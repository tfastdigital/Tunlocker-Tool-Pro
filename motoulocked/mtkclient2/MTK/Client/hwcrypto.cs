using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace motoulocked.mtkclient2.MTK.Client;

internal class hwcrypto
{
	public static string getSHA1Hash(byte[] bytetohash)
	{
		bytetohash = new SHA1CryptoServiceProvider().ComputeHash(bytetohash);
		string text = string.Empty;
		byte[] array = bytetohash;
		foreach (byte b in array)
		{
			text += b.ToString("x2");
		}
		return text;
	}

	public static string gethash256(byte[] bytetohas)
	{
		return utils.BytesToHextring(new SHA256Managed().ComputeHash(bytetohas));
	}

	public static string getsha256(string content)
	{
		UTF8Encoding uTF8Encoding = new UTF8Encoding();
		byte[] key = utils.HexStringToBytes("62DDE5B241D5EB467B577C04737FBCD4");
		uTF8Encoding.GetBytes(content);
		string text = utils.BytesToHextring(new HMACSHA256(key).ComputeHash(utils.HexStringToBytes("44ED75BBF9E6D0701022E954F0549D552D7C67AF9F8926F90B2638B4EBAE31D4")));
		Convert.ToBase64String(utils.HexStringToBytes(text));
		return text;
	}

	public static string hashlibsha256(string data)
	{
		return utils.BytesToHextring(new SHA256Managed().ComputeHash(utils.HexStringToBytes(data)));
	}

	public static byte[] DecryptorSec(byte[] cipherText)
	{
		byte[] bytes = Encoding.UTF8.GetBytes("1A52A367CB12C458965D32CD874B36B2");
		byte[] iV = utils.HexStringToBytes("57325A5A125497661254976657325A5A");
		try
		{
			RijndaelManaged obj = (RijndaelManaged)Rijndael.Create();
			obj.BlockSize = 128;
			obj.FeedbackSize = 128;
			obj.KeySize = 128;
			obj.Mode = CipherMode.CBC;
			obj.IV = iV;
			obj.Key = bytes;
			obj.Padding = PaddingMode.None;
			byte[] array = new byte[checked(cipherText.Length - 1 + 1)];
			MemoryStream memoryStream = new MemoryStream(array);
			using (ICryptoTransform transform = obj.CreateDecryptor())
			{
				using MemoryStream memoryStream2 = new MemoryStream(cipherText);
				using CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
				byte[] buffer = new byte[129];
				int num = 0;
				do
				{
					num = memoryStream2.Read(buffer, 0, 128);
					cryptoStream.Write(buffer, 0, num);
				}
				while (num != 0);
			}
			memoryStream.Close();
			return array;
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

	public static byte[] computeHash(string clearText, string key)
	{
		UTF8Encoding uTF8Encoding = new UTF8Encoding();
		return new HMACSHA512(uTF8Encoding.GetBytes(key)).ComputeHash(utils.HexStringToBytes(clearText));
	}

	public static string EncSeccfg(string data)
	{
		return utils.BytesToHextring(new SHA256Managed().ComputeHash(utils.HexStringToBytes(data)));
	}

	public bool tryDecryptBytes(ref byte[] B, string Pass)
	{
		bool result;
		try
		{
			ICryptoTransform cryptoTransform = new RijndaelManaged
			{
				Mode = CipherMode.ECB,
				Key = Encoding.UTF8.GetBytes(Pass)
			}.CreateDecryptor();
			B = cryptoTransform.TransformFinalBlock(B, 0, B.Length);
			result = true;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			result = false;
			ProjectData.ClearProjectError();
		}
		return result;
	}
}
