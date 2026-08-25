using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace motoulocked.mtkclient2.MTK.Client;

internal class utils
{
	public static string magichexFlow = "efeeeefe01000000";

	public static string magichexMessage = "efeeeefe02000000";

	public static string magichex = "efeeeefe";

	public static async Task xsend8(IMtkDevice device, CancellationToken cancellationToken, byte[] databytes)
	{
		byte[] data = HexStringToBytes("EF EE EE FE 01 00 00 00 08 00 00 00");
		await writemtk(device, cancellationToken, data);
		await writemtk(device, cancellationToken, databytes);
	}

	public static async Task xsend(IMtkDevice device, CancellationToken cancellationToken, byte[] databytes)
	{
		string text = Conversion.Hex(databytes.Length.ToString());
		string text2 = ((text.Length % 2 == 0) ? text : ("0" + text));
		byte[] data = HexStringToBytes(string.Concat(str1: (text2.Length == 2) ? (text2 + "000000") : ((text2.Length == 4) ? (text2 + "0000") : ((text2.Length != 6) ? text2 : (text2 + "00"))), str0: magichexFlow));
		await writemtk(device, cancellationToken, data);
		await writemtk(device, cancellationToken, databytes);
	}

	public static async Task xsend4(IMtkDevice device, CancellationToken cancellationToken, byte[] databytes)
	{
		byte[] data = HexStringToBytes("EFEEEEFE0100000004000000");
		await writemtk(device, cancellationToken, data);
		await writemtk(device, cancellationToken, databytes);
	}

	public static async Task<bool> send00000(IMtkDevice device, CancellationToken cancellationToken, int panjangresponse, string eksekusi, string hex, string delay)
	{
		checked
		{
			if (!cancellationToken.IsCancellationRequested)
			{
				if (string.IsNullOrEmpty(hex))
				{
					hex = "00000000";
				}
				byte[] databytes = HexStringToBytes(hex);
				await xsend4(device, cancellationToken, databytes);
				if (string.IsNullOrEmpty(delay))
				{
					delay = "15";
				}
				await Task.Delay(Convert.ToInt32(delay));
				string text = BytesToHextring(await readmtk(device, cancellationToken, panjangresponse.ToString()));
				int num = 0;
				TaskAwaiter<byte[]> taskAwaiter2 = default(TaskAwaiter<byte[]>);
				while (true)
				{
					if (num == 50)
					{
						return false;
					}
					if (text.Length == panjangresponse * 2)
					{
						break;
					}
					string text2 = text;
					TaskAwaiter<byte[]> taskAwaiter = readmtk(device, cancellationToken, "4").GetAwaiter();
					if (!taskAwaiter.IsCompleted)
					{
						//await taskAwaiter;
						taskAwaiter = taskAwaiter2;
						taskAwaiter2 = default(TaskAwaiter<byte[]>);
					}
					text = text2 + BytesToHextring(taskAwaiter.GetResult());
					num++;
					await Task.Delay(1);
				}
				if (Operators.CompareString(text.Substring(0, 8), magichex, TextCompare: false) != 0)
				{
					return false;
				}
				if (text.Length == panjangresponse * 2 && Operators.CompareString(text.Substring(panjangresponse * 2 - 2, 2), "00", TextCompare: false) != 0)
				{
					if (Operators.CompareString(applyshiftKiri2(text.Substring(panjangresponse * 2 - 8)), "010001c0", TextCompare: false) == 0)
					{
						return true;
					}
					if (Operators.CompareString(applyshiftKiri2(text.Substring(panjangresponse * 2 - 8)), "c0010001", TextCompare: false) == 0)
					{
						return true;
					}
					if (Operators.CompareString(applyshiftKiri2(text.Substring(panjangresponse * 2 - 8)), "c0010003", TextCompare: false) == 0)
					{
						return true;
					}
					if (Operators.CompareString(applyshiftKiri2(text.Substring(panjangresponse * 2 - 8)), "c0010004", TextCompare: false) == 0)
					{
						return true;
					}
					if (Operators.CompareString(applyshiftKiri2(text.Substring(panjangresponse * 2 - 8)), "40040004", TextCompare: false) == 0)
					{
						return true;
					}
					if (Operators.CompareString(applyshiftKiri2(text.Substring(panjangresponse * 2 - 8)), "40040005", TextCompare: false) == 0)
					{
						return true;
					}
					return false;
				}
				return true;
			}
			return false;
		}
	}

