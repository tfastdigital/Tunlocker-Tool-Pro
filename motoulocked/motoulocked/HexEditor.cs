using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace motoulocked.motoulocked;

[StandardModule]
internal sealed class HexEditor
{
	public static byte[] HexStringToBytes(string s)
	{
		try
		{
			s = s.Replace(" ", string.Empty).Replace("-", string.Empty).ToUpper();
			int num = s.Length / 2;
			checked
			{
				byte[] array = new byte[num - 1 + 1];
				int num2 = num - 1;
				for (int i = 0; i <= num2; i++)
				{
					array[i] = Convert.ToByte(s.Substring(i * 2, 2), 16);
				}
				return array;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.ToString());
			ProjectData.ClearProjectError();
		}
		return new byte[0];
	}

	public static void PatchFile_Bytes_Pattern(string file, byte[] bytes_pattern, string str_replace, long offset = 0L, long end = 0L, long len = 0L, bool fillzero = false, bool silent = false)
	{
		List<long> lst = FindAllOffsetsInFile_Bytes_Pattern(file, bytes_pattern);
		PatchFile(file, lst, str_replace, offset, end, len, fillzero, silent);
	}

	public static void PatchFile_String_Pattern(string file, string str_pattern, string str_replace, long offset = 0L, long end = 0L, long len = 0L, bool fillzero = false, bool silent = false)
	{
		List<long> lst = FindAllOffsetsInFile_String_Pattern(file, str_pattern);
		PatchFile(file, lst, str_replace, offset, end, len, fillzero, silent);
	}

	public static void PatchFile_Hex_Pattern(string file, string hex_pattern, string str_replace, long offset = 0L, long end = 0L, long len = 0L, bool fillzero = false, bool silent = false)
	{
		List<long> lst = FindAllOffsetsInFile_Hex_Pattern(file, hex_pattern);
		PatchFile(file, lst, str_replace, offset, end, len, fillzero, silent);
	}

	public static void PatchFile(string file, List<long> lst, string str_replace, long offset = 0L, long end = 0L, long len = 0L, bool fillzero = false, bool silent = false)
	{
		int num = 1;
		checked
		{
			foreach (long item in lst)
			{
				offset = item;
				if (offset > end)
				{
					offset -= end;
				}
				if (fillzero)
				{
					ReplaceHexInFile(file, (int)offset, str_replace, zerofill: true, len);
				}
				else
				{
					ReplaceHexInFile(file, (int)offset, str_replace, zerofill: false, 0L);
				}
				num++;
			}
		}
	}

