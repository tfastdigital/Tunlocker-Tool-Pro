using System.Runtime.InteropServices;

namespace motoulocked.SPD;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
internal struct PacHeaderStruct
{
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 44)]
	public byte[] szVersion;

	public uint dwHiSize;

	public uint dwLoSize;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
	public byte[] productName;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
	public byte[] firmwareName;

	public uint partitionCount;

	public uint partitionsListStart;

	public uint dwMode;

	public uint dwFlashType;

	public uint dwNandStrategy;

	public uint dwIsNvBackup;

	public uint dwNandPageType;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 996)]
	public byte[] szPrdAlias;

	public uint dwOmaDmProductFlag;

	public uint dwIsOmaDM;

	public uint dwIsPreload;

	public uint dwReserved;

	public uint dwMagic;

	public ushort wCRC1;

	public ushort wCRC2;

	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 60)]
	public string reservedData;
}
