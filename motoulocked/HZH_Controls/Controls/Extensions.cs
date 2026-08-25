using System.Drawing;
using System.Drawing.Drawing2D;
using Microsoft.VisualBasic.CompilerServices;

namespace motoulocked.HZH_Controls.Controls;

public static class Extensions
{
	public static  void SetGDIHigh(this Graphics g)
	{
		g.SmoothingMode = SmoothingMode.AntiAlias;
		g.InterpolationMode = InterpolationMode.HighQualityBilinear;
		g.PixelOffsetMode = PixelOffsetMode.HighQuality;
	}
}
