using System;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace motoulocked.mtkclient2.devicehandler;

[StandardModule]
internal sealed class Native
{
	internal enum DIGCF
	{
		DIGCF_DEFAULT = 1,
		DIGCF_PRESENT = 2,
		DIGCF_ALLCLASSES = 4,
		DIGCF_PROFILE = 8,
		DIGCF_DEVICEINTERFACE = 0x10
	}

	internal enum SPDRP
	{
		SPDRP_DEVICEDESC,
		SPDRP_HARDWAREID,
		SPDRP_COMPATIBLEIDS,
		SPDRP_UNUSED0,
		SPDRP_SERVICE,
		SPDRP_UNUSED1,
		SPDRP_UNUSED2,
		SPDRP_CLASS,
		SPDRP_CLASSGUID,
		SPDRP_DRIVER,
		SPDRP_CONFIGFLAGS,
		SPDRP_MFG,
		SPDRP_FRIENDLYNAME,
		SPDRP_LOCATION_INFORMATION,
		SPDRP_PHYSICAL_DEVICE_OBJECT_NAME,
		SPDRP_CAPABILITIES,
		SPDRP_UI_NUMBER,
		SPDRP_UPPERFILTERS,
		SPDRP_LOWERFILTERS,
		SPDRP_BUSTYPEGUID,
		SPDRP_LEGACYBUSTYPE,
		SPDRP_BUSNUMBER,
		SPDRP_ENUMERATOR_NAME,
		SPDRP_SECURITY,
		SPDRP_SECURITY_SDS,
		SPDRP_DEVTYPE,
		SPDRP_EXCLUSIVE,
		SPDRP_CHARACTERISTICS,
		SPDRP_ADDRESS,
		SPDRP_UI_NUMBER_DESC_FORMAT,
		SPDRP_DEVICE_POWER_DATA,
		SPDRP_REMOVAL_POLICY,
		SPDRP_REMOVAL_POLICY_HW_DEFAULT,
		SPDRP_REMOVAL_POLICY_OVERRIDE,
		SPDRP_INSTALL_STATE,
		SPDRP_LOCATION_PATHS
	}

	internal struct Ptr<T>
	{
		public IntPtr Pointer;

		public T Get()
		{
			if (Pointer == IntPtr.Zero)
			{
				throw new ArgumentException("Pointer is null");
			}
			return Marshal.PtrToStructure<T>(Pointer);
		}

		public T[] Get(int count)
		{
			checked
			{
				T[] array = new T[count - 1 + 1];
				int num = Marshal.SizeOf<T>();
				int num2 = count - 1;
				for (int i = 0; i <= num2; i++)
				{
					IntPtr ptr = new IntPtr(Pointer.ToInt64() + i * num);
					array[i] = Marshal.PtrToStructure<T>(ptr);
				}
				return array;
			}
		}

		internal static bool Lhyh()
		{
			return true;
		}

		internal static object Vhyb()
		{
			return null;
		}
	}

	internal struct HDEVINFO
	{
		public IntPtr Value;

		public bool IsInvalid()
		{
			return Value == new IntPtr(-1);
		}
	}

	internal struct SP_DEVINFO_DATA
	{
		public int CbSize;

		public Guid ClassGuid;

		public int DevInst;

		public IntPtr Reserved;
	}

	internal struct LibUsbContext
	{
		public IntPtr Value;
	}

	internal struct LibUsbDevice
	{
		public IntPtr Value;
	}

	internal struct LibUsbDeviceHandle
	{
		public IntPtr Value;
	}

	internal struct LibUsbDeviceDescriptor
	{
		public byte Length;

		public byte DescriptorType;

		public ushort USB;

		public byte DeviceClass;

		public byte DeviceSubClass;

		public byte DeviceProtocol;

		public byte MaxPacketSize0;

		public ushort IdVendor;

		public ushort IdProduct;

		public ushort Device;

		public byte Manufacturer;

		public byte Product;

		public byte SerialNumber;

		public byte NumConfigurations;
	}

	internal struct LibUsbEndpointDescriptor
	{
		public byte Length;

		public byte DescriptorType;

		public byte EndpointAddress;

		public byte Attributes;

		public ushort MaxPacketSize;

		public byte Interval;

		public byte Refresh;

		public byte SynchAddress;

		public IntPtr Extra;

		public int ExtraLength;
	}

	internal struct LibUsbInterfaceDescriptor
	{
		public byte Length;

		public byte DescriptorType;

		public byte InterfaceNumber;

		public byte AlternateSetting;

