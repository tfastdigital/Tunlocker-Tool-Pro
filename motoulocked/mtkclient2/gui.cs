using System;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace motoulocked.mtkclient2;

public class gui
{
	public static void logs(string text, bool newline)
	{
		if (Form1.SharedUI.RichTextBox1.InvokeRequired)
		{
			if (newline)
			{
				Form1.SharedUI.RichTextBox1.Invoke((Action)([SpecialName] () =>
				{
					Form1.SharedUI.RichTextBox1.AppendText(text + "\r\n");
				}));
			}
			else
			{
				Form1.SharedUI.RichTextBox1.Invoke((Action)([SpecialName] () =>
				{
					Form1.SharedUI.RichTextBox1.AppendText(text);
				}));
			}
		}
		else if (newline)
		{
			Form1.SharedUI.RichTextBox1.AppendText(text + "\r\n");
		}
		else
		{
			Form1.SharedUI.RichTextBox1.AppendText(text);
		}
		Form1.SharedUI.RichTextBox1.Update();
	}

	public static void Richlog(string msg, Color colour, bool isBold = false, bool NextLine = false)
	{
		if (colour == Color.Black)
		{
			colour = Color.White;
		}
		if ((colour == Color.Green) | (colour == Color.LightGreen))
		{
			colour = Color.Lime;
		}
		if (colour == Color.FromArgb(0, 85, 207))
		{
			colour = Color.FromArgb(21, 87, 255);
		}
		if (Form1.SharedUI.RichTextBox1.InvokeRequired)
		{
			Form1.SharedUI.RichTextBox1.Invoke((Action)([SpecialName] () =>
			{
				Color selectionColor2 = Form1.SharedUI.RichTextBox1.SelectionColor;
				Form1.SharedUI.RichTextBox1.SelectionColor = colour;
				Form1.SharedUI.RichTextBox1.AppendText(msg);
				Form1.SharedUI.RichTextBox1.SelectionColor = selectionColor2;
				if (NextLine && Form1.SharedUI.RichTextBox1.TextLength > 0)
				{
					Form1.SharedUI.RichTextBox1.AppendText("\r\n");
				}
			}));
		}
		else
		{
			Color selectionColor = Form1.SharedUI.RichTextBox1.SelectionColor;
			Form1.SharedUI.RichTextBox1.SelectionColor = colour;
			Form1.SharedUI.RichTextBox1.AppendText(msg);
			Form1.SharedUI.RichTextBox1.SelectionColor = selectionColor;
			if (NextLine && Form1.SharedUI.RichTextBox1.TextLength > 0)
			{
				Form1.SharedUI.RichTextBox1.AppendText("\r\n");
			}
		}
		Form1.SharedUI.RichTextBox1.Update();
	}
}
