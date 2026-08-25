using System.Diagnostics;

namespace motoulocked.motoulocked;

public class device_info
{
	internal static string model;

	internal static string secunumber;

	internal static string serialno;

	internal static string Android;

	internal static string imei;

	internal static string meid;

	internal static string imei_sign;

	internal static string Carrier;

	internal static string security_patch;

	internal static string Hardware;

	internal static string Brand;

	internal static string Build_id;

	internal static string Region;

	internal static string Software_Version;

	internal static string cpu_abi;

	[DebuggerNonUserCode]
	public device_info()
	{
	}

	public static void reset()
	{
		model = null;
		serialno = null;
		imei = null;
		imei_sign = null;
	}

	public static void set_model(string txt)
	{
		model = txt;
	}

	public static void set_sn(string txt)
	{
		serialno = txt;
	}

	public static void set_imei(string txt)
	{
		imei = txt;
	}

	public static void set_imei_sign(string txt)
	{
		imei_sign = txt;
	}
}
