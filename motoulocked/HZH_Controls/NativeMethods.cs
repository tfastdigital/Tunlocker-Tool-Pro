using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace motoulocked.HZH_Controls;

internal class NativeMethods
{
	public enum ComboBoxButtonState
	{
		STATE_SYSTEM_NONE = 0,
		STATE_SYSTEM_INVISIBLE = 32768,
		STATE_SYSTEM_PRESSED = 8
	}

	public struct RECT
	{
		public int Left;

		public int Top;

		public int Right;

		public int Bottom;

		public Rectangle Rect => checked(new Rectangle(Left, Top, Right - Left, Bottom - Top));

		public Size Size => checked(new Size(Right - Left, Bottom - Top));

		public RECT(int left, int top, int right, int bottom)
		{
			this = default(RECT);
			Left = left;
			Top = top;
			Right = right;
			Bottom = bottom;
		}

		public RECT(Rectangle rect)
		{
			this = default(RECT);
			Left = rect.Left;
			Top = rect.Top;
			Right = rect.Right;
			Bottom = rect.Bottom;
		}

		public static RECT FromXYWH(int x, int y, int width, int height)
		{
			return checked(new RECT(x, y, x + width, y + height));
		}

		public static RECT FromRectangle(Rectangle rect)
		{
			return new RECT(rect.Left, rect.Top, rect.Right, rect.Bottom);
		}
	}

	public struct PAINTSTRUCT
	{
		public IntPtr hdc;

		public int fErase;

		public RECT rcPaint;

		public int fRestore;

		public int fIncUpdate;

		public int Reserved1;

		public int Reserved2;

		public int Reserved3;

		public int Reserved4;

		public int Reserved5;

		public int Reserved6;

		public int Reserved7;

		public int Reserved8;
	}

	public struct ComboBoxInfo
	{
		public int cbSize;

		public RECT rcItem;

		public RECT rcButton;

		public ComboBoxButtonState stateButton;

		public IntPtr hwndCombo;

		public IntPtr hwndEdit;

		public IntPtr hwndList;
	}

	public const int WM_PAINT = 15;

	public const int WM_SETREDRAW = 11;

	public static readonly IntPtr FALSE = IntPtr.Zero;

	public static readonly IntPtr TRUE = new IntPtr(1);

	[DllImport("user32.dll")]
	public static extern bool GetComboBoxInfo(IntPtr hwndCombo, ref ComboBoxInfo info);

	[DllImport("user32.dll")]
	public static extern int GetWindowRect(IntPtr hwnd, ref RECT lpRect);

	[DllImport("user32.dll")]
	public static extern IntPtr BeginPaint(IntPtr hWnd, ref PAINTSTRUCT ps);

	[DllImport("user32.dll")]
	public static extern bool EndPaint(IntPtr hWnd, ref PAINTSTRUCT ps);

	[DllImport("user32.dll")]
	public static extern void SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
}
