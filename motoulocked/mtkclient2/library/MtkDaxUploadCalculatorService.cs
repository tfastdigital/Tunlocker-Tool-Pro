using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;

namespace motoulocked.mtkclient2.library;

internal class MtkDaxUploadCalculatorService
{
	private static (int HashMode, int Index) CalculateDaHash(byte[] da1Buff, byte[] da2Buff)
	{
		byte[] needle;
		using (SHA1 sHA = SHA1.Create())
		{
			needle = sHA.ComputeHash(da2Buff);
		}
		byte[] needle2;
		using (SHA256 sHA2 = SHA256.Create())
		{
			needle2 = sHA2.ComputeHash(da2Buff);
		}
		int num = Extension.Find(da1Buff, needle);
		int item = 1;
		if (num == -1)
		{
			num = Extension.Find(da1Buff, needle2);
			item = 2;
		}
		return (HashMode: item, Index: num);
	}

	private static Tuple<int, int, int> CalculateHash(byte[] da1, byte[] da2, int da2SignatureLen)
	{
		int num = checked(da2.Length - da2SignatureLen);
		(int, int) tuple = CalculateDaHash(da1, da2.Take(num).ToArray());
		if (tuple.Item2 == -1)
		{
			num = da2.Length;
			tuple = CalculateDaHash(da1, da2);
			if (tuple.Item2 == -1)
			{
				return null;
			}
		}
		return new Tuple<int, int, int>(tuple.Item1, tuple.Item2, num);
	}

	private static byte[] FixHash(byte[] da1, byte[] da2, int hashPos, int hashMode, int hashLen)
	{
		HashAlgorithm hashAlgorithm = hashMode switch
		{
			1 => SHA1.Create(), 
			2 => SHA256.Create(), 
			_ => throw new ArgumentException("Unknown hash mode"), 
		};
		byte[] array;
		using (hashAlgorithm)
		{
			array = hashAlgorithm.ComputeHash(da2.Take(hashLen).ToArray());
		}
		using MemoryStream memoryStream = new MemoryStream(da1);
		memoryStream.Seek(hashPos, SeekOrigin.Begin);
		memoryStream.Write(array, 0, array.Length);
		return memoryStream.ToArray();
	}

	public static MtkDaxUploadCalculationResult Calculate(byte[] da1, byte[] da2, uint uint_0, int da2SignatureLen)
	{
		Tuple<int, int, int> tuple = CalculateHash(da1, da2, da2SignatureLen);
		checked
		{
			if (tuple.Item1 > 0)
			{
				da2 = MtkDaxUploadPatchService.Patch2(da2);
				da1 = FixHash(da1, da2, tuple.Item2, tuple.Item1, tuple.Item3);
				da2 = da2.Take(tuple.Item3).ToArray();
			}
			else
			{
				da2 = da2.Take(da2.Length - da2SignatureLen).ToArray();
			}
			byte[] extension = MtkDaxUploadPatchService.PatchExtension(da2, (int)uint_0);
			Console.WriteLine("da_x.bin writen");
			return new MtkDaxUploadCalculationResult(da1, da2, extension);
		}
	}
}
