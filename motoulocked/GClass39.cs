using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace motoulocked;

public class GClass39
{
	private class Class51
	{
		public string string_0;

		internal byte method_0(int int_0)
		{
			return Convert.ToByte(string_0.Substring(int_0, 2), 16);
		}
	}

	[Serializable]
	private class Class52
	{
		public static Class52 x = new Class52();

		public static Func<int, bool> x__17_0;

		internal bool method_0(int int_0)
		{
			return int_0 % 2 == 0;
		}
	}

	public static string smethod_0(byte[] byte_0)
	{
		string text = "";
		string text2 = "";
		checked
		{
			try
			{
				int num = byte_0.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					byte b = byte_0[i];
					text += Conversions.ToString(Strings.Chr(b));
					text2 += Conversion.Hex(b).PadLeft(2, '0');
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			return text2;
		}
	}

	public static string smethod_1(string string_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		checked
		{
			string result;
			try
			{
				int num = string_0.Length - 1;
				for (int i = 0; i <= num; i += 2)
				{
					stringBuilder.Append(string_0.Substring(i, 2) + " ");
				}
				return stringBuilder.ToString().TrimEnd();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				result = stringBuilder.ToString().TrimEnd();
				ProjectData.ClearProjectError();
			}
			return result;
		}
	}

	public static string smethod_2(string string_0)
	{
		string text = string.Empty;
		string_0 = string_0.Replace(" ", "");
		checked
		{
			int num = string_0.Length - 1;
			for (int i = 0; i <= num; i += 2)
			{
				string text2 = string_0.Substring(i, 2);
				text = text2 switch
				{
					"00" => text + ".", 
					"09" => text + "□", 
					"0C" => text + "□", 
					"0D" => text + "□", 
					_ => text + Convert.ToChar(Convert.ToUInt32(text2, 16)), 
				};
			}
			return text;
		}
	}

	public static string smethod_3(string string_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		byte[] bytes = Encoding.UTF8.GetBytes(string_0);
		checked
		{
			int num = bytes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				byte b = bytes[i];
				stringBuilder.Append($"{b:x2}");
			}
			return stringBuilder.ToString();
		}
	}

	public static string smethod_4(string string_0)
	{
		checked
		{
			string result;
			try
			{
				string text = "";
				int num = string_0.Length - 1;
				int num2;
				for (num2 = 0; num2 <= num; num2++)
				{
					if (Operators.CompareString(string_0.Substring(num2, 2), "00", TextCompare: false) != 0)
					{
						text += string_0.Substring(num2, 2);
						num2++;
					}
					else
					{
						num2++;
					}
				}
				string text2 = "";
				while (text.Length > 0)
				{
					text2 += Convert.ToChar(Convert.ToUInt64(text.Substring(0, 2), 16));
					text = text.Substring(2, text.Length - 2);
				}
				result = text2;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				result = "-1";
				ProjectData.ClearProjectError();
			}
			return result;
		}
	}

