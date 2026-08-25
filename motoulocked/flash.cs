using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Media;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using motoulocked.Controls;
using motoulocked.motoulocked;
using Properties;

namespace motoulocked;

[DesignerGenerated]
public class flash : Form
{
	private class Class85
	{
		public IEnumerable<string> ienumerable_0;

		internal string method_0(string string_0)
		{
			Class86 @class = new Class86();
			@class.string_0 = string_0;
			return @class.string_0 + " - " + ienumerable_0.FirstOrDefault(@class.method_0);
		}
	}

	private class Class86
	{
		public string string_0;

		internal bool method_0(string string_1)
		{
			return string_1.Contains(string_0);
		}
	}

	private class Class87
	{
		public static Class87 x = new Class87();

		public static Func<string, string> x__0_0;

		public static Func<ManagementBaseObject, string> x__0_1;

		public static Func<string, ManagementBaseObject, string> x__0_2;

		public static Func<ManagementBaseObject, string> x__0_3;

		internal string method_0(string string_0)
		{
			return string_0;
		}

		internal string method_1(ManagementBaseObject managementBaseObject_0)
		{
			return managementBaseObject_0["DeviceID"].ToString();
		}

		internal string method_2(string string_0, ManagementBaseObject managementBaseObject_0)
		{
			string text = " - ";
			return string_0 + text + RuntimeHelpers.GetObjectValue(managementBaseObject_0["Caption"]);
		}

		internal string method_3(ManagementBaseObject managementBaseObject_0)
		{
			return managementBaseObject_0["Caption"].ToString();
		}
	}

	private IContainer components;

	[CompilerGenerated]
	[AccessedThroughProperty("Timer3")]
	private System.Windows.Forms.Timer _Timer3;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2CheckBox4")]
	private Guna2CheckBox _Guna2CheckBox4;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2CheckBox2")]
	private Guna2CheckBox _Guna2CheckBox2;

	[CompilerGenerated]
	[AccessedThroughProperty("Timer1")]
	private System.Windows.Forms.Timer _Timer1;

	[CompilerGenerated]
	[AccessedThroughProperty("Timer2")]
	private System.Windows.Forms.Timer _Timer2;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2Button1")]
	private Guna2Button _Guna2Button1;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2Button23")]
	private Guna2Button _Guna2Button23;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2Button25")]
	private Guna2Button _Guna2Button25;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2Button2")]
	private Guna2Button _Guna2Button2;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2Button4")]
	private Guna2Button _Guna2Button4;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2Button3")]
	private Guna2Button _Guna2Button3;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2Button5")]
	private Guna2Button _Guna2Button5;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2Button12")]
	private Guna2Button _Guna2Button12;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2Button8")]
	private Guna2Button _Guna2Button8;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2Button7")]
	private Guna2Button _Guna2Button7;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2Button6")]
	private Guna2Button _Guna2Button6;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2Button9")]
	private Guna2Button _Guna2Button9;

	[CompilerGenerated]
	[AccessedThroughProperty("DataGridFlash")]
	private DataGridView _DataGridFlash;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2Button10")]
	private Guna2Button _Guna2Button10;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2Button13")]
	private Guna2Button _Guna2Button13;

	private string a;

	private static List<string> list_0;

	private string text3;

	public static string namefile;

	private string check;

	public string string_13;

	public string string_14;

	public string string_15;

	private string ThisLocation;

	public static string ProgressChanged;

	private string chengbar;

	private string LoadFolderXml;
    /*
	[field: AccessedThroughProperty("TextBox4")]
	internal  TextBox TextBox4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ComboBox1")]
	internal  ComboBox ComboBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox15")]
	internal  TextBox TextBox15
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("RichTextBox2")]
	internal  RichTextBox RichTextBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Port_Name")]
	internal  ComboBox Port_Name
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ProgressBarCOM4S")]
	internal  Guna2ProgressBar ProgressBarCOM4S
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ProgressBarCOM3S")]
	internal  Guna2ProgressBar ProgressBarCOM3S
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ProgressBarCOM2S")]
	internal  Guna2ProgressBar ProgressBarCOM2S
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ProgressBarCOM1S")]
	internal  Guna2ProgressBar ProgressBarCOM1S
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox7")]
	internal  TextBox TextBox7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox11")]
	internal  TextBox TextBox11
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox1")]
	internal  TextBox TextBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal  System.Windows.Forms.Timer Timer3
	{
		[CompilerGenerated]
		get
		{
			return _Timer3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Timer3_Tick;
			System.Windows.Forms.Timer timer = _Timer3;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_Timer3 = value;
			timer = _Timer3;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	[field: AccessedThroughProperty("RichTextBox3")]
	internal  RichTextBox RichTextBox3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("SerialPort1")]
	internal  SerialPort SerialPort1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal  Guna2CheckBox Guna2CheckBox4
	{
		[CompilerGenerated]
		get
		{
			return _Guna2CheckBox4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Guna2CheckBox4_CheckedChanged;
			Guna2CheckBox guna2CheckBox = _Guna2CheckBox4;
			if (guna2CheckBox != null)
			{
				guna2CheckBox.CheckedChanged -= value2;
			}
			_Guna2CheckBox4 = value;
			guna2CheckBox = _Guna2CheckBox4;
			if (guna2CheckBox != null)
			{
				guna2CheckBox.CheckedChanged += value2;
			}
		}
	}

	internal  Guna2CheckBox Guna2CheckBox2
	{
		[CompilerGenerated]
		get
		{
			return _Guna2CheckBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Guna2CheckBox2_CheckedChanged;
			Guna2CheckBox guna2CheckBox = _Guna2CheckBox2;
			if (guna2CheckBox != null)
			{
				guna2CheckBox.CheckedChanged -= value2;
			}
			_Guna2CheckBox2 = value;
			guna2CheckBox = _Guna2CheckBox2;
			if (guna2CheckBox != null)
			{
				guna2CheckBox.CheckedChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("CSC")]
	internal  Guna2TextBox CSC
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CP")]
	internal  Guna2TextBox CP
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("AP")]
	internal  Guna2TextBox AP
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("BL")]
	internal  Guna2TextBox BL
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Guna2Button14")]
	internal  Guna2Button Guna2Button14
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Guna2GroupBox3")]
	internal  Guna2GroupBox Guna2GroupBox3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Guna2GroupBox1")]
	internal  Guna2GroupBox Guna2GroupBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("SamsungCOM4")]
	internal  Guna2TextBox SamsungCOM4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("SamsungCOM3")]
	internal  Guna2TextBox SamsungCOM3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("SamsungCOM2")]
	internal  Guna2TextBox SamsungCOM2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("SamsungCOM1")]
	internal  Guna2TextBox SamsungCOM1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Guna2GroupBox2")]
	internal  Guna2GroupBox Guna2GroupBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("COM4")]
	internal  Guna2TextBox COM4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Guna2Button11")]
	internal  Guna2Button Guna2Button11
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("COM3")]
	internal  Guna2TextBox COM3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("COM2")]
	internal  Guna2TextBox COM2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("COM1")]
	internal  Guna2TextBox COM1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("COM4ProgressBar1")]
	internal  Guna2ProgressBar COM4ProgressBar1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("COM3ProgressBar1")]
	internal  Guna2ProgressBar COM3ProgressBar1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("COM2ProgressBar1")]
	internal  Guna2ProgressBar COM2ProgressBar1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("COM1ProgressBar1")]
	internal  Guna2ProgressBar COM1ProgressBar1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Guna2GroupBox4")]
	internal  Guna2GroupBox Guna2GroupBox4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("name_flash")]
	internal  Guna2TextBox name_flash
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Comboboxport")]
	internal  Guna2ComboBox Comboboxport
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cbstorage")]
	internal  Guna2ComboBox cbstorage
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal  System.Windows.Forms.Timer Timer1
	{
		[CompilerGenerated]
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Timer1_Tick;
			System.Windows.Forms.Timer timer = _Timer1;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_Timer1 = value;
			timer = _Timer1;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	internal  System.Windows.Forms.Timer Timer2
	{
		[CompilerGenerated]
		get
		{
			return _Timer2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Timer2_Tick;
			System.Windows.Forms.Timer timer = _Timer2;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_Timer2 = value;
			timer = _Timer2;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	internal  Guna2Button Guna2Button1
	{
		[CompilerGenerated]
		get
		{
			return _Guna2Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Guna2Button1_Click;
			Guna2Button guna2Button = _Guna2Button1;
			if (guna2Button != null)
			{
				guna2Button.Click -= value2;
			}
			_Guna2Button1 = value;
			guna2Button = _Guna2Button1;
			if (guna2Button != null)
			{
				guna2Button.Click += value2;
			}
		}
	}

	internal  Guna2Button Guna2Button23
	{
		[CompilerGenerated]
		get
		{
			return _Guna2Button23;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Guna2Button23_Click;
			Guna2Button guna2Button = _Guna2Button23;
			if (guna2Button != null)
			{
				guna2Button.Click -= value2;
			}
			_Guna2Button23 = value;
			guna2Button = _Guna2Button23;
			if (guna2Button != null)
			{
				guna2Button.Click += value2;
			}
		}
	}

	internal  Guna2Button Guna2Button25
	{
		[CompilerGenerated]
		get
		{
			return _Guna2Button25;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Guna2Button25_Click;
			Guna2Button guna2Button = _Guna2Button25;
			if (guna2Button != null)
			{
				guna2Button.Click -= value2;
			}
			_Guna2Button25 = value;
			guna2Button = _Guna2Button25;
			if (guna2Button != null)
			{
				guna2Button.Click += value2;
			}
		}
	}

	internal  Guna2Button Guna2Button2
	{
		[CompilerGenerated]
		get
		{
			return _Guna2Button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Guna2Button2_Click;
			Guna2Button guna2Button = _Guna2Button2;
			if (guna2Button != null)
			{
				guna2Button.Click -= value2;
			}
			_Guna2Button2 = value;
			guna2Button = _Guna2Button2;
			if (guna2Button != null)
			{
				guna2Button.Click += value2;
			}
		}
	}

	internal  Guna2Button Guna2Button4
	{
		[CompilerGenerated]
		get
		{
			return _Guna2Button4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Guna2Button4_Click;
			Guna2Button guna2Button = _Guna2Button4;
			if (guna2Button != null)
			{
				guna2Button.Click -= value2;
			}
			_Guna2Button4 = value;
			guna2Button = _Guna2Button4;
			if (guna2Button != null)
			{
				guna2Button.Click += value2;
			}
		}
	}

	internal  Guna2Button Guna2Button3
	{
		[CompilerGenerated]
		get
		{
			return _Guna2Button3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Guna2Button3_Click;
			Guna2Button guna2Button = _Guna2Button3;
			if (guna2Button != null)
			{
				guna2Button.Click -= value2;
			}
			_Guna2Button3 = value;
			guna2Button = _Guna2Button3;
			if (guna2Button != null)
			{
				guna2Button.Click += value2;
			}
		}
	}

	internal  Guna2Button Guna2Button5
	{
		[CompilerGenerated]
		get
		{
			return _Guna2Button5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Guna2Button5_Click;
			Guna2Button guna2Button = _Guna2Button5;
			if (guna2Button != null)
			{
				guna2Button.Click -= value2;
			}
			_Guna2Button5 = value;
			guna2Button = _Guna2Button5;
			if (guna2Button != null)
			{
				guna2Button.Click += value2;
			}
		}
	}

	internal  Guna2Button Guna2Button12
	{
		[CompilerGenerated]
		get
		{
			return _Guna2Button12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Guna2Button12_Click;
			Guna2Button guna2Button = _Guna2Button12;
			if (guna2Button != null)
			{
				guna2Button.Click -= value2;
			}
			_Guna2Button12 = value;
			guna2Button = _Guna2Button12;
			if (guna2Button != null)
			{
				guna2Button.Click += value2;
			}
		}
	}

	internal  Guna2Button Guna2Button8
	{
		[CompilerGenerated]
		get
		{
			return _Guna2Button8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Guna2Button8_Click;
			Guna2Button guna2Button = _Guna2Button8;
			if (guna2Button != null)
			{
				guna2Button.Click -= value2;
			}
			_Guna2Button8 = value;
			guna2Button = _Guna2Button8;
			if (guna2Button != null)
			{
				guna2Button.Click += value2;
			}
		}
	}

	internal  Guna2Button Guna2Button7
	{
		[CompilerGenerated]
		get
		{
			return _Guna2Button7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Guna2Button7_Click;
			Guna2Button guna2Button = _Guna2Button7;
			if (guna2Button != null)
			{
				guna2Button.Click -= value2;
			}
			_Guna2Button7 = value;
			guna2Button = _Guna2Button7;
			if (guna2Button != null)
			{
				guna2Button.Click += value2;
			}
		}
	}

	internal  Guna2Button Guna2Button6
	{
		[CompilerGenerated]
		get
		{
			return _Guna2Button6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Guna2Button6_Click;
			Guna2Button guna2Button = _Guna2Button6;
			if (guna2Button != null)
			{
				guna2Button.Click -= value2;
			}
			_Guna2Button6 = value;
			guna2Button = _Guna2Button6;
			if (guna2Button != null)
			{
				guna2Button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Guna2CheckBox1")]
	internal  Guna2CheckBox Guna2CheckBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TabControlExt1")]
	internal  TabControlExt TabControlExt1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TabPage2")]
	internal  TabPage TabPage2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TabPage4")]
	internal  TabPage TabPage4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TabPage1")]
	internal  TabPage TabPage1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Guna2GroupBox5")]
	internal  Guna2GroupBox Guna2GroupBox5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cbsetboot")]
	internal  Guna2CheckBox cbsetboot
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal  Guna2Button Guna2Button9
	{
		[CompilerGenerated]
		get
		{
			return _Guna2Button9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Guna2Button9_Click;
			Guna2Button guna2Button = _Guna2Button9;
			if (guna2Button != null)
			{
				guna2Button.Click -= value2;
			}
			_Guna2Button9 = value;
			guna2Button = _Guna2Button9;
			if (guna2Button != null)
			{
				guna2Button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Guna2CheckBox5")]
	internal  Guna2CheckBox Guna2CheckBox5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Guna2GroupBox9")]
	internal  Guna2GroupBox Guna2GroupBox9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Guna2VScrollBar1")]
	internal  Guna2VScrollBar Guna2VScrollBar1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal  DataGridView DataGridFlash
	{
		[CompilerGenerated]
		get
		{
			return _DataGridFlash;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DataGridViewCellEventHandler value2 = DataGridView1_CellContentClick;
			DataGridView dataGridFlash = _DataGridFlash;
			if (dataGridFlash != null)
			{
				dataGridFlash.CellContentClick -= value2;
			}
			_DataGridFlash = value;
			dataGridFlash = _DataGridFlash;
			if (dataGridFlash != null)
			{
				dataGridFlash.CellContentClick += value2;
			}
		}
	}

	internal  Guna2Button Guna2Button10
	{
		[CompilerGenerated]
		get
		{
			return _Guna2Button10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Guna2Button10_Click;
			Guna2Button guna2Button = _Guna2Button10;
			if (guna2Button != null)
			{
				guna2Button.Click -= value2;
			}
			_Guna2Button10 = value;
			guna2Button = _Guna2Button10;
			if (guna2Button != null)
			{
				guna2Button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("txtrawxml")]
	internal  Guna2TextBox txtrawxml
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal  Guna2Button Guna2Button13
	{
		[CompilerGenerated]
		get
		{
			return _Guna2Button13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Guna2Button13_Click;
			Guna2Button guna2Button = _Guna2Button13;
			if (guna2Button != null)
			{
				guna2Button.Click -= value2;
			}
			_Guna2Button13 = value;
			guna2Button = _Guna2Button13;
			if (guna2Button != null)
			{
				guna2Button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("DataGridViewCheckBoxColumn1")]
	internal  DataGridViewCheckBoxColumn DataGridViewCheckBoxColumn1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn3")]
	internal  DataGridViewTextBoxColumn DataGridViewTextBoxColumn3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn1")]
	internal  DataGridViewTextBoxColumn DataGridViewTextBoxColumn1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn2")]
	internal  DataGridViewTextBoxColumn DataGridViewTextBoxColumn2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn7")]
	internal  DataGridViewTextBoxColumn DataGridViewTextBoxColumn7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}
	*/
    internal TextBox TextBox4;
    internal ComboBox ComboBox1;
    internal TextBox TextBox15;
    internal RichTextBox RichTextBox2;
    internal ComboBox Port_Name;
    internal Guna2ProgressBar ProgressBarCOM4S;
    internal Guna2ProgressBar ProgressBarCOM3S;
    internal Guna2ProgressBar ProgressBarCOM2S;
    internal Guna2ProgressBar ProgressBarCOM1S;
    internal TextBox TextBox7;
    internal TextBox TextBox11;
    internal TextBox TextBox1;
    internal System.Windows.Forms.Timer Timer3;
    internal RichTextBox RichTextBox3;
    internal SerialPort SerialPort1;
    internal Guna2CheckBox Guna2CheckBox4;
    internal Guna2CheckBox Guna2CheckBox2;
    internal Guna2TextBox CSC;
    internal Guna2TextBox CP;
    internal Guna2TextBox AP;
    internal Guna2TextBox BL;
    internal Guna2Button Guna2Button14;
    internal Guna2GroupBox Guna2GroupBox3;
    internal Guna2GroupBox Guna2GroupBox1;
    internal Guna2TextBox SamsungCOM4;
    internal Guna2TextBox SamsungCOM3;
    internal Guna2TextBox SamsungCOM2;
    internal Guna2TextBox SamsungCOM1;
    internal Guna2GroupBox Guna2GroupBox2;
    internal Guna2TextBox COM4;
    internal Guna2Button Guna2Button11;
    internal Guna2TextBox COM3;
    internal Guna2TextBox COM2;
    internal Guna2TextBox COM1;
    internal Guna2ProgressBar COM4ProgressBar1;
    internal Guna2ProgressBar COM3ProgressBar1;
    internal Guna2ProgressBar COM2ProgressBar1;
    internal Guna2ProgressBar COM1ProgressBar1;
    internal Guna2GroupBox Guna2GroupBox4;
    internal Guna2TextBox name_flash;
    internal Guna2ComboBox Comboboxport;
    internal Guna2ComboBox cbstorage;
    internal System.Windows.Forms.Timer Timer1;
    internal System.Windows.Forms.Timer Timer2;
    internal Guna2Button Guna2Button1;
    internal Guna2Button Guna2Button23;
    internal Guna2Button Guna2Button25;
    internal Guna2Button Guna2Button2;
    internal Guna2Button Guna2Button4;
    internal Guna2Button Guna2Button3;
    internal Guna2Button Guna2Button5;
    internal Guna2Button Guna2Button12;
    internal Guna2Button Guna2Button8;
    internal Guna2Button Guna2Button7;
    internal Guna2Button Guna2Button6;
    internal Guna2CheckBox Guna2CheckBox1;
    internal TabControlExt TabControlExt1;
    internal TabPage TabPage2;
    internal TabPage TabPage4;
    internal TabPage TabPage1;
    internal Guna2GroupBox Guna2GroupBox5;
    internal Guna2CheckBox cbsetboot;
    internal Guna2Button Guna2Button9;
    internal Guna2CheckBox Guna2CheckBox5;
    internal Guna2GroupBox Guna2GroupBox9;
    internal Guna2VScrollBar Guna2VScrollBar1;
    internal DataGridView DataGridFlash;
    internal Guna2Button Guna2Button10;
    internal Guna2TextBox txtrawxml;
    internal Guna2Button Guna2Button13;
    internal DataGridViewCheckBoxColumn DataGridViewCheckBoxColumn1;
    internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn3;
    internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
    internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn2;
    internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn7;

