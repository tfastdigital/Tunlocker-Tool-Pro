using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace motoulocked.HZH_Controls;

[StandardModule]
public sealed class ControlHelper
{
	public struct SCROLLINFO
	{
		public int cbSize;

		public int fMask;

		public int nMin;

		public int nMax;

		public int nPage;

		public int nPos;

		public int nTrackPos;

		public int ScrollMax => checked(nMax + 1 - nPage);
	}

	public enum ScrollInfoMask : uint
	{
		SIF_RANGE = 1u,
		SIF_PAGE = 2u,
		SIF_POS = 4u,
		SIF_DISABLENOSCROLL = 8u,
		SIF_TRACKPOS = 16u,
		SIF_ALL = 23u,
		SB_THUMBTRACK = 5u,
		WM_HSCROLL = 276u,
		WM_VSCROLL = 277u,
		SB_LINEUP = 0u,
		SB_LINEDOWN = 1u,
		SB_LINELEFT = 0u,
		SB_LINERIGHT = 1u
	}

	private static Color[] _Colors;

	public const int AW_HOR_POSITIVE = 1;

	public const int AW_HOR_NEGATIVE = 2;

	public const int AW_VER_POSITIVE = 4;

	public const int AW_VER_NEGATIVE = 8;

	public const int AW_CENTER = 16;

	public const int AW_HIDE = 65536;

	public const int AW_ACTIVATE = 131072;

	public const int AW_SLIDE = 262144;

	public const int AW_BLEND = 524288;

	private static Dictionary<Control, bool> m_lstFreezeControl;

	private static uint SB_HORZ;

	private static uint SB_VERT;

	private static uint SB_CTL;

	private static uint SB_BOTH;

	public static Color[] Colors
	{
		get
		{
			return _Colors;
		}
		private set
		{
			_Colors = value;
		}
	}

	[DllImport("user32.dll ")]
	public static extern int GetWindowLong(IntPtr hWnd, int nIndex);

