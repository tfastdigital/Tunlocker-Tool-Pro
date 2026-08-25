using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;
using motoulocked.mtkclient2.library.xflash;

namespace motoulocked.mtkclient2.devicehandler;

internal class MtkUsbDevice : IDisposable, IMtkUsbDevice, IMtkDevice
{
	private static int TIMEOUT;

	private Native.LibUsbContext m_context;

	private Native.LibUsbDevice? m_device;

	private Native.LibUsbDeviceDescriptor m_descriptor;

	private List<byte> m_claimedInterfaces;

	private Native.LibUsbDeviceHandle? m_handle;

	private Native.LibUsbEndpointDescriptor? m_readEp;

	private Native.LibUsbEndpointDescriptor? m_writeEp;

	public MtkUsbDevice(Native.LibUsbContext context, Native.LibUsbDevice device, Native.LibUsbDeviceDescriptor descriptor)
	{
		m_context = context;
		m_device = device;
		m_descriptor = descriptor;
		m_claimedInterfaces = new List<byte>();
	}

	private Native.LibUsbConfigDescriptor[] GetConfigurations()
	{
		if (m_device.HasValue)
		{
			Native.LibUsbConfigDescriptor[] array = new Native.LibUsbConfigDescriptor[checked(m_descriptor.NumConfigurations - 1 + 1)];
			byte b = 0;
			while ((uint)b < (uint)m_descriptor.NumConfigurations)
			{
				Native.Ptr<Native.LibUsbConfigDescriptor> config = default(Native.Ptr<Native.LibUsbConfigDescriptor>);
				int num = Native.LibUsb1.libusb_get_config_descriptor(m_device.Value, b, out config);
				if (num == 0)
				{
					array[b] = config.Get();
					b = checked((byte)(b + 1));
				}
				else
				{
					Console.WriteLine("Unable to get device configuration descriptor: " + Conversions.ToString(num));
				}
			}
			return array;
		}
		throw new InvalidOperationException("Already disposed");
	}