	public static string smethod_5(string string_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		byte[] bytes = Encoding.UTF8.GetBytes(string_0);
		checked
		{
			int num = bytes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				byte b = bytes[i];
				stringBuilder.Append($" {b:x2}");
			}
			return stringBuilder.ToString();
		}
	}

	public static string smethod_6(string string_0, int int_0)
	{
		string text = string.Empty;
		string empty = string.Empty;
		string empty2 = string.Empty;
		int num = Strings.Len(string_0);
		checked
		{
			for (int i = 1; i <= num; i++)
			{
				if (Strings.Len(Strings.Mid(string_0, i)) <= int_0 * 2)
				{
					empty = smethod_1(Strings.Mid(string_0, i));
					empty2 = "    |    " + smethod_2(empty);
					text = text + empty.PadRight(int_0 * 2 + 16).Substring(0, int_0 * 2 + 16) + empty2 + "\r\n";
				}
				else
				{
					empty = smethod_1(Strings.Mid(string_0, i, int_0 * 2));
					empty2 = "    |    " + smethod_2(empty);
					text = text + empty.PadRight(int_0 * 2 + 16).Substring(0, int_0 * 2 + 16) + empty2 + "\r\n";
				}
			}
			return text;
		}
	}

	public static string smethod_7(byte[] byte_0)
	{
		string text = smethod_0(byte_0);
		checked
		{
			string result;
			try
			{
				string text2 = "";
				int num = text.Length - 1;
				int num2;
				for (num2 = 0; num2 <= num; num2++)
				{
					if (Operators.CompareString(text.Substring(num2, 2), "00", TextCompare: false) != 0)
					{
						text2 += text.Substring(num2, 2);
						num2++;
					}
					else
					{
						num2++;
					}
				}
				string text3 = "";
				while (text2.Length > 0)
				{
					text3 += Convert.ToChar(Convert.ToUInt64(text2.Substring(0, 2), 16));
					text2 = text2.Substring(2, text2.Length - 2);
				}
				result = text3;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				result = "-1";
				ProjectData.ClearProjectError();
			}
			return result;
		}
	}

	public static string smethod_8(string string_0)
	{
		checked
		{
			string result;
			try
			{
				string text = "";
				int num = string_0.Length - 1;
				int num2;
				for (num2 = 0; num2 <= num; num2++)
				{
					if (Operators.CompareString(string_0.Substring(num2, 2), "00", TextCompare: false) != 0)
					{
						text += string_0.Substring(num2, 2);
						num2++;
					}
					else
					{
						num2++;
					}
				}
				string text2 = "";
				while (text.Length > 0)
				{
					text2 += Convert.ToChar(Convert.ToUInt64(text.Substring(0, 2), 16));
					text = text.Substring(2, text.Length - 2);
				}
				result = text2;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				result = "-1";
				ProjectData.ClearProjectError();
			}
			return result;
		}
	}

	public static string smethod_9(byte[] byte_0, int int_0, int int_1)
	{
		return smethod_7(byte_0).Substring(int_0, int_1);
	}

	public static byte[] HexStringToBytes(string string_0)
	{
		checked
		{
			byte[] result;
			try
			{
				int num = 0;
				int num2 = 0;
				byte[] array = new byte[(int)Math.Round((double)string_0.Length / 2.0 - 1.0) + 1 - 1 + 1];
				while (string_0.Length > num + 1)
				{
					long value = Convert.ToInt64(string_0.Substring(num, 2), 16);
					array[num2] = Convert.ToByte(value);
					num += 2;
					num2++;
				}
				result = array;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Interaction.MsgBox("Hex String To Byte Array Conversion Error!", MsgBoxStyle.Critical);
				result = null;
				ProjectData.ClearProjectError();
			}
			return result;
		}
	}

	public static string smethod_11(string string_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			return string.Empty;
		}
		StringBuilder stringBuilder = new StringBuilder();
		checked
		{
			int num = string_0.Length - 2;
			for (int i = 1; i <= num; i += 2)
			{
				stringBuilder.Append(new string(string_0.Substring(i, 2).Reverse().ToArray()));
			}
			return smethod_1($"08{string_0[0]}A{stringBuilder.ToString()}");
		}
	}

	public static string smethod_12(string string_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			return string.Empty;
		}
		StringBuilder stringBuilder = new StringBuilder();
		checked
		{
			int num = string_0.Length - 2;
			for (int i = 0; i <= num; i += 2)
			{
				stringBuilder.Append(new string(string_0.Substring(i, 2).Reverse().ToArray()));
			}
			return smethod_1(Strings.StrReverse(stringBuilder.ToString()));
		}
	}

	public static string smethod_13(string string_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			return string.Empty;
		}
		string text = string_0.Remove(0, 1);
		StringBuilder stringBuilder = new StringBuilder();
		checked
		{
			int num = text.Length - 2;
			for (int i = 1; i <= num; i += 2)
			{
				stringBuilder.Append(new string(text.Substring(i, 2).Reverse().ToArray()));
			}
			return stringBuilder.ToString().TrimStart('A');
		}
	}

	public static string smethod_14(string string_0)
	{
		return string_0.Substring(4, checked(string_0.Length - 7));
	}

	public static string smethod_15(string string_0, int int_0, int int_1)
	{
		return string_0.Substring(int_0, checked(string_0.Length - int_1));
	}

	public static string smethod_16(string string_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		checked
		{
			int num = string_0.Length - 2;
			for (int i = 0; i <= num; i += 2)
			{
				stringBuilder.Append(Convert.ToString(Convert.ToChar(int.Parse(string_0.Substring(i, 2), NumberStyles.HexNumber))));
			}
			return stringBuilder.ToString();
		}
	}

	private byte[] method_0(string string_0)
	{
		Class51 @class = new Class51();
		@class.string_0 = string_0;
		return Enumerable.Range(0, @class.string_0.Length).Where(Class52.x.method_0).Select(@class.method_0)
			.ToArray();
	}

	public static int GetSaltSize(byte[] passwordBytes)
	{
		byte[] bytes = new Rfc2898DeriveBytes(passwordBytes, passwordBytes, 1000).GetBytes(2);
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

	public static string smethod_17(string string_0)
	{
		string s = "dataunlock12az";
		byte[] sourceArray = SHA256.Create().ComputeHash(Encoding.ASCII.GetBytes(s));
		byte[] iV = new byte[16];
		Aes aes = Aes.Create();
		aes.Mode = CipherMode.CBC;
		byte[] array = new byte[32];
		Array.Copy(sourceArray, 0, array, 0, 32);
		aes.Key = array;
		aes.IV = iV;
		MemoryStream memoryStream = new MemoryStream();
		ICryptoTransform transform = aes.CreateEncryptor();
		CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
		byte[] bytes = Encoding.ASCII.GetBytes(string_0);
		cryptoStream.Write(bytes, 0, bytes.Length);
		cryptoStream.FlushFinalBlock();
		byte[] array2 = memoryStream.ToArray();
		memoryStream.Close();
		cryptoStream.Close();
		return Convert.ToBase64String(array2, 0, array2.Length);
	}

	public static string Decrypt(string decryptedText)
	{
		byte[] bytesToBeDecrypted = Convert.FromBase64String(decryptedText);
		Aes.Create();
		byte[] passwordBytes = SHA256.Create().ComputeHash(Encoding.ASCII.GetBytes("dataunlock12az"));
		byte[] array = AES_Decrypt(bytesToBeDecrypted, passwordBytes);
		int saltSize = GetSaltSize(passwordBytes);
		checked
		{
			byte[] array2 = new byte[array.Length - saltSize - 1 + 1];
			int num = array.Length - 1;
			for (int i = saltSize; i <= num; i++)
			{
				array2[i - saltSize] = array[i];
			}
			return Encoding.UTF8.GetString(array2);
		}
	}

	public static byte[] AES_Decrypt(byte[] bytesToBeDecrypted, byte[] passwordBytes)
	{
		byte[] array = null;
		checked
		{
			using MemoryStream memoryStream = new MemoryStream();
			using RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(passwordBytes, passwordBytes, 1000);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes((int)Math.Round((double)rijndaelManaged.KeySize / 8.0));
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes((int)Math.Round((double)rijndaelManaged.BlockSize / 8.0));
			rijndaelManaged.Mode = CipherMode.CBC;
			using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write))
			{
				cryptoStream.Write(bytesToBeDecrypted, 0, bytesToBeDecrypted.Length);
				cryptoStream.Close();
			}
			return memoryStream.ToArray();
		}
	}

	public static string smethod_18(string string_0)
	{
		string result = string.Empty;
		try
		{
			string s = "ewewer";
			Array sourceArray = SHA256.Create().ComputeHash(Encoding.ASCII.GetBytes(s));
			byte[] iV = new byte[16];
			Aes aes = Aes.Create();
			aes.Mode = CipherMode.CBC;
			byte[] array = new byte[32];
			Array.Copy(sourceArray, 0, array, 0, 32);
			aes.Key = array;
			aes.IV = iV;
			MemoryStream memoryStream = new MemoryStream();
			ICryptoTransform transform = aes.CreateDecryptor();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
			try
			{
				byte[] array2 = Convert.FromBase64String(string_0);
				cryptoStream.Write(array2, 0, array2.Length);
				cryptoStream.FlushFinalBlock();
				byte[] array3 = memoryStream.ToArray();
				result = Encoding.ASCII.GetString(array3, 0, array3.Length);
			}
			finally
			{
				memoryStream.Close();
				cryptoStream.Close();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		return result;
	}
}
