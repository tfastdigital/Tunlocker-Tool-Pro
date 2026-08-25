using System;
using System.Linq;

namespace motoulocked.mtkclient2.library.xflash;

internal class MtkDaWriteDataService
{
	public static void PrepareData(byte[] da, int signatureLength, out ushort checksum, out byte[] buffer)
	{
		checksum = 0;
		buffer = da;
		if (buffer.Length % 2 != 0)
		{
			buffer = buffer.Concat(new byte[1]).ToArray();
		}
		for (int i = 0; i < buffer.Length; i = checked(i + 2))
		{
			checksum ^= BitConverter.ToUInt16(buffer, i);
		}
		if ((long)(checked((uint)buffer.Length) & 1) != 0L)
		{
			checksum ^= buffer.Last();
		}
	}
}
