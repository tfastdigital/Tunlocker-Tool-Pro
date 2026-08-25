using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace motoulocked;

public sealed class tmpcrpt
{
	public static bool dbg = false;

	public static string keyQT = "0";

	public static string EncryptString(string plainText, string pass)
	{
		string result;
		try
		{
			byte[] bytes = Encoding.ASCII.GetBytes(pass);
			byte[] iV = new byte[16];
			Aes aes = Aes.Create();
			aes.Mode = CipherMode.ECB;
			aes.KeySize = 256;
			aes.Key = bytes.Take(32).ToArray();
			aes.IV = iV;
			using MemoryStream memoryStream = new MemoryStream();
			ICryptoTransform transform = aes.CreateEncryptor();
			using CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
			byte[] bytes2 = Encoding.ASCII.GetBytes(plainText);
			cryptoStream.Write(bytes2, 0, bytes2.Length);
			cryptoStream.FlushFinalBlock();
			result = Convert.ToBase64String(memoryStream.ToArray());
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			result = "null";
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static string DecryptString(string cipherText, string pass)
	{
		string result;
		try
		{
			byte[] bytes = Encoding.ASCII.GetBytes(pass);
			byte[] iV = new byte[16];
			Aes aes = Aes.Create();
			aes.Mode = CipherMode.ECB;
			aes.KeySize = 256;
			aes.Key = bytes.Take(32).ToArray();
			aes.IV = iV;
			using MemoryStream memoryStream = new MemoryStream();
			ICryptoTransform transform = aes.CreateDecryptor();
			using CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
			string text = string.Empty;
			try
			{
				byte[] array = Convert.FromBase64String(cipherText);
				cryptoStream.Write(array, 0, array.Length);
				cryptoStream.FlushFinalBlock();
				byte[] bytes2 = memoryStream.ToArray();
				text = Encoding.ASCII.GetString(bytes2);
			}
			finally
			{
				cryptoStream.Close();
				memoryStream.Close();
			}
			result = text;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			result = "null";
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static string CalculateMD5Hash(string input)
	{
		using MD5 mD = MD5.Create();
		byte[] bytes = Encoding.UTF8.GetBytes(input);
		byte[] array = mD.ComputeHash(bytes);
		StringBuilder stringBuilder = new StringBuilder();
		byte[] array2 = array;
		foreach (byte b in array2)
		{
			stringBuilder.Append(b.ToString("x2"));
		}
		return stringBuilder.ToString().ToUpper();
	}

	private static string CalculateMD5Hash2(byte[] inputBytes)
	{
		using MD5 mD = MD5.Create();
		byte[] array = mD.ComputeHash(inputBytes);
		StringBuilder stringBuilder = new StringBuilder();
		byte[] array2 = array;
		foreach (byte b in array2)
		{
			stringBuilder.Append(b.ToString("x2"));
		}
		string text = stringBuilder.ToString().ToUpper();
		string text2 = CalculateMD5Hash(inputBytes.Length.ToString());
		return CalculateMD5Hash(text + text2);
	}

	public static string keyQTx()
	{
		if (Operators.CompareString(keyQT, "0", TextCompare: false) == 0)
		{
			return encryptor.String_0;
		}
		return keyQT;
	}
}