		public byte NumEndpoints;

		public byte InterfaceClass;

		public byte InterfaceSubClass;

		public byte InterfaceProtocol;

		public byte Interface;

		public Ptr<LibUsbEndpointDescriptor> Endpoint;

		public IntPtr Extra;

		public int ExtraLength;
	}

	internal struct LibUsbInterface
	{
		public Ptr<LibUsbInterfaceDescriptor> AltSetting;

		public int NumAltSetting;
	}

	internal struct LibUsbConfigDescriptor
	{
		public byte Length;

		public byte DescriptorType;

		public ushort TotalLength;

		public byte NumInterfaces;

		public byte ConfigurationValue;

		public byte Configuration;

		public byte Attributes;

		public byte MaxPower;

		public Ptr<LibUsbInterface> Interface;

		public IntPtr Extra;

		public int ExtraLength;
	}

	internal sealed class SetupApi
	{
		private SetupApi()
		{
		}

		[DllImport("setupapi.dll", SetLastError = true)]
		public static extern HDEVINFO SetupDiGetClassDevs(ref Guid classGuid, IntPtr enumerator, IntPtr hwndParent, DIGCF flags);

		[DllImport("setupapi.dll", SetLastError = true)]
		public static extern bool SetupDiEnumDeviceInfo(HDEVINFO deviceInfoSet, int memberIndex, ref SP_DEVINFO_DATA deviceInfoData);

		[DllImport("setupapi.dll", SetLastError = true)]
		public static extern bool SetupDiGetDeviceRegistryProperty(HDEVINFO deviceInfoSet, ref SP_DEVINFO_DATA deviceInfoData, SPDRP property, out int propertyRegDataType, StringBuilder propertyBuffer, int propertyBufferSize, out int requiredSize);

		[DllImport("setupapi.dll", SetLastError = true)]
		public static extern bool SetupDiDestroyDeviceInfoList(HDEVINFO deviceInfoSet);
	}

	internal sealed class LibUsb1
	{
		private LibUsb1()
		{
		}

		[DllImport("\\mtk\\ronix_tmp\\usb_filter32.dll", EntryPoint = "libusb_init")]
		private static extern int libusb_init_1(ref LibUsbContext context);

		[DllImport("\\mtk\\ronix_tmp\\usb_filter.dll", EntryPoint = "libusb_init")]
		private static extern int libusb_init_2(ref LibUsbContext context);

		public static int libusb_init( LibUsbContext context)
		{
			if (Environment.Is64BitProcess)
			{
				return libusb_init_2(ref context);
			}
			return libusb_init_1(ref context);
		}

		[DllImport("\\mtk\\ronix_tmp\\usb_filter32.dll", EntryPoint = "libusb_set_option")]
		private static extern int libusb_set_option_1(LibUsbContext context, int option);

		[DllImport("\\mtk\\ronix_tmp\\usb_filter.dll", EntryPoint = "libusb_set_option")]
		private static extern int libusb_set_option_2(LibUsbContext context, int option);

		public static int libusb_set_option(LibUsbContext context, int option)
		{
			if (!Environment.Is64BitProcess)
			{
				return libusb_set_option_1(context, option);
			}
			return libusb_set_option_2(context, option);
		}

		[DllImport("\\mtk\\ronix_tmp\\usb_filter32.dll", EntryPoint = "libusb_exit")]
		private static extern int libusb_exit_1(LibUsbContext context);

		[DllImport("\\mtk\\ronix_tmp\\usb_filter.dll", EntryPoint = "libusb_exit")]
		private static extern int libusb_exit_2(LibUsbContext context);

		public static int libusb_exit(LibUsbContext context)
		{
			if (Environment.Is64BitProcess)
			{
				return libusb_exit_2(context);
			}
			return libusb_exit_1(context);
		}

		[DllImport("\\mtk\\ronix_tmp\\usb_filter32.dll", EntryPoint = "libusb_get_device_list")]
		private static extern IntPtr libusb_get_device_list_1(LibUsbContext context, ref IntPtr list);

		[DllImport("\\mtk\\ronix_tmp\\usb_filter.dll", EntryPoint = "libusb_get_device_list")]
		private static extern IntPtr libusb_get_device_list_2(LibUsbContext context, ref IntPtr list);

		public static IntPtr libusb_get_device_list(LibUsbContext context, out Ptr<LibUsbDevice> list)
		{
			IntPtr list2 = default(IntPtr);
			IntPtr result = (Environment.Is64BitProcess ? libusb_get_device_list_2(context, ref list2) : libusb_get_device_list_1(context, ref list2));
			list = new Ptr<LibUsbDevice>
			{
				Pointer = list2
			};
			return result;
		}

