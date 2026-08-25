namespace motoulocked.Force.Crc32;

internal class SafeProxy
{
	private readonly uint[] _table;

	internal SafeProxy()
	{
		_table = new uint[4096];
		Init(3988292384u);
	}

	protected void Init(uint poly)
	{
		uint[] table = _table;
		uint num = 0u;
		checked
		{
			do
			{
				uint num2 = num;
				int num3 = 0;
				do
				{
					int num4 = 0;
					do
					{
						num2 = (((unchecked((ulong)num2) & 1uL) == 1) ? (poly ^ (num2 >> 1)) : (num2 >> 1));
						num4++;
					}
					while (num4 <= 7);
					table[(int)(num3 * 256 + num)] = num2;
					num3++;
				}
				while (num3 <= 15);
				num++;
			}
			while (num <= 255);
		}
	}

	public uint Append(uint crc, byte[] input, int offset, int length)
	{
		uint num = 0xFFFFFFFFu ^ crc;
		uint[] table = _table;
		checked
		{
			while (length >= 16)
			{
				uint num2 = table[768 + input[offset + 12]] ^ table[512 + input[offset + 13]] ^ table[256 + input[offset + 14]] ^ table[input[offset + 15]];
				uint num3 = table[1792 + input[offset + 8]] ^ table[1536 + input[offset + 9]] ^ table[1280 + input[offset + 10]] ^ table[1024 + input[offset + 11]];
				uint num4 = table[2816 + input[offset + 4]] ^ table[2560 + input[offset + 5]] ^ table[2304 + input[offset + 6]] ^ table[2048 + input[offset + 7]];
				num = table[(int)(3840L + unchecked((long)((ulong)(num ^ input[offset]) & 0xFFuL)))] ^ table[(int)(3584L + unchecked((long)((ulong)((num >> 8) ^ input[checked(offset + 1)]) & 0xFFuL)))] ^ table[(int)(3328L + unchecked((long)((ulong)((num >> 16) ^ input[checked(offset + 2)]) & 0xFFuL)))] ^ table[(int)(3072L + unchecked((long)((ulong)((num >> 24) ^ input[checked(offset + 3)]) & 0xFFuL)))] ^ num4 ^ num3 ^ num2;
				offset += 16;
				length -= 16;
			}
			for (length--; length >= 0; length--)
			{
				num = table[(int)(unchecked((long)(num ^ input[offset])) & 0xFFL)] ^ (num >> 8);
				offset++;
			}
			return num ^ 0xFFFFFFFFu;
		}
	}
}
