using System;
using System.Collections;
using System.IO;
using System.Text.RegularExpressions;

namespace motoulocked;

internal class qcert3
{
	internal static string string_0;

	internal static string string_1;

	internal static string string_2;

	internal static string string_3;

	internal static string string_4;

	internal static string imeiconvert;

	internal static string string_finly;

	public static string imei;

	public static string imeiSign;

	private static string pubKey;

	private static string KeySign;

	public static string imeSIGN { get; set; }

	public static string PUBKEYy { get; set; }

	public static string PUBKEYSIGN { get; set; }

	public static ArrayList newsuucrt(string certpath)
	{
		imei = null;
		pubKey = null;
		KeySign = null;
		imeiSign = null;
		string[] array = null;
		array = File.ReadAllLines(certpath);
		checked
		{
			int num = array.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = array[i];
				if (text.Contains("IMEI="))
				{
					imei = Regex.Split(text, "=")[1];
				}
				if (text.Contains("ImeiSign="))
				{
					imeiSign = Regex.Split(text, "=")[1];
				}
				if (text.Contains("PubKey="))
				{
					pubKey = Regex.Split(text, "=")[1];
				}
				if (text.Contains("PubKeySign="))
				{
					KeySign = Regex.Split(text, "=")[1];
				}
			}
			string text2 = imeiSign + "," + pubKey + "," + KeySign;
			ArrayList arrayList = new ArrayList();
			int num2 = text2.Length - 1;
			for (int j = 0; j <= num2; j += 500)
			{
				arrayList.Add(text2.Substring(j, Math.Min(text2.Length - j, 500)));
			}
			return arrayList;
		}
	}

	internal static ArrayList smethod_0()
	{
		string_0 = imeSIGN;
		string_2 = PUBKEYy;
		string_3 = PUBKEYSIGN;
		string text = string_0 + "," + string_2 + "," + string_3;
		ArrayList arrayList = new ArrayList();
		checked
		{
			int num = text.Length - 1;
			for (int i = 0; i <= num; i += 500)
			{
				arrayList.Add(text.Substring(i, Math.Min(text.Length - i, 500)));
			}
			return arrayList;
		}
	}
}