		[DllImport("\\mtk\\ronix_tmp\\usb_filter32.dll", EntryPoint = "libusb_free_device_list")]
		private static extern IntPtr libusb_free_device_list_1(IntPtr list, int count);

		[DllImport("\\mtk\\ronix_tmp\\usb_filter.dll", EntryPoint = "libusb_free_device_list")]
		private static extern IntPtr libusb_free_device_list_2(IntPtr list, int count);

		public static IntPtr libusb_free_device_list(Ptr<LibUsbDevice> list, int count)
		{
			if (!Environment.Is64BitProcess)
			{
				return libusb_free_device_list_1(list.Pointer, count);
			}
			return libusb_free_device_list_2(list.Pointer, count);
		}

		[DllImport("\\mtk\\ronix_tmp\\usb_filter32.dll", EntryPoint = "libusb_unref_device")]
		private static extern void libusb_unref_device_1(LibUsbDevice device);

		[DllImport("\\mtk\\ronix_tmp\\usb_filter.dll", EntryPoint = "libusb_unref_device")]
		private static extern void libusb_unref_device_2(LibUsbDevice device);

		public static void libusb_unref_device(LibUsbDevice device)
		{
			if (Environment.Is64BitProcess)
			{
				libusb_unref_device_2(device);
			}
			else
			{
				libusb_unref_device_1(device);
			}
		}

		[DllImport("\\mtk\\ronix_tmp\\usb_filter32.dll", EntryPoint = "libusb_get_device_descriptor")]
		private static extern int libusb_get_device_descriptor_1(LibUsbDevice device, ref LibUsbDeviceDescriptor descriptor);

		[DllImport("\\mtk\\ronix_tmp\\usb_filter.dll", EntryPoint = "libusb_get_device_descriptor")]
		private static extern int libusb_get_device_descriptor_2(LibUsbDevice device, ref LibUsbDeviceDescriptor descriptor);

		public static int libusb_get_device_descriptor(LibUsbDevice device,  LibUsbDeviceDescriptor descriptor)
		{
			if (!Environment.Is64BitProcess)
			{
				return libusb_get_device_descriptor_1(device, ref descriptor);
			}
			return libusb_get_device_descriptor_2(device, ref descriptor);
		}

		[DllImport("\\mtk\\ronix_tmp\\usb_filter32.dll", EntryPoint = "libusb_get_config_descriptor")]
		private static extern int libusb_get_config_descriptor_1(LibUsbDevice device, byte index, ref IntPtr config);

		[DllImport("\\mtk\\ronix_tmp\\usb_filter.dll", EntryPoint = "libusb_get_config_descriptor")]
		private static extern int libusb_get_config_descriptor_2(LibUsbDevice device, byte index, ref IntPtr config);

		public static int libusb_get_config_descriptor(LibUsbDevice device, byte index, out Ptr<LibUsbConfigDescriptor> config)
		{
			IntPtr config2 = default(IntPtr);
			int result = ((!Environment.Is64BitProcess) ? libusb_get_config_descriptor_1(device, index, ref config2) : libusb_get_config_descriptor_2(device, index, ref config2));
			config = new Ptr<LibUsbConfigDescriptor>
			{
				Pointer = config2
			};
			return result;
		}

		[DllImport("\\mtk\\ronix_tmp\\usb_filter32.dll", EntryPoint = "libusb_open")]
		private static extern int libusb_open_1(LibUsbDevice device, ref LibUsbDeviceHandle handle);

		[DllImport("\\mtk\\ronix_tmp\\usb_filter.dll", EntryPoint = "libusb_open")]
		private static extern int libusb_open_2(LibUsbDevice device, ref LibUsbDeviceHandle handle);

		public static int libusb_open(LibUsbDevice device,  LibUsbDeviceHandle handle)
		{
			

            if (Environment.Is64BitProcess)
			{
				return libusb_open_2(device, ref handle);
			}
			return libusb_open_1(device, ref handle);
		}

		[DllImport("\\mtk\\ronix_tmp\\usb_filter32.dll", EntryPoint = "libusb_close")]
		private static extern int libusb_close_1(LibUsbDeviceHandle handle);

		[DllImport("\\mtk\\ronix_tmp\\usb_filter.dll", EntryPoint = "libusb_close")]
		private static extern int libusb_close_2(LibUsbDeviceHandle handle);

