namespace motoulocked.mtkclient2;

public class AndroidCommands
{
	public static string AndroidName(string os)
	{
		os = os.Trim();
		string result = "";
		if (os.Contains("3.0") || os.Contains("3.1") || os.Contains("3.2"))
		{
			result = os + " (Honeycomb)";
		}
		if (os.Contains("4.0"))
		{
			result = os + " (ICE Cream Sandwich)";
		}
		if (os.Contains("4.1") || os.Contains("4.2") || os.Contains("4.3"))
		{
			result = os + " (Jelly Bean)";
		}
		if (os.Contains("4.4"))
		{
			result = os + " (KitKat)";
		}
		if (os.Contains("5.0") || os.Contains("5.1"))
		{
			result = os + " (Lollipop)";
		}
		if (os.Contains("6.0"))
		{
			result = os + " (Marshmallow)";
		}
		if (os.Contains("7.0") || os.Contains("7.1"))
		{
			result = os + " (Nougat)";
		}
		if (os.Contains("8.0") || os.Contains("8.1"))
		{
			result = os + " (Oreo)";
		}
		if (os.Contains("9"))
		{
			result = os + " (Pie)";
		}
		if (os.Contains("10"))
		{
			result = os + " (Quince Tart)";
		}
		if (os.Contains("11"))
		{
			result = os + " (Red Velvet Cake)";
		}
		if (os.Contains("12"))
		{
			result = os + " (Show Cone)";
		}
		if (os.Contains("13"))
		{
			result = os ?? "";
		}
		if (os.Contains("14"))
		{
			result = os ?? "";
		}
		return result;
	}
}
