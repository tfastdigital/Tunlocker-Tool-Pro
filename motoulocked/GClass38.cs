using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace motoulocked;

public class GClass38
{
	private string string_1;

	private string string_2;

	private static string string_3;

	public static string string_4;

	private static string string_5;

	private string[] string_6;

	internal static string String_0 { get; set; }

	public string method_0(string string_7)
	{
		string_3 = string_7;
		method_1();
		smethod_0();
		return string_4;
	}

	public object method_1()
	{
		method_5();
		method_2();
		method_3();
		method_4();
		string_4 = String_0 + "-" + string_1 + "-" + string_2;
		return string_4;
	}

	public object method_2()
	{
		double num = 1.0;
		double num2 = 1.0;
		double num3 = Conversions.ToDouble(string_6[0]);
		double num4 = Conversions.ToDouble(string_6[1]);
		double num5 = Conversions.ToDouble(string_6[2]);
		if (num5 % 2.0 > 0.0)
		{
			num = num4;
		}
		for (double num6 = num5 / 2.0; num6 >= num2; num2 += 1.0)
		{
			num = num4 * num4 % (num3 * num);
			num %= num3;
		}
		String_0 = Conversions.ToString(new decimal(Math.Round(num) + 89.0));
		return String_0;
	}

	public object method_3()
	{
		double num = Conversions.ToDouble(string_6[0]);
		Conversions.ToDouble(string_6[1]);
		Conversions.ToDouble(string_6[2]);
		double num2 = 98789.0;
		double a = num * num2 % Math.Log(num);
		decimal num3 = new decimal(Math.Round(a) + 89.0);
		string_1 = Conversions.ToString(num3);
		return string_1;
	}

	public object method_4()
	{
		Conversions.ToDouble(string_6[0]);
		double num = Conversions.ToDouble(string_6[1]);
		Conversions.ToDouble(string_6[2]);
		double a = num / Math.Log(num);
		decimal num2 = new decimal(Math.Round(a) + 89.0);
		string_2 = Conversions.ToString(num2);
		return string_2;
	}

	public object method_5()
	{
		string_6 = string_3.Split('-');
		return string_6;
	}

	public void method_6(double double_0)
	{
		DateAndTime.Now.AddSeconds(1.1574074074074073E-05);
		DateTime t = DateAndTime.Now.AddSeconds(1.1574074074074073E-05).AddSeconds(double_0);
		while (DateTime.Compare(DateAndTime.Now, t) <= 0)
		{
			Application.DoEvents();
		}
	}

	public static string smethod_0()
	{
		String_0 = null;
		string text = GClass39.smethod_5(string_4).Replace(" ", ",0x");
		if (string_4.Length == 8)
		{
			String_0 = "0x12,0x0D,0x00,0x1C,0x00,0x16,0x41,0x54,0x2B,0x41,0x4B,0x53,0x45,0x45,0x44,0x4E,0x4F,0x3D,0x30,0x2C" + text + ",.";
		}
		if (string_4.Length == 9)
		{
			String_0 = "0x12,0x0D,0x00,0x1D,0x00,0x17,0x41,0x54,0x2B,0x41,0x4B,0x53,0x45,0x45,0x44,0x4E,0x4F,0x3D,0x30,0x2C" + text + ",.";
		}
		if (string_4.Length == 10)
		{
			String_0 = "0x12,0x0D,0x00,0x1E,0x00,0x18,0x41,0x54,0x2B,0x41,0x4B,0x53,0x45,0x45,0x44,0x4E,0x4F,0x3D,0x30,0x2C" + text + ",.";
		}
		if (string_4.Length == 11)
		{
			String_0 = "0x12,0x0D,0x00,0x1F,0x00,0x19,0x41,0x54,0x2B,0x41,0x4B,0x53,0x45,0x45,0x44,0x4E,0x4F,0x3D,0x30,0x2C" + text + ",.";
		}
		if (string_4.Length == 12)
		{
			String_0 = "0x12,0x0D,0x00,0x20,0x00,0x1A,0x41,0x54,0x2B,0x41,0x4B,0x53,0x45,0x45,0x44,0x4E,0x4F,0x3D,0x30,0x2C" + text + ",.";
		}
		if (string_4.Length == 13)
		{
			String_0 = "0x12,0x0D,0x00,0x21,0x00,0x1B,0x41,0x54,0x2B,0x41,0x4B,0x53,0x45,0x45,0x44,0x4E,0x4F,0x3D,0x30,0x2C" + text + ",.";
		}
		if (string_4.Length == 14)
		{
			String_0 = "0x12,0x0D,0x00,0x22,0x00,0x1C,0x41,0x54,0x2B,0x41,0x4B,0x53,0x45,0x45,0x44,0x4E,0x4F,0x3D,0x30,0x2C" + text + ",.";
		}
		if (string_4.Length == 15)
		{
			String_0 = "0x12,0x0D,0x00,0x23,0x00,0x1D,0x41,0x54,0x2B,0x41,0x4B,0x53,0x45,0x45,0x44,0x4E,0x4F,0x3D,0x30,0x2C" + text + ",.";
		}
		if (string_4.Length == 16)
		{
			String_0 = "0x12,0x0D,0x00,0x24,0x00,0x1E,0x41,0x54,0x2B,0x41,0x4B,0x53,0x45,0x45,0x44,0x4E,0x4F,0x3D,0x30,0x2C" + text + ",.";
		}
		if (string_4.Length == 17)
		{
			String_0 = "0x12,0x0D,0x00,0x25,0x00,0x1F,0x41,0x54,0x2B,0x41,0x4B,0x53,0x45,0x45,0x44,0x4E,0x4F,0x3D,0x30,0x2C" + text + ",.";
		}
		string result = default(string);
		return result;
	}
}
