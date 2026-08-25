using System.Drawing;

namespace motoulocked.HZH_Controls;

public class TextColors
{
	private static Color _MoreLight = ColorTranslator.FromHtml("#c0c4cc");

	private static Color _Light = ColorTranslator.FromHtml("#909399");

	private static Color _Dark = ColorTranslator.FromHtml("#606266");

	private static Color _MoreDark = ColorTranslator.FromHtml("#303133");

	public static Color MoreLight
	{
		get
		{
			return _MoreLight;
		}
		internal set
		{
			_MoreLight = value;
		}
	}

	public static Color Light
	{
		get
		{
			return _Light;
		}
		internal set
		{
			_Light = value;
		}
	}

	public static Color Dark
	{
		get
		{
			return _Dark;
		}
		internal set
		{
			_Dark = value;
		}
	}

	public static Color MoreDark
	{
		get
		{
			return _MoreDark;
		}
		internal set
		{
			_MoreDark = value;
		}
	}
}