		public static int libusb_close(LibUsbDeviceHandle handle)
		{
			if (Environment.Is64BitProcess)
			{
				return libusb_close_2(handle);
			}
			return libusb_close_1(handle);
		}

		[DllImport("\\mtk\\ronix_tmp\\usb_filter32.dll", EntryPoint = "libusb_claim_interface")]
		private static extern int libusb_claim_interface_1(LibUsbDeviceHandle handle, int interfaceNumber);

		[DllImport("\\mtk\\ronix_tmp\\usb_filter.dll", EntryPoint = "libusb_claim_interface")]
		private static extern int libusb_claim_interface_2(LibUsbDeviceHandle handle, int interfaceNumber);

		public static int libusb_claim_interface(LibUsbDeviceHandle handle, int interfaceNumber)
		{
			if (Environment.Is64BitProcess)
			{
				return libusb_claim_interface_2(handle, interfaceNumber);
			}
			return libusb_claim_interface_1(handle, interfaceNumber);
		}

		[DllImport("\\mtk\\ronix_tmp\\usb_filter32.dll", EntryPoint = "libusb_release_interface")]
		private static extern int libusb_release_interface_1(LibUsbDeviceHandle handle, int interfaceNumber);

		[DllImport("\\mtk\\ronix_tmp\\usb_filter.dll", EntryPoint = "libusb_release_interface")]
		private static extern int libusb_release_interface_2(LibUsbDeviceHandle handle, int interfaceNumber);

		public static int libusb_release_interface(LibUsbDeviceHandle handle, int interfaceNumber)
		{
			if (!Environment.Is64BitProcess)
			{
				return libusb_release_interface_1(handle, interfaceNumber);
			}
			return libusb_release_interface_2(handle, interfaceNumber);
		}

		[DllImport("\\mtk\\ronix_tmp\\usb_filter32.dll", EntryPoint = "libusb_reset_device")]
		private static extern int libusb_reset_device_1(LibUsbDeviceHandle handle);

		[DllImport("\\mtk\\ronix_tmp\\usb_filter.dll", EntryPoint = "libusb_reset_device")]
		private static extern int libusb_reset_device_2(LibUsbDeviceHandle handle);

		public static int libusb_reset_device(LibUsbDeviceHandle handle)
		{
			if (!Environment.Is64BitProcess)
			{
				return libusb_reset_device_1(handle);
			}
			return libusb_reset_device_2(handle);
		}

		[DllImport("\\mtk\\ronix_tmp\\usb_filter32.dll", EntryPoint = "libusb_control_transfer")]
		private static extern int libusb_control_transfer_1(LibUsbDeviceHandle handle, byte requestType, byte request, ushort value, ushort index, [Out] byte[] data, ushort dataLength, int timeout);

		[DllImport("\\mtk\\ronix_tmp\\usb_filter.dll", EntryPoint = "libusb_control_transfer")]
		private static extern int libusb_control_transfer_2(LibUsbDeviceHandle handle, byte requestType, byte request, ushort value, ushort index, [Out] byte[] data, ushort dataLength, int timeout);

		public static int libusb_control_transfer(LibUsbDeviceHandle handle, byte requestType, byte request, ushort value, ushort index, [Out] byte[] data, ushort dataLength, int timeout)
		{
			if (Environment.Is64BitProcess)
			{
				return libusb_control_transfer_2(handle, requestType, request, value, index, data, dataLength, timeout);
			}
			return libusb_control_transfer_1(handle, requestType, request, value, index, data, dataLength, timeout);
		}

		[DllImport("\\mtk\\ronix_tmp\\usb_filter32.dll", EntryPoint = "libusb_bulk_transfer")]
		private static extern int libusb_bulk_transfer_1(LibUsbDeviceHandle handle, byte endpoint, byte[] data, int length, ref int transferred, int timeout);

		[DllImport("\\mtk\\ronix_tmp\\usb_filter.dll", EntryPoint = "libusb_bulk_transfer")]
		private static extern int libusb_bulk_transfer_2(LibUsbDeviceHandle handle, byte endpoint, byte[] data, int length, ref int transferred, int timeout);

		public static int libusb_bulk_transfer(LibUsbDeviceHandle handle, byte endpoint, [Out] byte[] data, int length,  int transferred, int timeout)
		{
			if (!Environment.Is64BitProcess)
			{
				return libusb_bulk_transfer_1(handle, endpoint, data, length, ref transferred, timeout);
			}
			return libusb_bulk_transfer_2(handle, endpoint, data, length, ref transferred, timeout);
		}
	}
}