	public static async Task<byte[]> readmtk(IMtkDevice device, CancellationToken cancellationToken, string len)
	{
		if (cancellationToken.IsCancellationRequested)
		{
			return new byte[0];
		}
		try
		{
			return await device.ReadCustomAsync(cancellationToken, Convert.ToInt32(len));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			byte[] result = new byte[0];
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static async Task writemtk(IMtkDevice device, CancellationToken cancellationToken, byte[] data)
	{
		if (!cancellationToken.IsCancellationRequested)
		{
			try
			{
				await device.WriteAsync(data, 0, data.Length, cancellationToken);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	public static string GetFileSize(long TheSize)
	{
		string result = "0KB";
		try
		{
			result = ((TheSize >= 1099511627776L) ? (Strings.FormatNumber((double)TheSize / 1099511627776.0, 2) + " TB") : ((TheSize >= 1073741824 && TheSize <= 1099511627775L) ? (Strings.FormatNumber((double)TheSize / 1073741824.0, 2) + " GB") : ((TheSize >= 1048576 && TheSize <= 1073741823) ? (Strings.FormatNumber((double)TheSize / 1048576.0, 2) + " MB") : ((TheSize >= 1024 && TheSize <= 1048575) ? (Strings.FormatNumber((double)TheSize / 1024.0, 2) + " KB") : ((TheSize >= 0 && TheSize <= 1023) ? (Strings.FormatNumber((double)TheSize, 2) + " bytes") : "")))));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static long HexToLong(string hexstring)
	{
		if (Operators.CompareString(hexstring, "none", TextCompare: false) == 0)
		{
			hexstring = "0";
		}
		else if (string.IsNullOrEmpty(hexstring))
		{
			hexstring = "0";
		}
		return Convert.ToInt64(hexstring, 16);
	}

	public static string LongToHex(long LongLen)
	{
		long num = LongLen;
		string text = num.ToString("x");
		return "0x" + text;
	}

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

	public static string penggenapan2(string v)
	{
		if (v.Length == 1)
		{
			return "0" + v;
		}
		return v;
	}

	public static string penggenapan8(string input)
	{
		return input.Length switch
		{
			16 => input, 
			14 => input + "00", 
			12 => input + "0000", 
			10 => input + "000000", 
			8 => input + "00000000", 
			6 => input + "0000000000", 
			4 => input + "000000000000", 
			2 => input + "00000000000000", 
			_ => input + "0000000000000000", 
		};
	}

	public static string penggenapan4belakang(string input)
	{
		return input.Length.ToString() switch
		{
			"8" => input, 
			"7" => input + "0", 
			"6" => input + "00", 
			"5" => input + "000", 
			"4" => input + "0000", 
			"3" => input + "00000", 
			"2" => input + "000000", 
			"1" => "0" + input + "000000", 
			_ => input, 
		};
	}

	public static string DecimalToHexadecimal(long dec)
	{
		if (dec == 0L)
		{
			return "00";
		}
		if (dec < 1)
		{
			return "0";
		}
		long num = 0L;
		string text = string.Empty;
		while (dec > 0)
		{
			num = dec % 16;
			text = checked((num >= 10) ? text.Insert(0, Convert.ToChar(num + 55).ToString()) : text.Insert(0, Convert.ToChar(num + 48).ToString()));
			dec = Convert.ToInt64(Math.Floor((double)dec / 16.0));
		}
		return text;
	}

	public static string applyshiftKiri2(string hexstring)
	{
		string text = "";
		if (hexstring.Length % 2 != 0)
		{
			hexstring = "0" + hexstring;
		}
		checked
		{
			int num = hexstring.Length - 2;
			_ = hexstring.Length;
			int num2 = unchecked(hexstring.Length / 2) - 1;
			for (int i = 0; i <= num2; i++)
			{
				text += hexstring.Substring(num, 2);
				num -= 2;
			}
			text = Regex.Replace(text, "^0+", "");
		}
		if (text.Length % 2 != 0)
		{
			text = "0" + text;
		}
		double num3 = (double)(hexstring.Length / 2) - (double)(text.Length / 2) - 1.0;
		for (double num4 = 0.0; num4 <= num3; num4 += 1.0)
		{
			text = "00" + text;
		}
		return text;
	}

	public static string BytesToHextring(byte[] input)
	{
		return BitConverter.ToString(input).Replace("-", "").ToLower();
	}

	public static string HexToDec(string hexstring)
	{
		switch (hexstring)
		{
		case "none":
			hexstring = "0";
			break;
		case null:
		case "":
			hexstring = "0";
			break;
		}
		return Convert.ToInt64(hexstring, 16).ToString();
	}

	public static object skipoffset(string[] patternhex, ref int yangdi_skip, string hexstring)
	{
		string text = "";
		int length = hexstring.Length;
		checked
		{
			for (int i = 0; i <= length; i++)
			{
				string text2 = hexstring.Substring(i, 2);
				if (Operators.CompareString(text2.ToUpper(), patternhex[0].ToUpper(), TextCompare: false) != 0)
				{
					continue;
				}
				text += text2;
				if (Operators.CompareString(hexstring.Substring(i + 2, 2).ToUpper(), patternhex[1].ToUpper(), TextCompare: false) == 0)
				{
					yangdi_skip = i;
					if (Operators.CompareString(hexstring.Substring(i + 4, 2).ToUpper(), patternhex[2].ToUpper(), TextCompare: false) == 0)
					{
						yangdi_skip = i;
						break;
					}
				}
			}
			object result = default(object);
			return result;
		}
	}
}
