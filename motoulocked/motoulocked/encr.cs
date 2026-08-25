using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace motoulocked.motoulocked;

[StandardModule]
internal sealed class encr
{
	public static string Api0 = "fUDpHw8dRfIhN8icV8gi1OylSff8N4GvAlCF57Ov";

	public static string Api00 = "https://motounlock-7d7d0-default-rtdb.firebaseio.com/";

	private const int Keysize = 256;

	private const int DerivationIterations = 1000;

	public static string Encrypt(string plainText, string passPhrase)
	{
		byte[] array = Generate256BitsOfRandomEntropy();
		byte[] array2 = Generate256BitsOfRandomEntropy();
		byte[] bytes = Encoding.UTF8.GetBytes(plainText);
		using Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(passPhrase, array, 1000);
		byte[] bytes2 = rfc2898DeriveBytes.GetBytes(32);
		using RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.BlockSize = 256;
		rijndaelManaged.Mode = CipherMode.CBC;
		rijndaelManaged.Padding = PaddingMode.PKCS7;
		using ICryptoTransform transform = rijndaelManaged.CreateEncryptor(bytes2, array2);
		using MemoryStream memoryStream = new MemoryStream();
		using CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
		cryptoStream.Write(bytes, 0, bytes.Length);
		cryptoStream.FlushFinalBlock();
		byte[] inArray = array.Concat(array2).ToArray().Concat(memoryStream.ToArray())
			.ToArray();
		memoryStream.Close();
		cryptoStream.Close();
		return Convert.ToBase64String(inArray);
	}

	public static string Decrypt(string cipherText, string passPhrase)
	{
		byte[] array = Convert.FromBase64String(cipherText);
		byte[] salt = array.Take(32).ToArray();
		byte[] rgbIV = array.Skip(32).Take(32).ToArray();
		checked
		{
			byte[] array2 = array.Skip(64).Take(array.Length - 64).ToArray();
			using Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(passPhrase, salt, 1000);
			byte[] bytes = rfc2898DeriveBytes.GetBytes(32);
			using RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.BlockSize = 256;
			rijndaelManaged.Mode = CipherMode.CBC;
			rijndaelManaged.Padding = PaddingMode.PKCS7;
			using ICryptoTransform transform = rijndaelManaged.CreateDecryptor(bytes, rgbIV);
			using MemoryStream memoryStream = new MemoryStream(array2);
			using CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Read);
			byte[] array3 = new byte[array2.Length - 1 + 1];
			int count = cryptoStream.Read(array3, 0, array3.Length);
			memoryStream.Close();
			cryptoStream.Close();
			return Encoding.UTF8.GetString(array3, 0, count);
		}
	}

	private static byte[] Generate256BitsOfRandomEntropy()
	{
		byte[] array = new byte[32];
		using RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		rNGCryptoServiceProvider.GetBytes(array);
		return array;
	}
}
