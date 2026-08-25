using System.Windows.Forms;

namespace motoulocked.motoulocked;

public class sourcefile
{
	public static string Directoryfile = Application.StartupPath + "\\tmp\\temp";

	public static string Directorypath = Application.StartupPath + "\\tmp\\temp\\unpack";

	public static string Directorypath_kg = Application.StartupPath + "\\tmp";

	public static string Andoidpath = Directorypath + "\\unpackimg.bat";

	public static string clean = Directorypath + "\\cleanup.bat";

	public static string Dumped = Directorypath + "\\boot.img";
}
