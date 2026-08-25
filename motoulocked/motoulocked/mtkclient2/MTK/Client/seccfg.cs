using Microsoft.VisualBasic.CompilerServices;

namespace motoulocked.motoulocked.mtkclient2.MTK.Client;

internal class seccfg
{
	public static string CreateSeccfg(string proses, bool crtical)
	{
		string text = ((Operators.CompareString(proses, "unlock", TextCompare: false) != 0) ? "01 00 00 00" : "03 00 00 00");
		string text2 = ((!crtical) ? "00 00 00 00" : "01 00 00 00");
		return "4D 4D 4D 4D 04 00 00 00 3C 00 00 00 " + text + text2 + " 00 00 00 00 45 45 45 45";
	}
}
