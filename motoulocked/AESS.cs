using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace motoulocked;

internal class AESS
{
	public static byte[] smethod_0(byte[] byte_0, byte[] byte_1)
	{
		byte[] array = null;
		checked
		{
			using MemoryStream memoryStream = new MemoryStream();
			using RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(byte_1, byte_1, 1000);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes((int)Math.Round((double)rijndaelManaged.KeySize / 8.0));
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes((int)Math.Round((double)rijndaelManaged.BlockSize / 8.0));
			rijndaelManaged.Mode = CipherMode.CBC;
			using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write))
			{
				cryptoStream.Write(byte_0, 0, byte_0.Length);
				cryptoStream.Close();
			}
			return memoryStream.ToArray();
		}
	}

	public static byte[] smethod_1(byte[] byte_0, byte[] byte_1)
	{
		byte[] array = null;
		checked
		{
			using MemoryStream memoryStream = new MemoryStream();
			using RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(byte_1, byte_1, 1000);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes((int)Math.Round((double)rijndaelManaged.KeySize / 8.0));
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes((int)Math.Round((double)rijndaelManaged.BlockSize / 8.0));
			rijndaelManaged.Mode = CipherMode.CBC;
			using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write))
			{
				cryptoStream.Write(byte_0, 0, byte_0.Length);
				cryptoStream.Close();
			}
			return memoryStream.ToArray();
		}
	}

	public static string smethod_2(string string_0, byte[] byte_0)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(string_0);
		byte_0 = SHA256.Create().ComputeHash(byte_0);
		byte[] array = smethod_5(smethod_4(byte_0));
		checked
		{
			byte[] array2 = new byte[array.Length + bytes.Length - 1 + 1];
			int num = array.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				array2[i] = array[i];
			}
			int num2 = bytes.Length - 1;
			for (int j = 0; j <= num2; j++)
			{
				array2[j + array.Length] = bytes[j];
			}
			return Convert.ToBase64String(smethod_0(array2, byte_0));
		}
	}

	public static string smethod_3(string string_0, byte[] byte_0)
	{
		byte[] byte_ = Convert.FromBase64String(string_0);
		byte_0 = SHA256.Create().ComputeHash(byte_0);
		byte[] array = smethod_1(byte_, byte_0);
		int num = smethod_4(byte_0);
		checked
		{
			byte[] array2 = new byte[array.Length - num - 1 + 1];
			int num2 = array.Length - 1;
			for (int i = num; i <= num2; i++)
			{
				array2[i - num] = array[i];
			}
			return Encoding.UTF8.GetString(array2);
		}
	}

	public static int smethod_4(byte[] byte_0)
	{
		byte[] bytes = new Rfc2898DeriveBytes(byte_0, byte_0, 1000).GetBytes(2);
		StringBuilder stringBuilder = new StringBuilder();
		checked
		{
			int num = bytes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				stringBuilder.Append(Convert.ToInt32(bytes[i]).ToString());
			}
			int num2 = 0;
			string text = stringBuilder.ToString();
			int num3 = text.Length - 1;
			for (int j = 0; j <= num3; j++)
			{
				int num4 = Convert.ToInt32(text[j].ToString());
				num2 += num4;
			}
			return num2;
		}
	}

	public static byte[] smethod_5(int int_0)
	{
		byte[] array = new byte[checked(int_0 - 1 + 1)];
		RandomNumberGenerator.Create().GetBytes(array);
		return array;
	}
}
