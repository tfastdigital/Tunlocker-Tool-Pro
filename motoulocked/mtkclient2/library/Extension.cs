using System.Collections.Generic;
using System.IO;
using Microsoft.VisualBasic.CompilerServices;

namespace motoulocked.mtkclient2.library;


public  static class Extension
{
	public static void Write(this MemoryStream ms, byte[] buff)
	{
		ms.Write(buff, 0, buff.Length);
	}

	public static int Find(this byte[] haystack, byte[] needle, int start = 0)
	{
		int num = needle.Length;
		checked
		{
			int num2 = haystack.Length - num;
			int num3 = num2;
			for (int i = start; i <= num3; i++)
			{
				int j;
				for (j = 0; j < num && needle[j] == haystack[i + j]; j++)
				{
				}
				if (j == num)
				{
					return i;
				}
			}
			return -1;
		}
	}

	public static byte[][] Splitt(this byte[] input, byte[] separator)
	{
		List<byte[]> list = new List<byte[]>();
		checked
		{
			using (MemoryStream memoryStream = new MemoryStream(input))
			{
				while (memoryStream.Position + 1 < input.Length)
				{
					int num = Find(input, separator, (int)memoryStream.Position);
					byte[] array = ((num != -1) ? new byte[(int)(num - memoryStream.Position) - 1 + 1] : new byte[(int)(input.Length - memoryStream.Position) - 1 + 1]);
					if (array.Length != 0)
					{
						memoryStream.Read(array, 0, array.Length);
						list.Add(array);
					}
					memoryStream.Seek(separator.Length, SeekOrigin.Current);
				}
			}
			return list.ToArray();
		}
	}
}