	public static void ReplaceHexInFile(string filePath, int offset, string str_replace, bool zerofill = false, long len = 0L)
	{
		byte[] array;
		if (zerofill)
		{
			string text = "00";
			while (HexStringToBytes(text).Length != len)
			{
				text += "00";
			}
			array = HexStringToBytes(text);
		}
		else
		{
			array = Encoding.Default.GetBytes(str_replace);
		}
		using FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite);
		fileStream.Seek(offset, SeekOrigin.Begin);
		fileStream.Write(array, 0, array.Length);
	}

	public static long FindOffsetInFile_Bytes_Pattern(string filePath, byte[] bytes_pattern)
	{
		return FindOffsetInFile(filePath, bytes_pattern);
	}

	public static long FindOffsetInFile_Hex_Pattern(string filePath, string hex_pattern)
	{
		byte[] bytes_pattern = HexStringToBytes(hex_pattern);
		return FindOffsetInFile(filePath, bytes_pattern);
	}

	public static long FindOffsetInFile_String_Pattern(string filePath, string str_pattern)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(str_pattern);
		return FindOffsetInFile(filePath, bytes);
	}

	public static long FindOffsetInFile(string filePath, byte[] bytes_pattern)
	{
		int num = File.ReadAllBytes(filePath).Length;
		checked
		{
			byte[] array = new byte[num - 1 + 1];
			long num2 = 0L;
			using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
			{
				for (int num3 = fileStream.Read(array, 0, num); num3 > 0; num3 = fileStream.Read(array, 0, num))
				{
					for (int i = 0; i < num3 - bytes_pattern.Length; i++)
					{
						if (MatchesPattern(array, i, bytes_pattern))
						{
							return num2 + i;
						}
					}
					num2 += num3;
				}
			}
			return 0L;
		}
	}

	public static List<long> FindAllOffsetsInFile_Bytes_Pattern(string filePath, byte[] bytes_pattern)
	{
		return FindAllOffsetsInFile(filePath, bytes_pattern);
	}

	public static List<long> FindAllOffsetsInFile_Hex_Pattern(string filePath, string hex_pattern)
	{
		byte[] bytes_pattern = HexStringToBytes(hex_pattern);
		return FindAllOffsetsInFile(filePath, bytes_pattern);
	}

	public static List<long> FindAllOffsetsInFile_String_Pattern(string filePath, string str_pattern)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(str_pattern);
		return FindAllOffsetsInFile(filePath, bytes);
	}

	public static List<long> FindAllOffsetsInFile(string filePath, byte[] bytes_pattern)
	{
		int num = 1024;
		checked
		{
			byte[] array = new byte[num - 1 + 1];
			List<long> list = new List<long>();
			using FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
			long num2 = 0L;
			for (int num3 = fileStream.Read(array, 0, num); num3 > 0; num3 = fileStream.Read(array, 0, num))
			{
				List<int> list2 = FindAllPatternMatches(array, bytes_pattern);
				foreach (int item in list2)
				{
					list.Add(num2 + item);
				}
				num2 += num3;
			}
			return list;
		}
	}

	public static long FindOffsetInBytes_Bytes_Pattern(byte[] data, byte[] bytes_pattern)
	{
		return FindOffsetInBytes(data, bytes_pattern);
	}

	public static long FindOffsetInBytes_Hex_Pattern(byte[] data, string hex_pattern)
	{
		byte[] bytes_pattern = HexStringToBytes(hex_pattern);
		return FindOffsetInBytes(data, bytes_pattern);
	}

	public static long FindOffsetInBytes_String_Pattern(byte[] data, string str_pattern)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(str_pattern);
		return FindOffsetInBytes(data, bytes);
	}

	public static long FindOffsetInBytes(byte[] data, byte[] bytes_pattern)
	{
		int num = data.Length;
		checked
		{
			byte[] buffer = new byte[num - 1 + 1];
			long num2 = 0L;
			using (MemoryStream memoryStream = new MemoryStream(data))
			{
				for (int num3 = memoryStream.Read(buffer, 0, num); num3 > 0; num3 = memoryStream.Read(buffer, 0, num))
				{
					for (int i = 0; i < num3 - bytes_pattern.Length; i++)
					{
						if (MatchesPattern(buffer, i, bytes_pattern))
						{
							return num2 + i;
						}
					}
					num2 += num3;
				}
			}
			return 0L;
		}
	}

	public static List<long> FindAllOffsetsInBytes_Bytes_Pattern(byte[] data, byte[] bytes_pattern)
	{
		return FindAllOffsetsInBytes(data, bytes_pattern);
	}

	public static List<long> FindAllOffsetsInBytes_Hex_Pattern(byte[] data, string hex_pattern)
	{
		byte[] bytes_pattern = HexStringToBytes(hex_pattern);
		return FindAllOffsetsInBytes(data, bytes_pattern);
	}

	public static List<long> FindAllOffsetsInBytes_String_Pattern(byte[] data, string str_pattern)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(str_pattern);
		return FindAllOffsetsInBytes(data, bytes);
	}

	public static List<long> FindAllOffsetsInBytes(byte[] data, byte[] bytes_pattern)
	{
		int num = 1024;
		checked
		{
			byte[] buffer = new byte[num - 1 + 1];
			List<long> list = new List<long>();
			using MemoryStream memoryStream = new MemoryStream(data);
			long num2 = 0L;
			for (int num3 = memoryStream.Read(buffer, 0, num); num3 > 0; num3 = memoryStream.Read(buffer, 0, num))
			{
				List<int> list2 = FindAllPatternMatches(buffer, bytes_pattern);
				foreach (int item in list2)
				{
					list.Add(num2 + item);
				}
				num2 += num3;
			}
			memoryStream.Close();
			return list;
		}
	}

	public static List<int> FindAllPatternMatches(byte[] buffer, byte[] pattern)
	{
		List<int> list = new List<int>();
		checked
		{
			for (int i = 0; i <= buffer.Length - pattern.Length; i++)
			{
				if (MatchesPattern(buffer, i, pattern))
				{
					list.Add(i);
				}
			}
			return list;
		}
	}

	public static bool MatchesPattern(byte[] buffer, int index, byte[] pattern)
	{
		checked
		{
			int num = pattern.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				if (buffer[index + i] != pattern[i])
				{
					return false;
				}
			}
			return true;
		}
	}
}
