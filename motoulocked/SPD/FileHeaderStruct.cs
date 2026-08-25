using System.Runtime.InteropServices;

namespace motoulocked.SPD;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
internal struct FileHeaderStruct
{
	public uint length;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
	public byte[] partitionName;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
	public byte[] fileName;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
	public byte[] szFileName;

	public uint hiPartitionSize;

	public uint entahSize1;

	public uint entahSize2;

	public uint hiDataOffset;

	public uint loPartitionSize;

	public ushort nFileFlag;

	public ushort nCheckFlag;

	public uint loDataOffset;

	public uint dwCanOmitFlag;

	public uint dwAddrNum;

	public uint dwAddr;

	public uint dwReserved;

	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 996)]
	public string reservedData;
}
