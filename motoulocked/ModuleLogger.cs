using System;
using System.Drawing;
using Microsoft.VisualBasic.CompilerServices;

namespace motoulocked;

internal class ModuleLogger
{
	private static Form1 form1_0;

	internal static void smethod_0(Form1 form1_1)
	{
		form1_0 = form1_1;
	}

	internal static void UpdateLogger(string string_0, Color color_0, FontStyle fontStyle_0)
	{
		try
		{
			form1_0.RichTextBox1.SelectionColor = color_0;
			form1_0.RichTextBox1.SelectionFont = new Font(form1_0.RichTextBox1.Font, fontStyle_0);
			form1_0.RichTextBox1.AppendText(string_0);
			form1_0.RichTextBox1.SelectionStart = form1_0.RichTextBox1.TextLength;
			form1_0.RichTextBox1.SelectionLength = string_0.Length;
			form1_0.RichTextBox1.ScrollToCaret();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	internal static void ClearLogger()
	{
		try
		{
			form1_0.RichTextBox1.Clear();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