	private Native.LibUsbInterfaceDescriptor[] GetInterfaces(Native.LibUsbConfigDescriptor configuration)
	{
		List<Native.LibUsbInterfaceDescriptor> list = new List<Native.LibUsbInterfaceDescriptor>();
		Native.LibUsbInterface[] array = configuration.Interface.Get(configuration.NumInterfaces);
		checked
		{
			int num = array.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				Native.LibUsbInterface libUsbInterface = array[i];
				Native.Ptr<Native.LibUsbInterfaceDescriptor> altSetting = libUsbInterface.AltSetting;
				Native.LibUsbInterfaceDescriptor[] collection = altSetting.Get(libUsbInterface.NumAltSetting);
				list.AddRange(collection);
			}
			return list.ToArray();
		}
	}

	private void Connect()
	{
		if (!m_device.HasValue)
		{
			throw new InvalidOperationException("Already disposed");
		}
		if (!m_handle.HasValue)
		{
			Native.LibUsbConfigDescriptor[] configurations = GetConfigurations();
			Native.LibUsbDeviceHandle handle = default(Native.LibUsbDeviceHandle);
			int num = Native.LibUsb1.libusb_open(m_device.Value,  handle);
			Console.WriteLine("Native LibUSB Res : " + Conversions.ToString(num));
			if (num == 0)
			{
				Native.LibUsbInterfaceDescriptor libUsbInterfaceDescriptor = (from x in GetInterfaces(configurations[0])
					where x.InterfaceClass == 10
					select (x)).FirstOrDefault();
				if (libUsbInterfaceDescriptor.InterfaceClass == 0)
				{
					Native.LibUsb1.libusb_close(handle);
					Console.WriteLine("DATA interface not found");
				}
				int num2 = Native.LibUsb1.libusb_claim_interface(handle, 0);
				if (num2 == 0)
				{
					m_claimedInterfaces.Add(0);
					if (libUsbInterfaceDescriptor.InterfaceNumber != 0)
					{
						num2 = Native.LibUsb1.libusb_claim_interface(handle, libUsbInterfaceDescriptor.InterfaceNumber);
						if (num2 != 0)
						{
							Native.LibUsb1.libusb_close(handle);
							Console.WriteLine("Unable to claim DATA interface: " + Conversions.ToString(num2));
						}
						m_claimedInterfaces.Add(libUsbInterfaceDescriptor.InterfaceNumber);
					}
					Native.LibUsbEndpointDescriptor[] source = libUsbInterfaceDescriptor.Endpoint.Get(libUsbInterfaceDescriptor.NumEndpoints);
					m_writeEp = (from x in ((IEnumerable<Native.LibUsbEndpointDescriptor>)source).Select((Func<Native.LibUsbEndpointDescriptor, Native.LibUsbEndpointDescriptor?>)([SpecialName] (Native.LibUsbEndpointDescriptor x) => x))
						where x.HasValue && (x.Value.EndpointAddress & 0x80) == 0
						select (x)).FirstOrDefault();
					if (m_writeEp.HasValue)
					{
						m_readEp = (from x in ((IEnumerable<Native.LibUsbEndpointDescriptor>)source).Select((Func<Native.LibUsbEndpointDescriptor, Native.LibUsbEndpointDescriptor?>)([SpecialName] (Native.LibUsbEndpointDescriptor x) => x))
							where x.HasValue && (x.Value.EndpointAddress & 0x80) == 128
							select (x)).FirstOrDefault();
						if (!m_readEp.HasValue)
						{
							Native.LibUsb1.libusb_close(handle);
							Console.WriteLine("Read endpoint not found");
						}
						m_handle = handle;
						return;
					}
					Native.LibUsb1.libusb_close(handle);
					Console.WriteLine("Write endpoint not found");
				}
				Native.LibUsb1.libusb_close(handle);
				Console.WriteLine("Unable to claim interface 0: " + Conversions.ToString(num2));
			}
			Console.WriteLine("Unable to open libusb device: " + Conversions.ToString(num));
		}
		throw new InvalidOperationException("Already connected");
	}

	public Task ConnectAsync()
	{
		return Task.Run((Action)Connect);
	}

	Task IMtkDevice.ConnectAsync()
	{
		//ILSpy generated this explicit interface implementation from .override directive in ConnectAsync
		return this.ConnectAsync();
	}

	private int Read(byte[] buff, int offset, int len)
	{
		if (m_handle.HasValue && m_readEp.HasValue)
		{
			byte[] array = new byte[checked(len - 1 + 1)];
			int transferred = 0;
			int num = Native.LibUsb1.libusb_bulk_transfer(m_handle.Value, m_readEp.Value.EndpointAddress, array, len, transferred, TIMEOUT);
			if (num == -7)
			{
				throw new TimeoutException();
			}
			if (num < 0)
			{
				Console.WriteLine("Error sending bulk transfer: " + Conversions.ToString(num));
			}
			Array.Copy(array, 0, buff, offset, transferred);
			return transferred;
		}
		throw new InvalidOperationException("Not connected");
	}

	private byte[] ReadCustom(byte[] buff, int offset, int len)
	{
		if (m_handle.HasValue && m_readEp.HasValue)
		{
			byte[] array = new byte[checked(len - 1 + 1)];
			int transferred = 0;
			int num = Native.LibUsb1.libusb_bulk_transfer(m_handle.Value, m_readEp.Value.EndpointAddress, array, len, transferred, TIMEOUT);
			if (num == -7)
			{
				throw new TimeoutException();
			}
			if (num < 0)
			{
				Console.WriteLine("Error sending bulk transfer: " + Conversions.ToString(num));
			}
			Array.Copy(array, 0, buff, offset, transferred);
			return buff;
		}
		throw new InvalidOperationException("Not connected");
	}

	public Task<int> ReadAsync(byte[] buff, int offset, int len, CancellationToken cancellationToken)
	{
		return Task.Run([SpecialName] () => Read(buff, offset, len));
	}

	Task<int> IMtkDevice.ReadAsync(byte[] buff, int offset, int len, CancellationToken cancellationToken)
	{
		//ILSpy generated this explicit interface implementation from .override directive in ReadAsync
		return this.ReadAsync(buff, offset, len, cancellationToken);
	}

	public Task<byte[]> ReadCustomAsync(CancellationToken cancellationToken, int len)
	{
		byte[] buff = new byte[checked(len - 1 + 1)];
		return Task.Run([SpecialName] () => ReadCustom(buff, 0, len));
	}

	Task<byte[]> IMtkDevice.ReadCustomAsync(CancellationToken cancellationToken, int len)
	{
		//ILSpy generated this explicit interface implementation from .override directive in ReadCustomAsync
		return this.ReadCustomAsync(cancellationToken, len);
	}

	private void Write(byte[] buff, int offset, int len)
	{
		if (m_handle.HasValue && m_writeEp.HasValue)
		{
			byte[] array = new byte[checked(len - 1 + 1)];
			Array.Copy(buff, offset, array, 0, len);
			int transferred = 0;
			int num = Native.LibUsb1.libusb_bulk_transfer(m_handle.Value, m_writeEp.Value.EndpointAddress, array, len, transferred, TIMEOUT);
			if (num == -7)
			{
				throw new TimeoutException();
			}
			if (num < 0)
			{
				Console.WriteLine("Error sending bulk transfer: " + Conversions.ToString(num));
			}
			return;
		}
		throw new InvalidOperationException("Not connected");
	}

	public Task WriteAsync(byte[] buff, int offset, int len, CancellationToken cancellationToken)
	{
		return Task.Run([SpecialName] () =>
		{
			Write(buff, offset, len);
		});
	}

	Task IMtkDevice.WriteAsync(byte[] buff, int offset, int len, CancellationToken cancellationToken)
	{
		//ILSpy generated this explicit interface implementation from .override directive in WriteAsync
		return this.WriteAsync(buff, offset, len, cancellationToken);
	}

	private int SendControlMessage(byte requestType, byte request, ushort value, ushort index, byte[] data)
	{
		if (m_handle.HasValue)
		{
			int num = Native.LibUsb1.libusb_control_transfer(m_handle.Value, requestType, request, value, index, data, checked((ushort)data.Length), TIMEOUT);
			if (num == -7)
			{
				throw new TimeoutException();
			}
			if (num < 0)
			{
				Console.WriteLine("Error sending control transfer: " + Conversions.ToString(num));
			}
			return num;
		}
		throw new InvalidOperationException("Not connected");
	}

	public Task<int> SendControlMessageAsync(byte requestType, byte request, ushort value, ushort index, byte[] data, CancellationToken cancellationToken)
	{
		return Task.Run([SpecialName] () => SendControlMessage(requestType, request, value, index, data));
	}

	Task<int> IMtkUsbDevice.SendControlMessageAsync(byte requestType, byte request, ushort value, ushort index, byte[] data, CancellationToken cancellationToken)
	{
		//ILSpy generated this explicit interface implementation from .override directive in SendControlMessageAsync
		return this.SendControlMessageAsync(requestType, request, value, index, data, cancellationToken);
	}

	public Task ResetAsync()
	{
		if (!m_handle.HasValue)
		{
			throw new InvalidOperationException("Not connected");
		}
		ReleaseInterfaces();
		Native.LibUsb1.libusb_reset_device(m_handle.Value);
		return Task.CompletedTask;
	}

	Task IMtkUsbDevice.ResetAsync()
	{
		//ILSpy generated this explicit interface implementation from .override directive in ResetAsync
		return this.ResetAsync();
	}

	private void ReleaseInterfaces()
	{
		if (!m_handle.HasValue)
		{
			throw new InvalidOperationException("Not connected");
		}
		foreach (byte claimedInterface in m_claimedInterfaces)
		{
			Native.LibUsb1.libusb_release_interface(m_handle.Value, claimedInterface);
		}
		m_readEp = null;
		m_writeEp = null;
		m_claimedInterfaces.Clear();
	}

	public void Dispose()
	{
		if (m_device.HasValue)
		{
			Native.LibUsb1.libusb_unref_device(m_device.Value);
			m_device = null;
		}
		if (m_handle.HasValue)
		{
			ReleaseInterfaces();
			Native.LibUsb1.libusb_close(m_handle.Value);
			m_handle = null;
		}
	}

	void IDisposable.Dispose()
	{
		//ILSpy generated this explicit interface implementation from .override directive in Dispose
		this.Dispose();
	}

	public override string ToString()
	{
		return $"LibUsb_{m_descriptor.IdVendor:X4}_{m_descriptor.IdProduct:X4}";
	}

	static MtkUsbDevice()
	{
		TIMEOUT = 120000;
	}
}