	[DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
	public static extern IntPtr GetForegroundWindow();

	public static int GetStringWidth(string strSource, Graphics g, Font font)
	{
		string[] array = strSource.Split(new string[1] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
		float num = 0f;
		string[] array2 = array;
		checked
		{
			for (int i = 0; i < array2.Length; i++)
			{
				_ = array2[i];
				SizeF sizeF = g.MeasureString(strSource.Replace(" ", "A"), font);
				if (sizeF.Width > num)
				{
					num = sizeF.Width;
				}
			}
			return (int)Math.Round(num);
		}
	}

	[DllImport("user32.dll")]
	public static extern bool AnimateWindow(IntPtr whnd, int dwtime, int dwflag);

	static ControlHelper()
	{
		m_lstFreezeControl = new Dictionary<Control, bool>();
		SB_HORZ = 0u;
		SB_VERT = 1u;
		SB_CTL = 2u;
		SB_BOTH = 3u;
		List<Color> list = new List<Color>
		{
			Color.FromArgb(55, 162, 218),
			Color.FromArgb(50, 197, 233),
			Color.FromArgb(103, 224, 227),
			Color.FromArgb(159, 230, 184),
			Color.FromArgb(255, 219, 92),
			Color.FromArgb(255, 159, 127),
			Color.FromArgb(251, 114, 147),
			Color.FromArgb(224, 98, 174),
			Color.FromArgb(230, 144, 209),
			Color.FromArgb(231, 188, 243),
			Color.FromArgb(157, 150, 245),
			Color.FromArgb(131, 120, 234),
			Color.FromArgb(150, 191, 255),
			Color.FromArgb(243, 67, 54),
			Color.FromArgb(156, 39, 176),
			Color.FromArgb(103, 58, 183),
			Color.FromArgb(63, 81, 181),
			Color.FromArgb(33, 150, 243),
			Color.FromArgb(0, 188, 211),
			Color.FromArgb(3, 169, 244),
			Color.FromArgb(0, 150, 136),
			Color.FromArgb(139, 195, 74),
			Color.FromArgb(76, 175, 80),
			Color.FromArgb(204, 219, 57),
			Color.FromArgb(233, 30, 99),
			Color.FromArgb(254, 234, 59),
			Color.FromArgb(254, 192, 7),
			Color.FromArgb(254, 152, 0),
			Color.FromArgb(255, 87, 34),
			Color.FromArgb(121, 85, 72),
			Color.FromArgb(158, 158, 158),
			Color.FromArgb(96, 125, 139),
			Color.FromArgb(252, 117, 85),
			Color.FromArgb(172, 113, 191),
			Color.FromArgb(115, 131, 253),
			Color.FromArgb(78, 206, 255),
			Color.FromArgb(121, 195, 82),
			Color.FromArgb(255, 163, 28),
			Color.FromArgb(255, 185, 15),
			Color.FromArgb(255, 181, 197),
			Color.FromArgb(255, 110, 180),
			Color.FromArgb(255, 69, 0),
			Color.FromArgb(255, 48, 48),
			Color.FromArgb(154, 205, 50),
			Color.FromArgb(155, 205, 155),
			Color.FromArgb(154, 50, 205),
			Color.FromArgb(131, 111, 255),
			Color.FromArgb(124, 205, 124),
			Color.FromArgb(0, 206, 209),
			Color.FromArgb(0, 178, 238),
			Color.FromArgb(56, 142, 142)
		};
		PropertyInfo[] properties = typeof(Color).GetProperties();
		checked
		{
			int num = properties.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				PropertyInfo propertyInfo = properties[i];
				if ((object)propertyInfo.PropertyType == typeof(Color) && (propertyInfo.Name.StartsWith("Dark") || propertyInfo.Name.StartsWith("Medium")))
				{
					object objectValue = RuntimeHelpers.GetObjectValue(propertyInfo.GetValue(null, null));
					list.Add((objectValue != null) ? ((Color)objectValue) : default(Color));
				}
			}
			Colors = list.ToArray();
		}
	}

	public static void DrawString(Graphics g, string s, Font font, Brush brush, PointF point, StringFormat format, float angle)
	{
		Matrix transform = g.Transform;
		Matrix transform2 = g.Transform;
		transform2.RotateAt(angle, point);
		g.Transform = transform2;
		g.DrawString(s, font, brush, point, format);
		g.Transform = transform;
	}

	public static void FreezeControl(Control control, bool blnToFreeze)
	{
		if (blnToFreeze && control.IsHandleCreated && control.Visible && !control.IsDisposed && (!m_lstFreezeControl.ContainsKey(control) || (m_lstFreezeControl.ContainsKey(control) && !m_lstFreezeControl[control])))
		{
			m_lstFreezeControl[control] = true;
			control.Disposed += control_Disposed;
			NativeMethods.SendMessage(control.Handle, 11, 0, 0);
		}
		else if (!blnToFreeze && !control.IsDisposed && m_lstFreezeControl.ContainsKey(control) && m_lstFreezeControl[control])
		{
			m_lstFreezeControl.Remove(control);
			NativeMethods.SendMessage(control.Handle, 11, 1, 0);
			control.Invalidate(invalidateChildren: true);
		}
	}

	private static void control_Disposed(object sender, EventArgs e)
	{
		try
		{
			if (m_lstFreezeControl.ContainsKey((Control)sender))
			{
				m_lstFreezeControl.Remove((Control)sender);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static Point[] GetRhombusFromRectangle(Rectangle rect)
	{
		return checked(new Point[5]
		{
			new Point(rect.X, (int)Math.Round((double)rect.Y + (double)rect.Height / 2.0)),
			new Point((int)Math.Round((double)rect.X + (double)rect.Width / 2.0), rect.Y + rect.Height - 1),
			new Point(rect.X + rect.Width - 1, (int)Math.Round((double)rect.Y + (double)rect.Height / 2.0)),
			new Point((int)Math.Round((double)rect.X + (double)rect.Width / 2.0), rect.Y),
			new Point(rect.X, (int)Math.Round((double)rect.Y + (double)rect.Height / 2.0))
		});
	}

	public static float ComputePaintLocationY(int max, int min, int height, int value)
	{
		checked
		{
			if ((float)(max - min) == 0f)
			{
				return height;
			}
			return (float)height - (float)(value - min) * 1f / (float)(max - min) * (float)height;
		}
	}

	public static float ComputePaintLocationY(float max, float min, float height, float value)
	{
		if (max - min == 0f)
		{
			return height;
		}
		return height - (value - min) / (max - min) * height;
	}

	public static void PaintCoordinateDivide(Graphics g, Pen penLine, Pen penDash, Font font, Brush brush, StringFormat sf, int degree, int max, int min, int width, int height, int left = 60, int right = 8, int up = 8, int down = 8)
	{
		checked
		{
			for (int i = 0; i <= degree; i++)
			{
				int value = (int)Math.Round((double)((max - min) * i) / (double)degree + (double)min);
				int num = (int)Math.Round(ComputePaintLocationY(max, min, height - up - down, value)) + up + 1;
				g.DrawLine(penLine, left - 1, num, left - 4, num);
				if (i != 0)
				{
					g.DrawLine(penDash, left, num, width - right, num);
				}
				g.DrawString(value.ToString(), font, brush, new Rectangle(-5, (int)Math.Round((double)num - (double)font.Height / 2.0), left, font.Height), sf);
			}
		}
	}

	public static void AddArrayData<T>(ref T[] array, T[] data, int max)
	{
		if (data == null || data.Length == 0)
		{
			return;
		}
		checked
		{
			if (array.Length == max)
			{
				Array.Copy(array, data.Length, array, 0, array.Length - data.Length);
				Array.Copy(data, 0, array, array.Length - data.Length, data.Length);
			}
			else if (array.Length + data.Length > max)
			{
				T[] array2 = new T[max - 1 + 1];
				int num = max - data.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					array2[i] = array[i + (array.Length - max + data.Length)];
				}
				int num2 = data.Length - 1;
				for (int j = 0; j <= num2; j++)
				{
					array2[array2.Length - data.Length + j] = data[j];
				}
				array = array2;
			}
			else
			{
				T[] array3 = new T[array.Length + data.Length - 1 + 1];
				int num3 = array.Length - 1;
				for (int k = 0; k <= num3; k++)
				{
					array3[k] = array[k];
				}
				int num4 = data.Length - 1;
				for (int l = 0; l <= num4; l++)
				{
					array3[array3.Length - data.Length + l] = data[l];
				}
				array = array3;
			}
		}
	}

	public static SizeF ConvertSize(SizeF size, float angle)
	{
		Matrix matrix = new Matrix();
		matrix.Rotate(angle);
		PointF[] array = new PointF[4];
		array[0].X = (0f - size.Width) / 2f;
		array[0].Y = (0f - size.Height) / 2f;
		array[1].X = (0f - size.Width) / 2f;
		array[1].Y = size.Height / 2f;
		array[2].X = size.Width / 2f;
		array[2].Y = size.Height / 2f;
		array[3].X = size.Width / 2f;
		array[3].Y = (0f - size.Height) / 2f;
		matrix.TransformPoints(array);
		float num = float.MaxValue;
		float num2 = float.MinValue;
		float num3 = float.MaxValue;
		float num4 = float.MinValue;
		PointF[] array2 = array;
		checked
		{
			int num5 = array2.Length - 1;
			for (int i = 0; i <= num5; i++)
			{
				PointF pointF = array2[i];
				if (pointF.X < num)
				{
					num = pointF.X;
				}
				if (pointF.X > num2)
				{
					num2 = pointF.X;
				}
				if (pointF.Y < num3)
				{
					num3 = pointF.Y;
				}
				if (pointF.Y > num4)
				{
					num4 = pointF.Y;
				}
			}
			return new SizeF(num2 - num, num4 - num3);
		}
	}

	private static int GetPow(int digit)
	{
		int num = 1;
		checked
		{
			int num2 = digit - 1;
			for (int i = 0; i <= num2; i++)
			{
				num *= 10;
			}
			return num;
		}
	}

	public static double CalculateMaxSectionFrom(double[] values)
	{
		return CalculateMaxSection(values.Max());
	}

	public static double CalculateMaxSectionFrom(double[][] values)
	{
		return CalculateMaxSection(values.Max([SpecialName] (double[] p) => p.Max()));
	}

	private static double CalculateMaxSection(double num)
	{
		if (num <= 5.0)
		{
			return 5.0;
		}
		if (num <= 10.0)
		{
			return 10.0;
		}
		checked
		{
			int digit = num.ToString().Length - 2;
			int num2 = int.Parse(num.ToString().Substring(0, 2));
			if (num2 < 12)
			{
				return 12 * GetPow(digit);
			}
			if (num2 < 14)
			{
				return 14 * GetPow(digit);
			}
			if (num2 < 16)
			{
				return 16 * GetPow(digit);
			}
			if (num2 < 18)
			{
				return 18 * GetPow(digit);
			}
			if (num2 < 20)
			{
				return 20 * GetPow(digit);
			}
			if (num2 < 22)
			{
				return 22 * GetPow(digit);
			}
			if (num2 < 24)
			{
				return 24 * GetPow(digit);
			}
			if (num2 < 26)
			{
				return 26 * GetPow(digit);
			}
			if (num2 < 28)
			{
				return 28 * GetPow(digit);
			}
			if (num2 < 30)
			{
				return 30 * GetPow(digit);
			}
			if (num2 < 40)
			{
				return 40 * GetPow(digit);
			}
			if (num2 < 50)
			{
				return 50 * GetPow(digit);
			}
			if (num2 < 60)
			{
				return 60 * GetPow(digit);
			}
			if (num2 < 80)
			{
				return 80 * GetPow(digit);
			}
			return 100 * GetPow(digit);
		}
	}

	public static Color GetColorLight(Color color)
	{
		checked
		{
			return Color.FromArgb((int)Math.Round((double)unchecked((int)color.R) + (double)((255 - color.R) * 40) / 100.0), (int)Math.Round((double)unchecked((int)color.G) + (double)((255 - color.G) * 40) / 100.0), (int)Math.Round((double)unchecked((int)color.B) + (double)((255 - color.B) * 40) / 100.0));
		}
	}

	public static Color GetColorLightFive(Color color)
	{
		checked
		{
			return Color.FromArgb((int)Math.Round((double)unchecked((int)color.R) + (double)((255 - color.R) * 50) / 100.0), (int)Math.Round((double)unchecked((int)color.G) + (double)((255 - color.G) * 50) / 100.0), (int)Math.Round((double)unchecked((int)color.B) + (double)((255 - color.B) * 50) / 100.0));
		}
	}

	public static PointF[] GetPointsFrom(string points, float soureWidth, float sourceHeight, float width, float height, float dx = 0f, float dy = 0f)
	{
		string[] array = points.Split(new char[1] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
		checked
		{
			PointF[] array2 = new PointF[array.Length - 1 + 1];
			int num = array.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				int num2 = array[i].IndexOf(',');
				float num3 = Convert.ToSingle(array[i].Substring(0, num2));
				float num4 = Convert.ToSingle(array[i].Substring(num2 + 1));
				array2[i] = new PointF(width * (num3 + dx) / soureWidth, height * (num4 + dy) / sourceHeight);
			}
			return array2;
		}
	}

	public static bool IsDesignMode()
	{
		bool result = false;
		if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
		{
			result = true;
		}
		else if (object.Equals(Process.GetCurrentProcess().ProcessName, "devenv"))
		{
			result = true;
		}
		return result;
	}

	[DllImport("user32.dll", SetLastError = true)]
	private static extern int GetScrollInfo(IntPtr hWnd, uint fnBar, ref SCROLLINFO psbi);

	[DllImport("user32.dll")]
	private static extern int SetScrollInfo(IntPtr handle, uint fnBar, ref SCROLLINFO si, bool fRedraw);

	[DllImport("user32.dll")]
	private static extern bool PostMessage(IntPtr handle, int msg, uint wParam, uint lParam);

	[DllImport("User32.dll")]
	private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

	public static SCROLLINFO GetHScrollBarInfo(IntPtr hWnd)
	{
		SCROLLINFO psbi = default(SCROLLINFO);
		psbi.cbSize = Marshal.SizeOf(psbi);
		psbi.fMask = 31;
		GetScrollInfo(hWnd, SB_HORZ, ref psbi);
		return psbi;
	}

	public static SCROLLINFO GetVScrollBarInfo(IntPtr hWnd)
	{
		SCROLLINFO psbi = default(SCROLLINFO);
		psbi.cbSize = Marshal.SizeOf(psbi);
		psbi.fMask = 31;
		GetScrollInfo(hWnd, SB_VERT, ref psbi);
		return psbi;
	}

	public static void SetVScrollValue(IntPtr handle, int value)
	{
		SCROLLINFO si = GetVScrollBarInfo(handle);
		si.nPos = value;
		SetScrollInfo(handle, SB_VERT, ref si, fRedraw: true);
		PostMessage(handle, 277, MakeLong(5, checked((short)si.nPos)), 0u);
	}

	public static void SetHScrollValue(IntPtr handle, int value)
	{
		SCROLLINFO si = GetHScrollBarInfo(handle);
		si.nPos = value;
		SetScrollInfo(handle, SB_HORZ, ref si, fRedraw: true);
		PostMessage(handle, 276, MakeLong(5, checked((short)si.nPos)), 0u);
	}

	private static uint MakeLong(short lowPart, short highPart)
	{
		checked
		{
			return (ushort)lowPart | (uint)unchecked((short)(highPart << (0x10 & 0xF)));
		}
	}

	public static void ScrollUp(IntPtr handle)
	{
		SendMessage(handle, 277, 0, 0);
	}

	public static void ScrollDown(IntPtr handle)
	{
		SendMessage(handle, 277, 1, 0);
	}

	public static void ScrollLeft(IntPtr handle)
	{
		SendMessage(handle, 276, 0, 0);
	}

	public static void ScrollRight(IntPtr handle)
	{
		SendMessage(handle, 277, 1, 0);
	}

	public static GraphicsPath CalculateControlGraphicsPath(Bitmap bitmap, Color? colorTransparent = null)
	{
		GraphicsPath graphicsPath = new GraphicsPath();
		Color color = bitmap.GetPixel(0, 0);
		bool? obj;
		if (!colorTransparent.HasValue)
		{
			obj = false;
		}
		else
		{
			Color transparent = Color.Transparent;
			obj = (colorTransparent.HasValue ? new bool?(colorTransparent.GetValueOrDefault() != transparent) : null);
		}
		bool? flag = obj;
		if (flag ?? true)
		{
			Color transparent = Color.Empty;
			if ((colorTransparent.HasValue ? new bool?(colorTransparent.GetValueOrDefault() != transparent) : null).GetValueOrDefault() && flag.HasValue)
			{
				color = colorTransparent.Value;
			}
		}
		int num = 0;
		checked
		{
			int num2 = bitmap.Height - 1;
			for (int i = 0; i <= num2; i++)
			{
				num = 0;
				int num3 = bitmap.Width - 1;
				for (int j = 0; j <= num3; j++)
				{
					if (bitmap.GetPixel(j, i) != color)
					{
						num = j;
						int num4 = j;
						int num5 = num;
						int num6 = bitmap.Width - 1;
						for (num4 = num5; num4 <= num6 && !(bitmap.GetPixel(num4, i) == color); num4++)
						{
						}
						graphicsPath.AddRectangle(new Rectangle(num, i, num4 - num, 1));
						j = num4;
					}
				}
			}
			return graphicsPath;
		}
	}

	public static Point GetScreenLocation(Screen screen, int left, int top)
	{
		return checked(new Point(screen.Bounds.Left + left, screen.Bounds.Top + top));
	}
}
