using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace motoulocked.motoulocked;

[StandardModule]
public sealed class Cryptography
{
	public static string Base64Encode(string plainText)
	{
		return Convert.ToBase64String(Encoding.UTF8.GetBytes(plainText));
	}

	public static string Base64Decode(string base64EncodedData)
	{
		byte[] bytes = Convert.FromBase64String(base64EncodedData);
		return Encoding.UTF8.GetString(bytes);
	}

	public static bool CryptStream(string password, byte[] in_stream, bool encrypt, string Filenya)
	{
		if (string.IsNullOrEmpty(Filenya))
		{
			throw new ArgumentException(string.Format("'{0}' cannot be null or empty.", "Filenya"), "Filenya");
		}
		if (in_stream == null)
		{
			throw new ArgumentNullException("in_stream");
		}
		if (string.IsNullOrEmpty(password))
		{
			throw new ArgumentException(string.Format("'{0}' cannot be null or empty.", "password"), "password");
		}
		bool flag = false;
		ICryptoTransform cryptoTransform = null;
		AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider();
		int num = 0;
		int num2 = 1024;
		checked
		{
			do
			{
				if (!aesCryptoServiceProvider.ValidKeySize(num2))
				{
					num2 += -1;
					continue;
				}
				num = num2;
				break;
			}
			while (num2 >= 1);
			Console.WriteLine("Key size: " + Convert.ToString(num));
			int blockSize = aesCryptoServiceProvider.BlockSize;
			byte[] key = new byte[0];
			byte[] iv = new byte[0];
			byte[] salt = new byte[14]
			{
				0, 0, 1, 2, 3, 4, 5, 6, 241, 240,
				238, 33, 34, 69
			};
			MakeKeyAndIV(password, salt, num, blockSize, ref key, ref iv);
			cryptoTransform = ((!encrypt) ? aesCryptoServiceProvider.CreateDecryptor(key, iv) : aesCryptoServiceProvider.CreateEncryptor(key, iv));
			MemoryStream stream = new MemoryStream(EDL.OutDecripted);
			long num3 = 0L;
			try
			{
				using (MemoryStream memoryStream = new MemoryStream(in_stream))
				{
					using CryptoStream cryptoStream = new CryptoStream(stream, cryptoTransform, CryptoStreamMode.Write);
					byte[] buffer = new byte[1025];
					while (true)
					{
						int num4 = memoryStream.Read(buffer, 0, 1024);
						num3 += num4;
						if (num4 != 0)
						{
							cryptoStream.Write(buffer, 0, num4);
							continue;
						}
						break;
					}
				}
				if (Operators.CompareString(Filenya, "loader", TextCompare: false) == 0)
				{
					SAHARA_MANAGER.Loader = GetRawData(EDL.OutDecripted.Take(Convert.ToInt32(num3)).ToArray());
				}
				cryptoTransform.Dispose();
				flag = true;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				cryptoTransform.Dispose();
				UiManager.Richlogs(ex2.ToString(), Color.Red, isBold: false, NextLine: true);
				flag = false;
				ProjectData.ClearProjectError();
			}
			return flag;
		}
	}

	public static int FilterData(byte[] inputdata)
	{
		byte[] array = new byte[4];
		Stream stream = new MemoryStream(inputdata);
		int num = 0;
		while (true)
		{
			stream.Seek(num, SeekOrigin.Begin);
			stream.Read(array, 0, array.Length);
			if (Encoding.UTF8.GetString(array).ToLower().Contains("<?x"))
			{
				break;
			}
			num = checked(num + 1);
		}
		return num;
	}

	public static byte[] GetRawData(byte[] inputdata)
	{
		byte[] array = new byte[5];
		Stream stream = new MemoryStream(inputdata);
		int num = 0;
		checked
		{
			while (true)
			{
				stream.Seek(inputdata.Length - num, SeekOrigin.Begin);
				stream.Read(array, 0, array.Length);
				if (Operators.CompareString(Encoding.UTF8.GetString(array), "EndCF", TextCompare: false) == 0)
				{
					break;
				}
				num++;
			}
			return inputdata.Take(inputdata.Length - num).ToArray();
		}
	}

	public static void MakeKeyAndIV(string password, byte[] salt, int key_size_bits, int block_size_bits, ref byte[] key, ref byte[] iv)
	{
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, salt, 1000);
		key = rfc2898DeriveBytes.GetBytes(Convert.ToInt32((double)key_size_bits / 8.0));
		iv = rfc2898DeriveBytes.GetBytes(Convert.ToInt32((double)block_size_bits / 8.0));
	}
}