    public flash()
	{
		base.Load += flash_Load;
		ThisLocation = AppDomain.CurrentDomain.BaseDirectory;
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	[System.Diagnostics.DebuggerStepThrough]
	private void InitializeComponent()
	{
		this.components = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(flash));
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
		this.ComboBox1 = new System.Windows.Forms.ComboBox();
		this.TextBox4 = new System.Windows.Forms.TextBox();
		this.TextBox15 = new System.Windows.Forms.TextBox();
		this.RichTextBox2 = new System.Windows.Forms.RichTextBox();
		this.Guna2CheckBox2 = new Guna.UI2.WinForms.Guna2CheckBox();
		this.ProgressBarCOM4S = new Guna.UI2.WinForms.Guna2ProgressBar();
		this.ProgressBarCOM3S = new Guna.UI2.WinForms.Guna2ProgressBar();
		this.ProgressBarCOM2S = new Guna.UI2.WinForms.Guna2ProgressBar();
		this.ProgressBarCOM1S = new Guna.UI2.WinForms.Guna2ProgressBar();
		this.Port_Name = new System.Windows.Forms.ComboBox();
		this.CSC = new Guna.UI2.WinForms.Guna2TextBox();
		this.CP = new Guna.UI2.WinForms.Guna2TextBox();
		this.AP = new Guna.UI2.WinForms.Guna2TextBox();
		this.BL = new Guna.UI2.WinForms.Guna2TextBox();
		this.Guna2CheckBox4 = new Guna.UI2.WinForms.Guna2CheckBox();
		this.TextBox7 = new System.Windows.Forms.TextBox();
		this.TextBox11 = new System.Windows.Forms.TextBox();
		this.TextBox1 = new System.Windows.Forms.TextBox();
		this.Timer3 = new System.Windows.Forms.Timer(this.components);
		this.RichTextBox3 = new System.Windows.Forms.RichTextBox();
		this.Guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
		this.Guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
		this.Guna2Button23 = new Guna.UI2.WinForms.Guna2Button();
		this.Guna2Button25 = new Guna.UI2.WinForms.Guna2Button();
		this.Guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
		this.Guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
		this.Guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
		this.Guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
		this.SamsungCOM4 = new Guna.UI2.WinForms.Guna2TextBox();
		this.Guna2Button14 = new Guna.UI2.WinForms.Guna2Button();
		this.SamsungCOM3 = new Guna.UI2.WinForms.Guna2TextBox();
		this.SamsungCOM2 = new Guna.UI2.WinForms.Guna2TextBox();
		this.Guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
		this.SamsungCOM1 = new Guna.UI2.WinForms.Guna2TextBox();
		this.SerialPort1 = new System.IO.Ports.SerialPort(this.components);
		this.Guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
		this.Guna2CheckBox1 = new Guna.UI2.WinForms.Guna2CheckBox();
		this.COM4 = new Guna.UI2.WinForms.Guna2TextBox();
		this.Guna2Button11 = new Guna.UI2.WinForms.Guna2Button();
		this.COM3 = new Guna.UI2.WinForms.Guna2TextBox();
		this.COM2 = new Guna.UI2.WinForms.Guna2TextBox();
		this.Guna2Button12 = new Guna.UI2.WinForms.Guna2Button();
		this.COM1 = new Guna.UI2.WinForms.Guna2TextBox();
		this.COM4ProgressBar1 = new Guna.UI2.WinForms.Guna2ProgressBar();
		this.COM3ProgressBar1 = new Guna.UI2.WinForms.Guna2ProgressBar();
		this.COM2ProgressBar1 = new Guna.UI2.WinForms.Guna2ProgressBar();
		this.COM1ProgressBar1 = new Guna.UI2.WinForms.Guna2ProgressBar();
		this.Guna2GroupBox4 = new Guna.UI2.WinForms.Guna2GroupBox();
		this.Guna2Button8 = new Guna.UI2.WinForms.Guna2Button();
		this.Guna2Button7 = new Guna.UI2.WinForms.Guna2Button();
		this.Guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
		this.name_flash = new Guna.UI2.WinForms.Guna2TextBox();
		this.Comboboxport = new Guna.UI2.WinForms.Guna2ComboBox();
		this.cbstorage = new Guna.UI2.WinForms.Guna2ComboBox();
		this.Timer1 = new System.Windows.Forms.Timer(this.components);
		this.Timer2 = new System.Windows.Forms.Timer(this.components);
		this.TabControlExt1 = new Controls.TabControlExt();
		this.TabPage2 = new System.Windows.Forms.TabPage();
		this.TabPage4 = new System.Windows.Forms.TabPage();
		this.TabPage1 = new System.Windows.Forms.TabPage();
		this.Guna2GroupBox5 = new Guna.UI2.WinForms.Guna2GroupBox();
		this.Guna2Button13 = new Guna.UI2.WinForms.Guna2Button();
		this.txtrawxml = new Guna.UI2.WinForms.Guna2TextBox();
		this.Guna2Button9 = new Guna.UI2.WinForms.Guna2Button();
		this.cbsetboot = new Guna.UI2.WinForms.Guna2CheckBox();
		this.Guna2CheckBox5 = new Guna.UI2.WinForms.Guna2CheckBox();
		this.Guna2GroupBox9 = new Guna.UI2.WinForms.Guna2GroupBox();
		this.Guna2VScrollBar1 = new Guna.UI2.WinForms.Guna2VScrollBar();
		this.DataGridFlash = new System.Windows.Forms.DataGridView();
		this.DataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
		this.DataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Guna2Button10 = new Guna.UI2.WinForms.Guna2Button();
		this.Guna2GroupBox1.SuspendLayout();
		this.Guna2GroupBox3.SuspendLayout();
		this.Guna2GroupBox2.SuspendLayout();
		this.Guna2GroupBox4.SuspendLayout();
		this.TabControlExt1.SuspendLayout();
		this.TabPage2.SuspendLayout();
		this.TabPage4.SuspendLayout();
		this.TabPage1.SuspendLayout();
		this.Guna2GroupBox5.SuspendLayout();
		this.Guna2GroupBox9.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.DataGridFlash).BeginInit();
		base.SuspendLayout();
		this.ComboBox1.FormattingEnabled = true;
		this.ComboBox1.Location = new System.Drawing.Point(1065, 726);
		this.ComboBox1.Name = "ComboBox1";
		this.ComboBox1.Size = new System.Drawing.Size(18, 21);
		this.ComboBox1.TabIndex = 230;
		this.ComboBox1.Visible = false;
		this.TextBox4.Location = new System.Drawing.Point(1007, 776);
		this.TextBox4.Name = "TextBox4";
		this.TextBox4.Size = new System.Drawing.Size(10, 20);
		this.TextBox4.TabIndex = 228;
		this.TextBox4.Visible = false;
		this.TextBox15.Location = new System.Drawing.Point(1101, 767);
		this.TextBox15.Name = "TextBox15";
		this.TextBox15.Size = new System.Drawing.Size(72, 20);
		this.TextBox15.TabIndex = 297;
		this.TextBox15.Text = "\"!INFO GPRO \\x08\\x0b\\0\\0\"";
		this.TextBox15.Visible = false;
		this.RichTextBox2.BackColor = System.Drawing.Color.White;
		this.RichTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.RichTextBox2.Font = new System.Drawing.Font("Yu Gothic UI", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.RichTextBox2.Location = new System.Drawing.Point(1327, 1135);
		this.RichTextBox2.Name = "RichTextBox2";
		this.RichTextBox2.Size = new System.Drawing.Size(106, 20);
		this.RichTextBox2.TabIndex = 3;
		this.RichTextBox2.Text = "";
		this.Guna2CheckBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
		this.Guna2CheckBox2.Animated = true;
		this.Guna2CheckBox2.AutoSize = true;
		this.Guna2CheckBox2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
		this.Guna2CheckBox2.CheckedState.BorderRadius = 4;
		this.Guna2CheckBox2.CheckedState.BorderThickness = 2;
		this.Guna2CheckBox2.CheckedState.FillColor = System.Drawing.Color.FromArgb(21, 87, 255);
		this.Guna2CheckBox2.Font = new System.Drawing.Font("Yu Gothic UI", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Guna2CheckBox2.ForeColor = System.Drawing.Color.White;
		this.Guna2CheckBox2.Location = new System.Drawing.Point(323, 6);
		this.Guna2CheckBox2.Name = "Guna2CheckBox2";
		this.Guna2CheckBox2.Size = new System.Drawing.Size(100, 21);
		this.Guna2CheckBox2.TabIndex = 468;
		this.Guna2CheckBox2.Text = "Auto Detect";
		this.Guna2CheckBox2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.Guna2CheckBox2.UncheckedState.BorderRadius = 4;
		this.Guna2CheckBox2.UncheckedState.BorderThickness = 1;
		this.Guna2CheckBox2.UncheckedState.FillColor = System.Drawing.Color.FromArgb(70, 70, 70);
		this.ProgressBarCOM4S.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.ProgressBarCOM4S.BackColor = System.Drawing.Color.Transparent;
		this.ProgressBarCOM4S.BorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.ProgressBarCOM4S.BorderRadius = 5;
		this.ProgressBarCOM4S.BorderThickness = 2;
		this.ProgressBarCOM4S.FillColor = System.Drawing.Color.FromArgb(70, 70, 70);
		this.ProgressBarCOM4S.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.ProgressBarCOM4S.ForeColor = System.Drawing.Color.White;
		this.ProgressBarCOM4S.Location = new System.Drawing.Point(347, 33);
		this.ProgressBarCOM4S.Name = "ProgressBarCOM4S";
		this.ProgressBarCOM4S.ProgressColor = System.Drawing.Color.FromArgb(0, 85, 207);
		this.ProgressBarCOM4S.ProgressColor2 = System.Drawing.Color.FromArgb(0, 85, 207);
		this.ProgressBarCOM4S.ShadowDecoration.BorderRadius = 5;
		this.ProgressBarCOM4S.ShowText = true;
		this.ProgressBarCOM4S.Size = new System.Drawing.Size(117, 27);
		this.ProgressBarCOM4S.TabIndex = 299;
		this.ProgressBarCOM4S.TextMode = Guna.UI2.WinForms.Enums.ProgressBarTextMode.Custom;
		this.ProgressBarCOM4S.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
		this.ProgressBarCOM3S.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.ProgressBarCOM3S.BackColor = System.Drawing.Color.Transparent;
		this.ProgressBarCOM3S.BorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.ProgressBarCOM3S.BorderRadius = 5;
		this.ProgressBarCOM3S.BorderThickness = 2;
		this.ProgressBarCOM3S.FillColor = System.Drawing.Color.FromArgb(70, 70, 70);
		this.ProgressBarCOM3S.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.ProgressBarCOM3S.ForeColor = System.Drawing.Color.White;
		this.ProgressBarCOM3S.Location = new System.Drawing.Point(237, 33);
		this.ProgressBarCOM3S.Name = "ProgressBarCOM3S";
		this.ProgressBarCOM3S.ProgressColor = System.Drawing.Color.FromArgb(0, 85, 207);
		this.ProgressBarCOM3S.ProgressColor2 = System.Drawing.Color.FromArgb(0, 85, 207);
		this.ProgressBarCOM3S.ShadowDecoration.BorderRadius = 5;
		this.ProgressBarCOM3S.ShowText = true;
		this.ProgressBarCOM3S.Size = new System.Drawing.Size(104, 27);
		this.ProgressBarCOM3S.TabIndex = 299;
		this.ProgressBarCOM3S.TextMode = Guna.UI2.WinForms.Enums.ProgressBarTextMode.Custom;
		this.ProgressBarCOM3S.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
		this.ProgressBarCOM2S.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.ProgressBarCOM2S.BackColor = System.Drawing.Color.Transparent;
		this.ProgressBarCOM2S.BorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.ProgressBarCOM2S.BorderRadius = 5;
		this.ProgressBarCOM2S.BorderThickness = 2;
		this.ProgressBarCOM2S.FillColor = System.Drawing.Color.FromArgb(70, 70, 70);
		this.ProgressBarCOM2S.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.ProgressBarCOM2S.ForeColor = System.Drawing.Color.White;
		this.ProgressBarCOM2S.Location = new System.Drawing.Point(127, 33);
		this.ProgressBarCOM2S.Name = "ProgressBarCOM2S";
		this.ProgressBarCOM2S.ProgressColor = System.Drawing.Color.FromArgb(0, 85, 207);
		this.ProgressBarCOM2S.ProgressColor2 = System.Drawing.Color.FromArgb(0, 85, 207);
		this.ProgressBarCOM2S.ShadowDecoration.BorderRadius = 5;
		this.ProgressBarCOM2S.ShowText = true;
		this.ProgressBarCOM2S.Size = new System.Drawing.Size(104, 27);
		this.ProgressBarCOM2S.TabIndex = 299;
		this.ProgressBarCOM2S.TextMode = Guna.UI2.WinForms.Enums.ProgressBarTextMode.Custom;
		this.ProgressBarCOM2S.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
		this.ProgressBarCOM1S.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.ProgressBarCOM1S.BackColor = System.Drawing.Color.Transparent;
		this.ProgressBarCOM1S.BorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.ProgressBarCOM1S.BorderRadius = 5;
		this.ProgressBarCOM1S.BorderThickness = 2;
		this.ProgressBarCOM1S.FillColor = System.Drawing.Color.FromArgb(70, 70, 70);
		this.ProgressBarCOM1S.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.ProgressBarCOM1S.ForeColor = System.Drawing.Color.White;
		this.ProgressBarCOM1S.Location = new System.Drawing.Point(5, 33);
		this.ProgressBarCOM1S.Name = "ProgressBarCOM1S";
		this.ProgressBarCOM1S.ProgressColor = System.Drawing.Color.FromArgb(0, 85, 207);
		this.ProgressBarCOM1S.ProgressColor2 = System.Drawing.Color.FromArgb(0, 85, 207);
		this.ProgressBarCOM1S.ShadowDecoration.BorderRadius = 5;
		this.ProgressBarCOM1S.ShowText = true;
		this.ProgressBarCOM1S.Size = new System.Drawing.Size(116, 27);
		this.ProgressBarCOM1S.TabIndex = 299;
		this.ProgressBarCOM1S.TextMode = Guna.UI2.WinForms.Enums.ProgressBarTextMode.Custom;
		this.ProgressBarCOM1S.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
		this.Port_Name.FormattingEnabled = true;
		this.Port_Name.Location = new System.Drawing.Point(424, 627);
		this.Port_Name.Name = "Port_Name";
		this.Port_Name.Size = new System.Drawing.Size(249, 21);
		this.Port_Name.TabIndex = 230;
		this.Port_Name.Visible = false;
		this.CSC.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.CSC.Animated = true;
		this.CSC.BackColor = System.Drawing.Color.Transparent;
		this.CSC.BorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.CSC.BorderRadius = 5;
		this.CSC.BorderThickness = 2;
		this.CSC.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.CSC.DefaultText = "";
		this.CSC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(55, 55, 55);
		this.CSC.DisabledState.FillColor = System.Drawing.Color.FromArgb(55, 55, 55);
		this.CSC.DisabledState.ForeColor = System.Drawing.Color.Gray;
		this.CSC.DisabledState.PlaceholderForeColor = System.Drawing.Color.Gray;
		this.CSC.FillColor = System.Drawing.Color.FromArgb(70, 70, 70);
		this.CSC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.CSC.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.CSC.ForeColor = System.Drawing.Color.White;
		this.CSC.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
		this.CSC.Location = new System.Drawing.Point(6, 103);
		this.CSC.Name = "CSC";
		this.CSC.PasswordChar = '\0';
		this.CSC.PlaceholderForeColor = System.Drawing.Color.DarkGray;
		this.CSC.PlaceholderText = "CSC";
		this.CSC.SelectedText = "";
		this.CSC.ShadowDecoration.Color = System.Drawing.Color.DimGray;
		this.CSC.ShadowDecoration.Depth = 15;
		this.CSC.Size = new System.Drawing.Size(408, 26);
		this.CSC.TabIndex = 496;
		this.CSC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.CP.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.CP.Animated = true;
		this.CP.BackColor = System.Drawing.Color.Transparent;
		this.CP.BorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.CP.BorderRadius = 5;
		this.CP.BorderThickness = 2;
		this.CP.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.CP.DefaultText = "";
		this.CP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(55, 55, 55);
		this.CP.DisabledState.FillColor = System.Drawing.Color.FromArgb(55, 55, 55);
		this.CP.DisabledState.ForeColor = System.Drawing.Color.Gray;
		this.CP.DisabledState.PlaceholderForeColor = System.Drawing.Color.Gray;
		this.CP.FillColor = System.Drawing.Color.FromArgb(70, 70, 70);
		this.CP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.CP.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.CP.ForeColor = System.Drawing.Color.White;
		this.CP.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
		this.CP.Location = new System.Drawing.Point(6, 71);
		this.CP.Name = "CP";
		this.CP.PasswordChar = '\0';
		this.CP.PlaceholderForeColor = System.Drawing.Color.DarkGray;
		this.CP.PlaceholderText = "CP";
		this.CP.SelectedText = "";
		this.CP.ShadowDecoration.Color = System.Drawing.Color.DimGray;
		this.CP.ShadowDecoration.Depth = 15;
		this.CP.Size = new System.Drawing.Size(408, 26);
		this.CP.TabIndex = 495;
		this.CP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.AP.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.AP.Animated = true;
		this.AP.BackColor = System.Drawing.Color.Transparent;
		this.AP.BorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.AP.BorderRadius = 5;
		this.AP.BorderThickness = 2;
		this.AP.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.AP.DefaultText = "";
		this.AP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(55, 55, 55);
		this.AP.DisabledState.FillColor = System.Drawing.Color.FromArgb(55, 55, 55);
		this.AP.DisabledState.ForeColor = System.Drawing.Color.Gray;
		this.AP.DisabledState.PlaceholderForeColor = System.Drawing.Color.Gray;
		this.AP.FillColor = System.Drawing.Color.FromArgb(70, 70, 70);
		this.AP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.AP.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.AP.ForeColor = System.Drawing.Color.White;
		this.AP.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
		this.AP.Location = new System.Drawing.Point(6, 39);
		this.AP.Name = "AP";
		this.AP.PasswordChar = '\0';
		this.AP.PlaceholderForeColor = System.Drawing.Color.DarkGray;
		this.AP.PlaceholderText = "AP";
		this.AP.SelectedText = "";
		this.AP.ShadowDecoration.Color = System.Drawing.Color.DimGray;
		this.AP.ShadowDecoration.Depth = 15;
		this.AP.Size = new System.Drawing.Size(408, 26);
		this.AP.TabIndex = 494;
		this.AP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.BL.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.BL.Animated = true;
		this.BL.BackColor = System.Drawing.Color.Transparent;
		this.BL.BorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.BL.BorderRadius = 5;
		this.BL.BorderThickness = 2;
		this.BL.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.BL.DefaultText = "";
		this.BL.DisabledState.BorderColor = System.Drawing.Color.FromArgb(55, 55, 55);
		this.BL.DisabledState.FillColor = System.Drawing.Color.FromArgb(55, 55, 55);
		this.BL.DisabledState.ForeColor = System.Drawing.Color.Gray;
		this.BL.DisabledState.PlaceholderForeColor = System.Drawing.Color.Gray;
		this.BL.FillColor = System.Drawing.Color.FromArgb(70, 70, 70);
		this.BL.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.BL.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.BL.ForeColor = System.Drawing.Color.White;
		this.BL.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
		this.BL.Location = new System.Drawing.Point(6, 7);
		this.BL.Name = "BL";
		this.BL.PasswordChar = '\0';
		this.BL.PlaceholderForeColor = System.Drawing.Color.DarkGray;
		this.BL.PlaceholderText = "BL";
		this.BL.SelectedText = "";
		this.BL.ShadowDecoration.Color = System.Drawing.Color.DimGray;
		this.BL.ShadowDecoration.Depth = 15;
		this.BL.Size = new System.Drawing.Size(408, 26);
		this.BL.TabIndex = 493;
		this.BL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.Guna2CheckBox4.Anchor = System.Windows.Forms.AnchorStyles.Right;
		this.Guna2CheckBox4.Animated = true;
		this.Guna2CheckBox4.AutoSize = true;
		this.Guna2CheckBox4.Checked = true;
		this.Guna2CheckBox4.CheckedState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
		this.Guna2CheckBox4.CheckedState.BorderRadius = 4;
		this.Guna2CheckBox4.CheckedState.BorderThickness = 2;
		this.Guna2CheckBox4.CheckedState.FillColor = System.Drawing.Color.FromArgb(21, 87, 255);
		this.Guna2CheckBox4.CheckState = System.Windows.Forms.CheckState.Checked;
		this.Guna2CheckBox4.Font = new System.Drawing.Font("Yu Gothic UI", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Guna2CheckBox4.ForeColor = System.Drawing.Color.White;
		this.Guna2CheckBox4.Location = new System.Drawing.Point(358, 141);
		this.Guna2CheckBox4.Name = "Guna2CheckBox4";
		this.Guna2CheckBox4.Size = new System.Drawing.Size(105, 21);
		this.Guna2CheckBox4.TabIndex = 467;
		this.Guna2CheckBox4.Text = "Auto Reboot";
		this.Guna2CheckBox4.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.Guna2CheckBox4.UncheckedState.BorderRadius = 4;
		this.Guna2CheckBox4.UncheckedState.BorderThickness = 1;
		this.Guna2CheckBox4.UncheckedState.FillColor = System.Drawing.Color.FromArgb(70, 70, 70);
		this.TextBox7.Location = new System.Drawing.Point(1023, 767);
		this.TextBox7.Name = "TextBox7";
		this.TextBox7.Size = new System.Drawing.Size(72, 20);
		this.TextBox7.TabIndex = 301;
		this.TextBox7.Visible = false;
		this.TextBox11.Location = new System.Drawing.Point(1265, 1184);
		this.TextBox11.Name = "TextBox11";
		this.TextBox11.Size = new System.Drawing.Size(100, 20);
		this.TextBox11.TabIndex = 302;
		this.TextBox1.Location = new System.Drawing.Point(1301, 1088);
		this.TextBox1.Name = "TextBox1";
		this.TextBox1.Size = new System.Drawing.Size(100, 20);
		this.TextBox1.TabIndex = 303;
		this.Timer3.Interval = 1000;
		this.RichTextBox3.BackColor = System.Drawing.Color.White;
		this.RichTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.RichTextBox3.Font = new System.Drawing.Font("Yu Gothic UI", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.RichTextBox3.Location = new System.Drawing.Point(1201, 726);
		this.RichTextBox3.Name = "RichTextBox3";
		this.RichTextBox3.Size = new System.Drawing.Size(106, 165);
		this.RichTextBox3.TabIndex = 304;
		this.RichTextBox3.Text = "";
		this.RichTextBox3.Visible = false;
		this.Guna2GroupBox1.BackColor = System.Drawing.Color.Transparent;
		this.Guna2GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.Guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.Guna2GroupBox1.BorderRadius = 6;
		this.Guna2GroupBox1.Controls.Add(this.Guna2Button1);
		this.Guna2GroupBox1.Controls.Add(this.CSC);
		this.Guna2GroupBox1.Controls.Add(this.Guna2Button23);
		this.Guna2GroupBox1.Controls.Add(this.CP);
		this.Guna2GroupBox1.Controls.Add(this.Guna2Button25);
		this.Guna2GroupBox1.Controls.Add(this.AP);
		this.Guna2GroupBox1.Controls.Add(this.Guna2Button2);
		this.Guna2GroupBox1.Controls.Add(this.BL);
		this.Guna2GroupBox1.Controls.Add(this.Guna2CheckBox4);
		this.Guna2GroupBox1.Controls.Add(this.Guna2Button4);
		this.Guna2GroupBox1.Controls.Add(this.Guna2Button3);
		this.Guna2GroupBox1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.Guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0);
		this.Guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(50, 50, 50);
		this.Guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.Guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(125, 137, 149);
		this.Guna2GroupBox1.Location = new System.Drawing.Point(6, 111);
		this.Guna2GroupBox1.Name = "Guna2GroupBox1";
		this.Guna2GroupBox1.ShadowDecoration.BorderRadius = 9;
		this.Guna2GroupBox1.ShadowDecoration.Color = System.Drawing.Color.White;
		this.Guna2GroupBox1.ShadowDecoration.Depth = 15;
		this.Guna2GroupBox1.Size = new System.Drawing.Size(469, 172);
		this.Guna2GroupBox1.TabIndex = 511;
		this.Guna2Button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
		this.Guna2Button1.BorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.Guna2Button1.BorderRadius = 4;
		this.Guna2Button1.BorderThickness = 2;
		this.Guna2Button1.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
		this.Guna2Button1.CheckedState.FillColor = System.Drawing.Color.LightGray;
		this.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(55, 55, 55);
		this.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
		this.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(55, 55, 55);
		this.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.Gray;
		this.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(70, 70, 70);
		this.Guna2Button1.Font = new System.Drawing.Font("Yu Gothic UI", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Guna2Button1.ForeColor = System.Drawing.Color.White;
		this.Guna2Button1.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
		this.Guna2Button1.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
		this.Guna2Button1.Image = (System.Drawing.Image)resources.GetObject("Guna2Button1.Image");
		this.Guna2Button1.ImageSize = new System.Drawing.Size(25, 25);
		this.Guna2Button1.Location = new System.Drawing.Point(422, 7);
		this.Guna2Button1.Name = "Guna2Button1";
		this.Guna2Button1.PressedColor = System.Drawing.Color.Empty;
		this.Guna2Button1.Size = new System.Drawing.Size(41, 26);
		this.Guna2Button1.TabIndex = 462;
		this.Guna2Button1.TextFormatNoPrefix = true;
		this.Guna2Button23.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.Guna2Button23.BorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.Guna2Button23.BorderRadius = 4;
		this.Guna2Button23.BorderThickness = 2;
		this.Guna2Button23.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
		this.Guna2Button23.CheckedState.FillColor = System.Drawing.Color.LightGray;
		this.Guna2Button23.DisabledState.BorderColor = System.Drawing.Color.FromArgb(55, 55, 55);
		this.Guna2Button23.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
		this.Guna2Button23.DisabledState.FillColor = System.Drawing.Color.FromArgb(55, 55, 55);
		this.Guna2Button23.DisabledState.ForeColor = System.Drawing.Color.Gray;
		this.Guna2Button23.FillColor = System.Drawing.Color.FromArgb(70, 70, 70);
		this.Guna2Button23.Font = new System.Drawing.Font("Yu Gothic UI", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Guna2Button23.ForeColor = System.Drawing.Color.White;
		this.Guna2Button23.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
		this.Guna2Button23.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
		this.Guna2Button23.Image = Properties.Resources.flash__1_;
		this.Guna2Button23.ImageSize = new System.Drawing.Size(25, 25);
		this.Guna2Button23.Location = new System.Drawing.Point(6, 138);
		this.Guna2Button23.Name = "Guna2Button23";
		this.Guna2Button23.PressedColor = System.Drawing.Color.Empty;
		this.Guna2Button23.Size = new System.Drawing.Size(203, 26);
		this.Guna2Button23.TabIndex = 461;
		this.Guna2Button23.Text = "Start Flash";
		this.Guna2Button23.TextFormatNoPrefix = true;
		this.Guna2Button25.Anchor = System.Windows.Forms.AnchorStyles.Right;
		this.Guna2Button25.BorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.Guna2Button25.BorderRadius = 4;
		this.Guna2Button25.BorderThickness = 2;
		this.Guna2Button25.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
		this.Guna2Button25.CheckedState.FillColor = System.Drawing.Color.LightGray;
		this.Guna2Button25.CheckedState.Image = (System.Drawing.Image)resources.GetObject("resource.Image");
		this.Guna2Button25.DisabledState.BorderColor = System.Drawing.Color.FromArgb(55, 55, 55);
		this.Guna2Button25.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
		this.Guna2Button25.DisabledState.FillColor = System.Drawing.Color.FromArgb(55, 55, 55);
		this.Guna2Button25.DisabledState.ForeColor = System.Drawing.Color.Gray;
		this.Guna2Button25.FillColor = System.Drawing.Color.FromArgb(70, 70, 70);
		this.Guna2Button25.Font = new System.Drawing.Font("Yu Gothic UI", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Guna2Button25.ForeColor = System.Drawing.Color.White;
		this.Guna2Button25.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
		this.Guna2Button25.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
		this.Guna2Button25.Image = Properties.Resources.broom__1_;
		this.Guna2Button25.ImageSize = new System.Drawing.Size(25, 25);
		this.Guna2Button25.Location = new System.Drawing.Point(215, 138);
		this.Guna2Button25.Name = "Guna2Button25";
		this.Guna2Button25.PressedColor = System.Drawing.Color.Empty;
		this.Guna2Button25.Size = new System.Drawing.Size(135, 26);
		this.Guna2Button25.TabIndex = 463;
		this.Guna2Button25.Text = "Clear All";
		this.Guna2Button25.TextFormatNoPrefix = true;
		this.Guna2Button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
		this.Guna2Button2.BorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.Guna2Button2.BorderRadius = 4;
		this.Guna2Button2.BorderThickness = 2;
		this.Guna2Button2.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
		this.Guna2Button2.CheckedState.FillColor = System.Drawing.Color.LightGray;
		this.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(55, 55, 55);
		this.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
		this.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(55, 55, 55);
		this.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.Gray;
		this.Guna2Button2.FillColor = System.Drawing.Color.FromArgb(70, 70, 70);
		this.Guna2Button2.Font = new System.Drawing.Font("Yu Gothic UI", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Guna2Button2.ForeColor = System.Drawing.Color.White;
		this.Guna2Button2.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
		this.Guna2Button2.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
		this.Guna2Button2.Image = (System.Drawing.Image)resources.GetObject("Guna2Button2.Image");
		this.Guna2Button2.ImageSize = new System.Drawing.Size(25, 25);
		this.Guna2Button2.Location = new System.Drawing.Point(422, 39);
		this.Guna2Button2.Name = "Guna2Button2";
		this.Guna2Button2.PressedColor = System.Drawing.Color.Empty;
		this.Guna2Button2.Size = new System.Drawing.Size(41, 26);
		this.Guna2Button2.TabIndex = 463;
		this.Guna2Button2.TextFormatNoPrefix = true;
		this.Guna2Button4.Anchor = System.Windows.Forms.AnchorStyles.Right;
		this.Guna2Button4.BorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.Guna2Button4.BorderRadius = 4;
		this.Guna2Button4.BorderThickness = 2;
		this.Guna2Button4.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
		this.Guna2Button4.CheckedState.FillColor = System.Drawing.Color.LightGray;
		this.Guna2Button4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(55, 55, 55);
		this.Guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
		this.Guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(55, 55, 55);
		this.Guna2Button4.DisabledState.ForeColor = System.Drawing.Color.Gray;
		this.Guna2Button4.FillColor = System.Drawing.Color.FromArgb(70, 70, 70);
		this.Guna2Button4.Font = new System.Drawing.Font("Yu Gothic UI", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Guna2Button4.ForeColor = System.Drawing.Color.White;
		this.Guna2Button4.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
		this.Guna2Button4.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
		this.Guna2Button4.Image = (System.Drawing.Image)resources.GetObject("Guna2Button4.Image");
		this.Guna2Button4.ImageSize = new System.Drawing.Size(25, 25);
		this.Guna2Button4.Location = new System.Drawing.Point(422, 103);
		this.Guna2Button4.Name = "Guna2Button4";
		this.Guna2Button4.PressedColor = System.Drawing.Color.Empty;
		this.Guna2Button4.Size = new System.Drawing.Size(41, 26);
		this.Guna2Button4.TabIndex = 465;
		this.Guna2Button4.TextFormatNoPrefix = true;
		this.Guna2Button3.Anchor = System.Windows.Forms.AnchorStyles.Right;
		this.Guna2Button3.BorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.Guna2Button3.BorderRadius = 4;
		this.Guna2Button3.BorderThickness = 2;
		this.Guna2Button3.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
		this.Guna2Button3.CheckedState.FillColor = System.Drawing.Color.LightGray;
		this.Guna2Button3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(55, 55, 55);
		this.Guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
		this.Guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(55, 55, 55);
		this.Guna2Button3.DisabledState.ForeColor = System.Drawing.Color.Gray;
		this.Guna2Button3.FillColor = System.Drawing.Color.FromArgb(70, 70, 70);
		this.Guna2Button3.Font = new System.Drawing.Font("Yu Gothic UI", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Guna2Button3.ForeColor = System.Drawing.Color.White;
		this.Guna2Button3.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
		this.Guna2Button3.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
		this.Guna2Button3.Image = (System.Drawing.Image)resources.GetObject("Guna2Button3.Image");
		this.Guna2Button3.ImageSize = new System.Drawing.Size(25, 25);
		this.Guna2Button3.Location = new System.Drawing.Point(422, 71);
		this.Guna2Button3.Name = "Guna2Button3";
		this.Guna2Button3.PressedColor = System.Drawing.Color.Empty;
		this.Guna2Button3.Size = new System.Drawing.Size(41, 26);
		this.Guna2Button3.TabIndex = 464;
		this.Guna2Button3.TextFormatNoPrefix = true;
		this.Guna2GroupBox3.BackColor = System.Drawing.Color.Transparent;
		this.Guna2GroupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.Guna2GroupBox3.BorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.Guna2GroupBox3.BorderRadius = 6;
		this.Guna2GroupBox3.Controls.Add(this.SamsungCOM4);
		this.Guna2GroupBox3.Controls.Add(this.Guna2Button14);
		this.Guna2GroupBox3.Controls.Add(this.SamsungCOM3);
		this.Guna2GroupBox3.Controls.Add(this.Guna2CheckBox2);
		this.Guna2GroupBox3.Controls.Add(this.SamsungCOM2);
		this.Guna2GroupBox3.Controls.Add(this.Guna2Button5);
		this.Guna2GroupBox3.Controls.Add(this.SamsungCOM1);
		this.Guna2GroupBox3.Controls.Add(this.ProgressBarCOM4S);
		this.Guna2GroupBox3.Controls.Add(this.ProgressBarCOM3S);
		this.Guna2GroupBox3.Controls.Add(this.ProgressBarCOM2S);
		this.Guna2GroupBox3.Controls.Add(this.ProgressBarCOM1S);
		this.Guna2GroupBox3.Cursor = System.Windows.Forms.Cursors.Hand;
		this.Guna2GroupBox3.CustomBorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.Guna2GroupBox3.CustomBorderThickness = new System.Windows.Forms.Padding(0);
		this.Guna2GroupBox3.FillColor = System.Drawing.Color.FromArgb(50, 50, 50);
		this.Guna2GroupBox3.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.Guna2GroupBox3.ForeColor = System.Drawing.Color.FromArgb(125, 137, 149);
		this.Guna2GroupBox3.Location = new System.Drawing.Point(6, 6);
		this.Guna2GroupBox3.Name = "Guna2GroupBox3";
		this.Guna2GroupBox3.ShadowDecoration.BorderRadius = 9;
		this.Guna2GroupBox3.ShadowDecoration.Color = System.Drawing.Color.White;
		this.Guna2GroupBox3.ShadowDecoration.Depth = 15;
		this.Guna2GroupBox3.Size = new System.Drawing.Size(469, 99);
		this.Guna2GroupBox3.TabIndex = 510;
		this.SamsungCOM4.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.SamsungCOM4.Animated = true;
		this.SamsungCOM4.BackColor = System.Drawing.Color.Transparent;
		this.SamsungCOM4.BorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.SamsungCOM4.BorderRadius = 5;
		this.SamsungCOM4.BorderThickness = 2;
		this.SamsungCOM4.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.SamsungCOM4.DefaultText = "";
		this.SamsungCOM4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(55, 55, 55);
		this.SamsungCOM4.DisabledState.FillColor = System.Drawing.Color.FromArgb(70, 70, 70);
		this.SamsungCOM4.DisabledState.ForeColor = System.Drawing.Color.White;
		this.SamsungCOM4.DisabledState.PlaceholderForeColor = System.Drawing.Color.Gray;
		this.SamsungCOM4.FillColor = System.Drawing.Color.FromArgb(70, 70, 70);
		this.SamsungCOM4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.SamsungCOM4.FocusedState.FillColor = System.Drawing.Color.FromArgb(70, 70, 70);
		this.SamsungCOM4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.SamsungCOM4.ForeColor = System.Drawing.Color.White;
		this.SamsungCOM4.HoverState.BorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.SamsungCOM4.HoverState.FillColor = System.Drawing.Color.FromArgb(70, 70, 70);
		this.SamsungCOM4.Location = new System.Drawing.Point(347, 66);
		this.SamsungCOM4.Name = "SamsungCOM4";
		this.SamsungCOM4.PasswordChar = '\0';
		this.SamsungCOM4.PlaceholderForeColor = System.Drawing.Color.DarkGray;
		this.SamsungCOM4.PlaceholderText = "";
		this.SamsungCOM4.ReadOnly = true;
		this.SamsungCOM4.SelectedText = "";
		this.SamsungCOM4.ShadowDecoration.Color = System.Drawing.Color.DimGray;
		this.SamsungCOM4.ShadowDecoration.Depth = 15;
		this.SamsungCOM4.Size = new System.Drawing.Size(117, 26);
		this.SamsungCOM4.TabIndex = 500;
		this.SamsungCOM4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.Guna2Button14.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.Guna2Button14.BorderColor = System.Drawing.Color.DimGray;
		this.Guna2Button14.BorderRadius = 4;
		this.Guna2Button14.BorderThickness = 1;
		this.Guna2Button14.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
		this.Guna2Button14.CheckedState.FillColor = System.Drawing.Color.LightGray;
		this.Guna2Button14.CheckedState.Image = (System.Drawing.Image)resources.GetObject("resource.Image1");
		this.Guna2Button14.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
		this.Guna2Button14.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
		this.Guna2Button14.DisabledState.FillColor = System.Drawing.Color.DarkGray;
		this.Guna2Button14.DisabledState.ForeColor = System.Drawing.Color.LightGray;
		this.Guna2Button14.FillColor = System.Drawing.Color.DimGray;
		this.Guna2Button14.Font = new System.Drawing.Font("Yu Gothic UI", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Guna2Button14.ForeColor = System.Drawing.Color.White;
		this.Guna2Button14.HoverState.BorderColor = System.Drawing.Color.DimGray;
		this.Guna2Button14.HoverState.CustomBorderColor = System.Drawing.Color.DimGray;
		this.Guna2Button14.HoverState.FillColor = System.Drawing.Color.DimGray;
		this.Guna2Button14.HoverState.ForeColor = System.Drawing.Color.White;
		this.Guna2Button14.ImageSize = new System.Drawing.Size(25, 25);
		this.Guna2Button14.Location = new System.Drawing.Point(6, 6);
		this.Guna2Button14.Name = "Guna2Button14";
		this.Guna2Button14.PressedColor = System.Drawing.Color.DimGray;
		this.Guna2Button14.Size = new System.Drawing.Size(311, 21);
		this.Guna2Button14.TabIndex = 469;
		this.Guna2Button14.Text = "Connected Devices";
		this.Guna2Button14.TextFormatNoPrefix = true;
		this.SamsungCOM3.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.SamsungCOM3.Animated = true;
		this.SamsungCOM3.BackColor = System.Drawing.Color.Transparent;
		this.SamsungCOM3.BorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.SamsungCOM3.BorderRadius = 5;
		this.SamsungCOM3.BorderThickness = 2;
		this.SamsungCOM3.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.SamsungCOM3.DefaultText = "";
		this.SamsungCOM3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(55, 55, 55);
		this.SamsungCOM3.DisabledState.FillColor = System.Drawing.Color.FromArgb(70, 70, 70);
		this.SamsungCOM3.DisabledState.ForeColor = System.Drawing.Color.White;
		this.SamsungCOM3.DisabledState.PlaceholderForeColor = System.Drawing.Color.Gray;
		this.SamsungCOM3.FillColor = System.Drawing.Color.FromArgb(70, 70, 70);
		this.SamsungCOM3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.SamsungCOM3.FocusedState.FillColor = System.Drawing.Color.FromArgb(70, 70, 70);
		this.SamsungCOM3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.SamsungCOM3.ForeColor = System.Drawing.Color.White;
		this.SamsungCOM3.HoverState.BorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.SamsungCOM3.HoverState.FillColor = System.Drawing.Color.FromArgb(70, 70, 70);
		this.SamsungCOM3.Location = new System.Drawing.Point(237, 66);
		this.SamsungCOM3.Name = "SamsungCOM3";
		this.SamsungCOM3.PasswordChar = '\0';
		this.SamsungCOM3.PlaceholderForeColor = System.Drawing.Color.DarkGray;
		this.SamsungCOM3.PlaceholderText = "";
		this.SamsungCOM3.ReadOnly = true;
		this.SamsungCOM3.SelectedText = "";
		this.SamsungCOM3.ShadowDecoration.Color = System.Drawing.Color.DimGray;
		this.SamsungCOM3.ShadowDecoration.Depth = 15;
		this.SamsungCOM3.Size = new System.Drawing.Size(104, 26);
		this.SamsungCOM3.TabIndex = 499;
		this.SamsungCOM3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.SamsungCOM2.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.SamsungCOM2.Animated = true;
		this.SamsungCOM2.BackColor = System.Drawing.Color.Transparent;
		this.SamsungCOM2.BorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.SamsungCOM2.BorderRadius = 5;
		this.SamsungCOM2.BorderThickness = 2;
		this.SamsungCOM2.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.SamsungCOM2.DefaultText = "";
		this.SamsungCOM2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(55, 55, 55);
		this.SamsungCOM2.DisabledState.FillColor = System.Drawing.Color.FromArgb(70, 70, 70);
		this.SamsungCOM2.DisabledState.ForeColor = System.Drawing.Color.White;
		this.SamsungCOM2.DisabledState.PlaceholderForeColor = System.Drawing.Color.Gray;
		this.SamsungCOM2.FillColor = System.Drawing.Color.FromArgb(70, 70, 70);
		this.SamsungCOM2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.SamsungCOM2.FocusedState.FillColor = System.Drawing.Color.FromArgb(70, 70, 70);
		this.SamsungCOM2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.SamsungCOM2.ForeColor = System.Drawing.Color.White;
		this.SamsungCOM2.HoverState.BorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.SamsungCOM2.HoverState.FillColor = System.Drawing.Color.FromArgb(70, 70, 70);
		this.SamsungCOM2.Location = new System.Drawing.Point(127, 66);
		this.SamsungCOM2.Name = "SamsungCOM2";
		this.SamsungCOM2.PasswordChar = '\0';
		this.SamsungCOM2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
		this.SamsungCOM2.PlaceholderText = "";
		this.SamsungCOM2.ReadOnly = true;
		this.SamsungCOM2.SelectedText = "";
		this.SamsungCOM2.ShadowDecoration.Color = System.Drawing.Color.DimGray;
		this.SamsungCOM2.ShadowDecoration.Depth = 15;
		this.SamsungCOM2.Size = new System.Drawing.Size(104, 26);
		this.SamsungCOM2.TabIndex = 498;
		this.SamsungCOM2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.Guna2Button5.Anchor = System.Windows.Forms.AnchorStyles.Right;
		this.Guna2Button5.BorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.Guna2Button5.BorderRadius = 4;
		this.Guna2Button5.BorderThickness = 2;
		this.Guna2Button5.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
		this.Guna2Button5.CheckedState.FillColor = System.Drawing.Color.LightGray;
		this.Guna2Button5.DisabledState.BorderColor = System.Drawing.Color.FromArgb(55, 55, 55);
		this.Guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
		this.Guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(55, 55, 55);
		this.Guna2Button5.DisabledState.ForeColor = System.Drawing.Color.Gray;
		this.Guna2Button5.FillColor = System.Drawing.Color.FromArgb(70, 70, 70);
		this.Guna2Button5.Font = new System.Drawing.Font("Yu Gothic UI", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Guna2Button5.ForeColor = System.Drawing.Color.White;
		this.Guna2Button5.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
		this.Guna2Button5.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
		this.Guna2Button5.Image = Properties.Resources.magnifier__1_;
		this.Guna2Button5.Location = new System.Drawing.Point(422, 6);
		this.Guna2Button5.Name = "Guna2Button5";
		this.Guna2Button5.PressedColor = System.Drawing.Color.Empty;
		this.Guna2Button5.Size = new System.Drawing.Size(41, 21);
		this.Guna2Button5.TabIndex = 463;
		this.Guna2Button5.TextFormatNoPrefix = true;
		this.SamsungCOM1.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.SamsungCOM1.Animated = true;
		this.SamsungCOM1.BackColor = System.Drawing.Color.Transparent;
		this.SamsungCOM1.BorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.SamsungCOM1.BorderRadius = 5;
		this.SamsungCOM1.BorderThickness = 2;
		this.SamsungCOM1.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.SamsungCOM1.DefaultText = "";
		this.SamsungCOM1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(55, 55, 55);
		this.SamsungCOM1.DisabledState.FillColor = System.Drawing.Color.FromArgb(70, 70, 70);
		this.SamsungCOM1.DisabledState.ForeColor = System.Drawing.Color.White;
		this.SamsungCOM1.DisabledState.PlaceholderForeColor = System.Drawing.Color.Gray;
		this.SamsungCOM1.FillColor = System.Drawing.Color.FromArgb(70, 70, 70);
		this.SamsungCOM1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.SamsungCOM1.FocusedState.FillColor = System.Drawing.Color.FromArgb(70, 70, 70);
		this.SamsungCOM1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.SamsungCOM1.ForeColor = System.Drawing.Color.White;
		this.SamsungCOM1.HoverState.BorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.SamsungCOM1.HoverState.FillColor = System.Drawing.Color.FromArgb(70, 70, 70);
		this.SamsungCOM1.Location = new System.Drawing.Point(5, 66);
		this.SamsungCOM1.Name = "SamsungCOM1";
		this.SamsungCOM1.PasswordChar = '\0';
		this.SamsungCOM1.PlaceholderForeColor = System.Drawing.Color.DarkGray;
		this.SamsungCOM1.PlaceholderText = "";
		this.SamsungCOM1.ReadOnly = true;
		this.SamsungCOM1.SelectedText = "";
		this.SamsungCOM1.ShadowDecoration.Color = System.Drawing.Color.DimGray;
		this.SamsungCOM1.ShadowDecoration.Depth = 15;
		this.SamsungCOM1.Size = new System.Drawing.Size(116, 26);
		this.SamsungCOM1.TabIndex = 497;
		this.SamsungCOM1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.Guna2GroupBox2.BackColor = System.Drawing.Color.Transparent;
		this.Guna2GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.Guna2GroupBox2.BorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.Guna2GroupBox2.BorderRadius = 6;
		this.Guna2GroupBox2.Controls.Add(this.Guna2CheckBox1);
		this.Guna2GroupBox2.Controls.Add(this.COM4);
		this.Guna2GroupBox2.Controls.Add(this.Guna2Button11);
		this.Guna2GroupBox2.Controls.Add(this.COM3);
		this.Guna2GroupBox2.Controls.Add(this.COM2);
		this.Guna2GroupBox2.Controls.Add(this.Guna2Button12);
		this.Guna2GroupBox2.Controls.Add(this.COM1);
		this.Guna2GroupBox2.Controls.Add(this.COM4ProgressBar1);
		this.Guna2GroupBox2.Controls.Add(this.COM3ProgressBar1);
		this.Guna2GroupBox2.Controls.Add(this.COM2ProgressBar1);
		this.Guna2GroupBox2.Controls.Add(this.COM1ProgressBar1);
		this.Guna2GroupBox2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.Guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.Guna2GroupBox2.CustomBorderThickness = new System.Windows.Forms.Padding(0);
		this.Guna2GroupBox2.FillColor = System.Drawing.Color.FromArgb(50, 50, 50);
		this.Guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.Guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(125, 137, 149);
		this.Guna2GroupBox2.Location = new System.Drawing.Point(6, 6);
		this.Guna2GroupBox2.Name = "Guna2GroupBox2";
		this.Guna2GroupBox2.ShadowDecoration.BorderRadius = 9;
		this.Guna2GroupBox2.ShadowDecoration.Color = System.Drawing.Color.White;
		this.Guna2GroupBox2.ShadowDecoration.Depth = 15;
		this.Guna2GroupBox2.Size = new System.Drawing.Size(469, 99);
		this.Guna2GroupBox2.TabIndex = 511;
		this.Guna2CheckBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
		this.Guna2CheckBox1.Animated = true;
		this.Guna2CheckBox1.AutoSize = true;
		this.Guna2CheckBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
		this.Guna2CheckBox1.CheckedState.BorderRadius = 4;
		this.Guna2CheckBox1.CheckedState.BorderThickness = 2;
		this.Guna2CheckBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(21, 87, 255);
		this.Guna2CheckBox1.Font = new System.Drawing.Font("Yu Gothic UI", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Guna2CheckBox1.ForeColor = System.Drawing.Color.White;
		this.Guna2CheckBox1.Location = new System.Drawing.Point(323, 6);
		this.Guna2CheckBox1.Name = "Guna2CheckBox1";
		this.Guna2CheckBox1.Size = new System.Drawing.Size(100, 21);
		this.Guna2CheckBox1.TabIndex = 501;
		this.Guna2CheckBox1.Text = "Auto Detect";
		this.Guna2CheckBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.Guna2CheckBox1.UncheckedState.BorderRadius = 4;
		this.Guna2CheckBox1.UncheckedState.BorderThickness = 1;
		this.Guna2CheckBox1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(70, 70, 70);
		this.COM4.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.COM4.Animated = true;
		this.COM4.BackColor = System.Drawing.Color.Transparent;
		this.COM4.BorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.COM4.BorderRadius = 5;
		this.COM4.BorderThickness = 2;
		this.COM4.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.COM4.DefaultText = "";
		this.COM4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.COM4.DisabledState.FillColor = System.Drawing.Color.FromArgb(70, 70, 70);
		this.COM4.DisabledState.ForeColor = System.Drawing.Color.White;
		this.COM4.DisabledState.PlaceholderForeColor = System.Drawing.Color.Gray;
		this.COM4.FillColor = System.Drawing.Color.FromArgb(70, 70, 70);
		this.COM4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.COM4.FocusedState.FillColor = System.Drawing.Color.FromArgb(70, 70, 70);
		this.COM4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.COM4.ForeColor = System.Drawing.Color.White;
		this.COM4.HideSelection = false;
		this.COM4.HoverState.BorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.COM4.HoverState.FillColor = System.Drawing.Color.FromArgb(70, 70, 70);
		this.COM4.Location = new System.Drawing.Point(348, 66);
		this.COM4.Name = "COM4";
		this.COM4.PasswordChar = '\0';
		this.COM4.PlaceholderForeColor = System.Drawing.Color.DarkGray;
		this.COM4.PlaceholderText = "";
		this.COM4.ReadOnly = true;
		this.COM4.SelectedText = "";
		this.COM4.ShadowDecoration.Color = System.Drawing.Color.DimGray;
		this.COM4.ShadowDecoration.Depth = 15;
		this.COM4.Size = new System.Drawing.Size(116, 26);
		this.COM4.TabIndex = 500;
		this.COM4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.Guna2Button11.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.Guna2Button11.BorderColor = System.Drawing.Color.DimGray;
		this.Guna2Button11.BorderRadius = 4;
		this.Guna2Button11.BorderThickness = 1;
		this.Guna2Button11.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
		this.Guna2Button11.CheckedState.FillColor = System.Drawing.Color.LightGray;
		this.Guna2Button11.CheckedState.Image = (System.Drawing.Image)resources.GetObject("resource.Image2");
		this.Guna2Button11.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
		this.Guna2Button11.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
		this.Guna2Button11.DisabledState.FillColor = System.Drawing.Color.DarkGray;
		this.Guna2Button11.DisabledState.ForeColor = System.Drawing.Color.LightGray;
		this.Guna2Button11.FillColor = System.Drawing.Color.DimGray;
		this.Guna2Button11.Font = new System.Drawing.Font("Yu Gothic UI", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Guna2Button11.ForeColor = System.Drawing.Color.White;
		this.Guna2Button11.HoverState.BorderColor = System.Drawing.Color.DimGray;
		this.Guna2Button11.HoverState.CustomBorderColor = System.Drawing.Color.DimGray;
		this.Guna2Button11.HoverState.FillColor = System.Drawing.Color.DimGray;
		this.Guna2Button11.HoverState.ForeColor = System.Drawing.Color.White;
		this.Guna2Button11.ImageSize = new System.Drawing.Size(25, 25);
		this.Guna2Button11.Location = new System.Drawing.Point(6, 6);
		this.Guna2Button11.Name = "Guna2Button11";
		this.Guna2Button11.PressedColor = System.Drawing.Color.DimGray;
		this.Guna2Button11.Size = new System.Drawing.Size(311, 21);
		this.Guna2Button11.TabIndex = 469;
		this.Guna2Button11.Text = "Connected Devices";
		this.Guna2Button11.TextFormatNoPrefix = true;
		this.COM3.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.COM3.Animated = true;
		this.COM3.BackColor = System.Drawing.Color.Transparent;
		this.COM3.BorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.COM3.BorderRadius = 5;
		this.COM3.BorderThickness = 2;
		this.COM3.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.COM3.DefaultText = "";
		this.COM3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.COM3.DisabledState.FillColor = System.Drawing.Color.FromArgb(70, 70, 70);
		this.COM3.DisabledState.ForeColor = System.Drawing.Color.White;
		this.COM3.DisabledState.PlaceholderForeColor = System.Drawing.Color.Gray;
		this.COM3.FillColor = System.Drawing.Color.FromArgb(70, 70, 70);
		this.COM3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.COM3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.COM3.ForeColor = System.Drawing.Color.White;
		this.COM3.HideSelection = false;
		this.COM3.HoverState.BorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.COM3.Location = new System.Drawing.Point(238, 66);
		this.COM3.Name = "COM3";
		this.COM3.PasswordChar = '\0';
		this.COM3.PlaceholderForeColor = System.Drawing.Color.DarkGray;
		this.COM3.PlaceholderText = "";
		this.COM3.ReadOnly = true;
		this.COM3.SelectedText = "";
		this.COM3.ShadowDecoration.Color = System.Drawing.Color.DimGray;
		this.COM3.ShadowDecoration.Depth = 15;
		this.COM3.Size = new System.Drawing.Size(104, 26);
		this.COM3.TabIndex = 499;
		this.COM3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.COM2.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.COM2.Animated = true;
		this.COM2.BackColor = System.Drawing.Color.Transparent;
		this.COM2.BorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.COM2.BorderRadius = 5;
		this.COM2.BorderThickness = 2;
		this.COM2.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.COM2.DefaultText = "";
		this.COM2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.COM2.DisabledState.FillColor = System.Drawing.Color.FromArgb(70, 70, 70);
		this.COM2.DisabledState.ForeColor = System.Drawing.Color.White;
		this.COM2.DisabledState.PlaceholderForeColor = System.Drawing.Color.Gray;
		this.COM2.FillColor = System.Drawing.Color.FromArgb(70, 70, 70);
		this.COM2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.COM2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.COM2.ForeColor = System.Drawing.Color.White;
		this.COM2.HideSelection = false;
		this.COM2.HoverState.BorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.COM2.Location = new System.Drawing.Point(128, 66);
		this.COM2.Name = "COM2";
		this.COM2.PasswordChar = '\0';
		this.COM2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
		this.COM2.PlaceholderText = "";
		this.COM2.ReadOnly = true;
		this.COM2.SelectedText = "";
		this.COM2.ShadowDecoration.Color = System.Drawing.Color.DimGray;
		this.COM2.ShadowDecoration.Depth = 15;
		this.COM2.Size = new System.Drawing.Size(104, 26);
		this.COM2.TabIndex = 498;
		this.COM2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.Guna2Button12.Anchor = System.Windows.Forms.AnchorStyles.Right;
		this.Guna2Button12.BorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.Guna2Button12.BorderRadius = 4;
		this.Guna2Button12.BorderThickness = 2;
		this.Guna2Button12.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
		this.Guna2Button12.CheckedState.FillColor = System.Drawing.Color.LightGray;
		this.Guna2Button12.DisabledState.BorderColor = System.Drawing.Color.FromArgb(55, 55, 55);
		this.Guna2Button12.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
		this.Guna2Button12.DisabledState.FillColor = System.Drawing.Color.FromArgb(55, 55, 55);
		this.Guna2Button12.DisabledState.ForeColor = System.Drawing.Color.Gray;
		this.Guna2Button12.FillColor = System.Drawing.Color.FromArgb(70, 70, 70);
		this.Guna2Button12.Font = new System.Drawing.Font("Yu Gothic UI", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Guna2Button12.ForeColor = System.Drawing.Color.White;
		this.Guna2Button12.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
		this.Guna2Button12.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
		this.Guna2Button12.Image = Properties.Resources.magnifier__1_;
		this.Guna2Button12.Location = new System.Drawing.Point(422, 6);
		this.Guna2Button12.Name = "Guna2Button12";
		this.Guna2Button12.PressedColor = System.Drawing.Color.Empty;
		this.Guna2Button12.Size = new System.Drawing.Size(41, 21);
		this.Guna2Button12.TabIndex = 463;
		this.Guna2Button12.TextFormatNoPrefix = true;
		this.COM1.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.COM1.Animated = true;
		this.COM1.BackColor = System.Drawing.Color.Transparent;
		this.COM1.BorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.COM1.BorderRadius = 5;
		this.COM1.BorderThickness = 2;
		this.COM1.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.COM1.DefaultText = "";
		this.COM1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.COM1.DisabledState.FillColor = System.Drawing.Color.FromArgb(70, 70, 70);
		this.COM1.DisabledState.ForeColor = System.Drawing.Color.White;
		this.COM1.DisabledState.PlaceholderForeColor = System.Drawing.Color.Gray;
		this.COM1.FillColor = System.Drawing.Color.FromArgb(70, 70, 70);
		this.COM1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.COM1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.COM1.ForeColor = System.Drawing.Color.White;
		this.COM1.HideSelection = false;
		this.COM1.HoverState.BorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.COM1.Location = new System.Drawing.Point(5, 66);
		this.COM1.Name = "COM1";
		this.COM1.PasswordChar = '\0';
		this.COM1.PlaceholderForeColor = System.Drawing.Color.DarkGray;
		this.COM1.PlaceholderText = "";
		this.COM1.ReadOnly = true;
		this.COM1.SelectedText = "";
		this.COM1.ShadowDecoration.Color = System.Drawing.Color.DimGray;
		this.COM1.ShadowDecoration.Depth = 15;
		this.COM1.Size = new System.Drawing.Size(117, 26);
		this.COM1.TabIndex = 497;
		this.COM1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.COM4ProgressBar1.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.COM4ProgressBar1.BackColor = System.Drawing.Color.Transparent;
		this.COM4ProgressBar1.BorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.COM4ProgressBar1.BorderRadius = 5;
		this.COM4ProgressBar1.BorderThickness = 2;
		this.COM4ProgressBar1.FillColor = System.Drawing.Color.FromArgb(70, 70, 70);
		this.COM4ProgressBar1.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.COM4ProgressBar1.ForeColor = System.Drawing.Color.White;
		this.COM4ProgressBar1.Location = new System.Drawing.Point(348, 33);
		this.COM4ProgressBar1.Name = "COM4ProgressBar1";
		this.COM4ProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(0, 85, 207);
		this.COM4ProgressBar1.ProgressColor2 = System.Drawing.Color.FromArgb(0, 85, 207);
		this.COM4ProgressBar1.ShadowDecoration.BorderRadius = 5;
		this.COM4ProgressBar1.ShowText = true;
		this.COM4ProgressBar1.Size = new System.Drawing.Size(116, 27);
		this.COM4ProgressBar1.TabIndex = 299;
		this.COM4ProgressBar1.TextMode = Guna.UI2.WinForms.Enums.ProgressBarTextMode.Custom;
		this.COM4ProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
		this.COM3ProgressBar1.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.COM3ProgressBar1.BackColor = System.Drawing.Color.Transparent;
		this.COM3ProgressBar1.BorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.COM3ProgressBar1.BorderRadius = 5;
		this.COM3ProgressBar1.BorderThickness = 2;
		this.COM3ProgressBar1.FillColor = System.Drawing.Color.FromArgb(70, 70, 70);
		this.COM3ProgressBar1.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.COM3ProgressBar1.ForeColor = System.Drawing.Color.White;
		this.COM3ProgressBar1.Location = new System.Drawing.Point(238, 33);
		this.COM3ProgressBar1.Name = "COM3ProgressBar1";
		this.COM3ProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(0, 85, 207);
		this.COM3ProgressBar1.ProgressColor2 = System.Drawing.Color.FromArgb(0, 85, 207);
		this.COM3ProgressBar1.ShadowDecoration.BorderRadius = 5;
		this.COM3ProgressBar1.ShowText = true;
		this.COM3ProgressBar1.Size = new System.Drawing.Size(104, 27);
		this.COM3ProgressBar1.TabIndex = 299;
		this.COM3ProgressBar1.TextMode = Guna.UI2.WinForms.Enums.ProgressBarTextMode.Custom;
		this.COM3ProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
		this.COM2ProgressBar1.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.COM2ProgressBar1.BackColor = System.Drawing.Color.Transparent;
		this.COM2ProgressBar1.BorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.COM2ProgressBar1.BorderRadius = 5;
		this.COM2ProgressBar1.BorderThickness = 2;
		this.COM2ProgressBar1.FillColor = System.Drawing.Color.FromArgb(70, 70, 70);
		this.COM2ProgressBar1.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.COM2ProgressBar1.ForeColor = System.Drawing.Color.White;
		this.COM2ProgressBar1.Location = new System.Drawing.Point(128, 33);
		this.COM2ProgressBar1.Name = "COM2ProgressBar1";
		this.COM2ProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(0, 85, 207);
		this.COM2ProgressBar1.ProgressColor2 = System.Drawing.Color.FromArgb(0, 85, 207);
		this.COM2ProgressBar1.ShadowDecoration.BorderRadius = 5;
		this.COM2ProgressBar1.ShowText = true;
		this.COM2ProgressBar1.Size = new System.Drawing.Size(104, 27);
		this.COM2ProgressBar1.TabIndex = 299;
		this.COM2ProgressBar1.TextMode = Guna.UI2.WinForms.Enums.ProgressBarTextMode.Custom;
		this.COM2ProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
		this.COM1ProgressBar1.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.COM1ProgressBar1.BackColor = System.Drawing.Color.Transparent;
		this.COM1ProgressBar1.BorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.COM1ProgressBar1.BorderRadius = 5;
		this.COM1ProgressBar1.BorderThickness = 2;
		this.COM1ProgressBar1.FillColor = System.Drawing.Color.FromArgb(70, 70, 70);
		this.COM1ProgressBar1.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.COM1ProgressBar1.ForeColor = System.Drawing.Color.White;
		this.COM1ProgressBar1.Location = new System.Drawing.Point(5, 33);
		this.COM1ProgressBar1.Name = "COM1ProgressBar1";
		this.COM1ProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(0, 85, 207);
		this.COM1ProgressBar1.ProgressColor2 = System.Drawing.Color.FromArgb(0, 85, 207);
		this.COM1ProgressBar1.ShadowDecoration.BorderRadius = 5;
		this.COM1ProgressBar1.ShowText = true;
		this.COM1ProgressBar1.Size = new System.Drawing.Size(117, 27);
		this.COM1ProgressBar1.TabIndex = 299;
		this.COM1ProgressBar1.TextMode = Guna.UI2.WinForms.Enums.ProgressBarTextMode.Custom;
		this.COM1ProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
		this.Guna2GroupBox4.BackColor = System.Drawing.Color.Transparent;
		this.Guna2GroupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.Guna2GroupBox4.BorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.Guna2GroupBox4.BorderRadius = 6;
		this.Guna2GroupBox4.Controls.Add(this.Guna2Button8);
		this.Guna2GroupBox4.Controls.Add(this.Guna2Button7);
		this.Guna2GroupBox4.Controls.Add(this.Guna2Button6);
		this.Guna2GroupBox4.Controls.Add(this.name_flash);
		this.Guna2GroupBox4.Cursor = System.Windows.Forms.Cursors.Hand;
		this.Guna2GroupBox4.CustomBorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.Guna2GroupBox4.CustomBorderThickness = new System.Windows.Forms.Padding(0);
		this.Guna2GroupBox4.FillColor = System.Drawing.Color.FromArgb(50, 50, 50);
		this.Guna2GroupBox4.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.Guna2GroupBox4.ForeColor = System.Drawing.Color.FromArgb(125, 137, 149);
		this.Guna2GroupBox4.Location = new System.Drawing.Point(6, 111);
		this.Guna2GroupBox4.Name = "Guna2GroupBox4";
		this.Guna2GroupBox4.ShadowDecoration.BorderRadius = 9;
		this.Guna2GroupBox4.ShadowDecoration.Color = System.Drawing.Color.White;
		this.Guna2GroupBox4.ShadowDecoration.Depth = 15;
		this.Guna2GroupBox4.Size = new System.Drawing.Size(469, 104);
		this.Guna2GroupBox4.TabIndex = 512;
		this.Guna2Button8.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.Guna2Button8.BorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.Guna2Button8.BorderRadius = 4;
		this.Guna2Button8.BorderThickness = 2;
		this.Guna2Button8.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
		this.Guna2Button8.CheckedState.FillColor = System.Drawing.Color.LightGray;
		this.Guna2Button8.CheckedState.Image = (System.Drawing.Image)resources.GetObject("resource.Image3");
		this.Guna2Button8.DisabledState.BorderColor = System.Drawing.Color.FromArgb(55, 55, 55);
		this.Guna2Button8.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
		this.Guna2Button8.DisabledState.FillColor = System.Drawing.Color.FromArgb(55, 55, 55);
		this.Guna2Button8.DisabledState.ForeColor = System.Drawing.Color.Gray;
		this.Guna2Button8.FillColor = System.Drawing.Color.FromArgb(70, 70, 70);
		this.Guna2Button8.Font = new System.Drawing.Font("Yu Gothic UI", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Guna2Button8.ForeColor = System.Drawing.Color.White;
		this.Guna2Button8.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
		this.Guna2Button8.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
		this.Guna2Button8.Image = Properties.Resources.flash__1_;
		this.Guna2Button8.ImageSize = new System.Drawing.Size(25, 25);
		this.Guna2Button8.Location = new System.Drawing.Point(5, 71);
		this.Guna2Button8.Name = "Guna2Button8";
		this.Guna2Button8.PressedColor = System.Drawing.Color.Empty;
		this.Guna2Button8.Size = new System.Drawing.Size(459, 26);
		this.Guna2Button8.TabIndex = 464;
		this.Guna2Button8.Text = "Start Flash";
		this.Guna2Button8.TextFormatNoPrefix = true;
		this.Guna2Button7.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.Guna2Button7.BorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.Guna2Button7.BorderRadius = 4;
		this.Guna2Button7.BorderThickness = 2;
		this.Guna2Button7.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
		this.Guna2Button7.CheckedState.FillColor = System.Drawing.Color.LightGray;
		this.Guna2Button7.CheckedState.Image = (System.Drawing.Image)resources.GetObject("resource.Image4");
		this.Guna2Button7.DisabledState.BorderColor = System.Drawing.Color.FromArgb(55, 55, 55);
		this.Guna2Button7.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
		this.Guna2Button7.DisabledState.FillColor = System.Drawing.Color.FromArgb(55, 55, 55);
		this.Guna2Button7.DisabledState.ForeColor = System.Drawing.Color.Gray;
		this.Guna2Button7.FillColor = System.Drawing.Color.FromArgb(70, 70, 70);
		this.Guna2Button7.Font = new System.Drawing.Font("Yu Gothic UI", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Guna2Button7.ForeColor = System.Drawing.Color.White;
		this.Guna2Button7.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
		this.Guna2Button7.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
		this.Guna2Button7.Image = Properties.Resources.info__1_;
		this.Guna2Button7.Location = new System.Drawing.Point(5, 39);
		this.Guna2Button7.Name = "Guna2Button7";
		this.Guna2Button7.PressedColor = System.Drawing.Color.Empty;
		this.Guna2Button7.Size = new System.Drawing.Size(459, 26);
		this.Guna2Button7.TabIndex = 463;
		this.Guna2Button7.Text = "Read Info Devices";
		this.Guna2Button7.TextFormatNoPrefix = true;
		this.Guna2Button6.Anchor = System.Windows.Forms.AnchorStyles.Right;
		this.Guna2Button6.BorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.Guna2Button6.BorderRadius = 4;
		this.Guna2Button6.BorderThickness = 2;
		this.Guna2Button6.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
		this.Guna2Button6.CheckedState.FillColor = System.Drawing.Color.LightGray;
		this.Guna2Button6.DisabledState.BorderColor = System.Drawing.Color.FromArgb(55, 55, 55);
		this.Guna2Button6.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
		this.Guna2Button6.DisabledState.FillColor = System.Drawing.Color.FromArgb(55, 55, 55);
		this.Guna2Button6.DisabledState.ForeColor = System.Drawing.Color.Gray;
		this.Guna2Button6.FillColor = System.Drawing.Color.FromArgb(70, 70, 70);
		this.Guna2Button6.Font = new System.Drawing.Font("Yu Gothic UI", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Guna2Button6.ForeColor = System.Drawing.Color.White;
		this.Guna2Button6.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
		this.Guna2Button6.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
		this.Guna2Button6.Image = Properties.Resources.search_in_folder;
		this.Guna2Button6.ImageSize = new System.Drawing.Size(25, 25);
		this.Guna2Button6.Location = new System.Drawing.Point(423, 7);
		this.Guna2Button6.Name = "Guna2Button6";
		this.Guna2Button6.PressedColor = System.Drawing.Color.Empty;
		this.Guna2Button6.Size = new System.Drawing.Size(41, 26);
		this.Guna2Button6.TabIndex = 463;
		this.Guna2Button6.TextFormatNoPrefix = true;
		this.name_flash.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.name_flash.Animated = true;
		this.name_flash.BackColor = System.Drawing.Color.Transparent;
		this.name_flash.BorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.name_flash.BorderRadius = 5;
		this.name_flash.BorderThickness = 2;
		this.name_flash.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.name_flash.DefaultText = "";
		this.name_flash.DisabledState.BorderColor = System.Drawing.Color.FromArgb(55, 55, 55);
		this.name_flash.DisabledState.FillColor = System.Drawing.Color.FromArgb(55, 55, 55);
		this.name_flash.DisabledState.ForeColor = System.Drawing.Color.Gray;
		this.name_flash.DisabledState.PlaceholderForeColor = System.Drawing.Color.Gray;
		this.name_flash.FillColor = System.Drawing.Color.FromArgb(70, 70, 70);
		this.name_flash.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.name_flash.ForeColor = System.Drawing.Color.White;
		this.name_flash.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
		this.name_flash.Location = new System.Drawing.Point(5, 7);
		this.name_flash.Name = "name_flash";
		this.name_flash.PasswordChar = '\0';
		this.name_flash.PlaceholderForeColor = System.Drawing.Color.DarkGray;
		this.name_flash.PlaceholderText = "KDZ";
		this.name_flash.SelectedText = "";
		this.name_flash.ShadowDecoration.Color = System.Drawing.Color.DimGray;
		this.name_flash.ShadowDecoration.Depth = 15;
		this.name_flash.Size = new System.Drawing.Size(412, 26);
		this.name_flash.TabIndex = 493;
		this.name_flash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.Comboboxport.BackColor = System.Drawing.Color.Transparent;
		this.Comboboxport.BorderRadius = 4;
		this.Comboboxport.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
		this.Comboboxport.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
		this.Comboboxport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.Comboboxport.FocusedColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.Comboboxport.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.Comboboxport.Font = new System.Drawing.Font("Yu Gothic UI", 11.25f, System.Drawing.FontStyle.Bold);
		this.Comboboxport.ForeColor = System.Drawing.Color.Black;
		this.Comboboxport.FormattingEnabled = true;
		this.Comboboxport.ItemHeight = 30;
		this.Comboboxport.Location = new System.Drawing.Point(457, 539);
		this.Comboboxport.Name = "Comboboxport";
		this.Comboboxport.ShadowDecoration.BorderRadius = 4;
		this.Comboboxport.ShadowDecoration.Depth = 7;
		this.Comboboxport.Size = new System.Drawing.Size(10, 36);
		this.Comboboxport.TabIndex = 512;
		this.Comboboxport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.Comboboxport.Visible = false;
		this.cbstorage.BackColor = System.Drawing.Color.Transparent;
		this.cbstorage.BorderRadius = 4;
		this.cbstorage.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
		this.cbstorage.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
		this.cbstorage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbstorage.FocusedColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.cbstorage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.cbstorage.Font = new System.Drawing.Font("Yu Gothic UI", 11.25f, System.Drawing.FontStyle.Bold);
		this.cbstorage.ForeColor = System.Drawing.Color.Black;
		this.cbstorage.FormattingEnabled = true;
		this.cbstorage.ItemHeight = 30;
		this.cbstorage.Items.AddRange(new object[2] { "EMMC", "UFS" });
		this.cbstorage.Location = new System.Drawing.Point(438, 539);
		this.cbstorage.Name = "cbstorage";
		this.cbstorage.ShadowDecoration.BorderRadius = 4;
		this.cbstorage.ShadowDecoration.Depth = 7;
		this.cbstorage.Size = new System.Drawing.Size(10, 36);
		this.cbstorage.TabIndex = 513;
		this.cbstorage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.cbstorage.Visible = false;
		this.Timer1.Enabled = true;
		this.Timer1.Interval = 10;
		this.Timer2.Enabled = true;
		this.Timer2.Interval = 20;
		this.TabControlExt1.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
		this.TabControlExt1.BorderColor = System.Drawing.Color.DimGray;
		this.TabControlExt1.CloseBtnColor = System.Drawing.Color.White;
		this.TabControlExt1.Controls.Add(this.TabPage2);
		this.TabControlExt1.Controls.Add(this.TabPage4);
		this.TabControlExt1.Controls.Add(this.TabPage1);
		this.TabControlExt1.Font = new System.Drawing.Font("Yu Gothic UI", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.TabControlExt1.HeaderBackColor = System.Drawing.Color.FromArgb(70, 70, 70);
		this.TabControlExt1.HeadSelectedBackColor = System.Drawing.Color.FromArgb(21, 87, 255);
		this.TabControlExt1.HeadSelectedBorderColor = System.Drawing.Color.DimGray;
		this.TabControlExt1.IsShowCloseBtn = false;
		this.TabControlExt1.ItemSize = new System.Drawing.Size(0, 30);
		this.TabControlExt1.Location = new System.Drawing.Point(3, 4);
		this.TabControlExt1.Name = "TabControlExt1";
		this.TabControlExt1.SelectedIndex = 0;
		this.TabControlExt1.Size = new System.Drawing.Size(489, 525);
		this.TabControlExt1.TabIndex = 525;
		this.TabControlExt1.TabTextColor = System.Drawing.Color.White;
		this.TabControlExt1.UncloseTabIndexs = null;
		this.TabPage2.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
		this.TabPage2.Controls.Add(this.Guna2GroupBox3);
		this.TabPage2.Controls.Add(this.Guna2GroupBox1);
		this.TabPage2.Location = new System.Drawing.Point(4, 34);
		this.TabPage2.Name = "TabPage2";
		this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
		this.TabPage2.Size = new System.Drawing.Size(481, 487);
		this.TabPage2.TabIndex = 0;
		this.TabPage2.Text = "Sam [DM Mode]";
		this.TabPage4.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
		this.TabPage4.Controls.Add(this.Guna2GroupBox2);
		this.TabPage4.Controls.Add(this.Guna2GroupBox4);
		this.TabPage4.Location = new System.Drawing.Point(4, 34);
		this.TabPage4.Name = "TabPage4";
		this.TabPage4.Padding = new System.Windows.Forms.Padding(3);
		this.TabPage4.Size = new System.Drawing.Size(481, 487);
		this.TabPage4.TabIndex = 1;
		this.TabPage4.Text = "LGE [DM Mode]";
		this.TabPage1.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
		this.TabPage1.Controls.Add(this.Guna2GroupBox5);
		this.TabPage1.Controls.Add(this.cbsetboot);
		this.TabPage1.Controls.Add(this.Guna2CheckBox5);
		this.TabPage1.Controls.Add(this.Guna2GroupBox9);
		this.TabPage1.Controls.Add(this.Guna2Button10);
		this.TabPage1.Location = new System.Drawing.Point(4, 34);
		this.TabPage1.Name = "TabPage1";
		this.TabPage1.Size = new System.Drawing.Size(481, 487);
		this.TabPage1.TabIndex = 2;
		this.TabPage1.Text = "Motorola [FB Mode]";
		this.Guna2GroupBox5.BackColor = System.Drawing.Color.Transparent;
		this.Guna2GroupBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.Guna2GroupBox5.BorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.Guna2GroupBox5.BorderRadius = 6;
		this.Guna2GroupBox5.Controls.Add(this.Guna2Button13);
		this.Guna2GroupBox5.Controls.Add(this.txtrawxml);
		this.Guna2GroupBox5.Controls.Add(this.Guna2Button9);
		this.Guna2GroupBox5.Cursor = System.Windows.Forms.Cursors.Hand;
		this.Guna2GroupBox5.CustomBorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.Guna2GroupBox5.CustomBorderThickness = new System.Windows.Forms.Padding(0);
		this.Guna2GroupBox5.Enabled = false;
		this.Guna2GroupBox5.FillColor = System.Drawing.Color.FromArgb(50, 50, 50);
		this.Guna2GroupBox5.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.Guna2GroupBox5.ForeColor = System.Drawing.Color.FromArgb(125, 137, 149);
		this.Guna2GroupBox5.Location = new System.Drawing.Point(5, 6);
		this.Guna2GroupBox5.Name = "Guna2GroupBox5";
		this.Guna2GroupBox5.ShadowDecoration.BorderRadius = 9;
		this.Guna2GroupBox5.ShadowDecoration.Color = System.Drawing.Color.White;
		this.Guna2GroupBox5.ShadowDecoration.Depth = 15;
		this.Guna2GroupBox5.Size = new System.Drawing.Size(471, 39);
		this.Guna2GroupBox5.TabIndex = 559;
		this.Guna2Button13.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.Guna2Button13.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
		this.Guna2Button13.BorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.Guna2Button13.BorderRadius = 4;
		this.Guna2Button13.BorderThickness = 2;
		this.Guna2Button13.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
		this.Guna2Button13.CheckedState.FillColor = System.Drawing.Color.LightGray;
		this.Guna2Button13.DisabledState.BorderColor = System.Drawing.Color.FromArgb(55, 55, 55);
		this.Guna2Button13.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
		this.Guna2Button13.DisabledState.FillColor = System.Drawing.Color.FromArgb(55, 55, 55);
		this.Guna2Button13.DisabledState.ForeColor = System.Drawing.Color.Gray;
		this.Guna2Button13.FillColor = System.Drawing.Color.FromArgb(70, 70, 70);
		this.Guna2Button13.Font = new System.Drawing.Font("Yu Gothic UI", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Guna2Button13.ForeColor = System.Drawing.Color.White;
		this.Guna2Button13.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
		this.Guna2Button13.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
		this.Guna2Button13.Image = Properties.Resources.search_in_folder;
		this.Guna2Button13.ImageSize = new System.Drawing.Size(25, 25);
		this.Guna2Button13.Location = new System.Drawing.Point(363, 6);
		this.Guna2Button13.Name = "Guna2Button13";
		this.Guna2Button13.PressedColor = System.Drawing.Color.Empty;
		this.Guna2Button13.Size = new System.Drawing.Size(48, 27);
		this.Guna2Button13.TabIndex = 556;
		this.Guna2Button13.TextFormatNoPrefix = true;
		this.txtrawxml.Anchor = System.Windows.Forms.AnchorStyles.Left;
		this.txtrawxml.Animated = true;
		this.txtrawxml.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
		this.txtrawxml.BorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.txtrawxml.BorderRadius = 5;
		this.txtrawxml.BorderThickness = 2;
		this.txtrawxml.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.txtrawxml.DefaultText = "";
		this.txtrawxml.DisabledState.BorderColor = System.Drawing.Color.FromArgb(55, 55, 55);
		this.txtrawxml.DisabledState.FillColor = System.Drawing.Color.FromArgb(55, 55, 55);
		this.txtrawxml.DisabledState.ForeColor = System.Drawing.Color.Gray;
		this.txtrawxml.DisabledState.PlaceholderForeColor = System.Drawing.Color.Gray;
		this.txtrawxml.FillColor = System.Drawing.Color.FromArgb(70, 70, 70);
		this.txtrawxml.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.txtrawxml.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.txtrawxml.ForeColor = System.Drawing.Color.White;
		this.txtrawxml.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
		this.txtrawxml.Location = new System.Drawing.Point(6, 6);
		this.txtrawxml.Name = "txtrawxml";
		this.txtrawxml.PasswordChar = '\0';
		this.txtrawxml.PlaceholderForeColor = System.Drawing.Color.DarkGray;
		this.txtrawxml.PlaceholderText = "XML | Dump File";
		this.txtrawxml.SelectedText = "";
		this.txtrawxml.ShadowDecoration.Color = System.Drawing.Color.DimGray;
		this.txtrawxml.ShadowDecoration.Depth = 15;
		this.txtrawxml.Size = new System.Drawing.Size(351, 27);
		this.txtrawxml.TabIndex = 555;
		this.txtrawxml.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.Guna2Button9.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.Guna2Button9.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
		this.Guna2Button9.BorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.Guna2Button9.BorderRadius = 4;
		this.Guna2Button9.BorderThickness = 2;
		this.Guna2Button9.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
		this.Guna2Button9.CheckedState.FillColor = System.Drawing.Color.LightGray;
		this.Guna2Button9.DisabledState.BorderColor = System.Drawing.Color.FromArgb(55, 55, 55);
		this.Guna2Button9.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
		this.Guna2Button9.DisabledState.FillColor = System.Drawing.Color.FromArgb(55, 55, 55);
		this.Guna2Button9.DisabledState.ForeColor = System.Drawing.Color.Gray;
		this.Guna2Button9.FillColor = System.Drawing.Color.FromArgb(70, 70, 70);
		this.Guna2Button9.Font = new System.Drawing.Font("Yu Gothic UI", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Guna2Button9.ForeColor = System.Drawing.Color.White;
		this.Guna2Button9.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
		this.Guna2Button9.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
		this.Guna2Button9.Image = Properties.Resources.search_in_folder;
		this.Guna2Button9.ImageSize = new System.Drawing.Size(25, 25);
		this.Guna2Button9.Location = new System.Drawing.Point(417, 6);
		this.Guna2Button9.Name = "Guna2Button9";
		this.Guna2Button9.PressedColor = System.Drawing.Color.Empty;
		this.Guna2Button9.Size = new System.Drawing.Size(48, 27);
		this.Guna2Button9.TabIndex = 554;
		this.Guna2Button9.TextFormatNoPrefix = true;
		this.cbsetboot.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.cbsetboot.Animated = true;
		this.cbsetboot.AutoSize = true;
		this.cbsetboot.BackColor = System.Drawing.Color.Transparent;
		this.cbsetboot.CheckedState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
		this.cbsetboot.CheckedState.BorderRadius = 4;
		this.cbsetboot.CheckedState.BorderThickness = 2;
		this.cbsetboot.CheckedState.FillColor = System.Drawing.Color.FromArgb(21, 87, 255);
		this.cbsetboot.Enabled = false;
		this.cbsetboot.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.cbsetboot.ForeColor = System.Drawing.Color.White;
		this.cbsetboot.Location = new System.Drawing.Point(98, 425);
		this.cbsetboot.Name = "cbsetboot";
		this.cbsetboot.Size = new System.Drawing.Size(75, 19);
		this.cbsetboot.TabIndex = 558;
		this.cbsetboot.Text = "Set Boot";
		this.cbsetboot.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.cbsetboot.UncheckedState.BorderRadius = 3;
		this.cbsetboot.UncheckedState.BorderThickness = 1;
		this.cbsetboot.UncheckedState.FillColor = System.Drawing.Color.FromArgb(70, 70, 70);
		this.cbsetboot.UseVisualStyleBackColor = false;
		this.Guna2CheckBox5.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.Guna2CheckBox5.Animated = true;
		this.Guna2CheckBox5.AutoSize = true;
		this.Guna2CheckBox5.BackColor = System.Drawing.Color.Transparent;
		this.Guna2CheckBox5.CheckedState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
		this.Guna2CheckBox5.CheckedState.BorderRadius = 4;
		this.Guna2CheckBox5.CheckedState.BorderThickness = 2;
		this.Guna2CheckBox5.CheckedState.FillColor = System.Drawing.Color.FromArgb(21, 87, 255);
		this.Guna2CheckBox5.Enabled = false;
		this.Guna2CheckBox5.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Guna2CheckBox5.ForeColor = System.Drawing.Color.White;
		this.Guna2CheckBox5.Location = new System.Drawing.Point(14, 425);
		this.Guna2CheckBox5.Name = "Guna2CheckBox5";
		this.Guna2CheckBox5.Size = new System.Drawing.Size(78, 19);
		this.Guna2CheckBox5.TabIndex = 557;
		this.Guna2CheckBox5.Text = "Select All";
		this.Guna2CheckBox5.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.Guna2CheckBox5.UncheckedState.BorderRadius = 3;
		this.Guna2CheckBox5.UncheckedState.BorderThickness = 1;
		this.Guna2CheckBox5.UncheckedState.FillColor = System.Drawing.Color.FromArgb(70, 70, 70);
		this.Guna2CheckBox5.UseVisualStyleBackColor = false;
		this.Guna2GroupBox9.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.Guna2GroupBox9.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
		this.Guna2GroupBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.Guna2GroupBox9.BorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.Guna2GroupBox9.BorderRadius = 6;
		this.Guna2GroupBox9.BorderThickness = 2;
		this.Guna2GroupBox9.Controls.Add(this.Guna2VScrollBar1);
		this.Guna2GroupBox9.Controls.Add(this.DataGridFlash);
		this.Guna2GroupBox9.Cursor = System.Windows.Forms.Cursors.Default;
		this.Guna2GroupBox9.CustomBorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.Guna2GroupBox9.CustomBorderThickness = new System.Windows.Forms.Padding(0);
		this.Guna2GroupBox9.Enabled = false;
		this.Guna2GroupBox9.FillColor = System.Drawing.Color.FromArgb(70, 70, 70);
		this.Guna2GroupBox9.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.Guna2GroupBox9.ForeColor = System.Drawing.Color.FromArgb(125, 137, 149);
		this.Guna2GroupBox9.Location = new System.Drawing.Point(5, 51);
		this.Guna2GroupBox9.Name = "Guna2GroupBox9";
		this.Guna2GroupBox9.ShadowDecoration.BorderRadius = 9;
		this.Guna2GroupBox9.ShadowDecoration.Color = System.Drawing.Color.White;
		this.Guna2GroupBox9.ShadowDecoration.Depth = 15;
		this.Guna2GroupBox9.Size = new System.Drawing.Size(471, 364);
		this.Guna2GroupBox9.TabIndex = 556;
		this.Guna2VScrollBar1.AutoRoundedCorners = true;
		this.Guna2VScrollBar1.AutoScroll = true;
		this.Guna2VScrollBar1.BackColor = System.Drawing.Color.FromArgb(70, 70, 70);
		this.Guna2VScrollBar1.BindingContainer = this.DataGridFlash;
		this.Guna2VScrollBar1.BorderRadius = 8;
		this.Guna2VScrollBar1.FillColor = System.Drawing.Color.FromArgb(70, 70, 70);
		this.Guna2VScrollBar1.HighlightOnWheel = true;
		this.Guna2VScrollBar1.InUpdate = false;
		this.Guna2VScrollBar1.LargeChange = 10;
		this.Guna2VScrollBar1.Location = new System.Drawing.Point(450, 3);
		this.Guna2VScrollBar1.Minimum = 1;
		this.Guna2VScrollBar1.Name = "Guna2VScrollBar1";
		this.Guna2VScrollBar1.ScrollbarSize = 18;
		this.Guna2VScrollBar1.Size = new System.Drawing.Size(18, 358);
		this.Guna2VScrollBar1.TabIndex = 530;
		this.Guna2VScrollBar1.ThumbColor = System.Drawing.Color.FromArgb(0, 85, 207);
		this.Guna2VScrollBar1.ThumbSize = 35f;
		this.Guna2VScrollBar1.ThumbStyle = Guna.UI2.WinForms.Enums.ThumbStyle.Inset;
		this.Guna2VScrollBar1.Value = 1;
		this.DataGridFlash.AllowUserToAddRows = false;
		this.DataGridFlash.AllowUserToDeleteRows = false;
		this.DataGridFlash.AllowUserToResizeColumns = false;
		this.DataGridFlash.AllowUserToResizeRows = false;
		this.DataGridFlash.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.DataGridFlash.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
		this.DataGridFlash.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
		this.DataGridFlash.BackgroundColor = System.Drawing.Color.FromArgb(70, 70, 70);
		this.DataGridFlash.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.DataGridFlash.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
		this.DataGridFlash.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
		dataGridViewCellStyle.BackColor = System.Drawing.Color.FromArgb(70, 70, 70);
		dataGridViewCellStyle.Font = new System.Drawing.Font("Segoe UI", 9f);
		dataGridViewCellStyle.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(70, 70, 70);
		dataGridViewCellStyle.SelectionForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DataGridFlash.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
		this.DataGridFlash.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.DataGridFlash.Columns.AddRange(this.DataGridViewCheckBoxColumn1, this.DataGridViewTextBoxColumn3, this.DataGridViewTextBoxColumn1, this.DataGridViewTextBoxColumn2, this.DataGridViewTextBoxColumn7);
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(70, 70, 70);
		dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9f);
		dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(125, 137, 149);
		dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(85, 85, 85);
		dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.DataGridFlash.DefaultCellStyle = dataGridViewCellStyle2;
		this.DataGridFlash.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
		this.DataGridFlash.EnableHeadersVisualStyles = false;
		this.DataGridFlash.GridColor = System.Drawing.Color.FromArgb(70, 70, 70);
		this.DataGridFlash.Location = new System.Drawing.Point(6, 3);
		this.DataGridFlash.MultiSelect = false;
		this.DataGridFlash.Name = "DataGridFlash";
		dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(70, 70, 70);
		dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9f);
		dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(85, 85, 85);
		dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DataGridFlash.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
		this.DataGridFlash.RowHeadersVisible = false;
		dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(70, 70, 70);
		dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(85, 85, 85);
		dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
		this.DataGridFlash.RowsDefaultCellStyle = dataGridViewCellStyle4;
		this.DataGridFlash.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(70, 70, 70);
		this.DataGridFlash.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.DataGridFlash.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
		this.DataGridFlash.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.DataGridFlash.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
		this.DataGridFlash.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
		this.DataGridFlash.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.DataGridFlash.Size = new System.Drawing.Size(462, 358);
		this.DataGridFlash.TabIndex = 529;
		this.DataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
		this.DataGridViewCheckBoxColumn1.Frozen = true;
		this.DataGridViewCheckBoxColumn1.HeaderText = " ";
		this.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1";
		this.DataGridViewCheckBoxColumn1.Width = 19;
		this.DataGridViewTextBoxColumn3.FillWeight = 50f;
		this.DataGridViewTextBoxColumn3.HeaderText = "Command";
		this.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3";
		this.DataGridViewTextBoxColumn3.ReadOnly = true;
		this.DataGridViewTextBoxColumn1.FillWeight = 50f;
		this.DataGridViewTextBoxColumn1.HeaderText = "Partition";
		this.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
		this.DataGridViewTextBoxColumn1.ReadOnly = true;
		this.DataGridViewTextBoxColumn2.FillWeight = 80f;
		this.DataGridViewTextBoxColumn2.HeaderText = "FileName";
		this.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2";
		this.DataGridViewTextBoxColumn2.ReadOnly = true;
		this.DataGridViewTextBoxColumn7.FillWeight = 50f;
		this.DataGridViewTextBoxColumn7.HeaderText = "Part Size";
		this.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7";
		this.DataGridViewTextBoxColumn7.ReadOnly = true;
		this.Guna2Button10.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.Guna2Button10.Animated = true;
		this.Guna2Button10.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
		this.Guna2Button10.BorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.Guna2Button10.BorderRadius = 4;
		this.Guna2Button10.BorderThickness = 2;
		this.Guna2Button10.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
		this.Guna2Button10.CheckedState.FillColor = System.Drawing.Color.LightGray;
		this.Guna2Button10.DisabledState.BorderColor = System.Drawing.Color.FromArgb(55, 55, 55);
		this.Guna2Button10.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
		this.Guna2Button10.DisabledState.FillColor = System.Drawing.Color.FromArgb(55, 55, 55);
		this.Guna2Button10.DisabledState.ForeColor = System.Drawing.Color.Gray;
		this.Guna2Button10.Enabled = false;
		this.Guna2Button10.FillColor = System.Drawing.Color.FromArgb(70, 70, 70);
		this.Guna2Button10.Font = new System.Drawing.Font("Yu Gothic UI", 9.75f, System.Drawing.FontStyle.Bold);
		this.Guna2Button10.ForeColor = System.Drawing.Color.White;
		this.Guna2Button10.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
		this.Guna2Button10.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
		this.Guna2Button10.Image = Properties.Resources.flash__1_;
		this.Guna2Button10.ImageSize = new System.Drawing.Size(25, 25);
		this.Guna2Button10.Location = new System.Drawing.Point(345, 421);
		this.Guna2Button10.Name = "Guna2Button10";
		this.Guna2Button10.PressedColor = System.Drawing.Color.Empty;
		this.Guna2Button10.Size = new System.Drawing.Size(125, 27);
		this.Guna2Button10.TabIndex = 553;
		this.Guna2Button10.Text = "Start Flash";
		this.Guna2Button10.TextFormatNoPrefix = true;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		this.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
		base.ClientSize = new System.Drawing.Size(496, 534);
		base.ControlBox = false;
		base.Controls.Add(this.TabControlExt1);
		base.Controls.Add(this.Comboboxport);
		base.Controls.Add(this.cbstorage);
		base.Controls.Add(this.RichTextBox3);
		base.Controls.Add(this.TextBox1);
		base.Controls.Add(this.Port_Name);
		base.Controls.Add(this.TextBox11);
		base.Controls.Add(this.TextBox7);
		base.Controls.Add(this.ComboBox1);
		base.Controls.Add(this.RichTextBox2);
		base.Controls.Add(this.TextBox15);
		base.Controls.Add(this.TextBox4);
		this.Cursor = System.Windows.Forms.Cursors.Hand;
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "flash";
		base.ShowIcon = false;
		base.ShowInTaskbar = false;
		this.Text = " Services Flash [All]";
		this.Guna2GroupBox1.ResumeLayout(false);
		this.Guna2GroupBox1.PerformLayout();
		this.Guna2GroupBox3.ResumeLayout(false);
		this.Guna2GroupBox3.PerformLayout();
		this.Guna2GroupBox2.ResumeLayout(false);
		this.Guna2GroupBox2.PerformLayout();
		this.Guna2GroupBox4.ResumeLayout(false);
		this.TabControlExt1.ResumeLayout(false);
		this.TabPage2.ResumeLayout(false);
		this.TabPage4.ResumeLayout(false);
		this.TabPage1.ResumeLayout(false);
		this.TabPage1.PerformLayout();
		this.Guna2GroupBox5.ResumeLayout(false);
		this.Guna2GroupBox9.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.DataGridFlash).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public static string DetectSerialPortLG(string string_0)
	{
		string result = null;
		using ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE Caption like '%(COM%'");
		Class85 @class = new Class85();
		string[] portNames = SerialPort.GetPortNames();
		@class.ienumerable_0 = managementObjectSearcher.Get().Cast<ManagementBaseObject>().ToList()
			.Select(Class87.x.method_3);
		list_0 = portNames.Select(@class.method_0).ToList();
		foreach (string item in list_0)
		{
			if (item.Contains(string_0))
			{
				result = item;
			}
		}
		return result;
	}

	private void MaterialButton23_Click(object sender, EventArgs e)
	{
	}

	private void Name_PORT_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	private void Name_PORT_Click(object sender, EventArgs e)
	{
	}

	private void Name_PORT_SelectedIndexChanged_1(object sender, EventArgs e)
	{
	}

	private void method_Refrescom()
	{
		new Thread(method_Refrescom0).Start();
	}

	private void method_Refrescom0()
	{
		ComboBox1.Items.Clear();
		new ManagementObjectSearcher("SELECT * FROM WIN32_SerialPort").Get();
		foreach (COMPortInfoO item in COMPortInfoO.GetCOMPortsInfolg())
		{
			ComboBox1.Items.Add(string.Format("{0}{1}", "\r", item.Description));
			TextBox4.Text = Conversions.ToString(ComboBox1.Items.Count);
			if (Operators.CompareString(TextBox4.Text, "1", TextCompare: false) == 0)
			{
				ComboBox1.SelectedIndex = 0;
				text3 = ComboBox1.SelectedItem.ToString();
				if (!text3.Contains("USB Serial Port"))
				{
					ComboBox1.Items.RemoveAt(ComboBox1.SelectedIndex);
				}
			}
			if (Operators.CompareString(TextBox4.Text, "2", TextCompare: false) == 0)
			{
				ComboBox1.SelectedIndex = 0;
				text3 = ComboBox1.SelectedItem.ToString();
				if (!text3.Contains("USB Serial Port"))
				{
					ComboBox1.Items.RemoveAt(ComboBox1.SelectedIndex);
				}
				ComboBox1.SelectedIndex = 1;
				text3 = ComboBox1.SelectedItem.ToString();
				if (!text3.Contains("USB Serial Port"))
				{
					ComboBox1.Items.RemoveAt(ComboBox1.SelectedIndex);
				}
			}
			if (Operators.CompareString(TextBox4.Text, "3", TextCompare: false) == 0)
			{
				ComboBox1.SelectedIndex = 0;
				text3 = ComboBox1.SelectedItem.ToString();
				if (!text3.Contains("USB Serial Port"))
				{
					ComboBox1.Items.RemoveAt(ComboBox1.SelectedIndex);
				}
				ComboBox1.SelectedIndex = 1;
				text3 = ComboBox1.SelectedItem.ToString();
				if (!text3.Contains("USB Serial Port"))
				{
					ComboBox1.Items.RemoveAt(ComboBox1.SelectedIndex);
				}
				ComboBox1.SelectedIndex = 2;
				text3 = ComboBox1.SelectedItem.ToString();
				if (!text3.Contains("USB Serial Port"))
				{
					ComboBox1.Items.RemoveAt(ComboBox1.SelectedIndex);
				}
			}
			if (Operators.CompareString(TextBox4.Text, "4", TextCompare: false) == 0)
			{
				ComboBox1.SelectedIndex = 0;
				text3 = ComboBox1.SelectedItem.ToString();
				if (!text3.Contains("USB Serial Port"))
				{
					ComboBox1.Items.RemoveAt(ComboBox1.SelectedIndex);
				}
				ComboBox1.SelectedIndex = 1;
				text3 = ComboBox1.SelectedItem.ToString();
				if (!text3.Contains("USB Serial Port"))
				{
					ComboBox1.Items.RemoveAt(ComboBox1.SelectedIndex);
				}
				ComboBox1.SelectedIndex = 2;
				text3 = ComboBox1.SelectedItem.ToString();
				if (!text3.Contains("USB Serial Port"))
				{
					ComboBox1.Items.RemoveAt(ComboBox1.SelectedIndex);
				}
				ComboBox1.SelectedIndex = 3;
				text3 = ComboBox1.SelectedItem.ToString();
				if (!text3.Contains("USB Serial Port"))
				{
					ComboBox1.Items.RemoveAt(ComboBox1.SelectedIndex);
				}
			}
			if (Operators.CompareString(TextBox4.Text, "5", TextCompare: false) == 0)
			{
				ComboBox1.SelectedIndex = 0;
				text3 = ComboBox1.SelectedItem.ToString();
				if (!text3.Contains("USB Serial Port"))
				{
					ComboBox1.Items.RemoveAt(ComboBox1.SelectedIndex);
				}
				ComboBox1.SelectedIndex = 1;
				text3 = ComboBox1.SelectedItem.ToString();
				if (!text3.Contains("USB Serial Port"))
				{
					ComboBox1.Items.RemoveAt(ComboBox1.SelectedIndex);
				}
				ComboBox1.SelectedIndex = 2;
				text3 = ComboBox1.SelectedItem.ToString();
				if (!text3.Contains("USB Serial Port"))
				{
					ComboBox1.Items.RemoveAt(ComboBox1.SelectedIndex);
				}
				ComboBox1.SelectedIndex = 3;
				text3 = ComboBox1.SelectedItem.ToString();
				if (!text3.Contains("USB Serial Port"))
				{
					ComboBox1.Items.RemoveAt(ComboBox1.SelectedIndex);
				}
				ComboBox1.SelectedIndex = 4;
				text3 = ComboBox1.SelectedItem.ToString();
				if (!text3.Contains("USB Serial Port"))
				{
					ComboBox1.Items.RemoveAt(ComboBox1.SelectedIndex);
				}
			}
			if (Operators.CompareString(TextBox4.Text, "6", TextCompare: false) == 0)
			{
				ComboBox1.SelectedIndex = 0;
				text3 = ComboBox1.SelectedItem.ToString();
				if (!text3.Contains("USB Serial Port"))
				{
					ComboBox1.Items.RemoveAt(ComboBox1.SelectedIndex);
				}
				ComboBox1.SelectedIndex = 1;
				text3 = ComboBox1.SelectedItem.ToString();
				if (!text3.Contains("USB Serial Port"))
				{
					ComboBox1.Items.RemoveAt(ComboBox1.SelectedIndex);
				}
				ComboBox1.SelectedIndex = 2;
				text3 = ComboBox1.SelectedItem.ToString();
				if (!text3.Contains("USB Serial Port"))
				{
					ComboBox1.Items.RemoveAt(ComboBox1.SelectedIndex);
				}
				ComboBox1.SelectedIndex = 3;
				text3 = ComboBox1.SelectedItem.ToString();
				if (!text3.Contains("USB Serial Port"))
				{
					ComboBox1.Items.RemoveAt(ComboBox1.SelectedIndex);
				}
				ComboBox1.SelectedIndex = 4;
				text3 = ComboBox1.SelectedItem.ToString();
				if (!text3.Contains("USB Serial Port"))
				{
					ComboBox1.Items.RemoveAt(ComboBox1.SelectedIndex);
				}
				ComboBox1.SelectedIndex = 5;
				text3 = ComboBox1.SelectedItem.ToString();
				if (!text3.Contains("USB Serial Port"))
				{
					ComboBox1.Items.RemoveAt(ComboBox1.SelectedIndex);
				}
			}
		}
		method_DistributionPorts0();
	}

	public void method_DistributionPorts0()
	{
		checked
		{
			try
			{
				TextBox4.Text = Conversions.ToString(ComboBox1.Items.Count);
				if (Operators.CompareString(TextBox4.Text, "0", TextCompare: false) == 0)
				{
					COM1.Clear();
					COM2.Clear();
					COM3.Clear();
					COM4.Clear();
					COM1ProgressBar1.Text = "";
					COM1ProgressBar1.Value = 0;
					COM2ProgressBar1.Text = "";
					COM2ProgressBar1.Value = 0;
					COM3ProgressBar1.Text = "";
					COM3ProgressBar1.Value = 0;
					COM4ProgressBar1.Text = "";
					COM4ProgressBar1.Value = 0;
				}
				if (Operators.CompareString(TextBox4.Text, "1", TextCompare: false) == 0)
				{
					COM1.Clear();
					COM2.Clear();
					COM3.Clear();
					COM4.Clear();
					ComboBox1.SelectedIndex = 0;
					text3 = ComboBox1.SelectedItem.ToString();
					text3 = text3.Substring(text3.IndexOf("(") + 1, text3.Length - 2 - text3.IndexOf("(")).Replace(")", "");
					COM1.Text = text3;
					COM2ProgressBar1.Text = "";
					COM2ProgressBar1.Value = 0;
					COM3ProgressBar1.Text = "";
					COM3ProgressBar1.Value = 0;
					COM4ProgressBar1.Text = "";
					COM4ProgressBar1.Value = 0;
				}
				if (Operators.CompareString(TextBox4.Text, "2", TextCompare: false) == 0)
				{
					COM1.Clear();
					COM2.Clear();
					COM3.Clear();
					COM4.Clear();
					ComboBox1.SelectedIndex = 0;
					text3 = ComboBox1.SelectedItem.ToString();
					text3 = text3.Substring(text3.IndexOf("(") + 1, text3.Length - 2 - text3.IndexOf("(")).Replace(")", "");
					COM1.Text = text3;
					ComboBox1.SelectedIndex = 1;
					text3 = ComboBox1.SelectedItem.ToString();
					text3 = text3.Substring(text3.IndexOf("(") + 1, text3.Length - 2 - text3.IndexOf("(")).Replace(")", "");
					COM2.Text = text3;
					COM3ProgressBar1.Text = "";
					COM3ProgressBar1.Value = 0;
					COM4ProgressBar1.Text = "";
					COM4ProgressBar1.Value = 0;
				}
				if (Operators.CompareString(TextBox4.Text, "3", TextCompare: false) == 0)
				{
					COM1.Clear();
					COM2.Clear();
					COM3.Clear();
					COM4.Clear();
					ComboBox1.SelectedIndex = 0;
					text3 = ComboBox1.SelectedItem.ToString();
					text3 = text3.Substring(text3.IndexOf("(") + 1, text3.Length - 2 - text3.IndexOf("(")).Replace(")", "");
					COM1.Text = text3;
					ComboBox1.SelectedIndex = 1;
					text3 = ComboBox1.SelectedItem.ToString();
					text3 = text3.Substring(text3.IndexOf("(") + 1, text3.Length - 2 - text3.IndexOf("(")).Replace(")", "");
					COM2.Text = text3;
					ComboBox1.SelectedIndex = 2;
					text3 = ComboBox1.SelectedItem.ToString();
					text3 = text3.Substring(text3.IndexOf("(") + 1, text3.Length - 2 - text3.IndexOf("(")).Replace(")", "");
					COM3.Text = text3;
					COM4ProgressBar1.Text = "";
					COM4ProgressBar1.Value = 0;
				}
				if (Operators.CompareString(TextBox4.Text, "4", TextCompare: false) == 0)
				{
					COM1.Clear();
					COM2.Clear();
					COM3.Clear();
					COM4.Clear();
					ComboBox1.SelectedIndex = 0;
					text3 = ComboBox1.SelectedItem.ToString();
					text3 = text3.Substring(text3.IndexOf("(") + 1, text3.Length - 2 - text3.IndexOf("(")).Replace(")", "");
					COM1.Text = text3;
					ComboBox1.SelectedIndex = 1;
					text3 = ComboBox1.SelectedItem.ToString();
					text3 = text3.Substring(text3.IndexOf("(") + 1, text3.Length - 2 - text3.IndexOf("(")).Replace(")", "");
					COM2.Text = text3;
					ComboBox1.SelectedIndex = 2;
					text3 = ComboBox1.SelectedItem.ToString();
					text3 = text3.Substring(text3.IndexOf("(") + 1, text3.Length - 2 - text3.IndexOf("(")).Replace(")", "");
					COM3.Text = text3;
					ComboBox1.SelectedIndex = 3;
					text3 = ComboBox1.SelectedItem.ToString();
					text3 = text3.Substring(text3.IndexOf("(") + 1, text3.Length - 2 - text3.IndexOf("(")).Replace(")", "");
					COM4.Text = text3;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void method_flash22()
	{
		TextBox4.Text = Conversions.ToString(ComboBox1.Items.Count);
		if (Operators.CompareString(TextBox4.Text, "1", TextCompare: false) == 0)
		{
			TextBox7.Text = "(1 Devices)";
			method_flashcom1();
		}
		if (Operators.CompareString(TextBox4.Text, "2", TextCompare: false) == 0)
		{
			TextBox7.Text = "(2 Devices)";
			method_flashcom1();
			method_flashcom2();
		}
		if (Operators.CompareString(TextBox4.Text, "3", TextCompare: false) == 0)
		{
			TextBox7.Text = "(3 Devices)";
			method_flashcom1();
			method_flashcom2();
			method_flashcom3();
		}
		if (Operators.CompareString(TextBox4.Text, "4", TextCompare: false) == 0)
		{
			TextBox7.Text = "(4 Devices)";
			method_flashcom1();
			method_flashcom2();
			method_flashcom3();
			method_flashcom4();
		}
	}

	public void method_flashcom1()
	{
		COM1ProgressBar1.Text = "Checking Files...";
		COM1ProgressBar1.Value = 0;
		FLASHcom1();
	}

	public void method_flashcom2()
	{
		COM2ProgressBar1.Text = "Checking Files...";
		COM2ProgressBar1.Value = 0;
		FLASHcom2();
	}

	public void method_flashcom3()
	{
		COM3ProgressBar1.Text = "Checking Files...";
		COM3ProgressBar1.Value = 0;
		FLASHcom3();
	}

	public void method_flashcom4()
	{
		COM4ProgressBar1.Value = 0;
		COM4ProgressBar1.Text = "Checking Files...";
		FLASHcom4();
	}

	private byte[] send_LGLafCommand(string command)
	{
		string fileName = "C:/Windows/DUT/TF/1234.exe";
		Process process = new Process();
		ProcessStartInfo startInfo = new ProcessStartInfo
		{
			FileName = fileName,
			Arguments = command,
			RedirectStandardOutput = true,
			UseShellExecute = false,
			CreateNoWindow = true
		};
		process.StartInfo = startInfo;
		process.Start();
		process.WaitForExit(15000);
		checked
		{
			if (!process.HasExited)
			{
				process.Kill();
				Process[] processesByName = Process.GetProcessesByName("lg");
				int num = processesByName.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					processesByName[i].Kill();
				}
			}
			MemoryStream memoryStream = new MemoryStream();
			using (memoryStream)
			{
				process.StandardOutput.BaseStream.CopyTo(memoryStream);
				return memoryStream.ToArray();
			}
		}
	}

	public void Delay(double dblSecs)
	{
		DateAndTime.Now.AddSeconds(1.1574074074074073E-05);
		DateTime t = DateAndTime.Now.AddSeconds(1.1574074074074073E-05).AddSeconds(dblSecs);
		while (DateTime.Compare(DateAndTime.Now, t) <= 0)
		{
			Application.DoEvents();
		}
	}

	public void FLASHcom1()
	{
		string_14 = COM1.Text;
		string_14 = string_14.Replace("C", "").Replace("O", "").Replace("M", "");
		string_13 = "\"" + name_flash.Text + "\"";
		LGPythoncom1();
	}

	public void LGPythoncom1()
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			UseShellExecute = false,
			CreateNoWindow = true,
			FileName = "\"C:\\Windows\\DUT\\TF\\12345.exe\" " + string_14 + " \"C:\\Windows\\DUT\\TF\\LGUP_CommonOLD.dll\" ",
			Arguments = string_13,
			RedirectStandardInput = true,
			RedirectStandardOutput = true
		};
		process.Start();
		Console.WriteLine(string_13);
		process.StandardInput.WriteLine(string_13);
		process.StandardInput.Flush();
		process.StandardInput.Close();
		process.OutputDataReceived += lgflashcheckcom1;
		process.BeginOutputReadLine();
		process.Dispose();
	}

	private void lgflashcheckcom1(object sender, DataReceivedEventArgs e)
	{
		try
		{
			string obj = e.Data ?? string.Empty;
			if (obj.Contains("0x5002, USB Write packet failed"))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
				Form1.SharedUI.RichTextBox1.AppendText("Failed Via ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(COM1.Text);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Check The Cable, And Try Again");
			}
			if (obj.Contains("Download Error"))
			{
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
				Form1.SharedUI.RichTextBox1.AppendText("Failed Via ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(COM1.Text);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Check The Dll, And Try Again");
			}
			if (obj.Contains("Progress Percent: 11"))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("OK");
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Analyze Active From Device : ");
				COM1ProgressBar1.Value = 0;
				COM1ProgressBar1.Text = "Analyzeing..";
			}
			if (obj.Contains("Progress Percent: 12"))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("OK");
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Write active1 ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.LightGreen;
				Form1.SharedUI.RichTextBox1.AppendText(TextBox7.Text);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(" : ");
				COM1ProgressBar1.Value = 0;
				chengbar = "10";
				Delay(0.3);
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("OK");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Write encrypt ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.LightGreen;
				Form1.SharedUI.RichTextBox1.AppendText(TextBox7.Text);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(" : ");
				COM1ProgressBar1.Value = 0;
				chengbar = "10";
				Delay(0.2);
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("OK");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Write carrier ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.LightGreen;
				Form1.SharedUI.RichTextBox1.AppendText(TextBox7.Text);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(" : ");
				COM1ProgressBar1.Value = 0;
				chengbar = "10";
				Delay(0.2);
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("OK");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Write eri ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.LightGreen;
				Form1.SharedUI.RichTextBox1.AppendText(TextBox7.Text);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(" : ");
				COM1ProgressBar1.Value = 0;
				chengbar = "10";
				Delay(0.2);
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("OK");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Write op_a ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.LightGreen;
				Form1.SharedUI.RichTextBox1.AppendText(TextBox7.Text);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(" : ");
				COM1ProgressBar1.Value = 0;
				chengbar = "10";
				Delay(0.2);
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("OK");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Write op_b ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.LightGreen;
				Form1.SharedUI.RichTextBox1.AppendText(TextBox7.Text);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(" : ");
				COM1ProgressBar1.Value = 0;
				chengbar = "10";
				Delay(0.2);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("OK");
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Write md1img_a ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.LightGreen;
				Form1.SharedUI.RichTextBox1.AppendText(TextBox7.Text);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(" : ");
				COM1ProgressBar1.Value = 0;
				chengbar = "12";
			}
			if (obj.Contains("Progress Percent: 14"))
			{
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("OK");
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Write md1img_b ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.LightGreen;
				Form1.SharedUI.RichTextBox1.AppendText(TextBox7.Text);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(" : ");
				Form1.SharedUI.RichTextBox1.Update();
				COM1ProgressBar1.Value = 0;
				chengbar = "12";
			}
			if (obj.Contains("Progress Percent: 15"))
			{
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("OK");
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Write spmfw_b ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.LightGreen;
				Form1.SharedUI.RichTextBox1.AppendText(TextBox7.Text);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(" : ");
				Form1.SharedUI.RichTextBox1.Update();
				COM1ProgressBar1.Value = 0;
				chengbar = "10";
				Delay(0.5);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("OK");
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Write scp_b ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.LightGreen;
				Form1.SharedUI.RichTextBox1.AppendText(TextBox7.Text);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(" : ");
				COM1ProgressBar1.Value = 0;
				chengbar = "10";
				Delay(0.5);
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("OK");
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Write sspm_b ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.LightGreen;
				Form1.SharedUI.RichTextBox1.AppendText(TextBox7.Text);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(" : ");
				COM1ProgressBar1.Value = 0;
				chengbar = "10";
				Delay(0.5);
			}
			if (obj.Contains("Progress Percent: 16"))
			{
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("OK");
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Write tee_b ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.LightGreen;
				Form1.SharedUI.RichTextBox1.AppendText(TextBox7.Text);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(" : ");
				COM1ProgressBar1.Value = 0;
				chengbar = "12";
			}
			if (obj.Contains("Progress Percent: 18"))
			{
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("OK");
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Write logo_b ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.LightGreen;
				Form1.SharedUI.RichTextBox1.AppendText(TextBox7.Text);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(" : ");
				COM1ProgressBar1.Value = 0;
				chengbar = "10";
				Delay(0.5);
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("OK");
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Write lk_b ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.LightGreen;
				Form1.SharedUI.RichTextBox1.AppendText(TextBox7.Text);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(" : ");
				COM1ProgressBar1.Value = 0;
				chengbar = "12";
			}
			if (obj.Contains("Progress Percent: 20"))
			{
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("OK");
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Write dtbo_b ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.LightGreen;
				Form1.SharedUI.RichTextBox1.AppendText(TextBox7.Text);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(" : ");
				COM1ProgressBar1.Value = 0;
				chengbar = "12";
			}
			if (obj.Contains("Progress Percent: 22"))
			{
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("OK");
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Write laf_b ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.LightGreen;
				Form1.SharedUI.RichTextBox1.AppendText(TextBox7.Text);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(" : ");
				COM1ProgressBar1.Value = 0;
				chengbar = "12";
			}
			if (obj.Contains("Progress Percent: 24"))
			{
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("OK");
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Write vbmeta_a ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.LightGreen;
				Form1.SharedUI.RichTextBox1.AppendText(TextBox7.Text);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(" : ");
				COM1ProgressBar1.Value = 0;
				chengbar = "11";
			}
			if (obj.Contains("Progress Percent: 25"))
			{
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("OK");
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Write vbmeta_b ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.LightGreen;
				Form1.SharedUI.RichTextBox1.AppendText(TextBox7.Text);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(" : ");
				COM1ProgressBar1.Value = 0;
				chengbar = "12";
			}
			if (obj.Contains("Progress Percent: 27"))
			{
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("OK");
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Write boot_b ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.LightGreen;
				Form1.SharedUI.RichTextBox1.AppendText(TextBox7.Text);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(" : ");
				COM1ProgressBar1.Value = 0;
				chengbar = "11";
			}
			if (obj.Contains("Progress Percent: 28"))
			{
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("OK");
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Write boot_a ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.LightGreen;
				Form1.SharedUI.RichTextBox1.AppendText(TextBox7.Text);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(" : ");
				COM1ProgressBar1.Value = 0;
				chengbar = "11";
			}
			if (obj.Contains("Progress Percent: 29"))
			{
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("OK");
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Write system ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.LightGreen;
				Form1.SharedUI.RichTextBox1.AppendText(TextBox7.Text);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(" : ");
				Form1.SharedUI.RichTextBox1.Update();
				COM1ProgressBar1.Value = 0;
				chengbar = "";
				COM1ProgressBar1.Visible = true;
				COM1ProgressBar1.Value = 1;
				COM1ProgressBar1.Text = "1%";
			}
			if (obj.Contains("Progress Percent: 30"))
			{
				COM1ProgressBar1.Visible = true;
				COM1ProgressBar1.Value = 2;
				COM1ProgressBar1.Text = "2%";
			}
			if (obj.Contains("Progress Percent: 31"))
			{
				COM1ProgressBar1.Visible = true;
				COM1ProgressBar1.Value = 4;
				COM1ProgressBar1.Text = "4%";
			}
			if (obj.Contains("Progress Percent: 32"))
			{
				COM1ProgressBar1.Visible = true;
				COM1ProgressBar1.Value = 6;
				COM1ProgressBar1.Text = "6%";
			}
			if (obj.Contains("Progress Percent: 33"))
			{
				COM1ProgressBar1.Visible = true;
				COM1ProgressBar1.Value = 9;
				COM1ProgressBar1.Text = "9%";
			}
			if (obj.Contains("Progress Percent: 34"))
			{
				COM1ProgressBar1.Visible = true;
				COM1ProgressBar1.Value = 13;
				COM1ProgressBar1.Text = "13%";
			}
			if (obj.Contains("Progress Percent: 35"))
			{
				COM1ProgressBar1.Visible = true;
				COM1ProgressBar1.Value = 16;
				COM1ProgressBar1.Text = "16%";
			}
			if (obj.Contains("Progress Percent: 36"))
			{
				COM1ProgressBar1.Visible = true;
				COM1ProgressBar1.Value = 19;
				COM1ProgressBar1.Text = "19%";
			}
			if (obj.Contains("Progress Percent: 37"))
			{
				COM1ProgressBar1.Visible = true;
				COM1ProgressBar1.Value = 22;
				COM1ProgressBar1.Text = "22%";
			}
			if (obj.Contains("Progress Percent: 38"))
			{
				COM1ProgressBar1.Visible = true;
				COM1ProgressBar1.Value = 25;
				COM1ProgressBar1.Text = "25%";
			}
			if (obj.Contains("Progress Percent: 39"))
			{
				COM1ProgressBar1.Visible = true;
				COM1ProgressBar1.Value = 28;
				COM1ProgressBar1.Text = "28%";
			}
			if (obj.Contains("Progress Percent: 40"))
			{
				COM1ProgressBar1.Visible = true;
				COM1ProgressBar1.Value = 31;
				COM1ProgressBar1.Text = "31%";
			}
			if (obj.Contains("Progress Percent: 45"))
			{
				COM1ProgressBar1.Visible = true;
				COM1ProgressBar1.Value = 34;
				COM1ProgressBar1.Text = "34%";
			}
			if (obj.Contains("Progress Percent: 46"))
			{
				COM1ProgressBar1.Visible = true;
				COM1ProgressBar1.Value = 37;
				COM1ProgressBar1.Text = "37%";
			}
			if (obj.Contains("Progress Percent: 47"))
			{
				COM1ProgressBar1.Visible = true;
				COM1ProgressBar1.Value = 40;
				COM1ProgressBar1.Text = "40%";
			}
			if (obj.Contains("Progress Percent: 48"))
			{
				COM1ProgressBar1.Visible = true;
				COM1ProgressBar1.Value = 42;
				COM1ProgressBar1.Text = "42%";
			}
			if (obj.Contains("Progress Percent: 49"))
			{
				COM1ProgressBar1.Visible = true;
				COM1ProgressBar1.Value = 44;
				COM1ProgressBar1.Text = "44%";
			}
			if (obj.Contains("Progress Percent: 50"))
			{
				COM1ProgressBar1.Visible = true;
				COM1ProgressBar1.Value = 46;
				COM1ProgressBar1.Text = "46%";
			}
			if (obj.Contains("Progress Percent: 51"))
			{
				COM1ProgressBar1.Visible = true;
				COM1ProgressBar1.Value = 48;
				COM1ProgressBar1.Text = "48%";
			}
			if (obj.Contains("Progress Percent: 52"))
			{
				COM1ProgressBar1.Visible = true;
				COM1ProgressBar1.Value = 50;
				COM1ProgressBar1.Text = "50%";
			}
			if (obj.Contains("Progress Percent: 53"))
			{
				COM1ProgressBar1.Visible = true;
				COM1ProgressBar1.Value = 51;
				COM1ProgressBar1.Text = "51%";
			}
			if (obj.Contains("Progress Percent: 54"))
			{
				COM1ProgressBar1.Visible = true;
				COM1ProgressBar1.Value = 52;
				COM1ProgressBar1.Text = "52%";
			}
			if (obj.Contains("Progress Percent: 55"))
			{
				COM1ProgressBar1.Visible = true;
				COM1ProgressBar1.Value = 53;
				COM1ProgressBar1.Text = "53%";
			}
			if (obj.Contains("Progress Percent: 56"))
			{
				COM1ProgressBar1.Visible = true;
				COM1ProgressBar1.Value = 54;
				COM1ProgressBar1.Text = "54%";
			}
			if (obj.Contains("Progress Percent: 57"))
			{
				COM1ProgressBar1.Visible = true;
				COM1ProgressBar1.Value = 55;
				COM1ProgressBar1.Text = "55%";
			}
			if (obj.Contains("Progress Percent: 58"))
			{
				COM1ProgressBar1.Visible = true;
				COM1ProgressBar1.Value = 57;
				COM1ProgressBar1.Text = "57%";
			}
			if (obj.Contains("Progress Percent: 59"))
			{
				COM1ProgressBar1.Visible = true;
				COM1ProgressBar1.Value = 59;
				COM1ProgressBar1.Text = "59%";
			}
			if (obj.Contains("Progress Percent: 60"))
			{
				COM1ProgressBar1.Visible = true;
				COM1ProgressBar1.Value = 62;
				COM1ProgressBar1.Text = "62%";
			}
			if (obj.Contains("Progress Percent: 61"))
			{
				COM1ProgressBar1.Visible = true;
				COM1ProgressBar1.Value = 63;
				COM1ProgressBar1.Text = "63%";
			}
			if (obj.Contains("Progress Percent: 62"))
			{
				COM1ProgressBar1.Visible = true;
				COM1ProgressBar1.Value = 66;
				COM1ProgressBar1.Text = "66%";
			}
			if (obj.Contains("Progress Percent: 65"))
			{
				COM1ProgressBar1.Visible = true;
				COM1ProgressBar1.Value = 69;
				COM1ProgressBar1.Text = "69%";
			}
			if (obj.Contains("Progress Percent: 68"))
			{
				COM1ProgressBar1.Visible = true;
				COM1ProgressBar1.Value = 73;
				COM1ProgressBar1.Text = "73%";
			}
			if (obj.Contains("Progress Percent: 70"))
			{
				COM1ProgressBar1.Visible = true;
				COM1ProgressBar1.Value = 77;
				COM1ProgressBar1.Text = "77%";
			}
			if (obj.Contains("Progress Percent: 73"))
			{
				COM1ProgressBar1.Visible = true;
				COM1ProgressBar1.Value = 80;
				COM1ProgressBar1.Text = "80%";
			}
			if (obj.Contains("Progress Percent: 75"))
			{
				COM1ProgressBar1.Visible = true;
				COM1ProgressBar1.Value = 84;
				COM1ProgressBar1.Text = "84%";
			}
			if (obj.Contains("Progress Percent: 78"))
			{
				COM1ProgressBar1.Visible = true;
				COM1ProgressBar1.Value = 88;
				COM1ProgressBar1.Text = "88%";
			}
			if (obj.Contains("Progress Percent: 79"))
			{
				COM1ProgressBar1.Visible = true;
				COM1ProgressBar1.Value = 95;
				COM1ProgressBar1.Text = "95%";
				Delay(2.5);
				Delay(1.5);
				COM1ProgressBar1.Value = 99;
				COM1ProgressBar1.Text = "99%";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("OK");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Reboot Devices : ");
				Form1.SharedUI.RichTextBox1.Update();
				Delay(1.0);
				COM1.Text = "";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("OK");
				COM1ProgressBar1.Value = 0;
				COM1ProgressBar1.Text = "Flash Done!";
			}
			if (obj.Contains("Progress Percent: 82"))
			{
				FINSH_FLASHcom1();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception projectError = ex;
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
	}

	private void wesreampung_wav()
	{
		if (RichTextBox2.Text.Contains("Windows 11"))
		{
			SoundPlayer soundPlayer = new SoundPlayer();
			soundPlayer.SoundLocation = "Plug\\ssc\\Bgm11.wav";
			soundPlayer.Load();
			soundPlayer.Play();
		}
		if (RichTextBox2.Text.Contains("Windows 10"))
		{
			SoundPlayer soundPlayer2 = new SoundPlayer();
			soundPlayer2.SoundLocation = "Plug\\ssc\\Bgm10.wav";
			soundPlayer2.Load();
			soundPlayer2.Play();
		}
	}

	public void FLASHcom2()
	{
		string_14 = COM2.Text;
		string_14 = string_14.Replace("C", "").Replace("O", "").Replace("M", "");
		string_13 = "\"" + name_flash.Text + "\"";
		LGPythoncom2();
	}

	public void LGPythoncom2()
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			UseShellExecute = false,
			CreateNoWindow = true,
			FileName = "\"C:\\Windows\\DUT\\TF\\12345.exe\" " + string_14 + " \"C:\\Windows\\DUT\\TF\\LGUP_CommonOLD.dll\" ",
			Arguments = string_13,
			RedirectStandardInput = true,
			RedirectStandardOutput = true
		};
		process.Start();
		Console.WriteLine(string_13);
		process.StandardInput.WriteLine(string_13);
		process.StandardInput.Flush();
		process.StandardInput.Close();
		process.OutputDataReceived += lgflashcheckcom2;
		process.BeginOutputReadLine();
		process.Dispose();
	}

	private void lgflashcheckcom2(object sender, DataReceivedEventArgs e)
	{
		try
		{
			string obj = e.Data ?? string.Empty;
			if (obj.Contains("0x5002, USB Write packet failed"))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
				Form1.SharedUI.RichTextBox1.AppendText("Failed Via ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(COM2.Text);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Check The Cable, And Try Again");
			}
			if (obj.Contains("Download Error"))
			{
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
				Form1.SharedUI.RichTextBox1.AppendText("Failed Via ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(COM2.Text);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Check The Dll, And Try Again");
			}
			if (obj.Contains("Progress Percent: 11"))
			{
				COM2ProgressBar1.Value = 0;
				COM2ProgressBar1.Text = "Analyzeing..";
			}
			if (obj.Contains("Progress Percent: 12"))
			{
				COM2ProgressBar1.Value = 0;
				chengbar = "10";
				Delay(0.3);
				COM2ProgressBar1.Value = 0;
				chengbar = "10";
				Delay(0.2);
				COM2ProgressBar1.Value = 0;
				chengbar = "10";
				Delay(0.2);
				COM2ProgressBar1.Value = 0;
				chengbar = "10";
				Delay(0.2);
				COM2ProgressBar1.Value = 0;
				chengbar = "10";
				Delay(0.2);
				COM2ProgressBar1.Value = 0;
				chengbar = "10";
				Delay(0.2);
				COM2ProgressBar1.Value = 0;
				chengbar = "12";
			}
			if (obj.Contains("Progress Percent: 14"))
			{
				COM2ProgressBar1.Value = 0;
				chengbar = "12";
			}
			if (obj.Contains("Progress Percent: 15"))
			{
				COM2ProgressBar1.Value = 0;
				chengbar = "10";
				Delay(0.5);
				COM2ProgressBar1.Value = 0;
				chengbar = "10";
				Delay(0.5);
				COM2ProgressBar1.Value = 0;
				chengbar = "10";
				Delay(0.5);
			}
			if (obj.Contains("Progress Percent: 16"))
			{
				COM2ProgressBar1.Value = 0;
				chengbar = "12";
			}
			if (obj.Contains("Progress Percent: 18"))
			{
				COM2ProgressBar1.Value = 0;
				chengbar = "10";
				Delay(0.5);
				COM2ProgressBar1.Value = 0;
				chengbar = "12";
			}
			if (obj.Contains("Progress Percent: 20"))
			{
				COM2ProgressBar1.Value = 0;
				chengbar = "12";
			}
			if (obj.Contains("Progress Percent: 22"))
			{
				COM2ProgressBar1.Value = 0;
				chengbar = "12";
			}
			if (obj.Contains("Progress Percent: 24"))
			{
				COM2ProgressBar1.Value = 0;
				chengbar = "11";
			}
			if (obj.Contains("Progress Percent: 25"))
			{
				COM2ProgressBar1.Value = 0;
				chengbar = "12";
			}
			if (obj.Contains("Progress Percent: 27"))
			{
				COM2ProgressBar1.Value = 0;
				chengbar = "11";
			}
			if (obj.Contains("Progress Percent: 28"))
			{
				COM2ProgressBar1.Value = 0;
				chengbar = "11";
			}
			if (obj.Contains("Progress Percent: 29"))
			{
				COM2ProgressBar1.Value = 0;
				chengbar = "";
				COM2ProgressBar1.Value = 1;
				COM2ProgressBar1.Text = "1%";
			}
			if (obj.Contains("Progress Percent: 30"))
			{
				COM2ProgressBar1.Value = 2;
				COM2ProgressBar1.Text = "2%";
			}
			if (obj.Contains("Progress Percent: 31"))
			{
				COM2ProgressBar1.Value = 4;
				COM2ProgressBar1.Text = "4%";
			}
			if (obj.Contains("Progress Percent: 32"))
			{
				COM2ProgressBar1.Value = 6;
				COM2ProgressBar1.Text = "6%";
			}
			if (obj.Contains("Progress Percent: 33"))
			{
				COM2ProgressBar1.Value = 9;
				COM2ProgressBar1.Text = "9%";
			}
			if (obj.Contains("Progress Percent: 34"))
			{
				COM2ProgressBar1.Value = 13;
				COM2ProgressBar1.Text = "13%";
			}
			if (obj.Contains("Progress Percent: 35"))
			{
				COM2ProgressBar1.Value = 16;
				COM2ProgressBar1.Text = "16%";
			}
			if (obj.Contains("Progress Percent: 36"))
			{
				COM2ProgressBar1.Value = 19;
				COM2ProgressBar1.Text = "19%";
			}
			if (obj.Contains("Progress Percent: 37"))
			{
				COM2ProgressBar1.Value = 22;
				COM2ProgressBar1.Text = "22%";
			}
			if (obj.Contains("Progress Percent: 38"))
			{
				COM2ProgressBar1.Value = 25;
				COM2ProgressBar1.Text = "25%";
			}
			if (obj.Contains("Progress Percent: 39"))
			{
				COM2ProgressBar1.Value = 28;
				COM2ProgressBar1.Text = "28%";
			}
			if (obj.Contains("Progress Percent: 40"))
			{
				COM2ProgressBar1.Value = 31;
				COM2ProgressBar1.Text = "31%";
			}
			if (obj.Contains("Progress Percent: 45"))
			{
				COM2ProgressBar1.Value = 34;
				COM2ProgressBar1.Text = "34%";
			}
			if (obj.Contains("Progress Percent: 46"))
			{
				COM2ProgressBar1.Value = 37;
				COM2ProgressBar1.Text = "37%";
			}
			if (obj.Contains("Progress Percent: 47"))
			{
				COM2ProgressBar1.Value = 40;
				COM2ProgressBar1.Text = "40%";
			}
			if (obj.Contains("Progress Percent: 48"))
			{
				COM2ProgressBar1.Value = 42;
				COM2ProgressBar1.Text = "42%";
			}
			if (obj.Contains("Progress Percent: 49"))
			{
				COM2ProgressBar1.Value = 44;
				COM2ProgressBar1.Text = "44%";
			}
			if (obj.Contains("Progress Percent: 50"))
			{
				COM2ProgressBar1.Value = 46;
				COM2ProgressBar1.Text = "46%";
			}
			if (obj.Contains("Progress Percent: 51"))
			{
				COM2ProgressBar1.Value = 48;
				COM2ProgressBar1.Text = "48%";
			}
			if (obj.Contains("Progress Percent: 52"))
			{
				COM2ProgressBar1.Value = 50;
				COM2ProgressBar1.Text = "50%";
			}
			if (obj.Contains("Progress Percent: 53"))
			{
				COM2ProgressBar1.Value = 51;
				COM2ProgressBar1.Text = "51%";
			}
			if (obj.Contains("Progress Percent: 54"))
			{
				COM2ProgressBar1.Value = 52;
				COM2ProgressBar1.Text = "52%";
			}
			if (obj.Contains("Progress Percent: 55"))
			{
				COM2ProgressBar1.Value = 53;
				COM2ProgressBar1.Text = "53%";
			}
			if (obj.Contains("Progress Percent: 56"))
			{
				COM2ProgressBar1.Value = 54;
				COM2ProgressBar1.Text = "54%";
			}
			if (obj.Contains("Progress Percent: 57"))
			{
				COM2ProgressBar1.Value = 55;
				COM2ProgressBar1.Text = "55%";
			}
			if (obj.Contains("Progress Percent: 58"))
			{
				COM2ProgressBar1.Value = 57;
				COM2ProgressBar1.Text = "57%";
			}
			if (obj.Contains("Progress Percent: 59"))
			{
				COM2ProgressBar1.Value = 59;
				COM2ProgressBar1.Text = "59%";
			}
			if (obj.Contains("Progress Percent: 60"))
			{
				COM2ProgressBar1.Value = 62;
				COM2ProgressBar1.Text = "62%";
			}
			if (obj.Contains("Progress Percent: 61"))
			{
				COM2ProgressBar1.Value = 63;
				COM2ProgressBar1.Text = "63%";
			}
			if (obj.Contains("Progress Percent: 62"))
			{
				COM2ProgressBar1.Value = 66;
				COM2ProgressBar1.Text = "66%";
			}
			if (obj.Contains("Progress Percent: 65"))
			{
				COM2ProgressBar1.Value = 69;
				COM2ProgressBar1.Text = "69%";
			}
			if (obj.Contains("Progress Percent: 68"))
			{
				COM2ProgressBar1.Value = 73;
				COM2ProgressBar1.Text = "73%";
			}
			if (obj.Contains("Progress Percent: 70"))
			{
				COM2ProgressBar1.Value = 77;
				COM2ProgressBar1.Text = "77%";
			}
			if (obj.Contains("Progress Percent: 73"))
			{
				COM2ProgressBar1.Value = 80;
				COM2ProgressBar1.Text = "80%";
			}
			if (obj.Contains("Progress Percent: 75"))
			{
				COM2ProgressBar1.Value = 84;
				COM2ProgressBar1.Text = "84%";
			}
			if (obj.Contains("Progress Percent: 78"))
			{
				COM2ProgressBar1.Value = 88;
				COM2ProgressBar1.Text = "88%";
			}
			if (obj.Contains("Progress Percent: 79"))
			{
				COM2ProgressBar1.Value = 95;
				COM2ProgressBar1.Text = "95%";
				Delay(2.5);
				Delay(1.5);
				COM2ProgressBar1.Value = 99;
				COM2ProgressBar1.Text = "99%";
				Delay(1.0);
				COM2.Text = "";
				COM2ProgressBar1.Value = 0;
				COM2ProgressBar1.Text = "Flash Done!";
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception projectError = ex;
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
	}

	public void FINSH_FLASHcom1()
	{
		try
		{
			Process[] processesByName = Process.GetProcessesByName("12345");
			int num = 0;
			do
			{
				processesByName[num].Kill();
				num = checked(num + 1);
			}
			while (num < processesByName.Length);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception projectError = ex;
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
	}

	public void FLASHcom3()
	{
		string_14 = COM3.Text;
		string_14 = string_14.Replace("C", "").Replace("O", "").Replace("M", "");
		string_13 = "\"" + name_flash.Text + "\"";
		LGPythoncom3();
	}

	public void LGPythoncom3()
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			UseShellExecute = false,
			CreateNoWindow = true,
			FileName = "\"C:\\Windows\\DUT\\TF\\12345.exe\" " + string_14 + " \"C:\\Windows\\DUT\\TF\\LGUP_CommonOLD.dll\" ",
			Arguments = string_13,
			RedirectStandardInput = true,
			RedirectStandardOutput = true
		};
		process.Start();
		Console.WriteLine(string_13);
		process.StandardInput.WriteLine(string_13);
		process.StandardInput.Flush();
		process.StandardInput.Close();
		process.OutputDataReceived += lgflashcheckcom3;
		process.BeginOutputReadLine();
		process.Dispose();
	}

	private void lgflashcheckcom3(object sender, DataReceivedEventArgs e)
	{
		try
		{
			string obj = e.Data ?? string.Empty;
			if (obj.Contains("0x5002, USB Write packet failed"))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
				Form1.SharedUI.RichTextBox1.AppendText("Failed Via ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(COM3.Text);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Check The Cable, And Try Again");
			}
			if (obj.Contains("Download Error"))
			{
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
				Form1.SharedUI.RichTextBox1.AppendText("Failed Via ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(COM3.Text);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Check The Dll, And Try Again");
			}
			if (obj.Contains("Progress Percent: 11"))
			{
				COM3ProgressBar1.Value = 0;
				COM3ProgressBar1.Text = "Analyzeing..";
			}
			if (obj.Contains("Progress Percent: 12"))
			{
				COM3ProgressBar1.Value = 0;
				chengbar = "10";
				Delay(0.3);
				COM3ProgressBar1.Value = 0;
				chengbar = "10";
				Delay(0.2);
				COM3ProgressBar1.Value = 0;
				chengbar = "10";
				Delay(0.2);
				COM3ProgressBar1.Value = 0;
				chengbar = "10";
				Delay(0.2);
				COM3ProgressBar1.Value = 0;
				chengbar = "10";
				Delay(0.2);
				COM3ProgressBar1.Value = 0;
				chengbar = "10";
				Delay(0.2);
				COM3ProgressBar1.Value = 0;
				chengbar = "12";
			}
			if (obj.Contains("Progress Percent: 14"))
			{
				COM3ProgressBar1.Value = 0;
				chengbar = "12";
			}
			if (obj.Contains("Progress Percent: 15"))
			{
				COM3ProgressBar1.Value = 0;
				chengbar = "10";
				Delay(0.5);
				COM3ProgressBar1.Value = 0;
				chengbar = "10";
				Delay(0.5);
				COM3ProgressBar1.Value = 0;
				chengbar = "10";
				Delay(0.5);
			}
			if (obj.Contains("Progress Percent: 16"))
			{
				COM3ProgressBar1.Value = 0;
				chengbar = "12";
			}
			if (obj.Contains("Progress Percent: 18"))
			{
				COM3ProgressBar1.Value = 0;
				chengbar = "10";
				Delay(0.5);
				COM3ProgressBar1.Value = 0;
				chengbar = "12";
			}
			if (obj.Contains("Progress Percent: 20"))
			{
				COM3ProgressBar1.Value = 0;
				chengbar = "12";
			}
			if (obj.Contains("Progress Percent: 22"))
			{
				COM3ProgressBar1.Value = 0;
				chengbar = "12";
			}
			if (obj.Contains("Progress Percent: 24"))
			{
				COM3ProgressBar1.Value = 0;
				chengbar = "11";
			}
			if (obj.Contains("Progress Percent: 25"))
			{
				COM3ProgressBar1.Value = 0;
				chengbar = "12";
			}
			if (obj.Contains("Progress Percent: 27"))
			{
				COM3ProgressBar1.Value = 0;
				chengbar = "11";
			}
			if (obj.Contains("Progress Percent: 28"))
			{
				COM3ProgressBar1.Value = 0;
				chengbar = "11";
			}
			if (obj.Contains("Progress Percent: 29"))
			{
				COM3ProgressBar1.Value = 0;
				chengbar = "";
				COM3ProgressBar1.Value = 1;
				COM3ProgressBar1.Text = "1%";
			}
			if (obj.Contains("Progress Percent: 30"))
			{
				COM3ProgressBar1.Value = 2;
				COM3ProgressBar1.Text = "2%";
			}
			if (obj.Contains("Progress Percent: 31"))
			{
				COM3ProgressBar1.Value = 4;
				COM3ProgressBar1.Text = "4%";
			}
			if (obj.Contains("Progress Percent: 32"))
			{
				COM3ProgressBar1.Value = 6;
				COM3ProgressBar1.Text = "6%";
			}
			if (obj.Contains("Progress Percent: 33"))
			{
				COM3ProgressBar1.Value = 9;
				COM3ProgressBar1.Text = "9%";
			}
			if (obj.Contains("Progress Percent: 34"))
			{
				COM3ProgressBar1.Value = 13;
				COM3ProgressBar1.Text = "13%";
			}
			if (obj.Contains("Progress Percent: 35"))
			{
				COM3ProgressBar1.Value = 16;
				COM3ProgressBar1.Text = "16%";
			}
			if (obj.Contains("Progress Percent: 36"))
			{
				COM3ProgressBar1.Value = 19;
				COM3ProgressBar1.Text = "19%";
			}
			if (obj.Contains("Progress Percent: 37"))
			{
				COM3ProgressBar1.Value = 22;
				COM3ProgressBar1.Text = "22%";
			}
			if (obj.Contains("Progress Percent: 38"))
			{
				COM3ProgressBar1.Value = 25;
				COM3ProgressBar1.Text = "25%";
			}
			if (obj.Contains("Progress Percent: 39"))
			{
				COM3ProgressBar1.Value = 28;
				COM3ProgressBar1.Text = "28%";
			}
			if (obj.Contains("Progress Percent: 40"))
			{
				COM3ProgressBar1.Value = 31;
				COM3ProgressBar1.Text = "31%";
			}
			if (obj.Contains("Progress Percent: 45"))
			{
				COM3ProgressBar1.Value = 34;
				COM3ProgressBar1.Text = "34%";
			}
			if (obj.Contains("Progress Percent: 46"))
			{
				COM3ProgressBar1.Value = 37;
				COM3ProgressBar1.Text = "37%";
			}
			if (obj.Contains("Progress Percent: 47"))
			{
				COM3ProgressBar1.Value = 40;
				COM3ProgressBar1.Text = "40%";
			}
			if (obj.Contains("Progress Percent: 48"))
			{
				COM3ProgressBar1.Value = 42;
				COM3ProgressBar1.Text = "42%";
			}
			if (obj.Contains("Progress Percent: 49"))
			{
				COM3ProgressBar1.Value = 44;
				COM3ProgressBar1.Text = "44%";
			}
			if (obj.Contains("Progress Percent: 50"))
			{
				COM3ProgressBar1.Value = 46;
				COM3ProgressBar1.Text = "46%";
			}
			if (obj.Contains("Progress Percent: 51"))
			{
				COM3ProgressBar1.Value = 48;
				COM3ProgressBar1.Text = "48%";
			}
			if (obj.Contains("Progress Percent: 52"))
			{
				COM3ProgressBar1.Value = 50;
				COM3ProgressBar1.Text = "50%";
			}
			if (obj.Contains("Progress Percent: 53"))
			{
				COM3ProgressBar1.Value = 51;
				COM3ProgressBar1.Text = "51%";
			}
			if (obj.Contains("Progress Percent: 54"))
			{
				COM3ProgressBar1.Value = 52;
				COM3ProgressBar1.Text = "52%";
			}
			if (obj.Contains("Progress Percent: 55"))
			{
				COM3ProgressBar1.Value = 53;
				COM3ProgressBar1.Text = "53%";
			}
			if (obj.Contains("Progress Percent: 56"))
			{
				COM3ProgressBar1.Value = 54;
				COM3ProgressBar1.Text = "54%";
			}
			if (obj.Contains("Progress Percent: 57"))
			{
				COM3ProgressBar1.Value = 55;
				COM3ProgressBar1.Text = "55%";
			}
			if (obj.Contains("Progress Percent: 58"))
			{
				COM3ProgressBar1.Value = 57;
				COM3ProgressBar1.Text = "57%";
			}
			if (obj.Contains("Progress Percent: 59"))
			{
				COM3ProgressBar1.Value = 59;
				COM3ProgressBar1.Text = "59%";
			}
			if (obj.Contains("Progress Percent: 60"))
			{
				COM3ProgressBar1.Value = 62;
				COM3ProgressBar1.Text = "62%";
			}
			if (obj.Contains("Progress Percent: 61"))
			{
				COM3ProgressBar1.Value = 63;
				COM3ProgressBar1.Text = "63%";
			}
			if (obj.Contains("Progress Percent: 62"))
			{
				COM3ProgressBar1.Value = 66;
				COM3ProgressBar1.Text = "66%";
			}
			if (obj.Contains("Progress Percent: 65"))
			{
				COM3ProgressBar1.Value = 69;
				COM3ProgressBar1.Text = "69%";
			}
			if (obj.Contains("Progress Percent: 68"))
			{
				COM3ProgressBar1.Value = 73;
				COM3ProgressBar1.Text = "73%";
			}
			if (obj.Contains("Progress Percent: 70"))
			{
				COM3ProgressBar1.Value = 77;
				COM3ProgressBar1.Text = "77%";
			}
			if (obj.Contains("Progress Percent: 73"))
			{
				COM3ProgressBar1.Value = 80;
				COM3ProgressBar1.Text = "80%";
			}
			if (obj.Contains("Progress Percent: 75"))
			{
				COM3ProgressBar1.Value = 84;
				COM3ProgressBar1.Text = "84%";
			}
			if (obj.Contains("Progress Percent: 78"))
			{
				COM3ProgressBar1.Value = 88;
				COM3ProgressBar1.Text = "88%";
			}
			if (obj.Contains("Progress Percent: 79"))
			{
				COM3ProgressBar1.Value = 95;
				COM3ProgressBar1.Text = "95%";
				Delay(2.5);
				Delay(1.5);
				COM3ProgressBar1.Value = 99;
				COM3ProgressBar1.Text = "99%";
				Delay(1.0);
				COM3.Text = "";
				COM3ProgressBar1.Value = 0;
				COM3ProgressBar1.Text = "Flash Done!";
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception projectError = ex;
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
	}

	public void FLASHcom4()
	{
		string_14 = COM4.Text;
		string_14 = string_14.Replace("C", "").Replace("O", "").Replace("M", "");
		string_13 = "\"" + name_flash.Text + "\"";
		LGPythoncom4();
	}

	public void LGPythoncom4()
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			UseShellExecute = false,
			CreateNoWindow = true,
			FileName = "\"C:\\Windows\\DUT\\TF\\12345.exe\" " + string_14 + " \"C:\\Windows\\DUT\\TF\\LGUP_CommonOLD.dll\" ",
			Arguments = string_13,
			RedirectStandardInput = true,
			RedirectStandardOutput = true
		};
		process.Start();
		Console.WriteLine(string_13);
		process.StandardInput.WriteLine(string_13);
		process.StandardInput.Flush();
		process.StandardInput.Close();
		process.OutputDataReceived += lgflashcheckcom4;
		process.BeginOutputReadLine();
		process.Dispose();
	}

	private void lgflashcheckcom4(object sender, DataReceivedEventArgs e)
	{
		try
		{
			string obj = e.Data ?? string.Empty;
			if (obj.Contains("0x5002, USB Write packet failed"))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
				Form1.SharedUI.RichTextBox1.AppendText("Failed Via ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(COM4.Text);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Check The Cable, And Try Again");
			}
			if (obj.Contains("Download Error"))
			{
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
				Form1.SharedUI.RichTextBox1.AppendText("Failed Via ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(COM4.Text);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Check The Dll, And Try Again");
			}
			if (obj.Contains("Progress Percent: 11"))
			{
				COM4ProgressBar1.Value = 0;
				COM4ProgressBar1.Text = "Analyzeing..";
			}
			if (obj.Contains("Progress Percent: 12"))
			{
				COM4ProgressBar1.Value = 0;
				chengbar = "10";
				Delay(0.3);
				COM4ProgressBar1.Value = 0;
				chengbar = "10";
				Delay(0.2);
				COM4ProgressBar1.Value = 0;
				chengbar = "10";
				Delay(0.2);
				COM4ProgressBar1.Value = 0;
				chengbar = "10";
				Delay(0.2);
				COM4ProgressBar1.Value = 0;
				chengbar = "10";
				Delay(0.2);
				COM4ProgressBar1.Value = 0;
				chengbar = "10";
				Delay(0.2);
				COM4ProgressBar1.Value = 0;
				chengbar = "12";
			}
			if (obj.Contains("Progress Percent: 14"))
			{
				COM4ProgressBar1.Value = 0;
				chengbar = "12";
			}
			if (obj.Contains("Progress Percent: 15"))
			{
				COM4ProgressBar1.Value = 0;
				chengbar = "10";
				Delay(0.5);
				COM4ProgressBar1.Value = 0;
				chengbar = "10";
				Delay(0.5);
				COM4ProgressBar1.Value = 0;
				chengbar = "10";
				Delay(0.5);
			}
			if (obj.Contains("Progress Percent: 16"))
			{
				COM4ProgressBar1.Value = 0;
				chengbar = "12";
			}
			if (obj.Contains("Progress Percent: 18"))
			{
				COM4ProgressBar1.Value = 0;
				chengbar = "10";
				Delay(0.5);
				COM4ProgressBar1.Value = 0;
				chengbar = "12";
			}
			if (obj.Contains("Progress Percent: 20"))
			{
				COM4ProgressBar1.Value = 0;
				chengbar = "12";
			}
			if (obj.Contains("Progress Percent: 22"))
			{
				COM4ProgressBar1.Value = 0;
				chengbar = "12";
			}
			if (obj.Contains("Progress Percent: 24"))
			{
				COM4ProgressBar1.Value = 0;
				chengbar = "11";
			}
			if (obj.Contains("Progress Percent: 25"))
			{
				COM4ProgressBar1.Value = 0;
				chengbar = "12";
			}
			if (obj.Contains("Progress Percent: 27"))
			{
				COM4ProgressBar1.Value = 0;
				chengbar = "11";
			}
			if (obj.Contains("Progress Percent: 28"))
			{
				COM4ProgressBar1.Value = 0;
				chengbar = "11";
			}
			if (obj.Contains("Progress Percent: 29"))
			{
				COM4ProgressBar1.Value = 0;
				chengbar = "";
				COM4ProgressBar1.Value = 1;
				COM4ProgressBar1.Text = "1%";
			}
			if (obj.Contains("Progress Percent: 30"))
			{
				COM4ProgressBar1.Value = 2;
				COM4ProgressBar1.Text = "2%";
			}
			if (obj.Contains("Progress Percent: 31"))
			{
				COM4ProgressBar1.Value = 4;
				COM4ProgressBar1.Text = "4%";
			}
			if (obj.Contains("Progress Percent: 32"))
			{
				COM4ProgressBar1.Value = 6;
				COM4ProgressBar1.Text = "6%";
			}
			if (obj.Contains("Progress Percent: 33"))
			{
				COM4ProgressBar1.Value = 9;
				COM4ProgressBar1.Text = "9%";
			}
			if (obj.Contains("Progress Percent: 34"))
			{
				COM4ProgressBar1.Value = 13;
				COM4ProgressBar1.Text = "13%";
			}
			if (obj.Contains("Progress Percent: 35"))
			{
				COM4ProgressBar1.Value = 16;
				COM4ProgressBar1.Text = "16%";
			}
			if (obj.Contains("Progress Percent: 36"))
			{
				COM4ProgressBar1.Value = 19;
				COM4ProgressBar1.Text = "19%";
			}
			if (obj.Contains("Progress Percent: 37"))
			{
				COM4ProgressBar1.Value = 22;
				COM4ProgressBar1.Text = "22%";
			}
			if (obj.Contains("Progress Percent: 38"))
			{
				COM4ProgressBar1.Value = 25;
				COM4ProgressBar1.Text = "25%";
			}
			if (obj.Contains("Progress Percent: 39"))
			{
				COM4ProgressBar1.Value = 28;
				COM4ProgressBar1.Text = "28%";
			}
			if (obj.Contains("Progress Percent: 40"))
			{
				COM4ProgressBar1.Value = 31;
				COM4ProgressBar1.Text = "31%";
			}
			if (obj.Contains("Progress Percent: 45"))
			{
				COM4ProgressBar1.Value = 34;
				COM4ProgressBar1.Text = "34%";
			}
			if (obj.Contains("Progress Percent: 46"))
			{
				COM4ProgressBar1.Value = 37;
				COM4ProgressBar1.Text = "37%";
			}
			if (obj.Contains("Progress Percent: 47"))
			{
				COM4ProgressBar1.Value = 40;
				COM4ProgressBar1.Text = "40%";
			}
			if (obj.Contains("Progress Percent: 48"))
			{
				COM4ProgressBar1.Value = 42;
				COM4ProgressBar1.Text = "42%";
			}
			if (obj.Contains("Progress Percent: 49"))
			{
				COM4ProgressBar1.Value = 44;
				COM4ProgressBar1.Text = "44%";
			}
			if (obj.Contains("Progress Percent: 50"))
			{
				COM4ProgressBar1.Value = 46;
				COM4ProgressBar1.Text = "46%";
			}
			if (obj.Contains("Progress Percent: 51"))
			{
				COM4ProgressBar1.Value = 48;
				COM4ProgressBar1.Text = "48%";
			}
			if (obj.Contains("Progress Percent: 52"))
			{
				COM4ProgressBar1.Value = 50;
				COM4ProgressBar1.Text = "50%";
			}
			if (obj.Contains("Progress Percent: 53"))
			{
				COM4ProgressBar1.Value = 51;
				COM4ProgressBar1.Text = "51%";
			}
			if (obj.Contains("Progress Percent: 54"))
			{
				COM4ProgressBar1.Value = 52;
				COM4ProgressBar1.Text = "52%";
			}
			if (obj.Contains("Progress Percent: 55"))
			{
				COM4ProgressBar1.Value = 53;
				COM4ProgressBar1.Text = "53%";
			}
			if (obj.Contains("Progress Percent: 56"))
			{
				COM4ProgressBar1.Value = 54;
				COM4ProgressBar1.Text = "54%";
			}
			if (obj.Contains("Progress Percent: 57"))
			{
				COM4ProgressBar1.Value = 55;
				COM4ProgressBar1.Text = "55%";
			}
			if (obj.Contains("Progress Percent: 58"))
			{
				COM4ProgressBar1.Value = 57;
				COM4ProgressBar1.Text = "57%";
			}
			if (obj.Contains("Progress Percent: 59"))
			{
				COM4ProgressBar1.Value = 59;
				COM4ProgressBar1.Text = "59%";
			}
			if (obj.Contains("Progress Percent: 60"))
			{
				COM4ProgressBar1.Value = 62;
				COM4ProgressBar1.Text = "62%";
			}
			if (obj.Contains("Progress Percent: 61"))
			{
				COM4ProgressBar1.Value = 63;
				COM4ProgressBar1.Text = "63%";
			}
			if (obj.Contains("Progress Percent: 62"))
			{
				COM4ProgressBar1.Value = 66;
				COM4ProgressBar1.Text = "66%";
			}
			if (obj.Contains("Progress Percent: 65"))
			{
				COM4ProgressBar1.Value = 69;
				COM4ProgressBar1.Text = "69%";
			}
			if (obj.Contains("Progress Percent: 68"))
			{
				COM4ProgressBar1.Value = 73;
				COM4ProgressBar1.Text = "73%";
			}
			if (obj.Contains("Progress Percent: 70"))
			{
				COM4ProgressBar1.Value = 77;
				COM4ProgressBar1.Text = "77%";
			}
			if (obj.Contains("Progress Percent: 73"))
			{
				COM4ProgressBar1.Value = 80;
				COM4ProgressBar1.Text = "80%";
			}
			if (obj.Contains("Progress Percent: 75"))
			{
				COM4ProgressBar1.Value = 84;
				COM4ProgressBar1.Text = "84%";
			}
			if (obj.Contains("Progress Percent: 78"))
			{
				COM4ProgressBar1.Value = 88;
				COM4ProgressBar1.Text = "88%";
			}
			if (obj.Contains("Progress Percent: 79"))
			{
				COM4ProgressBar1.Value = 95;
				COM4ProgressBar1.Text = "95%";
				Delay(2.5);
				Delay(1.5);
				COM4ProgressBar1.Value = 99;
				COM4ProgressBar1.Text = "99%";
				Delay(1.0);
				COM4.Text = "";
				COM4ProgressBar1.Value = 0;
				COM4ProgressBar1.Text = "Flash Done!";
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception projectError = ex;
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
	}

	private void method_CheckFirmwere()
	{
		RichTextBox3.Clear();
		if (Operators.CompareString(BL.Text, "", TextCompare: false) == 0 && Operators.CompareString(AP.Text, "", TextCompare: false) == 0 && Operators.CompareString(CP.Text, "", TextCompare: false) == 0 && Operators.CompareString(CSC.Text, "", TextCompare: false) == 0)
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Check The Files Firmwere, And Try Again");
			return;
		}
		if (Operators.CompareString(BL.Text, "", TextCompare: false) == 0)
		{
			if (Operators.CompareString(AP.Text, "", TextCompare: false) == 0)
			{
				if (Operators.CompareString(CP.Text, "", TextCompare: false) == 0)
				{
					if (Operators.CompareString(CSC.Text, "", TextCompare: false) != 0)
					{
						RichTextBox3.AppendText(Environment.NewLine + "CSC");
					}
				}
				else
				{
					RichTextBox3.AppendText(Environment.NewLine + "CP");
					if (Operators.CompareString(CSC.Text, "", TextCompare: false) != 0)
					{
						RichTextBox3.AppendText(Environment.NewLine + "CSC");
					}
				}
			}
			else
			{
				RichTextBox3.AppendText(Environment.NewLine + "AP");
				if (Operators.CompareString(CP.Text, "", TextCompare: false) != 0)
				{
					RichTextBox3.AppendText(Environment.NewLine + "CP");
					if (Operators.CompareString(CSC.Text, "", TextCompare: false) != 0)
					{
						RichTextBox3.AppendText(Environment.NewLine + "CSC");
					}
				}
			}
		}
		else
		{
			RichTextBox3.AppendText(Environment.NewLine + "BL");
			if (Operators.CompareString(AP.Text, "", TextCompare: false) != 0)
			{
				RichTextBox3.AppendText(Environment.NewLine + "AP");
				if (Operators.CompareString(CP.Text, "", TextCompare: false) != 0)
				{
					RichTextBox3.AppendText(Environment.NewLine + "CP");
					if (Operators.CompareString(CSC.Text, "", TextCompare: false) != 0)
					{
						RichTextBox3.AppendText(Environment.NewLine + "CSC");
					}
				}
			}
		}
		if (RichTextBox3.Text.Contains("BL") && RichTextBox3.Text.Contains("AP") && RichTextBox3.Text.Contains("CP") && RichTextBox3.Text.Contains("CSC"))
		{
			string_13 = "C:\\Windows\\DUT\\TF\\678910.exe -b \"" + BL.Text + "\" -a \"" + AP.Text + "\" -c \"" + CP.Text + "\" -s \"" + CSC.Text + "\" -d " + string_14;
		}
		else if (RichTextBox3.Text.Contains("BL") && RichTextBox3.Text.Contains("AP") && RichTextBox3.Text.Contains("CP"))
		{
			string_13 = "C:\\Windows\\DUT\\TF\\678910.exe -b \"" + BL.Text + "\" -a \"" + AP.Text + "\" -c \"" + CP.Text + "\" -d " + string_14;
		}
		else if (RichTextBox3.Text.Contains("BL") && RichTextBox3.Text.Contains("AP"))
		{
			string_13 = "C:\\Windows\\DUT\\TF\\678910.exe -b \"" + BL.Text + "\" -a \"" + AP.Text + "\" -d " + string_14;
		}
		else if (RichTextBox3.Text.Contains("BL"))
		{
			string_13 = "C:\\Windows\\DUT\\TF\\678910.exe -b \"" + BL.Text + "\" -d " + string_14;
		}
		else if (RichTextBox3.Text.Contains("AP") && RichTextBox3.Text.Contains("CP") && RichTextBox3.Text.Contains("CSC"))
		{
			string_13 = "C:\\Windows\\DUT\\TF\\678910.exe -a \"" + AP.Text + "\" -c \"" + CP.Text + "\" -s \"" + CSC.Text + "\" -d " + string_14;
		}
		else if (RichTextBox3.Text.Contains("AP") && RichTextBox3.Text.Contains("CP"))
		{
			string_13 = "C:\\Windows\\DUT\\TF\\678910.exe -a \"" + AP.Text + "\" -c \"" + CP.Text + "\" -d " + string_14;
		}
		else if (RichTextBox3.Text.Contains("AP"))
		{
			string_13 = "C:\\Windows\\DUT\\TF\\678910.exe -a \"" + AP.Text + "\" -d " + string_14;
		}
		else if (RichTextBox3.Text.Contains("CP") && RichTextBox3.Text.Contains("CSC"))
		{
			string_13 = "C:\\Windows\\DUT\\TF\\678910.exe -c \"" + CP.Text + "\" -s \"" + CSC.Text + "\" -d " + string_14;
		}
		else if (RichTextBox3.Text.Contains("CP"))
		{
			string_13 = "C:\\Windows\\DUT\\TF\\678910.exe -c \"" + CP.Text + "\" -d " + string_14;
		}
		else if (RichTextBox3.Text.Contains("CSC"))
		{
			string_13 = "C:\\Windows\\DUT\\TF\\678910.exe -s \"" + CSC.Text + "\" -d " + string_14;
		}
	}

	private void method_flashsamsung()
	{
		TextBox4.Text = Conversions.ToString(Port_Name.Items.Count);
		if (Operators.CompareString(TextBox4.Text, "1", TextCompare: false) == 0)
		{
			TextBox7.Text = "(1 Devices)";
			method_flashsamsungcom1();
		}
		if (Operators.CompareString(TextBox4.Text, "2", TextCompare: false) == 0)
		{
			TextBox7.Text = "(2 Devices)";
			method_flashsamsungcom1();
			method_flashsamsungcom2();
		}
		if (Operators.CompareString(TextBox4.Text, "3", TextCompare: false) == 0)
		{
			TextBox7.Text = "(3 Devices)";
			method_flashsamsungcom1();
			method_flashsamsungcom2();
			method_flashsamsungcom3();
		}
		if (Operators.CompareString(TextBox4.Text, "4", TextCompare: false) == 0)
		{
			TextBox7.Text = "(4 Devices)";
			method_flashsamsungcom1();
			method_flashsamsungcom2();
			method_flashsamsungcom3();
			method_flashsamsungcom4();
		}
	}

	public void method_flashsamsungcom1()
	{
		ProgressBarCOM1S.ProgressColor = Color.FromArgb(0, 85, 207);
		ProgressBarCOM1S.ProgressColor2 = Color.FromArgb(0, 85, 207);
		ProgressBarCOM1S.Text = "Check Files..";
		ProgressBarCOM1S.Value = 0;
		string_14 = SamsungCOM1.Text;
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Check The Files :");
		ProgressBarCOM1S.Text = "";
		ProgressBarCOM1S.Value = 0;
		ProgressBarCOM2S.Text = "";
		ProgressBarCOM2S.Value = 0;
		ProgressBarCOM3S.Text = "";
		ProgressBarCOM3S.Value = 0;
		ProgressBarCOM4S.Text = "";
		ProgressBarCOM4S.Value = 0;
		method_CheckFirmwere();
		string_15 = string_13;
		PythonOdinCOM1();
	}

	public void method_flashsamsungcom2()
	{
		ProgressBarCOM2S.ProgressColor = Color.FromArgb(0, 85, 207);
		ProgressBarCOM2S.ProgressColor2 = Color.FromArgb(0, 85, 207);
		ProgressBarCOM2S.Text = "Check Files..";
		ProgressBarCOM2S.Value = 0;
		string_14 = SamsungCOM2.Text;
		method_CheckFirmwere();
		string_15 = string_13;
		PythonOdinCOM2();
	}

	public void method_flashsamsungcom3()
	{
		ProgressBarCOM3S.ProgressColor = Color.FromArgb(0, 85, 207);
		ProgressBarCOM3S.ProgressColor2 = Color.FromArgb(0, 85, 207);
		ProgressBarCOM1S.Text = "Check Files..";
		ProgressBarCOM3S.Value = 0;
		string_14 = SamsungCOM3.Text;
		method_CheckFirmwere();
		string_15 = string_13;
		PythonOdinCOM3();
	}

	public void method_flashsamsungcom4()
	{
		ProgressBarCOM4S.ProgressColor = Color.FromArgb(0, 85, 207);
		ProgressBarCOM4S.ProgressColor2 = Color.FromArgb(0, 85, 207);
		ProgressBarCOM1S.Text = "Check Files..";
		ProgressBarCOM4S.Value = 0;
		string_14 = SamsungCOM4.Text;
		method_CheckFirmwere();
		string_15 = string_13;
		PythonOdinCOM4();
	}

	public void PythonOdinCOM1()
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			UseShellExecute = false,
			CreateNoWindow = true,
			FileName = Form1.String_9 + "bin\\Tunlocker Tool.exe",
			Arguments = string_15,
			RedirectStandardInput = true,
			RedirectStandardOutput = true
		};
		process.Start();
		Console.WriteLine(string_13);
		process.StandardInput.WriteLine(string_13);
		process.StandardInput.Flush();
		process.StandardInput.Close();
		process.OutputDataReceived += PythonOdinDataCom1;
		process.BeginOutputReadLine();
	}

	public void PythonOdinCOM2()
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			UseShellExecute = false,
			CreateNoWindow = true,
			FileName = Form1.String_9 + "bin\\Tunlocker Tool.exe",
			Arguments = string_15,
			RedirectStandardInput = true,
			RedirectStandardOutput = true
		};
		process.Start();
		Console.WriteLine(string_13);
		process.StandardInput.WriteLine(string_13);
		process.StandardInput.Flush();
		process.StandardInput.Close();
		process.OutputDataReceived += PythonOdinDataCom2;
		process.BeginOutputReadLine();
	}

	public void PythonOdinCOM3()
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			UseShellExecute = false,
			CreateNoWindow = true,
			FileName = Form1.String_9 + "bin\\Tunlocker Tool.exe",
			Arguments = string_15,
			RedirectStandardInput = true,
			RedirectStandardOutput = true
		};
		process.Start();
		Console.WriteLine(string_13);
		process.StandardInput.WriteLine(string_13);
		process.StandardInput.Flush();
		process.StandardInput.Close();
		process.OutputDataReceived += PythonOdinDataCom3;
		process.BeginOutputReadLine();
	}

	public void PythonOdinCOM4()
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			UseShellExecute = false,
			CreateNoWindow = true,
			FileName = Form1.String_9 + "bin\\Tunlocker Tool.exe",
			Arguments = string_15,
			RedirectStandardInput = true,
			RedirectStandardOutput = true
		};
		process.Start();
		Console.WriteLine(string_13);
		process.StandardInput.WriteLine(string_13);
		process.StandardInput.Flush();
		process.StandardInput.Close();
		process.OutputDataReceived += PythonOdinDataCom4;
		process.BeginOutputReadLine();
	}

	private void PythonOdinDataCom1(object sender, DataReceivedEventArgs e)
	{
		try
		{
			string obj = e.Data ?? string.Empty;
			if (obj.Contains("Check file :"))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText(" OK");
				ProgressBarCOM1S.Text = "Check Files..";
			}
			if (obj.Contains("Setup Connection"))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Connected Devices : ");
				Form1.SharedUI.RichTextBox1.Update();
			}
			if (obj.Contains("Fail parse"))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
				Form1.SharedUI.RichTextBox1.AppendText("Fail");
				Form1.SharedUI.RichTextBox1.Update();
				ProgressBarCOM1S.Value = 100;
				ProgressBarCOM1S.ProgressColor = Color.Red;
				ProgressBarCOM1S.ProgressColor2 = Color.Red;
				ProgressChanged = Conversions.ToString(ProgressBarCOM1S.Value);
				ProgressBarCOM1S.Text = "FAIL!";
			}
			if (obj.Contains("%)"))
			{
				ProgressBarCOM1S.Increment(1);
				ProgressChanged = Conversions.ToString(ProgressBarCOM1S.Value);
				ProgressBarCOM1S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("(69%)"))
			{
				ProgressBarCOM1S.Value = 69;
				ProgressBarCOM1S.Text = "69%";
			}
			if (obj.Contains("100%)"))
			{
				ProgressBarCOM1S.Value = 100;
				ProgressBarCOM1S.Text = "100%";
			}
			if (obj.Contains("initializeConnection"))
			{
				ProgressBarCOM1S.Value = 100;
				ProgressBarCOM1S.Value = 10;
				ProgressBarCOM1S.Value = 40;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("OK");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Read PIT Map ");
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.LightGreen;
				Form1.SharedUI.RichTextBox1.AppendText(TextBox7.Text);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(" : ");
				ProgressBarCOM1S.Value = 75;
				ProgressChanged = Conversions.ToString(ProgressBarCOM1S.Value);
				ProgressBarCOM1S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("FAIL! SHA256 is invalid"))
			{
				ProgressBarCOM1S.Value = 100;
				ProgressBarCOM1S.ProgressColor = Color.Red;
				ProgressBarCOM1S.ProgressColor2 = Color.Red;
				ProgressChanged = Conversions.ToString(ProgressBarCOM1S.Value);
				ProgressBarCOM1S.Text = "FAIL!";
			}
			if (obj.Contains("Fail Initialize Connection"))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
				Form1.SharedUI.RichTextBox1.AppendText("Fail");
				Form1.SharedUI.RichTextBox1.Update();
				ProgressBarCOM1S.Value = 100;
				ProgressBarCOM1S.ProgressColor = Color.Red;
				ProgressBarCOM1S.ProgressColor2 = Color.Red;
				ProgressChanged = Conversions.ToString(ProgressBarCOM1S.Value);
				ProgressBarCOM1S.Text = "FAIL!";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Fail Initialize Connection!");
				Form1.SharedUI.RichTextBox1.Update();
			}
			if (obj.Contains("success getpit"))
			{
				ProgressBarCOM1S.Value = 100;
				ProgressBarCOM1S.Value = 10;
				ProgressBarCOM1S.Value = 40;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("OK");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Write PIT Map To Device ");
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.LightGreen;
				Form1.SharedUI.RichTextBox1.AppendText(TextBox7.Text);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(" : ");
				ProgressBarCOM1S.Value = 30;
				ProgressChanged = Conversions.ToString(ProgressBarCOM1S.Value);
				ProgressBarCOM1S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("sboot"))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("OK");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Flashing sboot.bin ");
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.LightGreen;
				Form1.SharedUI.RichTextBox1.AppendText(TextBox7.Text);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(" : ");
				ProgressBarCOM1S.Value = 100;
				ProgressBarCOM1S.Value = 10;
				ProgressBarCOM1S.Value = 40;
				ProgressChanged = Conversions.ToString(ProgressBarCOM1S.Value);
				ProgressBarCOM1S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("param"))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("OK");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Flashing param.bin ");
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.LightGreen;
				Form1.SharedUI.RichTextBox1.AppendText(TextBox7.Text);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(" : ");
				ProgressBarCOM1S.Value = 100;
				ProgressBarCOM1S.Value = 10;
				ProgressBarCOM1S.Value = 40;
				ProgressBarCOM1S.Value = 96;
				ProgressChanged = Conversions.ToString(ProgressBarCOM1S.Value);
				ProgressBarCOM1S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("cm.bin"))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("OK");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Flashing cm.bin ");
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.LightGreen;
				Form1.SharedUI.RichTextBox1.AppendText(TextBox7.Text);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(" : ");
				ProgressBarCOM1S.Value = 100;
				ProgressBarCOM1S.Value = 10;
				ProgressBarCOM1S.Value = 40;
				ProgressBarCOM1S.Value = 80;
				ProgressChanged = Conversions.ToString(ProgressBarCOM1S.Value);
				ProgressBarCOM1S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("vbmeta."))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("OK");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Flashing vbmeta.img ");
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.LightGreen;
				Form1.SharedUI.RichTextBox1.AppendText(TextBox7.Text);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(" : ");
				ProgressBarCOM1S.Value = 100;
				ProgressBarCOM1S.Value = 10;
				ProgressBarCOM1S.Value = 40;
				ProgressBarCOM1S.Value = 67;
				ProgressChanged = Conversions.ToString(ProgressBarCOM1S.Value);
				ProgressBarCOM1S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("dtbo."))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("OK");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Flashing dtbo.img.lz4 ");
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.LightGreen;
				Form1.SharedUI.RichTextBox1.AppendText(TextBox7.Text);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(" : ");
			}
			if (obj.Contains("system."))
			{
				ProgressBarCOM1S.Value = 2;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("OK");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Flashing system.img ");
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.LightGreen;
				Form1.SharedUI.RichTextBox1.AppendText(TextBox7.Text);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(" : ");
			}
			if (obj.Contains("carrier."))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("OK");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Flashing carrier.img ");
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.LightGreen;
				Form1.SharedUI.RichTextBox1.AppendText(TextBox7.Text);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(" : ");
			}
			if (obj.Contains("product."))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("OK");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Flashing product.img ");
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.LightGreen;
				Form1.SharedUI.RichTextBox1.AppendText(TextBox7.Text);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(" : ");
			}
			if (obj.Contains("emmc_appsboot."))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("OK");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Flashing emmc_appsboot.mbn ");
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.LightGreen;
				Form1.SharedUI.RichTextBox1.AppendText(TextBox7.Text);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(" : ");
				ProgressBarCOM1S.Value = 100;
				ProgressBarCOM1S.Value = 10;
				ProgressBarCOM1S.Value = 40;
				ProgressBarCOM1S.Value = 96;
				ProgressChanged = Conversions.ToString(ProgressBarCOM1S.Value);
				ProgressBarCOM1S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("lksecapp."))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("OK");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Flashing lksecapp.mbn ");
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.LightGreen;
				Form1.SharedUI.RichTextBox1.AppendText(TextBox7.Text);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(" : ");
				ProgressBarCOM1S.Value = 100;
				ProgressBarCOM1S.Value = 10;
				ProgressBarCOM1S.Value = 30;
				ProgressChanged = Conversions.ToString(ProgressBarCOM1S.Value);
				ProgressBarCOM1S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("xbl."))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("OK");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Flashing xbl.elf ");
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.LightGreen;
				Form1.SharedUI.RichTextBox1.AppendText(TextBox7.Text);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(" : ");
				ProgressBarCOM1S.Value = 100;
				ProgressBarCOM1S.Value = 10;
				ProgressBarCOM1S.Value = 45;
				ProgressChanged = Conversions.ToString(ProgressBarCOM1S.Value);
				ProgressBarCOM1S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("tz."))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("OK");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Flashing tz.mbn ");
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.LightGreen;
				Form1.SharedUI.RichTextBox1.AppendText(TextBox7.Text);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(" : ");
				ProgressBarCOM1S.Value = 100;
				ProgressBarCOM1S.Value = 10;
				ProgressBarCOM1S.Value = 65;
				ProgressChanged = Conversions.ToString(ProgressBarCOM1S.Value);
				ProgressBarCOM1S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("hyp."))
			{
				ProgressBarCOM1S.Value = 100;
				ProgressBarCOM1S.Value = 10;
				ProgressBarCOM1S.Value = 40;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("OK");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Flashing hyp.mbn ");
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.LightGreen;
				Form1.SharedUI.RichTextBox1.AppendText(TextBox7.Text);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(" : ");
				ProgressBarCOM1S.Value = 95;
				ProgressChanged = Conversions.ToString(ProgressBarCOM1S.Value);
				ProgressBarCOM1S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("devcfg."))
			{
				ProgressBarCOM1S.Value = 100;
				ProgressBarCOM1S.Value = 10;
				ProgressBarCOM1S.Value = 40;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("OK");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Flashing devcfg.mbn ");
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.LightGreen;
				Form1.SharedUI.RichTextBox1.AppendText(TextBox7.Text);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(" : ");
				ProgressBarCOM1S.Value = 35;
				ProgressChanged = Conversions.ToString(ProgressBarCOM1S.Value);
				ProgressBarCOM1S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("pmic."))
			{
				ProgressBarCOM1S.Value = 100;
				ProgressBarCOM1S.Value = 10;
				ProgressBarCOM1S.Value = 40;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("OK");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Flashing pmic.elf ");
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.LightGreen;
				Form1.SharedUI.RichTextBox1.AppendText(TextBox7.Text);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(" : ");
				ProgressBarCOM1S.Value = 55;
				ProgressChanged = Conversions.ToString(ProgressBarCOM1S.Value);
				ProgressBarCOM1S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("rpm."))
			{
				ProgressBarCOM1S.Value = 100;
				ProgressBarCOM1S.Value = 10;
				ProgressBarCOM1S.Value = 40;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("OK");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Flashing rpm.mbn ");
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.LightGreen;
				Form1.SharedUI.RichTextBox1.AppendText(TextBox7.Text);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(" : ");
				ProgressBarCOM1S.Value = 65;
				ProgressChanged = Conversions.ToString(ProgressBarCOM1S.Value);
				ProgressBarCOM1S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("cmnlib."))
			{
				ProgressBarCOM1S.Value = 100;
				ProgressBarCOM1S.Value = 10;
				ProgressBarCOM1S.Value = 40;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("OK");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Flashing cmnlib.mbn ");
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.LightGreen;
				Form1.SharedUI.RichTextBox1.AppendText(TextBox7.Text);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(" : ");
				ProgressBarCOM1S.Value = 50;
				ProgressChanged = Conversions.ToString(ProgressBarCOM1S.Value);
				ProgressBarCOM1S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("keymaster."))
			{
				ProgressBarCOM1S.Value = 100;
				ProgressBarCOM1S.Value = 10;
				ProgressBarCOM1S.Value = 40;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("OK");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Flashing keymaster.mbn ");
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.LightGreen;
				Form1.SharedUI.RichTextBox1.AppendText(TextBox7.Text);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(" : ");
				ProgressBarCOM1S.Value = 40;
				ProgressChanged = Conversions.ToString(ProgressBarCOM1S.Value);
				ProgressBarCOM1S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("apdp."))
			{
				ProgressBarCOM1S.Value = 100;
				ProgressBarCOM1S.Value = 10;
				ProgressBarCOM1S.Value = 40;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("OK");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Flashing apdp.mbn ");
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.LightGreen;
				Form1.SharedUI.RichTextBox1.AppendText(TextBox7.Text);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(" : ");
				ProgressBarCOM1S.Value = 66;
				ProgressChanged = Conversions.ToString(ProgressBarCOM1S.Value);
				ProgressBarCOM1S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("msadp."))
			{
				ProgressBarCOM1S.Value = 100;
				ProgressBarCOM1S.Value = 10;
				ProgressBarCOM1S.Value = 40;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("OK");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Flashing msadp.mbn ");
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.LightGreen;
				Form1.SharedUI.RichTextBox1.AppendText(TextBox7.Text);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(" : ");
				ProgressBarCOM1S.Value = 87;
				ProgressChanged = Conversions.ToString(ProgressBarCOM1S.Value);
				ProgressBarCOM1S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("cmnlib64."))
			{
				ProgressBarCOM1S.Value = 100;
				ProgressBarCOM1S.Value = 10;
				ProgressBarCOM1S.Value = 40;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("OK");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Flashing cmnlib64.mbn ");
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.LightGreen;
				Form1.SharedUI.RichTextBox1.AppendText(TextBox7.Text);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(" : ");
				ProgressBarCOM1S.Value = 39;
				ProgressChanged = Conversions.ToString(ProgressBarCOM1S.Value);
				ProgressBarCOM1S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("sec."))
			{
				ProgressBarCOM1S.Value = 100;
				ProgressBarCOM1S.Value = 10;
				ProgressBarCOM1S.Value = 40;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("OK");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Flashing sec.dat.lz4 ");
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.LightGreen;
				Form1.SharedUI.RichTextBox1.AppendText(TextBox7.Text);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(" : ");
				ProgressBarCOM1S.Value = 59;
				ProgressChanged = Conversions.ToString(ProgressBarCOM1S.Value);
				ProgressBarCOM1S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("NON-HLOS."))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("OK");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Flashing NON-HLOS.bin ");
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.LightGreen;
				Form1.SharedUI.RichTextBox1.AppendText(TextBox7.Text);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(" : ");
				ProgressBarCOM1S.Value = 99;
				ProgressChanged = Conversions.ToString(ProgressBarCOM1S.Value);
				ProgressBarCOM1S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("boot.img"))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("OK");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Flashing boot.img ");
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.LightGreen;
				Form1.SharedUI.RichTextBox1.AppendText(TextBox7.Text);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(" : ");
				ProgressBarCOM1S.Value = 0;
				ProgressChanged = Conversions.ToString(ProgressBarCOM1S.Value);
				ProgressBarCOM1S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("recovery."))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("OK");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Flashing recovery.img ");
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.LightGreen;
				Form1.SharedUI.RichTextBox1.AppendText(TextBox7.Text);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(" : ");
			}
			if (obj.Contains("system.img.ext4.lz4"))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("OK");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Flashing system.img.ext4.lz4 ");
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.LightGreen;
				Form1.SharedUI.RichTextBox1.AppendText(TextBox7.Text);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(" : ");
			}
			if (obj.Contains("persist.img.ext4.lz4"))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("OK");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Flashing persist.img.ext4.lz4 ");
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.LightGreen;
				Form1.SharedUI.RichTextBox1.AppendText(TextBox7.Text);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(" : ");
			}
			if (obj.Contains("persist."))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("OK");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Flashing persist.img ");
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.LightGreen;
				Form1.SharedUI.RichTextBox1.AppendText(TextBox7.Text);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(" : ");
			}
			if (Operators.CompareString(obj, "md1img.", TextCompare: false) == 0)
			{
				ProgressBarCOM1S.Value = 100;
				ProgressBarCOM1S.Value = 10;
				ProgressBarCOM1S.Value = 40;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("OK");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Flashing md1img.img ");
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.LightGreen;
				Form1.SharedUI.RichTextBox1.AppendText(TextBox7.Text);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(" : ");
				ProgressBarCOM1S.Value = 79;
				ProgressChanged = Conversions.ToString(ProgressBarCOM1S.Value);
				ProgressBarCOM1S.Text = ProgressChanged + "%";
			}
			if (Operators.CompareString(obj, "modem.bin.lz4", TextCompare: false) == 0)
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("OK");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Flashing modem.bin ");
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.LightGreen;
				Form1.SharedUI.RichTextBox1.AppendText(TextBox7.Text);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(" : ");
			}
			if (Operators.CompareString(obj, "modem.", TextCompare: false) == 0)
			{
				ProgressBarCOM1S.Value = 100;
				ProgressBarCOM1S.Value = 10;
				ProgressBarCOM1S.Value = 40;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("OK");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Flashing modem.bin ");
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.LightGreen;
				Form1.SharedUI.RichTextBox1.AppendText(TextBox7.Text);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(" : ");
				ProgressBarCOM1S.Value = 59;
				ProgressChanged = Conversions.ToString(ProgressBarCOM1S.Value);
				ProgressBarCOM1S.Text = ProgressChanged + "%";
			}
			if (Operators.CompareString(obj, "modem_debug.bin", TextCompare: false) == 0)
			{
				ProgressBarCOM1S.Value = 100;
				ProgressBarCOM1S.Value = 10;
				ProgressBarCOM1S.Value = 40;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("OK");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Flashing modem_debug.bin ");
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.LightGreen;
				Form1.SharedUI.RichTextBox1.AppendText(TextBox7.Text);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(" : ");
				ProgressBarCOM1S.Value = 89;
				ProgressChanged = Conversions.ToString(ProgressBarCOM1S.Value);
				ProgressBarCOM1S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("adspso."))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("OK");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Flashing adspso.bin.lz4 ");
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.LightGreen;
				Form1.SharedUI.RichTextBox1.AppendText(TextBox7.Text);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(" : ");
			}
			if (obj.Contains("cache."))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("OK");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Flashing cache.img.ext4 ");
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.LightGreen;
				Form1.SharedUI.RichTextBox1.AppendText(TextBox7.Text);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(" : ");
			}
			if (obj.Contains("Close"))
			{
				if (!Form1.SharedUI.RichTextBox1.Text.Contains("Fail Initialize Connection!"))
				{
					Form1.SharedUI.RichTextBox1.Update();
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
					Form1.SharedUI.RichTextBox1.AppendText("OK");
					Form1.SharedUI.RichTextBox1.Update();
				}
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Disconnected Device : ");
				Form1.SharedUI.RichTextBox1.Update();
			}
			if (obj.Contains("Close Connection"))
			{
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("OK");
				Form1.SharedUI.RichTextBox1.Update();
				wesreampung_wav();
				ProgressBarCOM1S.Text = "";
				ProgressBarCOM1S.Value = 0;
				Port_Name.Items.Clear();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception projectError = ex;
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
	}

	private void PythonOdinDataCom2(object sender, DataReceivedEventArgs e)
	{
		try
		{
			string obj = e.Data ?? string.Empty;
			if (obj.Contains("Fail parse"))
			{
				ProgressBarCOM2S.Value = 100;
				ProgressBarCOM2S.ProgressColor = Color.Red;
				ProgressBarCOM2S.ProgressColor2 = Color.Red;
				ProgressChanged = Conversions.ToString(ProgressBarCOM2S.Value);
				ProgressBarCOM2S.Text = "FAIL!";
			}
			if (obj.Contains("%)"))
			{
				ProgressBarCOM2S.Increment(1);
				ProgressChanged = Conversions.ToString(ProgressBarCOM2S.Value);
				ProgressBarCOM2S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("100%)"))
			{
				ProgressBarCOM2S.Value = 100;
				ProgressBarCOM2S.Text = "100%";
			}
			if (obj.Contains("FAIL! SHA256 is invalid"))
			{
				ProgressBarCOM2S.Value = 100;
				ProgressBarCOM2S.ProgressColor = Color.Red;
				ProgressBarCOM2S.ProgressColor2 = Color.Red;
				ProgressChanged = Conversions.ToString(ProgressBarCOM2S.Value);
				ProgressBarCOM2S.Text = "FAIL!";
			}
			if (obj.Contains("initializeConnection"))
			{
				ProgressBarCOM2S.Value = 100;
				ProgressBarCOM2S.Value = 10;
				ProgressBarCOM2S.Value = 40;
				ProgressBarCOM2S.Value = 75;
				ProgressChanged = Conversions.ToString(ProgressBarCOM2S.Value);
				ProgressBarCOM2S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("Fail Initialize Connection"))
			{
				ProgressBarCOM2S.Value = 100;
				ProgressBarCOM2S.ProgressColor = Color.Red;
				ProgressBarCOM2S.ProgressColor2 = Color.Red;
				ProgressChanged = Conversions.ToString(ProgressBarCOM2S.Value);
				ProgressBarCOM2S.Text = "FAIL!";
			}
			if (obj.Contains("success getpit"))
			{
				ProgressBarCOM2S.Value = 100;
				ProgressBarCOM2S.Value = 10;
				ProgressBarCOM2S.Value = 40;
				ProgressBarCOM2S.Value = 50;
				ProgressChanged = Conversions.ToString(ProgressBarCOM2S.Value);
				ProgressBarCOM2S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("emmc_appsboot.mbn.lz4"))
			{
				ProgressBarCOM2S.Value = 100;
				ProgressBarCOM2S.Value = 10;
				ProgressBarCOM2S.Value = 40;
				ProgressBarCOM2S.Value = 96;
				ProgressChanged = Conversions.ToString(ProgressBarCOM2S.Value);
				ProgressBarCOM2S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("lksecapp.mbn.lz4"))
			{
				ProgressBarCOM2S.Value = 100;
				ProgressBarCOM2S.Value = 10;
				ProgressBarCOM2S.Value = 30;
				ProgressChanged = Conversions.ToString(ProgressBarCOM2S.Value);
				ProgressBarCOM2S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("xbl.elf.lz4"))
			{
				ProgressBarCOM2S.Value = 100;
				ProgressBarCOM2S.Value = 10;
				ProgressBarCOM2S.Value = 45;
				ProgressChanged = Conversions.ToString(ProgressBarCOM2S.Value);
				ProgressBarCOM2S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("tz.mbn.lz4"))
			{
				ProgressBarCOM2S.Value = 100;
				ProgressBarCOM2S.Value = 10;
				ProgressBarCOM2S.Value = 65;
				ProgressChanged = Conversions.ToString(ProgressBarCOM2S.Value);
				ProgressBarCOM2S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("hyp.mbn.lz4"))
			{
				ProgressBarCOM2S.Value = 100;
				ProgressBarCOM2S.Value = 10;
				ProgressBarCOM2S.Value = 40;
				ProgressBarCOM2S.Value = 95;
				ProgressChanged = Conversions.ToString(ProgressBarCOM2S.Value);
				ProgressBarCOM2S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("devcfg.mbn.lz4"))
			{
				ProgressBarCOM2S.Value = 100;
				ProgressBarCOM2S.Value = 10;
				ProgressBarCOM2S.Value = 40;
				ProgressBarCOM2S.Value = 35;
				ProgressChanged = Conversions.ToString(ProgressBarCOM2S.Value);
				ProgressBarCOM2S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("pmic.elf.lz4"))
			{
				ProgressBarCOM2S.Value = 100;
				ProgressBarCOM2S.Value = 10;
				ProgressBarCOM2S.Value = 40;
				ProgressBarCOM2S.Value = 55;
				ProgressChanged = Conversions.ToString(ProgressBarCOM2S.Value);
				ProgressBarCOM2S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("rpm.mbn.lz4"))
			{
				ProgressBarCOM2S.Value = 100;
				ProgressBarCOM2S.Value = 10;
				ProgressBarCOM2S.Value = 40;
				ProgressBarCOM2S.Value = 65;
				ProgressChanged = Conversions.ToString(ProgressBarCOM2S.Value);
				ProgressBarCOM2S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("cmnlib.mbn.lz4"))
			{
				ProgressBarCOM2S.Value = 100;
				ProgressBarCOM2S.Value = 10;
				ProgressBarCOM2S.Value = 40;
				ProgressBarCOM2S.Value = 50;
				ProgressChanged = Conversions.ToString(ProgressBarCOM2S.Value);
				ProgressBarCOM2S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("keymaster.mbn.lz4"))
			{
				ProgressBarCOM2S.Value = 100;
				ProgressBarCOM2S.Value = 10;
				ProgressBarCOM2S.Value = 40;
				ProgressChanged = Conversions.ToString(ProgressBarCOM2S.Value);
				ProgressBarCOM2S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("apdp.mbn.lz4"))
			{
				ProgressBarCOM2S.Value = 100;
				ProgressBarCOM2S.Value = 10;
				ProgressBarCOM2S.Value = 40;
				ProgressBarCOM2S.Value = 66;
				ProgressChanged = Conversions.ToString(ProgressBarCOM2S.Value);
				ProgressBarCOM2S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("msadp.mbn.lz4"))
			{
				ProgressBarCOM2S.Value = 100;
				ProgressBarCOM2S.Value = 10;
				ProgressBarCOM2S.Value = 40;
				ProgressBarCOM2S.Value = 87;
				ProgressChanged = Conversions.ToString(ProgressBarCOM2S.Value);
				ProgressBarCOM2S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("cmnlib64.mbn.lz4"))
			{
				ProgressBarCOM2S.Value = 100;
				ProgressBarCOM2S.Value = 10;
				ProgressBarCOM2S.Value = 40;
				ProgressBarCOM2S.Value = 39;
				ProgressChanged = Conversions.ToString(ProgressBarCOM2S.Value);
				ProgressBarCOM2S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("sec.dat.lz4"))
			{
				ProgressBarCOM2S.Value = 100;
				ProgressBarCOM2S.Value = 10;
				ProgressBarCOM2S.Value = 40;
				ProgressBarCOM2S.Value = 59;
				ProgressChanged = Conversions.ToString(ProgressBarCOM2S.Value);
				ProgressBarCOM2S.Text = ProgressChanged + "%";
			}
			if (Operators.CompareString(obj, "md1img.img.lz4", TextCompare: false) == 0)
			{
				ProgressBarCOM2S.Value = 100;
				ProgressBarCOM2S.Value = 10;
				ProgressBarCOM2S.Value = 40;
				ProgressBarCOM2S.Value = 79;
				ProgressChanged = Conversions.ToString(ProgressBarCOM2S.Value);
				ProgressBarCOM2S.Text = ProgressChanged + "%";
			}
			if (Operators.CompareString(obj, "modem.bin", TextCompare: false) == 0)
			{
				ProgressBarCOM2S.Value = 100;
				ProgressBarCOM2S.Value = 10;
				ProgressBarCOM2S.Value = 40;
				ProgressBarCOM2S.Value = 59;
				ProgressChanged = Conversions.ToString(ProgressBarCOM2S.Value);
				ProgressBarCOM2S.Text = ProgressChanged + "%";
			}
			if (Operators.CompareString(obj, "modem_debug.bin", TextCompare: false) == 0)
			{
				ProgressBarCOM2S.Value = 100;
				ProgressBarCOM2S.Value = 10;
				ProgressBarCOM2S.Value = 40;
				ProgressBarCOM2S.Value = 89;
				ProgressChanged = Conversions.ToString(ProgressBarCOM2S.Value);
				ProgressBarCOM2S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("NON-HLOS.bin.lz4"))
			{
				ProgressBarCOM2S.Value = 99;
				ProgressChanged = Conversions.ToString(ProgressBarCOM2S.Value);
				ProgressBarCOM2S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("boot.img.lz4"))
			{
				ProgressBarCOM2S.Value = 0;
				ProgressChanged = Conversions.ToString(ProgressBarCOM2S.Value);
				ProgressBarCOM2S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("Close Connection"))
			{
				wesreampung_wav();
				Port_Name.Items.Clear();
				ProgressBarCOM2S.Text = "";
				ProgressBarCOM2S.Value = 0;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception projectError = ex;
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
	}

	private void PythonOdinDataCom3(object sender, DataReceivedEventArgs e)
	{
		try
		{
			string obj = e.Data ?? string.Empty;
			if (obj.Contains("Fail parse"))
			{
				ProgressBarCOM3S.Value = 100;
				ProgressBarCOM3S.ProgressColor = Color.Red;
				ProgressBarCOM3S.ProgressColor2 = Color.Red;
				ProgressChanged = Conversions.ToString(ProgressBarCOM3S.Value);
				ProgressBarCOM3S.Text = "FAIL!";
			}
			if (obj.Contains("%)"))
			{
				ProgressBarCOM3S.Increment(1);
				ProgressChanged = Conversions.ToString(ProgressBarCOM3S.Value);
				ProgressBarCOM3S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("100%)"))
			{
				ProgressBarCOM3S.Value = 100;
				ProgressBarCOM3S.Text = "100%";
			}
			if (obj.Contains("FAIL! SHA256 is invalid"))
			{
				ProgressBarCOM3S.Value = 100;
				ProgressBarCOM3S.ProgressColor = Color.Red;
				ProgressBarCOM3S.ProgressColor2 = Color.Red;
				ProgressChanged = Conversions.ToString(ProgressBarCOM3S.Value);
				ProgressBarCOM3S.Text = "FAIL!";
			}
			if (obj.Contains("initializeConnection"))
			{
				ProgressBarCOM3S.Value = 100;
				ProgressBarCOM3S.Value = 10;
				ProgressBarCOM3S.Value = 40;
				ProgressBarCOM3S.Value = 75;
				ProgressChanged = Conversions.ToString(ProgressBarCOM3S.Value);
				ProgressBarCOM3S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("Fail Initialize Connection"))
			{
				ProgressBarCOM3S.Value = 100;
				ProgressBarCOM3S.ProgressColor = Color.Red;
				ProgressBarCOM3S.ProgressColor2 = Color.Red;
				ProgressChanged = Conversions.ToString(ProgressBarCOM3S.Value);
				ProgressBarCOM3S.Text = "FAIL!";
			}
			if (obj.Contains("success getpit"))
			{
				ProgressBarCOM3S.Value = 100;
				ProgressBarCOM3S.Value = 10;
				ProgressBarCOM3S.Value = 40;
				ProgressBarCOM3S.Value = 50;
				ProgressChanged = Conversions.ToString(ProgressBarCOM3S.Value);
				ProgressBarCOM3S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("emmc_appsboot.mbn.lz4"))
			{
				ProgressBarCOM3S.Value = 100;
				ProgressBarCOM3S.Value = 10;
				ProgressBarCOM3S.Value = 40;
				ProgressBarCOM3S.Value = 96;
				ProgressChanged = Conversions.ToString(ProgressBarCOM3S.Value);
				ProgressBarCOM3S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("lksecapp.mbn.lz4"))
			{
				ProgressBarCOM3S.Value = 100;
				ProgressBarCOM3S.Value = 10;
				ProgressBarCOM3S.Value = 30;
				ProgressChanged = Conversions.ToString(ProgressBarCOM3S.Value);
				ProgressBarCOM3S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("xbl.elf.lz4"))
			{
				ProgressBarCOM3S.Value = 100;
				ProgressBarCOM3S.Value = 10;
				ProgressBarCOM3S.Value = 45;
				ProgressChanged = Conversions.ToString(ProgressBarCOM3S.Value);
				ProgressBarCOM3S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("tz.mbn.lz4"))
			{
				ProgressBarCOM3S.Value = 100;
				ProgressBarCOM3S.Value = 10;
				ProgressBarCOM3S.Value = 65;
				ProgressChanged = Conversions.ToString(ProgressBarCOM3S.Value);
				ProgressBarCOM3S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("hyp.mbn.lz4"))
			{
				ProgressBarCOM3S.Value = 100;
				ProgressBarCOM3S.Value = 10;
				ProgressBarCOM3S.Value = 40;
				ProgressBarCOM3S.Value = 95;
				ProgressChanged = Conversions.ToString(ProgressBarCOM3S.Value);
				ProgressBarCOM3S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("devcfg.mbn.lz4"))
			{
				ProgressBarCOM3S.Value = 100;
				ProgressBarCOM3S.Value = 10;
				ProgressBarCOM3S.Value = 40;
				ProgressBarCOM3S.Value = 35;
				ProgressChanged = Conversions.ToString(ProgressBarCOM3S.Value);
				ProgressBarCOM3S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("pmic.elf.lz4"))
			{
				ProgressBarCOM3S.Value = 100;
				ProgressBarCOM3S.Value = 10;
				ProgressBarCOM3S.Value = 40;
				ProgressBarCOM3S.Value = 55;
				ProgressChanged = Conversions.ToString(ProgressBarCOM3S.Value);
				ProgressBarCOM3S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("rpm.mbn.lz4"))
			{
				ProgressBarCOM3S.Value = 100;
				ProgressBarCOM3S.Value = 10;
				ProgressBarCOM3S.Value = 40;
				ProgressBarCOM3S.Value = 65;
				ProgressChanged = Conversions.ToString(ProgressBarCOM3S.Value);
				ProgressBarCOM3S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("cmnlib.mbn.lz4"))
			{
				ProgressBarCOM3S.Value = 100;
				ProgressBarCOM3S.Value = 10;
				ProgressBarCOM3S.Value = 40;
				ProgressBarCOM3S.Value = 50;
				ProgressChanged = Conversions.ToString(ProgressBarCOM3S.Value);
				ProgressBarCOM3S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("keymaster.mbn.lz4"))
			{
				ProgressBarCOM3S.Value = 100;
				ProgressBarCOM3S.Value = 10;
				ProgressBarCOM3S.Value = 40;
				ProgressChanged = Conversions.ToString(ProgressBarCOM3S.Value);
				ProgressBarCOM3S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("apdp.mbn.lz4"))
			{
				ProgressBarCOM3S.Value = 100;
				ProgressBarCOM3S.Value = 10;
				ProgressBarCOM3S.Value = 40;
				ProgressBarCOM3S.Value = 66;
				ProgressChanged = Conversions.ToString(ProgressBarCOM3S.Value);
				ProgressBarCOM3S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("msadp.mbn.lz4"))
			{
				ProgressBarCOM3S.Value = 100;
				ProgressBarCOM3S.Value = 10;
				ProgressBarCOM3S.Value = 40;
				ProgressBarCOM3S.Value = 87;
				ProgressChanged = Conversions.ToString(ProgressBarCOM3S.Value);
				ProgressBarCOM3S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("cmnlib64.mbn.lz4"))
			{
				ProgressBarCOM3S.Value = 100;
				ProgressBarCOM3S.Value = 10;
				ProgressBarCOM3S.Value = 40;
				ProgressBarCOM3S.Value = 39;
				ProgressChanged = Conversions.ToString(ProgressBarCOM3S.Value);
				ProgressBarCOM3S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("sec.dat.lz4"))
			{
				ProgressBarCOM3S.Value = 100;
				ProgressBarCOM3S.Value = 10;
				ProgressBarCOM3S.Value = 40;
				ProgressBarCOM3S.Value = 59;
				ProgressChanged = Conversions.ToString(ProgressBarCOM3S.Value);
				ProgressBarCOM3S.Text = ProgressChanged + "%";
			}
			if (Operators.CompareString(obj, "md1img.img.lz4", TextCompare: false) == 0)
			{
				ProgressBarCOM3S.Value = 100;
				ProgressBarCOM3S.Value = 10;
				ProgressBarCOM3S.Value = 40;
				ProgressBarCOM3S.Value = 79;
				ProgressChanged = Conversions.ToString(ProgressBarCOM3S.Value);
				ProgressBarCOM3S.Text = ProgressChanged + "%";
			}
			if (Operators.CompareString(obj, "modem.bin", TextCompare: false) == 0)
			{
				ProgressBarCOM3S.Value = 100;
				ProgressBarCOM3S.Value = 10;
				ProgressBarCOM3S.Value = 40;
				ProgressBarCOM3S.Value = 59;
				ProgressChanged = Conversions.ToString(ProgressBarCOM3S.Value);
				ProgressBarCOM3S.Text = ProgressChanged + "%";
			}
			if (Operators.CompareString(obj, "modem_debug.bin", TextCompare: false) == 0)
			{
				ProgressBarCOM3S.Value = 100;
				ProgressBarCOM3S.Value = 10;
				ProgressBarCOM3S.Value = 40;
				ProgressBarCOM3S.Value = 89;
				ProgressChanged = Conversions.ToString(ProgressBarCOM3S.Value);
				ProgressBarCOM3S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("NON-HLOS.bin.lz4"))
			{
				ProgressBarCOM3S.Value = 99;
				ProgressChanged = Conversions.ToString(ProgressBarCOM3S.Value);
				ProgressBarCOM3S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("boot.img.lz4"))
			{
				ProgressBarCOM3S.Value = 0;
				ProgressChanged = Conversions.ToString(ProgressBarCOM3S.Value);
				ProgressBarCOM3S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("Close Connection"))
			{
				wesreampung_wav();
				ProgressBarCOM3S.Text = "";
				ProgressBarCOM3S.Value = 0;
				Port_Name.Items.Clear();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception projectError = ex;
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
	}

	private void PythonOdinDataCom4(object sender, DataReceivedEventArgs e)
	{
		try
		{
			string obj = e.Data ?? string.Empty;
			if (obj.Contains("Fail parse"))
			{
				ProgressBarCOM4S.Value = 100;
				ProgressBarCOM4S.ProgressColor = Color.Red;
				ProgressBarCOM4S.ProgressColor2 = Color.Red;
				ProgressChanged = Conversions.ToString(ProgressBarCOM4S.Value);
				ProgressBarCOM4S.Text = "FAIL!";
			}
			if (obj.Contains("%)"))
			{
				ProgressBarCOM4S.Increment(1);
				ProgressChanged = Conversions.ToString(ProgressBarCOM4S.Value);
				ProgressBarCOM4S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("100%)"))
			{
				ProgressBarCOM4S.Value = 100;
				ProgressBarCOM4S.Text = "100%";
			}
			if (obj.Contains("FAIL! SHA256 is invalid"))
			{
				ProgressBarCOM4S.Value = 100;
				ProgressBarCOM4S.ProgressColor = Color.Red;
				ProgressBarCOM4S.ProgressColor2 = Color.Red;
				ProgressChanged = Conversions.ToString(ProgressBarCOM4S.Value);
				ProgressBarCOM4S.Text = "FAIL!";
			}
			if (obj.Contains("initializeConnection"))
			{
				ProgressBarCOM4S.Value = 100;
				ProgressBarCOM4S.Value = 10;
				ProgressBarCOM4S.Value = 40;
				ProgressBarCOM4S.Value = 75;
				ProgressChanged = Conversions.ToString(ProgressBarCOM4S.Value);
				ProgressBarCOM4S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("Fail Initialize Connection"))
			{
				ProgressBarCOM4S.Value = 100;
				ProgressBarCOM4S.ProgressColor = Color.Red;
				ProgressBarCOM4S.ProgressColor2 = Color.Red;
				ProgressChanged = Conversions.ToString(ProgressBarCOM4S.Value);
				ProgressBarCOM4S.Text = "FAIL!";
			}
			if (obj.Contains("success getpit"))
			{
				ProgressBarCOM4S.Value = 100;
				ProgressBarCOM4S.Value = 10;
				ProgressBarCOM4S.Value = 40;
				ProgressBarCOM4S.Value = 50;
				ProgressChanged = Conversions.ToString(ProgressBarCOM4S.Value);
				ProgressBarCOM4S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("emmc_appsboot.mbn.lz4"))
			{
				ProgressBarCOM4S.Value = 100;
				ProgressBarCOM4S.Value = 10;
				ProgressBarCOM4S.Value = 40;
				ProgressBarCOM4S.Value = 96;
				ProgressChanged = Conversions.ToString(ProgressBarCOM4S.Value);
				ProgressBarCOM4S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("lksecapp.mbn.lz4"))
			{
				ProgressBarCOM4S.Value = 100;
				ProgressBarCOM4S.Value = 10;
				ProgressBarCOM4S.Value = 30;
				ProgressChanged = Conversions.ToString(ProgressBarCOM4S.Value);
				ProgressBarCOM4S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("xbl.elf.lz4"))
			{
				ProgressBarCOM4S.Value = 100;
				ProgressBarCOM4S.Value = 10;
				ProgressBarCOM4S.Value = 45;
				ProgressChanged = Conversions.ToString(ProgressBarCOM4S.Value);
				ProgressBarCOM4S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("tz.mbn.lz4"))
			{
				ProgressBarCOM4S.Value = 100;
				ProgressBarCOM4S.Value = 10;
				ProgressBarCOM4S.Value = 65;
				ProgressChanged = Conversions.ToString(ProgressBarCOM4S.Value);
				ProgressBarCOM4S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("hyp.mbn.lz4"))
			{
				ProgressBarCOM4S.Value = 100;
				ProgressBarCOM4S.Value = 10;
				ProgressBarCOM4S.Value = 40;
				ProgressBarCOM4S.Value = 95;
				ProgressChanged = Conversions.ToString(ProgressBarCOM4S.Value);
				ProgressBarCOM4S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("devcfg.mbn.lz4"))
			{
				ProgressBarCOM4S.Value = 100;
				ProgressBarCOM4S.Value = 10;
				ProgressBarCOM4S.Value = 40;
				ProgressBarCOM4S.Value = 35;
				ProgressChanged = Conversions.ToString(ProgressBarCOM4S.Value);
				ProgressBarCOM4S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("pmic.elf.lz4"))
			{
				ProgressBarCOM4S.Value = 100;
				ProgressBarCOM4S.Value = 10;
				ProgressBarCOM4S.Value = 40;
				ProgressBarCOM4S.Value = 55;
				ProgressChanged = Conversions.ToString(ProgressBarCOM4S.Value);
				ProgressBarCOM4S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("rpm.mbn.lz4"))
			{
				ProgressBarCOM4S.Value = 100;
				ProgressBarCOM4S.Value = 10;
				ProgressBarCOM4S.Value = 40;
				ProgressBarCOM4S.Value = 65;
				ProgressChanged = Conversions.ToString(ProgressBarCOM4S.Value);
				ProgressBarCOM4S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("cmnlib.mbn.lz4"))
			{
				ProgressBarCOM4S.Value = 100;
				ProgressBarCOM4S.Value = 10;
				ProgressBarCOM4S.Value = 40;
				ProgressBarCOM4S.Value = 50;
				ProgressChanged = Conversions.ToString(ProgressBarCOM4S.Value);
				ProgressBarCOM4S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("keymaster.mbn.lz4"))
			{
				ProgressBarCOM4S.Value = 100;
				ProgressBarCOM4S.Value = 10;
				ProgressBarCOM4S.Value = 40;
				ProgressChanged = Conversions.ToString(ProgressBarCOM4S.Value);
				ProgressBarCOM4S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("apdp.mbn.lz4"))
			{
				ProgressBarCOM4S.Value = 100;
				ProgressBarCOM4S.Value = 10;
				ProgressBarCOM4S.Value = 40;
				ProgressBarCOM4S.Value = 66;
				ProgressChanged = Conversions.ToString(ProgressBarCOM4S.Value);
				ProgressBarCOM4S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("msadp.mbn.lz4"))
			{
				ProgressBarCOM4S.Value = 100;
				ProgressBarCOM4S.Value = 10;
				ProgressBarCOM4S.Value = 40;
				ProgressBarCOM4S.Value = 87;
				ProgressChanged = Conversions.ToString(ProgressBarCOM4S.Value);
				ProgressBarCOM4S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("cmnlib64.mbn.lz4"))
			{
				ProgressBarCOM4S.Value = 100;
				ProgressBarCOM4S.Value = 10;
				ProgressBarCOM4S.Value = 40;
				ProgressBarCOM4S.Value = 39;
				ProgressChanged = Conversions.ToString(ProgressBarCOM4S.Value);
				ProgressBarCOM4S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("sec.dat.lz4"))
			{
				ProgressBarCOM4S.Value = 100;
				ProgressBarCOM4S.Value = 10;
				ProgressBarCOM4S.Value = 40;
				ProgressBarCOM4S.Value = 59;
				ProgressChanged = Conversions.ToString(ProgressBarCOM4S.Value);
				ProgressBarCOM4S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("NON-HLOS.bin.lz4"))
			{
				ProgressBarCOM4S.Value = 99;
				ProgressChanged = Conversions.ToString(ProgressBarCOM4S.Value);
				ProgressBarCOM4S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("boot.img.lz4"))
			{
				ProgressBarCOM4S.Value = 0;
				ProgressChanged = Conversions.ToString(ProgressBarCOM4S.Value);
				ProgressBarCOM4S.Text = ProgressChanged + "%";
			}
			if (Operators.CompareString(obj, "md1img.img.lz4", TextCompare: false) == 0)
			{
				ProgressBarCOM4S.Value = 100;
				ProgressBarCOM4S.Value = 10;
				ProgressBarCOM4S.Value = 40;
				ProgressBarCOM4S.Value = 79;
				ProgressChanged = Conversions.ToString(ProgressBarCOM4S.Value);
				ProgressBarCOM4S.Text = ProgressChanged + "%";
			}
			if (Operators.CompareString(obj, "modem.bin", TextCompare: false) == 0)
			{
				ProgressBarCOM4S.Value = 100;
				ProgressBarCOM4S.Value = 10;
				ProgressBarCOM4S.Value = 40;
				ProgressBarCOM4S.Value = 59;
				ProgressChanged = Conversions.ToString(ProgressBarCOM4S.Value);
				ProgressBarCOM4S.Text = ProgressChanged + "%";
			}
			if (Operators.CompareString(obj, "modem_debug.bin", TextCompare: false) == 0)
			{
				ProgressBarCOM4S.Value = 100;
				ProgressBarCOM4S.Value = 10;
				ProgressBarCOM4S.Value = 40;
				ProgressBarCOM4S.Value = 89;
				ProgressChanged = Conversions.ToString(ProgressBarCOM4S.Value);
				ProgressBarCOM4S.Text = ProgressChanged + "%";
			}
			if (obj.Contains("Close Connection"))
			{
				wesreampung_wav();
				ProgressBarCOM4S.Text = "";
				ProgressBarCOM4S.Value = 0;
				Port_Name.Items.Clear();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception projectError = ex;
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
	}

	public void method_Refrescomsamsung00()
	{
		new Thread(method_Refrescomsamsung01).Start();
	}

	public void method_Refrescomsamsung000()
	{
		new Thread(method_Refrescomsamsung0).Start();
	}

	public void method_Refrescomsamsung01()
	{
		try
		{
			modem();
			method_DistributionProgressBarsamsung();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception projectError = ex;
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
	}

	public void method_Refrescomsamsung0()
	{
		try
		{
			modem();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception projectError = ex;
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
	}

	public void modem()
	{
		Port_Name.Items.Clear();
		checked
		{
			foreach (ManagementObject item in new ManagementObjectSearcher("SELECT * FROM Win32_POTSModem").Get())
			{
				if (Operators.CompareString(Conversions.ToString(item["Status"]), "OK", TextCompare: false) != 0)
				{
					continue;
				}
				Port_Name.Items.Add(Operators.AddObject(Operators.AddObject(item["Description"], " ("), Convert.ToString(Operators.AddObject(item["AttachedTo"], ")"))));
				TextBox4.Text = Conversions.ToString(Port_Name.Items.Count);
				if (Operators.CompareString(TextBox4.Text, "1", TextCompare: false) == 0)
				{
					Port_Name.SelectedIndex = 0;
					text3 = Port_Name.SelectedItem.ToString();
					if (!text3.Contains("Mobile USB Modem"))
					{
						Port_Name.Items.RemoveAt(Port_Name.SelectedIndex);
					}
				}
				if (Operators.CompareString(TextBox4.Text, "2", TextCompare: false) == 0)
				{
					Port_Name.SelectedIndex = 0;
					text3 = Port_Name.SelectedItem.ToString();
					if (!text3.Contains("Mobile USB Modem"))
					{
						Port_Name.Items.RemoveAt(Port_Name.SelectedIndex);
					}
					Port_Name.SelectedIndex = 1;
					text3 = Port_Name.SelectedItem.ToString();
					if (!text3.Contains("Mobile USB Modem"))
					{
						Port_Name.Items.RemoveAt(Port_Name.SelectedIndex);
					}
				}
				if (Operators.CompareString(TextBox4.Text, "3", TextCompare: false) == 0)
				{
					Port_Name.SelectedIndex = 0;
					text3 = Port_Name.SelectedItem.ToString();
					if (!text3.Contains("Mobile USB Modem"))
					{
						Port_Name.Items.RemoveAt(Port_Name.SelectedIndex);
					}
					Port_Name.SelectedIndex = 1;
					text3 = Port_Name.SelectedItem.ToString();
					if (!text3.Contains("Mobile USB Modem"))
					{
						Port_Name.Items.RemoveAt(Port_Name.SelectedIndex);
					}
					Port_Name.SelectedIndex = 2;
					text3 = Port_Name.SelectedItem.ToString();
					if (!text3.Contains("Mobile USB Modem"))
					{
						Port_Name.Items.RemoveAt(Port_Name.SelectedIndex);
					}
				}
				if (Operators.CompareString(TextBox4.Text, "4", TextCompare: false) == 0)
				{
					Port_Name.SelectedIndex = 0;
					text3 = Port_Name.SelectedItem.ToString();
					if (!text3.Contains("Mobile USB Modem"))
					{
						Port_Name.Items.RemoveAt(Port_Name.SelectedIndex);
					}
					Port_Name.SelectedIndex = 1;
					text3 = Port_Name.SelectedItem.ToString();
					if (!text3.Contains("Mobile USB Modem"))
					{
						Port_Name.Items.RemoveAt(Port_Name.SelectedIndex);
					}
					Port_Name.SelectedIndex = 2;
					text3 = Port_Name.SelectedItem.ToString();
					if (!text3.Contains("Mobile USB Modem"))
					{
						Port_Name.Items.RemoveAt(Port_Name.SelectedIndex);
					}
					Port_Name.SelectedIndex = 3;
					text3 = Port_Name.SelectedItem.ToString();
					if (!text3.Contains("Mobile USB Modem"))
					{
						Port_Name.Items.RemoveAt(Port_Name.SelectedIndex);
					}
				}
				if (Operators.CompareString(TextBox4.Text, "5", TextCompare: false) == 0)
				{
					Port_Name.SelectedIndex = 0;
					text3 = Port_Name.SelectedItem.ToString();
					if (!text3.Contains("Mobile USB Modem"))
					{
						Port_Name.Items.RemoveAt(Port_Name.SelectedIndex);
					}
					Port_Name.SelectedIndex = 1;
					text3 = Port_Name.SelectedItem.ToString();
					if (!text3.Contains("Mobile USB Modem"))
					{
						Port_Name.Items.RemoveAt(Port_Name.SelectedIndex);
					}
					Port_Name.SelectedIndex = 2;
					text3 = Port_Name.SelectedItem.ToString();
					if (!text3.Contains("Mobile USB Modem"))
					{
						Port_Name.Items.RemoveAt(Port_Name.SelectedIndex);
					}
					Port_Name.SelectedIndex = 3;
					text3 = Port_Name.SelectedItem.ToString();
					if (!text3.Contains("Mobile USB Modem"))
					{
						Port_Name.Items.RemoveAt(Port_Name.SelectedIndex);
					}
					Port_Name.SelectedIndex = 4;
					text3 = Port_Name.SelectedItem.ToString();
					if (!text3.Contains("Mobile USB Modem"))
					{
						Port_Name.Items.RemoveAt(Port_Name.SelectedIndex);
					}
				}
				if (Operators.CompareString(TextBox4.Text, "6", TextCompare: false) == 0)
				{
					Port_Name.SelectedIndex = 0;
					text3 = Port_Name.SelectedItem.ToString();
					if (!text3.Contains("Mobile USB Modem"))
					{
						Port_Name.Items.RemoveAt(Port_Name.SelectedIndex);
					}
					Port_Name.SelectedIndex = 1;
					text3 = Port_Name.SelectedItem.ToString();
					if (!text3.Contains("Mobile USB Modem"))
					{
						Port_Name.Items.RemoveAt(Port_Name.SelectedIndex);
					}
					Port_Name.SelectedIndex = 2;
					text3 = Port_Name.SelectedItem.ToString();
					if (!text3.Contains("Mobile USB Modem"))
					{
						Port_Name.Items.RemoveAt(Port_Name.SelectedIndex);
					}
					Port_Name.SelectedIndex = 3;
					text3 = Port_Name.SelectedItem.ToString();
					if (!text3.Contains("Mobile USB Modem"))
					{
						Port_Name.Items.RemoveAt(Port_Name.SelectedIndex);
					}
					Port_Name.SelectedIndex = 4;
					text3 = Port_Name.SelectedItem.ToString();
					if (!text3.Contains("Mobile USB Modem"))
					{
						Port_Name.Items.RemoveAt(Port_Name.SelectedIndex);
					}
					Port_Name.SelectedIndex = 5;
					text3 = Port_Name.SelectedItem.ToString();
					if (!text3.Contains("Mobile USB Modem"))
					{
						Port_Name.Items.RemoveAt(Port_Name.SelectedIndex);
					}
				}
				TextBox4.Text = Conversions.ToString(Port_Name.Items.Count);
				if (Operators.CompareString(TextBox4.Text, "0", TextCompare: false) == 0)
				{
					SamsungCOM1.Clear();
					SamsungCOM2.Clear();
					SamsungCOM3.Clear();
					SamsungCOM4.Clear();
				}
				if (Operators.CompareString(TextBox4.Text, "1", TextCompare: false) == 0)
				{
					SamsungCOM2.Clear();
					SamsungCOM3.Clear();
					SamsungCOM4.Clear();
					Port_Name.SelectedIndex = 0;
					text3 = Port_Name.SelectedItem.ToString();
					text3 = text3.Substring(text3.IndexOf("(") + 1, text3.Length - 2 - text3.IndexOf("(")).Replace(")", "");
					SamsungCOM1.Text = text3;
				}
				if (Operators.CompareString(TextBox4.Text, "2", TextCompare: false) == 0)
				{
					SamsungCOM3.Clear();
					SamsungCOM4.Clear();
					Port_Name.SelectedIndex = 0;
					text3 = Port_Name.SelectedItem.ToString();
					text3 = text3.Substring(text3.IndexOf("(") + 1, text3.Length - 2 - text3.IndexOf("(")).Replace(")", "");
					SamsungCOM1.Text = text3;
					Port_Name.SelectedIndex = 1;
					text3 = Port_Name.SelectedItem.ToString();
					text3 = text3.Substring(text3.IndexOf("(") + 1, text3.Length - 2 - text3.IndexOf("(")).Replace(")", "");
					SamsungCOM2.Text = text3;
				}
				if (Operators.CompareString(TextBox4.Text, "3", TextCompare: false) == 0)
				{
					SamsungCOM4.Clear();
					Port_Name.SelectedIndex = 0;
					text3 = Port_Name.SelectedItem.ToString();
					text3 = text3.Substring(text3.IndexOf("(") + 1, text3.Length - 2 - text3.IndexOf("(")).Replace(")", "");
					SamsungCOM1.Text = text3;
					Port_Name.SelectedIndex = 1;
					text3 = Port_Name.SelectedItem.ToString();
					text3 = text3.Substring(text3.IndexOf("(") + 1, text3.Length - 2 - text3.IndexOf("(")).Replace(")", "");
					SamsungCOM2.Text = text3;
					Port_Name.SelectedIndex = 2;
					text3 = Port_Name.SelectedItem.ToString();
					text3 = text3.Substring(text3.IndexOf("(") + 1, text3.Length - 2 - text3.IndexOf("(")).Replace(")", "");
					SamsungCOM3.Text = text3;
				}
				if (Operators.CompareString(TextBox4.Text, "4", TextCompare: false) == 0)
				{
					Port_Name.SelectedIndex = 0;
					text3 = Port_Name.SelectedItem.ToString();
					text3 = text3.Substring(text3.IndexOf("(") + 1, text3.Length - 2 - text3.IndexOf("(")).Replace(")", "");
					SamsungCOM1.Text = text3;
					Port_Name.SelectedIndex = 1;
					text3 = Port_Name.SelectedItem.ToString();
					text3 = text3.Substring(text3.IndexOf("(") + 1, text3.Length - 2 - text3.IndexOf("(")).Replace(")", "");
					SamsungCOM2.Text = text3;
					Port_Name.SelectedIndex = 2;
					text3 = Port_Name.SelectedItem.ToString();
					text3 = text3.Substring(text3.IndexOf("(") + 1, text3.Length - 2 - text3.IndexOf("(")).Replace(")", "");
					SamsungCOM3.Text = text3;
					Port_Name.SelectedIndex = 3;
					text3 = Port_Name.SelectedItem.ToString();
					text3 = text3.Substring(text3.IndexOf("(") + 1, text3.Length - 2 - text3.IndexOf("(")).Replace(")", "");
					SamsungCOM4.Text = text3;
				}
			}
		}
	}

	private void method_Refrescomsamsung()
	{
		if (Operators.CompareString(TextBox4.Text, "1", TextCompare: false) == 0)
		{
			Port_Name.SelectedIndex = 0;
			text3 = Port_Name.SelectedItem.ToString();
			if (!text3.Contains("Mobile USB Modem"))
			{
				Port_Name.Items.RemoveAt(Port_Name.SelectedIndex);
			}
		}
		if (Operators.CompareString(TextBox4.Text, "2", TextCompare: false) == 0)
		{
			Port_Name.SelectedIndex = 0;
			text3 = Port_Name.SelectedItem.ToString();
			if (!text3.Contains("Mobile USB Modem"))
			{
				Port_Name.Items.RemoveAt(Port_Name.SelectedIndex);
			}
			Port_Name.SelectedIndex = 1;
			text3 = Port_Name.SelectedItem.ToString();
			if (!text3.Contains("Mobile USB Modem"))
			{
				Port_Name.Items.RemoveAt(Port_Name.SelectedIndex);
			}
		}
		if (Operators.CompareString(TextBox4.Text, "3", TextCompare: false) == 0)
		{
			Port_Name.SelectedIndex = 0;
			text3 = Port_Name.SelectedItem.ToString();
			if (!text3.Contains("Mobile USB Modem"))
			{
				Port_Name.Items.RemoveAt(Port_Name.SelectedIndex);
			}
			Port_Name.SelectedIndex = 1;
			text3 = Port_Name.SelectedItem.ToString();
			if (!text3.Contains("Mobile USB Modem"))
			{
				Port_Name.Items.RemoveAt(Port_Name.SelectedIndex);
			}
			Port_Name.SelectedIndex = 2;
			text3 = Port_Name.SelectedItem.ToString();
			if (!text3.Contains("Mobile USB Modem"))
			{
				Port_Name.Items.RemoveAt(Port_Name.SelectedIndex);
			}
		}
		if (Operators.CompareString(TextBox4.Text, "4", TextCompare: false) == 0)
		{
			Port_Name.SelectedIndex = 0;
			text3 = Port_Name.SelectedItem.ToString();
			if (!text3.Contains("Mobile USB Modem"))
			{
				Port_Name.Items.RemoveAt(Port_Name.SelectedIndex);
			}
			Port_Name.SelectedIndex = 1;
			text3 = Port_Name.SelectedItem.ToString();
			if (!text3.Contains("Mobile USB Modem"))
			{
				Port_Name.Items.RemoveAt(Port_Name.SelectedIndex);
			}
			Port_Name.SelectedIndex = 2;
			text3 = Port_Name.SelectedItem.ToString();
			if (!text3.Contains("Mobile USB Modem"))
			{
				Port_Name.Items.RemoveAt(Port_Name.SelectedIndex);
			}
			Port_Name.SelectedIndex = 3;
			text3 = Port_Name.SelectedItem.ToString();
			if (!text3.Contains("Mobile USB Modem"))
			{
				Port_Name.Items.RemoveAt(Port_Name.SelectedIndex);
			}
		}
		if (Operators.CompareString(TextBox4.Text, "5", TextCompare: false) == 0)
		{
			Port_Name.SelectedIndex = 0;
			text3 = Port_Name.SelectedItem.ToString();
			if (!text3.Contains("Mobile USB Modem"))
			{
				Port_Name.Items.RemoveAt(Port_Name.SelectedIndex);
			}
			Port_Name.SelectedIndex = 1;
			text3 = Port_Name.SelectedItem.ToString();
			if (!text3.Contains("Mobile USB Modem"))
			{
				Port_Name.Items.RemoveAt(Port_Name.SelectedIndex);
			}
			Port_Name.SelectedIndex = 2;
			text3 = Port_Name.SelectedItem.ToString();
			if (!text3.Contains("Mobile USB Modem"))
			{
				Port_Name.Items.RemoveAt(Port_Name.SelectedIndex);
			}
			Port_Name.SelectedIndex = 3;
			text3 = Port_Name.SelectedItem.ToString();
			if (!text3.Contains("Mobile USB Modem"))
			{
				Port_Name.Items.RemoveAt(Port_Name.SelectedIndex);
			}
			Port_Name.SelectedIndex = 4;
			text3 = Port_Name.SelectedItem.ToString();
			if (!text3.Contains("Mobile USB Modem"))
			{
				Port_Name.Items.RemoveAt(Port_Name.SelectedIndex);
			}
		}
		if (Operators.CompareString(TextBox4.Text, "6", TextCompare: false) == 0)
		{
			Port_Name.SelectedIndex = 0;
			text3 = Port_Name.SelectedItem.ToString();
			if (!text3.Contains("Mobile USB Modem"))
			{
				Port_Name.Items.RemoveAt(Port_Name.SelectedIndex);
			}
			Port_Name.SelectedIndex = 1;
			text3 = Port_Name.SelectedItem.ToString();
			if (!text3.Contains("Mobile USB Modem"))
			{
				Port_Name.Items.RemoveAt(Port_Name.SelectedIndex);
			}
			Port_Name.SelectedIndex = 2;
			text3 = Port_Name.SelectedItem.ToString();
			if (!text3.Contains("Mobile USB Modem"))
			{
				Port_Name.Items.RemoveAt(Port_Name.SelectedIndex);
			}
			Port_Name.SelectedIndex = 3;
			text3 = Port_Name.SelectedItem.ToString();
			if (!text3.Contains("Mobile USB Modem"))
			{
				Port_Name.Items.RemoveAt(Port_Name.SelectedIndex);
			}
			Port_Name.SelectedIndex = 4;
			text3 = Port_Name.SelectedItem.ToString();
			if (!text3.Contains("Mobile USB Modem"))
			{
				Port_Name.Items.RemoveAt(Port_Name.SelectedIndex);
			}
			Port_Name.SelectedIndex = 5;
			text3 = Port_Name.SelectedItem.ToString();
			if (!text3.Contains("Mobile USB Modem"))
			{
				Port_Name.Items.RemoveAt(Port_Name.SelectedIndex);
			}
		}
		TextBox4.Text = Conversions.ToString(Port_Name.Items.Count);
		checked
		{
			if (Operators.CompareString(TextBox4.Text, "1", TextCompare: false) == 0)
			{
				SamsungCOM2.Clear();
				SamsungCOM3.Clear();
				SamsungCOM4.Clear();
				Port_Name.SelectedIndex = 0;
				text3 = Port_Name.SelectedItem.ToString();
				text3 = text3.Substring(text3.IndexOf("(") + 1, text3.Length - 2 - text3.IndexOf("(")).Replace(")", "");
				SamsungCOM1.Text = text3;
			}
			if (Operators.CompareString(TextBox4.Text, "2", TextCompare: false) == 0)
			{
				SamsungCOM3.Clear();
				SamsungCOM4.Clear();
				Port_Name.SelectedIndex = 0;
				text3 = Port_Name.SelectedItem.ToString();
				text3 = text3.Substring(text3.IndexOf("(") + 1, text3.Length - 2 - text3.IndexOf("(")).Replace(")", "");
				SamsungCOM1.Text = text3;
				Port_Name.SelectedIndex = 1;
				text3 = Port_Name.SelectedItem.ToString();
				text3 = text3.Substring(text3.IndexOf("(") + 1, text3.Length - 2 - text3.IndexOf("(")).Replace(")", "");
				SamsungCOM2.Text = text3;
			}
			if (Operators.CompareString(TextBox4.Text, "3", TextCompare: false) == 0)
			{
				SamsungCOM4.Clear();
				Port_Name.SelectedIndex = 0;
				text3 = Port_Name.SelectedItem.ToString();
				text3 = text3.Substring(text3.IndexOf("(") + 1, text3.Length - 2 - text3.IndexOf("(")).Replace(")", "");
				SamsungCOM1.Text = text3;
				Port_Name.SelectedIndex = 1;
				text3 = Port_Name.SelectedItem.ToString();
				text3 = text3.Substring(text3.IndexOf("(") + 1, text3.Length - 2 - text3.IndexOf("(")).Replace(")", "");
				SamsungCOM2.Text = text3;
				Port_Name.SelectedIndex = 2;
				text3 = Port_Name.SelectedItem.ToString();
				text3 = text3.Substring(text3.IndexOf("(") + 1, text3.Length - 2 - text3.IndexOf("(")).Replace(")", "");
				SamsungCOM3.Text = text3;
			}
			if (Operators.CompareString(TextBox4.Text, "4", TextCompare: false) == 0)
			{
				Port_Name.SelectedIndex = 0;
				text3 = Port_Name.SelectedItem.ToString();
				text3 = text3.Substring(text3.IndexOf("(") + 1, text3.Length - 2 - text3.IndexOf("(")).Replace(")", "");
				SamsungCOM1.Text = text3;
				Port_Name.SelectedIndex = 1;
				text3 = Port_Name.SelectedItem.ToString();
				text3 = text3.Substring(text3.IndexOf("(") + 1, text3.Length - 2 - text3.IndexOf("(")).Replace(")", "");
				SamsungCOM2.Text = text3;
				Port_Name.SelectedIndex = 2;
				text3 = Port_Name.SelectedItem.ToString();
				text3 = text3.Substring(text3.IndexOf("(") + 1, text3.Length - 2 - text3.IndexOf("(")).Replace(")", "");
				SamsungCOM3.Text = text3;
				Port_Name.SelectedIndex = 3;
				text3 = Port_Name.SelectedItem.ToString();
				text3 = text3.Substring(text3.IndexOf("(") + 1, text3.Length - 2 - text3.IndexOf("(")).Replace(")", "");
				SamsungCOM4.Text = text3;
			}
		}
	}

	public void method_DistributionProgressBarsamsung()
	{
		TextBox4.Text = Conversions.ToString(Port_Name.Items.Count);
		if (Operators.CompareString(TextBox4.Text, "0", TextCompare: false) == 0)
		{
			ProgressBarCOM1S.Text = "";
			ProgressBarCOM1S.Value = 0;
			ProgressBarCOM2S.Text = "";
			ProgressBarCOM2S.Value = 0;
			ProgressBarCOM3S.Text = "";
			ProgressBarCOM3S.Value = 0;
			ProgressBarCOM4S.Text = "";
			ProgressBarCOM4S.Value = 0;
		}
		if (Operators.CompareString(TextBox4.Text, "1", TextCompare: false) == 0)
		{
			ProgressBarCOM1S.Text = "Unknown";
			ProgressBarCOM1S.Value = 100;
			ProgressBarCOM2S.Text = "";
			ProgressBarCOM2S.Value = 0;
			ProgressBarCOM3S.Text = "";
			ProgressBarCOM3S.Value = 0;
			ProgressBarCOM4S.Text = "";
			ProgressBarCOM4S.Value = 0;
		}
		if (Operators.CompareString(TextBox4.Text, "2", TextCompare: false) == 0)
		{
			ProgressBarCOM1S.Text = "Unknown";
			ProgressBarCOM1S.Value = 100;
			ProgressBarCOM2S.Text = "Unknown";
			ProgressBarCOM2S.Value = 100;
			ProgressBarCOM3S.Text = "";
			ProgressBarCOM3S.Value = 0;
			ProgressBarCOM4S.Text = "";
			ProgressBarCOM4S.Value = 0;
		}
		if (Operators.CompareString(TextBox4.Text, "3", TextCompare: false) == 0)
		{
			ProgressBarCOM1S.Text = "Unknown";
			ProgressBarCOM1S.Value = 100;
			ProgressBarCOM2S.Text = "Unknown";
			ProgressBarCOM2S.Value = 100;
			ProgressBarCOM3S.Text = "Unknown";
			ProgressBarCOM3S.Value = 100;
			ProgressBarCOM4S.Text = "";
			ProgressBarCOM4S.Value = 0;
		}
		if (Operators.CompareString(TextBox4.Text, "4", TextCompare: false) == 0)
		{
			ProgressBarCOM1S.Text = "Unknown";
			ProgressBarCOM1S.Value = 100;
			ProgressBarCOM2S.Text = "Unknown";
			ProgressBarCOM2S.Value = 100;
			ProgressBarCOM3S.Text = "Unknown";
			ProgressBarCOM3S.Value = 100;
			ProgressBarCOM4S.Text = "Unknown";
			ProgressBarCOM4S.Value = 100;
		}
	}

	public void method_DistributionPortsamsung()
	{
		checked
		{
			if (Operators.CompareString(TextBox4.Text, "1", TextCompare: false) == 0)
			{
				SamsungCOM2.Clear();
				SamsungCOM3.Clear();
				SamsungCOM4.Clear();
				Port_Name.SelectedIndex = 0;
				text3 = Port_Name.SelectedItem.ToString();
				text3 = text3.Substring(text3.IndexOf("(") + 1, text3.Length - 2 - text3.IndexOf("(")).Replace(")", "");
				SamsungCOM1.Text = text3;
			}
			if (Operators.CompareString(TextBox4.Text, "2", TextCompare: false) == 0)
			{
				SamsungCOM3.Clear();
				SamsungCOM4.Clear();
				Port_Name.SelectedIndex = 0;
				text3 = Port_Name.SelectedItem.ToString();
				text3 = text3.Substring(text3.IndexOf("(") + 1, text3.Length - 2 - text3.IndexOf("(")).Replace(")", "");
				SamsungCOM1.Text = text3;
				Port_Name.SelectedIndex = 1;
				text3 = Port_Name.SelectedItem.ToString();
				text3 = text3.Substring(text3.IndexOf("(") + 1, text3.Length - 2 - text3.IndexOf("(")).Replace(")", "");
				SamsungCOM2.Text = text3;
			}
			if (Operators.CompareString(TextBox4.Text, "3", TextCompare: false) == 0)
			{
				SamsungCOM4.Clear();
				Port_Name.SelectedIndex = 0;
				text3 = Port_Name.SelectedItem.ToString();
				text3 = text3.Substring(text3.IndexOf("(") + 1, text3.Length - 2 - text3.IndexOf("(")).Replace(")", "");
				SamsungCOM1.Text = text3;
				Port_Name.SelectedIndex = 1;
				text3 = Port_Name.SelectedItem.ToString();
				text3 = text3.Substring(text3.IndexOf("(") + 1, text3.Length - 2 - text3.IndexOf("(")).Replace(")", "");
				SamsungCOM2.Text = text3;
				Port_Name.SelectedIndex = 2;
				text3 = Port_Name.SelectedItem.ToString();
				text3 = text3.Substring(text3.IndexOf("(") + 1, text3.Length - 2 - text3.IndexOf("(")).Replace(")", "");
				SamsungCOM3.Text = text3;
			}
			if (Operators.CompareString(TextBox4.Text, "4", TextCompare: false) == 0)
			{
				Port_Name.SelectedIndex = 0;
				text3 = Port_Name.SelectedItem.ToString();
				text3 = text3.Substring(text3.IndexOf("(") + 1, text3.Length - 2 - text3.IndexOf("(")).Replace(")", "");
				SamsungCOM1.Text = text3;
				Port_Name.SelectedIndex = 1;
				text3 = Port_Name.SelectedItem.ToString();
				text3 = text3.Substring(text3.IndexOf("(") + 1, text3.Length - 2 - text3.IndexOf("(")).Replace(")", "");
				SamsungCOM2.Text = text3;
				Port_Name.SelectedIndex = 2;
				text3 = Port_Name.SelectedItem.ToString();
				text3 = text3.Substring(text3.IndexOf("(") + 1, text3.Length - 2 - text3.IndexOf("(")).Replace(")", "");
				SamsungCOM3.Text = text3;
				Port_Name.SelectedIndex = 3;
				text3 = Port_Name.SelectedItem.ToString();
				text3 = text3.Substring(text3.IndexOf("(") + 1, text3.Length - 2 - text3.IndexOf("(")).Replace(")", "");
				SamsungCOM4.Text = text3;
			}
		}
	}

	private void Timer3_Tick(object sender, EventArgs e)
	{
		try
		{
			method_Refrescomsamsung000();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception projectError = ex;
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
	}

	public void READINFOCOM1()
	{
		if (!COM1.Text.Contains("COM"))
		{
			return;
		}
		check = "--serial " + COM1.Text + " -c " + TextBox15.Text;
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Connect Port ( ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.LightGreen;
		Form1.SharedUI.RichTextBox1.AppendText("LGE Mobile USB Serial Port (" + COM1.Text + ")");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(" ) : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(" OK");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Gathering Phone Info : ");
		Form1.SharedUI.RichTextBox1.Update();
		byte[] array = send_LGLafCommand(check);
		if (array == null || array.Length < 1000 || Operators.CompareString(BitConverter.ToString(array, 0, 2), "08-0B", TextCompare: false) != 0)
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText("Fail To Getting Device Info");
			Delay(0.1);
			return;
		}
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("OK");
		Form1.SharedUI.RichTextBox1.Update();
		string text = Encoding.UTF8.GetString(array, 305, 15).Replace("\0", "");
		string text2 = Encoding.UTF8.GetString(array, 335, 30).Replace("\0", "");
		string text3 = Encoding.UTF8.GetString(array, 591, 50).Replace("\0", "");
		string text4 = Encoding.UTF8.GetString(array, 967, 16).Replace("\0", "").Replace("\r", " ");
		string text5 = Encoding.UTF8.GetString(array, 907, 16).Replace("\0", "");
		string text6 = Encoding.UTF8.GetString(array, 987, 16).Replace("\0", "");
		string text7 = Encoding.UTF8.GetString(array, 945, 4).Replace("\0", "");
		string text8 = Encoding.UTF8.GetString(array, 1082, 15).Replace("\0", "");
		string text9 = Encoding.UTF8.GetString(array, 1102, 4).Replace("\0", "");
		string text10 = Encoding.UTF8.GetString(array, 1256, 10).Replace("\0", "");
		string text11 = Encoding.UTF8.GetString(array, 927, 18).Replace("\0", "");
		string text12 = Encoding.UTF8.GetString(array, 1047, 7).Replace("\0", "");
		string text13 = Encoding.UTF8.GetString(array, 1943, 60).Replace("\0", "");
		Encoding.UTF8.GetString(array, 1576, 100).Replace("\0", "");
		string text14 = Encoding.UTF8.GetString(array, 1840, 20).Replace('\u00a0', ' ');
		string left = Encoding.UTF8.GetString(array, 2160, 8).Replace("\0", "");
		int num = array[1067];
		int num2 = array[1837];
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Model : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(text);
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Version : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(text2);
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Software version : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(text3);
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- IMEI : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(text4);
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- SN : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(text5);
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Product ID : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(text6);
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Android Version : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(text7);
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Current Battery : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(num + "%");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Status : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(text13);
		Form1.SharedUI.RichTextBox1.Update();
		if (Operators.CompareString(left, "", TextCompare: false) != 0)
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Region : ");
			Form1.SharedUI.RichTextBox1.Update();
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText(left);
			Form1.SharedUI.RichTextBox1.Update();
		}
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Hardware : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(text12);
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- LAF version : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(text10);
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Download mode : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(text11);
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Operator : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(text9);
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Platform : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(text8);
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Storage Serial : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(text14);
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText("- Storage Size : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(num2 + "GB");
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.LightGreen;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "> Finsh Read Info");
	}

	public void READINFOCOM2()
	{
		if (!COM2.Text.Contains("COM"))
		{
			return;
		}
		check = "--serial " + COM2.Text + " -c " + TextBox15.Text;
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Connect Port ( ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.LightGreen;
		Form1.SharedUI.RichTextBox1.AppendText("LGE Mobile USB Serial Port (" + COM2.Text + ")");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(" ) : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(" OK");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Gathering Phone Info : ");
		Form1.SharedUI.RichTextBox1.Update();
		byte[] array = send_LGLafCommand(check);
		if (array == null || array.Length < 1000 || Operators.CompareString(BitConverter.ToString(array, 0, 2), "08-0B", TextCompare: false) != 0)
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText("Fail To Getting Device Info");
			Delay(0.1);
			return;
		}
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("OK");
		Form1.SharedUI.RichTextBox1.Update();
		string text = Encoding.UTF8.GetString(array, 305, 15).Replace("\0", "");
		string text2 = Encoding.UTF8.GetString(array, 335, 30).Replace("\0", "");
		string text3 = Encoding.UTF8.GetString(array, 591, 50).Replace("\0", "");
		string text4 = Encoding.UTF8.GetString(array, 967, 16).Replace("\0", "").Replace("\r", " ");
		string text5 = Encoding.UTF8.GetString(array, 907, 16).Replace("\0", "");
		string text6 = Encoding.UTF8.GetString(array, 987, 16).Replace("\0", "");
		string text7 = Encoding.UTF8.GetString(array, 945, 4).Replace("\0", "");
		string text8 = Encoding.UTF8.GetString(array, 1082, 15).Replace("\0", "");
		string text9 = Encoding.UTF8.GetString(array, 1102, 4).Replace("\0", "");
		string text10 = Encoding.UTF8.GetString(array, 1256, 10).Replace("\0", "");
		string text11 = Encoding.UTF8.GetString(array, 927, 18).Replace("\0", "");
		string text12 = Encoding.UTF8.GetString(array, 1047, 7).Replace("\0", "");
		string text13 = Encoding.UTF8.GetString(array, 1943, 60).Replace("\0", "");
		Encoding.UTF8.GetString(array, 1576, 100).Replace("\0", "");
		string text14 = Encoding.UTF8.GetString(array, 1840, 20).Replace('\u00a0', ' ');
		string left = Encoding.UTF8.GetString(array, 2160, 8).Replace("\0", "");
		int num = array[1067];
		int num2 = array[1837];
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Model : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(text);
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Version : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(text2);
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Software version : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(text3);
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- IMEI : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(text4);
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- SN : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(text5);
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Product ID : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(text6);
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Android Version : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(text7);
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Current Battery : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(num + "%");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Status : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(text13);
		Form1.SharedUI.RichTextBox1.Update();
		if (Operators.CompareString(left, "", TextCompare: false) != 0)
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Region : ");
			Form1.SharedUI.RichTextBox1.Update();
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText(left);
			Form1.SharedUI.RichTextBox1.Update();
		}
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Hardware : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(text12);
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- LAF version : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(text10);
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Download mode : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(text11);
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Operator : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(text9);
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Platform : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(text8);
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Storage Serial : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(text14);
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText("- Storage Size : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(num2 + "GB");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.LightGreen;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "> Finsh Read Info");
	}

	public void READINFOCOM3()
	{
		if (!COM3.Text.Contains("COM"))
		{
			return;
		}
		check = "--serial " + COM3.Text + " -c " + TextBox15.Text;
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Connect Port ( ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.LightGreen;
		Form1.SharedUI.RichTextBox1.AppendText("LGE Mobile USB Serial Port (" + COM3.Text + ")");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(" ) : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(" OK");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Gathering Phone Info : ");
		Form1.SharedUI.RichTextBox1.Update();
		byte[] array = send_LGLafCommand(check);
		if (array == null || array.Length < 1000 || Operators.CompareString(BitConverter.ToString(array, 0, 2), "08-0B", TextCompare: false) != 0)
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText("Fail To Getting Device Info");
			Delay(0.1);
			return;
		}
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("OK");
		Form1.SharedUI.RichTextBox1.Update();
		string text = Encoding.UTF8.GetString(array, 305, 15).Replace("\0", "");
		string text2 = Encoding.UTF8.GetString(array, 335, 30).Replace("\0", "");
		string text3 = Encoding.UTF8.GetString(array, 591, 50).Replace("\0", "");
		string text4 = Encoding.UTF8.GetString(array, 967, 16).Replace("\0", "").Replace("\r", " ");
		string text5 = Encoding.UTF8.GetString(array, 907, 16).Replace("\0", "");
		string text6 = Encoding.UTF8.GetString(array, 987, 16).Replace("\0", "");
		string text7 = Encoding.UTF8.GetString(array, 945, 4).Replace("\0", "");
		string text8 = Encoding.UTF8.GetString(array, 1082, 15).Replace("\0", "");
		string text9 = Encoding.UTF8.GetString(array, 1102, 4).Replace("\0", "");
		string text10 = Encoding.UTF8.GetString(array, 1256, 10).Replace("\0", "");
		string text11 = Encoding.UTF8.GetString(array, 927, 18).Replace("\0", "");
		string text12 = Encoding.UTF8.GetString(array, 1047, 7).Replace("\0", "");
		string text13 = Encoding.UTF8.GetString(array, 1943, 60).Replace("\0", "");
		Encoding.UTF8.GetString(array, 1576, 100).Replace("\0", "");
		string text14 = Encoding.UTF8.GetString(array, 1840, 20).Replace('\u00a0', ' ');
		string left = Encoding.UTF8.GetString(array, 2160, 8).Replace("\0", "");
		int num = array[1067];
		int num2 = array[1837];
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Model : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(text);
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Version : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(text2);
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Software version : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(text3);
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- IMEI : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(text4);
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- SN : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(text5);
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Product ID : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(text6);
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Android Version : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(text7);
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Current Battery : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(num + "%");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Status : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(text13);
		Form1.SharedUI.RichTextBox1.Update();
		if (Operators.CompareString(left, "", TextCompare: false) != 0)
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Region : ");
			Form1.SharedUI.RichTextBox1.Update();
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText(left);
			Form1.SharedUI.RichTextBox1.Update();
		}
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Hardware : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(text12);
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- LAF version : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(text10);
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Download mode : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(text11);
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Operator : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(text9);
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Platform : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(text8);
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Storage Serial : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(text14);
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText("- Storage Size : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(num2 + "GB");
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.LightGreen;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "> Finsh Read Info");
	}

	public void READINFOCOM4()
	{
		if (!COM4.Text.Contains("COM"))
		{
			return;
		}
		check = "--serial " + COM4.Text + " -c " + TextBox15.Text;
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Connect Port ( ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.LightGreen;
		Form1.SharedUI.RichTextBox1.AppendText("LGE Mobile USB Serial Port (" + COM4.Text + ")");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(" ) : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(" OK");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Gathering Phone Info : ");
		Form1.SharedUI.RichTextBox1.Update();
		byte[] array = send_LGLafCommand(check);
		if (array == null || array.Length < 1000 || Operators.CompareString(BitConverter.ToString(array, 0, 2), "08-0B", TextCompare: false) != 0)
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText("Fail To Getting Device Info");
			Delay(0.1);
			return;
		}
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("OK");
		Form1.SharedUI.RichTextBox1.Update();
		string text = Encoding.UTF8.GetString(array, 305, 15).Replace("\0", "");
		string text2 = Encoding.UTF8.GetString(array, 335, 30).Replace("\0", "");
		string text3 = Encoding.UTF8.GetString(array, 591, 50).Replace("\0", "");
		string text4 = Encoding.UTF8.GetString(array, 967, 16).Replace("\0", "").Replace("\r", " ");
		string text5 = Encoding.UTF8.GetString(array, 907, 16).Replace("\0", "");
		string text6 = Encoding.UTF8.GetString(array, 987, 16).Replace("\0", "");
		string text7 = Encoding.UTF8.GetString(array, 945, 4).Replace("\0", "");
		string text8 = Encoding.UTF8.GetString(array, 1082, 15).Replace("\0", "");
		string text9 = Encoding.UTF8.GetString(array, 1102, 4).Replace("\0", "");
		string text10 = Encoding.UTF8.GetString(array, 1256, 10).Replace("\0", "");
		string text11 = Encoding.UTF8.GetString(array, 927, 18).Replace("\0", "");
		string text12 = Encoding.UTF8.GetString(array, 1047, 7).Replace("\0", "");
		string text13 = Encoding.UTF8.GetString(array, 1943, 60).Replace("\0", "");
		Encoding.UTF8.GetString(array, 1576, 100).Replace("\0", "");
		string text14 = Encoding.UTF8.GetString(array, 1840, 20).Replace('\u00a0', ' ');
		string left = Encoding.UTF8.GetString(array, 2160, 8).Replace("\0", "");
		int num = array[1067];
		int num2 = array[1837];
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Model : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(text);
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Version : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(text2);
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Software version : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(text3);
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- IMEI : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(text4);
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- SN : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(text5);
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Product ID : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(text6);
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Android Version : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(text7);
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Current Battery : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(num + "%");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Status : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(text13);
		Form1.SharedUI.RichTextBox1.Update();
		if (Operators.CompareString(left, "", TextCompare: false) != 0)
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Region : ");
			Form1.SharedUI.RichTextBox1.Update();
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText(left);
			Form1.SharedUI.RichTextBox1.Update();
		}
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Hardware : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(text12);
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- LAF version : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(text10);
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Download mode : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(text11);
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Operator : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(text9);
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Platform : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(text8);
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Storage Serial : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(text14);
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText("- Storage Size : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(num2 + "GB");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.LightGreen;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "> Finsh Read Info");
		Form1.SharedUI.RichTextBox1.Update();
	}

	public void READINFO()
	{
		TextBox4.Text = Conversions.ToString(ComboBox1.Items.Count);
		if (Operators.CompareString(TextBox4.Text, "1", TextCompare: false) == 0)
		{
			READINFOCOM1();
		}
		if (Operators.CompareString(TextBox4.Text, "2", TextCompare: false) == 0)
		{
			READINFOCOM1();
			READINFOCOM2();
		}
		if (Operators.CompareString(TextBox4.Text, "3", TextCompare: false) == 0)
		{
			READINFOCOM1();
			READINFOCOM2();
			READINFOCOM3();
		}
		if (Operators.CompareString(TextBox4.Text, "4", TextCompare: false) == 0)
		{
			READINFOCOM1();
			READINFOCOM2();
			READINFOCOM3();
			READINFOCOM4();
		}
	}

	private void Guna2Button23_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(SamsungCOM1.Text, "", TextCompare: false) == 0 && Operators.CompareString(SamsungCOM2.Text, "", TextCompare: false) == 0 && Operators.CompareString(SamsungCOM3.Text, "", TextCompare: false) == 0 && Operators.CompareString(SamsungCOM4.Text, "", TextCompare: false) == 0)
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Check The Connected Devices, And Try Again");
		}
		else
		{
			Form1.SharedUI.RichTextBox1.Text = "# [ Samsung Flasher ] By Tunlocker Team";
			method_flashsamsung();
		}
	}

	private void Guna2Button25_Click(object sender, EventArgs e)
	{
		SamsungCOM1.Clear();
		SamsungCOM2.Clear();
		SamsungCOM3.Clear();
		SamsungCOM4.Clear();
		RichTextBox3.Clear();
		Form1.SharedUI.RichTextBox1.Text = "# [ Samsung Flasher ] By Tunlocker Team";
		BL.Clear();
		AP.Clear();
		CP.Clear();
		CSC.Clear();
		ProgressBarCOM1S.Text = "";
		ProgressBarCOM1S.Value = 0;
		ProgressBarCOM2S.Text = "";
		ProgressBarCOM2S.Value = 0;
		ProgressBarCOM3S.Text = "";
		ProgressBarCOM3S.Value = 0;
		ProgressBarCOM4S.Text = "";
		ProgressBarCOM4S.Value = 0;
	}

	private void Guna2Button1_Click(object sender, EventArgs e)
	{
		BL.Clear();
		OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.Filter = "BL Files (*.tar, *.md5)|*.md5;*.tar";
		if (DialogResult.OK == openFileDialog.ShowDialog())
		{
			string fileName = openFileDialog.FileName;
			a = openFileDialog.FileName;
			a = Strings.Replace(a, " ", "\" \"");
			BL.AppendText(fileName);
		}
	}

	private void Guna2Button2_Click(object sender, EventArgs e)
	{
		AP.Clear();
		OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.Filter = "AP Files (*.tar, *.md5)|*.md5;*.tar";
		if (DialogResult.OK == openFileDialog.ShowDialog())
		{
			string fileName = openFileDialog.FileName;
			a = openFileDialog.FileName;
			a = Strings.Replace(a, " ", "\" \"");
			AP.AppendText(fileName);
		}
	}

	private void Guna2Button3_Click(object sender, EventArgs e)
	{
		CP.Clear();
		OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.Filter = "CP Files (*.tar, *.md5)|*.md5;*.tar";
		if (DialogResult.OK == openFileDialog.ShowDialog())
		{
			string fileName = openFileDialog.FileName;
			a = openFileDialog.FileName;
			a = Strings.Replace(a, " ", "\" \"");
			CP.AppendText(fileName);
		}
	}

	private void Guna2Button4_Click(object sender, EventArgs e)
	{
		CSC.Clear();
		OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.Filter = "CSC Files (*.tar, *.md5)|*.md5;*.tar";
		if (DialogResult.OK == openFileDialog.ShowDialog())
		{
			string fileName = openFileDialog.FileName;
			a = openFileDialog.FileName;
			a = Strings.Replace(a, " ", "\" \"");
			CSC.AppendText(fileName);
		}
	}

	private void Guna2Button5_Click(object sender, EventArgs e)
	{
		try
		{
			method_Refrescomsamsung000();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception projectError = ex;
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
	}

	private void Guna2CheckBox2_CheckedChanged(object sender, EventArgs e)
	{
		if (Guna2CheckBox2.Checked)
		{
			Timer3.Enabled = true;
		}
		else
		{
			Timer3.Enabled = false;
		}
	}

	private void Guna2Button6_Click(object sender, EventArgs e)
	{
		OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.Filter = "All Files (*.kdz*)|*.kdz*";
		if (DialogResult.OK == openFileDialog.ShowDialog())
		{
			string fileName = openFileDialog.FileName;
			a = openFileDialog.FileName;
			a = Strings.Replace(a, " ", "\" \"");
			name_flash.Text = fileName;
		}
	}

	private void Guna2Button7_Click(object sender, EventArgs e)
	{
		SamsungCOM1.Clear();
		SamsungCOM2.Clear();
		SamsungCOM3.Clear();
		SamsungCOM4.Clear();
		Form1.SharedUI.RichTextBox1.Clear();
		Form1.SharedUI.RichTextBox1.Text = "# [ LG Flasher ] By Tunlocker Team";
		new Thread(READINFO).Start();
	}

	private void Guna2Button8_Click(object sender, EventArgs e)
	{
		SamsungCOM1.Clear();
		SamsungCOM2.Clear();
		SamsungCOM3.Clear();
		SamsungCOM4.Clear();
		Form1.SharedUI.RichTextBox1.Clear();
		Form1.SharedUI.RichTextBox1.Text = "# [ LG Flasher ] By Tunlocker Team";
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Checking Files : ");
		if (Operators.CompareString(name_flash.Text, "", TextCompare: false) != 0)
		{
			if (File.Exists(name_flash.Text))
			{
				method_flash22();
				return;
			}
			Form1.SharedUI.RichTextBox1.Update();
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText("Not Exists Firmware");
		}
		else
		{
			Form1.SharedUI.RichTextBox1.Update();
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText("Select Firmware");
		}
	}

	private void Guna2Button12_Click(object sender, EventArgs e)
	{
		method_Refrescom();
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		if (Operators.CompareString(TextBox4.Text, "1", TextCompare: false) == 0 && Operators.CompareString(chengbar, "11", TextCompare: false) == 0)
		{
			COM1ProgressBar1.Increment(1);
			ProgressChanged = Conversions.ToString(COM1ProgressBar1.Value);
			COM1ProgressBar1.Text = ProgressChanged + "%";
		}
		if (Operators.CompareString(TextBox4.Text, "2", TextCompare: false) == 0)
		{
			if (Operators.CompareString(chengbar, "11", TextCompare: false) == 0)
			{
				COM1ProgressBar1.Increment(1);
				ProgressChanged = Conversions.ToString(COM1ProgressBar1.Value);
				COM1ProgressBar1.Text = ProgressChanged + "%";
			}
			if (Operators.CompareString(chengbar, "11", TextCompare: false) == 0)
			{
				COM2ProgressBar1.Increment(1);
				ProgressChanged = Conversions.ToString(COM2ProgressBar1.Value);
				COM2ProgressBar1.Text = ProgressChanged + "%";
			}
		}
		if (Operators.CompareString(TextBox4.Text, "3", TextCompare: false) == 0)
		{
			if (Operators.CompareString(chengbar, "11", TextCompare: false) == 0)
			{
				COM1ProgressBar1.Increment(1);
				ProgressChanged = Conversions.ToString(COM1ProgressBar1.Value);
				COM1ProgressBar1.Text = ProgressChanged + "%";
			}
			if (Operators.CompareString(chengbar, "11", TextCompare: false) == 0)
			{
				COM2ProgressBar1.Increment(1);
				ProgressChanged = Conversions.ToString(COM2ProgressBar1.Value);
				COM2ProgressBar1.Text = ProgressChanged + "%";
			}
			if (Operators.CompareString(chengbar, "11", TextCompare: false) == 0)
			{
				COM3ProgressBar1.Increment(1);
				ProgressChanged = Conversions.ToString(COM3ProgressBar1.Value);
				COM3ProgressBar1.Text = ProgressChanged + "%";
			}
		}
		if (Operators.CompareString(TextBox4.Text, "4", TextCompare: false) == 0)
		{
			if (Operators.CompareString(chengbar, "11", TextCompare: false) == 0)
			{
				COM1ProgressBar1.Increment(1);
				ProgressChanged = Conversions.ToString(COM1ProgressBar1.Value);
				COM1ProgressBar1.Text = ProgressChanged + "%";
			}
			if (Operators.CompareString(chengbar, "11", TextCompare: false) == 0)
			{
				COM2ProgressBar1.Increment(1);
				ProgressChanged = Conversions.ToString(COM2ProgressBar1.Value);
				COM2ProgressBar1.Text = ProgressChanged + "%";
			}
			if (Operators.CompareString(chengbar, "11", TextCompare: false) == 0)
			{
				COM3ProgressBar1.Increment(1);
				ProgressChanged = Conversions.ToString(COM3ProgressBar1.Value);
				COM3ProgressBar1.Text = ProgressChanged + "%";
			}
			if (Operators.CompareString(chengbar, "11", TextCompare: false) == 0)
			{
				COM4ProgressBar1.Increment(1);
				ProgressChanged = Conversions.ToString(COM4ProgressBar1.Value);
				COM4ProgressBar1.Text = ProgressChanged + "%";
			}
		}
		if (Operators.CompareString(TextBox4.Text, "1", TextCompare: false) == 0 && Operators.CompareString(chengbar, "10", TextCompare: false) == 0)
		{
			COM1ProgressBar1.Increment(25);
			ProgressChanged = Conversions.ToString(COM1ProgressBar1.Value);
			COM1ProgressBar1.Text = ProgressChanged + "%";
		}
		if (Operators.CompareString(TextBox4.Text, "2", TextCompare: false) == 0)
		{
			if (Operators.CompareString(chengbar, "10", TextCompare: false) == 0)
			{
				COM1ProgressBar1.Increment(25);
				ProgressChanged = Conversions.ToString(COM1ProgressBar1.Value);
				COM1ProgressBar1.Text = ProgressChanged + "%";
			}
			if (Operators.CompareString(chengbar, "10", TextCompare: false) == 0)
			{
				COM1ProgressBar1.Increment(25);
				ProgressChanged = Conversions.ToString(COM2ProgressBar1.Value);
				COM2ProgressBar1.Text = ProgressChanged + "%";
			}
		}
		if (Operators.CompareString(TextBox4.Text, "3", TextCompare: false) == 0)
		{
			if (Operators.CompareString(chengbar, "10", TextCompare: false) == 0)
			{
				COM1ProgressBar1.Increment(25);
				ProgressChanged = Conversions.ToString(COM1ProgressBar1.Value);
				COM1ProgressBar1.Text = ProgressChanged + "%";
			}
			if (Operators.CompareString(chengbar, "10", TextCompare: false) == 0)
			{
				COM1ProgressBar1.Increment(25);
				ProgressChanged = Conversions.ToString(COM2ProgressBar1.Value);
				COM2ProgressBar1.Text = ProgressChanged + "%";
			}
			if (Operators.CompareString(chengbar, "10", TextCompare: false) == 0)
			{
				COM1ProgressBar1.Increment(25);
				ProgressChanged = Conversions.ToString(COM3ProgressBar1.Value);
				COM3ProgressBar1.Text = ProgressChanged + "%";
			}
		}
		if (Operators.CompareString(TextBox4.Text, "4", TextCompare: false) == 0)
		{
			if (Operators.CompareString(chengbar, "10", TextCompare: false) == 0)
			{
				COM1ProgressBar1.Increment(25);
				ProgressChanged = Conversions.ToString(COM1ProgressBar1.Value);
				COM1ProgressBar1.Text = ProgressChanged + "%";
			}
			if (Operators.CompareString(chengbar, "10", TextCompare: false) == 0)
			{
				COM1ProgressBar1.Increment(25);
				ProgressChanged = Conversions.ToString(COM2ProgressBar1.Value);
				COM2ProgressBar1.Text = ProgressChanged + "%";
			}
			if (Operators.CompareString(chengbar, "10", TextCompare: false) == 0)
			{
				COM1ProgressBar1.Increment(25);
				ProgressChanged = Conversions.ToString(COM3ProgressBar1.Value);
				COM3ProgressBar1.Text = ProgressChanged + "%";
			}
			if (Operators.CompareString(chengbar, "10", TextCompare: false) == 0)
			{
				COM1ProgressBar1.Increment(25);
				ProgressChanged = Conversions.ToString(COM4ProgressBar1.Value);
				COM4ProgressBar1.Text = ProgressChanged + "%";
			}
		}
	}

	private void Timer2_Tick(object sender, EventArgs e)
	{
		if (Operators.CompareString(TextBox4.Text, "1", TextCompare: false) == 0 && Operators.CompareString(chengbar, "12", TextCompare: false) == 0)
		{
			COM1ProgressBar1.Increment(1);
			ProgressChanged = Conversions.ToString(COM1ProgressBar1.Value);
			COM1ProgressBar1.Text = ProgressChanged + "%";
		}
		if (Operators.CompareString(TextBox4.Text, "2", TextCompare: false) == 0)
		{
			if (Operators.CompareString(chengbar, "12", TextCompare: false) == 0)
			{
				COM1ProgressBar1.Increment(1);
				ProgressChanged = Conversions.ToString(COM1ProgressBar1.Value);
				COM1ProgressBar1.Text = ProgressChanged + "%";
			}
			if (Operators.CompareString(chengbar, "12", TextCompare: false) == 0)
			{
				COM2ProgressBar1.Increment(1);
				ProgressChanged = Conversions.ToString(COM2ProgressBar1.Value);
				COM2ProgressBar1.Text = ProgressChanged + "%";
			}
		}
		if (Operators.CompareString(TextBox4.Text, "3", TextCompare: false) == 0)
		{
			if (Operators.CompareString(chengbar, "12", TextCompare: false) == 0)
			{
				COM1ProgressBar1.Increment(1);
				ProgressChanged = Conversions.ToString(COM1ProgressBar1.Value);
				COM1ProgressBar1.Text = ProgressChanged + "%";
			}
			if (Operators.CompareString(chengbar, "12", TextCompare: false) == 0)
			{
				COM2ProgressBar1.Increment(1);
				ProgressChanged = Conversions.ToString(COM2ProgressBar1.Value);
				COM2ProgressBar1.Text = ProgressChanged + "%";
			}
			if (Operators.CompareString(chengbar, "12", TextCompare: false) == 0)
			{
				COM3ProgressBar1.Increment(1);
				ProgressChanged = Conversions.ToString(COM3ProgressBar1.Value);
				COM3ProgressBar1.Text = ProgressChanged + "%";
			}
		}
		if (Operators.CompareString(TextBox4.Text, "4", TextCompare: false) == 0)
		{
			if (Operators.CompareString(chengbar, "12", TextCompare: false) == 0)
			{
				COM1ProgressBar1.Increment(1);
				ProgressChanged = Conversions.ToString(COM1ProgressBar1.Value);
				COM1ProgressBar1.Text = ProgressChanged + "%";
			}
			if (Operators.CompareString(chengbar, "12", TextCompare: false) == 0)
			{
				COM2ProgressBar1.Increment(1);
				ProgressChanged = Conversions.ToString(COM2ProgressBar1.Value);
				COM2ProgressBar1.Text = ProgressChanged + "%";
			}
			if (Operators.CompareString(chengbar, "12", TextCompare: false) == 0)
			{
				COM3ProgressBar1.Increment(1);
				ProgressChanged = Conversions.ToString(COM3ProgressBar1.Value);
				COM3ProgressBar1.Text = ProgressChanged + "%";
			}
			if (Operators.CompareString(chengbar, "12", TextCompare: false) == 0)
			{
				COM4ProgressBar1.Increment(1);
				ProgressChanged = Conversions.ToString(COM4ProgressBar1.Value);
				COM4ProgressBar1.Text = ProgressChanged + "%";
			}
		}
	}

	private void Guna2CheckBox4_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void flash_Load(object sender, EventArgs e)
	{
	}

	private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void Guna2Button9_Click(object sender, EventArgs e)
	{
		FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog
		{
			ShowNewFolderButton = true
		};
		if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
		{
			string text = ((!Directory.Exists(folderBrowserDialog.SelectedPath + "\\images")) ? folderBrowserDialog.SelectedPath : (folderBrowserDialog.SelectedPath + "\\images"));
			txtrawxml.Text = text;
		}
	}

	private void Guna2Button13_Click(object sender, EventArgs e)
	{
		try
		{
			OpenFileDialog openFileDialog = new OpenFileDialog
			{
				Title = "Select Flash File !",
				Filter = "flashfile.xml  |*.xml"
			};
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				DataGridFlash.Rows.Clear();
				txtrawxml.Text = openFileDialog.FileName;
				LoadFolderXml = openFileDialog.FileName.Replace("flashfile.xml", "");
				LoadXmlFolder(openFileDialog.FileName);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private long GetFileSize(string filePath)
	{
		return new FileInfo(filePath).Length;
	}

	private string FormatFileSize(long fileSize)
	{
		if (fileSize >= 1073741824)
		{
			return ((double)fileSize / 1073741824.0).ToString("F2") + " GB";
		}
		if (fileSize >= 1048576)
		{
			return ((double)fileSize / 1048576.0).ToString("F2") + " MB";
		}
		if (fileSize >= 1024)
		{
			return ((double)fileSize / 1024.0).ToString("F2") + " KB";
		}
		return Conversions.ToString(fileSize) + " Bytes";
	}

	private void LoadXmlFolder(string xml)
	{
		XmlReader xmlReader = XmlReader.Create(xml);
		while (xmlReader.Read())
		{
			string text = null;
			string text2 = null;
			long num = 0L;
			if (xmlReader.NodeType != XmlNodeType.Element || Operators.CompareString(xmlReader.Name, "step", TextCompare: false) != 0)
			{
				continue;
			}
			if (Operators.CompareString(xmlReader.GetAttribute("operation"), "flash", TextCompare: false) == 0)
			{
				if (File.Exists(LoadFolderXml + xmlReader.GetAttribute("filename")))
				{
					text = LoadFolderXml + xmlReader.GetAttribute("filename");
					num = GetFileSize(text);
					text2 = FormatFileSize(num);
				}
				else
				{
					text = "Double Click For Add File";
					text2 = "";
				}
			}
			if (Operators.CompareString(xmlReader.GetAttribute("operation"), "oem", TextCompare: false) != 0 && Operators.CompareString(text, "Double Click For Add File", TextCompare: false) != 0)
			{
				DataGridFlash.Rows.Add(false, xmlReader.GetAttribute("operation"), xmlReader.GetAttribute("partition"), text, text2);
			}
		}
	}

	private void Guna2Button10_Click(object sender, EventArgs e)
	{
	}
}
