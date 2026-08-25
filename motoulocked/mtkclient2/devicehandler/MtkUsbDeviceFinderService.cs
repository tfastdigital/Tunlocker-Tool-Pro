using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;
using motoulocked.mtkclient2.library.xflash;
using static motoulocked.mtkclient2.devicehandler.Native;

namespace motoulocked.mtkclient2.devicehandler;

internal class MtkUsbDeviceFinderService
{
	private static Native.LibUsbContext? m_context;

	static MtkUsbDeviceFinderService()
	{
        LibUsbContext context = new LibUsbContext();

        if (Native.LibUsb1.libusb_init(  context) != 0)
		{
			gui.Richlog("Unable to init libusb", Color.Black, isBold: false, NextLine: true);
			return;
		}
		int num = Native.LibUsb1.libusb_set_option(context, 1);
		if (num != 0)
		{
			gui.Richlog("Unable to enable usbdk: " + Conversions.ToString(num), Color.Black, isBold: false, NextLine: true);
		}
		else
		{
			m_context = context;
		}
	}

	private static Native.LibUsbDeviceDescriptor? GetDescriptor(Native.LibUsbDevice device)
	{
		Native.LibUsbDeviceDescriptor descriptor = new Native.LibUsbDeviceDescriptor();
		return (Native.LibUsb1.libusb_get_device_descriptor(device,  descriptor) == 0) ? new Native.LibUsbDeviceDescriptor?(descriptor) : null;
	}

	private static IMtkUsbDevice[] Find()
	{
		if (!m_context.HasValue)
		{
			Console.WriteLine("Failed to initialize libusb");
		}
		Native.Ptr<Native.LibUsbDevice> list = default(Native.Ptr<Native.LibUsbDevice>);
		int count = Native.LibUsb1.libusb_get_device_list(m_context.Value, out list).ToInt32();
		checked
		{
			try
			{
				Native.LibUsbDevice[] array = list.Get(count);
				List<MtkUsbDevice> list2 = new List<MtkUsbDevice>();
				int num = array.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					Native.LibUsbDeviceDescriptor? descriptor = GetDescriptor(array[i]);
					if (descriptor.HasValue && descriptor.Value.IdVendor == 3725 && descriptor.Value.IdProduct == 3)
					{
						list2.Add(new MtkUsbDevice(m_context.Value, array[i], descriptor.Value));
					}
				}
				return list2.ToArray();
			}
			finally
			{
				Native.LibUsb1.libusb_free_device_list(list, 0);
			}
		}
	}

	public static Task<IMtkUsbDevice[]> FindAsync()
	{
		return Task.Run((Func<IMtkUsbDevice[]>)Find);
	}
}
