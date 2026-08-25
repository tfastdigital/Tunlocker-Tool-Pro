using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace motoulocked.mtkclient2.library;

internal class MtkDaxPartitionChecksumService
{
	public static int Calculate(byte[] payload)
	{
		return Convert.ToInt32(Math.Truncate(new decimal(((IEnumerable<byte>)payload).Sum((Func<byte, long>)([SpecialName] (byte x) => x))))) & 0xFFFF;
	}
}
