using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace motoulocked;

public class encryptor
{
	public static readonly string String_0 = "DTDAPINEWNOVDINXWTWJJWQAHNJAUWKDUQ";

	public static string ENC(string plainText)
	{
		byte[] bytes = Encoding.ASCII.GetBytes(String_0);
		byte[] iV = new byte[16];
		Aes aes = Aes.Create();
		aes.Mode = CipherMode.ECB;
		aes.Padding = PaddingMode.PKCS7;
		aes.Key = bytes.Take(32).ToArray();
		aes.IV = iV;
		using MemoryStream memoryStream = new MemoryStream();
		ICryptoTransform transform = aes.CreateEncryptor();
		using CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
		byte[] bytes2 = Encoding.ASCII.GetBytes(plainText);
		cryptoStream.Write(bytes2, 0, bytes2.Length);
		cryptoStream.FlushFinalBlock();
		return Convert.ToBase64String(memoryStream.ToArray());
	}

	public static string DEC(string cipherText)
	{
		byte[] bytes = Encoding.ASCII.GetBytes(String_0);
		byte[] iV = new byte[16];
		Aes aes = Aes.Create();
		aes.Mode = CipherMode.ECB;
		aes.KeySize = 256;
		aes.Key = bytes.Take(32).ToArray();
		aes.IV = iV;
		using MemoryStream memoryStream = new MemoryStream();
		ICryptoTransform transform = aes.CreateDecryptor();
		using CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
		string result = string.Empty;
		try
		{
			byte[] array = Convert.FromBase64String(cipherText);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.FlushFinalBlock();
			byte[] bytes2 = memoryStream.ToArray();
			result = Encoding.ASCII.GetString(bytes2);
		}
		finally
		{
			cryptoStream.Close();
			memoryStream.Close();
		}
		return result;
	}
}
