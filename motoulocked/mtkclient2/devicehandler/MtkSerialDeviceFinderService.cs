using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO.Ports;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;
using motoulocked.mtkclient2.library.xflash;

namespace motoulocked.mtkclient2.devicehandler;

internal class MtkSerialDeviceFinderService
{
	private class MtkId : IEquatable<MtkId>
	{
		protected  Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(MtkId);
			}
		}

		public ushort VendorId { get; set; }

		public ushort ProductId { get; set; }

		public MtkId(ushort VendorId, ushort ProductId)
		{
			this.VendorId = VendorId;
			this.ProductId = ProductId;
		}

		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("MtkId");
			stringBuilder.Append(" { ");
			if (PrintMembers(stringBuilder))
			{
				stringBuilder.Append(' ');
			}
			stringBuilder.Append('}');
			return stringBuilder.ToString();
		}

		protected  bool PrintMembers(StringBuilder builder)
		{
			RuntimeHelpers.EnsureSufficientExecutionStack();
			builder.Append("VendorId = ");
			builder.Append(VendorId.ToString());
			builder.Append(", ProductId = ");
			builder.Append(ProductId.ToString());
			return true;
		}

		public static bool operator !=(MtkId left, MtkId right)
		{
			return !(left == right);
		}

		public static bool operator ==(MtkId left, MtkId right)
		{
			if ((object)left != right)
			{
				return left?.Equals(right) ?? false;
			}
			return true;
		}

		public override int GetHashCode()
		{
			return checked((EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<ushort>.Default.GetHashCode(VendorId)) * -1521134295 + EqualityComparer<ushort>.Default.GetHashCode(ProductId));
		}

		public override bool Equals(object obj)
		{
			return Equals(obj as MtkId);
		}

		public  bool Equals(MtkId other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && (object)EqualityContract == other.EqualityContract && EqualityComparer<ushort>.Default.Equals(VendorId, other.VendorId))
				{
					return EqualityComparer<ushort>.Default.Equals(ProductId, other.ProductId);
				}
				return false;
			}
			return true;
		}

		bool IEquatable<MtkId>.Equals(MtkId other)
		{
			//ILSpy generated this explicit interface implementation from .override directive in Equals
			return this.Equals(other);
		}



		public  MtkId _get()
		{
			return new MtkId(this);
		}

		protected MtkId(MtkId original)
		{
			VendorId = original.VendorId;
			ProductId = original.ProductId;
		}

		public void Deconstruct(out ushort VendorId, out ushort ProductId)
		{
			VendorId = this.VendorId;
			ProductId = this.ProductId;
		}
	}

	private sealed class Native
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

		internal struct HDEVINFO
		{
			public IntPtr Pointer;
		}

		internal struct SP_DEVINFO_DATA
		{
			public int CbSize;

			public Guid ClassGuid;

			public int DevInst;

			public IntPtr Reserved;
		}

		private Native()
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

		public static bool SetupDiDestroyDeviceInfoList2(HDEVINFO deviceInfoSet)
		{
			bool result = default(bool);
			return result;
		}
	}

	private static readonly MtkId[] MTK_IDS;

	private static readonly Guid COM_GUID;

	private static Native.HDEVINFO InitEnumerator()
	{
		Guid classGuid = COM_GUID;
		Native.HDEVINFO result = Native.SetupDiGetClassDevs(ref classGuid, IntPtr.Zero, IntPtr.Zero, (Native.DIGCF)6);
		if (result.Pointer == new IntPtr(-1))
		{
			Console.WriteLine("Unable to initialize device enumerator");
		}
		return result;
	}

	private static Native.HDEVINFO InitEnumerator2()
	{
		Guid classGuid = COM_GUID;
		Native.HDEVINFO result = Native.SetupDiGetClassDevs(ref classGuid, IntPtr.Zero, IntPtr.Zero, (Native.DIGCF)6);
		if (result.Pointer == new IntPtr(-1))
		{
			Console.WriteLine("Unable to initialize device enumerator");
		}
		return result;
	}

	private static Native.SP_DEVINFO_DATA? InitDevinfoData(Native.HDEVINFO enumerator, int index)
	{
		Native.SP_DEVINFO_DATA deviceInfoData = default(Native.SP_DEVINFO_DATA);
		deviceInfoData.CbSize = Marshal.SizeOf(deviceInfoData);
		Native.SP_DEVINFO_DATA? result;
		if (!Native.SetupDiEnumDeviceInfo(enumerator, index, ref deviceInfoData))
		{
			int lastWin32Error = Marshal.GetLastWin32Error();
			if (lastWin32Error == 259)
			{
				result = null;
				goto IL_0055;
			}
			Console.WriteLine("Unable to initialize device info data: " + Conversions.ToString(lastWin32Error));
		}
		result = deviceInfoData;
		goto IL_0055;
		IL_0055:
		return result;
	}

	private static Native.SP_DEVINFO_DATA? InitDevinfoData2(Native.HDEVINFO enumerator, int index)
	{
		Native.SP_DEVINFO_DATA deviceInfoData = default(Native.SP_DEVINFO_DATA);
		deviceInfoData.CbSize = Marshal.SizeOf(deviceInfoData);
		Native.SP_DEVINFO_DATA? result;
		if (!Native.SetupDiEnumDeviceInfo(enumerator, index, ref deviceInfoData))
		{
			int lastWin32Error = Marshal.GetLastWin32Error();
			if (lastWin32Error == 259)
			{
				result = null;
				goto IL_0055;
			}
			Console.WriteLine("Unable to initialize device info data: " + Conversions.ToString(lastWin32Error));
		}
		result = deviceInfoData;
		goto IL_0055;
		IL_0055:
		return result;
	}

	private static string GetHardwareId(Native.HDEVINFO enumerator, Native.SP_DEVINFO_DATA devinfoData)
	{
		StringBuilder stringBuilder = new StringBuilder(1024);
		if (!Native.SetupDiGetDeviceRegistryProperty(enumerator, ref devinfoData, Native.SPDRP.SPDRP_HARDWAREID, out var _, stringBuilder, stringBuilder.Capacity, out var _))
		{
			return null;
		}
		return stringBuilder.ToString();
	}

	private static string GetHardwareId2(Native.HDEVINFO enumerator, Native.SP_DEVINFO_DATA devinfoData)
	{
		StringBuilder stringBuilder = new StringBuilder(1024);
		if (!Native.SetupDiGetDeviceRegistryProperty(enumerator, ref devinfoData, Native.SPDRP.SPDRP_HARDWAREID, out var _, stringBuilder, stringBuilder.Capacity, out var _))
		{
			return null;
		}
		return stringBuilder.ToString();
	}

	private static Tuple<ushort, ushort> ParseIds(string hardwareId)
	{
		Match match = new Regex("^USB\\\\VID_([0-9A-F]{4})&PID_([0-9A-F]{4})", RegexOptions.IgnoreCase).Match(hardwareId);
		if (!match.Success)
		{
			return null;
		}
		ushort item = ushort.Parse(match.Groups[1].Value, NumberStyles.AllowHexSpecifier);
		ushort item2 = ushort.Parse(match.Groups[2].Value, NumberStyles.AllowHexSpecifier);
		return new Tuple<ushort, ushort>(item, item2);
	}

	private static Tuple<ushort, ushort> ParseIds2(string hardwareId)
	{
		Match match = new Regex("^USB\\\\VID_([0-9A-F]{4})&PID_([0-9A-F]{4})", RegexOptions.IgnoreCase).Match(hardwareId);
		if (!match.Success)
		{
			return null;
		}
		ushort item = ushort.Parse(match.Groups[1].Value, NumberStyles.AllowHexSpecifier);
		ushort item2 = ushort.Parse(match.Groups[2].Value, NumberStyles.AllowHexSpecifier);
		return new Tuple<ushort, ushort>(item, item2);
	}

	private static string GetName(Native.HDEVINFO enumerator, Native.SP_DEVINFO_DATA devinfoData)
	{
		StringBuilder stringBuilder = new StringBuilder(1024);
		if (!Native.SetupDiGetDeviceRegistryProperty(enumerator, ref devinfoData, Native.SPDRP.SPDRP_FRIENDLYNAME, out var propertyRegDataType, stringBuilder, stringBuilder.Capacity, out var requiredSize) && !Native.SetupDiGetDeviceRegistryProperty(enumerator, ref devinfoData, Native.SPDRP.SPDRP_DEVICEDESC, out requiredSize, stringBuilder, stringBuilder.Capacity, out propertyRegDataType))
		{
			return null;
		}
		return stringBuilder.ToString();
	}

	private static string GetName2(Native.HDEVINFO enumerator, Native.SP_DEVINFO_DATA devinfoData)
	{
		StringBuilder stringBuilder = new StringBuilder(1024);
		if (!Native.SetupDiGetDeviceRegistryProperty(enumerator, ref devinfoData, Native.SPDRP.SPDRP_FRIENDLYNAME, out var propertyRegDataType, stringBuilder, stringBuilder.Capacity, out var requiredSize) && !Native.SetupDiGetDeviceRegistryProperty(enumerator, ref devinfoData, Native.SPDRP.SPDRP_DEVICEDESC, out requiredSize, stringBuilder, stringBuilder.Capacity, out propertyRegDataType))
		{
			return null;
		}
		return stringBuilder.ToString();
	}

	private static int? GetPortNumber(string deviceName)
	{
		Match match = new Regex("com(\\d+)").Match(deviceName.ToLower());
		return match.Success ? new int?(int.Parse(match.Value.Substring(3))) : null;
	}

	private static int? GetPortNumber2(string deviceName)
	{
		Match match = new Regex("com(\\d+)").Match(deviceName.ToLower());
		return match.Success ? new int?(int.Parse(match.Value.Substring(3))) : null;
	}

	private static bool IsMtkDevice(ushort vid, ushort pid)
	{
		MtkId[] mTK_IDS = MTK_IDS;
		int num = 0;
		while (true)
		{
			if (num < mTK_IDS.Length)
			{
				MtkId mtkId = mTK_IDS[num];
				if (vid == mtkId.VendorId && pid == mtkId.ProductId)
				{
					break;
				}
				num = checked(num + 1);
				continue;
			}
			return false;
		}
		return true;
	}

	private static bool IsMtkDevice2(ushort vid, ushort pid)
	{
		MtkId[] mTK_IDS = MTK_IDS;
		int num = 0;
		while (true)
		{
			if (num < mTK_IDS.Length)
			{
				MtkId mtkId = mTK_IDS[num];
				if (vid == mtkId.VendorId && pid == mtkId.ProductId)
				{
					break;
				}
				num = checked(num + 1);
				continue;
			}
			return false;
		}
		return true;
	}

	private static IMtkSerialDevice[] Find()
	{
		List<IMtkSerialDevice> list = new List<IMtkSerialDevice>();
		Native.HDEVINFO hDEVINFO = InitEnumerator();
		try
		{
			int num = 0;
			while (true)
			{
				Native.SP_DEVINFO_DATA? sP_DEVINFO_DATA = InitDevinfoData(hDEVINFO, num);
				num = checked(num + 1);
				if (!sP_DEVINFO_DATA.HasValue)
				{
					break;
				}
				string hardwareId = GetHardwareId(hDEVINFO, sP_DEVINFO_DATA.Value);
				if (hardwareId == null)
				{
					continue;
				}
				Tuple<ushort, ushort> tuple = ParseIds(hardwareId);
				if (tuple == null || !IsMtkDevice(tuple.Item1, tuple.Item2))
				{
					continue;
				}
				string name = GetName(hDEVINFO, sP_DEVINFO_DATA.Value);
				if (name != null)
				{
					int? portNumber = GetPortNumber(name);
					if (portNumber.HasValue)
					{
						SerialPort serialPort = new SerialPort("COM" + Conversions.ToString(portNumber.Value), 115200);
						serialPort.ReadTimeout = 120000;
						serialPort.WriteTimeout = 120000;
						list.Add(new MtkSerialDevice(serialPort));
					}
				}
			}
		}
		finally
		{
			Native.SetupDiDestroyDeviceInfoList(hDEVINFO);
		}
		return list.ToArray();
	}

	private static IMtkSerialDevice[] Find2()
	{
		List<IMtkSerialDevice> list = new List<IMtkSerialDevice>();
		Native.HDEVINFO hDEVINFO = InitEnumerator2();
		try
		{
			int num = 0;
			while (true)
			{
				Native.SP_DEVINFO_DATA? sP_DEVINFO_DATA = InitDevinfoData2(hDEVINFO, num);
				num = checked(num + 1);
				if (!sP_DEVINFO_DATA.HasValue)
				{
					break;
				}
				string hardwareId = GetHardwareId2(hDEVINFO, sP_DEVINFO_DATA.Value);
				if (hardwareId == null)
				{
					continue;
				}
				Tuple<ushort, ushort> tuple = ParseIds2(hardwareId);
				if (tuple == null || !IsMtkDevice2(tuple.Item1, tuple.Item2))
				{
					continue;
				}
				string name = GetName2(hDEVINFO, sP_DEVINFO_DATA.Value);
				if (name != null)
				{
					int? portNumber = GetPortNumber2(name);
					if (portNumber.HasValue)
					{
						SerialPort serialPort = new SerialPort("COM" + Conversions.ToString(portNumber.Value), 115200);
						serialPort.ReadTimeout = 120000;
						serialPort.WriteTimeout = 120000;
						list.Add(new MtkSerialDevice(serialPort));
					}
				}
			}
		}
		finally
		{
			Native.SetupDiDestroyDeviceInfoList2(hDEVINFO);
		}
		return list.ToArray();
	}

	public static Task<IMtkSerialDevice[]> FindAsync()
	{
		return Task.Run((Func<IMtkSerialDevice[]>)Find);
	}

	public static Task<IMtkSerialDevice[]> FindAsync2()
	{
		return Task.Run((Func<IMtkSerialDevice[]>)Find2);
	}

	static MtkSerialDeviceFinderService()
	{
		MTK_IDS = new MtkId[8]
		{
			new MtkId(3725, 3),
			new MtkId(3725, 24576),
			new MtkId(3725, 8192),
			new MtkId(3725, 8193),
			new MtkId(3725, 8447),
			new MtkId(4100, 24576),
			new MtkId(8921, 6),
			new MtkId(4046, 61952)
		};
		COM_GUID = Guid.Parse("{4D36E978-E325-11CE-BFC1-08002BE10318}");
	}
}
