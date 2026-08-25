using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Media;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using libcurl.cdmaDevLib;
using libeay32.Device;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;
using motoulocked.Controls;
using motoulocked.motoulocked;
using motoulocked.My;
using Properties;

namespace motoulocked;

[DesignerGenerated]
public class Services_Network : Form
{
	private IContainer components;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2Button8")]
	private Guna2Button _Guna2Button8;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2Button3")]
	private Guna2Button _Guna2Button3;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2Button2")]
	private Guna2Button _Guna2Button2;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2Button1")]
	private Guna2Button _Guna2Button1;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2Button12")]
	private Guna2Button _Guna2Button12;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2Button13")]
	private Guna2Button _Guna2Button13;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2Button11")]
	private Guna2Button _Guna2Button11;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2Button7")]
	private Guna2Button _Guna2Button7;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2Button6")]
	private Guna2Button _Guna2Button6;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2Button5")]
	private Guna2Button _Guna2Button5;

	[CompilerGenerated]
	[AccessedThroughProperty("Timer10")]
	private System.Windows.Forms.Timer _Timer10;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2Button16")]
	private Guna2Button _Guna2Button16;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2Button14")]
	private Guna2Button _Guna2Button14;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2Button15")]
	private Guna2Button _Guna2Button15;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2Button18")]
	private Guna2Button _Guna2Button18;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2Button10")]
	private Guna2Button _Guna2Button10;

	[CompilerGenerated]
	[AccessedThroughProperty("Timer1")]
	private System.Windows.Forms.Timer _Timer1;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2ComboBox1")]
	private Guna2ComboBox _Guna2ComboBox1;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2Button9")]
	private Guna2Button _Guna2Button9;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2Button40")]
	private Guna2Button _Guna2Button40;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2Button48")]
	private Guna2Button _Guna2Button48;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2Button22")]
	private Guna2Button _Guna2Button22;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2Button21")]
	private Guna2Button _Guna2Button21;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2Button19")]
	private Guna2Button _Guna2Button19;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2Button17")]
	private Guna2Button _Guna2Button17;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2Button4")]
	private Guna2Button _Guna2Button4;

	public static string cancel;

	private string idproos;

	private string ProgressChanged;

	private string ThisLocation;

	private string TextBox10;

	private string TextBox41;

	private string serialnmber;

	private string security_patch;

	private string baseband;

	private string build_id;

	private string usb_config;

	private string sim_state;

	private string csc;

	private string sales_code;

	private string knox;

	private string Label15;

	private bool DownloadFileCompleted;

	private string link;

	private string Label4;

	private string QcomString;

	private string Label9;

	private string Name_Com;

	private string tmpWinrarr;

	private int cost;

	private string IMEI;

	private string MEID;

	private string tmp;

	private int nembr_com;

	private string Method;

	private int Putsseva;

	private string namefile;

	private string Carrierboxstring;

	private string Carrierboxcheckstring;

	private string NameFile4G;

	private string compareOkNotString;

	private string string_13;

	private SaveFileDialog saveFileDialog;

	private OpenFileDialog openFileDialog;

	private string Count;

	private string a;

	private Thread ThreadNew;

	private string NameConfig;

	public string startTime;

	public static Services_Network SharedUI;
    /*
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

	[field: AccessedThroughProperty("Temp_Credits")]
	internal  TextBox Temp_Credits
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	internal  Guna2Button Guna2Button11
	{
		[CompilerGenerated]
		get
		{
			return _Guna2Button11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Guna2Button11_Click;
			Guna2Button guna2Button = _Guna2Button11;
			if (guna2Button != null)
			{
				guna2Button.Click -= value2;
			}
			_Guna2Button11 = value;
			guna2Button = _Guna2Button11;
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

	[field: AccessedThroughProperty("Guna2TaskBarProgress1")]
	internal  Guna2TaskBarProgress Guna2TaskBarProgress1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Guna2CheckBox1")]
	internal  Guna2CheckBox Guna2CheckBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CheckBox2")]
	internal  Guna2CheckBox CheckBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("serialno")]
	internal  TextBox serialno
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal  System.Windows.Forms.Timer Timer10
	{
		[CompilerGenerated]
		get
		{
			return _Timer10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Timer10_Tick;
			System.Windows.Forms.Timer timer = _Timer10;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_Timer10 = value;
			timer = _Timer10;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	[field: AccessedThroughProperty("PictureBox2")]
	internal  PictureBox PictureBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal  Guna2Button Guna2Button16
	{
		[CompilerGenerated]
		get
		{
			return _Guna2Button16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Guna2Button16_Click;
			Guna2Button guna2Button = _Guna2Button16;
			if (guna2Button != null)
			{
				guna2Button.Click -= value2;
			}
			_Guna2Button16 = value;
			guna2Button = _Guna2Button16;
			if (guna2Button != null)
			{
				guna2Button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("RichTextBox2")]
	internal  RichTextBox RichTextBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox33")]
	internal  TextBox TextBox33
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

	[field: AccessedThroughProperty("SaveFileDialog1")]
	internal  SaveFileDialog SaveFileDialog1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Guna2MessageDialog1")]
	internal  Guna2MessageDialog Guna2MessageDialog1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Guna2CheckBox2")]
	internal  Guna2CheckBox Guna2CheckBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal  Guna2Button Guna2Button14
	{
		[CompilerGenerated]
		get
		{
			return _Guna2Button14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Guna2Button14_Click;
			Guna2Button guna2Button = _Guna2Button14;
			if (guna2Button != null)
			{
				guna2Button.Click -= value2;
			}
			_Guna2Button14 = value;
			guna2Button = _Guna2Button14;
			if (guna2Button != null)
			{
				guna2Button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("SerialPort1")]
	internal  SerialPort SerialPort1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox4")]
	internal  TextBox TextBox4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal  Guna2Button Guna2Button15
	{
		[CompilerGenerated]
		get
		{
			return _Guna2Button15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Guna2Button15_Click;
			Guna2Button guna2Button = _Guna2Button15;
			if (guna2Button != null)
			{
				guna2Button.Click -= value2;
			}
			_Guna2Button15 = value;
			guna2Button = _Guna2Button15;
			if (guna2Button != null)
			{
				guna2Button.Click += value2;
			}
		}
	}

	internal  Guna2Button Guna2Button18
	{
		[CompilerGenerated]
		get
		{
			return _Guna2Button18;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Guna2Button18_Click;
			Guna2Button guna2Button = _Guna2Button18;
			if (guna2Button != null)
			{
				guna2Button.Click -= value2;
			}
			_Guna2Button18 = value;
			guna2Button = _Guna2Button18;
			if (guna2Button != null)
			{
				guna2Button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("txtqcn")]
	internal  Guna2TextBox txtqcn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	[field: AccessedThroughProperty("text3")]
	internal  TextBox text3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Carrierbox")]
	internal  RichTextBox Carrierbox
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

	[field: AccessedThroughProperty("Guna2GroupBox1")]
	internal  Guna2GroupBox Guna2GroupBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CKAUTO_CONN")]
	internal  Guna2CheckBox CKAUTO_CONN
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal  Guna2ComboBox Guna2ComboBox1
	{
		[CompilerGenerated]
		get
		{
			return _Guna2ComboBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Guna2ComboBox1_Click;
			Guna2ComboBox guna2ComboBox = _Guna2ComboBox1;
			if (guna2ComboBox != null)
			{
				guna2ComboBox.Click -= value2;
			}
			_Guna2ComboBox1 = value;
			guna2ComboBox = _Guna2ComboBox1;
			if (guna2ComboBox != null)
			{
				guna2ComboBox.Click += value2;
			}
		}
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

	[field: AccessedThroughProperty("RichTextBox1")]
	internal  RichTextBox RichTextBox1
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

	internal  Guna2Button Guna2Button40
	{
		[CompilerGenerated]
		get
		{
			return _Guna2Button40;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Guna2Button40_Click;
			Guna2Button guna2Button = _Guna2Button40;
			if (guna2Button != null)
			{
				guna2Button.Click -= value2;
			}
			_Guna2Button40 = value;
			guna2Button = _Guna2Button40;
			if (guna2Button != null)
			{
				guna2Button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Guna2GroupBox3")]
	internal  Guna2GroupBox Guna2GroupBox3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Guna2RadioButton2")]
	internal  Guna2RadioButton Guna2RadioButton2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Guna2RadioButton1")]
	internal  Guna2RadioButton Guna2RadioButton1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Guna2RadioButton4")]
	internal  Guna2RadioButton Guna2RadioButton4
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

	internal  Guna2Button Guna2Button48
	{
		[CompilerGenerated]
		get
		{
			return _Guna2Button48;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Guna2Button48_Click;
			Guna2Button guna2Button = _Guna2Button48;
			if (guna2Button != null)
			{
				guna2Button.Click -= value2;
			}
			_Guna2Button48 = value;
			guna2Button = _Guna2Button48;
			if (guna2Button != null)
			{
				guna2Button.Click += value2;
			}
		}
	}

	internal  Guna2Button Guna2Button22
	{
		[CompilerGenerated]
		get
		{
			return _Guna2Button22;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Guna2Button22_Click;
			Guna2Button guna2Button = _Guna2Button22;
			if (guna2Button != null)
			{
				guna2Button.Click -= value2;
			}
			_Guna2Button22 = value;
			guna2Button = _Guna2Button22;
			if (guna2Button != null)
			{
				guna2Button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Guna2RadioButton16")]
	internal  Guna2RadioButton Guna2RadioButton16
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Guna2RadioButton17")]
	internal  Guna2RadioButton Guna2RadioButton17
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Guna2RadioButton18")]
	internal  Guna2RadioButton Guna2RadioButton18
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Guna2RadioButton19")]
	internal  Guna2RadioButton Guna2RadioButton19
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Guna2RadioButton20")]
	internal  Guna2RadioButton Guna2RadioButton20
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Guna2RadioButton13")]
	internal  Guna2RadioButton Guna2RadioButton13
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Guna2RadioButton14")]
	internal  Guna2RadioButton Guna2RadioButton14
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Guna2RadioButton15")]
	internal  Guna2RadioButton Guna2RadioButton15
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Guna2RadioButton10")]
	internal  Guna2RadioButton Guna2RadioButton10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Guna2RadioButton11")]
	internal  Guna2RadioButton Guna2RadioButton11
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Guna2RadioButton12")]
	internal  Guna2RadioButton Guna2RadioButton12
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Guna2RadioButton7")]
	internal  Guna2RadioButton Guna2RadioButton7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Guna2RadioButton8")]
	internal  Guna2RadioButton Guna2RadioButton8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Guna2RadioButton9")]
	internal  Guna2RadioButton Guna2RadioButton9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Guna2RadioButton3")]
	internal  Guna2RadioButton Guna2RadioButton3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Guna2RadioButton5")]
	internal  Guna2RadioButton Guna2RadioButton5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Guna2RadioButton6")]
	internal  Guna2RadioButton Guna2RadioButton6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal  Guna2Button Guna2Button21
	{
		[CompilerGenerated]
		get
		{
			return _Guna2Button21;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Guna2Button21_Click;
			Guna2Button guna2Button = _Guna2Button21;
			if (guna2Button != null)
			{
				guna2Button.Click -= value2;
			}
			_Guna2Button21 = value;
			guna2Button = _Guna2Button21;
			if (guna2Button != null)
			{
				guna2Button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label3")]
	internal  Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Guna2GroupBox7")]
	internal  Guna2GroupBox Guna2GroupBox7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal  Guna2Button Guna2Button19
	{
		[CompilerGenerated]
		get
		{
			return _Guna2Button19;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Guna2Button19_Click;
			Guna2Button guna2Button = _Guna2Button19;
			if (guna2Button != null)
			{
				guna2Button.Click -= value2;
			}
			_Guna2Button19 = value;
			guna2Button = _Guna2Button19;
			if (guna2Button != null)
			{
				guna2Button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Guna2RadioButton26")]
	internal  Guna2RadioButton Guna2RadioButton26
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label2")]
	internal  Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Guna2RadioButton23")]
	internal  Guna2RadioButton Guna2RadioButton23
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Guna2RadioButton24")]
	internal  Guna2RadioButton Guna2RadioButton24
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Guna2RadioButton21")]
	internal  Guna2RadioButton Guna2RadioButton21
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Guna2RadioButton22")]
	internal  Guna2RadioButton Guna2RadioButton22
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Guna2RadioButton25")]
	internal  Guna2RadioButton Guna2RadioButton25
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Guna2RadioButton27")]
	internal  Guna2RadioButton Guna2RadioButton27
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

	[field: AccessedThroughProperty("TabPage3")]
	internal  TabPage TabPage3
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

	internal  Guna2Button Guna2Button17
	{
		[CompilerGenerated]
		get
		{
			return _Guna2Button17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Guna2Button17_Click;
			Guna2Button guna2Button = _Guna2Button17;
			if (guna2Button != null)
			{
				guna2Button.Click -= value2;
			}
			_Guna2Button17 = value;
			guna2Button = _Guna2Button17;
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

	[field: AccessedThroughProperty("TabPage1")]
	internal  TabPage TabPage1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Guna2RadioButton29")]
	internal  Guna2RadioButton Guna2RadioButton29
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Guna2RadioButton30")]
	internal  Guna2RadioButton Guna2RadioButton30
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Guna2RadioButton28")]
	internal  Guna2RadioButton Guna2RadioButton28
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}
	*/
    internal Guna2Button Guna2Button8;
    internal TextBox Temp_Credits;
    internal Guna2Button Guna2Button3;
    internal Guna2Button Guna2Button2;
    internal Guna2Button Guna2Button1;
    internal Guna2Button Guna2Button12;
    internal Guna2Button Guna2Button13;
    internal Guna2Button Guna2Button11;
    internal Guna2Button Guna2Button7;
    internal Guna2Button Guna2Button6;
    internal Guna2Button Guna2Button5;
    internal Guna2TaskBarProgress Guna2TaskBarProgress1;
    internal Guna2CheckBox Guna2CheckBox1;
    internal Guna2CheckBox CheckBox2;
    internal TextBox serialno;
    internal System.Windows.Forms.Timer Timer10;
    internal PictureBox PictureBox2;
    internal Guna2Button Guna2Button16;
    internal RichTextBox RichTextBox2;
    internal TextBox TextBox33;
    internal ComboBox ComboBox1;
    internal SaveFileDialog SaveFileDialog1;
    internal Guna2MessageDialog Guna2MessageDialog1;
    internal Guna2CheckBox Guna2CheckBox2;
    internal Guna2Button Guna2Button14;
    internal SerialPort SerialPort1;
    internal TextBox TextBox4;
    internal Guna2Button Guna2Button15;
    internal Guna2Button Guna2Button18;
    internal Guna2TextBox txtqcn;
    internal Guna2Button Guna2Button10;
    internal System.Windows.Forms.Timer Timer1;
    internal TextBox text3;
    internal RichTextBox Carrierbox;
    internal Guna2GroupBox Guna2GroupBox2;
    internal Guna2GroupBox Guna2GroupBox1;
    internal Guna2CheckBox CKAUTO_CONN;
    internal Guna2ComboBox Guna2ComboBox1;
    internal Guna2Button Guna2Button9;
    internal RichTextBox RichTextBox1;
    internal Guna2GroupBox Guna2GroupBox4;
    internal Guna2Button Guna2Button40;
    internal Guna2GroupBox Guna2GroupBox3;
    internal Guna2RadioButton Guna2RadioButton2;
    internal Guna2RadioButton Guna2RadioButton1;
    internal Guna2RadioButton Guna2RadioButton4;
    internal Guna2GroupBox Guna2GroupBox5;
    internal Guna2Button Guna2Button48;
    internal Guna2Button Guna2Button22;
    internal Guna2RadioButton Guna2RadioButton16;
    internal Guna2RadioButton Guna2RadioButton17;
    internal Guna2RadioButton Guna2RadioButton18;
    internal Guna2RadioButton Guna2RadioButton19;
    internal Guna2RadioButton Guna2RadioButton20;
    internal Guna2RadioButton Guna2RadioButton13;
    internal Guna2RadioButton Guna2RadioButton14;
    internal Guna2RadioButton Guna2RadioButton15;
    internal Guna2RadioButton Guna2RadioButton10;
    internal Guna2RadioButton Guna2RadioButton11;
    internal Guna2RadioButton Guna2RadioButton12;
    internal Guna2RadioButton Guna2RadioButton7;
    internal Guna2RadioButton Guna2RadioButton8;
    internal Guna2RadioButton Guna2RadioButton9;
    internal Guna2RadioButton Guna2RadioButton3;
    internal Guna2RadioButton Guna2RadioButton5;
    internal Guna2RadioButton Guna2RadioButton6;
    internal Guna2Button Guna2Button21;
    internal Label Label3;
    internal Guna2GroupBox Guna2GroupBox7;
    internal Guna2Button Guna2Button19;
    internal Guna2RadioButton Guna2RadioButton26;
    internal Label Label2;
    internal Guna2RadioButton Guna2RadioButton23;
    internal Guna2RadioButton Guna2RadioButton24;
    internal Guna2RadioButton Guna2RadioButton21;
    internal Guna2RadioButton Guna2RadioButton22;
    internal Guna2RadioButton Guna2RadioButton25;
    internal Guna2RadioButton Guna2RadioButton27;
    internal motoulocked.Controls.TabControlExt TabControlExt1;
    internal TabPage TabPage2;
    internal TabPage TabPage3;
    internal TabPage TabPage4;
    internal Guna2Button Guna2Button17;
    internal Guna2Button Guna2Button4;
    internal TabPage TabPage1;
    internal Guna2RadioButton Guna2RadioButton29;
    internal Guna2RadioButton Guna2RadioButton30;
    internal Guna2RadioButton Guna2RadioButton28;

    public static string ProgressBa { get; set; }

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Services_Network));
            this.TextBox4 = new System.Windows.Forms.TextBox();
            this.TextBox33 = new System.Windows.Forms.TextBox();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.RichTextBox2 = new System.Windows.Forms.RichTextBox();
            this.serialno = new System.Windows.Forms.TextBox();
            this.txtqcn = new Guna.UI2.WinForms.Guna2TextBox();
            this.Guna2CheckBox2 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.Guna2CheckBox1 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.CheckBox2 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.Temp_Credits = new System.Windows.Forms.TextBox();
            this.Guna2TaskBarProgress1 = new Guna.UI2.WinForms.Guna2TaskBarProgress(this.components);
            this.Timer10 = new System.Windows.Forms.Timer(this.components);
            this.SaveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Guna2MessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.SerialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.text3 = new System.Windows.Forms.TextBox();
            this.Carrierbox = new System.Windows.Forms.RichTextBox();
            this.Guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.Guna2Button8 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2Button14 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2Button16 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2Button7 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2Button15 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2Button11 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2Button18 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2Button13 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2Button10 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2Button12 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2Button22 = new Guna.UI2.WinForms.Guna2Button();
            this.RichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.Guna2Button17 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2Button9 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.CKAUTO_CONN = new Guna.UI2.WinForms.Guna2CheckBox();
            this.Guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.Guna2RadioButton29 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.Guna2RadioButton30 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.Guna2RadioButton28 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.Guna2RadioButton23 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.Guna2Button21 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2RadioButton24 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.Guna2RadioButton15 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.Guna2RadioButton21 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.Guna2RadioButton14 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.Guna2RadioButton22 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.Guna2RadioButton10 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.Guna2RadioButton11 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.Label3 = new System.Windows.Forms.Label();
            this.Guna2RadioButton13 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.Guna2RadioButton7 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.Guna2RadioButton12 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.Guna2RadioButton20 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.Guna2GroupBox7 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.Guna2RadioButton27 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.Guna2RadioButton25 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.Guna2Button19 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2RadioButton26 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.Label2 = new System.Windows.Forms.Label();
            this.Guna2RadioButton6 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.Guna2RadioButton16 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.Guna2RadioButton8 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.Guna2RadioButton17 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.Guna2RadioButton9 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.Guna2RadioButton18 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.Guna2RadioButton5 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.Guna2RadioButton19 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.Guna2RadioButton3 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.Guna2GroupBox5 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.Guna2Button48 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2GroupBox4 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.Guna2RadioButton2 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.Guna2RadioButton1 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.Guna2RadioButton4 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.Guna2Button40 = new Guna.UI2.WinForms.Guna2Button();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.TabControlExt1 = new motoulocked.Controls.TabControlExt();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.TabPage3 = new System.Windows.Forms.TabPage();
            this.TabPage4 = new System.Windows.Forms.TabPage();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.Guna2GroupBox2.SuspendLayout();
            this.Guna2GroupBox1.SuspendLayout();
            this.Guna2GroupBox3.SuspendLayout();
            this.Guna2GroupBox7.SuspendLayout();
            this.Guna2GroupBox5.SuspendLayout();
            this.Guna2GroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.TabControlExt1.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.TabPage3.SuspendLayout();
            this.TabPage4.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBox4
            // 
            this.TextBox4.Location = new System.Drawing.Point(938, 555);
            this.TextBox4.Name = "TextBox4";
            this.TextBox4.Size = new System.Drawing.Size(10, 20);
            this.TextBox4.TabIndex = 479;
            this.TextBox4.Visible = false;
            // 
            // TextBox33
            // 
            this.TextBox33.Location = new System.Drawing.Point(919, 658);
            this.TextBox33.Name = "TextBox33";
            this.TextBox33.Size = new System.Drawing.Size(10, 20);
            this.TextBox33.TabIndex = 464;
            this.TextBox33.Visible = false;
            // 
            // ComboBox1
            // 
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Location = new System.Drawing.Point(927, 654);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(10, 21);
            this.ComboBox1.TabIndex = 463;
            this.ComboBox1.Visible = false;
            // 
            // RichTextBox2
            // 
            this.RichTextBox2.Location = new System.Drawing.Point(965, 652);
            this.RichTextBox2.Name = "RichTextBox2";
            this.RichTextBox2.Size = new System.Drawing.Size(10, 20);
            this.RichTextBox2.TabIndex = 462;
            this.RichTextBox2.Text = "";
            // 
            // serialno
            // 
            this.serialno.Location = new System.Drawing.Point(943, 678);
            this.serialno.Name = "serialno";
            this.serialno.Size = new System.Drawing.Size(10, 20);
            this.serialno.TabIndex = 299;
            this.serialno.Visible = false;
            // 
            // txtqcn
            // 
            this.txtqcn.Animated = true;
            this.txtqcn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtqcn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.txtqcn.BorderRadius = 5;
            this.txtqcn.BorderThickness = 2;
            this.txtqcn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtqcn.DefaultText = "";
            this.txtqcn.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtqcn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtqcn.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.txtqcn.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtqcn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txtqcn.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtqcn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqcn.ForeColor = System.Drawing.Color.White;
            this.txtqcn.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.txtqcn.Location = new System.Drawing.Point(56, 351);
            this.txtqcn.Name = "txtqcn";
            this.txtqcn.PasswordChar = '\0';
            this.txtqcn.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtqcn.PlaceholderText = "QCN File";
            this.txtqcn.SelectedText = "";
            this.txtqcn.ShadowDecoration.Color = System.Drawing.Color.DimGray;
            this.txtqcn.ShadowDecoration.Depth = 15;
            this.txtqcn.Size = new System.Drawing.Size(261, 32);
            this.txtqcn.TabIndex = 494;
            this.txtqcn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtqcn.TextChanged += new System.EventHandler(this.txtqcn_TextChanged);
            // 
            // Guna2CheckBox2
            // 
            this.Guna2CheckBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Guna2CheckBox2.Animated = true;
            this.Guna2CheckBox2.AutoSize = true;
            this.Guna2CheckBox2.Checked = true;
            this.Guna2CheckBox2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2CheckBox2.CheckedState.BorderRadius = 4;
            this.Guna2CheckBox2.CheckedState.BorderThickness = 2;
            this.Guna2CheckBox2.CheckedState.FillColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Guna2CheckBox2.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2CheckBox2.ForeColor = System.Drawing.Color.White;
            this.Guna2CheckBox2.Location = new System.Drawing.Point(518, 40);
            this.Guna2CheckBox2.Name = "Guna2CheckBox2";
            this.Guna2CheckBox2.Size = new System.Drawing.Size(108, 21);
            this.Guna2CheckBox2.TabIndex = 478;
            this.Guna2CheckBox2.Text = " Auto Up PRL";
            this.Guna2CheckBox2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2CheckBox2.UncheckedState.BorderRadius = 3;
            this.Guna2CheckBox2.UncheckedState.BorderThickness = 1;
            this.Guna2CheckBox2.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2CheckBox2.Visible = false;
            // 
            // Guna2CheckBox1
            // 
            this.Guna2CheckBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Guna2CheckBox1.Animated = true;
            this.Guna2CheckBox1.AutoSize = true;
            this.Guna2CheckBox1.Checked = true;
            this.Guna2CheckBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2CheckBox1.CheckedState.BorderRadius = 4;
            this.Guna2CheckBox1.CheckedState.BorderThickness = 2;
            this.Guna2CheckBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Guna2CheckBox1.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2CheckBox1.ForeColor = System.Drawing.Color.White;
            this.Guna2CheckBox1.Location = new System.Drawing.Point(348, 5);
            this.Guna2CheckBox1.Name = "Guna2CheckBox1";
            this.Guna2CheckBox1.Size = new System.Drawing.Size(109, 21);
            this.Guna2CheckBox1.TabIndex = 473;
            this.Guna2CheckBox1.Text = " Auto Reboot";
            this.Guna2CheckBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2CheckBox1.UncheckedState.BorderRadius = 3;
            this.Guna2CheckBox1.UncheckedState.BorderThickness = 1;
            this.Guna2CheckBox1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2CheckBox1.CheckedChanged += new System.EventHandler(this.Guna2CheckBox1_CheckedChanged);
            // 
            // CheckBox2
            // 
            this.CheckBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CheckBox2.Animated = true;
            this.CheckBox2.AutoSize = true;
            this.CheckBox2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.CheckBox2.CheckedState.BorderRadius = 4;
            this.CheckBox2.CheckedState.BorderThickness = 2;
            this.CheckBox2.CheckedState.FillColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.CheckBox2.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBox2.ForeColor = System.Drawing.Color.White;
            this.CheckBox2.Location = new System.Drawing.Point(242, 5);
            this.CheckBox2.Name = "CheckBox2";
            this.CheckBox2.Size = new System.Drawing.Size(104, 21);
            this.CheckBox2.TabIndex = 472;
            this.CheckBox2.Text = " Auto Set 3G";
            this.CheckBox2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.CheckBox2.UncheckedState.BorderRadius = 3;
            this.CheckBox2.UncheckedState.BorderThickness = 1;
            this.CheckBox2.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.CheckBox2.CheckedChanged += new System.EventHandler(this.CheckBox2_CheckedChanged);
            // 
            // Temp_Credits
            // 
            this.Temp_Credits.Location = new System.Drawing.Point(909, 671);
            this.Temp_Credits.Name = "Temp_Credits";
            this.Temp_Credits.Size = new System.Drawing.Size(10, 20);
            this.Temp_Credits.TabIndex = 229;
            this.Temp_Credits.Text = "0";
            this.Temp_Credits.Visible = false;
            // 
            // Guna2TaskBarProgress1
            // 
            this.Guna2TaskBarProgress1.TargetForm = this;
            // 
            // Timer10
            // 
            this.Timer10.Enabled = true;
            this.Timer10.Interval = 500;
            // 
            // Guna2MessageDialog1
            // 
            this.Guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.Guna2MessageDialog1.Caption = null;
            this.Guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.Guna2MessageDialog1.Parent = null;
            this.Guna2MessageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.Guna2MessageDialog1.Text = null;
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            // 
            // text3
            // 
            this.text3.Location = new System.Drawing.Point(443, -22);
            this.text3.Name = "text3";
            this.text3.Size = new System.Drawing.Size(10, 20);
            this.text3.TabIndex = 495;
            this.text3.Visible = false;
            // 
            // Carrierbox
            // 
            this.Carrierbox.Location = new System.Drawing.Point(482, -16);
            this.Carrierbox.Name = "Carrierbox";
            this.Carrierbox.Size = new System.Drawing.Size(10, 10);
            this.Carrierbox.TabIndex = 496;
            this.Carrierbox.Text = "";
            // 
            // Guna2GroupBox2
            // 
            this.Guna2GroupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Guna2GroupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2GroupBox2.BorderRadius = 6;
            this.Guna2GroupBox2.Controls.Add(this.Guna2Button8);
            this.Guna2GroupBox2.Controls.Add(this.Guna2Button14);
            this.Guna2GroupBox2.Controls.Add(this.Guna2Button6);
            this.Guna2GroupBox2.Controls.Add(this.Guna2Button5);
            this.Guna2GroupBox2.Controls.Add(this.Guna2Button16);
            this.Guna2GroupBox2.Controls.Add(this.Guna2Button7);
            this.Guna2GroupBox2.Controls.Add(this.Guna2Button15);
            this.Guna2GroupBox2.Controls.Add(this.Guna2Button4);
            this.Guna2GroupBox2.Controls.Add(this.Guna2Button11);
            this.Guna2GroupBox2.Controls.Add(this.Guna2Button18);
            this.Guna2GroupBox2.Controls.Add(this.txtqcn);
            this.Guna2GroupBox2.Controls.Add(this.Guna2Button3);
            this.Guna2GroupBox2.Controls.Add(this.Guna2Button1);
            this.Guna2GroupBox2.Controls.Add(this.Guna2Button13);
            this.Guna2GroupBox2.Controls.Add(this.Guna2Button10);
            this.Guna2GroupBox2.Controls.Add(this.Guna2Button12);
            this.Guna2GroupBox2.Controls.Add(this.Guna2Button2);
            this.Guna2GroupBox2.Controls.Add(this.Guna2Button22);
            this.Guna2GroupBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2GroupBox2.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.Guna2GroupBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Guna2GroupBox2.Location = new System.Drawing.Point(8, 83);
            this.Guna2GroupBox2.Name = "Guna2GroupBox2";
            this.Guna2GroupBox2.ShadowDecoration.BorderRadius = 9;
            this.Guna2GroupBox2.ShadowDecoration.Color = System.Drawing.Color.White;
            this.Guna2GroupBox2.ShadowDecoration.Depth = 15;
            this.Guna2GroupBox2.Size = new System.Drawing.Size(465, 392);
            this.Guna2GroupBox2.TabIndex = 520;
            // 
            // Guna2Button8
            // 
            this.Guna2Button8.Animated = true;
            this.Guna2Button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2Button8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2Button8.BorderRadius = 4;
            this.Guna2Button8.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.Guna2Button8.BorderThickness = 2;
            this.Guna2Button8.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button8.CheckedState.FillColor = System.Drawing.Color.LightGray;
            this.Guna2Button8.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button8.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
            this.Guna2Button8.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button8.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.Guna2Button8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2Button8.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Guna2Button8.ForeColor = System.Drawing.Color.White;
            this.Guna2Button8.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button8.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button8.Image = global::Properties.Resources.info__1_;
            this.Guna2Button8.Location = new System.Drawing.Point(9, 10);
            this.Guna2Button8.Name = "Guna2Button8";
            this.Guna2Button8.PressedColor = System.Drawing.Color.Empty;
            this.Guna2Button8.Size = new System.Drawing.Size(448, 32);
            this.Guna2Button8.TabIndex = 441;
            this.Guna2Button8.Text = "Read Info";
            this.Guna2Button8.TextFormatNoPrefix = true;
            this.Guna2Button8.Click += new System.EventHandler(this.Guna2Button8_Click);
            // 
            // Guna2Button14
            // 
            this.Guna2Button14.Animated = true;
            this.Guna2Button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2Button14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2Button14.BorderRadius = 4;
            this.Guna2Button14.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.Guna2Button14.BorderThickness = 2;
            this.Guna2Button14.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button14.CheckedState.FillColor = System.Drawing.Color.LightGray;
            this.Guna2Button14.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button14.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
            this.Guna2Button14.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button14.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.Guna2Button14.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2Button14.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Guna2Button14.ForeColor = System.Drawing.Color.White;
            this.Guna2Button14.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button14.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button14.Image = global::Properties.Resources.repair__1_;
            this.Guna2Button14.ImageSize = new System.Drawing.Size(23, 23);
            this.Guna2Button14.Location = new System.Drawing.Point(224, 237);
            this.Guna2Button14.Name = "Guna2Button14";
            this.Guna2Button14.PressedColor = System.Drawing.Color.Empty;
            this.Guna2Button14.Size = new System.Drawing.Size(233, 32);
            this.Guna2Button14.TabIndex = 476;
            this.Guna2Button14.Text = "Repair Replace SIM";
            this.Guna2Button14.TextFormatNoPrefix = true;
            this.Guna2Button14.Click += new System.EventHandler(this.Guna2Button14_Click);
            // 
            // Guna2Button6
            // 
            this.Guna2Button6.Animated = true;
            this.Guna2Button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2Button6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2Button6.BorderRadius = 4;
            this.Guna2Button6.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.Guna2Button6.BorderThickness = 2;
            this.Guna2Button6.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button6.CheckedState.FillColor = System.Drawing.Color.LightGray;
            this.Guna2Button6.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button6.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
            this.Guna2Button6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button6.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.Guna2Button6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2Button6.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Guna2Button6.ForeColor = System.Drawing.Color.White;
            this.Guna2Button6.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button6.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button6.Image = global::Properties.Resources.arrows_circle_of_two_rotating_in_clockwise_direction;
            this.Guna2Button6.Location = new System.Drawing.Point(9, 48);
            this.Guna2Button6.Name = "Guna2Button6";
            this.Guna2Button6.PressedColor = System.Drawing.Color.Empty;
            this.Guna2Button6.Size = new System.Drawing.Size(448, 32);
            this.Guna2Button6.TabIndex = 466;
            this.Guna2Button6.Text = "Direct Convert To CDMA";
            this.Guna2Button6.TextFormatNoPrefix = true;
            this.Guna2Button6.Click += new System.EventHandler(this.Guna2Button6_Click);
            // 
            // Guna2Button5
            // 
            this.Guna2Button5.Animated = true;
            this.Guna2Button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2Button5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2Button5.BorderRadius = 4;
            this.Guna2Button5.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.Guna2Button5.BorderThickness = 2;
            this.Guna2Button5.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button5.CheckedState.FillColor = System.Drawing.Color.LightGray;
            this.Guna2Button5.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
            this.Guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button5.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.Guna2Button5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2Button5.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Guna2Button5.ForeColor = System.Drawing.Color.White;
            this.Guna2Button5.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button5.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button5.Image = global::Properties.Resources._3g__1_;
            this.Guna2Button5.Location = new System.Drawing.Point(9, 237);
            this.Guna2Button5.Name = "Guna2Button5";
            this.Guna2Button5.PressedColor = System.Drawing.Color.Empty;
            this.Guna2Button5.Size = new System.Drawing.Size(209, 32);
            this.Guna2Button5.TabIndex = 465;
            this.Guna2Button5.Text = "Write 3G Setting";
            this.Guna2Button5.TextFormatNoPrefix = true;
            this.Guna2Button5.Click += new System.EventHandler(this.Guna2Button5_Click);
            // 
            // Guna2Button16
            // 
            this.Guna2Button16.Animated = true;
            this.Guna2Button16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2Button16.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2Button16.BorderRadius = 4;
            this.Guna2Button16.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.Guna2Button16.BorderThickness = 2;
            this.Guna2Button16.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button16.CheckedState.FillColor = System.Drawing.Color.LightGray;
            this.Guna2Button16.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button16.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
            this.Guna2Button16.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button16.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.Guna2Button16.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2Button16.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Guna2Button16.ForeColor = System.Drawing.Color.White;
            this.Guna2Button16.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button16.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button16.Image = global::Properties.Resources.lte__1_;
            this.Guna2Button16.ImageSize = new System.Drawing.Size(23, 23);
            this.Guna2Button16.Location = new System.Drawing.Point(9, 86);
            this.Guna2Button16.Name = "Guna2Button16";
            this.Guna2Button16.PressedColor = System.Drawing.Color.Empty;
            this.Guna2Button16.Size = new System.Drawing.Size(209, 31);
            this.Guna2Button16.TabIndex = 474;
            this.Guna2Button16.Text = "Direct Enable VoLTE ";
            this.Guna2Button16.TextFormatNoPrefix = true;
            this.Guna2Button16.Click += new System.EventHandler(this.Guna2Button16_Click);
            // 
            // Guna2Button7
            // 
            this.Guna2Button7.Animated = true;
            this.Guna2Button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2Button7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2Button7.BorderRadius = 4;
            this.Guna2Button7.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.Guna2Button7.BorderThickness = 2;
            this.Guna2Button7.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button7.CheckedState.FillColor = System.Drawing.Color.LightGray;
            this.Guna2Button7.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button7.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
            this.Guna2Button7.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button7.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.Guna2Button7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2Button7.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Guna2Button7.ForeColor = System.Drawing.Color.White;
            this.Guna2Button7.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button7.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button7.Image = global::Properties.Resources.file;
            this.Guna2Button7.ImageSize = new System.Drawing.Size(23, 23);
            this.Guna2Button7.Location = new System.Drawing.Point(223, 275);
            this.Guna2Button7.Name = "Guna2Button7";
            this.Guna2Button7.PressedColor = System.Drawing.Color.Empty;
            this.Guna2Button7.Size = new System.Drawing.Size(233, 32);
            this.Guna2Button7.TabIndex = 468;
            this.Guna2Button7.Text = "Remove Policyman";
            this.Guna2Button7.TextFormatNoPrefix = true;
            this.Guna2Button7.Click += new System.EventHandler(this.Guna2Button7_Click);
            // 
            // Guna2Button15
            // 
            this.Guna2Button15.Animated = true;
            this.Guna2Button15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2Button15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2Button15.BorderRadius = 4;
            this.Guna2Button15.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.Guna2Button15.BorderThickness = 2;
            this.Guna2Button15.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button15.CheckedState.FillColor = System.Drawing.Color.LightGray;
            this.Guna2Button15.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button15.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
            this.Guna2Button15.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button15.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.Guna2Button15.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2Button15.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Guna2Button15.ForeColor = System.Drawing.Color.White;
            this.Guna2Button15.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button15.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button15.Image = global::Properties.Resources.edit__1_;
            this.Guna2Button15.ImageSize = new System.Drawing.Size(23, 23);
            this.Guna2Button15.Location = new System.Drawing.Point(323, 351);
            this.Guna2Button15.Name = "Guna2Button15";
            this.Guna2Button15.PressedColor = System.Drawing.Color.Empty;
            this.Guna2Button15.Size = new System.Drawing.Size(133, 32);
            this.Guna2Button15.TabIndex = 479;
            this.Guna2Button15.Text = "Write QCN";
            this.Guna2Button15.TextFormatNoPrefix = true;
            this.Guna2Button15.Click += new System.EventHandler(this.Guna2Button15_Click);
            // 
            // Guna2Button4
            // 
            this.Guna2Button4.Animated = true;
            this.Guna2Button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2Button4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2Button4.BorderRadius = 4;
            this.Guna2Button4.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.Guna2Button4.BorderThickness = 2;
            this.Guna2Button4.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button4.CheckedState.FillColor = System.Drawing.Color.LightGray;
            this.Guna2Button4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
            this.Guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button4.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.Guna2Button4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2Button4.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Guna2Button4.ForeColor = System.Drawing.Color.White;
            this.Guna2Button4.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button4.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button4.Image = global::Properties.Resources.magic_wand_auto_fix_button;
            this.Guna2Button4.ImageSize = new System.Drawing.Size(23, 23);
            this.Guna2Button4.Location = new System.Drawing.Point(9, 199);
            this.Guna2Button4.Name = "Guna2Button4";
            this.Guna2Button4.PressedColor = System.Drawing.Color.Empty;
            this.Guna2Button4.Size = new System.Drawing.Size(209, 32);
            this.Guna2Button4.TabIndex = 464;
            this.Guna2Button4.Text = "Repair Baseband";
            this.Guna2Button4.TextFormatNoPrefix = true;
            this.Guna2Button4.Click += new System.EventHandler(this.Guna2Button4_Click);
            // 
            // Guna2Button11
            // 
            this.Guna2Button11.Animated = true;
            this.Guna2Button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2Button11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2Button11.BorderRadius = 4;
            this.Guna2Button11.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.Guna2Button11.BorderThickness = 2;
            this.Guna2Button11.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button11.CheckedState.FillColor = System.Drawing.Color.LightGray;
            this.Guna2Button11.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button11.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
            this.Guna2Button11.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button11.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.Guna2Button11.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2Button11.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Guna2Button11.ForeColor = System.Drawing.Color.White;
            this.Guna2Button11.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button11.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button11.Image = global::Properties.Resources.sim_card;
            this.Guna2Button11.ImageSize = new System.Drawing.Size(23, 23);
            this.Guna2Button11.Location = new System.Drawing.Point(9, 275);
            this.Guna2Button11.Name = "Guna2Button11";
            this.Guna2Button11.PressedColor = System.Drawing.Color.Empty;
            this.Guna2Button11.Size = new System.Drawing.Size(209, 32);
            this.Guna2Button11.TabIndex = 469;
            this.Guna2Button11.Text = "Patch SIM [Sprint]";
            this.Guna2Button11.TextFormatNoPrefix = true;
            this.Guna2Button11.Click += new System.EventHandler(this.Guna2Button11_Click);
            // 
            // Guna2Button18
            // 
            this.Guna2Button18.Animated = true;
            this.Guna2Button18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2Button18.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2Button18.BorderRadius = 4;
            this.Guna2Button18.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.Guna2Button18.BorderThickness = 2;
            this.Guna2Button18.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button18.CheckedState.FillColor = System.Drawing.Color.LightGray;
            this.Guna2Button18.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button18.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
            this.Guna2Button18.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button18.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.Guna2Button18.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2Button18.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Guna2Button18.ForeColor = System.Drawing.Color.White;
            this.Guna2Button18.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button18.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button18.Image = global::Properties.Resources.cogwheel__1_;
            this.Guna2Button18.Location = new System.Drawing.Point(224, 199);
            this.Guna2Button18.Name = "Guna2Button18";
            this.Guna2Button18.PressedColor = System.Drawing.Color.Empty;
            this.Guna2Button18.Size = new System.Drawing.Size(233, 32);
            this.Guna2Button18.TabIndex = 480;
            this.Guna2Button18.Text = " Repair 4G If Not Work";
            this.Guna2Button18.TextFormatNoPrefix = true;
            this.Guna2Button18.Click += new System.EventHandler(this.Guna2Button18_Click);
            // 
            // Guna2Button3
            // 
            this.Guna2Button3.Animated = true;
            this.Guna2Button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2Button3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2Button3.BorderRadius = 4;
            this.Guna2Button3.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.Guna2Button3.BorderThickness = 2;
            this.Guna2Button3.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button3.CheckedState.FillColor = System.Drawing.Color.LightGray;
            this.Guna2Button3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
            this.Guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button3.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.Guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2Button3.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Guna2Button3.ForeColor = System.Drawing.Color.White;
            this.Guna2Button3.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button3.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button3.Image = global::Properties.Resources.upload__1_;
            this.Guna2Button3.Location = new System.Drawing.Point(9, 161);
            this.Guna2Button3.Name = "Guna2Button3";
            this.Guna2Button3.PressedColor = System.Drawing.Color.Empty;
            this.Guna2Button3.Size = new System.Drawing.Size(209, 32);
            this.Guna2Button3.TabIndex = 463;
            this.Guna2Button3.Text = "Write carrier_policy";
            this.Guna2Button3.TextFormatNoPrefix = true;
            this.Guna2Button3.Click += new System.EventHandler(this.Guna2Button3_Click);
            // 
            // Guna2Button1
            // 
            this.Guna2Button1.Animated = true;
            this.Guna2Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2Button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2Button1.BorderRadius = 4;
            this.Guna2Button1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.Guna2Button1.BorderThickness = 2;
            this.Guna2Button1.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button1.CheckedState.FillColor = System.Drawing.Color.LightGray;
            this.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
            this.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2Button1.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Guna2Button1.ForeColor = System.Drawing.Color.White;
            this.Guna2Button1.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button1.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button1.Image = global::Properties.Resources._4g__2_;
            this.Guna2Button1.Location = new System.Drawing.Point(224, 85);
            this.Guna2Button1.Name = "Guna2Button1";
            this.Guna2Button1.PressedColor = System.Drawing.Color.Empty;
            this.Guna2Button1.Size = new System.Drawing.Size(233, 32);
            this.Guna2Button1.TabIndex = 461;
            this.Guna2Button1.Text = "Direct Install 4G Setting";
            this.Guna2Button1.TextFormatNoPrefix = true;
            this.Guna2Button1.Click += new System.EventHandler(this.Guna2Button1_Click);
            // 
            // Guna2Button13
            // 
            this.Guna2Button13.Animated = true;
            this.Guna2Button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2Button13.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2Button13.BorderRadius = 4;
            this.Guna2Button13.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.Guna2Button13.BorderThickness = 2;
            this.Guna2Button13.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button13.CheckedState.FillColor = System.Drawing.Color.LightGray;
            this.Guna2Button13.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button13.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
            this.Guna2Button13.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button13.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.Guna2Button13.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2Button13.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Guna2Button13.ForeColor = System.Drawing.Color.White;
            this.Guna2Button13.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button13.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button13.Image = global::Properties.Resources.signal__1_;
            this.Guna2Button13.Location = new System.Drawing.Point(223, 161);
            this.Guna2Button13.Name = "Guna2Button13";
            this.Guna2Button13.PressedColor = System.Drawing.Color.Empty;
            this.Guna2Button13.Size = new System.Drawing.Size(233, 32);
            this.Guna2Button13.TabIndex = 470;
            this.Guna2Button13.Text = "Enable Bands [All]";
            this.Guna2Button13.Click += new System.EventHandler(this.Guna2Button13_Click);
            // 
            // Guna2Button10
            // 
            this.Guna2Button10.Animated = true;
            this.Guna2Button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2Button10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2Button10.BorderRadius = 4;
            this.Guna2Button10.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.Guna2Button10.BorderThickness = 2;
            this.Guna2Button10.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button10.CheckedState.FillColor = System.Drawing.Color.LightGray;
            this.Guna2Button10.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button10.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
            this.Guna2Button10.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button10.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.Guna2Button10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2Button10.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Guna2Button10.ForeColor = System.Drawing.Color.White;
            this.Guna2Button10.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button10.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button10.Image = global::Properties.Resources.search_in_folder;
            this.Guna2Button10.ImageSize = new System.Drawing.Size(25, 25);
            this.Guna2Button10.Location = new System.Drawing.Point(9, 351);
            this.Guna2Button10.Name = "Guna2Button10";
            this.Guna2Button10.PressedColor = System.Drawing.Color.Empty;
            this.Guna2Button10.Size = new System.Drawing.Size(41, 32);
            this.Guna2Button10.TabIndex = 493;
            this.Guna2Button10.TextFormatNoPrefix = true;
            this.Guna2Button10.Click += new System.EventHandler(this.Guna2Button10_Click);
            // 
            // Guna2Button12
            // 
            this.Guna2Button12.Animated = true;
            this.Guna2Button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2Button12.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2Button12.BorderRadius = 4;
            this.Guna2Button12.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.Guna2Button12.BorderThickness = 2;
            this.Guna2Button12.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button12.CheckedState.FillColor = System.Drawing.Color.LightGray;
            this.Guna2Button12.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button12.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
            this.Guna2Button12.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button12.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.Guna2Button12.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2Button12.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Guna2Button12.ForeColor = System.Drawing.Color.White;
            this.Guna2Button12.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button12.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button12.Image = global::Properties.Resources.no_signal;
            this.Guna2Button12.ImageSize = new System.Drawing.Size(21, 21);
            this.Guna2Button12.Location = new System.Drawing.Point(223, 123);
            this.Guna2Button12.Name = "Guna2Button12";
            this.Guna2Button12.PressedColor = System.Drawing.Color.Empty;
            this.Guna2Button12.Size = new System.Drawing.Size(233, 32);
            this.Guna2Button12.TabIndex = 471;
            this.Guna2Button12.Text = "Disable Bands [All]";
            this.Guna2Button12.TextFormatNoPrefix = true;
            this.Guna2Button12.Click += new System.EventHandler(this.Guna2Button12_Click);
            // 
            // Guna2Button2
            // 
            this.Guna2Button2.Animated = true;
            this.Guna2Button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2Button2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2Button2.BorderRadius = 4;
            this.Guna2Button2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.Guna2Button2.BorderThickness = 2;
            this.Guna2Button2.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button2.CheckedState.FillColor = System.Drawing.Color.LightGray;
            this.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
            this.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.Guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2Button2.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Guna2Button2.ForeColor = System.Drawing.Color.White;
            this.Guna2Button2.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button2.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button2.Image = global::Properties.Resources.download__3_;
            this.Guna2Button2.Location = new System.Drawing.Point(9, 123);
            this.Guna2Button2.Name = "Guna2Button2";
            this.Guna2Button2.PressedColor = System.Drawing.Color.Empty;
            this.Guna2Button2.Size = new System.Drawing.Size(209, 32);
            this.Guna2Button2.TabIndex = 462;
            this.Guna2Button2.Text = "Read carrier_policy";
            this.Guna2Button2.TextFormatNoPrefix = true;
            this.Guna2Button2.Click += new System.EventHandler(this.Guna2Button2_Click);
            // 
            // Guna2Button22
            // 
            this.Guna2Button22.Animated = true;
            this.Guna2Button22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2Button22.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2Button22.BorderRadius = 4;
            this.Guna2Button22.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.Guna2Button22.BorderThickness = 2;
            this.Guna2Button22.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button22.CheckedState.FillColor = System.Drawing.Color.LightGray;
            this.Guna2Button22.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button22.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
            this.Guna2Button22.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button22.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.Guna2Button22.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2Button22.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Guna2Button22.ForeColor = System.Drawing.Color.White;
            this.Guna2Button22.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button22.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button22.Image = global::Properties.Resources._3g__1_;
            this.Guna2Button22.Location = new System.Drawing.Point(9, 313);
            this.Guna2Button22.Name = "Guna2Button22";
            this.Guna2Button22.PressedColor = System.Drawing.Color.Empty;
            this.Guna2Button22.Size = new System.Drawing.Size(447, 32);
            this.Guna2Button22.TabIndex = 495;
            this.Guna2Button22.Text = " Write 3G Motorola One Click";
            this.Guna2Button22.TextFormatNoPrefix = true;
            this.Guna2Button22.Click += new System.EventHandler(this.Guna2Button22_Click);
            // 
            // RichTextBox1
            // 
            this.RichTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.RichTextBox1.Location = new System.Drawing.Point(482, -16);
            this.RichTextBox1.Name = "RichTextBox1";
            this.RichTextBox1.Size = new System.Drawing.Size(10, 10);
            this.RichTextBox1.TabIndex = 522;
            this.RichTextBox1.Text = "";
            // 
            // Guna2GroupBox1
            // 
            this.Guna2GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.Guna2GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2GroupBox1.BorderRadius = 6;
            this.Guna2GroupBox1.Controls.Add(this.Guna2Button17);
            this.Guna2GroupBox1.Controls.Add(this.Guna2Button9);
            this.Guna2GroupBox1.Controls.Add(this.Guna2ComboBox1);
            this.Guna2GroupBox1.Controls.Add(this.Guna2CheckBox2);
            this.Guna2GroupBox1.Controls.Add(this.CKAUTO_CONN);
            this.Guna2GroupBox1.Controls.Add(this.Guna2CheckBox1);
            this.Guna2GroupBox1.Controls.Add(this.CheckBox2);
            this.Guna2GroupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.Guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Guna2GroupBox1.Location = new System.Drawing.Point(8, 8);
            this.Guna2GroupBox1.Name = "Guna2GroupBox1";
            this.Guna2GroupBox1.ShadowDecoration.BorderRadius = 9;
            this.Guna2GroupBox1.ShadowDecoration.Color = System.Drawing.Color.White;
            this.Guna2GroupBox1.ShadowDecoration.Depth = 15;
            this.Guna2GroupBox1.Size = new System.Drawing.Size(465, 69);
            this.Guna2GroupBox1.TabIndex = 519;
            // 
            // Guna2Button17
            // 
            this.Guna2Button17.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Guna2Button17.Animated = true;
            this.Guna2Button17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2Button17.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2Button17.BorderRadius = 4;
            this.Guna2Button17.BorderThickness = 2;
            this.Guna2Button17.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button17.CheckedState.FillColor = System.Drawing.Color.LightGray;
            this.Guna2Button17.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button17.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
            this.Guna2Button17.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button17.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.Guna2Button17.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2Button17.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Guna2Button17.ForeColor = System.Drawing.Color.White;
            this.Guna2Button17.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button17.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button17.Image = global::Properties.Resources.cogwheel__1_;
            this.Guna2Button17.ImageSize = new System.Drawing.Size(17, 17);
            this.Guna2Button17.Location = new System.Drawing.Point(9, 6);
            this.Guna2Button17.Name = "Guna2Button17";
            this.Guna2Button17.PressedColor = System.Drawing.Color.Empty;
            this.Guna2Button17.Size = new System.Drawing.Size(111, 18);
            this.Guna2Button17.TabIndex = 524;
            this.Guna2Button17.Text = " Zero Ports";
            this.Guna2Button17.TextFormatNoPrefix = true;
            this.Guna2Button17.Click += new System.EventHandler(this.Guna2Button17_Click);
            // 
            // Guna2Button9
            // 
            this.Guna2Button9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Guna2Button9.Animated = true;
            this.Guna2Button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2Button9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2Button9.BorderRadius = 4;
            this.Guna2Button9.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.Guna2Button9.BorderThickness = 2;
            this.Guna2Button9.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button9.CheckedState.FillColor = System.Drawing.Color.LightGray;
            this.Guna2Button9.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button9.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
            this.Guna2Button9.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button9.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.Guna2Button9.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2Button9.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Guna2Button9.ForeColor = System.Drawing.Color.White;
            this.Guna2Button9.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button9.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button9.Image = global::Properties.Resources.info__1_;
            this.Guna2Button9.Location = new System.Drawing.Point(379, 29);
            this.Guna2Button9.Name = "Guna2Button9";
            this.Guna2Button9.PressedColor = System.Drawing.Color.Empty;
            this.Guna2Button9.Size = new System.Drawing.Size(77, 32);
            this.Guna2Button9.TabIndex = 523;
            this.Guna2Button9.Text = "Check";
            this.Guna2Button9.TextFormatNoPrefix = true;
            this.Guna2Button9.Click += new System.EventHandler(this.Guna2Button9_Click);
            // 
            // Guna2ComboBox1
            // 
            this.Guna2ComboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Guna2ComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2ComboBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2ComboBox1.BorderRadius = 4;
            this.Guna2ComboBox1.BorderThickness = 2;
            this.Guna2ComboBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2ComboBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2ComboBox1.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.Guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Guna2ComboBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Guna2ComboBox1.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2ComboBox1.ForeColor = System.Drawing.Color.White;
            this.Guna2ComboBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2ComboBox1.ItemHeight = 26;
            this.Guna2ComboBox1.ItemsAppearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2ComboBox1.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2ComboBox1.Location = new System.Drawing.Point(9, 29);
            this.Guna2ComboBox1.MaxDropDownItems = 5;
            this.Guna2ComboBox1.MaxLength = 5;
            this.Guna2ComboBox1.Name = "Guna2ComboBox1";
            this.Guna2ComboBox1.Size = new System.Drawing.Size(364, 32);
            this.Guna2ComboBox1.TabIndex = 522;
            this.Guna2ComboBox1.SelectedIndexChanged += new System.EventHandler(this.Guna2ComboBox1_SelectedIndexChanged);
            // 
            // CKAUTO_CONN
            // 
            this.CKAUTO_CONN.Animated = true;
            this.CKAUTO_CONN.AutoSize = true;
            this.CKAUTO_CONN.CheckedState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.CKAUTO_CONN.CheckedState.BorderRadius = 4;
            this.CKAUTO_CONN.CheckedState.BorderThickness = 2;
            this.CKAUTO_CONN.CheckedState.FillColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.CKAUTO_CONN.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CKAUTO_CONN.ForeColor = System.Drawing.Color.White;
            this.CKAUTO_CONN.Location = new System.Drawing.Point(127, 5);
            this.CKAUTO_CONN.Name = "CKAUTO_CONN";
            this.CKAUTO_CONN.Size = new System.Drawing.Size(115, 21);
            this.CKAUTO_CONN.TabIndex = 521;
            this.CKAUTO_CONN.Text = " Auto Connect";
            this.CKAUTO_CONN.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.CKAUTO_CONN.UncheckedState.BorderRadius = 3;
            this.CKAUTO_CONN.UncheckedState.BorderThickness = 1;
            this.CKAUTO_CONN.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.CKAUTO_CONN.CheckedChanged += new System.EventHandler(this.CKAUTO_CONN_CheckedChanged);
            // 
            // Guna2GroupBox3
            // 
            this.Guna2GroupBox3.BackColor = System.Drawing.Color.Transparent;
            this.Guna2GroupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Guna2GroupBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2GroupBox3.BorderRadius = 6;
            this.Guna2GroupBox3.Controls.Add(this.Guna2RadioButton29);
            this.Guna2GroupBox3.Controls.Add(this.Guna2RadioButton30);
            this.Guna2GroupBox3.Controls.Add(this.Guna2RadioButton28);
            this.Guna2GroupBox3.Controls.Add(this.Guna2RadioButton23);
            this.Guna2GroupBox3.Controls.Add(this.Guna2Button21);
            this.Guna2GroupBox3.Controls.Add(this.Guna2RadioButton24);
            this.Guna2GroupBox3.Controls.Add(this.Guna2RadioButton15);
            this.Guna2GroupBox3.Controls.Add(this.Guna2RadioButton21);
            this.Guna2GroupBox3.Controls.Add(this.Guna2RadioButton14);
            this.Guna2GroupBox3.Controls.Add(this.Guna2RadioButton22);
            this.Guna2GroupBox3.Controls.Add(this.Guna2RadioButton10);
            this.Guna2GroupBox3.Controls.Add(this.Guna2RadioButton11);
            this.Guna2GroupBox3.Controls.Add(this.Label3);
            this.Guna2GroupBox3.Controls.Add(this.Guna2RadioButton13);
            this.Guna2GroupBox3.Controls.Add(this.Guna2RadioButton7);
            this.Guna2GroupBox3.Controls.Add(this.Guna2RadioButton12);
            this.Guna2GroupBox3.Controls.Add(this.Guna2RadioButton20);
            this.Guna2GroupBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.Guna2GroupBox3.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2GroupBox3.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.Guna2GroupBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2GroupBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Guna2GroupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Guna2GroupBox3.Location = new System.Drawing.Point(8, 7);
            this.Guna2GroupBox3.Name = "Guna2GroupBox3";
            this.Guna2GroupBox3.ShadowDecoration.BorderRadius = 9;
            this.Guna2GroupBox3.ShadowDecoration.Color = System.Drawing.Color.White;
            this.Guna2GroupBox3.ShadowDecoration.Depth = 15;
            this.Guna2GroupBox3.Size = new System.Drawing.Size(466, 473);
            this.Guna2GroupBox3.TabIndex = 521;
            // 
            // Guna2RadioButton29
            // 
            this.Guna2RadioButton29.Animated = true;
            this.Guna2RadioButton29.AutoSize = true;
            this.Guna2RadioButton29.CheckedState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2RadioButton29.CheckedState.BorderThickness = 3;
            this.Guna2RadioButton29.CheckedState.FillColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2RadioButton29.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(99)))), ((int)(((byte)(129)))));
            this.Guna2RadioButton29.CheckedState.InnerOffset = -6;
            this.Guna2RadioButton29.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guna2RadioButton29.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.Guna2RadioButton29.ForeColor = System.Drawing.Color.White;
            this.Guna2RadioButton29.Location = new System.Drawing.Point(11, 358);
            this.Guna2RadioButton29.Name = "Guna2RadioButton29";
            this.Guna2RadioButton29.Size = new System.Drawing.Size(192, 19);
            this.Guna2RadioButton29.TabIndex = 512;
            this.Guna2RadioButton29.Text = "Open MBN Test Menu [ Qcom ]";
            this.Guna2RadioButton29.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2RadioButton29.UncheckedState.BorderThickness = 3;
            this.Guna2RadioButton29.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2RadioButton29.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            // 
            // Guna2RadioButton30
            // 
            this.Guna2RadioButton30.Animated = true;
            this.Guna2RadioButton30.AutoSize = true;
            this.Guna2RadioButton30.CheckedState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2RadioButton30.CheckedState.BorderThickness = 3;
            this.Guna2RadioButton30.CheckedState.FillColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2RadioButton30.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(99)))), ((int)(((byte)(129)))));
            this.Guna2RadioButton30.CheckedState.InnerOffset = -6;
            this.Guna2RadioButton30.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guna2RadioButton30.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2RadioButton30.ForeColor = System.Drawing.Color.White;
            this.Guna2RadioButton30.Location = new System.Drawing.Point(11, 333);
            this.Guna2RadioButton30.Name = "Guna2RadioButton30";
            this.Guna2RadioButton30.Size = new System.Drawing.Size(199, 19);
            this.Guna2RadioButton30.TabIndex = 511;
            this.Guna2RadioButton30.Text = "Open MBN Config Edit [ Xiaomi ]";
            this.Guna2RadioButton30.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2RadioButton30.UncheckedState.BorderThickness = 3;
            this.Guna2RadioButton30.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2RadioButton30.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            // 
            // Guna2RadioButton28
            // 
            this.Guna2RadioButton28.Animated = true;
            this.Guna2RadioButton28.AutoSize = true;
            this.Guna2RadioButton28.CheckedState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2RadioButton28.CheckedState.BorderThickness = 3;
            this.Guna2RadioButton28.CheckedState.FillColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2RadioButton28.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(99)))), ((int)(((byte)(129)))));
            this.Guna2RadioButton28.CheckedState.InnerOffset = -6;
            this.Guna2RadioButton28.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guna2RadioButton28.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2RadioButton28.ForeColor = System.Drawing.Color.White;
            this.Guna2RadioButton28.Location = new System.Drawing.Point(13, 383);
            this.Guna2RadioButton28.Name = "Guna2RadioButton28";
            this.Guna2RadioButton28.Size = new System.Drawing.Size(182, 19);
            this.Guna2RadioButton28.TabIndex = 510;
            this.Guna2RadioButton28.Text = "Enable VoLTE All MTK [ Root ]";
            this.Guna2RadioButton28.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2RadioButton28.UncheckedState.BorderThickness = 3;
            this.Guna2RadioButton28.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2RadioButton28.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            // 
            // Guna2RadioButton23
            // 
            this.Guna2RadioButton23.Animated = true;
            this.Guna2RadioButton23.AutoSize = true;
            this.Guna2RadioButton23.CheckedState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2RadioButton23.CheckedState.BorderThickness = 3;
            this.Guna2RadioButton23.CheckedState.FillColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2RadioButton23.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(99)))), ((int)(((byte)(129)))));
            this.Guna2RadioButton23.CheckedState.InnerOffset = -6;
            this.Guna2RadioButton23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guna2RadioButton23.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2RadioButton23.ForeColor = System.Drawing.Color.White;
            this.Guna2RadioButton23.Location = new System.Drawing.Point(11, 308);
            this.Guna2RadioButton23.Name = "Guna2RadioButton23";
            this.Guna2RadioButton23.Size = new System.Drawing.Size(179, 19);
            this.Guna2RadioButton23.TabIndex = 509;
            this.Guna2RadioButton23.Text = "Open MiscConfig Menu MTK";
            this.Guna2RadioButton23.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2RadioButton23.UncheckedState.BorderThickness = 3;
            this.Guna2RadioButton23.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2RadioButton23.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            // 
            // Guna2Button21
            // 
            this.Guna2Button21.Animated = true;
            this.Guna2Button21.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2Button21.BorderRadius = 4;
            this.Guna2Button21.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.Guna2Button21.BorderThickness = 2;
            this.Guna2Button21.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button21.CheckedState.FillColor = System.Drawing.Color.LightGray;
            this.Guna2Button21.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button21.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
            this.Guna2Button21.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button21.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.Guna2Button21.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2Button21.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Guna2Button21.ForeColor = System.Drawing.Color.White;
            this.Guna2Button21.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button21.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button21.Image = global::Properties.Resources.video;
            this.Guna2Button21.Location = new System.Drawing.Point(12, 429);
            this.Guna2Button21.Name = "Guna2Button21";
            this.Guna2Button21.PressedColor = System.Drawing.Color.Empty;
            this.Guna2Button21.Size = new System.Drawing.Size(442, 32);
            this.Guna2Button21.TabIndex = 505;
            this.Guna2Button21.Text = "Start Job";
            this.Guna2Button21.TextFormatNoPrefix = true;
            this.Guna2Button21.Click += new System.EventHandler(this.Guna2Button21_Click);
            // 
            // Guna2RadioButton24
            // 
            this.Guna2RadioButton24.Animated = true;
            this.Guna2RadioButton24.AutoSize = true;
            this.Guna2RadioButton24.CheckedState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2RadioButton24.CheckedState.BorderThickness = 3;
            this.Guna2RadioButton24.CheckedState.FillColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2RadioButton24.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(99)))), ((int)(((byte)(129)))));
            this.Guna2RadioButton24.CheckedState.InnerOffset = -6;
            this.Guna2RadioButton24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guna2RadioButton24.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2RadioButton24.ForeColor = System.Drawing.Color.White;
            this.Guna2RadioButton24.Location = new System.Drawing.Point(11, 283);
            this.Guna2RadioButton24.Name = "Guna2RadioButton24";
            this.Guna2RadioButton24.Size = new System.Drawing.Size(184, 19);
            this.Guna2RadioButton24.TabIndex = 508;
            this.Guna2RadioButton24.Text = "Open Selection Operator MTK";
            this.Guna2RadioButton24.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2RadioButton24.UncheckedState.BorderThickness = 3;
            this.Guna2RadioButton24.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2RadioButton24.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            // 
            // Guna2RadioButton15
            // 
            this.Guna2RadioButton15.Animated = true;
            this.Guna2RadioButton15.AutoSize = true;
            this.Guna2RadioButton15.CheckedState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2RadioButton15.CheckedState.BorderThickness = 3;
            this.Guna2RadioButton15.CheckedState.FillColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2RadioButton15.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(99)))), ((int)(((byte)(129)))));
            this.Guna2RadioButton15.CheckedState.InnerOffset = -6;
            this.Guna2RadioButton15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guna2RadioButton15.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2RadioButton15.ForeColor = System.Drawing.Color.White;
            this.Guna2RadioButton15.Location = new System.Drawing.Point(11, 133);
            this.Guna2RadioButton15.Name = "Guna2RadioButton15";
            this.Guna2RadioButton15.Size = new System.Drawing.Size(210, 19);
            this.Guna2RadioButton15.TabIndex = 495;
            this.Guna2RadioButton15.Text = "Open SPD Operator Settings Menu";
            this.Guna2RadioButton15.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2RadioButton15.UncheckedState.BorderThickness = 3;
            this.Guna2RadioButton15.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2RadioButton15.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            // 
            // Guna2RadioButton21
            // 
            this.Guna2RadioButton21.Animated = true;
            this.Guna2RadioButton21.AutoSize = true;
            this.Guna2RadioButton21.CheckedState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2RadioButton21.CheckedState.BorderThickness = 3;
            this.Guna2RadioButton21.CheckedState.FillColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2RadioButton21.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(99)))), ((int)(((byte)(129)))));
            this.Guna2RadioButton21.CheckedState.InnerOffset = -6;
            this.Guna2RadioButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guna2RadioButton21.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2RadioButton21.ForeColor = System.Drawing.Color.White;
            this.Guna2RadioButton21.Location = new System.Drawing.Point(11, 258);
            this.Guna2RadioButton21.Name = "Guna2RadioButton21";
            this.Guna2RadioButton21.Size = new System.Drawing.Size(165, 19);
            this.Guna2RadioButton21.TabIndex = 507;
            this.Guna2RadioButton21.Text = "Open Engineer Mode MTK";
            this.Guna2RadioButton21.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2RadioButton21.UncheckedState.BorderThickness = 3;
            this.Guna2RadioButton21.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2RadioButton21.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            // 
            // Guna2RadioButton14
            // 
            this.Guna2RadioButton14.Animated = true;
            this.Guna2RadioButton14.AutoSize = true;
            this.Guna2RadioButton14.CheckedState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2RadioButton14.CheckedState.BorderThickness = 3;
            this.Guna2RadioButton14.CheckedState.FillColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2RadioButton14.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(99)))), ((int)(((byte)(129)))));
            this.Guna2RadioButton14.CheckedState.InnerOffset = -6;
            this.Guna2RadioButton14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guna2RadioButton14.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2RadioButton14.ForeColor = System.Drawing.Color.White;
            this.Guna2RadioButton14.Location = new System.Drawing.Point(11, 158);
            this.Guna2RadioButton14.Name = "Guna2RadioButton14";
            this.Guna2RadioButton14.Size = new System.Drawing.Size(181, 19);
            this.Guna2RadioButton14.TabIndex = 496;
            this.Guna2RadioButton14.Text = "Open SPD Gcf Settings Menu";
            this.Guna2RadioButton14.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2RadioButton14.UncheckedState.BorderThickness = 3;
            this.Guna2RadioButton14.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2RadioButton14.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            // 
            // Guna2RadioButton22
            // 
            this.Guna2RadioButton22.Animated = true;
            this.Guna2RadioButton22.AutoSize = true;
            this.Guna2RadioButton22.CheckedState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2RadioButton22.CheckedState.BorderThickness = 3;
            this.Guna2RadioButton22.CheckedState.FillColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2RadioButton22.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(99)))), ((int)(((byte)(129)))));
            this.Guna2RadioButton22.CheckedState.InnerOffset = -6;
            this.Guna2RadioButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guna2RadioButton22.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2RadioButton22.ForeColor = System.Drawing.Color.White;
            this.Guna2RadioButton22.Location = new System.Drawing.Point(11, 233);
            this.Guna2RadioButton22.Name = "Guna2RadioButton22";
            this.Guna2RadioButton22.Size = new System.Drawing.Size(141, 19);
            this.Guna2RadioButton22.TabIndex = 506;
            this.Guna2RadioButton22.Text = "Open IMS Menu MTK";
            this.Guna2RadioButton22.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2RadioButton22.UncheckedState.BorderThickness = 3;
            this.Guna2RadioButton22.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2RadioButton22.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            // 
            // Guna2RadioButton10
            // 
            this.Guna2RadioButton10.Animated = true;
            this.Guna2RadioButton10.AutoSize = true;
            this.Guna2RadioButton10.CheckedState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2RadioButton10.CheckedState.BorderThickness = 3;
            this.Guna2RadioButton10.CheckedState.FillColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2RadioButton10.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(99)))), ((int)(((byte)(129)))));
            this.Guna2RadioButton10.CheckedState.InnerOffset = -6;
            this.Guna2RadioButton10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guna2RadioButton10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2RadioButton10.ForeColor = System.Drawing.Color.White;
            this.Guna2RadioButton10.Location = new System.Drawing.Point(11, 108);
            this.Guna2RadioButton10.Name = "Guna2RadioButton10";
            this.Guna2RadioButton10.Size = new System.Drawing.Size(203, 19);
            this.Guna2RadioButton10.TabIndex = 494;
            this.Guna2RadioButton10.Text = "Open SPD Enginnger Menu Mth4";
            this.Guna2RadioButton10.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2RadioButton10.UncheckedState.BorderThickness = 3;
            this.Guna2RadioButton10.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2RadioButton10.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            // 
            // Guna2RadioButton11
            // 
            this.Guna2RadioButton11.Animated = true;
            this.Guna2RadioButton11.AutoSize = true;
            this.Guna2RadioButton11.CheckedState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2RadioButton11.CheckedState.BorderThickness = 3;
            this.Guna2RadioButton11.CheckedState.FillColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2RadioButton11.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(99)))), ((int)(((byte)(129)))));
            this.Guna2RadioButton11.CheckedState.InnerOffset = -6;
            this.Guna2RadioButton11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guna2RadioButton11.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2RadioButton11.ForeColor = System.Drawing.Color.White;
            this.Guna2RadioButton11.Location = new System.Drawing.Point(11, 83);
            this.Guna2RadioButton11.Name = "Guna2RadioButton11";
            this.Guna2RadioButton11.Size = new System.Drawing.Size(203, 19);
            this.Guna2RadioButton11.TabIndex = 493;
            this.Guna2RadioButton11.Text = "Open SPD Enginnger Menu Mth3";
            this.Guna2RadioButton11.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2RadioButton11.UncheckedState.BorderThickness = 3;
            this.Guna2RadioButton11.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2RadioButton11.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(8, 7);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(94, 17);
            this.Label3.TabIndex = 491;
            this.Label3.Text = "VoLTE Custom";
            // 
            // Guna2RadioButton13
            // 
            this.Guna2RadioButton13.Animated = true;
            this.Guna2RadioButton13.AutoSize = true;
            this.Guna2RadioButton13.CheckedState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2RadioButton13.CheckedState.BorderThickness = 3;
            this.Guna2RadioButton13.CheckedState.FillColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2RadioButton13.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(99)))), ((int)(((byte)(129)))));
            this.Guna2RadioButton13.CheckedState.InnerOffset = -6;
            this.Guna2RadioButton13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guna2RadioButton13.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2RadioButton13.ForeColor = System.Drawing.Color.White;
            this.Guna2RadioButton13.Location = new System.Drawing.Point(11, 183);
            this.Guna2RadioButton13.Name = "Guna2RadioButton13";
            this.Guna2RadioButton13.Size = new System.Drawing.Size(171, 19);
            this.Guna2RadioButton13.TabIndex = 497;
            this.Guna2RadioButton13.Text = "Open IMS Menu Direct ZTE";
            this.Guna2RadioButton13.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2RadioButton13.UncheckedState.BorderThickness = 3;
            this.Guna2RadioButton13.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2RadioButton13.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            // 
            // Guna2RadioButton7
            // 
            this.Guna2RadioButton7.Animated = true;
            this.Guna2RadioButton7.AutoSize = true;
            this.Guna2RadioButton7.Checked = true;
            this.Guna2RadioButton7.CheckedState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2RadioButton7.CheckedState.BorderThickness = 3;
            this.Guna2RadioButton7.CheckedState.FillColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2RadioButton7.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(99)))), ((int)(((byte)(129)))));
            this.Guna2RadioButton7.CheckedState.InnerOffset = -6;
            this.Guna2RadioButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guna2RadioButton7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2RadioButton7.ForeColor = System.Drawing.Color.White;
            this.Guna2RadioButton7.Location = new System.Drawing.Point(11, 33);
            this.Guna2RadioButton7.Name = "Guna2RadioButton7";
            this.Guna2RadioButton7.Size = new System.Drawing.Size(171, 19);
            this.Guna2RadioButton7.TabIndex = 491;
            this.Guna2RadioButton7.TabStop = true;
            this.Guna2RadioButton7.Text = "Open SPD Enginnger Menu";
            this.Guna2RadioButton7.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2RadioButton7.UncheckedState.BorderThickness = 3;
            this.Guna2RadioButton7.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2RadioButton7.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            // 
            // Guna2RadioButton12
            // 
            this.Guna2RadioButton12.Animated = true;
            this.Guna2RadioButton12.AutoSize = true;
            this.Guna2RadioButton12.CheckedState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2RadioButton12.CheckedState.BorderThickness = 3;
            this.Guna2RadioButton12.CheckedState.FillColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2RadioButton12.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(99)))), ((int)(((byte)(129)))));
            this.Guna2RadioButton12.CheckedState.InnerOffset = -6;
            this.Guna2RadioButton12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guna2RadioButton12.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2RadioButton12.ForeColor = System.Drawing.Color.White;
            this.Guna2RadioButton12.Location = new System.Drawing.Point(11, 58);
            this.Guna2RadioButton12.Name = "Guna2RadioButton12";
            this.Guna2RadioButton12.Size = new System.Drawing.Size(203, 19);
            this.Guna2RadioButton12.TabIndex = 492;
            this.Guna2RadioButton12.Text = "Open SPD Enginnger Menu Mth2";
            this.Guna2RadioButton12.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2RadioButton12.UncheckedState.BorderThickness = 3;
            this.Guna2RadioButton12.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2RadioButton12.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            // 
            // Guna2RadioButton20
            // 
            this.Guna2RadioButton20.Animated = true;
            this.Guna2RadioButton20.AutoSize = true;
            this.Guna2RadioButton20.CheckedState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2RadioButton20.CheckedState.BorderThickness = 3;
            this.Guna2RadioButton20.CheckedState.FillColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2RadioButton20.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(99)))), ((int)(((byte)(129)))));
            this.Guna2RadioButton20.CheckedState.InnerOffset = -6;
            this.Guna2RadioButton20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guna2RadioButton20.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2RadioButton20.ForeColor = System.Drawing.Color.White;
            this.Guna2RadioButton20.Location = new System.Drawing.Point(11, 208);
            this.Guna2RadioButton20.Name = "Guna2RadioButton20";
            this.Guna2RadioButton20.Size = new System.Drawing.Size(165, 19);
            this.Guna2RadioButton20.TabIndex = 498;
            this.Guna2RadioButton20.Text = "Open IMS Menu Direct LG";
            this.Guna2RadioButton20.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2RadioButton20.UncheckedState.BorderThickness = 3;
            this.Guna2RadioButton20.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2RadioButton20.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            // 
            // Guna2GroupBox7
            // 
            this.Guna2GroupBox7.BackColor = System.Drawing.Color.Transparent;
            this.Guna2GroupBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Guna2GroupBox7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2GroupBox7.BorderRadius = 6;
            this.Guna2GroupBox7.Controls.Add(this.Guna2RadioButton27);
            this.Guna2GroupBox7.Controls.Add(this.Guna2RadioButton25);
            this.Guna2GroupBox7.Controls.Add(this.Guna2Button19);
            this.Guna2GroupBox7.Controls.Add(this.Guna2RadioButton26);
            this.Guna2GroupBox7.Controls.Add(this.Label2);
            this.Guna2GroupBox7.Controls.Add(this.Guna2RadioButton6);
            this.Guna2GroupBox7.Controls.Add(this.Guna2RadioButton16);
            this.Guna2GroupBox7.Controls.Add(this.Guna2RadioButton8);
            this.Guna2GroupBox7.Controls.Add(this.Guna2RadioButton17);
            this.Guna2GroupBox7.Controls.Add(this.Guna2RadioButton9);
            this.Guna2GroupBox7.Controls.Add(this.Guna2RadioButton18);
            this.Guna2GroupBox7.Controls.Add(this.Guna2RadioButton5);
            this.Guna2GroupBox7.Controls.Add(this.Guna2RadioButton19);
            this.Guna2GroupBox7.Controls.Add(this.Guna2RadioButton3);
            this.Guna2GroupBox7.Cursor = System.Windows.Forms.Cursors.Default;
            this.Guna2GroupBox7.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2GroupBox7.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.Guna2GroupBox7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2GroupBox7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Guna2GroupBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Guna2GroupBox7.Location = new System.Drawing.Point(8, 7);
            this.Guna2GroupBox7.Name = "Guna2GroupBox7";
            this.Guna2GroupBox7.ShadowDecoration.BorderRadius = 9;
            this.Guna2GroupBox7.ShadowDecoration.Color = System.Drawing.Color.White;
            this.Guna2GroupBox7.ShadowDecoration.Depth = 15;
            this.Guna2GroupBox7.Size = new System.Drawing.Size(466, 473);
            this.Guna2GroupBox7.TabIndex = 523;
            // 
            // Guna2RadioButton27
            // 
            this.Guna2RadioButton27.Animated = true;
            this.Guna2RadioButton27.AutoSize = true;
            this.Guna2RadioButton27.CheckedState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2RadioButton27.CheckedState.BorderThickness = 3;
            this.Guna2RadioButton27.CheckedState.FillColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2RadioButton27.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(99)))), ((int)(((byte)(129)))));
            this.Guna2RadioButton27.CheckedState.InnerOffset = -6;
            this.Guna2RadioButton27.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guna2RadioButton27.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2RadioButton27.ForeColor = System.Drawing.Color.White;
            this.Guna2RadioButton27.Location = new System.Drawing.Point(11, 283);
            this.Guna2RadioButton27.Name = "Guna2RadioButton27";
            this.Guna2RadioButton27.Size = new System.Drawing.Size(125, 19);
            this.Guna2RadioButton27.TabIndex = 506;
            this.Guna2RadioButton27.Text = "Enabel Daig For All";
            this.Guna2RadioButton27.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2RadioButton27.UncheckedState.BorderThickness = 3;
            this.Guna2RadioButton27.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2RadioButton27.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            // 
            // Guna2RadioButton25
            // 
            this.Guna2RadioButton25.Animated = true;
            this.Guna2RadioButton25.AutoSize = true;
            this.Guna2RadioButton25.CheckedState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2RadioButton25.CheckedState.BorderThickness = 3;
            this.Guna2RadioButton25.CheckedState.FillColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2RadioButton25.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(99)))), ((int)(((byte)(129)))));
            this.Guna2RadioButton25.CheckedState.InnerOffset = -6;
            this.Guna2RadioButton25.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guna2RadioButton25.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2RadioButton25.ForeColor = System.Drawing.Color.White;
            this.Guna2RadioButton25.Location = new System.Drawing.Point(11, 308);
            this.Guna2RadioButton25.Name = "Guna2RadioButton25";
            this.Guna2RadioButton25.Size = new System.Drawing.Size(237, 19);
            this.Guna2RadioButton25.TabIndex = 505;
            this.Guna2RadioButton25.Text = "Open Diag Menu ZTE [ General Mehod ]";
            this.Guna2RadioButton25.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2RadioButton25.UncheckedState.BorderThickness = 3;
            this.Guna2RadioButton25.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2RadioButton25.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            // 
            // Guna2Button19
            // 
            this.Guna2Button19.Animated = true;
            this.Guna2Button19.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2Button19.BorderRadius = 4;
            this.Guna2Button19.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.Guna2Button19.BorderThickness = 2;
            this.Guna2Button19.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button19.CheckedState.FillColor = System.Drawing.Color.LightGray;
            this.Guna2Button19.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button19.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
            this.Guna2Button19.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button19.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.Guna2Button19.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2Button19.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Guna2Button19.ForeColor = System.Drawing.Color.White;
            this.Guna2Button19.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button19.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button19.Image = global::Properties.Resources.video;
            this.Guna2Button19.Location = new System.Drawing.Point(12, 429);
            this.Guna2Button19.Name = "Guna2Button19";
            this.Guna2Button19.PressedColor = System.Drawing.Color.Empty;
            this.Guna2Button19.Size = new System.Drawing.Size(442, 32);
            this.Guna2Button19.TabIndex = 504;
            this.Guna2Button19.Text = "Start Job";
            this.Guna2Button19.TextFormatNoPrefix = true;
            this.Guna2Button19.Click += new System.EventHandler(this.Guna2Button19_Click);
            // 
            // Guna2RadioButton26
            // 
            this.Guna2RadioButton26.Animated = true;
            this.Guna2RadioButton26.AutoSize = true;
            this.Guna2RadioButton26.CheckedState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2RadioButton26.CheckedState.BorderThickness = 3;
            this.Guna2RadioButton26.CheckedState.FillColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2RadioButton26.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(99)))), ((int)(((byte)(129)))));
            this.Guna2RadioButton26.CheckedState.InnerOffset = -6;
            this.Guna2RadioButton26.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guna2RadioButton26.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2RadioButton26.ForeColor = System.Drawing.Color.White;
            this.Guna2RadioButton26.Location = new System.Drawing.Point(11, 258);
            this.Guna2RadioButton26.Name = "Guna2RadioButton26";
            this.Guna2RadioButton26.Size = new System.Drawing.Size(153, 19);
            this.Guna2RadioButton26.TabIndex = 503;
            this.Guna2RadioButton26.Text = "Open Network Menu All\r\n";
            this.Guna2RadioButton26.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2RadioButton26.UncheckedState.BorderThickness = 3;
            this.Guna2RadioButton26.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2RadioButton26.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(8, 7);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(35, 17);
            this.Label2.TabIndex = 491;
            this.Label2.Text = "Misc";
            // 
            // Guna2RadioButton6
            // 
            this.Guna2RadioButton6.Animated = true;
            this.Guna2RadioButton6.AutoSize = true;
            this.Guna2RadioButton6.Checked = true;
            this.Guna2RadioButton6.CheckedState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2RadioButton6.CheckedState.BorderThickness = 3;
            this.Guna2RadioButton6.CheckedState.FillColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2RadioButton6.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(99)))), ((int)(((byte)(129)))));
            this.Guna2RadioButton6.CheckedState.InnerOffset = -6;
            this.Guna2RadioButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guna2RadioButton6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2RadioButton6.ForeColor = System.Drawing.Color.White;
            this.Guna2RadioButton6.Location = new System.Drawing.Point(11, 33);
            this.Guna2RadioButton6.Name = "Guna2RadioButton6";
            this.Guna2RadioButton6.Size = new System.Drawing.Size(182, 19);
            this.Guna2RadioButton6.TabIndex = 486;
            this.Guna2RadioButton6.TabStop = true;
            this.Guna2RadioButton6.Text = "Open Diag Menu [ LG Sprint ]";
            this.Guna2RadioButton6.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2RadioButton6.UncheckedState.BorderThickness = 3;
            this.Guna2RadioButton6.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2RadioButton6.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            // 
            // Guna2RadioButton16
            // 
            this.Guna2RadioButton16.Animated = true;
            this.Guna2RadioButton16.AutoSize = true;
            this.Guna2RadioButton16.CheckedState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2RadioButton16.CheckedState.BorderThickness = 3;
            this.Guna2RadioButton16.CheckedState.FillColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2RadioButton16.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(99)))), ((int)(((byte)(129)))));
            this.Guna2RadioButton16.CheckedState.InnerOffset = -6;
            this.Guna2RadioButton16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guna2RadioButton16.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2RadioButton16.ForeColor = System.Drawing.Color.White;
            this.Guna2RadioButton16.Location = new System.Drawing.Point(11, 233);
            this.Guna2RadioButton16.Name = "Guna2RadioButton16";
            this.Guna2RadioButton16.Size = new System.Drawing.Size(222, 19);
            this.Guna2RadioButton16.TabIndex = 502;
            this.Guna2RadioButton16.Text = "Open Change CSC Menu [ Samsung ]";
            this.Guna2RadioButton16.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2RadioButton16.UncheckedState.BorderThickness = 3;
            this.Guna2RadioButton16.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2RadioButton16.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            // 
            // Guna2RadioButton8
            // 
            this.Guna2RadioButton8.Animated = true;
            this.Guna2RadioButton8.AutoSize = true;
            this.Guna2RadioButton8.CheckedState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2RadioButton8.CheckedState.BorderThickness = 3;
            this.Guna2RadioButton8.CheckedState.FillColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2RadioButton8.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(99)))), ((int)(((byte)(129)))));
            this.Guna2RadioButton8.CheckedState.InnerOffset = -6;
            this.Guna2RadioButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guna2RadioButton8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2RadioButton8.ForeColor = System.Drawing.Color.White;
            this.Guna2RadioButton8.Location = new System.Drawing.Point(11, 133);
            this.Guna2RadioButton8.Name = "Guna2RadioButton8";
            this.Guna2RadioButton8.Size = new System.Drawing.Size(177, 19);
            this.Guna2RadioButton8.TabIndex = 490;
            this.Guna2RadioButton8.Text = "Open MCFG Edit Menu [ LG ]";
            this.Guna2RadioButton8.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2RadioButton8.UncheckedState.BorderThickness = 3;
            this.Guna2RadioButton8.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2RadioButton8.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            // 
            // Guna2RadioButton17
            // 
            this.Guna2RadioButton17.Animated = true;
            this.Guna2RadioButton17.AutoSize = true;
            this.Guna2RadioButton17.CheckedState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2RadioButton17.CheckedState.BorderThickness = 3;
            this.Guna2RadioButton17.CheckedState.FillColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2RadioButton17.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(99)))), ((int)(((byte)(129)))));
            this.Guna2RadioButton17.CheckedState.InnerOffset = -6;
            this.Guna2RadioButton17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guna2RadioButton17.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2RadioButton17.ForeColor = System.Drawing.Color.White;
            this.Guna2RadioButton17.Location = new System.Drawing.Point(11, 208);
            this.Guna2RadioButton17.Name = "Guna2RadioButton17";
            this.Guna2RadioButton17.Size = new System.Drawing.Size(209, 19);
            this.Guna2RadioButton17.TabIndex = 501;
            this.Guna2RadioButton17.Text = "Open Hidden Services [ Samsung ]";
            this.Guna2RadioButton17.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2RadioButton17.UncheckedState.BorderThickness = 3;
            this.Guna2RadioButton17.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2RadioButton17.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            // 
            // Guna2RadioButton9
            // 
            this.Guna2RadioButton9.Animated = true;
            this.Guna2RadioButton9.AutoSize = true;
            this.Guna2RadioButton9.CheckedState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2RadioButton9.CheckedState.BorderThickness = 3;
            this.Guna2RadioButton9.CheckedState.FillColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2RadioButton9.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(99)))), ((int)(((byte)(129)))));
            this.Guna2RadioButton9.CheckedState.InnerOffset = -6;
            this.Guna2RadioButton9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guna2RadioButton9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2RadioButton9.ForeColor = System.Drawing.Color.White;
            this.Guna2RadioButton9.Location = new System.Drawing.Point(11, 108);
            this.Guna2RadioButton9.Name = "Guna2RadioButton9";
            this.Guna2RadioButton9.Size = new System.Drawing.Size(184, 19);
            this.Guna2RadioButton9.TabIndex = 489;
            this.Guna2RadioButton9.Text = "Open NOA Test Settings [ LG ]\r\n";
            this.Guna2RadioButton9.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2RadioButton9.UncheckedState.BorderThickness = 3;
            this.Guna2RadioButton9.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2RadioButton9.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            // 
            // Guna2RadioButton18
            // 
            this.Guna2RadioButton18.Animated = true;
            this.Guna2RadioButton18.AutoSize = true;
            this.Guna2RadioButton18.CheckedState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2RadioButton18.CheckedState.BorderThickness = 3;
            this.Guna2RadioButton18.CheckedState.FillColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2RadioButton18.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(99)))), ((int)(((byte)(129)))));
            this.Guna2RadioButton18.CheckedState.InnerOffset = -6;
            this.Guna2RadioButton18.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guna2RadioButton18.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2RadioButton18.ForeColor = System.Drawing.Color.White;
            this.Guna2RadioButton18.Location = new System.Drawing.Point(11, 183);
            this.Guna2RadioButton18.Name = "Guna2RadioButton18";
            this.Guna2RadioButton18.Size = new System.Drawing.Size(178, 19);
            this.Guna2RadioButton18.TabIndex = 500;
            this.Guna2RadioButton18.Text = "Open Usb Menu [ Samsung ]";
            this.Guna2RadioButton18.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2RadioButton18.UncheckedState.BorderThickness = 3;
            this.Guna2RadioButton18.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2RadioButton18.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            // 
            // Guna2RadioButton5
            // 
            this.Guna2RadioButton5.Animated = true;
            this.Guna2RadioButton5.AutoSize = true;
            this.Guna2RadioButton5.CheckedState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2RadioButton5.CheckedState.BorderThickness = 3;
            this.Guna2RadioButton5.CheckedState.FillColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2RadioButton5.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(99)))), ((int)(((byte)(129)))));
            this.Guna2RadioButton5.CheckedState.InnerOffset = -6;
            this.Guna2RadioButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guna2RadioButton5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2RadioButton5.ForeColor = System.Drawing.Color.White;
            this.Guna2RadioButton5.Location = new System.Drawing.Point(11, 58);
            this.Guna2RadioButton5.Name = "Guna2RadioButton5";
            this.Guna2RadioButton5.Size = new System.Drawing.Size(171, 19);
            this.Guna2RadioButton5.TabIndex = 487;
            this.Guna2RadioButton5.Text = "Open Add APN Menu [ LG ]\r\n";
            this.Guna2RadioButton5.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2RadioButton5.UncheckedState.BorderThickness = 3;
            this.Guna2RadioButton5.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2RadioButton5.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            // 
            // Guna2RadioButton19
            // 
            this.Guna2RadioButton19.Animated = true;
            this.Guna2RadioButton19.AutoSize = true;
            this.Guna2RadioButton19.CheckedState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2RadioButton19.CheckedState.BorderThickness = 3;
            this.Guna2RadioButton19.CheckedState.FillColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2RadioButton19.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(99)))), ((int)(((byte)(129)))));
            this.Guna2RadioButton19.CheckedState.InnerOffset = -6;
            this.Guna2RadioButton19.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guna2RadioButton19.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2RadioButton19.ForeColor = System.Drawing.Color.White;
            this.Guna2RadioButton19.Location = new System.Drawing.Point(11, 158);
            this.Guna2RadioButton19.Name = "Guna2RadioButton19";
            this.Guna2RadioButton19.Size = new System.Drawing.Size(179, 19);
            this.Guna2RadioButton19.TabIndex = 499;
            this.Guna2RadioButton19.Text = "Open SPC Menu [ Samsung ]";
            this.Guna2RadioButton19.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2RadioButton19.UncheckedState.BorderThickness = 3;
            this.Guna2RadioButton19.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2RadioButton19.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            // 
            // Guna2RadioButton3
            // 
            this.Guna2RadioButton3.Animated = true;
            this.Guna2RadioButton3.AutoSize = true;
            this.Guna2RadioButton3.CheckedState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2RadioButton3.CheckedState.BorderThickness = 3;
            this.Guna2RadioButton3.CheckedState.FillColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2RadioButton3.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(99)))), ((int)(((byte)(129)))));
            this.Guna2RadioButton3.CheckedState.InnerOffset = -6;
            this.Guna2RadioButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guna2RadioButton3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2RadioButton3.ForeColor = System.Drawing.Color.White;
            this.Guna2RadioButton3.Location = new System.Drawing.Point(11, 83);
            this.Guna2RadioButton3.Name = "Guna2RadioButton3";
            this.Guna2RadioButton3.Size = new System.Drawing.Size(220, 19);
            this.Guna2RadioButton3.TabIndex = 488;
            this.Guna2RadioButton3.Text = "Open Enable Bands Menu [ LG MTK ]";
            this.Guna2RadioButton3.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2RadioButton3.UncheckedState.BorderThickness = 3;
            this.Guna2RadioButton3.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2RadioButton3.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            // 
            // Guna2GroupBox5
            // 
            this.Guna2GroupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2GroupBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Guna2GroupBox5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2GroupBox5.BorderRadius = 6;
            this.Guna2GroupBox5.Controls.Add(this.Guna2Button48);
            this.Guna2GroupBox5.Cursor = System.Windows.Forms.Cursors.Default;
            this.Guna2GroupBox5.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2GroupBox5.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.Guna2GroupBox5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2GroupBox5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Guna2GroupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Guna2GroupBox5.Location = new System.Drawing.Point(8, 111);
            this.Guna2GroupBox5.Name = "Guna2GroupBox5";
            this.Guna2GroupBox5.ShadowDecoration.BorderRadius = 9;
            this.Guna2GroupBox5.ShadowDecoration.Color = System.Drawing.Color.White;
            this.Guna2GroupBox5.ShadowDecoration.Depth = 15;
            this.Guna2GroupBox5.Size = new System.Drawing.Size(465, 47);
            this.Guna2GroupBox5.TabIndex = 521;
            // 
            // Guna2Button48
            // 
            this.Guna2Button48.Animated = true;
            this.Guna2Button48.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2Button48.BorderRadius = 4;
            this.Guna2Button48.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.Guna2Button48.BorderThickness = 2;
            this.Guna2Button48.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button48.CheckedState.FillColor = System.Drawing.Color.LightGray;
            this.Guna2Button48.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button48.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
            this.Guna2Button48.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button48.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.Guna2Button48.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2Button48.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Guna2Button48.ForeColor = System.Drawing.Color.White;
            this.Guna2Button48.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button48.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button48.Image = global::Properties.Resources.magic_wand_auto_fix_button;
            this.Guna2Button48.ImageSize = new System.Drawing.Size(23, 23);
            this.Guna2Button48.Location = new System.Drawing.Point(9, 7);
            this.Guna2Button48.Name = "Guna2Button48";
            this.Guna2Button48.PressedColor = System.Drawing.Color.Empty;
            this.Guna2Button48.Size = new System.Drawing.Size(448, 32);
            this.Guna2Button48.TabIndex = 464;
            this.Guna2Button48.Text = "Repair Call Not Sent";
            this.Guna2Button48.TextFormatNoPrefix = true;
            this.Guna2Button48.Click += new System.EventHandler(this.Guna2Button48_Click);
            // 
            // Guna2GroupBox4
            // 
            this.Guna2GroupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2GroupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Guna2GroupBox4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2GroupBox4.BorderRadius = 6;
            this.Guna2GroupBox4.Controls.Add(this.Guna2RadioButton2);
            this.Guna2GroupBox4.Controls.Add(this.Guna2RadioButton1);
            this.Guna2GroupBox4.Controls.Add(this.Guna2RadioButton4);
            this.Guna2GroupBox4.Controls.Add(this.Guna2Button40);
            this.Guna2GroupBox4.Cursor = System.Windows.Forms.Cursors.Default;
            this.Guna2GroupBox4.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2GroupBox4.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.Guna2GroupBox4.Enabled = false;
            this.Guna2GroupBox4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2GroupBox4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Guna2GroupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Guna2GroupBox4.Location = new System.Drawing.Point(8, 8);
            this.Guna2GroupBox4.Name = "Guna2GroupBox4";
            this.Guna2GroupBox4.ShadowDecoration.BorderRadius = 9;
            this.Guna2GroupBox4.ShadowDecoration.Color = System.Drawing.Color.White;
            this.Guna2GroupBox4.ShadowDecoration.Depth = 15;
            this.Guna2GroupBox4.Size = new System.Drawing.Size(465, 97);
            this.Guna2GroupBox4.TabIndex = 521;
            // 
            // Guna2RadioButton2
            // 
            this.Guna2RadioButton2.Animated = true;
            this.Guna2RadioButton2.AutoSize = true;
            this.Guna2RadioButton2.BackColor = System.Drawing.Color.Transparent;
            this.Guna2RadioButton2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2RadioButton2.CheckedState.BorderThickness = 3;
            this.Guna2RadioButton2.CheckedState.FillColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2RadioButton2.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(99)))), ((int)(((byte)(129)))));
            this.Guna2RadioButton2.CheckedState.InnerOffset = -6;
            this.Guna2RadioButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guna2RadioButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2RadioButton2.ForeColor = System.Drawing.Color.White;
            this.Guna2RadioButton2.Location = new System.Drawing.Point(177, 18);
            this.Guna2RadioButton2.Name = "Guna2RadioButton2";
            this.Guna2RadioButton2.Size = new System.Drawing.Size(116, 19);
            this.Guna2RadioButton2.TabIndex = 477;
            this.Guna2RadioButton2.Text = "Method New Sec";
            this.Guna2RadioButton2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2RadioButton2.UncheckedState.BorderThickness = 3;
            this.Guna2RadioButton2.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2RadioButton2.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2RadioButton2.UseVisualStyleBackColor = false;
            this.Guna2RadioButton2.CheckedChanged += new System.EventHandler(this.Guna2RadioButton2_CheckedChanged);
            // 
            // Guna2RadioButton1
            // 
            this.Guna2RadioButton1.Animated = true;
            this.Guna2RadioButton1.AutoSize = true;
            this.Guna2RadioButton1.BackColor = System.Drawing.Color.Transparent;
            this.Guna2RadioButton1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2RadioButton1.CheckedState.BorderThickness = 3;
            this.Guna2RadioButton1.CheckedState.FillColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2RadioButton1.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(99)))), ((int)(((byte)(129)))));
            this.Guna2RadioButton1.CheckedState.InnerOffset = -6;
            this.Guna2RadioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guna2RadioButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2RadioButton1.ForeColor = System.Drawing.Color.White;
            this.Guna2RadioButton1.Location = new System.Drawing.Point(94, 18);
            this.Guna2RadioButton1.Name = "Guna2RadioButton1";
            this.Guna2RadioButton1.Size = new System.Drawing.Size(77, 19);
            this.Guna2RadioButton1.TabIndex = 476;
            this.Guna2RadioButton1.Text = "Method 2";
            this.Guna2RadioButton1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2RadioButton1.UncheckedState.BorderThickness = 3;
            this.Guna2RadioButton1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2RadioButton1.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2RadioButton1.UseVisualStyleBackColor = false;
            this.Guna2RadioButton1.CheckedChanged += new System.EventHandler(this.Guna2RadioButton1_CheckedChanged);
            // 
            // Guna2RadioButton4
            // 
            this.Guna2RadioButton4.Animated = true;
            this.Guna2RadioButton4.AutoSize = true;
            this.Guna2RadioButton4.BackColor = System.Drawing.Color.Transparent;
            this.Guna2RadioButton4.Checked = true;
            this.Guna2RadioButton4.CheckedState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2RadioButton4.CheckedState.BorderThickness = 3;
            this.Guna2RadioButton4.CheckedState.FillColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2RadioButton4.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(99)))), ((int)(((byte)(129)))));
            this.Guna2RadioButton4.CheckedState.InnerOffset = -6;
            this.Guna2RadioButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guna2RadioButton4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2RadioButton4.ForeColor = System.Drawing.Color.White;
            this.Guna2RadioButton4.Location = new System.Drawing.Point(13, 18);
            this.Guna2RadioButton4.Name = "Guna2RadioButton4";
            this.Guna2RadioButton4.Size = new System.Drawing.Size(75, 19);
            this.Guna2RadioButton4.TabIndex = 475;
            this.Guna2RadioButton4.TabStop = true;
            this.Guna2RadioButton4.Text = "Method 1";
            this.Guna2RadioButton4.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2RadioButton4.UncheckedState.BorderThickness = 3;
            this.Guna2RadioButton4.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2RadioButton4.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2RadioButton4.UseVisualStyleBackColor = false;
            this.Guna2RadioButton4.CheckedChanged += new System.EventHandler(this.Guna2RadioButton4_CheckedChanged);
            // 
            // Guna2Button40
            // 
            this.Guna2Button40.Animated = true;
            this.Guna2Button40.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2Button40.BorderRadius = 4;
            this.Guna2Button40.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.Guna2Button40.BorderThickness = 2;
            this.Guna2Button40.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button40.CheckedState.FillColor = System.Drawing.Color.LightGray;
            this.Guna2Button40.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button40.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
            this.Guna2Button40.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button40.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.Guna2Button40.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2Button40.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Guna2Button40.ForeColor = System.Drawing.Color.White;
            this.Guna2Button40.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button40.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button40.Image = global::Properties.Resources.video;
            this.Guna2Button40.Location = new System.Drawing.Point(9, 52);
            this.Guna2Button40.Name = "Guna2Button40";
            this.Guna2Button40.PressedColor = System.Drawing.Color.Empty;
            this.Guna2Button40.Size = new System.Drawing.Size(448, 32);
            this.Guna2Button40.TabIndex = 441;
            this.Guna2Button40.Text = "Start Remove KG";
            this.Guna2Button40.TextFormatNoPrefix = true;
            this.Guna2Button40.Click += new System.EventHandler(this.Guna2Button40_Click);
            // 
            // PictureBox2
            // 
            this.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox2.Location = new System.Drawing.Point(797, 631);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(10, 10);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox2.TabIndex = 462;
            this.PictureBox2.TabStop = false;
            this.PictureBox2.Visible = false;
            // 
            // TabControlExt1
            // 
            this.TabControlExt1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TabControlExt1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.TabControlExt1.CloseBtnColor = System.Drawing.Color.White;
            this.TabControlExt1.Controls.Add(this.TabPage2);
            this.TabControlExt1.Controls.Add(this.TabPage3);
            this.TabControlExt1.Controls.Add(this.TabPage4);
            this.TabControlExt1.Controls.Add(this.TabPage1);
            this.TabControlExt1.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControlExt1.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.TabControlExt1.HeadSelectedBackColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.TabControlExt1.HeadSelectedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.TabControlExt1.IsShowCloseBtn = false;
            this.TabControlExt1.ItemSize = new System.Drawing.Size(0, 30);
            this.TabControlExt1.Location = new System.Drawing.Point(3, 3);
            this.TabControlExt1.Name = "TabControlExt1";
            this.TabControlExt1.SelectedIndex = 0;
            this.TabControlExt1.Size = new System.Drawing.Size(489, 525);
            this.TabControlExt1.TabIndex = 524;
            this.TabControlExt1.TabTextColor = System.Drawing.Color.White;
            this.TabControlExt1.UncloseTabIndexs = null;
            // 
            // TabPage2
            // 
            this.TabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TabPage2.Controls.Add(this.Guna2GroupBox1);
            this.TabPage2.Controls.Add(this.Guna2GroupBox2);
            this.TabPage2.Location = new System.Drawing.Point(4, 34);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(481, 487);
            this.TabPage2.TabIndex = 0;
            this.TabPage2.Text = "Network ";
            // 
            // TabPage3
            // 
            this.TabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TabPage3.Controls.Add(this.Guna2GroupBox3);
            this.TabPage3.Location = new System.Drawing.Point(4, 34);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage3.Size = new System.Drawing.Size(481, 487);
            this.TabPage3.TabIndex = 1;
            this.TabPage3.Text = "VoLTE Custom";
            // 
            // TabPage4
            // 
            this.TabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TabPage4.Controls.Add(this.Guna2GroupBox4);
            this.TabPage4.Controls.Add(this.Guna2GroupBox5);
            this.TabPage4.Location = new System.Drawing.Point(4, 34);
            this.TabPage4.Name = "TabPage4";
            this.TabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage4.Size = new System.Drawing.Size(481, 487);
            this.TabPage4.TabIndex = 2;
            this.TabPage4.Text = "Remove KG  ";
            // 
            // TabPage1
            // 
            this.TabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TabPage1.Controls.Add(this.Guna2GroupBox7);
            this.TabPage1.Location = new System.Drawing.Point(4, 34);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Size = new System.Drawing.Size(481, 487);
            this.TabPage1.TabIndex = 3;
            this.TabPage1.Text = "Speed Services";
            // 
            // Services_Network
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(496, 534);
            this.ControlBox = false;
            this.Controls.Add(this.RichTextBox1);
            this.Controls.Add(this.Carrierbox);
            this.Controls.Add(this.TabControlExt1);
            this.Controls.Add(this.Temp_Credits);
            this.Controls.Add(this.text3);
            this.Controls.Add(this.TextBox4);
            this.Controls.Add(this.TextBox33);
            this.Controls.Add(this.ComboBox1);
            this.Controls.Add(this.RichTextBox2);
            this.Controls.Add(this.PictureBox2);
            this.Controls.Add(this.serialno);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Services_Network";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Services Network";
            this.Guna2GroupBox2.ResumeLayout(false);
            this.Guna2GroupBox1.ResumeLayout(false);
            this.Guna2GroupBox1.PerformLayout();
            this.Guna2GroupBox3.ResumeLayout(false);
            this.Guna2GroupBox3.PerformLayout();
            this.Guna2GroupBox7.ResumeLayout(false);
            this.Guna2GroupBox7.PerformLayout();
            this.Guna2GroupBox5.ResumeLayout(false);
            this.Guna2GroupBox4.ResumeLayout(false);
            this.Guna2GroupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            this.TabControlExt1.ResumeLayout(false);
            this.TabPage2.ResumeLayout(false);
            this.TabPage3.ResumeLayout(false);
            this.TabPage4.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

	}

	public Services_Network()
	{
		base.Load += Services_Network_Load;
		ThisLocation = AppDomain.CurrentDomain.BaseDirectory;
		saveFileDialog = new SaveFileDialog();
		openFileDialog = new OpenFileDialog();
		InitializeComponent();
		SharedUI = this;
	}

	public void StartProcess()
	{
		startTime = Strings.Format(DateAndTime.TimeOfDay, "hh:mm:ss");
	}

	public object ShowElapsedTime()
	{
		string str = Strings.Format(DateAndTime.TimeOfDay, "hh:mm:ss");
		checked
		{
			int num = (int)Math.Round(Conversion.Val(Strings.Mid(str, 4, 2)) - Conversion.Val(Strings.Mid(startTime, 4, 2)));
			int num2 = (int)Math.Round(Conversion.Val(Strings.Mid(str, 7, 2)) - Conversion.Val(Strings.Mid(startTime, 7, 2)));
			if (num2 < 0)
			{
				num2 = 60 + num2;
				num--;
			}
			return Strings.Format(num, "00") + ":" + Strings.Format(num2, "00");
		}
	}

	public void start()
	{
		try
		{
			SerialCOM.MSL = null;
			if (Operators.CompareString(cancel, "Cancel", TextCompare: false) == 0)
			{
				cancel = "";
			}
			StartProcess();
			Form1.SharedUI.RichTextBox1.Clear();
			ProgressChanged = Conversions.ToString(0);
			ProgressChanged = "0";
			idproos = GetNum();
			Form1.SharedUI.ProgressBar1.Text = "100%";
			Form1.SharedUI.Guna2TaskBarProgress1.Value = 0;
			Form1.SharedUI.Guna2TaskBarProgress1.State = Guna2TaskBarProgress.TaskbarStates.Indeterminate;
			Form1.SharedUI.ProgressBar1.Roll = true;
			Form1.SharedUI.MaterialCard3.Enabled = false;
			Form1.SharedUI.MaterialButton8.Enabled = true;
			File.Delete(ThisLocation + "tmp\\scan.wav");
			File.Delete(ThisLocation + "tmp\\wronganswer.wav");
			File.Delete(ThisLocation + "tmp\\wesreampung.wav");
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public void finsh()
	{
		SerialCOM.MSL = null;
		Form1.SharedUI.MaterialButton8.Enabled = false;
		Form1.SharedUI.MaterialButton20.Enabled = true;
		Form1.SharedUI.ProgressBar4.Visible = false;
		Form1.SharedUI.ProgressBar4.Value = 0;
		Form1.SharedUI.ProgressBar1.Text = "Finish Server Data..";
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- ID Operation : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(idproos);
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Time Elapsed : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(Conversions.ToString(ShowElapsedTime()));
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.Guna2TaskBarProgress1.State = Guna2TaskBarProgress.TaskbarStates.Normal;
		Form1.SharedUI.Guna2TaskBarProgress1.Value = 0;
		Form1.SharedUI.Guna2TaskBarProgress1.State = Guna2TaskBarProgress.TaskbarStates.Normal;
		Form1.SharedUI.Guna2TaskBarProgress1.Value = 0;
		Form1.SharedUI.ProgressBar1.Roll = false;
		Form1.SharedUI.ProgressBar1.Text = "100%";
		Form1.SharedUI.MaterialButton8.Enabled = false;
		Form1.SharedUI.MaterialCard3.Enabled = true;
		wesreampung_wav();
	}

	public string GetNum()
	{
		Random random = new Random();
		string text = "";
		while (text.Length != 9)
		{
			text += Conversions.ToString(random.Next(0, 10));
		}
		return text;
	}

	public void wesreampung_wav()
	{
		try
		{
			File.WriteAllBytes(Application.StartupPath + "/tmp/wesreampung.wav", Resources.wesreampung);
			SoundPlayer soundPlayer = new SoundPlayer();
			soundPlayer.SoundLocation = "tmp\\wesreampung.wav";
			soundPlayer.Load();
			soundPlayer.Play();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public void finshonly()
	{
		SerialCOM.MSL = null;
		Form1.SharedUI.ProgressBar1.Roll = false;
		Form1.SharedUI.MaterialButton8.Enabled = false;
		Form1.SharedUI.MaterialCard3.Enabled = true;
		Form1.SharedUI.ProgressBar1.Text = "100%";
		Form1.SharedUI.Guna2TaskBarProgress1.State = Guna2TaskBarProgress.TaskbarStates.Normal;
		Form1.SharedUI.Guna2TaskBarProgress1.Value = 0;
		Form1.SharedUI.Guna2TaskBarProgress1.State = Guna2TaskBarProgress.TaskbarStates.Normal;
		Form1.SharedUI.Guna2TaskBarProgress1.Value = 0;
	}

	private void wronganswer_wave()
	{
		try
		{
			File.WriteAllBytes(Application.StartupPath + "/tmp/wronganswer.wav", Resources.wronganswer);
			SoundPlayer soundPlayer = new SoundPlayer();
			soundPlayer.SoundLocation = "tmp\\wronganswer.wav";
			soundPlayer.Load();
			soundPlayer.Play();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void method_infoadb3chakccable()
	{
		Form1.SharedUI.ProgressBar4.Value = 0;
		ProgressChanged = Conversions.ToString(0);
		TextBox41 = "";
		TextBox10 = "";
		Form1.SharedUI.ProgressBar1.Text = "Start Adb Deamon..";
		while (true)
		{
			TextBox10 = Adb.ExecuteAdbCommand(Adb.FormAdbCommand("shell getprop ro.product.model", new object[0]), false);
			if (TextBox10.Contains("error: no devices/emulators found"))
			{
				if (Operators.CompareString(cancel, "Cancel", TextCompare: false) == 0)
				{
					ProgressBa = "Cen";
					cancel = "Cancel";
					break;
				}
				if (Form1.SharedUI.ProgressBar4.Value == 100)
				{
					ProgressBa = "Cen";
					TextBox10 = "NOT";
					break;
				}
				ProgressBa = "ENREADDEVICE";
				ProgressChanged = Conversions.ToString(Form1.SharedUI.ProgressBar4.Value);
				Form1.SharedUI.ProgressBar4.Text = "Wait For Device.." + ProgressChanged + "%";
				continue;
			}
			TextBox10 = "";
			ProgressBa = "DISREAD";
			Form1.SharedUI.ProgressBar1.Text = "Start Adb Deamon..";
			break;
		}
		if (Operators.CompareString(cancel, "Cancel", TextCompare: false) == 0 || Operators.CompareString(TextBox10, "NOT", TextCompare: false) == 0)
		{
			return;
		}
		while (true)
		{
			Form1.SharedUI.ProgressBar1.Text = "Wait For Yor Device..";
			Adb.ExecuteAdbCommand(Adb.FormAdbCommand("start-server", new object[0]), false);
			TextBox10 = Adb.ExecuteAdbCommand(Adb.FormAdbCommand("shell getprop ro.product.model", new object[0]), false);
			if (Operators.CompareString(cancel, "Cancel", TextCompare: false) == 0)
			{
				ProgressBa = "Cen";
				cancel = "Cancel";
				break;
			}
			if (!(TextBox10.Contains("error: device unauthorized.") | TextBox10.Contains("error: no devices/emulators found")))
			{
				break;
			}
			Form1.SharedUI.ProgressBar1.Text = "Checking Device State..";
			Adb.ExecuteAdbCommand(Adb.FormAdbCommand("kill-server", new object[0]), false);
		}
		if (Operators.CompareString(cancel, "Cancel", TextCompare: false) == 0)
		{
			return;
		}
		while (true)
		{
			TextBox10 = Adb.ExecuteAdbCommand(Adb.FormAdbCommand("shell getprop ro.product.model", new object[0]), false);
			if (TextBox10.Contains("error: more than one device/emulator"))
			{
				wronganswer_wave();
				MessageBox.Show("Sorry, But You Have 2 Devices Connected Unplug One Device To Continue", "Warning", MessageBoxButtons.OK);
				continue;
			}
			break;
		}
	}

	public void GetCsc()
	{
		if (Label15.Contains("LGE"))
		{
			csc = Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + serialno.Text + " shell getprop ro.vendor.lge.build.target_operator", new object[0]), false);
		}
		if (Label15.Contains("TINNO"))
		{
			csc = Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + serialno.Text + " shell getprop ro.product.operator", new object[0]), false);
			if (Operators.CompareString(csc, "", TextCompare: false) == 0)
			{
				csc = Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + serialno.Text + " shell getprop ro.carrier.default_id", new object[0]), false);
				Operators.CompareString(csc, "", TextCompare: false);
			}
		}
		if (Label15.Contains("google"))
		{
			csc = Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + serialno.Text + " shell getprop ro.product.product.brand", new object[0]), false);
		}
		if (Label15.Contains("OnePlus"))
		{
			csc = Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + serialno.Text + " shell getprop ro.boot.opcarrier", new object[0]), false);
		}
		if (Label15.Contains("Coolpad"))
		{
			csc = Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + serialno.Text + " shell getprop ro.home.operator.alpha", new object[0]), false);
		}
	}

	private void method_infoadb2()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("OK");
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Waiting for ADB Mode : ");
		method_infoadb3chakccable();
		if (Operators.CompareString(cancel, "Cancel", TextCompare: false) == 0)
		{
			ProgressBa = "Cen";
			return;
		}
		if (Operators.CompareString(TextBox10, "NOT", TextCompare: false) == 0)
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText("Not Found");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- TimeOut, Check The Cable And Try Again");
			finshonly();
			return;
		}
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("OK");
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Gathering Phone Info : ");
		Form1.SharedUI.ProgressBar1.Text = "Gathering Phone Info..";
		Form1.SharedUI.RichTextBox1.Update();
		serialnmber = Adb.ExecuteAdbCommand(Adb.FormAdbCommand("wait-for-device shell getprop ril.serialnumber", new object[0]), false);
		if (Operators.CompareString(cancel, "Cancel", TextCompare: false) == 0)
		{
			return;
		}
		serialno.Text = Adb.ExecuteAdbCommand(Adb.FormAdbCommand("wait-for-device shell getprop ro.serialno", new object[0]), false);
		if (Operators.CompareString(serialnmber, "", TextCompare: false) == 0)
		{
			serialnmber = Adb.ExecuteAdbCommand(Adb.FormAdbCommand("wait-for-device shell getprop ro.serialno", new object[0]), false);
			serialno.Text = Adb.ExecuteAdbCommand(Adb.FormAdbCommand("wait-for-device shell getprop ro.serialno", new object[0]), false);
		}
		security_patch = Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + serialno.Text + " shell getprop ro.build.version.security_patch", new object[0]), false);
		if (Operators.CompareString(cancel, "Cancel", TextCompare: false) == 0)
		{
			return;
		}
		baseband = Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + serialno.Text + " shell getprop gsm.version.baseband", new object[0]), false);
		if (Operators.CompareString(cancel, "Cancel", TextCompare: false) == 0)
		{
			return;
		}
		build_id = Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + serialno.Text + " shell getprop ro.build.id", new object[0]), false);
		if (Operators.CompareString(cancel, "Cancel", TextCompare: false) == 0)
		{
			return;
		}
		usb_config = Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + serialno.Text + " shell getprop sys.usb.config", new object[0]), false);
		sim_state = Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + serialno.Text + " shell getprop gsm.sim.state", new object[0]), false);
		if (Operators.CompareString(cancel, "Cancel", TextCompare: false) == 0)
		{
			return;
		}
		csc = Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + serialno.Text + " shell getprop ro.boot.carrierid", new object[0]), false);
		sales_code = Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + serialno.Text + " shell getprop ro.csc.sales_code", new object[0]), false);
		if (Operators.CompareString(cancel, "Cancel", TextCompare: false) == 0)
		{
			return;
		}
		knox = Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + serialno.Text + " shell getprop ro.warranty_bit", new object[0]), false);
		if (Operators.CompareString(knox, "", TextCompare: false) == 0)
		{
			knox = Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + serialno.Text + " shell getprop ro.boot.warranty_bit", new object[0]), false);
		}
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("[");
		Form1.SharedUI.RichTextBox1.AppendText(serialnmber);
		Form1.SharedUI.RichTextBox1.AppendText("] ");
		Form1.SharedUI.RichTextBox1.Update();
		Label15 = Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + serialno.Text + " shell getprop ro.product.manufacturer", new object[0]), false);
		if (!Label15.Contains("samsung"))
		{
			GetCsc();
			Operators.CompareString(csc, "", TextCompare: false);
		}
		if (Operators.CompareString(cancel, "Cancel", TextCompare: false) == 0)
		{
			return;
		}
		if (Label15.Contains("LGE"))
		{
			Label4 = Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + serialno.Text + " shell getprop ro.boot.vendor.lge.model.name", new object[0]), false);
			if (Operators.CompareString(Label4, "", TextCompare: false) == 0)
			{
				Label4 = Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + serialno.Text + " shell getprop ro.product.model", new object[0]), false);
			}
		}
		else if (Label15.Contains("motoro"))
		{
			Label4 = Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + serialno.Text + " shell getprop ro.boot.hardware.sku", new object[0]), false);
		}
		else
		{
			Label4 = Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + serialno.Text + " shell getprop ro.product.model", new object[0]), false);
		}
		QcomString = Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + serialno.Text + " shell getprop ro.boot.hardware", new object[0]), false);
		if (Operators.CompareString(TextBox41, "Cancel", TextCompare: false) == 0)
		{
			return;
		}
		Label9 = Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + serialno.Text + " shell getprop ro.build.version.release", new object[0]), false);
		if (Operators.CompareString(cancel, "Cancel", TextCompare: false) == 0)
		{
			return;
		}
		Form1.SharedUI.RichTextBox1.AppendText("OK");
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Brand : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(Label15);
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Phone Model : ");
		Label4 = Label4.Replace("SAMSUNG-", "").Replace("-1", "").Replace("-2", "")
			.Replace("-3", "")
			.Replace("-4", "")
			.Replace("-5", "")
			.Replace("-6", "")
			.Replace("-7", "")
			.Replace("-8", "")
			.Replace("-9", "");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(Label4);
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Android Version : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(Label9);
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Security Patch : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(security_patch);
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Baseband : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(baseband);
		if (Operators.CompareString(knox, "", TextCompare: false) != 0)
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Knox : ");
			Form1.SharedUI.RichTextBox1.Update();
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText(knox);
			Form1.SharedUI.RichTextBox1.Update();
		}
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Build id : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(build_id);
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Hardware : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(QcomString);
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- SIM Info : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(sim_state);
		Form1.SharedUI.RichTextBox1.Update();
		if (Label15.Contains("samsung"))
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Carrier : ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.Update();
			if (Operators.CompareString(csc, "", TextCompare: false) == 0)
			{
				Form1.SharedUI.RichTextBox1.AppendText(sales_code);
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.AppendText("/");
				Form1.SharedUI.RichTextBox1.AppendText(sales_code);
			}
			else if (Operators.CompareString(sales_code, "", TextCompare: false) == 0)
			{
				Form1.SharedUI.RichTextBox1.AppendText(csc);
				Form1.SharedUI.RichTextBox1.Update();
			}
			else
			{
				Form1.SharedUI.RichTextBox1.AppendText(sales_code);
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.AppendText("/");
				Form1.SharedUI.RichTextBox1.AppendText(sales_code);
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.AppendText("/");
				Form1.SharedUI.RichTextBox1.AppendText(csc);
				Form1.SharedUI.RichTextBox1.Update();
			}
		}
		else if (Operators.CompareString(csc, "", TextCompare: false) != 0)
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Carrier : ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.Update();
			Form1.SharedUI.RichTextBox1.AppendText(csc);
			Form1.SharedUI.RichTextBox1.Update();
		}
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- USB State : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(usb_config);
		Form1.SharedUI.RichTextBox1.Update();
		try
		{
			if (Operators.CompareString(baseband, "", TextCompare: false) != 0)
			{
				device_info.secunumber = baseband.Substring(8, 4);
				device_info.secunumber = device_info.secunumber;
			}
			device_info.Android = Label9;
			device_info.model = Label4;
			device_info.security_patch = security_patch;
			device_info.Build_id = build_id;
			device_info.Brand = Label15;
			if ((Operators.CompareString(serialnmber, "", TextCompare: false) == 0) | serialnmber.Contains("000000000"))
			{
				device_info.serialno = serialno.Text;
			}
			else
			{
				device_info.serialno = serialnmber;
			}
			device_info.Carrier = csc;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		Form1.SharedUI.ProgressBar1.Text = "Connecting To Server..";
	}

	private void Guna2Button6_Click(object sender, EventArgs e)
	{
		start();
		ThreadNew = new Thread(method_adb9);
		ThreadNew.Start();
	}

	internal static void W_1CDMA()
	{
		TX("2752C34279204461746120556e6c6f636b20546f6f6c000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000010167E", crc: true);
	}

	private void SPC_PWD2()
	{
		TX("4B0B24005D0200000E00550006003030303030300B3E7E", crc: false);
		TX("4B0B24005D0200000E00550006003030303030300B3E7E", crc: false);
		TX("4B0B24005D0200000E00550006003030303030300B3E7E", crc: false);
		TX("465903365113726913282B7E", crc: false);
		TX("46FFFFFFFFFFFFFFFF00FDEE7E", crc: false);
		TX("41303030303030DF8A7E", crc: false);
		TX("41303030303030DF8A7E", crc: false);
		TX("41303030303030DF8A7E", crc: false);
		TX("465903365113726913282B7E", crc: false);
		TX("46201211212013121994247E", crc: false);
		TX("462013051320130909BC4A7E", crc: false);
		TX("46201211212013121994247E", crc: false);
		TX("462009031920090615BAED7E", crc: false);
		TX("462009031920090615BAED7E", crc: false);
		TX("4620100316197807215C727E", crc: false);
		TX("46FFFFFFFFFFFFFFFFFE747E", crc: false);
		TX("462FF811282FF9F32337A97E", crc: false);
		TX("4620100316197807215C727E", crc: false);
		TX("46201411242015020217B77E", crc: false);
		TX("4620100316197807215C727E", crc: false);
		W_1CDMA();
	}

	private void SWCDMA()
	{
		TX("270A0000130000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000CF757E", crc: true);
		TX("270A00130000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000009BE87E", crc: true);
		TX("2764130200000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000014047E", crc: true);
		TX("276C1001000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000078A7E", crc: true);
		TX("273202010000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000B147E", crc: true);
		TX("270201000300000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000005CC37E", crc: true);
		TX("270B0000010000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000FDC27E", crc: true);
		TX("27BA01000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000A747E", crc: true);
		TX("27CB0101000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000A86A7E", crc: true);
		TX("27570300000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000BC307E", crc: true);
		TX("26570300000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000A9007E", crc: true);
		TX("4B130800706F6C6963796D616E2F667265715F6C6973740032BD7E", crc: true);
		TX("4B130800706F6C6963796D616E2F667265715F6C6973745F537562736372697074696F6E303100616A7E", crc: true);
		TX("4B130800706F6C6963796D616E2F69676E6F72655F6D63633262616E64735F6D646200B5D97E", crc: true);
		TX("27EA1B000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000189E7E", crc: true);
		TX("27FE1B000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000375C7E", crc: true);
		TX("2752C34279204461746120556e6c6f636b20546f6f6c000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000010167E", crc: true);
		TX("2753C34E393530552E30303100000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000032097E", crc: true);
		TX("2754C3524556312E300000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000009B547E", crc: true);
		TX("2758C3000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000E4347E", crc: true);
		TX("2759C3000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000C5AA7E", crc: true);
		TX("2760C35E4F0A0C000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000057E57E", crc: true);
		TX("27ACC3010000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000DCA07E", crc: true);
		TX("27B3C3565A57000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000B87B7E", crc: true);
		TX("4B1308006E762F6974656D5F66696C65732F6D6F64656D2F6D6D6F64652F63646D615F6C657373001D167E", crc: true);
		TX("4B130800706F6C6963796D616E2F6465766963655F636F6E6669670082007E", crc: true);
		TX("4B130800706F6C6963796D616E2F636172726965725F706F6C6963792E786D6C00F4BA7E", crc: true);
		TX("4B130800706F6C6963796D616E2F7261745F6D61736B0073607E", crc: true);
		TX("4B130800706F6C6963796D616E2F7376635F6D6F64655F537562736372697074696F6E303100AE4C7E", crc: true);
		TX("4B130800706F6C6963796D616E2F7376635F6D6F646500EBA57E", crc: true);
		TX("4B130800706F6C6963796D616E2F7261745F6D61736B5F537562736372697074696F6E303100AFC87E", crc: true);
		TX("4B130800706F6C6963796D616E2F75655F6D6F646500EF277E", crc: true);
		TX("4B130800706F6C6963796D616E2F75655F6D6F64655F537562736372697074696F6E3031001D1F7E", crc: true);
		TX("4B130800706F6C6963796D616E2F7261745F6D61736B5F537562736372697074696F6E303100AFC87E", crc: true);
		TX("4B130800706F6C6963796D616E2F706F6C696379332F636172726965725F706F6C6963792E786D6C00B27A7E", crc: true);
		TX("4B130800706F6C6963796D616E2F63616C6C5F6D6F64650098FA7E", crc: true);
		TX("4B130800706F6C6963796D616E2F63616C6C5F6D6F64655F537562736372697074696F6E30310003EA7E", crc: true);
		TX("4B130800706F6C6963796D616E2F63757272656E745F6D636300A6077E", crc: true);
		TX("4B130800706F6C6963796D616E2F63757272656E745F6D63635F537562736372697074696F6E30310048387E", crc: true);
		TX("4B130800706F6C6963796D616E2F706F6C696379312F636172726965725F706F6C6963792E786D6C006A147E", crc: true);
		TX("4B130800706F6C6963796D616E2F63757272656E745F6D636300A6077E", crc: true);
		TX("4B130800706F6C6963796D616E2F6465766963655F636F6E6669670082007E", crc: true);
		TX("4B130800706F6C6963796D616E2F7261745F6D61736B0073607E", crc: true);
		TX("4B130800706F6C6963796D616E2F7261745F6D61736B5F537562736372697074696F6E303100AFC87E", crc: true);
		TX("4B130800706F6C6963796D616E2F7376635F6D6F646500EBA57E", crc: true);
		TX("4B130800706F6C6963796D616E2F7376635F6D6F64655F537562736372697074696F6E303100AE4C7E", crc: true);
		TX("4B130800706F6C6963796D616E2F75655F6D6F646500EF277E", crc: true);
		TX("4B130800706F6C6963796D616E2F75655F6D6F64655F537562736372697074696F6E3031001D1F7E", crc: true);
		TX("4B130800706F6C6963796D616E2F706F6C696379312F636172726965725F706F6C6963792E786D6C006A147E", crc: true);
		TX("4B130800706F6C6963796D616E2F706F6C696379322F636172726965725F706F6C6963792E786D6C00DE4D7E", crc: true);
		TX("4B130800706F6C6963796D616E2F706F6C696379332F636172726965725F706F6C6963792E786D6C00B27A7E", crc: true);
		TX("4B130800706F6C6963796D616E2F6465766963655F636F6E6669672E786D6C00B5607E", crc: true);
		TX("278C2701000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000006BEC7E", crc: true);
		TX("278C2701000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000006BEC7E", crc: true);
		TX("278C2701000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000006BEC7E", crc: true);
		TX("278C2701000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000006BEC7E", crc: true);
	}

	private void Wband()
	{
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Analyze Data Security : ");
		Form1.SharedUI.ProgressBar1.Text = "Analyzeing Security..";
		cdmaTerm.SendTerminalCommand("265507000000000000000000000000000000000000000000000000", true);
		FromHex(cdmaTerm.thePhone.LogData.Replace("RX:", "@").Replace("\r\n", "").Replace(" ", "")
			.Split('@')[1].Substring(2, 50));
		cdmaTerm.SendTerminalCommand("2755078743E8060000020000000000000000000000000000000000000000000000000000000000000000000000", true);
		cdmaTerm.SendTerminalCommand("2755078743E8060000020000000000000000000000000000000000000000000000000000000000000000000000", true);
		cdmaTerm.SendTerminalCommand("2755078743E8060000020000000000000000000000000000000000000000000000000000000000000000000000", true);
		cdmaTerm.SendTerminalCommand("265507000000000000000000000000000000000000000000000000", true);
		if (cdmaTerm.thePhone.LogData.Replace("RX:", "@").Replace("\r\n", "").Replace(" ", "")
			.Split('@')[1].Contains("8743E80600000200"))
		{
			Method = "Method-1";
			SWCDMA();
			return;
		}
		cdmaTerm.SendTerminalCommand("265507000000000000000000000000000000000000000000000000", true);
		FromHex(cdmaTerm.thePhone.LogData.Replace("RX:", "@").Replace("\r\n", "").Replace(" ", "")
			.Split('@')[1].Substring(2, 50));
		cdmaTerm.SendTerminalCommand("27550706400000000000000000000000000000000000000000000000", true);
		cdmaTerm.SendTerminalCommand("27550706400000000000000000000000000000000000000000000000", true);
		cdmaTerm.SendTerminalCommand("27550706400000000000000000000000000000000000000000000000", true);
		cdmaTerm.SendTerminalCommand("265507000000000000000000000000000000000000000000000000", true);
		if (cdmaTerm.thePhone.LogData.Replace("RX:", "@").Replace("\r\n", "").Replace(" ", "")
			.Split('@')[1].Contains("5507064000000000"))
		{
			Method = "Method-2";
			SWCDMA();
			return;
		}
		cdmaTerm.SendTerminalCommand("265507000000000000000000000000000000000000000000000000", true);
		FromHex(cdmaTerm.thePhone.LogData.Replace("RX:", "@").Replace("\r\n", "").Replace(" ", "")
			.Split('@')[1].Substring(2, 50));
		cdmaTerm.SendTerminalCommand("2755070602000006E80380000000000000000000000000000000000000000000000000000000000000", true);
		cdmaTerm.SendTerminalCommand("2755070602000006E80380000000000000000000000000000000000000000000000000000000000000", true);
		cdmaTerm.SendTerminalCommand("2755070602000006E80380000000000000000000000000000000000000000000000000000000000000", true);
		cdmaTerm.SendTerminalCommand("265507000000000000000000000000000000000000000000000000", true);
		if (cdmaTerm.thePhone.LogData.Replace("RX:", "@").Replace("\r\n", "").Replace(" ", "")
			.Split('@')[1].Contains("0602000006E80380000000000000"))
		{
			Method = "Method-3";
			SWCDMA();
		}
		else
		{
			cdmaTerm.SendTerminalCommand("275507000000000000000000000000000000000000000000000000000000000000", true);
			Method = "NO";
		}
	}

	public void checkport()
	{
		Name_Com = null;
		new ManagementObjectSearcher("SELECT * FROM WIN32_SerialPort").Get();
		foreach (COMPortInfoO item in COMPortInfoO.GetCOMPortsInfoO())
		{
			Name_Com = string.Format("{0}{1}", "\r", item.Description);
		}
	}

	public void method_Samsung_noQCN()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Analyze Device Port : ");
		Form1.SharedUI.ProgressBar1.Text = "Analyzeing..";
		if (Guna2ComboBox1.Text.Contains("USB Serial Port") | Guna2ComboBox1.Text.Contains("HS-USB") | Guna2ComboBox1.Text.Contains("Diagnostics"))
		{
			Name_Com = checked(Guna2ComboBox1.Text.Substring(Guna2ComboBox1.Text.IndexOf("(") + 1, Guna2ComboBox1.Text.Length - 2 - Guna2ComboBox1.Text.IndexOf("("))).Replace(")", "");
			cdmaTerm.Connect(Name_Com);
			if (!cdmaTerm.portIsOpen)
			{
				cdmaTerm.Disconnect();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
				Form1.SharedUI.RichTextBox1.AppendText("Port Opening Failed");
				finshonly();
			}
			else
			{
				if (!cdmaTerm.portIsOpen)
				{
					return;
				}
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Connected");
				Info();
				if (Operators.CompareString(Method, "no", TextCompare: false) == 0)
				{
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
					Form1.SharedUI.RichTextBox1.AppendText("Port Opening Failed, Please Select Other Port");
					Form1.SharedUI.RichTextBox1.Update();
					cdmaTerm.Disconnect();
					finshonly();
					return;
				}
				Method = "";
				SPC_PWD3();
				Wband();
				if (Operators.CompareString(Method, "No", TextCompare: false) == 0)
				{
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
					Form1.SharedUI.RichTextBox1.AppendText("Not Supported");
					Form1.SharedUI.RichTextBox1.Update();
					cdmaTerm.Disconnect();
					finshonly();
				}
				else
				{
					method_CONVRT2();
					cdmaTerm.Disconnect();
					finsh();
				}
			}
		}
		else
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText("Port Not Found");
			finshonly();
		}
	}

	public void wait_booted(bool log_allow)
	{
		if (log_allow)
		{
			Form1.SharedUI.ProgressBar1.Text = "Wait For Device..(" + serialno.Text + ")";
		}
		while (Operators.CompareString(cancel, "Cancel", TextCompare: false) != 0)
		{
			string text = Conversions.ToString(Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + serialno.Text + " shell getprop sys.boot_completed", new object[0]), false));
			if (text.Contains("1") & !text.Contains("'"))
			{
				if (log_allow)
				{
					Form1.SharedUI.ProgressBar1.Text = "Waiting..";
				}
				break;
			}
		}
	}

	public void method_Samsung_QCN()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Analyze Device Port : ");
		Form1.SharedUI.ProgressBar1.Text = "Analyzeing..";
		checked
		{
			try
			{
				Process[] processesByName = Process.GetProcessesByName("7z");
				int num = 0;
				do
				{
					processesByName[num].Kill();
					num++;
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
			try
			{
				Process[] processesByName2 = Process.GetProcessesByName("qc");
				int num2 = 0;
				do
				{
					processesByName2[num2].Kill();
					num2++;
				}
				while (num2 < processesByName2.Length);
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception projectError2 = ex2;
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
			}
			try
			{
				Process[] processesByName3 = Process.GetProcessesByName("Tunlocker Tool");
				int num3 = 0;
				do
				{
					processesByName3[num3].Kill();
					num3++;
				}
				while (num3 < processesByName3.Length);
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception projectError3 = ex3;
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
			}
			if (Guna2ComboBox1.Text.Contains("USB Serial Port") | Guna2ComboBox1.Text.Contains("HS-USB") | Guna2ComboBox1.Text.Contains("Diagnostics"))
			{
				Name_Com = Guna2ComboBox1.Text.Substring(Guna2ComboBox1.Text.IndexOf("(") + 1, Guna2ComboBox1.Text.Length - 2 - Guna2ComboBox1.Text.IndexOf("(")).Replace(")", "");
				cdmaTerm.Connect(Name_Com);
				if (!cdmaTerm.portIsOpen)
				{
					cdmaTerm.Disconnect();
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
					Form1.SharedUI.RichTextBox1.AppendText("Port Opening Failed");
					finshonly();
				}
				else
				{
					if (!cdmaTerm.portIsOpen)
					{
						return;
					}
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
					Form1.SharedUI.RichTextBox1.AppendText("Connected");
					Info();
					if (Operators.CompareString(Method, "no", TextCompare: false) == 0)
					{
						Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
						Form1.SharedUI.RichTextBox1.AppendText("Port Opening Failed, Please Select Other Port");
						Form1.SharedUI.RichTextBox1.Update();
						cdmaTerm.Disconnect();
						finshonly();
						return;
					}
					Method = "";
					SPC_PWD3();
					IMEI = read_IMEI();
					MEID = read_MEID();
					cdmaTerm.Disconnect();
					if ("SM-A025V-SM-A025AP-SM-A025AZ-SM-A025A".Contains(Label4))
					{
						tmp = "tmp\\N\\2";
					}
					else
					{
						tmp = "tmp\\N\\1";
					}
					nembr_com = Conversions.ToInteger(Name_Com.Replace("COM", ""));
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
					Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Prepair Device : ");
					if (CKAUTO_CONN.Checked)
					{
						if (nembr_com > 150)
						{
							Form1.SharedUI.ProgressBar1.Text = "Analyzeing Ports..";
							Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + serialno.Text + " shell reboot", new object[0]), false);
							namefile = "DCAPI.exe";
							string path = ThisLocation + "tmp\\" + namefile;
							try
							{
								File.Delete(path);
							}
							catch (Exception ex4)
							{
								ProjectData.SetProjectError(ex4);
								Exception ex5 = ex4;
								ProjectData.ClearProjectError();
							}
							File.WriteAllBytes(ThisLocation + "tmp\\DCAPI.exe", Resources.DCAPI);
							namefile = "reset.bat";
							path = ThisLocation + "tmp\\" + namefile;
							try
							{
								MyProject.Computer.FileSystem.DeleteDirectory(path, DeleteDirectoryOption.DeleteAllContents);
							}
							catch (Exception ex6)
							{
								ProjectData.SetProjectError(ex6);
								Exception ex7 = ex6;
								ProjectData.ClearProjectError();
							}
							File.WriteAllBytes(ThisLocation + "tmp\\reset.bat", Resources.comportreset);
							Delay(6.0);
							string_13 = "tmp\\DCAPI.exe *";
							Zero_ALL();
							runExFB("tmp\\reset.bat");
							Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
							Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Waiting For Device : ");
							wait_booted(log_allow: true);
							Delay(2.0);
							Form1.SharedUI.ProgressBar1.Text = "Checking Ports..";
							Guna2ComboBox1.Items.Clear();
							new ManagementObjectSearcher("SELECT * FROM WIN32_SerialPort").Get();
							foreach (COMPortInfoO item in COMPortInfoO.GetCOMPortsInfoO())
							{
								Guna2ComboBox1.Items.Add(string.Format("{0}{1}", "\r", item.Description));
							}
							if (Guna2ComboBox1.Items.Count != 0)
							{
								Guna2ComboBox1.SelectedIndex = 0;
							}
							Count = Conversions.ToString(Guna2ComboBox1.Items.Count);
							if (Operators.CompareString(Count, "1", TextCompare: false) == 0)
							{
								Guna2ComboBox1.SelectedIndex = 0;
								text3.Text = Guna2ComboBox1.SelectedItem.ToString();
								if (!(text3.Text.Contains("USB Serial Port") | Guna2ComboBox1.Text.Contains("HS-USB") | Guna2ComboBox1.Text.Contains("Diagnostics")))
								{
									Guna2ComboBox1.Items.RemoveAt(Guna2ComboBox1.SelectedIndex);
								}
							}
							if (Operators.CompareString(Count, "2", TextCompare: false) == 0)
							{
								Guna2ComboBox1.SelectedIndex = 0;
								text3.Text = Guna2ComboBox1.SelectedItem.ToString();
								if (!(text3.Text.Contains("USB Serial Port") | Guna2ComboBox1.Text.Contains("HS-USB") | Guna2ComboBox1.Text.Contains("Diagnostics")))
								{
									Guna2ComboBox1.Items.RemoveAt(Guna2ComboBox1.SelectedIndex);
								}
								Guna2ComboBox1.SelectedIndex = 1;
								text3.Text = Guna2ComboBox1.SelectedItem.ToString();
								if (!(text3.Text.Contains("USB Serial Port") | Guna2ComboBox1.Text.Contains("HS-USB") | Guna2ComboBox1.Text.Contains("Diagnostics")))
								{
									Guna2ComboBox1.Items.RemoveAt(Guna2ComboBox1.SelectedIndex);
								}
							}
							if (Operators.CompareString(Count, "3", TextCompare: false) == 0)
							{
								Guna2ComboBox1.SelectedIndex = 0;
								text3.Text = Guna2ComboBox1.SelectedItem.ToString();
								if (!(text3.Text.Contains("USB Serial Port") | Guna2ComboBox1.Text.Contains("HS-USB") | Guna2ComboBox1.Text.Contains("Diagnostics")))
								{
									Guna2ComboBox1.Items.RemoveAt(Guna2ComboBox1.SelectedIndex);
								}
								Guna2ComboBox1.SelectedIndex = 1;
								text3.Text = Guna2ComboBox1.SelectedItem.ToString();
								if (!(text3.Text.Contains("USB Serial Port") | Guna2ComboBox1.Text.Contains("HS-USB") | Guna2ComboBox1.Text.Contains("Diagnostics")))
								{
									Guna2ComboBox1.Items.RemoveAt(Guna2ComboBox1.SelectedIndex);
								}
								Guna2ComboBox1.SelectedIndex = 2;
								text3.Text = Guna2ComboBox1.SelectedItem.ToString();
								if (!(text3.Text.Contains("USB Serial Port") | Guna2ComboBox1.Text.Contains("HS-USB") | Guna2ComboBox1.Text.Contains("Diagnostics")))
								{
									Guna2ComboBox1.Items.RemoveAt(Guna2ComboBox1.SelectedIndex);
								}
							}
							if (Operators.CompareString(Count, "4", TextCompare: false) == 0)
							{
								Guna2ComboBox1.SelectedIndex = 0;
								text3.Text = Guna2ComboBox1.SelectedItem.ToString();
								if (!(text3.Text.Contains("USB Serial Port") | Guna2ComboBox1.Text.Contains("HS-USB") | Guna2ComboBox1.Text.Contains("Diagnostics")))
								{
									Guna2ComboBox1.Items.RemoveAt(Guna2ComboBox1.SelectedIndex);
								}
								Guna2ComboBox1.SelectedIndex = 1;
								text3.Text = Guna2ComboBox1.SelectedItem.ToString();
								if (!(text3.Text.Contains("USB Serial Port") | Guna2ComboBox1.Text.Contains("HS-USB") | Guna2ComboBox1.Text.Contains("Diagnostics")))
								{
									Guna2ComboBox1.Items.RemoveAt(Guna2ComboBox1.SelectedIndex);
								}
								Guna2ComboBox1.SelectedIndex = 2;
								text3.Text = Guna2ComboBox1.SelectedItem.ToString();
								if (!(text3.Text.Contains("USB Serial Port") | Guna2ComboBox1.Text.Contains("HS-USB") | Guna2ComboBox1.Text.Contains("Diagnostics")))
								{
									Guna2ComboBox1.Items.RemoveAt(Guna2ComboBox1.SelectedIndex);
								}
								Guna2ComboBox1.SelectedIndex = 3;
								text3.Text = Guna2ComboBox1.SelectedItem.ToString();
								if (!(text3.Text.Contains("USB Serial Port") | Guna2ComboBox1.Text.Contains("HS-USB") | Guna2ComboBox1.Text.Contains("Diagnostics")))
								{
									Guna2ComboBox1.Items.RemoveAt(Guna2ComboBox1.SelectedIndex);
								}
							}
							Count = Conversions.ToString(Guna2ComboBox1.Items.Count);
							if (Operators.CompareString(Count, "2", TextCompare: false) == 0)
							{
								Guna2ComboBox1.SelectedIndex = 0;
								Name_Com = Guna2ComboBox1.Text.Substring(Guna2ComboBox1.Text.IndexOf("(") + 1, Guna2ComboBox1.Text.Length - 2 - Guna2ComboBox1.Text.IndexOf("(")).Replace(")", "");
								cdmaTerm.Connect(Name_Com);
								SPC_PWD2();
								IMEI = read_IMEI();
								MEID = read_MEID();
								Delay(1.0);
								if (IMEI.Contains("0000000000000000"))
								{
									cdmaTerm.Disconnect();
									Guna2ComboBox1.SelectedIndex = 1;
									Name_Com = Guna2ComboBox1.Text.Substring(Guna2ComboBox1.Text.IndexOf("(") + 1, Guna2ComboBox1.Text.Length - 2 - Guna2ComboBox1.Text.IndexOf("(")).Replace(")", "");
									cdmaTerm.Connect(Name_Com);
									SPC_PWD2();
									IMEI = read_IMEI();
									MEID = read_MEID();
									cdmaTerm.Disconnect();
								}
								else
								{
									cdmaTerm.Disconnect();
								}
							}
							else if (Operators.CompareString(Count, "3", TextCompare: false) == 0)
							{
								Guna2ComboBox1.SelectedIndex = 0;
								Name_Com = Guna2ComboBox1.Text.Substring(Guna2ComboBox1.Text.IndexOf("(") + 1, Guna2ComboBox1.Text.Length - 2 - Guna2ComboBox1.Text.IndexOf("(")).Replace(")", "");
								cdmaTerm.Connect(Name_Com);
								SPC_PWD2();
								IMEI = read_IMEI();
								MEID = read_MEID();
								Delay(1.0);
								if (IMEI.Contains("0000000000000000"))
								{
									cdmaTerm.Disconnect();
									Guna2ComboBox1.SelectedIndex = 1;
									Name_Com = Guna2ComboBox1.Text.Substring(Guna2ComboBox1.Text.IndexOf("(") + 1, Guna2ComboBox1.Text.Length - 2 - Guna2ComboBox1.Text.IndexOf("(")).Replace(")", "");
									cdmaTerm.Connect(Name_Com);
									SPC_PWD2();
									IMEI = read_IMEI();
									MEID = read_MEID();
									Delay(1.0);
									if (IMEI.Contains("0000000000000000"))
									{
										cdmaTerm.Disconnect();
										Guna2ComboBox1.SelectedIndex = 2;
										Name_Com = Guna2ComboBox1.Text.Substring(Guna2ComboBox1.Text.IndexOf("(") + 1, Guna2ComboBox1.Text.Length - 2 - Guna2ComboBox1.Text.IndexOf("(")).Replace(")", "");
										cdmaTerm.Connect(Name_Com);
										SPC_PWD2();
										IMEI = read_IMEI();
										MEID = read_MEID();
										cdmaTerm.Disconnect();
									}
									else
									{
										cdmaTerm.Disconnect();
									}
								}
								else
								{
									cdmaTerm.Disconnect();
								}
							}
							else if (Operators.CompareString(Count, "4", TextCompare: false) == 0)
							{
								Guna2ComboBox1.SelectedIndex = 0;
								Name_Com = Guna2ComboBox1.Text.Substring(Guna2ComboBox1.Text.IndexOf("(") + 1, Guna2ComboBox1.Text.Length - 2 - Guna2ComboBox1.Text.IndexOf("(")).Replace(")", "");
								cdmaTerm.Connect(Name_Com);
								SPC_PWD2();
								IMEI = read_IMEI();
								MEID = read_MEID();
								Delay(1.0);
								if (IMEI.Contains("0000000000000000"))
								{
									cdmaTerm.Disconnect();
									Guna2ComboBox1.SelectedIndex = 1;
									Name_Com = Guna2ComboBox1.Text.Substring(Guna2ComboBox1.Text.IndexOf("(") + 1, Guna2ComboBox1.Text.Length - 2 - Guna2ComboBox1.Text.IndexOf("(")).Replace(")", "");
									cdmaTerm.Connect(Name_Com);
									SPC_PWD2();
									IMEI = read_IMEI();
									MEID = read_MEID();
									Delay(1.0);
									if (IMEI.Contains("0000000000000000"))
									{
										cdmaTerm.Disconnect();
										Guna2ComboBox1.SelectedIndex = 2;
										Name_Com = Guna2ComboBox1.Text.Substring(Guna2ComboBox1.Text.IndexOf("(") + 1, Guna2ComboBox1.Text.Length - 2 - Guna2ComboBox1.Text.IndexOf("(")).Replace(")", "");
										cdmaTerm.Connect(Name_Com);
										SPC_PWD2();
										IMEI = read_IMEI();
										MEID = read_MEID();
										Delay(1.0);
										if (IMEI.Contains("0000000000000000"))
										{
											cdmaTerm.Disconnect();
											Guna2ComboBox1.SelectedIndex = 3;
											Name_Com = Guna2ComboBox1.Text.Substring(Guna2ComboBox1.Text.IndexOf("(") + 1, Guna2ComboBox1.Text.Length - 2 - Guna2ComboBox1.Text.IndexOf("(")).Replace(")", "");
											cdmaTerm.Connect(Name_Com);
											SPC_PWD2();
											IMEI = read_IMEI();
											MEID = read_MEID();
											cdmaTerm.Disconnect();
										}
										else
										{
											cdmaTerm.Disconnect();
										}
									}
									else
									{
										cdmaTerm.Disconnect();
									}
								}
								else
								{
									cdmaTerm.Disconnect();
								}
							}
							nembr_com = Conversions.ToInteger(Name_Com.Replace("COM", ""));
							if (nembr_com > 150)
							{
								Name_Com = Guna2ComboBox1.Text.Substring(Guna2ComboBox1.Text.IndexOf("(") + 1, Guna2ComboBox1.Text.Length - 2 - Guna2ComboBox1.Text.IndexOf("(")).Replace(")", "");
								Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
								Form1.SharedUI.RichTextBox1.AppendText("Failed, Ports Zero And Try Again");
								finshonly();
								return;
							}
						}
					}
					else if (nembr_com > 150)
					{
						Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
						Form1.SharedUI.RichTextBox1.AppendText("Failed, Ports Zero And Try Again");
						finshonly();
						return;
					}
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
					Form1.SharedUI.RichTextBox1.AppendText("OK");
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
					Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Prepair Files : ");
					namefile = "N.zip";
					tmpWinrarr = "N";
					string path2 = ThisLocation + "tmp\\" + namefile;
					try
					{
						File.Delete(path2);
					}
					catch (Exception ex8)
					{
						ProjectData.SetProjectError(ex8);
						Exception ex9 = ex8;
						ProjectData.ClearProjectError();
					}
					path2 = ThisLocation + "tmp\\" + tmpWinrarr;
					try
					{
						MyProject.Computer.FileSystem.DeleteDirectory(path2, DeleteDirectoryOption.DeleteAllContents);
					}
					catch (Exception ex10)
					{
						ProjectData.SetProjectError(ex10);
						Exception ex11 = ex10;
						ProjectData.ClearProjectError();
					}
					Delay(1.0);
					File.WriteAllBytes(ThisLocation + "tmp\\" + namefile, Resources.QCN);
					Delay(1.0);
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
					Form1.SharedUI.RichTextBox1.AppendText("OK");
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
					Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Writeing QCN : ");
					Form1.SharedUI.ProgressBar1.Text = "Writeing QCN..";
					runExFB("bin\\7z.exe x tmp\\N.zip -p911 -otmp\\N");
					Form1.SharedUI.ProgressBar1.Text = "Writeing QCN...";
					runExFB("tmp\\N\\qc.exe qcnwrite -p " + Name_Com + " -f \"" + tmp + "\" -spc 000000");
					cdmaTerm.Connect(Name_Com);
					path2 = ThisLocation + "tmp\\" + namefile;
					try
					{
						File.Delete(path2);
					}
					catch (Exception ex12)
					{
						ProjectData.SetProjectError(ex12);
						Exception ex13 = ex12;
						ProjectData.ClearProjectError();
					}
					path2 = ThisLocation + "tmp\\" + tmpWinrarr;
					try
					{
						MyProject.Computer.FileSystem.DeleteDirectory(path2, DeleteDirectoryOption.DeleteAllContents);
					}
					catch (Exception ex14)
					{
						ProjectData.SetProjectError(ex14);
						Exception ex15 = ex14;
						ProjectData.ClearProjectError();
					}
					SPC_PWD2();
					if (!"SM-A025V-SM-A025AP-SM-A025AZ-SM-A025A".Contains(Label4))
					{
						W_IMEI(IMEI);
						WMEID(MEID);
						Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
						Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Check IMEI => ");
						string right = read_IMEI();
						Form1.SharedUI.RichTextBox1.SelectionColor = Color.Lime;
						Form1.SharedUI.RichTextBox1.AppendText(right);
						Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
						Form1.SharedUI.RichTextBox1.AppendText(" : ");
						if (Operators.CompareString(IMEI, right, TextCompare: false) == 0)
						{
							Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
							Form1.SharedUI.RichTextBox1.AppendText("Is OK");
						}
						else
						{
							Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
							Form1.SharedUI.RichTextBox1.AppendText("Is Fail");
						}
						Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
						Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Check MEID => ");
						string right2 = read_MEID();
						Form1.SharedUI.RichTextBox1.SelectionColor = Color.Lime;
						Form1.SharedUI.RichTextBox1.AppendText(right2);
						Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
						Form1.SharedUI.RichTextBox1.AppendText(" : ");
						if (Operators.CompareString(MEID, right2, TextCompare: false) == 0)
						{
							Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
							Form1.SharedUI.RichTextBox1.AppendText("Is OK");
						}
						else
						{
							Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
							Form1.SharedUI.RichTextBox1.AppendText("Is Fail");
						}
						Wband();
						if (Operators.CompareString(Method, "No", TextCompare: false) == 0)
						{
							Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
							Form1.SharedUI.RichTextBox1.AppendText("Not Supported");
							Form1.SharedUI.RichTextBox1.Update();
							cdmaTerm.Disconnect();
						}
						else
						{
							method_CONVRT2();
							cdmaTerm.Disconnect();
							finsh();
						}
					}
					else if (Operators.CompareString(read_IMEI(), IMEI, TextCompare: false) == 0)
					{
						Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
						Form1.SharedUI.RichTextBox1.AppendText("Failed");
						Form1.SharedUI.RichTextBox1.Update();
						cdmaTerm.Disconnect();
						finshonly();
					}
					else
					{
						W_IMEI(IMEI);
						WMEID(MEID);
						Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
						Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Check IMEI => ");
						string right3 = read_IMEI();
						Form1.SharedUI.RichTextBox1.SelectionColor = Color.Lime;
						Form1.SharedUI.RichTextBox1.AppendText(right3);
						Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
						Form1.SharedUI.RichTextBox1.AppendText(" : ");
						if (Operators.CompareString(IMEI, right3, TextCompare: false) == 0)
						{
							Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
							Form1.SharedUI.RichTextBox1.AppendText("Is OK");
						}
						else
						{
							Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
							Form1.SharedUI.RichTextBox1.AppendText("Is Fail");
						}
						Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
						Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Check MEID => ");
						string right4 = read_MEID();
						Form1.SharedUI.RichTextBox1.SelectionColor = Color.Lime;
						Form1.SharedUI.RichTextBox1.AppendText(right4);
						Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
						Form1.SharedUI.RichTextBox1.AppendText(" : ");
						if (Operators.CompareString(MEID, right4, TextCompare: false) == 0)
						{
							Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
							Form1.SharedUI.RichTextBox1.AppendText("Is OK");
						}
						else
						{
							Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
							Form1.SharedUI.RichTextBox1.AppendText("Is Fail");
						}
						Wband();
						if (Operators.CompareString(Method, "No", TextCompare: false) == 0)
						{
							Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
							Form1.SharedUI.RichTextBox1.AppendText("Not Supported");
							Form1.SharedUI.RichTextBox1.Update();
							cdmaTerm.Disconnect();
						}
						else
						{
							method_CONVRT2();
							cdmaTerm.Disconnect();
							finsh();
						}
					}
				}
			}
			else
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
				Form1.SharedUI.RichTextBox1.AppendText("Port Not Found");
				finshonly();
			}
		}
	}

	public void method_LG_noQCN()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Analyze Device Port : ");
		Form1.SharedUI.ProgressBar1.Text = "Analyzeing..";
		if (Guna2ComboBox1.Text.Contains("USB Serial Port") | Guna2ComboBox1.Text.Contains("HS-USB") | Guna2ComboBox1.Text.Contains("Diagnostics"))
		{
			Name_Com = checked(Guna2ComboBox1.Text.Substring(Guna2ComboBox1.Text.IndexOf("(") + 1, Guna2ComboBox1.Text.Length - 2 - Guna2ComboBox1.Text.IndexOf("("))).Replace(")", "");
			cdmaTerm.Connect(Name_Com);
			if (!cdmaTerm.portIsOpen)
			{
				cdmaTerm.Disconnect();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
				Form1.SharedUI.RichTextBox1.AppendText("Port Opening Failed");
				finshonly();
			}
			else
			{
				if (!cdmaTerm.portIsOpen)
				{
					return;
				}
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Connected");
				Info();
				if (Operators.CompareString(Method, "no", TextCompare: false) == 0)
				{
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
					Form1.SharedUI.RichTextBox1.AppendText("Port Opening Failed, Please Select Other Port");
					Form1.SharedUI.RichTextBox1.Update();
					cdmaTerm.Disconnect();
					finshonly();
					return;
				}
				Method = "";
				SPC_PWD3();
				Wband();
				if (Operators.CompareString(Method, "No", TextCompare: false) == 0)
				{
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
					Form1.SharedUI.RichTextBox1.AppendText("Not Supported");
					Form1.SharedUI.RichTextBox1.Update();
					cdmaTerm.Disconnect();
					return;
				}
				if (device_info.Android.Contains("11") | device_info.Android.Contains("12"))
				{
					method_CONVRTNew();
				}
				else
				{
					method_CONVRT1();
				}
				cdmaTerm.Disconnect();
				finsh();
			}
		}
		else
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText("Port Not Found");
			finshonly();
		}
	}

	public void method_lg_QCN()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Analyze Device Port : ");
		Form1.SharedUI.ProgressBar1.Text = "Analyzeing..";
		checked
		{
			try
			{
				Process[] processesByName = Process.GetProcessesByName("7z");
				int num = 0;
				do
				{
					processesByName[num].Kill();
					num++;
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
			try
			{
				Process[] processesByName2 = Process.GetProcessesByName("qc");
				int num2 = 0;
				do
				{
					processesByName2[num2].Kill();
					num2++;
				}
				while (num2 < processesByName2.Length);
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception projectError2 = ex2;
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
			}
			try
			{
				Process[] processesByName3 = Process.GetProcessesByName("Tunlocker Tool");
				int num3 = 0;
				do
				{
					processesByName3[num3].Kill();
					num3++;
				}
				while (num3 < processesByName3.Length);
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception projectError3 = ex3;
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
			}
			if (Guna2ComboBox1.Text.Contains("USB Serial Port") | Guna2ComboBox1.Text.Contains("HS-USB") | Guna2ComboBox1.Text.Contains("Diagnostics"))
			{
				Name_Com = Guna2ComboBox1.Text.Substring(Guna2ComboBox1.Text.IndexOf("(") + 1, Guna2ComboBox1.Text.Length - 2 - Guna2ComboBox1.Text.IndexOf("(")).Replace(")", "");
				cdmaTerm.Connect(Name_Com);
				if (!cdmaTerm.portIsOpen)
				{
					cdmaTerm.Disconnect();
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
					Form1.SharedUI.RichTextBox1.AppendText("Port Opening Failed");
					finshonly();
				}
				else
				{
					if (!cdmaTerm.portIsOpen)
					{
						return;
					}
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
					Form1.SharedUI.RichTextBox1.AppendText("Connected");
					Info();
					if (Operators.CompareString(Method, "no", TextCompare: false) == 0)
					{
						Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
						Form1.SharedUI.RichTextBox1.AppendText("Port Opening Failed, Please Select Other Port");
						Form1.SharedUI.RichTextBox1.Update();
						cdmaTerm.Disconnect();
						finshonly();
						return;
					}
					Method = "";
					SPC_PWD3();
					IMEI = read_IMEI();
					MEID = read_MEID();
					cdmaTerm.Disconnect();
					tmp = "tmp\\N\\4";
					nembr_com = Conversions.ToInteger(Name_Com.Replace("COM", ""));
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
					Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Prepair Device : ");
					if (CKAUTO_CONN.Checked)
					{
						if (nembr_com > 150)
						{
							Form1.SharedUI.ProgressBar1.Text = "Analyzeing Ports..";
							Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + serialno.Text + " shell reboot", new object[0]), false);
							namefile = "DCAPI.exe";
							string path = ThisLocation + "tmp\\" + namefile;
							try
							{
								File.Delete(path);
							}
							catch (Exception ex4)
							{
								ProjectData.SetProjectError(ex4);
								Exception ex5 = ex4;
								ProjectData.ClearProjectError();
							}
							File.WriteAllBytes(ThisLocation + "tmp\\DCAPI.exe", Resources.DCAPI);
							namefile = "reset.bat";
							path = ThisLocation + "tmp\\" + namefile;
							try
							{
								MyProject.Computer.FileSystem.DeleteDirectory(path, DeleteDirectoryOption.DeleteAllContents);
							}
							catch (Exception ex6)
							{
								ProjectData.SetProjectError(ex6);
								Exception ex7 = ex6;
								ProjectData.ClearProjectError();
							}
							File.WriteAllBytes(ThisLocation + "tmp\\reset.bat", Resources.comportreset);
							Delay(6.0);
							string_13 = "tmp\\DCAPI.exe *";
							Zero_ALL();
							runExFB("tmp\\reset.bat");
							Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
							Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Waiting For Device : ");
							wait_booted(log_allow: true);
							Delay(2.0);
							Form1.SharedUI.ProgressBar1.Text = "Checking Ports..";
							Guna2ComboBox1.Items.Clear();
							new ManagementObjectSearcher("SELECT * FROM WIN32_SerialPort").Get();
							foreach (COMPortInfoO item in COMPortInfoO.GetCOMPortsInfoO())
							{
								Guna2ComboBox1.Items.Add(string.Format("{0}{1}", "\r", item.Description));
							}
							if (Guna2ComboBox1.Items.Count != 0)
							{
								Guna2ComboBox1.SelectedIndex = 0;
							}
							Count = Conversions.ToString(Guna2ComboBox1.Items.Count);
							if (Operators.CompareString(Count, "1", TextCompare: false) == 0)
							{
								Guna2ComboBox1.SelectedIndex = 0;
								text3.Text = Guna2ComboBox1.SelectedItem.ToString();
								if (!(text3.Text.Contains("USB Serial Port") | Guna2ComboBox1.Text.Contains("HS-USB") | Guna2ComboBox1.Text.Contains("Diagnostics")))
								{
									Guna2ComboBox1.Items.RemoveAt(Guna2ComboBox1.SelectedIndex);
								}
							}
							if (Operators.CompareString(Count, "2", TextCompare: false) == 0)
							{
								Guna2ComboBox1.SelectedIndex = 0;
								text3.Text = Guna2ComboBox1.SelectedItem.ToString();
								if (!(text3.Text.Contains("USB Serial Port") | Guna2ComboBox1.Text.Contains("HS-USB") | Guna2ComboBox1.Text.Contains("Diagnostics")))
								{
									Guna2ComboBox1.Items.RemoveAt(Guna2ComboBox1.SelectedIndex);
								}
								Guna2ComboBox1.SelectedIndex = 1;
								text3.Text = Guna2ComboBox1.SelectedItem.ToString();
								if (!(text3.Text.Contains("USB Serial Port") | Guna2ComboBox1.Text.Contains("HS-USB") | Guna2ComboBox1.Text.Contains("Diagnostics")))
								{
									Guna2ComboBox1.Items.RemoveAt(Guna2ComboBox1.SelectedIndex);
								}
							}
							if (Operators.CompareString(Count, "3", TextCompare: false) == 0)
							{
								Guna2ComboBox1.SelectedIndex = 0;
								text3.Text = Guna2ComboBox1.SelectedItem.ToString();
								if (!(text3.Text.Contains("USB Serial Port") | Guna2ComboBox1.Text.Contains("HS-USB") | Guna2ComboBox1.Text.Contains("Diagnostics")))
								{
									Guna2ComboBox1.Items.RemoveAt(Guna2ComboBox1.SelectedIndex);
								}
								Guna2ComboBox1.SelectedIndex = 1;
								text3.Text = Guna2ComboBox1.SelectedItem.ToString();
								if (!(text3.Text.Contains("USB Serial Port") | Guna2ComboBox1.Text.Contains("HS-USB") | Guna2ComboBox1.Text.Contains("Diagnostics")))
								{
									Guna2ComboBox1.Items.RemoveAt(Guna2ComboBox1.SelectedIndex);
								}
								Guna2ComboBox1.SelectedIndex = 2;
								text3.Text = Guna2ComboBox1.SelectedItem.ToString();
								if (!(text3.Text.Contains("USB Serial Port") | Guna2ComboBox1.Text.Contains("HS-USB") | Guna2ComboBox1.Text.Contains("Diagnostics")))
								{
									Guna2ComboBox1.Items.RemoveAt(Guna2ComboBox1.SelectedIndex);
								}
							}
							if (Operators.CompareString(Count, "4", TextCompare: false) == 0)
							{
								Guna2ComboBox1.SelectedIndex = 0;
								text3.Text = Guna2ComboBox1.SelectedItem.ToString();
								if (!(text3.Text.Contains("USB Serial Port") | Guna2ComboBox1.Text.Contains("HS-USB") | Guna2ComboBox1.Text.Contains("Diagnostics")))
								{
									Guna2ComboBox1.Items.RemoveAt(Guna2ComboBox1.SelectedIndex);
								}
								Guna2ComboBox1.SelectedIndex = 1;
								text3.Text = Guna2ComboBox1.SelectedItem.ToString();
								if (!(text3.Text.Contains("USB Serial Port") | Guna2ComboBox1.Text.Contains("HS-USB") | Guna2ComboBox1.Text.Contains("Diagnostics")))
								{
									Guna2ComboBox1.Items.RemoveAt(Guna2ComboBox1.SelectedIndex);
								}
								Guna2ComboBox1.SelectedIndex = 2;
								text3.Text = Guna2ComboBox1.SelectedItem.ToString();
								if (!(text3.Text.Contains("USB Serial Port") | Guna2ComboBox1.Text.Contains("HS-USB") | Guna2ComboBox1.Text.Contains("Diagnostics")))
								{
									Guna2ComboBox1.Items.RemoveAt(Guna2ComboBox1.SelectedIndex);
								}
								Guna2ComboBox1.SelectedIndex = 3;
								text3.Text = Guna2ComboBox1.SelectedItem.ToString();
								if (!(text3.Text.Contains("USB Serial Port") | Guna2ComboBox1.Text.Contains("HS-USB") | Guna2ComboBox1.Text.Contains("Diagnostics")))
								{
									Guna2ComboBox1.Items.RemoveAt(Guna2ComboBox1.SelectedIndex);
								}
							}
							Count = Conversions.ToString(Guna2ComboBox1.Items.Count);
							if (Operators.CompareString(Count, "2", TextCompare: false) == 0)
							{
								Guna2ComboBox1.SelectedIndex = 0;
								Name_Com = Guna2ComboBox1.Text.Substring(Guna2ComboBox1.Text.IndexOf("(") + 1, Guna2ComboBox1.Text.Length - 2 - Guna2ComboBox1.Text.IndexOf("(")).Replace(")", "");
								cdmaTerm.Connect(Name_Com);
								SPC_PWD2();
								IMEI = read_IMEI();
								MEID = read_MEID();
								Delay(1.0);
								if (IMEI.Contains("0000000000000000"))
								{
									cdmaTerm.Disconnect();
									Guna2ComboBox1.SelectedIndex = 1;
									Name_Com = Guna2ComboBox1.Text.Substring(Guna2ComboBox1.Text.IndexOf("(") + 1, Guna2ComboBox1.Text.Length - 2 - Guna2ComboBox1.Text.IndexOf("(")).Replace(")", "");
									cdmaTerm.Connect(Name_Com);
									SPC_PWD2();
									IMEI = read_IMEI();
									MEID = read_MEID();
									cdmaTerm.Disconnect();
								}
								else
								{
									cdmaTerm.Disconnect();
								}
							}
							else if (Operators.CompareString(Count, "3", TextCompare: false) == 0)
							{
								Guna2ComboBox1.SelectedIndex = 0;
								Name_Com = Guna2ComboBox1.Text.Substring(Guna2ComboBox1.Text.IndexOf("(") + 1, Guna2ComboBox1.Text.Length - 2 - Guna2ComboBox1.Text.IndexOf("(")).Replace(")", "");
								cdmaTerm.Connect(Name_Com);
								SPC_PWD2();
								IMEI = read_IMEI();
								MEID = read_MEID();
								Delay(1.0);
								if (IMEI.Contains("0000000000000000"))
								{
									cdmaTerm.Disconnect();
									Guna2ComboBox1.SelectedIndex = 1;
									Name_Com = Guna2ComboBox1.Text.Substring(Guna2ComboBox1.Text.IndexOf("(") + 1, Guna2ComboBox1.Text.Length - 2 - Guna2ComboBox1.Text.IndexOf("(")).Replace(")", "");
									cdmaTerm.Connect(Name_Com);
									SPC_PWD2();
									IMEI = read_IMEI();
									MEID = read_MEID();
									Delay(1.0);
									if (IMEI.Contains("0000000000000000"))
									{
										cdmaTerm.Disconnect();
										Guna2ComboBox1.SelectedIndex = 2;
										Name_Com = Guna2ComboBox1.Text.Substring(Guna2ComboBox1.Text.IndexOf("(") + 1, Guna2ComboBox1.Text.Length - 2 - Guna2ComboBox1.Text.IndexOf("(")).Replace(")", "");
										cdmaTerm.Connect(Name_Com);
										SPC_PWD2();
										IMEI = read_IMEI();
										MEID = read_MEID();
										cdmaTerm.Disconnect();
									}
									else
									{
										cdmaTerm.Disconnect();
									}
								}
								else
								{
									cdmaTerm.Disconnect();
								}
							}
							else if (Operators.CompareString(Count, "4", TextCompare: false) == 0)
							{
								Guna2ComboBox1.SelectedIndex = 0;
								Name_Com = Guna2ComboBox1.Text.Substring(Guna2ComboBox1.Text.IndexOf("(") + 1, Guna2ComboBox1.Text.Length - 2 - Guna2ComboBox1.Text.IndexOf("(")).Replace(")", "");
								cdmaTerm.Connect(Name_Com);
								SPC_PWD2();
								IMEI = read_IMEI();
								MEID = read_MEID();
								Delay(1.0);
								if (IMEI.Contains("0000000000000000"))
								{
									cdmaTerm.Disconnect();
									Guna2ComboBox1.SelectedIndex = 1;
									Name_Com = Guna2ComboBox1.Text.Substring(Guna2ComboBox1.Text.IndexOf("(") + 1, Guna2ComboBox1.Text.Length - 2 - Guna2ComboBox1.Text.IndexOf("(")).Replace(")", "");
									cdmaTerm.Connect(Name_Com);
									SPC_PWD2();
									IMEI = read_IMEI();
									MEID = read_MEID();
									Delay(1.0);
									if (IMEI.Contains("0000000000000000"))
									{
										cdmaTerm.Disconnect();
										Guna2ComboBox1.SelectedIndex = 2;
										Name_Com = Guna2ComboBox1.Text.Substring(Guna2ComboBox1.Text.IndexOf("(") + 1, Guna2ComboBox1.Text.Length - 2 - Guna2ComboBox1.Text.IndexOf("(")).Replace(")", "");
										cdmaTerm.Connect(Name_Com);
										SPC_PWD2();
										IMEI = read_IMEI();
										MEID = read_MEID();
										Delay(1.0);
										if (IMEI.Contains("0000000000000000"))
										{
											cdmaTerm.Disconnect();
											Guna2ComboBox1.SelectedIndex = 3;
											Name_Com = Guna2ComboBox1.Text.Substring(Guna2ComboBox1.Text.IndexOf("(") + 1, Guna2ComboBox1.Text.Length - 2 - Guna2ComboBox1.Text.IndexOf("(")).Replace(")", "");
											cdmaTerm.Connect(Name_Com);
											SPC_PWD2();
											IMEI = read_IMEI();
											MEID = read_MEID();
											cdmaTerm.Disconnect();
										}
										else
										{
											cdmaTerm.Disconnect();
										}
									}
									else
									{
										cdmaTerm.Disconnect();
									}
								}
								else
								{
									cdmaTerm.Disconnect();
								}
							}
							nembr_com = Conversions.ToInteger(Name_Com.Replace("COM", ""));
							if (nembr_com > 150)
							{
								Name_Com = Guna2ComboBox1.Text.Substring(Guna2ComboBox1.Text.IndexOf("(") + 1, Guna2ComboBox1.Text.Length - 2 - Guna2ComboBox1.Text.IndexOf("(")).Replace(")", "");
								Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
								Form1.SharedUI.RichTextBox1.AppendText("Failed, Ports Zero And Try Again");
								finshonly();
								return;
							}
						}
					}
					else if (nembr_com > 150)
					{
						Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
						Form1.SharedUI.RichTextBox1.AppendText("Failed, Ports Zero And Try Again");
						finshonly();
						return;
					}
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
					Form1.SharedUI.RichTextBox1.AppendText("OK");
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
					Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Prepair Files : ");
					namefile = "N.zip";
					tmpWinrarr = "N";
					string path2 = ThisLocation + "tmp\\" + namefile;
					try
					{
						File.Delete(path2);
					}
					catch (Exception ex8)
					{
						ProjectData.SetProjectError(ex8);
						Exception ex9 = ex8;
						ProjectData.ClearProjectError();
					}
					path2 = ThisLocation + "tmp\\" + tmpWinrarr;
					try
					{
						MyProject.Computer.FileSystem.DeleteDirectory(path2, DeleteDirectoryOption.DeleteAllContents);
					}
					catch (Exception ex10)
					{
						ProjectData.SetProjectError(ex10);
						Exception ex11 = ex10;
						ProjectData.ClearProjectError();
					}
					Delay(1.0);
					File.WriteAllBytes(ThisLocation + "tmp\\" + namefile, Resources.QCN);
					Delay(1.0);
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
					Form1.SharedUI.RichTextBox1.AppendText("OK");
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
					Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Writeing QCN : ");
					Form1.SharedUI.ProgressBar1.Text = "Writeing QCN..";
					runExFB("bin\\7z.exe x tmp\\N.zip -p911 -otmp\\N");
					Form1.SharedUI.ProgressBar1.Text = "Writeing QCN...";
					runExFB("tmp\\N\\qc.exe qcnwrite -p " + Name_Com + " -f \"" + tmp + "\" -spc 000000");
					cdmaTerm.Connect(Name_Com);
					path2 = ThisLocation + "tmp\\" + namefile;
					try
					{
						File.Delete(path2);
					}
					catch (Exception ex12)
					{
						ProjectData.SetProjectError(ex12);
						Exception ex13 = ex12;
						ProjectData.ClearProjectError();
					}
					path2 = ThisLocation + "tmp\\" + tmpWinrarr;
					try
					{
						MyProject.Computer.FileSystem.DeleteDirectory(path2, DeleteDirectoryOption.DeleteAllContents);
					}
					catch (Exception ex14)
					{
						ProjectData.SetProjectError(ex14);
						Exception ex15 = ex14;
						ProjectData.ClearProjectError();
					}
					SPC_PWD2();
					method_CONVRTNew_LG();
				}
			}
			else
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
				Form1.SharedUI.RichTextBox1.AppendText("Port Not Found");
				finshonly();
			}
		}
	}

	private void SPC_PWD3()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Sand SPC Code (000000) : ");
		Form1.SharedUI.ProgressBar1.Text = "Sand SPC...";
		TX("4B0B24005D0200000E00550006003030303030300B3E7E", crc: false);
		TX("4B0B24005D0200000E00550006003030303030300B3E7E", crc: false);
		TX("4B0B24005D0200000E00550006003030303030300B3E7E", crc: false);
		TX("465903365113726913282B7E", crc: false);
		TX("46FFFFFFFFFFFFFFFF00FDEE7E", crc: false);
		TX("41303030303030DF8A7E", crc: false);
		TX("41303030303030DF8A7E", crc: false);
		TX("41303030303030DF8A7E", crc: false);
		TX("465903365113726913282B7E", crc: false);
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("OK");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Bypass Security Code Checking : ");
		Form1.SharedUI.ProgressBar1.Text = "Bypass...";
		Form1.SharedUI.RichTextBox1.Update();
		TX("46201211212013121994247E", crc: false);
		TX("462013051320130909BC4A7E", crc: false);
		TX("46201211212013121994247E", crc: false);
		TX("462009031920090615BAED7E", crc: false);
		TX("462009031920090615BAED7E", crc: false);
		TX("4620100316197807215C727E", crc: false);
		TX("46FFFFFFFFFFFFFFFFFE747E", crc: false);
		TX("462FF811282FF9F32337A97E", crc: false);
		TX("4620100316197807215C727E", crc: false);
		TX("46201411242015020217B77E", crc: false);
		TX("4620100316197807215C727E", crc: false);
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("OK");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Disable Write Protection : ");
		Form1.SharedUI.ProgressBar1.Text = "Disable...";
		Form1.SharedUI.RichTextBox1.Update();
		W_1CDMA();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("OK");
		Form1.SharedUI.RichTextBox1.Update();
	}

	private void method_CONVRT2()
	{
		TX("465903365113726913282b7e", crc: false);
		TX("41303030303030df8a7e", crc: false);
		TX("465903365113726913282b7e", crc: false);
		TX("41303030303030df8a7e", crc: false);
		TX("41303030303030df8a7e", crc: false);
		TX("fac30000a5b27e", crc: false);
		TX("278c27010000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000006bec7e", crc: false);
		TX("278c27010000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000006bec7e", crc: false);
		TX("278c27010000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000006bec7e", crc: false);
		TX("278c27010000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000006bec7e", crc: false);
		TX("4b040e000dd37e", crc: false);
		TX("4b130b002f0019117e", crc: false);
		TX("270a0000130000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000cf757e", crc: false);
		TX("270a00130000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000009be87e", crc: false);
		TX("276c1001000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000078a7e", crc: false);
		TX("270b0000010000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000fdc27e", crc: false);
		TX("27ba01000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000a747e", crc: false);
		TX("27cb0101000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000a86a7e", crc: false);
		TX("26570300000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000a9007e", crc: false);
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("OK");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Write Network Values : ");
		Form1.SharedUI.ProgressBar1.Text = "Writeing...";
		Form1.SharedUI.RichTextBox1.Update();
		TX("4b130800706f6c6963796d616e2f667265715f6c6973740032bd7e", crc: false);
		TX("4b130800706f6c6963796d616e2f667265715f6c6973745f537562736372697074696f6e303100616a7e", crc: false);
		TX("4b130800706f6c6963796d616e2f69676e6f72655f6d63633262616e64735f6d646200b5d97e", crc: false);
		TX("4b1308006e762f6974656d5f66696c65732f6d6f64656d2f6d6d6f64652f63646d615f6c657373001d167e", crc: false);
		TX("4b130800706f6c6963796d616e2f6465766963655f636f6e6669670082007e", crc: false);
		TX("4b130800706f6c6963796d616e2f636172726965725f706f6c6963792e786d6c00f4ba7e", crc: false);
		TX("4b130800706f6c6963796d616e2f7261745f6d61736b0073607e", crc: false);
		TX("4b130800706f6c6963796d616e2f7376635f6d6f64655f537562736372697074696f6e303100ae4c7e", crc: false);
		TX("4b130800706f6c6963796d616e2f7376635f6d6f646500eba57e", crc: false);
		TX("4B130800706F6C6963796D616E2F7261745F6D61736B5F537562736372697074696F6E303100AFC87E", crc: false);
		TX("4B130800706F6C6963796D616E2F75655F6D6F646500EF277E", crc: false);
		TX("4B130800706F6C6963796D616E2F75655F6D6F64655F537562736372697074696F6E3031001D1F7E", crc: false);
		TX("4B130800706F6C6963796D616E2F7261745F6D61736B5F537562736372697074696F6E303100AFC87E", crc: false);
		TX("4B130800706F6C6963796D616E2F706F6C696379332F636172726965725F706F6C6963792E786D6C00B27A7E", crc: false);
		TX("4B130800706F6C6963796D616E2F63616C6C5F6D6F64650098FA7E", crc: false);
		TX("4B130800706F6C6963796D616E2F63616C6C5F6D6F64655F537562736372697074696F6E30310003EA7E", crc: false);
		TX("4B130800706F6C6963796D616E2F63757272656E745F6D636300A6077E", crc: false);
		TX("4B130800706F6C6963796D616E2F63757272656E745F6D63635F537562736372697074696F6E30310048387E", crc: false);
		TX("4B130800706F6C6963796D616E2F706F6C696379312F636172726965725F706F6C6963792E786D6C006A147E", crc: false);
		TX("4B130800706F6C6963796D616E2F63757272656E745F6D636300A6077E", crc: false);
		TX("4B130800706F6C6963796D616E2F6465766963655F636F6E6669670082007E", crc: false);
		TX("4B130800706F6C6963796D616E2F7261745F6D61736B0073607E", crc: false);
		TX("4B130800706F6C6963796D616E2F7261745F6D61736B5F537562736372 697074696F6E303100AFC87E", crc: false);
		TX("4B130800706F6C6963796D616E2F7376635F6D6F646500EBA57E", crc: false);
		TX("4B130800706F6C6963796D616E2F7376635F6D6F64655F537562736372697074696F6E303100AE4C7E", crc: false);
		TX("4B130800706F6C6963796D616E2F75655F6D6F646500EF277E", crc: false);
		TX("4B130800706F6C6963796D616E2F75655F6D6F64655F537562736372697074696F6E3031001D1F7E", crc: false);
		TX("4B130800706F6C6963796D616E2F706F6C696379312F636172726965725F706F6C6963792E786D6C006A147E", crc: false);
		TX("4B130800706F6C6963796D616E2F706F6C696379322F636172726965725F706F6C6963792E786D6C00DE4D7E", crc: false);
		TX("4B130800706F6C6963796D616E2F706F6C696379332F636172726965725F706F6C6963792E786D6C00B27A7E", crc: false);
		TX("4B130800706F6C6963796D616E2F6465766963655F636F6E6669672E786D6C00B5607E", crc: false);
		TX("260A0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000B2377E", crc: false);
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("OK");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Removeing File Modem : ");
		Form1.SharedUI.ProgressBar1.Text = "Removeing..";
		Form1.SharedUI.RichTextBox1.Update();
		method_Erasemodem();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("OK");
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Removeing Poliyman : ");
		Form1.SharedUI.ProgressBar1.Text = "Removeing...";
		Form1.SharedUI.RichTextBox1.Update();
		method_Erase();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("OK");
		Form1.SharedUI.RichTextBox1.Update();
		if (CheckBox2.CheckState == CheckState.Checked)
		{
			method_3gauot();
		}
		method_re();
	}

	private void method_CONVRT1()
	{
		cdmaTerm.SendTerminalCommand("465903365113726913282b7e", false);
		cdmaTerm.SendTerminalCommand("41303030303030df8a7e", false);
		cdmaTerm.SendTerminalCommand("465903365113726913282b7e", false);
		cdmaTerm.SendTerminalCommand("41303030303030df8a7e", false);
		cdmaTerm.SendTerminalCommand("41303030303030df8a7e", false);
		cdmaTerm.SendTerminalCommand("fac30000a5b27e", false);
		cdmaTerm.SendTerminalCommand("278c27010000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000006bec7e", false);
		cdmaTerm.SendTerminalCommand("278c27010000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000006bec7e", false);
		cdmaTerm.SendTerminalCommand("278c27010000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000006bec7e", false);
		cdmaTerm.SendTerminalCommand("278c27010000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000006bec7e", false);
		cdmaTerm.SendTerminalCommand("4b040e000dd37e", false);
		cdmaTerm.SendTerminalCommand("4b130b002f0019117e", false);
		cdmaTerm.SendTerminalCommand("270a0000130000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000cf757e", false);
		cdmaTerm.SendTerminalCommand("270a00130000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000009be87e", false);
		cdmaTerm.SendTerminalCommand("276c1001000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000078a7e", false);
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("OK");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Switch Network (CDMA_MODE) : ");
		Form1.SharedUI.ProgressBar1.Text = "Switching...";
		Form1.SharedUI.RichTextBox1.Update();
		cdmaTerm.SendTerminalCommand("270b0000010000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000fdc27e", false);
		cdmaTerm.SendTerminalCommand("27ba01000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000a747e", false);
		cdmaTerm.SendTerminalCommand("27cb0101000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000a86a7e", false);
		cdmaTerm.SendTerminalCommand("26570300000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000a9007e", false);
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("OK");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Write Network Values : ");
		Form1.SharedUI.ProgressBar1.Text = "Writeing...";
		Form1.SharedUI.RichTextBox1.Update();
		TX("4b130800706f6c6963796d616e2f667265715f6c6973740032bd7e", crc: false);
		TX("4b130800706f6c6963796d616e2f667265715f6c6973745f537562736372697074696f6e303100616a7e", crc: false);
		TX("4b130800706f6c6963796d616e2f69676e6f72655f6d63633262616e64735f6d646200b5d97e", crc: false);
		TX("4b1308006e762f6974656d5f66696c65732f6d6f64656d2f6d6d6f64652f63646d615f6c657373001d167e", crc: false);
		TX("4b130800706f6c6963796d616e2f6465766963655f636f6e6669670082007e", crc: false);
		TX("4b130800706f6c6963796d616e2f636172726965725f706f6c6963792e786d6c00f4ba7e", crc: false);
		TX("4b130800706f6c6963796d616e2f7261745f6d61736b0073607e", crc: false);
		TX("4b130800706f6c6963796d616e2f7376635f6d6f64655f537562736372697074696f6e303100ae4c7e", crc: false);
		TX("4b130800706f6c6963796d616e2f7376635f6d6f646500eba57e", crc: false);
		TX("4B130800706F6C6963796D616E2F7261745F6D61736B5F537562736372697074696F6E303100AFC87E", crc: false);
		TX("4B130800706F6C6963796D616E2F75655F6D6F646500EF277E", crc: false);
		TX("4B130800706F6C6963796D616E2F75655F6D6F64655F537562736372697074696F6E3031001D1F7E", crc: false);
		TX("4B130800706F6C6963796D616E2F7261745F6D61736B5F537562736372697074696F6E303100AFC87E", crc: false);
		TX("4B130800706F6C6963796D616E2F706F6C696379332F636172726965725F706F6C6963792E786D6C00B27A7E", crc: false);
		TX("4B130800706F6C6963796D616E2F63616C6C5F6D6F64650098FA7E", crc: false);
		TX("4B130800706F6C6963796D616E2F63616C6C5F6D6F64655F537562736372697074696F6E30310003EA7E", crc: false);
		TX("4B130800706F6C6963796D616E2F63757272656E745F6D636300A6077E", crc: false);
		TX("4B130800706F6C6963796D616E2F63757272656E745F6D63635F537562736372697074696F6E30310048387E", crc: false);
		TX("4B130800706F6C6963796D616E2F706F6C696379312F636172726965725F706F6C6963792E786D6C006A147E", crc: false);
		TX("4B130800706F6C6963796D616E2F63757272656E745F6D636300A6077E", crc: false);
		TX("4B130800706F6C6963796D616E2F6465766963655F636F6E6669670082007E", crc: false);
		TX("4B130800706F6C6963796D616E2F7261745F6D61736B0073607E", crc: false);
		TX("4B130800706F6C6963796D616E2F7261745F6D61736B5F537562736372 697074696F6E303100AFC87E", crc: false);
		TX("4B130800706F6C6963796D616E2F7376635F6D6F646500EBA57E", crc: false);
		TX("4B130800706F6C6963796D616E2F7376635F6D6F64655F537562736372697074696F6E303100AE4C7E", crc: false);
		TX("4B130800706F6C6963796D616E2F75655F6D6F646500EF277E", crc: false);
		TX("4B130800706F6C6963796D616E2F75655F6D6F64655F537562736372697074696F6E3031001D1F7E", crc: false);
		TX("4B130800706F6C6963796D616E2F706F6C696379312F636172726965725F706F6C6963792E786D6C006A147E", crc: false);
		TX("4B130800706F6C6963796D616E2F706F6C696379322F636172726965725F706F6C6963792E786D6C00DE4D7E", crc: false);
		TX("4B130800706F6C6963796D616E2F706F6C696379332F636172726965725F706F6C6963792E786D6C00B27A7E", crc: false);
		TX("4B130800706F6C6963796D616E2F6465766963655F636F6E6669672E786D6C00B5607E", crc: false);
		TX("260A0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000B2377E", crc: false);
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("OK");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Removeing Poliyman : ");
		Form1.SharedUI.ProgressBar1.Text = "Removeing...";
		Form1.SharedUI.RichTextBox1.Update();
		method_Erase();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("OK");
		Form1.SharedUI.RichTextBox1.Update();
		if (CheckBox2.CheckState == CheckState.Checked)
		{
			method_3gauot();
		}
		method_re();
	}

	private void method_CONVRTNew()
	{
		TX("465903365113726913282b7e", crc: false);
		TX("41303030303030df8a7e", crc: false);
		TX("465903365113726913282b7e", crc: false);
		TX("41303030303030df8a7e", crc: false);
		TX("41303030303030df8a7e", crc: false);
		TX("fac30000a5b27e", crc: false);
		TX("278c27010000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000006bec7e", crc: false);
		TX("278c27010000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000006bec7e", crc: false);
		TX("278c27010000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000006bec7e", crc: false);
		TX("278c27010000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000006bec7e", crc: false);
		TX("4b040e000dd37e", crc: false);
		TX("4b130b002f0019117e", crc: false);
		TX("270a0000130000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000cf757e", crc: false);
		TX("270a00130000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000009be87e", crc: false);
		TX("276c1001000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000078a7e", crc: false);
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("OK");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Unlock Network (CDMA_MODE) : ");
		Form1.SharedUI.ProgressBar1.Text = "Unlocking...";
		Form1.SharedUI.RichTextBox1.Update();
		TX("270b0000010000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000fdc27e", crc: false);
		TX("27ba01000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000a747e", crc: false);
		TX("27cb0101000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000a86a7e", crc: false);
		TX("26570300000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000a9007e", crc: false);
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("OK");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Write Network Values : ");
		Form1.SharedUI.ProgressBar1.Text = "Writeing...";
		Form1.SharedUI.RichTextBox1.Update();
		TX("4b130800706f6c6963796d616e2f667265715f6c6973740032bd7e", crc: false);
		TX("4b130800706f6c6963796d616e2f667265715f6c6973745f537562736372697074696f6e303100616a7e", crc: false);
		TX("4b130800706f6c6963796d616e2f69676e6f72655f6d63633262616e64735f6d646200b5d97e", crc: false);
		TX("4b1308006e762f6974656d5f66696c65732f6d6f64656d2f6d6d6f64652f63646d615f6c657373001d167e", crc: false);
		TX("4b130800706f6c6963796d616e2f6465766963655f636f6e6669670082007e", crc: false);
		TX("4b130800706f6c6963796d616e2f636172726965725f706f6c6963792e786d6c00f4ba7e", crc: false);
		TX("4b130800706f6c6963796d616e2f7261745f6d61736b0073607e", crc: false);
		TX("4b130800706f6c6963796d616e2f7376635f6d6f64655f537562736372697074696f6e303100ae4c7e", crc: false);
		TX("4b130800706f6c6963796d616e2f7376635f6d6f646500eba57e", crc: false);
		TX("4B130800706F6C6963796D616E2F7261745F6D61736B5F537562736372697074696F6E303100AFC87E", crc: false);
		TX("4B130800706F6C6963796D616E2F75655F6D6F646500EF277E", crc: false);
		TX("4B130800706F6C6963796D616E2F75655F6D6F64655F537562736372697074696F6E3031001D1F7E", crc: false);
		TX("4B130800706F6C6963796D616E2F7261745F6D61736B5F537562736372697074696F6E303100AFC87E", crc: false);
		TX("4B130800706F6C6963796D616E2F706F6C696379332F636172726965725F706F6C6963792E786D6C00B27A7E", crc: false);
		TX("4B130800706F6C6963796D616E2F63616C6C5F6D6F64650098FA7E", crc: false);
		TX("4B130800706F6C6963796D616E2F63616C6C5F6D6F64655F537562736372697074696F6E30310003EA7E", crc: false);
		TX("4B130800706F6C6963796D616E2F63757272656E745F6D636300A6077E", crc: false);
		TX("4B130800706F6C6963796D616E2F63757272656E745F6D63635F537562736372697074696F6E30310048387E", crc: false);
		TX("4B130800706F6C6963796D616E2F706F6C696379312F636172726965725F706F6C6963792E786D6C006A147E", crc: false);
		TX("4B130800706F6C6963796D616E2F63757272656E745F6D636300A6077E", crc: false);
		TX("4B130800706F6C6963796D616E2F6465766963655F636F6E6669670082007E", crc: false);
		TX("4B130800706F6C6963796D616E2F7261745F6D61736B0073607E", crc: false);
		TX("4B130800706F6C6963796D616E2F7261745F6D61736B5F537562736372 697074696F6E303100AFC87E", crc: false);
		TX("4B130800706F6C6963796D616E2F7376635F6D6F646500EBA57E", crc: false);
		TX("4B130800706F6C6963796D616E2F7376635F6D6F64655F537562736372697074696F6E303100AE4C7E", crc: false);
		TX("4B130800706F6C6963796D616E2F75655F6D6F646500EF277E", crc: false);
		TX("4B130800706F6C6963796D616E2F75655F6D6F64655F537562736372697074696F6E3031001D1F7E", crc: false);
		TX("4B130800706F6C6963796D616E2F706F6C696379312F636172726965725F706F6C6963792E786D6C006A147E", crc: false);
		TX("4B130800706F6C6963796D616E2F706F6C696379322F636172726965725F706F6C6963792E786D6C00DE4D7E", crc: false);
		TX("4B130800706F6C6963796D616E2F706F6C696379332F636172726965725F706F6C6963792E786D6C00B27A7E", crc: false);
		TX("4B130800706F6C6963796D616E2F6465766963655F636F6E6669672E786D6C00B5607E", crc: false);
		TX("4B1308006E762F6974656D5F66696C65732F6D6366672F6D6366675F6175746F73656C6563745F62795F75696D002BDE7E", crc: true);
		TX("4B1308006E762F6974656D5F66696C65732F6D6366672F6D6366675F6175746F73656C6563745F62795F75696D5F537562736372697074696F6E30310033B47E", crc: true);
		TX("4B1308006E762F6974656D5F66696C65732F6D6366672F6D6366675F6175746F73656C6563745F62795F75696D5F537562736372697074696F6E30315F6261636B7570003A137E", crc: true);
		TX("4B1308006E762F6974656D5F66696C65732F6D6366672F6D6366675F6175746F73656C6563745F62795F75696D5F6261636B757000A0D67E", crc: true);
		TX("4B1308006E762F6974656D5F66696C65732F6D6366672F6D6366675F6465665F636F6E6669675F73775F76657273696F6E0072147E", crc: true);
		TX("4B1308006E762F6974656D5F66696C65732F6D6366672F6D6366675F6465665F636F6E6669675F73775F76657273696F6E5F537562736372697074696F6E3031003B437E", crc: true);
		TX("4B1308006E762F6974656D5F66696C65732F6D6366672F6D6366675F64656661756C745F68775F6469676573745F76657273696F6E0098DE7E", crc: true);
		TX("4B1308006E762F6974656D5F66696C65732F6D6366672F6D6366675F64656661756C745F73775F6469676573745F76657273696F6E0060D67E", crc: true);
		TX("4B1308006E762F6974656D5F66696C65732F6D6366672F6D6366675F64656661756C745F73775F6469676573745F76657273696F6E5F537562736372697074696F6E303100EE497E", crc: true);
		TX("4B1308006E762F6974656D5F66696C65732F6D6366672F6D6366675F68775F636F6E6669675F6469676573745F76657273696F6E0024DE7E", crc: true);
		TX("4B1308006E762F6974656D5F66696C65732F6D6366672F6D6366675F7266735F68775F6469676573745F76657273696F6E00B4807E", crc: true);
		TX("4B1308006E762F6974656D5F66696C65732F6D6366672F6D6366675F7266735F73775F6469676573745F76657273696F6E004C887E", crc: true);
		TX("4B1308006E762F6974656D5F66696C65732F6D6366672F6D6366675F73657474696E67004C457E", crc: true);
		TX("4B1308006E762F6974656D5F66696C65732F6D6366672F6D6366675F73657474696E675F310076937E", crc: true);
		TX("4B1308006E762F6974656D5F66696C65732F6D6366672F6D6366675F73775F636F6E6669675F6469676573745F76657273696F6E00C1B67E", crc: true);
		TX("4B1308006E762F6974656D5F66696C65732F6D6366672F6D6366675F73775F636F6E6669675F6469676573745F76657273696F6E5F537562736372697074696F6E303100B8957E", crc: true);
		TX("4B1308006E762F6974656D5F66696C65732F6D6366672F6D6366675F73775F696D675F6E65775F76657273696F6E00C18A7E", crc: true);
		TX("4B1308006E762F6974656D5F66696C65732F6D6366672F6D6366675F73775F6D7578645F76657273696F6E5F330046527E", crc: true);
		TX("4B1308006E762F6974656D5F66696C65732F6D6366672F6D6366675F73775F6D7578645F76657273696F6E5F3800EEB67E", crc: true);
		TX("4B1308006E762F6974656D5F66696C65732F6D6366672F7266735F637573745F706172616D7300F2F67E", crc: true);
		TX("4B1308006E762F6974656D5F66696C65732F6D6366672F6D6366675F68775F696D675F6E65775F76657273696F6E000EF17E", crc: true);
		TX("4B1308006E762F6974656D5F66696C65732F6D6366672F6D6366675F73656C5F64622E786D6C00A2CA7E", crc: true);
		TX("4B1308006E762F6974656D5F66696C65732F6D6366672F6D6366675F73775F6D7578645F76657273696F6E5F32009E4B7E", crc: true);
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("OK");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Removeing Poliyman : ");
		Form1.SharedUI.ProgressBar1.Text = "Removeing...";
		Form1.SharedUI.RichTextBox1.Update();
		method_Erase();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("OK");
		Form1.SharedUI.RichTextBox1.Update();
		if (CheckBox2.CheckState == CheckState.Checked)
		{
			method_3gauot();
		}
		method_re();
	}

	private void method_CONVRTNew_LG()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("OK");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Unlock Network (CDMA_MODE) : ");
		Form1.SharedUI.ProgressBar1.Text = "Unlocking...";
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("OK");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Write Network Values : ");
		Form1.SharedUI.ProgressBar1.Text = "Writeing...";
		method_Erase();
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("OK");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Removeing Poliyman : ");
		Form1.SharedUI.ProgressBar1.Text = "Removeing...";
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("OK");
		Form1.SharedUI.RichTextBox1.Update();
		if (CheckBox2.CheckState == CheckState.Checked)
		{
			method_3gauot();
		}
		method_re();
	}

	private void method_3gauot()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Write Activation 3G Data : ");
		Form1.SharedUI.ProgressBar1.Text = "Activation...";
		cdmaTerm.SendTerminalCommand("29 01 00", true);
		Form1.SharedUI.RichTextBox1.Update();
		cdmaTerm.SendTerminalCommand("27 04 00 3A 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 5A 98 7E", false);
		cdmaTerm.SendTerminalCommand("27 0D 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 73 C5 7E", false);
		cdmaTerm.SendTerminalCommand("27 0E 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 01 6F 7E", false);
		cdmaTerm.SendTerminalCommand("27 18 00 3F 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 8D 81 7E", false);
		cdmaTerm.SendTerminalCommand("27 27 00 3F 3F 3F 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 AF 7D 5E 7E", false);
		cdmaTerm.SendTerminalCommand("27 D0 02 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 4F 76 7E", false);
		cdmaTerm.SendTerminalCommand("27 73 03 01 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 16 C8 7E", false);
		cdmaTerm.SendTerminalCommand("27 2F 0D 02 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 6A C7 7E", false);
		cdmaTerm.SendTerminalCommand("27 3E 01 07 79 6D 6F 62 69 6C 65 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 C0 F0 7E", false);
		cdmaTerm.SendTerminalCommand("27 3F 01 07 79 6D 6F 62 69 6C 65 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 E1 6E 7E", false);
		cdmaTerm.SendTerminalCommand("27 CB 01 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 A7 A7 7E", false);
		cdmaTerm.SendTerminalCommand("27 CC 01 06 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 73 DB 7E", false);
		cdmaTerm.SendTerminalCommand("27 CD 01 04 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 5D D7 7E", false);
		cdmaTerm.SendTerminalCommand("27 CE 01 1E 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 02 07 7E", false);
		cdmaTerm.SendTerminalCommand("27 CF 01 06 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 01 71 7E", false);
		cdmaTerm.SendTerminalCommand("27 D0 01 01 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 1F BB 7E", false);
		cdmaTerm.SendTerminalCommand("27 CA 02 01 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 D6 F4 7E", false);
		cdmaTerm.SendTerminalCommand("27 57 03 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 BC 30 7E", false);
		cdmaTerm.SendTerminalCommand("27 8A 03 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 E5 7B 7E", false);
		cdmaTerm.SendTerminalCommand("27 8E 03 07 79 6D 6F 62 69 6C 65 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 32 83 7E", false);
		cdmaTerm.SendTerminalCommand("27 97 03 07 79 6D 6F 62 69 6C 65 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 D6 66 7E", false);
		cdmaTerm.SendTerminalCommand("27 98 03 07 79 6D 6F 62 69 6C 65 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 4E 75 7E", false);
		cdmaTerm.SendTerminalCommand("27 AA 04 0F 31 31 32 38 36 36 31 31 34 33 40 45 56 44 4F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 DD 13 7E", false);
		cdmaTerm.SendTerminalCommand("27 73 07 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 C2 FD 7E", false);
		cdmaTerm.SendTerminalCommand("27 09 0B 0D 4D 44 4E 40 76 7A 77 33 67 2E 63 6F 6D 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 17 34 7E", false);
		cdmaTerm.SendTerminalCommand("27 89 0B 07 79 6D 6F 62 69 6C 65 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 41 B8 7E", false);
		cdmaTerm.SendTerminalCommand("27 82 0D 01 01 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 C4 C5 7E", false);
		cdmaTerm.SendTerminalCommand("27 6C 10 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 08 47 7E", false);
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("OK");
		method_PRL();
	}

	private void OfflineA()
	{
		TX("290000E9597E", crc: false);
	}

	private void OfflineD()
	{
		TX("29010031407E", crc: false);
	}

	private void method_re()
	{
		cdmaTerm.Connect(Name_Com);
		OfflineA();
		OfflineD();
		if (Guna2CheckBox1.CheckState == CheckState.Checked)
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Reboot Device : ");
			Form1.SharedUI.ProgressBar1.Text = "Rebooting...";
			try
			{
				cdmaTerm.SendTerminalCommand("29 01 00 31 40 7E", false);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			try
			{
				cdmaTerm.SendTerminalCommand("29 02 00 59 6A 7E", false);
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ProjectData.ClearProjectError();
			}
			Delay(1.0);
			cdmaTerm.Disconnect();
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("OK");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Note : ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("If Not Rebooting Please Reboot Manual");
		}
		else
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "> Please Reboot Manual if not auto");
			cdmaTerm.Disconnect();
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

	internal static string RCONFIG()
	{
		cdmaTerm.SendTerminalCommand("260A000000000000000000000000000000000000000000000000000000000000000000000000000000000000", true);
		return cdmaTerm.thePhone.LogData.Replace("RX:", "@").Replace("\r\n", "").Replace(" ", "")
			.Split('@')[1].Substring(8, 2);
	}

	public static string ReverseHexToIMEI(string hexInput)
	{
		if (string.IsNullOrEmpty(hexInput))
		{
			return string.Empty;
		}
		string text = hexInput.Remove(0, 1);
		StringBuilder stringBuilder = new StringBuilder();
		checked
		{
			int num = text.Length - 2;
			for (int i = 1; i <= num; i += 2)
			{
				stringBuilder.Append(new string(text.Substring(i, 2).Reverse().ToArray()));
			}
			return stringBuilder.ToString().TrimStart('A');
		}
	}

	internal static string read_IMEI()
	{
		cdmaTerm.thePhone.LogData = null;
		cdmaTerm.SendTerminalCommand("2626020000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000", true);
		return ReverseHexToIMEI(cdmaTerm.thePhone.LogData.Replace("RX:", "@").Replace("\r\n", "").Replace(" ", "")
			.Split('@')[1].Substring(6, 18));
	}

	internal static string read_MEID()
	{
		cdmaTerm.thePhone.LogData = null;
		cdmaTerm.SendTerminalCommand("26DE150000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000", true);
		return MEID_Encode(cdmaTerm.thePhone.LogData.Replace("RX:", "@").Replace("\r\n", "").Replace(" ", "")
			.Split('@')[1].Substring(6, 14));
	}

	internal static string MEID_Encode(string meid)
	{
		return meid[12].ToString() + meid[13] + meid[10] + meid[11] + meid[8] + meid[9] + meid[6] + meid[7] + meid[4] + meid[5] + meid[2] + meid[3] + meid[0] + meid[1];
	}

	private void method_PRL()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Write PRL Update : ");
		Form1.SharedUI.RichTextBox1.Update();
		TX("48 00 00 00 E8 01 00 13 F8 0C 00 80 40 01 31 11 B1 92 B1 1C 80 00 10 7D 5D 4D 00 28 F8 0C 03 00 80 80 00 01 00 03 04 11 1B 19 20 0B 04 00 4E 03 FB 38 D0 08 00 01 80 00 40 60 00 58 8E 03 00 00 18 13 D9 10 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 A0 46 7E", crc: false);
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("OK");
	}

	internal static string FromHex(string hex)
	{
		hex = hex.Replace("-", "");
		checked
		{
			byte[] array = new byte[(int)Math.Round((double)hex.Length / 2.0 - 1.0) + 1];
			int num = array.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				array[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
			}
			return GetASCIIString(array);
		}
	}

	public static string GetASCIIString(byte[] bytes)
	{
		string text = SerialCOM.ConversionUtils.BytesToHexString(bytes);
		checked
		{
			string result;
			try
			{
				string text2 = "";
				int num = text.Length - 1;
				int num2;
				for (num2 = 0; num2 <= num; num2++)
				{
					if (Operators.CompareString(text.Substring(num2, 2), "00", TextCompare: false) == 0)
					{
						num2++;
					}
					else
					{
						text2 += text.Substring(num2, 2);
						num2++;
					}
				}
				string text3 = "";
				while (text2.Length > 0)
				{
					text3 += Convert.ToChar(Convert.ToUInt64(text2.Substring(0, 2), 16));
					text2 = text2.Substring(2, text2.Length - 2);
				}
				result = text3;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception projectError = ex;
				ProjectData.SetProjectError(projectError);
				result = "-1";
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
			}
			return result;
		}
	}

	private void Info()
	{
		checked
		{
			try
			{
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Gathering Modem Info : ");
				Form1.SharedUI.ProgressBar1.Text = "Gathering Modem Info..";
				Form1.SharedUI.RichTextBox1.Update();
				if (CKAUTO_CONN.Checked)
				{
					Count = Conversions.ToString(Guna2ComboBox1.Items.Count);
					if (Operators.CompareString(Count, "2", TextCompare: false) == 0)
					{
						Guna2ComboBox1.SelectedIndex = 0;
						Name_Com = Guna2ComboBox1.Text.Substring(Guna2ComboBox1.Text.IndexOf("(") + 1, Guna2ComboBox1.Text.Length - 2 - Guna2ComboBox1.Text.IndexOf("(")).Replace(")", "");
						cdmaTerm.Connect(Name_Com);
						SPC_PWD2();
						IMEI = read_IMEI();
						MEID = read_MEID();
						Delay(1.0);
						if (IMEI.Contains("0000000000000000"))
						{
							cdmaTerm.Disconnect();
							Guna2ComboBox1.SelectedIndex = 1;
							Name_Com = Guna2ComboBox1.Text.Substring(Guna2ComboBox1.Text.IndexOf("(") + 1, Guna2ComboBox1.Text.Length - 2 - Guna2ComboBox1.Text.IndexOf("(")).Replace(")", "");
							cdmaTerm.Connect(Name_Com);
							SPC_PWD2();
							IMEI = read_IMEI();
							MEID = read_MEID();
							cdmaTerm.Disconnect();
						}
						else
						{
							cdmaTerm.Disconnect();
						}
					}
					else if (Operators.CompareString(Count, "3", TextCompare: false) == 0)
					{
						Guna2ComboBox1.SelectedIndex = 0;
						Name_Com = Guna2ComboBox1.Text.Substring(Guna2ComboBox1.Text.IndexOf("(") + 1, Guna2ComboBox1.Text.Length - 2 - Guna2ComboBox1.Text.IndexOf("(")).Replace(")", "");
						cdmaTerm.Connect(Name_Com);
						SPC_PWD2();
						IMEI = read_IMEI();
						MEID = read_MEID();
						Delay(1.0);
						if (IMEI.Contains("0000000000000000"))
						{
							cdmaTerm.Disconnect();
							Guna2ComboBox1.SelectedIndex = 1;
							Name_Com = Guna2ComboBox1.Text.Substring(Guna2ComboBox1.Text.IndexOf("(") + 1, Guna2ComboBox1.Text.Length - 2 - Guna2ComboBox1.Text.IndexOf("(")).Replace(")", "");
							cdmaTerm.Connect(Name_Com);
							SPC_PWD2();
							IMEI = read_IMEI();
							MEID = read_MEID();
							Delay(1.0);
							if (IMEI.Contains("0000000000000000"))
							{
								cdmaTerm.Disconnect();
								Guna2ComboBox1.SelectedIndex = 2;
								Name_Com = Guna2ComboBox1.Text.Substring(Guna2ComboBox1.Text.IndexOf("(") + 1, Guna2ComboBox1.Text.Length - 2 - Guna2ComboBox1.Text.IndexOf("(")).Replace(")", "");
								cdmaTerm.Connect(Name_Com);
								SPC_PWD2();
								IMEI = read_IMEI();
								MEID = read_MEID();
								cdmaTerm.Disconnect();
							}
							else
							{
								cdmaTerm.Disconnect();
							}
						}
						else
						{
							cdmaTerm.Disconnect();
						}
					}
					else if (Operators.CompareString(Count, "4", TextCompare: false) == 0)
					{
						Guna2ComboBox1.SelectedIndex = 0;
						Name_Com = Guna2ComboBox1.Text.Substring(Guna2ComboBox1.Text.IndexOf("(") + 1, Guna2ComboBox1.Text.Length - 2 - Guna2ComboBox1.Text.IndexOf("(")).Replace(")", "");
						cdmaTerm.Connect(Name_Com);
						SPC_PWD2();
						IMEI = read_IMEI();
						MEID = read_MEID();
						Delay(1.0);
						if (IMEI.Contains("0000000000000000"))
						{
							cdmaTerm.Disconnect();
							Guna2ComboBox1.SelectedIndex = 1;
							Name_Com = Guna2ComboBox1.Text.Substring(Guna2ComboBox1.Text.IndexOf("(") + 1, Guna2ComboBox1.Text.Length - 2 - Guna2ComboBox1.Text.IndexOf("(")).Replace(")", "");
							cdmaTerm.Connect(Name_Com);
							SPC_PWD2();
							IMEI = read_IMEI();
							MEID = read_MEID();
							Delay(1.0);
							if (IMEI.Contains("0000000000000000"))
							{
								cdmaTerm.Disconnect();
								Guna2ComboBox1.SelectedIndex = 2;
								Name_Com = Guna2ComboBox1.Text.Substring(Guna2ComboBox1.Text.IndexOf("(") + 1, Guna2ComboBox1.Text.Length - 2 - Guna2ComboBox1.Text.IndexOf("(")).Replace(")", "");
								cdmaTerm.Connect(Name_Com);
								SPC_PWD2();
								IMEI = read_IMEI();
								MEID = read_MEID();
								Delay(1.0);
								if (IMEI.Contains("0000000000000000"))
								{
									cdmaTerm.Disconnect();
									Guna2ComboBox1.SelectedIndex = 3;
									Name_Com = Guna2ComboBox1.Text.Substring(Guna2ComboBox1.Text.IndexOf("(") + 1, Guna2ComboBox1.Text.Length - 2 - Guna2ComboBox1.Text.IndexOf("(")).Replace(")", "");
									cdmaTerm.Connect(Name_Com);
									SPC_PWD2();
									IMEI = read_IMEI();
									MEID = read_MEID();
									cdmaTerm.Disconnect();
								}
								else
								{
									cdmaTerm.Disconnect();
								}
							}
							else
							{
								cdmaTerm.Disconnect();
							}
						}
						else
						{
							cdmaTerm.Disconnect();
						}
					}
				}
				Method = "";
				cdmaTerm.Connect(Name_Com);
				cdmaTerm.SendTerminalCommand("00 78 F0 7E", false);
				FromHex(cdmaTerm.thePhone.LogData.Replace("RX:", "@").Replace("\r\n", "").Replace(" ", "")
					.Split('@')[1].Substring(2, 100));
				cdmaTerm.thePhone.LogData.Replace("RX:", "@").Replace("\r\n", "").Replace(" ", "")
					.Split('@')[1].Substring(2, 100);
				cdmaTerm.Q.Clear();
				cdmaTerm.SendTerminalCommand("7C 93 49 7E", false);
				FromHex(cdmaTerm.thePhone.LogData.Replace("RX:", "@").Replace("\r\n", "").Replace(" ", "")
					.Split('@')[1].Substring(2, 100));
				string imei = read_IMEI();
				string meid = read_MEID();
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("OK");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- IMEI : ");
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText(imei);
				Form1.SharedUI.RichTextBox1.Update();
				device_info.imei = imei;
				device_info.meid = meid;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- MEID : ");
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText(meid);
				Form1.SharedUI.RichTextBox1.Update();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Method = "no";
				ProjectData.ClearProjectError();
			}
		}
	}

	internal static void TX(string t, bool crc)
	{
		cdmaTerm.SendTerminalCommand(t, crc);
	}

	internal static void SPC_PWD_HID()
	{
		TX("4B0B24005D0200000E00550006003030303030300B3E7E", crc: false);
		TX("46FFFFFFFFFFFFFFFF00FDEE7E", crc: false);
		TX("41303030303030DF8A7E", crc: false);
		TX("462009031920090615BAED7E", crc: false);
		TX("46201211212013121994247E", crc: false);
		TX("4620100316197807215C727E", crc: false);
		TX("462009031920090615BAED7E", crc: false);
	}

	private void auot3g()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Start Activation 3G Data : ");
		cdmaTerm.SendTerminalCommand("29 01 00", true);
		Form1.SharedUI.RichTextBox1.Update();
		TX("27F0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000029D37E", crc: true);
		TX("27290103000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000EC577E", crc: true);
		TX("273E0107796D6F62696C650000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000C0F07E", crc: true);
		TX("273F0107796D6F62696C650000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000E16E7E", crc: true);
		TX("27A80100000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000D0EA7E", crc: true);
		TX("27AD010100000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000058D17E", crc: true);
		TX("27CB0101000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000A86A7E", crc: true);
		TX("27DB0102000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000219F7E", crc: true);
		TX("27C30200000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000B4767E", crc: true);
		TX("2732030100000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000031EC7E", crc: true);
		TX("27970307796D6F62696C650000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000D6667E", crc: true);
		TX("27980307796D6F62696C6500000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000004E757E", crc: true);
		TX("27FA03916C000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000085147E", crc: true);
		TX("27090B000D4D444E40767A7733672E636F6D000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000007D5E707E", crc: true);
		TX("270B0F03000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000A5C77E", crc: true);
		TX("2764130400000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000014BA7E", crc: true);
		TX("2704003A00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000005A987E", crc: true);
		TX("270D0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000073C57E", crc: true);
		TX("270E00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000016F7E", crc: true);
		TX("2718003F3F000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000008D817E", crc: true);
		TX("2727003F3F3F3F0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000AF7D5E7E", crc: true);
		TX("27D0020000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000004F767E", crc: true);
		TX("27730301000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000016C87E", crc: true);
		TX("272F0D0200000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000006AC77E", crc: true);
		TX("273E0107796D6F62696C6500000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000C0F07E", crc: true);
		TX("273F0107796D6F62696C6500000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000E16E7E", crc: true);
		TX("27CB01000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000A7A77E", crc: true);
		TX("27CC0106000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000073DB7E", crc: true);
		TX("27CD010400000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000005DD77E", crc: true);
		TX("27CE011E000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000002077E", crc: true);
		TX("27CF0106000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001717E", crc: true);
		TX("27D0010100000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001FBB7E", crc: true);
		TX("27CA02010000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000D6F47E", crc: true);
		TX("275703000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000BC307E", crc: true);
		TX("278A03000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000E57B7E", crc: true);
		TX("278E0307796D6F62696C650000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000032837E", crc: true);
		TX("27970307796D6F62696C6500000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000D6667E", crc: true);
		TX("27980307796D6F62696C65000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000004E757E", crc: true);
		TX("27AA040F31313238363631313433404556444F0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000DD137E", crc: true);
		TX("277307000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000C2FD7E", crc: true);
		TX("27090B0D4D444E40767A7733672E636F6D0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000017347E", crc: true);
		TX("27890B07796D6F62696C650000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000041B87E", crc: true);
		TX("27820D010100000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000C4C57E", crc: true);
		TX("276C1000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000008477E", crc: true);
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("OK");
	}

	private void auot3gnew()
	{
		cdmaTerm.SendTerminalCommand("29 01 00", true);
		Form1.SharedUI.RichTextBox1.Update();
		TX("27F0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000029D37E", crc: true);
		TX("27290103000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000EC577E", crc: true);
		TX("273E0107796D6F62696C650000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000C0F07E", crc: true);
		TX("273F0107796D6F62696C650000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000E16E7E", crc: true);
		TX("27A80100000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000D0EA7E", crc: true);
		TX("27AD010100000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000058D17E", crc: true);
		TX("27CB0101000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000A86A7E", crc: true);
		TX("27DB0102000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000219F7E", crc: true);
		TX("27C30200000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000B4767E", crc: true);
		TX("2732030100000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000031EC7E", crc: true);
		TX("27970307796D6F62696C650000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000D6667E", crc: true);
		TX("27980307796D6F62696C6500000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000004E757E", crc: true);
		TX("27FA03916C000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000085147E", crc: true);
		TX("27090B000D4D444E40767A7733672E636F6D000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000007D5E707E", crc: true);
		TX("270B0F03000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000A5C77E", crc: true);
		TX("2764130400000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000014BA7E", crc: true);
		TX("2704003A00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000005A987E", crc: true);
		TX("270D0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000073C57E", crc: true);
		TX("270E00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000016F7E", crc: true);
		TX("2718003F3F000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000008D817E", crc: true);
		TX("2727003F3F3F3F0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000AF7D5E7E", crc: true);
		TX("27D0020000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000004F767E", crc: true);
		TX("27730301000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000016C87E", crc: true);
		TX("272F0D0200000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000006AC77E", crc: true);
		TX("273E0107796D6F62696C6500000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000C0F07E", crc: true);
		TX("273F0107796D6F62696C6500000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000E16E7E", crc: true);
		TX("27CB01000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000A7A77E", crc: true);
		TX("27CC0106000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000073DB7E", crc: true);
		TX("27CD010400000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000005DD77E", crc: true);
		TX("27CE011E000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000002077E", crc: true);
		TX("27CF0106000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001717E", crc: true);
		TX("27D0010100000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001FBB7E", crc: true);
		TX("27CA02010000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000D6F47E", crc: true);
		TX("275703000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000BC307E", crc: true);
		TX("278A03000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000E57B7E", crc: true);
		TX("278E0307796D6F62696C650000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000032837E", crc: true);
		TX("27970307796D6F62696C6500000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000D6667E", crc: true);
		TX("27980307796D6F62696C65000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000004E757E", crc: true);
		TX("27AA040F31313238363631313433404556444F0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000DD137E", crc: true);
		TX("277307000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000C2FD7E", crc: true);
		TX("27090B0D4D444E40767A7733672E636F6D0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000017347E", crc: true);
		TX("27890B07796D6F62696C650000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000041B87E", crc: true);
		TX("27820D010100000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000C4C57E", crc: true);
		TX("276C1000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000008477E", crc: true);
	}

	private void method_Erasemodem()
	{
		TX("462015062920150831", crc: true);
		TX("4b090a000000b1557e", crc: true);
		TX("4b090a00000500972a7e", crc: true);
		TX("4b0801000000e09e7e", crc: true);
		TX("4b080100083a4522193180384900000000000000000000000000000606000500aca27e", crc: true);
		TX("4b13260004000000000000000000535052002f2f6e762f6974656d5f66696c65732f6d6f64656d2f73616c65636f64652f6e65745f636f64655f3100a3a77e", crc: true);
		TX("4b13260000000000000091ad7e", crc: true);
	}

	private void method_Erase()
	{
		cdmaTerm.SendTerminalCommand("4B 04 0E 00 0D D3 7E", false);
		cdmaTerm.SendTerminalCommand("4B 13 0B 00 2F 00 19 11 7E", false);
		cdmaTerm.SendTerminalCommand("4B 13 08 00 6E 76 2F 69 74 65 6D 5F 66 69 6C 65 73 2F 6D 6F 64 65 6D 2F 6D 6D 6F 64 65 2F 63 64 6D 61 5F 6C 65 73 73 00 1D 16 7E", true);
		cdmaTerm.SendTerminalCommand("4B 13 08 00 70 6F 6C 69 63 79 6D 61 6E 2F 64 65 76 69 63 65 5F 63 6F 6E 66 69 67 00 82 00 7E", true);
		cdmaTerm.SendTerminalCommand("4B 13 08 00 70 6F 6C 69 63 79 6D 61 6E 2F 63 61 72 72 69 65 72 5F 70 6F 6C 69 63 79 2E 78 6D 6C 00 F4 BA 7E", true);
		cdmaTerm.SendTerminalCommand("4B 13 08 00 70 6F 6C 69 63 79 6D 61 6E 2F 72 61 74 5F 6D 61 73 6B 00 73 60 7E", true);
		cdmaTerm.SendTerminalCommand("4B 13 08 00 70 6F 6C 69 63 79 6D 61 6E 2F 73 76 63 5F 6D 6F 64 65 5F 53 75 62 73 63 72 69 70 74 69 6F 6E 30 31 00 AE 4C 7E", true);
		cdmaTerm.SendTerminalCommand("4B 13 08 00 70 6F 6C 69 63 79 6D 61 6E 2F 73 76 63 5F 6D 6F 64 65 00 EB A5 7E", true);
		cdmaTerm.SendTerminalCommand("4B 13 08 00 70 6F 6C 69 63 79 6D 61 6E 2F 72 61 74 5F 6D 61 73 6B 5F 53 75 62 73 63 72 69 70 74 69 6F 6E 30 31 00 AF C8 7E", true);
		cdmaTerm.SendTerminalCommand("4B 13 08 00 70 6F 6C 69 63 79 6D 61 6E 2F 75 65 5F 6D 6F 64 65 00 EF 27 7E", true);
		cdmaTerm.SendTerminalCommand("4B 13 08 00 70 6F 6C 69 63 79 6D 61 6E 2F 75 65 5F 6D 6F 64 65 5F 53 75 62 73 63 72 69 70 74 69 6F 6E 30 31 00 1D 1F 7E", true);
		cdmaTerm.SendTerminalCommand("4B 13 08 00 70 6F 6C 69 63 79 6D 61 6E 2F 72 61 74 5F 6D 61 73 6B 5F 53 75 62 73 63 72 69 70 74 69 6F 6E 30 31 00 AF C8 7E", true);
		cdmaTerm.SendTerminalCommand("4B 13 08 00 70 6F 6C 69 63 79 6D 61 6E 2F 70 6F 6C 69 63 79 33 2F 63 61 72 72 69 65 72 5F 70 6F 6C 69 63 79 2E 78 6D 6C 00 B2 7A 7E", true);
		cdmaTerm.SendTerminalCommand("4B 13 08 00 70 6F 6C 69 63 79 6D 61 6E 2F 63 61 6C 6C 5F 6D 6F 64 65 00 98 FA 7E", true);
		cdmaTerm.SendTerminalCommand("4B 13 08 00 70 6F 6C 69 63 79 6D 61 6E 2F 63 61 6C 6C 5F 6D 6F 64 65 5F 53 75 62 73 63 72 69 70 74 69 6F 6E 30 31 00 03 EA 7E", true);
		cdmaTerm.SendTerminalCommand("4B 13 08 00 70 6F 6C 69 63 79 6D 61 6E 2F 63 75 72 72 65 6E 74 5F 6D 63 63 00 A6 07 7E", true);
		cdmaTerm.SendTerminalCommand("4B 13 08 00 70 6F 6C 69 63 79 6D 61 6E 2F 63 75 72 72 65 6E 74 5F 6D 63 63 5F 53 75 62 73 63 72 69 70 74 69 6F 6E 30 31 00 48 38 7E", true);
		cdmaTerm.SendTerminalCommand("4B 13 08 00 70 6F 6C 69 63 79 6D 61 6E 2F 70 6F 6C 69 63 79 31 2F 63 61 72 72 69 65 72 5F 70 6F 6C 69 63 79 2E 78 6D 6C 00 6A 14 7E", true);
		cdmaTerm.SendTerminalCommand("4B 13 08 00 70 6F 6C 69 63 79 6D 61 6E 2F 63 75 72 72 65 6E 74 5F 6D 63 63 00 A6 07 7E", true);
		cdmaTerm.SendTerminalCommand("4B 13 08 00 70 6F 6C 69 63 79 6D 61 6E 2F 64 65 76 69 63 65 5F 63 6F 6E 66 69 67 00 82 00 7E", true);
		cdmaTerm.SendTerminalCommand("4B 13 08 00 70 6F 6C 69 63 79 6D 61 6E 2F 72 61 74 5F 6D 61 73 6B 00 73 60 7E", true);
		cdmaTerm.SendTerminalCommand("4B 13 08 00 70 6F 6C 69 63 79 6D 61 6E 2F 72 61 74 5F 6D 61 73 6B 5F 53 75 62 73 63 72 69 70 74 69 6F 6E 30 31 00 AF C8 7E", true);
		cdmaTerm.SendTerminalCommand("4B 13 08 00 70 6F 6C 69 63 79 6D 61 6E 2F 73 76 63 5F 6D 6F 64 65 00 EB A5 7E", true);
		cdmaTerm.SendTerminalCommand("4B 13 08 00 70 6F 6C 69 63 79 6D 61 6E 2F 73 76 63 5F 6D 6F 64 65 5F 53 75 62 73 63 72 69 70 74 69 6F 6E 30 31 00 AE 4C 7E", true);
		cdmaTerm.SendTerminalCommand("4B 13 08 00 70 6F 6C 69 63 79 6D 61 6E 2F 75 65 5F 6D 6F 64 65 00 EF 27 7E", true);
		cdmaTerm.SendTerminalCommand("4B 13 08 00 70 6F 6C 69 63 79 6D 61 6E 2F 75 65 5F 6D 6F 64 65 5F 53 75 62 73 63 72 69 70 74 69 6F 6E 30 31 00 1D 1F 7E", true);
		cdmaTerm.SendTerminalCommand("4B 13 08 00 70 6F 6C 69 63 79 6D 61 6E 2F 70 6F 6C 69 63 79 31 2F 63 61 72 72 69 65 72 5F 70 6F 6C 69 63 79 2E 78 6D 6C 00 6A 14 7E", true);
		cdmaTerm.SendTerminalCommand("4B 13 08 00 70 6F 6C 69 63 79 6D 61 6E 2F 70 6F 6C 69 63 79 32 2F 63 61 72 72 69 65 72 5F 70 6F 6C 69 63 79 2E 78 6D 6C 00 DE 4D 7E", true);
		cdmaTerm.SendTerminalCommand("4B 13 08 00 70 6F 6C 69 63 79 6D 61 6E 2F 70 6F 6C 69 63 79 33 2F 63 61 72 72 69 65 72 5F 70 6F 6C 69 63 79 2E 78 6D 6C 00 B2 7A 7E", true);
		cdmaTerm.SendTerminalCommand("4B 13 08 00 70 6F 6C 69 63 79 6D 61 6E 2F 64 65 76 69 63 65 5F 63 6F 6E 66 69 67 2E 78 6D 6C 00 B5 60 7E", true);
		cdmaTerm.SendTerminalCommand("4B 13 08 00 70 6F 6C 69 63 79 6D 61 6E 2F 66 72 65 71 5F 6C 69 73 74 00 32 BD 7E", true);
		cdmaTerm.SendTerminalCommand("4B 13 08 00 70 6F 6C 69 63 79 6D 61 6E 2F 66 72 65 71 5F 6C 69 73 74 5F 53 75 62 73 63 72 69 70 74 69 6F 6E 30 31 00 61 6A 7E", true);
	}

	private void WMEID(string imei)
	{
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("OK");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Writeing MEID : ");
		cdmaTerm.SendTerminalCommand("279707" + MEID_Encode(imei) + "0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000", true);
		cdmaTerm.SendTerminalCommand("26DE150000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000", true);
		if (Operators.CompareString(read_MEID(), imei, TextCompare: false) == 0)
		{
			Form1.SharedUI.RichTextBox1.Update();
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("OK");
		}
	}

	public static string IMEIToReverseHex(string imei)
	{
		if (string.IsNullOrEmpty(imei))
		{
			return string.Empty;
		}
		StringBuilder stringBuilder = new StringBuilder();
		checked
		{
			int num = imei.Length - 2;
			for (int i = 1; i <= num; i += 2)
			{
				stringBuilder.Append(new string(imei.Substring(i, 2).Reverse().ToArray()));
			}
			return FormatHexStr($"08{imei[0]}A{stringBuilder.ToString()}");
		}
	}

	public static string FormatHexStr(string hexStr)
	{
		StringBuilder stringBuilder = new StringBuilder();
		string result;
		checked
		{
			try
			{
				int num = hexStr.Length - 1;
				for (int i = 0; i <= num; i += 2)
				{
					stringBuilder.Append(hexStr.Substring(i, 2) + " ");
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception projectError = ex;
				ProjectData.SetProjectError(projectError);
				string obj = stringBuilder.ToString().TrimEnd();
				ProjectData.ClearProjectError();
				result = obj;
				ProjectData.ClearProjectError();
				goto IL_0068;
			}
			return stringBuilder.ToString().TrimEnd();
		}
		IL_0068:
		return result;
	}

	private void W_IMEI(string imei)
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("OK");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Writeing IMEI : ");
		cdmaTerm.SendTerminalCommand("272602" + IMEIToReverseHex(imei) + "0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000", true);
		Operators.CompareString(read_IMEI(), imei, TextCompare: false);
	}

	public void runExFB(string Commands)
	{
		Process process = new Process();
		process.StartInfo.FileName = ThisLocation + "bin\\Tunlocker Tool.exe";
		process.StartInfo.Arguments = "/c " + Commands;
		process.StartInfo.CreateNoWindow = true;
		process.StartInfo.UseShellExecute = false;
		process.StartInfo.RedirectStandardOutput = true;
		process.StartInfo.RedirectStandardError = true;
		process.Start();
		process.WaitForExit();
	}

	public bool chacknet()
	{
		bool result;
		try
		{
			using WebClient webClient = new WebClient();
			using (webClient.OpenRead("https://google.com/"))
			{
				result = true;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			result = false;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private void Guna2Button8_Click(object sender, EventArgs e)
	{
		start();
		ThreadNew = new Thread(method_adb8);
		ThreadNew.Start();
	}

	public void COMLG()
	{
		ComboBox1.Items.Clear();
		new ManagementObjectSearcher("SELECT * FROM WIN32_SerialPort").Get();
		foreach (COMPortInfoO item in COMPortInfoO.GetCOMPortsInfolg())
		{
			ComboBox1.Items.Add(string.Format("{0}{1}", "\r", item.Description));
			TextBox33.Text = Conversions.ToString(ComboBox1.Items.Count);
			if (Operators.CompareString(TextBox33.Text, "1", TextCompare: false) == 0)
			{
				ComboBox1.SelectedIndex = 0;
				text3.Text = ComboBox1.SelectedItem.ToString();
				if (!(text3.Text.Contains("USB Serial Port") | Guna2ComboBox1.Text.Contains("HS-USB") | Guna2ComboBox1.Text.Contains("Diagnostics")))
				{
					ComboBox1.Items.RemoveAt(ComboBox1.SelectedIndex);
				}
			}
			if (Operators.CompareString(TextBox33.Text, "2", TextCompare: false) == 0)
			{
				ComboBox1.SelectedIndex = 0;
				text3.Text = ComboBox1.SelectedItem.ToString();
				if (!(text3.Text.Contains("USB Serial Port") | Guna2ComboBox1.Text.Contains("HS-USB") | Guna2ComboBox1.Text.Contains("Diagnostics")))
				{
					ComboBox1.Items.RemoveAt(ComboBox1.SelectedIndex);
				}
				ComboBox1.SelectedIndex = 1;
				text3.Text = ComboBox1.SelectedItem.ToString();
				if (!(text3.Text.Contains("USB Serial Port") | Guna2ComboBox1.Text.Contains("HS-USB") | Guna2ComboBox1.Text.Contains("Diagnostics")))
				{
					ComboBox1.Items.RemoveAt(ComboBox1.SelectedIndex);
				}
			}
			if (Operators.CompareString(TextBox33.Text, "3", TextCompare: false) == 0)
			{
				ComboBox1.SelectedIndex = 0;
				text3.Text = ComboBox1.SelectedItem.ToString();
				if (!(text3.Text.Contains("USB Serial Port") | Guna2ComboBox1.Text.Contains("HS-USB") | Guna2ComboBox1.Text.Contains("Diagnostics")))
				{
					ComboBox1.Items.RemoveAt(ComboBox1.SelectedIndex);
				}
				ComboBox1.SelectedIndex = 1;
				text3.Text = ComboBox1.SelectedItem.ToString();
				if (!(text3.Text.Contains("USB Serial Port") | Guna2ComboBox1.Text.Contains("HS-USB") | Guna2ComboBox1.Text.Contains("Diagnostics")))
				{
					ComboBox1.Items.RemoveAt(ComboBox1.SelectedIndex);
				}
				ComboBox1.SelectedIndex = 2;
				text3.Text = ComboBox1.SelectedItem.ToString();
				if (!(text3.Text.Contains("USB Serial Port") | Guna2ComboBox1.Text.Contains("HS-USB") | Guna2ComboBox1.Text.Contains("Diagnostics")))
				{
					ComboBox1.Items.RemoveAt(ComboBox1.SelectedIndex);
				}
			}
			if (Operators.CompareString(TextBox33.Text, "4", TextCompare: false) == 0)
			{
				ComboBox1.SelectedIndex = 0;
				text3.Text = ComboBox1.SelectedItem.ToString();
				if (!(text3.Text.Contains("USB Serial Port") | Guna2ComboBox1.Text.Contains("HS-USB") | Guna2ComboBox1.Text.Contains("Diagnostics")))
				{
					ComboBox1.Items.RemoveAt(ComboBox1.SelectedIndex);
				}
				ComboBox1.SelectedIndex = 1;
				text3.Text = ComboBox1.SelectedItem.ToString();
				if (!(text3.Text.Contains("USB Serial Port") | Guna2ComboBox1.Text.Contains("HS-USB") | Guna2ComboBox1.Text.Contains("Diagnostics")))
				{
					ComboBox1.Items.RemoveAt(ComboBox1.SelectedIndex);
				}
				ComboBox1.SelectedIndex = 2;
				text3.Text = ComboBox1.SelectedItem.ToString();
				if (!(text3.Text.Contains("USB Serial Port") | Guna2ComboBox1.Text.Contains("HS-USB") | Guna2ComboBox1.Text.Contains("Diagnostics")))
				{
					ComboBox1.Items.RemoveAt(ComboBox1.SelectedIndex);
				}
				ComboBox1.SelectedIndex = 3;
				text3.Text = ComboBox1.SelectedItem.ToString();
				if (!(text3.Text.Contains("USB Serial Port") | Guna2ComboBox1.Text.Contains("HS-USB") | Guna2ComboBox1.Text.Contains("Diagnostics")))
				{
					ComboBox1.Items.RemoveAt(ComboBox1.SelectedIndex);
				}
			}
			if (Operators.CompareString(TextBox33.Text, "5", TextCompare: false) == 0)
			{
				ComboBox1.SelectedIndex = 0;
				text3.Text = ComboBox1.SelectedItem.ToString();
				if (!(text3.Text.Contains("USB Serial Port") | Guna2ComboBox1.Text.Contains("HS-USB") | Guna2ComboBox1.Text.Contains("Diagnostics")))
				{
					ComboBox1.Items.RemoveAt(ComboBox1.SelectedIndex);
				}
				ComboBox1.SelectedIndex = 1;
				text3.Text = ComboBox1.SelectedItem.ToString();
				if (!(text3.Text.Contains("USB Serial Port") | Guna2ComboBox1.Text.Contains("HS-USB") | Guna2ComboBox1.Text.Contains("Diagnostics")))
				{
					ComboBox1.Items.RemoveAt(ComboBox1.SelectedIndex);
				}
				ComboBox1.SelectedIndex = 2;
				text3.Text = ComboBox1.SelectedItem.ToString();
				if (!(text3.Text.Contains("USB Serial Port") | Guna2ComboBox1.Text.Contains("HS-USB") | Guna2ComboBox1.Text.Contains("Diagnostics")))
				{
					ComboBox1.Items.RemoveAt(ComboBox1.SelectedIndex);
				}
				ComboBox1.SelectedIndex = 3;
				text3.Text = ComboBox1.SelectedItem.ToString();
				if (!(text3.Text.Contains("USB Serial Port") | Guna2ComboBox1.Text.Contains("HS-USB") | Guna2ComboBox1.Text.Contains("Diagnostics")))
				{
					ComboBox1.Items.RemoveAt(ComboBox1.SelectedIndex);
				}
				ComboBox1.SelectedIndex = 4;
				text3.Text = ComboBox1.SelectedItem.ToString();
				if (!(text3.Text.Contains("USB Serial Port") | Guna2ComboBox1.Text.Contains("HS-USB") | Guna2ComboBox1.Text.Contains("Diagnostics")))
				{
					ComboBox1.Items.RemoveAt(ComboBox1.SelectedIndex);
				}
			}
			if (Operators.CompareString(TextBox33.Text, "6", TextCompare: false) == 0)
			{
				ComboBox1.SelectedIndex = 0;
				text3.Text = ComboBox1.SelectedItem.ToString();
				if (!(text3.Text.Contains("USB Serial Port") | Guna2ComboBox1.Text.Contains("HS-USB") | Guna2ComboBox1.Text.Contains("Diagnostics")))
				{
					ComboBox1.Items.RemoveAt(ComboBox1.SelectedIndex);
				}
				ComboBox1.SelectedIndex = 1;
				text3.Text = ComboBox1.SelectedItem.ToString();
				if (!(text3.Text.Contains("USB Serial Port") | Guna2ComboBox1.Text.Contains("HS-USB") | Guna2ComboBox1.Text.Contains("Diagnostics")))
				{
					ComboBox1.Items.RemoveAt(ComboBox1.SelectedIndex);
				}
				ComboBox1.SelectedIndex = 2;
				text3.Text = ComboBox1.SelectedItem.ToString();
				if (!(text3.Text.Contains("USB Serial Port") | Guna2ComboBox1.Text.Contains("HS-USB") | Guna2ComboBox1.Text.Contains("Diagnostics")))
				{
					ComboBox1.Items.RemoveAt(ComboBox1.SelectedIndex);
				}
				ComboBox1.SelectedIndex = 3;
				text3.Text = ComboBox1.SelectedItem.ToString();
				if (!(text3.Text.Contains("USB Serial Port") | Guna2ComboBox1.Text.Contains("HS-USB") | Guna2ComboBox1.Text.Contains("Diagnostics")))
				{
					ComboBox1.Items.RemoveAt(ComboBox1.SelectedIndex);
				}
				ComboBox1.SelectedIndex = 4;
				text3.Text = ComboBox1.SelectedItem.ToString();
				if (!(text3.Text.Contains("USB Serial Port") | Guna2ComboBox1.Text.Contains("HS-USB") | Guna2ComboBox1.Text.Contains("Diagnostics")))
				{
					ComboBox1.Items.RemoveAt(ComboBox1.SelectedIndex);
				}
				ComboBox1.SelectedIndex = 5;
				text3.Text = ComboBox1.SelectedItem.ToString();
				if (!(text3.Text.Contains("USB Serial Port") | Guna2ComboBox1.Text.Contains("HS-USB") | Guna2ComboBox1.Text.Contains("Diagnostics")))
				{
					ComboBox1.Items.RemoveAt(ComboBox1.SelectedIndex);
				}
			}
		}
		method_DistributionPorts();
	}

	public void method_DistributionPorts()
	{
		TextBox33.Text = Conversions.ToString(ComboBox1.Items.Count);
		if (Operators.CompareString(TextBox33.Text, "1", TextCompare: false) == 0)
		{
			ComboBox1.SelectedIndex = 0;
			Guna2ComboBox1.Items.Clear();
			string text = ComboBox1.SelectedItem.ToString();
			Guna2ComboBox1.Items.Add(text);
			text = checked(text.Substring(text.IndexOf("(") + 1, text.Length - 2 - text.IndexOf("("))).Replace(")", "");
			Name_Com = text;
		}
		else
		{
			Form1.SharedUI.RichTextBox1.Update();
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "> Sorry, But You Have 2 Devices Connected Unplug One Device To Continue");
			finshonly();
		}
	}

	public void method_adb8()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.CTS);
		Form1.SharedUI.ProgressBar1.Text = "Connecting....";
		method_infoadb2();
		if (Operators.CompareString(cancel, "Cancel", TextCompare: false) == 0)
		{
			finshonly();
		}
		else if (Operators.CompareString(TextBox10, "NOT", TextCompare: false) != 0)
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Check If Model Supported : ");
			check_model();
			finshonly();
		}
	}

	public void method_adb9()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.CTS);
		Form1.SharedUI.ProgressBar1.Text = "Connecting....";
		method_infoadb2();
		if (Operators.CompareString(cancel, "Cancel", TextCompare: false) == 0)
		{
			finshonly();
		}
		else if (Operators.CompareString(TextBox10, "NOT", TextCompare: false) != 0)
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Check If Model Supported : ");
			check_Convert();
		}
	}

	public void check_Convert()
	{
		if ("SM-S115DL-SM-S124DL-SM-A025U1-SM-A025U-SM-A115U-SM-A115U1-SM-A426U-SM-A426U1".Contains(Label4))
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Supported");
			Form1.SharedUI.RichTextBox1.Update();
			if (!usb_config.Contains("diag"))
			{
				wronganswer_wave();
				Form1.SharedUI.Guna2MessageDialog1.Text = "Please Enable Diag Port : \r\nDial *#0808# and select DM+ACM+ADB\r\n\r\nThen press OK to Continue...";
				Form1.SharedUI.Guna2MessageDialog1.Show();
			}
			usb_config = Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + serialno.Text + " shell getprop sys.usb.config", new object[0]), false);
			if (!usb_config.Contains("diag"))
			{
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "> Please Enable Diag Port, Then Try Again");
				finshonly();
			}
			else
			{
				method_Samsung_noQCN();
			}
		}
		else if ("SM-A025V-SM-A025AP-SM-A025AZ-SM-A025A-SM-A115AP-SM-A115A-SM-A115AZ-SM-A115V".Contains(Label4))
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Supported");
			Form1.SharedUI.RichTextBox1.Update();
			if (!usb_config.Contains("diag"))
			{
				wronganswer_wave();
				Form1.SharedUI.Guna2MessageDialog1.Text = "Please Enable Diag Port : \r\nDial *#0808# and select DM+ACM+ADB\r\n\r\nThen press OK to Continue...";
				Form1.SharedUI.Guna2MessageDialog1.Show();
			}
			usb_config = Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + serialno.Text + " shell getprop sys.usb.config", new object[0]), false);
			if (!usb_config.Contains("diag"))
			{
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "> Please Enable Diag Port, Then Try Again");
				finshonly();
			}
			else
			{
				method_Samsung_QCN();
			}
		}
		else if ("LGE".Contains(Label15))
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Supported");
			Form1.SharedUI.RichTextBox1.Update();
			if (Label4.Contains("K420MM"))
			{
				method_lg_QCN();
			}
			else
			{
				method_LG_noQCN();
			}
		}
		else
		{
			Guna2Button6.Enabled = false;
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText("Not Supported");
			Form1.SharedUI.RichTextBox1.Update();
			finshonly();
		}
	}

	public void check_model()
	{
		Form1.SharedUI.ProgressBar1.Text = "Check Model From Server...";
		if (!chacknet())
		{
			Form1.SharedUI.MaterialCard3.Enabled = false;
			Form1.SharedUI.RichTextBox1.Update();
			Form1.SharedUI.ProgressBar1.Roll = false;
			Form1.SharedUI.ProgressBar1.Text = "100%";
		}
		Form1.SharedUI.ProgressBar1.Text = "Waiting..";
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("OK");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.LightGreen;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " + Supported Operations :-");
		if ("SM-S115DL-SM-S124DL-SM-A025U1-SM-A025U-SM-A115U-SM-A115U1".Contains(Label4))
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Convert To CDMA");
			Guna2Button6.Enabled = true;
			if (QcomString.Contains("mt") | QcomString.Contains("exynos"))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Install 4G Setting");
				Guna2Button1.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Install VoLTE Setting");
				Guna2Button16.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Repair 4G If Not Work");
				Guna2Button18.Enabled = true;
			}
			else if (QcomString.Contains("qcom"))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Install 4G Setting");
				Guna2Button1.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Install 3G Setting");
				Guna2Button5.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Install VoLTE Setting");
				Guna2Button16.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Read carrier_policy");
				Guna2Button2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Write carrier_policy");
				Guna2Button3.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Repair Baseband");
				Guna2Button4.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Remove Policyman");
				Guna2Button7.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Repair Replace SIM");
				Guna2Button14.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Repair 4G If Not Work");
				Guna2Button18.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Patch And Edit SIM [Sprint]");
				Guna2Button11.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Enable Bands [All]");
				Guna2Button13.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Disable Bands [All]");
				Guna2Button12.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Write QCN");
				Guna2Button15.Enabled = true;
				Guna2Button10.Enabled = true;
				txtqcn.Enabled = true;
			}
		}
		else if ("LGE".Contains(Label15))
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Convert To CDMA");
			Guna2Button6.Enabled = true;
			if (!QcomString.Contains("mt"))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Install 4G Setting");
				Guna2Button1.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Install 3G Setting");
				Guna2Button5.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Read carrier_policy");
				Guna2Button2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Write carrier_policy");
				Guna2Button3.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Repair Baseband");
				Guna2Button4.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Remove Policyman");
				Guna2Button7.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Repair Replace SIM");
				Guna2Button14.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Repair 4G If Not Work");
				Guna2Button18.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Patch And Edit SIM [Sprint]");
				Guna2Button11.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Enable Bands [All]");
				Guna2Button13.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Disable Bands [All]");
				Guna2Button12.Enabled = true;
			}
		}
		else if ("SM-A025V-SM-A025AP-SM-A025AZ-SM-A025A-SM-A115AP-SM-A115A-SM-A115AZ-SM-A115V".Contains(Label4))
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Convert To CDMA");
			Guna2Button6.Enabled = true;
			if (QcomString.Contains("mt") | QcomString.Contains("exynos"))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Install 4G Setting");
				Guna2Button1.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Install VoLTE Setting");
				Guna2Button16.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Repair 4G If Not Work");
				Guna2Button18.Enabled = true;
			}
			else if (QcomString.Contains("qcom"))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Install 4G Setting");
				Guna2Button1.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Install 3G Setting");
				Guna2Button5.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Install VoLTE Setting");
				Guna2Button16.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Read carrier_policy");
				Guna2Button2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Write carrier_policy");
				Guna2Button3.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Repair Baseband");
				Guna2Button4.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Remove Policyman");
				Guna2Button7.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Repair Replace SIM");
				Guna2Button14.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Repair 4G If Not Work");
				Guna2Button18.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Patch And Edit SIM [Sprint]");
				Guna2Button11.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Enable Bands [All]");
				Guna2Button13.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Disable Bands [All]");
				Guna2Button12.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Write QCN");
				Guna2Button15.Enabled = true;
				Guna2Button10.Enabled = true;
				txtqcn.Enabled = true;
			}
		}
		else
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Not Supported Operation >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText("Convert To CDMA");
			Guna2Button6.Enabled = false;
			if (QcomString.Contains("mt") | QcomString.Contains("exynos"))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Install 4G Setting");
				Guna2Button1.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Install VoLTE Setting");
				Guna2Button16.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Repair 4G If Not Work");
				Guna2Button18.Enabled = true;
			}
			else if (QcomString.Contains("qcom"))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Install 4G Setting");
				Guna2Button1.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Install 3G Setting");
				Guna2Button5.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Install VoLTE Setting");
				Guna2Button16.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Read carrier_policy");
				Guna2Button2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Write carrier_policy");
				Guna2Button3.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Repair Baseband");
				Guna2Button4.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Remove Policyman");
				Guna2Button7.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Repair Replace SIM");
				Guna2Button14.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Repair 4G If Not Work");
				Guna2Button18.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Patch And Edit SIM [Sprint]");
				Guna2Button11.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Enable Bands [All]");
				Guna2Button13.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Disable Bands [All]");
				Guna2Button12.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Write QCN");
				Guna2Button15.Enabled = true;
				Guna2Button10.Enabled = true;
				txtqcn.Enabled = true;
			}
		}
	}

	public void check_4g()
	{
		if (QcomString.Contains("qcom"))
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Supported");
			Form1.SharedUI.RichTextBox1.Update();
			if (!usb_config.Contains("diag"))
			{
				wronganswer_wave();
				Form1.SharedUI.Guna2MessageDialog1.Text = "Please Enable Diag Port : \r\nDial *#0808# and select DM+ACM+ADB\r\n\r\nThen press OK to Continue...";
				Form1.SharedUI.Guna2MessageDialog1.Show();
			}
			usb_config = Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + serialno.Text + " shell getprop sys.usb.config", new object[0]), false);
			if (!usb_config.Contains("diag"))
			{
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "> Please Enable Diag Port, Then Try Again");
				finshonly();
			}
			else
			{
				method_auot4gQC();
			}
		}
		else if ("LGE".Contains(Label15))
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Supported");
			Form1.SharedUI.RichTextBox1.Update();
			method_auot4gQC();
		}
		else if (QcomString.Contains("mt") | QcomString.Contains("exynos"))
		{
			if ("samsung".Contains(Label15))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Supported");
				Form1.SharedUI.RichTextBox1.Update();
				if (!usb_config.Contains("mtp"))
				{
					wronganswer_wave();
					Form1.SharedUI.Guna2MessageDialog1.Text = "Please Enable mtp Port : \r\nDial *#0808# and select MTP+ADB\r\n\r\nThen press OK to Continue...";
					Form1.SharedUI.Guna2MessageDialog1.Show();
				}
				auot4gEX();
			}
			else
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
				Form1.SharedUI.RichTextBox1.AppendText("Not Supported");
				Form1.SharedUI.RichTextBox1.Update();
				finshonly();
			}
		}
		else
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText("Not Supported");
			Form1.SharedUI.RichTextBox1.Update();
			finshonly();
		}
	}

	private void Timer10_Tick(object sender, EventArgs e)
	{
		if (Operators.CompareString(ProgressBa, "HHHHHHHHHHHHHHHHHHHHHHHHHH", TextCompare: false) == 0)
		{
			Form1.SharedUI.Guna2TaskBarProgress1.Value = 0;
			Form1.SharedUI.Guna2TaskBarProgress1.State = Guna2TaskBarProgress.TaskbarStates.Normal;
			Form1.SharedUI.Guna2TaskBarProgress1.Value = 0;
			Form1.SharedUI.Guna2TaskBarProgress1.State = Guna2TaskBarProgress.TaskbarStates.Normal;
			Form1.SharedUI.Guna2TaskBarProgress1.Value = 0;
			Form1.SharedUI.Guna2TaskBarProgress1.State = Guna2TaskBarProgress.TaskbarStates.Indeterminate;
			Form1.SharedUI.ProgressBar4.Visible = false;
			Form1.SharedUI.ProgressBar4.Maximum = 100;
			Form1.SharedUI.ProgressBar4.Value = 0;
			ProgressBa = "HHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHH";
		}
		if (Operators.CompareString(ProgressBa, "ENREADDEVICE", TextCompare: false) == 0)
		{
			Form1.SharedUI.Guna2TaskBarProgress1.State = Guna2TaskBarProgress.TaskbarStates.Normal;
			Form1.SharedUI.ProgressBar4.Visible = true;
			Form1.SharedUI.ProgressBar4.Increment(1);
			ProgressChanged = Conversions.ToString(Form1.SharedUI.ProgressBar4.Value);
			Form1.SharedUI.Guna2TaskBarProgress1.Value = Form1.SharedUI.ProgressBar4.Value;
			if (Form1.SharedUI.ProgressBar4.Value == 100)
			{
				Form1.SharedUI.ProgressBar4.Value = 100;
			}
		}
		if (Operators.CompareString(ProgressBa, "ENREAD", TextCompare: false) == 0)
		{
			Form1.SharedUI.Guna2TaskBarProgress1.State = Guna2TaskBarProgress.TaskbarStates.Normal;
			Form1.SharedUI.Guna2TaskBarProgress1.Value = Form1.SharedUI.ProgressBar4.Value;
			Form1.SharedUI.ProgressBar4.Visible = true;
		}
		if (Operators.CompareString(ProgressBa, "DISREAD", TextCompare: false) == 0)
		{
			Form1.SharedUI.ProgressBar4.Visible = false;
			Form1.SharedUI.ProgressBar4.Maximum = 100;
			Form1.SharedUI.ProgressBar4.Value = 0;
			ProgressBa = "HHHHHHHHHHHHHHHHHHHHHHHHHH";
		}
		if (Operators.CompareString(ProgressBa, "Cen", TextCompare: false) == 0)
		{
			Form1.SharedUI.ProgressBar4.Visible = false;
			Form1.SharedUI.ProgressBar4.Maximum = 100;
			Form1.SharedUI.ProgressBar4.Value = 0;
		}
	}

	private void Guna2Button16_Click(object sender, EventArgs e)
	{
		start();
		ThreadNew = new Thread(method_adb11);
		ThreadNew.Start();
	}

	private void Guna2Button1_Click(object sender, EventArgs e)
	{
		start();
		ThreadNew = new Thread(method_adb10);
		ThreadNew.Start();
	}

	public void method_adb10()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.CTS);
		Form1.SharedUI.ProgressBar1.Text = "Connecting....";
		method_infoadb2();
		if (Operators.CompareString(cancel, "Cancel", TextCompare: false) == 0)
		{
			finshonly();
		}
		else if (Operators.CompareString(TextBox10, "NOT", TextCompare: false) != 0)
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Check If Model Supported : ");
			check_4g();
		}
	}

	private void method_Setlie2()
	{
		cdmaTerm.SendTerminalCommand("27AC1A44000808000000004400080800000000000000000000000000000000000000000000000000000000000000000000000000000000000000", true);
	}

	private void method_enablebend()
	{
		cdmaTerm.SendTerminalCommand("27AC1A44000808000000004400080800000000000000000000000000000000000000000000000000000000000000000000000000000000000000", true);
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("Success");
		Form1.SharedUI.RichTextBox1.Update();
	}

	public void carrierNEAM()
	{
		if (Label4.Contains("SM-G991"))
		{
			NameFile4G = "tmp\\4g\\S21 ULTRA 5G\\carrier_policy.xml";
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Galaxy S21 5G");
		}
		else if (Label4.Contains("SM-G998"))
		{
			NameFile4G = "tmp\\4g\\S21 ULTRA 5G\\carrier_policy.xml";
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Galaxy S21 Ultra 5G");
		}
		else if (Label4.Contains("SM-A115U"))
		{
			NameFile4G = "tmp\\4g\\A Famley\\Galaxy A11 SM-A115U-U1.xml";
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Galaxy A11 SM-A115U-U1");
		}
		else if (Label4.Contains("SM-A115A"))
		{
			NameFile4G = "tmp\\4g\\A Famley\\Galaxy A11 SM-A115AP.xml";
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Galaxy A11 SM-A115A-AP");
		}
		else if (Label4.Contains("SM-A115DL"))
		{
			NameFile4G = "tmp\\4g\\A Famley\\Galaxy A11 SM-S115DL.xml";
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Galaxy A11 SM-A115DL");
		}
		else if (Label4.Contains("SM-A426U"))
		{
			NameFile4G = "tmp\\4g\\A Famley\\Galaxy A42 5G SM-A426U.xml";
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Galaxy A42 5G");
		}
		else if (Label4.Contains("SM-J327V"))
		{
			NameFile4G = "tmp\\4g\\A Famley\\Galaxy J3 Eclipse SM-J327VVPP.xml";
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Galaxy J3 Eclipse");
		}
		else if (Label4.Contains("SM-J3119"))
		{
			NameFile4G = "tmp\\4g\\A Famley\\Galaxy J3 Pro SM-J3119.xml";
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Galaxy J3 Pro");
		}
		else if (Label4.Contains("SM-J727V"))
		{
			NameFile4G = "tmp\\4g\\A Famley\\Galaxy J7 SM-J727VVPP.xml";
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Galaxy J7");
		}
		else if (Label4.Contains("SM-N975V"))
		{
			NameFile4G = "tmp\\4g\\A Famley\\Galaxy Note 10+ 5G SM-N975V.xml";
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Galaxy Note 10+ 5G");
		}
		else if (Label4.Contains("SM-G977U"))
		{
			NameFile4G = "tmp\\4g\\A Famley\\Galaxy S10 5G SM-G977U.xml";
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Galaxy S10 5G");
		}
		else if (Label4.Contains("SM-G781U"))
		{
			NameFile4G = "tmp\\4g\\A Famley\\Galaxy S20 FE 5G SM-G781U.xml";
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Galaxy S20 FE 5G");
		}
		else if (Label4.Contains("SM-G986U"))
		{
			NameFile4G = "tmp\\4g\\A Famley\\Galaxy S20+ 5G SM-G986U.xml";
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Galaxy S20+ 5G");
		}
		else if (Label4.Contains("SM-G990U"))
		{
			NameFile4G = "tmp\\4g\\A Famley\\Galaxy S21 FE 5G SM-G990U.xml";
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Galaxy S21 FE 5G");
		}
		else if (Label4.Contains("SM-G996U"))
		{
			NameFile4G = "tmp\\4g\\A Famley\\Galaxy S21+ 5G SM-G996U.xml";
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Galaxy S21+ 5G");
		}
		else if (Label4.Contains("SM-F711U"))
		{
			NameFile4G = "tmp\\4g\\A Famley\\Galaxy Z Flip 3 5G SM-F711U.xml";
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Galaxy Z Flip 3 5G");
		}
		else if (Label4.Contains("SM-F707U"))
		{
			NameFile4G = "tmp\\4g\\A Famley\\Galaxy Z Flip 5G SM-F707U.xml";
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Galaxy Z Flip 5G");
		}
		else if (Label4.Contains("SM-F900U"))
		{
			NameFile4G = "tmp\\4g\\A Famley\\Galaxy Z Fold 5G SM-F900U.xml";
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Galaxy Z Fold 5G");
		}
		else if (Label4.Contains("Redmi 9T"))
		{
			NameFile4G = "tmp\\4g\\A Famley\\Redmi 9T.xml";
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Redmi 9T");
		}
		else if (Label4.Contains("Redmi K30"))
		{
			NameFile4G = "tmp\\4g\\A Famley\\Redmi K30.xml";
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Redmi K30");
		}
		else if (Label4.Contains("Redmi Note 7"))
		{
			NameFile4G = "tmp\\4g\\A Famley\\Redmi Note 7.xml";
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Redmi Note 7");
		}
		else if (Label4.Contains("Redmi Note 8"))
		{
			NameFile4G = "tmp\\4g\\A Famley\\Redmi Note 8.xml";
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Redmi Note 8");
		}
		else if (Label4.Contains("Redmi Note 9 5G"))
		{
			NameFile4G = "tmp\\4g\\A Famley\\Redmi Note 9 5G.xml";
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Redmi Note 9 5G");
		}
		else if (Label4.Contains("Redmi Note 9 PRO"))
		{
			NameFile4G = "tmp\\4g\\A Famley\\Redmi Note 9 PRO.xml";
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Redmi Note 9 PRO");
		}
		else if (Label4.Contains("Redmi Note 11E"))
		{
			NameFile4G = "tmp\\4g\\A Famley\\Redmi Note 11E.xml";
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Redmi Note 11E");
		}
		else if (Label15.Contains("VIVO"))
		{
			NameFile4G = "tmp\\4g\\A Famley\\VIVO ALL MODELS [Method 1].xml";
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText(Label4);
		}
		else if (Label15.Contains("Motorola"))
		{
			NameFile4G = "tmp\\4g\\A Famley\\Motorola 4G LTE [Method 1].xml";
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText(Label4);
		}
		else if (Label15.Contains("Huawei") | Label15.Contains("Honor"))
		{
			NameFile4G = "tmp\\4g\\A Famley\\ALL Huawei - Honor [Method 1].xml";
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText(Label4);
		}
		else if (Label4.Contains("SM-N920"))
		{
			NameFile4G = "tmp\\4g\\NOT5\\carrier_policy.xml";
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Galaxy Note5");
		}
		else if (Label4.Contains("SM-G925"))
		{
			NameFile4G = "tmp\\4g\\4G S6 Edge VZW\\carrier_policy.xml";
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Galaxy S6 Edge");
		}
		else if (Label4.Contains("SM-G930"))
		{
			NameFile4G = "tmp\\4g\\S8\\carrier_policy.xml";
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Galaxy S7");
		}
		else if (Label4.Contains("SM-G935"))
		{
			NameFile4G = "tmp\\4g\\S8\\carrier_policy.xml";
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Galaxy S7 Edge");
		}
		else if (Label4.Contains("SM-G950"))
		{
			NameFile4G = "tmp\\4g\\S8\\carrier_policy.xml";
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Galaxy S8");
		}
		else if (Label4.Contains("SM-G955"))
		{
			NameFile4G = "tmp\\4g\\S8+\\carrier_policy.xml";
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Galaxy S8+");
		}
		else if (Label4.Contains("SM-N950"))
		{
			NameFile4G = "tmp\\4g\\Samsung Note 8\\carrier_policy.xml";
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Galaxy Note8");
		}
		else if (Label4.Contains("SM-G960"))
		{
			NameFile4G = "tmp\\4g\\Galaxy S9 & Galaxy 9+\\carrier_policy.xml";
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Galaxy S9");
		}
		else if (Label4.Contains("SM-G965"))
		{
			NameFile4G = "tmp\\4g\\Galaxy S9 & Galaxy 9+\\carrier_policy.xml";
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Galaxy S9+");
		}
		else if (Label4.Contains("SM-N960"))
		{
			NameFile4G = "tmp\\4g\\Samasung Note 9\\carrier_policy.xml";
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Galaxy Note9");
		}
		else if (Label4.Contains("SM-G973") | Label4.Contains("SM-G970"))
		{
			NameFile4G = "tmp\\4g\\Galaxy S10 & Galaxy 10+\\carrier_policy.xml";
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Galaxy S10");
		}
		else if (Label4.Contains("SM-G975"))
		{
			NameFile4G = "tmp\\4g\\Galaxy S10 & Galaxy 10+\\carrier_policy.xml";
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Galaxy S10+");
		}
		else if (Label4.Contains("SM-N970"))
		{
			NameFile4G = "tmp\\4g\\Samsung Note 10 & 10+\\carrier_policy.xml";
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Galaxy Note10");
		}
		else if (Label4.Contains("SM-N975"))
		{
			NameFile4G = "tmp\\4g\\Samsung Note 10 & 10+\\carrier_policy.xml";
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Galaxy Note10+");
		}
		else if (Label4.Contains("SM-G980"))
		{
			NameFile4G = "tmp\\4g\\Galaxy S20 & Galaxy S20+\\carrier_policy.xml";
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Galaxy S20");
		}
		else if (Label4.Contains("SM-G985"))
		{
			NameFile4G = "tmp\\4g\\Galaxy S20 & Galaxy S20+\\carrier_policy.xml";
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Galaxy S20+");
		}
		else if (Label4.Contains("SM-G988"))
		{
			NameFile4G = "tmp\\4g\\Galaxy S20-s21 Ultra\\carrier_policy.xml";
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Galaxy S20 Ultra");
		}
		else if (Label4.Contains("SM-N981"))
		{
			NameFile4G = "tmp\\4g\\NOTE20 ULTRA 5G\\carrier_policy.xml";
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Galaxy Note20 5G");
		}
		else if (Label4.Contains("SM-N986"))
		{
			NameFile4G = "tmp\\4g\\NOTE20 ULTRA 5G\\carrier_policy.xml";
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Galaxy Note20 Ultra 5G");
		}
		else if (Label4.Contains("SM-F916"))
		{
			NameFile4G = "tmp\\4g\\z fold2\\carrier_policy.xml";
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Galaxy Z Fold 2");
		}
		else if (Label4.Contains("SM-F926"))
		{
			NameFile4G = "tmp\\4g\\z flod 3\\carrier_policy.xml";
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Galaxy Z Fold 3");
		}
		else if (Label4.Contains("SM-F700"))
		{
			NameFile4G = "tmp\\4g\\z flip 4g\\carrier_policy.xml";
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Galaxy Z Flip 4G");
		}
		else if (Label4.Contains("SM-N9500"))
		{
			NameFile4G = "tmp\\4g\\N9500\\carrier_policy.xml";
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Galaxy N9500");
		}
		else if (Label4.Contains("SM-A9200"))
		{
			NameFile4G = "tmp\\4g\\A9200 2 SIM CHINA\\carrier_policy.xml";
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Galaxy A9200");
		}
		else if (Label15.Contains("LGE"))
		{
			NameFile4G = "tmp\\4g\\LG ALL\\Method 1.xml";
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText(Label4);
		}
		else if (Label15.Contains("LT"))
		{
			NameFile4G = "tmp\\4g\\4G LT Carrier\\carrier_policy.xml";
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText(Label4);
		}
		else if (Label4.Contains("M765G"))
		{
			NameFile4G = "tmp\\4g\\N5 M765G\\carrier_policy.xml";
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("N5 M765G");
		}
		else if (Label4.Contains("N100"))
		{
			NameFile4G = "tmp\\4g\\N100\\carrier_policy.xml";
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("OnePlus6 N100");
		}
		else if (Label4.Contains("V2027"))
		{
			NameFile4G = "tmp\\4g\\VIVOV2027\\Method 1.xml";
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("VIVO V2027");
		}
		else if (Label4.Contains("N9560U"))
		{
			NameFile4G = "tmp\\4g\\ZTE N9560U\\Method 2.xml";
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("ZTE N9560U");
		}
		else
		{
			NameFile4G = null;
		}
	}

	public void method_auot4gQC()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Analyze Device Port : ");
		Form1.SharedUI.ProgressBar1.Text = "Analyzeing..";
		if (Guna2ComboBox1.Text.Contains("USB Serial Port") | Guna2ComboBox1.Text.Contains("HS-USB") | Guna2ComboBox1.Text.Contains("Diagnostics"))
		{
			Name_Com = checked(Guna2ComboBox1.Text.Substring(Guna2ComboBox1.Text.IndexOf("(") + 1, Guna2ComboBox1.Text.Length - 2 - Guna2ComboBox1.Text.IndexOf("("))).Replace(")", "");
			cdmaTerm.Connect(Name_Com);
			if (!cdmaTerm.portIsOpen)
			{
				cdmaTerm.Disconnect();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
				Form1.SharedUI.RichTextBox1.AppendText("Port Opening Failed");
				finshonly();
			}
			else if (cdmaTerm.portIsOpen)
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Connected");
				Info();
				if (Operators.CompareString(Method, "no", TextCompare: false) == 0)
				{
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
					Form1.SharedUI.RichTextBox1.AppendText("Port Opening Failed, Please Select Other Port");
					Form1.SharedUI.RichTextBox1.Update();
					cdmaTerm.Disconnect();
					finshonly();
				}
				else
				{
					Method = "";
					SPC_PWD3();
					auot4gQC();
					cdmaTerm.Disconnect();
				}
			}
		}
		else
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText("Port Not Found");
			finshonly();
		}
	}

	public static string ToHex(string input)
	{
		StringBuilder stringBuilder = new StringBuilder();
		int num = checked(input.Length - 1);
		for (int i = 0; i <= num; i = checked(i + 1))
		{
			char c = input[i];
			stringBuilder.AppendFormat("0x{0:X2} ", (int)c);
		}
		return stringBuilder.ToString().Trim();
	}

	public static void Write(string file)
	{
		checked
		{
			try
			{
				List<string> list = new List<string>
				{
					"00", "02", "04", "06", "08", "0A", "0C", "0E", "10", "12",
					"14", "16", "18", "1A", "1C", "1E", "20", "22", "24", "26",
					"28", "2A", "2C", "2E", "30", "32", "34", "36", "38", "3A",
					"3C", "3E", "40", "42", "44", "46", "48", "4A", "4C", "4E",
					"50", "5A", "5C", "5E", "60", "6A", "6C", "6E", "70", "72",
					"74", "76", "78", "7A", "7C", "7E", "80", "82", "84", "86",
					"88", "8A", "8C", "8E", "90", "92", "94", "96", "98", "9A",
					"9C", "9E", "A0", "A2", "A4", "A6", "A8", "AA", "AC", "AE",
					"B0", "B2", "B4", "B6", "B8", "BA", "BC", "BE", "C0", "C2",
					"C4", "C6", "C8", "CA", "CC", "CE", "D0", "C2", "C4", "C6",
					"C8", "CA", "CC", "CE", "D0", "D2", "D4", "D6", "D8", "DA",
					"DC", "DE", "E0", "E2", "E4", "E6", "E8", "EA", "EC", "EE",
					"F0", "F2", "F4", "F6", "F8", "FA", "FC", "FE"
				};
				Form1.SharedUI.ProgressBar4.Value = 0;
				int num = 0;
				do
				{
					cdmaTerm.SendTerminalCommand("4B 13 08 00 70 6F 6C 69 63 79 6D 61 6E 2F 63 61 72 72 69 65 72 5F 70 6F 6C 69 63 79 2E 78 6D 6C 00 F4 BA 7E", false);
					cdmaTerm.SendTerminalCommand("4b0801000000e09e7e", false);
					cdmaTerm.SendTerminalCommand("4b13020041020000b60100002f2f706f6c6963796d616e2f636172726965725f706f6c6963792e786d6c00aec07e", false);
					List<string> list2 = new List<string>();
					string text = ToHex(file).Replace("0x", "").Replace(" ", "");
					StringBuilder stringBuilder = new StringBuilder();
					int num2 = text.Length - 1;
					for (int i = 0; i <= num2; i++)
					{
						if (unchecked(i % 1024) == 0)
						{
							stringBuilder.Append('@');
						}
						stringBuilder.Append(text[i]);
					}
					string[] array = stringBuilder.ToString().Split('@');
					foreach (string text2 in array)
					{
						if (Operators.CompareString(text2, string.Empty, TextCompare: false) != 0)
						{
							list2.Add(text2);
						}
					}
					Form1.SharedUI.ProgressBar4.Maximum = list2.Count;
					int num3 = list2.Count + 1;
					for (int k = 0; k <= num3; k++)
					{
						cdmaTerm.SendTerminalCommand("4b1305000000000000" + list[k].ToString() + "0000" + list2[k].ToString() + "\n", true);
						Form1.SharedUI.ProgressBar4.Value++;
					}
					cdmaTerm.SendTerminalCommand("4b130f002f2f706f6c6963796d616e2f636172726965725f706f6c6963792e786d6c006c527e", false);
					cdmaTerm.SendTerminalCommand("4b 13 03 00 00 00 00 00 34 50 7e", true);
					cdmaTerm.SendTerminalCommand("4b 13 03 00 00 00 00 00 34 50 7e", false);
					cdmaTerm.SendTerminalCommand("4b1303000000000034507e", false);
					cdmaTerm.SendTerminalCommand("4b130f002f2f706f6c6963796d616e2f636172726965725f706f6c6963792e786d6c006c527e", false);
					cdmaTerm.SendTerminalCommand("4b130f002f2f706f6c6963796d616e2f636172726965725f706f6c6963792e786d6c006c527e", false);
					cdmaTerm.SendTerminalCommand("4b 13 03 00 00 00 00 00 34 50 7e", true);
					cdmaTerm.SendTerminalCommand("4b 13 03 00 00 00 00 00 34 50 7e", false);
					num++;
				}
				while (num <= 2);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			cdmaTerm.SendTerminalCommand("4b1303000000000034507e", false);
			cdmaTerm.SendTerminalCommand("4b130f002f2f706f6c6963796d616e2f636172726965725f706f6c6963792e786d6c006c527e", false);
			cdmaTerm.SendTerminalCommand("4b130f002f2f706f6c6963796d616e2f636172726965725f706f6c6963792e786d6c006c527e", false);
			cdmaTerm.SendTerminalCommand("4b 13 03 00 00 00 00 00 34 50 7e", true);
			cdmaTerm.SendTerminalCommand("4b 13 03 00 00 00 00 00 34 50 7e", false);
		}
	}

	public string Read()
	{
		RichTextBox1.Clear();
		List<string> list = new List<string>();
		checked
		{
			try
			{
				List<string> list2 = new List<string>
				{
					"00", "02", "04", "06", "08", "0A", "0C", "0E", "10", "12",
					"14", "16", "18", "1A", "1C", "1E", "20", "22", "24", "26",
					"28", "2A", "2C", "2E", "30", "32", "34", "36", "38", "3A",
					"3C", "3E", "40", "42", "44", "46", "48", "4A", "4C", "4E",
					"50", "5A", "5C", "5E", "60", "6A", "6C", "6E", "70", "72",
					"74", "76", "78", "7A", "7C", "7E", "80", "82", "84", "86",
					"88", "8A", "8C", "8E", "90", "92", "94", "96", "98", "9A",
					"9C", "9E", "A0", "A2", "A4", "A6", "A8", "AA", "AC", "AE",
					"B0", "B2", "B4", "B6", "B8", "BA", "BC", "BE", "C0", "C2",
					"C4", "C6", "C8", "CA", "CC", "CE", "D0", "C2", "C4", "C6",
					"C8", "CA", "CC", "CE", "D0", "D2", "D4", "D6", "D8", "DA",
					"DC", "DE", "E0", "E2", "E4", "E6", "E8", "EA", "EC", "EE",
					"F0", "F2", "F4", "F6", "F8", "FA", "FC", "FE"
				};
				cdmaTerm.SendTerminalCommand("4b 09 0a 00 00 00 b1 55 7e", false);
				cdmaTerm.SendTerminalCommand("4b 09 0a 00 00 05 02 85 09 7e", false);
				cdmaTerm.SendTerminalCommand("4b 08 01 00 00 00 e0 9e 7e", false);
				cdmaTerm.SendTerminalCommand("4b 08 01 00 08 3a 85 05 02 28 16 43 95 00 00 00 00 00 00 00 00 00 00 00 00 01 00 06 06 00 05 02 0d 0f 7e", false);
				cdmaTerm.SendTerminalCommand("4b 13 02 00 00 00 00 00 24 01 00 00 2f 2f 70 6f 6c 69 63 79 6d 61 6e 2f 63 61 72 72 69 65 72 5f 70 6f 6c 69 63 79 2e 78 6d 6c 00 77 98 7e", false);
				cdmaTerm.SendTerminalCommand("4b 13 02 00 00 00 00 00 00 00 00 00 04 6d 7e", false);
				int num = list2.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					cdmaTerm.SendTerminalCommand("4b130400000000000002000000" + list2[i].ToString() + "0000", true);
					string[] array = cdmaTerm.thePhone.LogData.Replace("RX:", "@").Replace("RX(", "@").Replace("\r\n", "")
						.Replace(" ", "")
						.Split('@');
					string text = array[1].ToString().Substring(40, array[1].Length - 46);
					string obj = FromHex(text.Replace(" ", "").Replace("\r\n", ""));
					if (obj != null)
					{
						list.Add(FromHex(text.Replace(" ", "").Replace("\r\n", "")));
					}
					if (obj.Contains("</policy>"))
					{
						break;
					}
				}
				_ = list.Count;
				int count = list.Count;
				for (int j = 0; j <= count; j++)
				{
					RichTextBox1.AppendText(list[j]);
				}
				cdmaTerm.SendTerminalCommand("4b 13 03 00 00 00 00 00 34 50 7e", false);
				cdmaTerm.SendTerminalCommand("4b 13 03 00 00 00 00 00 34 50 7e", false);
				cdmaTerm.SendTerminalCommand("4b 13 03 00 00 00 00 00 34 50 7e", false);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			string result = RichTextBox1.Text;
			cdmaTerm.SendTerminalCommand("4b 13 03 00 00 00 00 00 34 50 7e", false);
			cdmaTerm.SendTerminalCommand("4b 13 03 00 00 00 00 00 34 50 7e", true);
			cdmaTerm.SendTerminalCommand("4b 13 03 00 00 00 00 00 34 50 7e", false);
			return result;
		}
	}

	public bool dump_files()
	{
		bool result;
		try
		{
			namefile = "4G.zip";
			tmpWinrarr = "4G";
			string directory = ThisLocation + "tmp\\4G";
			try
			{
				MyProject.Computer.FileSystem.DeleteDirectory(directory, DeleteDirectoryOption.DeleteAllContents);
				File.Delete(ThisLocation + "tmp\\4G.zip");
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			directory = ThisLocation + "tmp\\4G";
			try
			{
				MyProject.Computer.FileSystem.DeleteDirectory(directory, DeleteDirectoryOption.DeleteAllContents);
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ProjectData.ClearProjectError();
			}
			File.WriteAllBytes(ThisLocation + "tmp\\4G.zip", Resources._4G);
			runExFB(("bin\\7z.exe x tmp\\" + namefile + " -p4G4G -otmp\\" + tmpWinrarr) ?? "");
			Form1.SharedUI.RichTextBox1.Update();
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("OK");
			Form1.SharedUI.RichTextBox1.Update();
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Select Model From Server : ");
			Form1.SharedUI.ProgressBar1.Text = "Select Model..";
			Form1.SharedUI.RichTextBox1.Update();
			carrierNEAM();
			if (Operators.CompareString(NameFile4G, null, TextCompare: false) == 0)
			{
				Guna2Button6.Enabled = false;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
				Form1.SharedUI.RichTextBox1.AppendText("Not Supported");
				Form1.SharedUI.RichTextBox1.Update();
				finshonly();
				result = false;
			}
			else
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Enable Bands (All) : ");
				Form1.SharedUI.ProgressBar1.Text = "Enable Bands..";
				Form1.SharedUI.RichTextBox1.Update();
				if (new FileInfo(ThisLocation + NameFile4G).Exists)
				{
					string text = File.ReadAllText(ThisLocation + NameFile4G);
					Carrierbox.AppendText(text);
				}
				if (Operators.CompareString(Carrierbox.Text, "", TextCompare: false) == 0)
				{
					Form1.SharedUI.RichTextBox1.Update();
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
					Form1.SharedUI.RichTextBox1.AppendText("Failed");
					cdmaTerm.Disconnect();
					finshonly();
					result = false;
				}
				else
				{
					directory = ThisLocation + "tmp\\4G";
					try
					{
						MyProject.Computer.FileSystem.DeleteDirectory(directory, DeleteDirectoryOption.DeleteAllContents);
						File.Delete(ThisLocation + "tmp\\4G.zip");
					}
					catch (Exception ex5)
					{
						ProjectData.SetProjectError(ex5);
						Exception ex6 = ex5;
						ProjectData.ClearProjectError();
					}
					directory = ThisLocation + "tmp\\4G";
					try
					{
						MyProject.Computer.FileSystem.DeleteDirectory(directory, DeleteDirectoryOption.DeleteAllContents);
					}
					catch (Exception ex7)
					{
						ProjectData.SetProjectError(ex7);
						Exception ex8 = ex7;
						ProjectData.ClearProjectError();
					}
					result = true;
				}
			}
		}
		catch (Exception ex9)
		{
			ProjectData.SetProjectError(ex9);
			Exception ex10 = ex9;
			result = false;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private void auot4gQC()
	{
		NameFile4G = null;
		Carrierbox.Clear();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Get Model From Server : ");
		Form1.SharedUI.ProgressBar1.Text = "Getting Data..";
		if (dump_files() && Carrierbox.Text.Contains("</policy>"))
		{
			Write(Carrierbox.Text);
			string text = Read();
			RichTextBox1.Clear();
			RichTextBox1.AppendText(text);
			cdmaTerm.SendTerminalCommand("4b1303000000000034507e", false);
			cdmaTerm.SendTerminalCommand("4b130f002f2f706f6c6963796d616e2f636172726965725f706f6c6963792e786d6c006c527e", false);
			cdmaTerm.SendTerminalCommand("4b130f002f2f706f6c6963796d616e2f636172726965725f706f6c6963792e786d6c006c527e", false);
			cdmaTerm.SendTerminalCommand("4b 13 03 00 00 00 00 00 34 50 7e", true);
			cdmaTerm.SendTerminalCommand("4b 13 03 00 00 00 00 00 34 50 7e", false);
			method_enablebend();
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Write 4G LTE Config : ");
			Form1.SharedUI.ProgressBar1.Text = "Writeing..";
			if (Operators.CompareString(RichTextBox1.Text, Carrierbox.Text, TextCompare: false) == 0)
			{
				Form1.SharedUI.RichTextBox1.Update();
				method_Setlie2();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("OK");
				method_re();
				cdmaTerm.Disconnect();
				finsh();
			}
			else
			{
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
				Form1.SharedUI.RichTextBox1.AppendText("Failed");
				cdmaTerm.Disconnect();
				finshonly();
			}
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

	public static string betweenStrings(string text, string start, string end)
	{
		if (!text.Contains(start))
		{
			return null;
		}
		if (!text.Contains(end))
		{
			return null;
		}
		checked
		{
			int num = text.IndexOf(start) + start.Length;
			int num2 = text.IndexOf(end, num);
			if (Operators.CompareString(end, "", TextCompare: false) == 0)
			{
				return text.Substring(num);
			}
			return text.Substring(num, num2 - num);
		}
	}

	private string ATSendEx(SerialPort ATPort, string command, int timeout = 3000)
	{
		if (!ATPort.IsOpen)
		{
			return null;
		}
		ATPort.WriteLine(command);
		string text = "";
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		do
		{
			Thread.Sleep(50);
			if (!ATPort.IsOpen)
			{
				break;
			}
			text = ATPort.ReadExisting();
		}
		while (!text.Contains("\nOK") && !text.Contains("\nERROR") && stopwatch.ElapsedMilliseconds <= timeout);
		Console.WriteLine(text);
		return text;
	}

	public void modem()
	{
		foreach (ManagementObject item in new ManagementObjectSearcher("SELECT * FROM Win32_POTSModem").Get())
		{
			if (Operators.CompareString(Conversions.ToString(item["Status"]), "OK", TextCompare: false) == 0)
			{
				Guna2ComboBox1.Items.Add(Operators.AddObject(Operators.AddObject(item["Description"], " ("), Convert.ToString(Operators.AddObject(item["AttachedTo"], ")"))));
				Guna2ComboBox1.Text = Conversions.ToString(Operators.AddObject(Operators.AddObject(item["Description"], " ("), Convert.ToString(Operators.AddObject(item["AttachedTo"], ")"))));
				Guna2ComboBox1.Update();
				Guna2ComboBox1.Refresh();
				string value = Conversions.ToString(Guna2ComboBox1.FindString("SAMSUNG Mobile USB Modem"));
				if (!Guna2ComboBox1.Text.Contains("SAMSUNG Mobile USB Modem"))
				{
					Guna2ComboBox1.SelectedIndex = Conversions.ToInteger(value);
				}
				if (Guna2ComboBox1.Text.Contains("SAMSUNG Mobile USB Modem"))
				{
					TextBox4.Text = checked(Guna2ComboBox1.Text.Substring(Guna2ComboBox1.Text.IndexOf("(") + 1, Guna2ComboBox1.Text.Length - 2 - Guna2ComboBox1.Text.IndexOf("("))).Replace(")", "");
				}
			}
		}
	}

	private string ACTIVATE_A12TRY()
	{
		cdmaTerm.Disconnect();
		string result;
		string text2 = default(string);
		using (SerialPort serialPort = new SerialPort(Name_Com))
		{
			serialPort.RtsEnable = true;
			serialPort.DtrEnable = true;
			serialPort.WriteBufferSize = serialPort.BaudRate;
			try
			{
				serialPort.Open();
			}
			catch (UnauthorizedAccessException ex)
			{
				ProjectData.SetProjectError(ex);
				UnauthorizedAccessException ex2 = ex;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
				Form1.SharedUI.RichTextBox1.AppendText(ex2.Message);
				result = null;
				ProjectData.ClearProjectError();
				goto end_IL_0011;
			}
			string text = ATSendEx(serialPort, "AT+ACTIVATE=0,0,0", 7000);
			if (text == null || text.Contains("\nERROR") || !text.Contains("OK"))
			{
				text2 = null;
				compareOkNotString = "NO";
				serialPort.Close();
			}
			else
			{
				compareOkNotString = null;
				serialPort.Close();
				Form1.SharedUI.ProgressBar1.Text = "Try Checking Security..";
				Thread.Sleep(50);
				Thread.Sleep(50);
				Thread.Sleep(50);
				Thread.Sleep(1500);
				Form1.SharedUI.ProgressBar1.Text = "Try Checking Security...";
				Thread.Sleep(1500);
				cdmaTerm.Connect(Name_Com);
				cdmaTerm.SendAtCommand("AT+SWATD=1");
				Thread.Sleep(1500);
				cdmaTerm.SendAtCommand("AT+FACTORST=0,2");
				Thread.Sleep(1500);
			}
			goto IL_0155;
			end_IL_0011:;
		}
		goto IL_0157;
		IL_0155:
		result = text2;
		goto IL_0157;
		IL_0157:
		return result;
	}

	private string ACTIVATE_A12()
	{
		cdmaTerm.Disconnect();
		string result;
		string text2 = default(string);
		using (SerialPort serialPort = new SerialPort(Name_Com))
		{
			serialPort.RtsEnable = true;
			serialPort.DtrEnable = true;
			serialPort.WriteBufferSize = serialPort.BaudRate;
			try
			{
				serialPort.Open();
			}
			catch (UnauthorizedAccessException ex)
			{
				ProjectData.SetProjectError(ex);
				UnauthorizedAccessException ex2 = ex;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
				Form1.SharedUI.RichTextBox1.AppendText(ex2.Message);
				result = null;
				ProjectData.ClearProjectError();
				goto end_IL_0011;
			}
			string text = ATSendEx(serialPort, "AT+ACTIVATE=0,0,0", 7000);
			if (text == null || text.Contains("\nERROR") || !text.Contains("OK"))
			{
				text2 = null;
				compareOkNotString = "NO";
				serialPort.Close();
			}
			else
			{
				compareOkNotString = null;
				serialPort.Close();
				Form1.SharedUI.ProgressBar1.Text = "Checking Security..";
				Thread.Sleep(50);
				Thread.Sleep(50);
				Thread.Sleep(50);
				Thread.Sleep(1500);
				Form1.SharedUI.ProgressBar1.Text = "Checking Security...";
				Thread.Sleep(1500);
				cdmaTerm.Connect(Name_Com);
				cdmaTerm.SendAtCommand("AT+SWATD=1");
				Thread.Sleep(1500);
				cdmaTerm.SendAtCommand("AT+FACTORST=0,2");
				Thread.Sleep(1500);
			}
			goto IL_0155;
			end_IL_0011:;
		}
		goto IL_0157;
		IL_0155:
		result = text2;
		goto IL_0157;
		IL_0157:
		return result;
	}

	public void auot4gEX()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Open Radio Info Main : ");
		Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + serialno.Text + " shell am start -n com.android.settings/com.android.settings.RadioInfo", new object[0]), false);
		Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + serialno.Text + " shell am start -n com.android.settings/.RadioInfo", new object[0]), false);
		Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + serialno.Text + " shell am start -n com.android.phone/.settings.RadioInfo", new object[0]), false);
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("OK");
		if (Operators.CompareString(cancel, "Cancel", TextCompare: false) == 0)
		{
			Form1.SharedUI.ProgressBar1.Text = "100%";
			return;
		}
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Analyze Device Port : ");
		Form1.SharedUI.ProgressBar1.Text = "Search.";
		wronganswer_wave();
		MyProject.Forms.Dialog2.ShowDialog();
		Guna2ComboBox1.Items.Clear();
		TextBox4.Clear();
		while (true)
		{
			if (TextBox4.Text.Contains("COM"))
			{
				Form1.SharedUI.ProgressBar1.Text = "Getting Auth..";
				break;
			}
			if (Operators.CompareString(cancel, "Cancel", TextCompare: false) == 0)
			{
				Form1.SharedUI.ProgressBar1.Text = "100%";
				break;
			}
			Thread.Sleep(50);
			Form1.SharedUI.ProgressBar1.Text = "Search..";
			Thread.Sleep(50);
			Form1.SharedUI.ProgressBar1.Text = "Search...";
			Thread.Sleep(50);
			Form1.SharedUI.ProgressBar1.Text = "Search....";
			Guna2ComboBox1.Items.Clear();
			TextBox4.Clear();
			modem();
			Thread.Sleep(50);
			Form1.SharedUI.ProgressBar1.Text = "Search.....";
		}
		if (Operators.CompareString(cancel, "Cancel", TextCompare: false) == 0)
		{
			Form1.SharedUI.ProgressBar1.Text = "100%";
			return;
		}
		compareOkNotString = "";
		Name_Com = TextBox4.Text;
		cdmaTerm.Connect(Name_Com);
		Form1.SharedUI.ProgressBar1.Text = "Wiating..";
		if (!cdmaTerm.portIsOpen)
		{
			cdmaTerm.Disconnect();
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText("Failed");
			finshonly();
			return;
		}
		if (cdmaTerm.portIsOpen)
		{
			if (Operators.CompareString(Label9, "11", TextCompare: false) == 0)
			{
				Form1.SharedUI.ProgressBar1.Text = "Checking Security..";
				cdmaTerm.Disconnect();
				SerialPort1.Close();
				SerialPort1.PortName = Name_Com;
				SerialPort1.BaudRate = Convert.ToInt32("115200");
				SerialPort1.BaudRate = Convert.ToInt32("57600");
				SerialPort1.BaudRate = Convert.ToInt32("38400");
				SerialPort1.BaudRate = Convert.ToInt32("19200");
				SerialPort1.BaudRate = Convert.ToInt32("9600");
				SerialPort1.BaudRate = Convert.ToInt32("1200");
				SerialPort1.StopBits = (StopBits)Conversions.ToInteger(Enum.Parse(typeof(StopBits), "One"));
				SerialPort1.Parity = (Parity)Conversions.ToInteger(Enum.Parse(typeof(Parity), "None"));
				SerialPort1.Open();
				try
				{
					SerialPort1.WriteLine("AT+SWATD=0");
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
				Thread.Sleep(500);
				Thread.Sleep(50);
				Thread.Sleep(50);
				try
				{
					SerialPort1.WriteLine("AT+ACTIVATE=0,0,0");
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					ProjectData.ClearProjectError();
				}
				Thread.Sleep(50);
				Thread.Sleep(50);
				Thread.Sleep(50);
				Thread.Sleep(3000);
				Form1.SharedUI.ProgressBar1.Text = "Checking Security...";
				Thread.Sleep(1500);
				try
				{
					SerialPort1.WriteLine("AT+SWATD=1");
				}
				catch (Exception ex5)
				{
					ProjectData.SetProjectError(ex5);
					Exception ex6 = ex5;
					ProjectData.ClearProjectError();
				}
				Thread.Sleep(1000);
				try
				{
					SerialPort1.WriteLine("AT+FACTORST=0,2");
				}
				catch (Exception ex7)
				{
					ProjectData.SetProjectError(ex7);
					Exception ex8 = ex7;
					ProjectData.ClearProjectError();
				}
				Thread.Sleep(1000);
				SerialPort1.Close();
			}
			else
			{
				Form1.SharedUI.ProgressBar1.Text = "Wiating..";
				try
				{
					cdmaTerm.SendAtCommand("AT+SWATD=0");
				}
				catch (Exception ex9)
				{
					ProjectData.SetProjectError(ex9);
					Exception ex10 = ex9;
					ProjectData.ClearProjectError();
				}
				ACTIVATE_A12();
			}
		}
		if (Operators.CompareString(compareOkNotString, "NO", TextCompare: false) == 0)
		{
			cdmaTerm.Connect(Name_Com);
			compareOkNotString = "";
			Form1.SharedUI.ProgressBar1.Text = "Wiating..";
			try
			{
				cdmaTerm.SendAtCommand("AT+SWATD=0");
			}
			catch (Exception ex11)
			{
				ProjectData.SetProjectError(ex11);
				Exception ex12 = ex11;
				ProjectData.ClearProjectError();
			}
			ACTIVATE_A12TRY();
		}
		if (Operators.CompareString(compareOkNotString, "NO", TextCompare: false) == 0)
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText("Failed, Open Home Screen And Try Agine");
			finshonly();
			return;
		}
		cdmaTerm.Connect(Name_Com);
		if (cdmaTerm.portIsOpen)
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("OK");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Get Model From Server : ");
			Form1.SharedUI.RichTextBox1.Update();
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("OK");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Write 4G LTE Config : ");
			Form1.SharedUI.ProgressBar1.Text = "Writeing..";
			Form1.SharedUI.RichTextBox1.Update();
			cdmaTerm.Disconnect();
			SerialPort1.Close();
			SerialPort1.PortName = Name_Com;
			SerialPort1.BaudRate = Convert.ToInt32("115200");
			SerialPort1.BaudRate = Convert.ToInt32("57600");
			SerialPort1.BaudRate = Convert.ToInt32("38400");
			SerialPort1.BaudRate = Convert.ToInt32("19200");
			SerialPort1.BaudRate = Convert.ToInt32("9600");
			SerialPort1.BaudRate = Convert.ToInt32("1200");
			SerialPort1.StopBits = (StopBits)Conversions.ToInteger(Enum.Parse(typeof(StopBits), "One"));
			SerialPort1.Parity = (Parity)Conversions.ToInteger(Enum.Parse(typeof(Parity), "None"));
			SerialPort1.Open();
			try
			{
				SerialPort1.WriteLine("AT%FINAL%IMEI%Certi%Status...");
			}
			catch (Exception ex13)
			{
				ProjectData.SetProjectError(ex13);
				Exception ex14 = ex13;
				ProjectData.ClearProjectError();
			}
			Thread.Sleep(500);
			try
			{
				SerialPort1.WriteLine("AT%Enable%Band%LTE...");
			}
			catch (Exception ex15)
			{
				ProjectData.SetProjectError(ex15);
				Exception ex16 = ex15;
				ProjectData.ClearProjectError();
			}
			Thread.Sleep(500);
			try
			{
				SerialPort1.WriteLine("AT+BANSELCT=2,AUTO");
			}
			catch (Exception ex17)
			{
				ProjectData.SetProjectError(ex17);
				Exception ex18 = ex17;
				ProjectData.ClearProjectError();
			}
			Thread.Sleep(500);
			Form1.SharedUI.ProgressBar1.Text = "Writeing...";
			try
			{
				SerialPort1.WriteLine("AT+BANSELCT=2,LTE3PREF");
			}
			catch (Exception ex19)
			{
				ProjectData.SetProjectError(ex19);
				Exception ex20 = ex19;
				ProjectData.ClearProjectError();
			}
			Thread.Sleep(500);
			try
			{
				SerialPort1.WriteLine("AT+SVCBANDB=2,2,0");
			}
			catch (Exception ex21)
			{
				ProjectData.SetProjectError(ex21);
				Exception ex22 = ex21;
				ProjectData.ClearProjectError();
			}
			Thread.Sleep(500);
			try
			{
				SerialPort1.WriteLine("AT+SVCBANDB=2,1,L03");
			}
			catch (Exception ex23)
			{
				ProjectData.SetProjectError(ex23);
				Exception ex24 = ex23;
				ProjectData.ClearProjectError();
			}
			Thread.Sleep(500);
			Form1.SharedUI.ProgressBar1.Text = "Writeing....";
			try
			{
				SerialPort1.WriteLine("AT+SVCBANDB=2,1,L28");
			}
			catch (Exception ex25)
			{
				ProjectData.SetProjectError(ex25);
				Exception ex26 = ex25;
				ProjectData.ClearProjectError();
			}
			try
			{
				SerialPort1.WriteLine("AT%FINAL%IMEI%Certi%Status...");
			}
			catch (Exception ex27)
			{
				ProjectData.SetProjectError(ex27);
				Exception ex28 = ex27;
				ProjectData.ClearProjectError();
			}
			Thread.Sleep(500);
			try
			{
				SerialPort1.WriteLine("AT%Enable%Band%LTE...");
			}
			catch (Exception ex29)
			{
				ProjectData.SetProjectError(ex29);
				Exception ex30 = ex29;
				ProjectData.ClearProjectError();
			}
			Thread.Sleep(500);
			try
			{
				SerialPort1.WriteLine("AT+BANSELCT=2,AUTO");
			}
			catch (Exception ex31)
			{
				ProjectData.SetProjectError(ex31);
				Exception ex32 = ex31;
				ProjectData.ClearProjectError();
			}
			Thread.Sleep(500);
			Form1.SharedUI.ProgressBar1.Text = "Writeing..";
			try
			{
				SerialPort1.WriteLine("AT+BANSELCT=2,LTE3PREF");
			}
			catch (Exception ex33)
			{
				ProjectData.SetProjectError(ex33);
				Exception ex34 = ex33;
				ProjectData.ClearProjectError();
			}
			Thread.Sleep(500);
			try
			{
				SerialPort1.WriteLine("AT+SVCBANDB=2,2,0");
			}
			catch (Exception ex35)
			{
				ProjectData.SetProjectError(ex35);
				Exception ex36 = ex35;
				ProjectData.ClearProjectError();
			}
			Thread.Sleep(500);
			try
			{
				SerialPort1.WriteLine("AT+SVCBANDB=2,1,L03");
			}
			catch (Exception ex37)
			{
				ProjectData.SetProjectError(ex37);
				Exception ex38 = ex37;
				ProjectData.ClearProjectError();
			}
			Thread.Sleep(500);
			Form1.SharedUI.ProgressBar1.Text = "Writeing...";
			try
			{
				SerialPort1.WriteLine("AT+SVCBANDB=2,1,L28");
			}
			catch (Exception ex39)
			{
				ProjectData.SetProjectError(ex39);
				Exception ex40 = ex39;
				ProjectData.ClearProjectError();
			}
			Thread.Sleep(500);
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("OK");
			Form1.SharedUI.RichTextBox1.Update();
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Reboot Device : ");
			Form1.SharedUI.ProgressBar1.Text = "Rebooting..";
			Form1.SharedUI.RichTextBox1.Update();
			try
			{
				SerialPort1.WriteLine("AT+POWRESET=0,0");
			}
			catch (Exception ex41)
			{
				ProjectData.SetProjectError(ex41);
				Exception ex42 = ex41;
				ProjectData.ClearProjectError();
			}
			Thread.Sleep(500);
			SerialPort1.Close();
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("OK");
			Form1.SharedUI.RichTextBox1.Update();
			Form1.SharedUI.RichTextBox1.Update();
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Note : ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("IF Not Working Try Convert CSC To SPR");
			Form1.SharedUI.RichTextBox1.Update();
			finsh();
		}
	}

	public void VoLteAll()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("Supported");
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Get Data From Server : ");
		Form1.SharedUI.RichTextBox1.Update();
		if (Label9.Contains("11") | Label9.Contains("10") | Label9.Contains("9"))
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("OK");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Open IMS Main From Server : ");
			runExFB(Form1.String_73 + "adb.exe shell settings put global function_key_config_doublepress_value com.samsung.advp.imssettings/com.samsung.advp.imssettings.MainActivity");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("OK");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- 4G APN :\r\n1- Name : ymdata\r\n2- APN : ymdata\r\n\r\n- VoLTE APN :\r\n1- Name : ims\r\n2- APN : ims\r\n3- APN Type : ims\r\n\r\n- xcap APN :\r\n1- Name : xcap\r\n2- APN : xcap\r\n3- APN Type : xcap");
		}
		else
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("OK");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Enable IMS Main By Side Key : ");
			runExFB(Form1.String_73 + "adb.exe shell input keyevent KEYCODE_HOME; settings put secure assistant 'com.samsung.advp.imssettings/com.samsung.advp.imssettings.MainActivity';input keyevent --longpress KEYCODE_HOME;settings put secure assistant 'com.samsung.advp.imssettings/com.samsun.advp.imssettings.MainActivity'");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("OK");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Go To Setting >> Advanced Features >> Side Key >> And Select Open app >>  ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- 4G APN :\r\n1- Name : ymdata\r\n2- APN : ymdata\r\n\r\n- VoLTE APN :\r\n1- Name : ims\r\n2- APN : ims\r\n3- APN Type : ims\r\n\r\n- xcap APN :\r\n1- Name : xcap\r\n2- APN : xcap\r\n3- APN Type : xcap");
		}
		finsh();
	}

	public void Zero_ALL()
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			UseShellExecute = false,
			CreateNoWindow = true,
			FileName = Form1.String_9 + "bin\\Tunlocker Tool.exe",
			Arguments = string_13,
			RedirectStandardInput = true,
			RedirectStandardOutput = true
		};
		process.Start();
		Console.WriteLine(string_13);
		process.StandardInput.WriteLine(string_13);
		process.StandardInput.Flush();
		process.StandardInput.Close();
		process.OutputDataReceived += Zero_ALL_data;
		process.BeginOutputReadLine();
		process.WaitForExit();
	}

	private void Zero_ALL_data(object sender, DataReceivedEventArgs e)
	{
		try
		{
			if ((e.Data ?? string.Empty).Contains("Removed"))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("OK");
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

	public void Zero_ALL_2()
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			UseShellExecute = false,
			CreateNoWindow = true,
			FileName = Form1.String_9 + "bin\\Tunlocker Tool.exe",
			Arguments = string_13,
			RedirectStandardInput = true,
			RedirectStandardOutput = true
		};
		process.Start();
		Console.WriteLine(string_13);
		process.StandardInput.WriteLine(string_13);
		process.StandardInput.Flush();
		process.StandardInput.Close();
		process.OutputDataReceived += Zero_ALL_data_2;
		process.BeginOutputReadLine();
		process.WaitForExit();
	}

	public string ExtractContent(string input)
	{
		string pattern = "'([^']*)'";
		Match match = Regex.Match(input, pattern);
		if (match.Success)
		{
			return match.Groups[1].Value;
		}
		return string.Empty;
	}

	private void Zero_ALL_data_2(object sender, DataReceivedEventArgs e)
	{
		try
		{
			string text = e.Data ?? string.Empty;
			if (text.Contains("Freeware by Uwe Sieber"))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText("Pleses Waiting...");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Creating System Restore Point : ");
			}
			if (text.Contains("removing device"))
			{
				string left = ExtractContent(text);
				if (Operators.CompareString(left, string.Empty, TextCompare: false) != 0)
				{
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
					Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Removeing ");
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
					Form1.SharedUI.RichTextBox1.AppendText(left);
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
					Form1.SharedUI.RichTextBox1.AppendText(" : ");
				}
			}
			if (text.Contains("OK"))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("OK");
			}
			if (text.Contains("Removed 0 devices"))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("OK");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Removeing 0 Devices : ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("OK");
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

	public void method_adb11()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.CTS);
		Form1.SharedUI.ProgressBar1.Text = "Connecting....";
		method_infoadb2();
		if (Operators.CompareString(cancel, "Cancel", TextCompare: false) == 0)
		{
			finshonly();
		}
		else if (Operators.CompareString(TextBox10, "NOT", TextCompare: false) != 0)
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Check If Model Supported : ");
			VoLteAll();
		}
	}

	private void Guna2Button2_Click(object sender, EventArgs e)
	{
		start();
		Carrierbox.Clear();
		saveFileDialog.Filter = "carrier_policy.xml (*.xml)|*.xml";
		saveFileDialog.FileName = "carrier_policy.xml";
		saveFileDialog.FilterIndex = 2;
		saveFileDialog.RestoreDirectory = true;
		if (saveFileDialog.ShowDialog() == DialogResult.OK)
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.CTS);
			Form1.SharedUI.ProgressBar1.Text = "Connecting....";
			ThreadNew = new Thread(method_adb12);
			ThreadNew.Start();
		}
		else
		{
			Form1.SharedUI.RichTextBox1.Clear();
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText("Cancel by User");
			Carrierbox.Clear();
			cdmaTerm.Disconnect();
			finshonly();
		}
	}

	public void method_adb12()
	{
		method_infoadb2();
		if (Operators.CompareString(cancel, "Cancel", TextCompare: false) == 0)
		{
			finshonly();
		}
		else if (Operators.CompareString(TextBox10, "NOT", TextCompare: false) != 0)
		{
			method_Read_carrier_policy();
		}
	}

	public void method_Read_carrier_policy()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Analyze Device Port : ");
		Form1.SharedUI.ProgressBar1.Text = "Analyzeing..";
		if (Guna2ComboBox1.Text.Contains("USB Serial Port") | Guna2ComboBox1.Text.Contains("HS-USB") | Guna2ComboBox1.Text.Contains("Diagnostics"))
		{
			Name_Com = checked(Guna2ComboBox1.Text.Substring(Guna2ComboBox1.Text.IndexOf("(") + 1, Guna2ComboBox1.Text.Length - 2 - Guna2ComboBox1.Text.IndexOf("("))).Replace(")", "");
			cdmaTerm.Connect(Name_Com);
			if (!cdmaTerm.portIsOpen)
			{
				cdmaTerm.Disconnect();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
				Form1.SharedUI.RichTextBox1.AppendText("Port Opening Failed");
				finshonly();
			}
			else if (cdmaTerm.portIsOpen)
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Connected");
				Info();
				if (Operators.CompareString(Method, "no", TextCompare: false) == 0)
				{
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
					Form1.SharedUI.RichTextBox1.AppendText("Port Opening Failed, Please Select Other Port");
					Form1.SharedUI.RichTextBox1.Update();
					cdmaTerm.Disconnect();
					finshonly();
					return;
				}
				Method = "";
				SPC_PWD3();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Reading Data : ");
				Form1.SharedUI.ProgressBar1.Text = "Analyzeing..";
				Carrierbox.AppendText(Read());
				StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("OK");
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Save The File : ");
				Form1.SharedUI.ProgressBar1.Text = "Saveing..";
				Form1.SharedUI.RichTextBox1.Update();
				streamWriter.WriteLine(Carrierbox.Text);
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("OK");
				Form1.SharedUI.RichTextBox1.Update();
				streamWriter.Close();
				Application.DoEvents();
				cdmaTerm.Disconnect();
				finsh();
			}
		}
		else
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText("Port Not Found");
			finshonly();
		}
	}

	private void Guna2Button3_Click(object sender, EventArgs e)
	{
		start();
		Carrierbox.Clear();
		openFileDialog.Title = "Select carrier_policy.xml";
		openFileDialog.FileName = "carrier_policy.xml";
		openFileDialog.Filter = "carrier_policy.xml | *.xml|carrier_policy.xml | *.xml";
		openFileDialog.FilterIndex = 1;
		openFileDialog.RestoreDirectory = true;
		if (openFileDialog.ShowDialog() == DialogResult.OK)
		{
			string left = File.ReadAllText(openFileDialog.FileName.ToString());
			if (Operators.CompareString(left, "", TextCompare: false) != 0)
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.CTS);
				Form1.SharedUI.ProgressBar1.Text = "Connecting....";
				Carrierbox.AppendText(left);
				ThreadNew = new Thread(method_adb13);
				ThreadNew.Start();
			}
			else
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
				Form1.SharedUI.RichTextBox1.AppendText("> Error carrier_policy is Corrupted");
				cdmaTerm.Disconnect();
				finshonly();
			}
		}
		else
		{
			Form1.SharedUI.RichTextBox1.Clear();
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText("Cancel by User");
			cdmaTerm.Disconnect();
			finshonly();
		}
	}

	public void method_adb13()
	{
		method_infoadb2();
		if (Operators.CompareString(cancel, "Cancel", TextCompare: false) == 0)
		{
			finshonly();
		}
		else if (Operators.CompareString(TextBox10, "NOT", TextCompare: false) != 0)
		{
			method_Write_carrier_policy();
		}
	}

	public void method_Write_carrier_policy()
	{
		Carrierboxstring = null;
		Carrierboxcheckstring = null;
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Analyze Device Port : ");
		Form1.SharedUI.ProgressBar1.Text = "Analyzeing..";
		if (Guna2ComboBox1.Text.Contains("USB Serial Port") | Guna2ComboBox1.Text.Contains("HS-USB") | Guna2ComboBox1.Text.Contains("Diagnostics"))
		{
			Name_Com = checked(Guna2ComboBox1.Text.Substring(Guna2ComboBox1.Text.IndexOf("(") + 1, Guna2ComboBox1.Text.Length - 2 - Guna2ComboBox1.Text.IndexOf("("))).Replace(")", "");
			cdmaTerm.Connect(Name_Com);
			if (!cdmaTerm.portIsOpen)
			{
				cdmaTerm.Disconnect();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
				Form1.SharedUI.RichTextBox1.AppendText("Port Opening Failed");
				finshonly();
			}
			else
			{
				if (!cdmaTerm.portIsOpen)
				{
					return;
				}
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Connected");
				Info();
				if (Operators.CompareString(Method, "no", TextCompare: false) == 0)
				{
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
					Form1.SharedUI.RichTextBox1.AppendText("Port Opening Failed, Please Select Other Port");
					Form1.SharedUI.RichTextBox1.Update();
					cdmaTerm.Disconnect();
					finshonly();
					return;
				}
				Method = "";
				SPC_PWD3();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Enable Bands (All) : ");
				Form1.SharedUI.RichTextBox1.Update();
				string text = File.ReadAllText(openFileDialog.FileName.ToString());
				if (text.Contains("</policy>"))
				{
					method_enablebend();
					Write(text);
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
					Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Write File 4G LTE Config : ");
					Form1.SharedUI.RichTextBox1.Update();
					cdmaTerm.SendTerminalCommand("4b1303000000000034507e", false);
					cdmaTerm.SendTerminalCommand("4b130f002f2f706f6c6963796d616e2f636172726965725f706f6c6963792e786d6c006c527e", false);
					cdmaTerm.SendTerminalCommand("4b130f002f2f706f6c6963796d616e2f636172726965725f706f6c6963792e786d6c006c527e", false);
					cdmaTerm.SendTerminalCommand("4b 13 03 00 00 00 00 00 34 50 7e", true);
					cdmaTerm.SendTerminalCommand("4b 13 03 00 00 00 00 00 34 50 7e", false);
					Carrierboxstring = Read();
					if (Operators.CompareString(Carrierboxstring, text, TextCompare: false) == 0)
					{
						Form1.SharedUI.RichTextBox1.Update();
						method_Setlie2();
						Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
						Form1.SharedUI.RichTextBox1.AppendText("OK");
						Form1.SharedUI.RichTextBox1.Update();
						Application.DoEvents();
						method_re();
						finsh();
					}
					else
					{
						Form1.SharedUI.RichTextBox1.Update();
						Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
						Form1.SharedUI.RichTextBox1.AppendText("Failed");
						cdmaTerm.Disconnect();
						finshonly();
					}
				}
			}
		}
		else
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText("Port Not Found");
			finshonly();
		}
	}

	private void Guna2Button4_Click(object sender, EventArgs e)
	{
		start();
		ThreadNew = new Thread(method_adb14);
		ThreadNew.Start();
	}

	public void method_adb14()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.CTS);
		Form1.SharedUI.ProgressBar1.Text = "Connecting....";
		method_infoadb2();
		if (Operators.CompareString(cancel, "Cancel", TextCompare: false) == 0)
		{
			finshonly();
		}
		else if (Operators.CompareString(TextBox10, "NOT", TextCompare: false) != 0)
		{
			method_Fix_Basband();
		}
	}

	public void method_Fix_Basband()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Analyze Device Port : ");
		Form1.SharedUI.ProgressBar1.Text = "Analyzeing..";
		if (Guna2ComboBox1.Text.Contains("USB Serial Port") | Guna2ComboBox1.Text.Contains("HS-USB") | Guna2ComboBox1.Text.Contains("Diagnostics"))
		{
			Name_Com = checked(Guna2ComboBox1.Text.Substring(Guna2ComboBox1.Text.IndexOf("(") + 1, Guna2ComboBox1.Text.Length - 2 - Guna2ComboBox1.Text.IndexOf("("))).Replace(")", "");
			cdmaTerm.Connect(Name_Com);
			if (!cdmaTerm.portIsOpen)
			{
				cdmaTerm.Disconnect();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
				Form1.SharedUI.RichTextBox1.AppendText("Port Opening Failed");
				finshonly();
			}
			else if (cdmaTerm.portIsOpen)
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Connected");
				Info();
				if (Operators.CompareString(Method, "no", TextCompare: false) == 0)
				{
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
					Form1.SharedUI.RichTextBox1.AppendText("Port Opening Failed, Please Select Other Port");
					Form1.SharedUI.RichTextBox1.Update();
					cdmaTerm.Disconnect();
					finshonly();
				}
				else
				{
					Method = "";
					SPC_PWD3();
					basebanduft();
					method_re();
					cdmaTerm.Disconnect();
					finsh();
				}
			}
		}
		else
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText("Port Not Found");
			finshonly();
		}
	}

	private void basebanduft()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Fix Baseband Method 1 : ");
		Form1.SharedUI.RichTextBox1.Update();
		TX("41303030303030df8a7e", crc: true);
		TX("465903365113726913282b7e", crc: true);
		TX("0078f07e", crc: true);
		TX("4b130800706f6c6963796d616e2f636172726965725f706f6c6963792e786d6c00f4ba7e", crc: true);
		TX("4b132600200000004102000001008303e80400000200d5000000e001000021000000000000003c0a00005006f28a706f6c6963796d616e2f7261745f6d61736b007e", crc: true);
		TX("4b132600200000004102000002008303e80400000200d5000000e001000021000000000000003c0a00005006f28a706f6c6963796d616e2f7261745f6d61736b5f537562736372697074696f6e3031007e", crc: true);
		TX("4b1326000100000041020000030000706f6c6963796d616e2f75655f6d6f6465007e", crc: true);
		TX("4b1310002f6e76007e", crc: true);
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("Success");
	}

	private void method_baseband2()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Fix Baseband Method 2 : ");
		Form1.SharedUI.RichTextBox1.Update();
		cdmaTerm.SendTerminalCommand("29 01 00 31 40 7E", true);
		cdmaTerm.SendTerminalCommand("41 30 30 30 30 30 30 DF 8A 7E", true);
		cdmaTerm.SendTerminalCommand("29 00 00 e9 59 7E", true);
		cdmaTerm.SendTerminalCommand("4b 13 0f 00 2f 2f 70 6f 6c 69 63 79 6d 61 6e 2f 63 61 72 72 69 65 72 5f 70 6f 6c 69 63 79 2e 78 6d 6c 00 6c 52 7E", true);
		cdmaTerm.SendTerminalCommand("4B 13 08 00 70 6F 6C 69 63 79 6D 61 6E 2F 63 61 72 72 69 65 72 5F 70 6F 6C 69 63 79 2E 78 6D 6C 00 F4 BA 7E", true);
		cdmaTerm.SendTerminalCommand("4B 13 08 00 70 6F 6C 69 63 79 6D 61 6E 2F 70 6F 6C 69 63 79 33 2F 63 61 72 72 69 65 72 5F 70 6F 6C 69 63 79 2E 78 6D 6C 00 B2 7A 7E", true);
		cdmaTerm.SendTerminalCommand("4B 13 08 00 70 6F 6C 69 63 79 6D 61 6E 2F 70 6F 6C 69 63 79 31 2F 63 61 72 72 69 65 72 5F 70 6F 6C 69 63 79 2E 78 6D 6C 00 6A 14 7E", true);
		cdmaTerm.SendTerminalCommand("4B 0B 24 00 5D 02 00 00 0E 00 55 00 06 00 30 30 30 30 30 30 0B 3E 7E", true);
		cdmaTerm.SendTerminalCommand("4B 0B 24 00 5D 02 00 00 0E 00 55 00 06 00 30 30 30 30 30 30 0B 3E 7E", true);
		cdmaTerm.SendTerminalCommand("4B 0B 24 00 5D 02 00 00 0E 00 55 00 06 00 30 30 30 30 30 30 0B 3E 7E", true);
		cdmaTerm.SendTerminalCommand("46 59 03 36 51 13 72 69 13 28 2B 7E", true);
		cdmaTerm.SendTerminalCommand("46 FF FF FF FF FF FF FF FF 00 FD EE 7E", true);
		cdmaTerm.SendTerminalCommand("41 30 30 30 30 30 30 DF 8A 7E", true);
		cdmaTerm.SendTerminalCommand("41 30 30 30 30 30 30 DF 8A 7E", true);
		cdmaTerm.SendTerminalCommand("41 30 30 30 30 30 30 DF 8A 7E", true);
		cdmaTerm.SendTerminalCommand("46 59 03 36 51 13 72 69 13 28 2B 7E", true);
		cdmaTerm.SendTerminalCommand("46 20 12 11 21 20 13 12 19 94 24 7E", true);
		cdmaTerm.SendTerminalCommand("46 20 12 11 21 20 13 12 19 94 24 7E", true);
		cdmaTerm.SendTerminalCommand("46 20 09 03 19 20 09 06 15 BA ED 7E", true);
		cdmaTerm.SendTerminalCommand("46 20 09 03 19 20 09 06 15 BA ED 7E", true);
		cdmaTerm.SendTerminalCommand("46 FF FF FF FF FF FF FF FF FE 74 7E", true);
		cdmaTerm.SendTerminalCommand("46 2F F8 11 28 2F F9 F3 23 37 A9 7E", true);
		cdmaTerm.SendTerminalCommand("46 20 10 03 16 19 78 07 21 5C 72 7E", true);
		cdmaTerm.SendTerminalCommand("46 20 14 11 24 20 15 02 02 17 B7 7E", true);
		cdmaTerm.SendTerminalCommand("46 20 10 03 16 19 78 07 21 5C 72 7E", true);
		cdmaTerm.SendTerminalCommand("29 00 00 e9 59 7E", true);
		cdmaTerm.SendTerminalCommand("29 01 00 31 40 7E", true);
		cdmaTerm.SendTerminalCommand("4b 13 0f 00 2f 2f 70 6f 6c 69 63 79 6d 61 6e 2f 63 61 72 72 69 65 72 5f 70 6f 6c 69 63 79 2e 78 6d 6c 00 6c 52 7E", true);
		cdmaTerm.SendTerminalCommand("4B 13 08 00 70 6F 6C 69 63 79 6D 61 6E 2F 63 61 72 72 69 65 72 5F 70 6F 6C 69 63 79 2E 78 6D 6C 00 F4 BA 7E", true);
		cdmaTerm.SendTerminalCommand("4B 13 08 00 70 6F 6C 69 63 79 6D 61 6E 2F 70 6F 6C 69 63 79 33 2F 63 61 72 72 69 65 72 5F 70 6F 6C 69 63 79 2E 78 6D 6C 00 B2 7A 7E", true);
		cdmaTerm.SendTerminalCommand("4B 13 08 00 70 6F 6C 69 63 79 6D 61 6E 2F 70 6F 6C 69 63 79 31 2F 63 61 72 72 69 65 72 5F 70 6F 6C 69 63 79 2E 78 6D 6C 00 6A 14 7E", true);
		cdmaTerm.SendTerminalCommand("4B 13 0C 00 01 00 00 00 1E 00 00 00 A3 00 7E", true);
		cdmaTerm.SendTerminalCommand("4B 13 0C 00 01 00 00 00 1E 00 00 00 A3 00 7E", true);
		cdmaTerm.SendTerminalCommand("4B 13 0C 00 01 00 00 00 1E 00 00 00 A3 00 7E", true);
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("Success");
	}

	private void method_baseband3()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Fix Baseband Method 3 : ");
		Form1.SharedUI.RichTextBox1.Update();
		cdmaTerm.SendTerminalCommand("41 30 30 30 30 30 30 DF 8A 7E", true);
		cdmaTerm.SendTerminalCommand("4b 13 0f 00 2f 2f 70 6f 6c 69 63 79 6d 61 6e 2f 63 61 72 72 69 65 72 5f 70 6f 6c 69 63 79 2e 78 6d 6c 00 6c 52 7E", true);
		cdmaTerm.SendTerminalCommand("4B 13 08 00 70 6F 6C 69 63 79 6D 61 6E 2F 63 61 72 72 69 65 72 5F 70 6F 6C 69 63 79 2E 78 6D 6C 00 F4 BA 7E", true);
		cdmaTerm.SendTerminalCommand("4B 13 08 00 70 6F 6C 69 63 79 6D 61 6E 2F 70 6F 6C 69 63 79 33 2F 63 61 72 72 69 65 72 5F 70 6F 6C 69 63 79 2E 78 6D 6C 00 B2 7A 7E", true);
		cdmaTerm.SendTerminalCommand("4B 13 08 00 70 6F 6C 69 63 79 6D 61 6E 2F 70 6F 6C 69 63 79 31 2F 63 61 72 72 69 65 72 5F 70 6F 6C 69 63 79 2E 78 6D 6C 00 6A 14 7E", true);
		cdmaTerm.SendTerminalCommand("4B 0B 24 00 5D 02 00 00 0E 00 55 00 06 00 30 30 30 30 30 30 0B 3E 7E", true);
		cdmaTerm.SendTerminalCommand("4B 0B 24 00 5D 02 00 00 0E 00 55 00 06 00 30 30 30 30 30 30 0B 3E 7E", true);
		cdmaTerm.SendTerminalCommand("4B 0B 24 00 5D 02 00 00 0E 00 55 00 06 00 30 30 30 30 30 30 0B 3E 7E", true);
		cdmaTerm.SendTerminalCommand("46 59 03 36 51 13 72 69 13 28 2B 7E", true);
		cdmaTerm.SendTerminalCommand("46 FF FF FF FF FF FF FF FF 00 FD EE 7E", true);
		cdmaTerm.SendTerminalCommand("41 30 30 30 30 30 30 DF 8A 7E", true);
		cdmaTerm.SendTerminalCommand("41 30 30 30 30 30 30 DF 8A 7E", true);
		cdmaTerm.SendTerminalCommand("41 30 30 30 30 30 30 DF 8A 7E", true);
		cdmaTerm.SendTerminalCommand("46 59 03 36 51 13 72 69 13 28 2B 7E", true);
		cdmaTerm.SendTerminalCommand("46 20 12 11 21 20 13 12 19 94 24 7E", true);
		cdmaTerm.SendTerminalCommand("46 20 12 11 21 20 13 12 19 94 24 7E", true);
		cdmaTerm.SendTerminalCommand("46 20 09 03 19 20 09 06 15 BA ED 7E", true);
		cdmaTerm.SendTerminalCommand("46 20 09 03 19 20 09 06 15 BA ED 7E", true);
		cdmaTerm.SendTerminalCommand("46 FF FF FF FF FF FF FF FF FE 74 7E", true);
		cdmaTerm.SendTerminalCommand("46 2F F8 11 28 2F F9 F3 23 37 A9 7E", true);
		cdmaTerm.SendTerminalCommand("46 20 10 03 16 19 78 07 21 5C 72 7E", true);
		cdmaTerm.SendTerminalCommand("46 20 14 11 24 20 15 02 02 17 B7 7E", true);
		cdmaTerm.SendTerminalCommand("46 20 10 03 16 19 78 07 21 5C 72 7E", true);
		cdmaTerm.SendTerminalCommand("29 00 00 e9 59 7E", true);
		cdmaTerm.SendTerminalCommand("29 01 00 31 40 7E", true);
		cdmaTerm.SendTerminalCommand("4b 13 0f 00 2f 2f 70 6f 6c 69 63 79 6d 61 6e 2f 63 61 72 72 69 65 72 5f 70 6f 6c 69 63 79 2e 78 6d 6c 00 6c 52 7E", true);
		cdmaTerm.SendTerminalCommand("4B 13 08 00 70 6F 6C 69 63 79 6D 61 6E 2F 63 61 72 72 69 65 72 5F 70 6F 6C 69 63 79 2E 78 6D 6C 00 F4 BA 7E", true);
		cdmaTerm.SendTerminalCommand("4B 13 08 00 70 6F 6C 69 63 79 6D 61 6E 2F 70 6F 6C 69 63 79 33 2F 63 61 72 72 69 65 72 5F 70 6F 6C 69 63 79 2E 78 6D 6C 00 B2 7A 7E", true);
		cdmaTerm.SendTerminalCommand("4B 13 08 00 70 6F 6C 69 63 79 6D 61 6E 2F 70 6F 6C 69 63 79 31 2F 63 61 72 72 69 65 72 5F 70 6F 6C 69 63 79 2E 78 6D 6C 00 6A 14 7E", true);
		cdmaTerm.SendTerminalCommand("27 55 07 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 34 FC 7E", true);
		cdmaTerm.SendTerminalCommand("27 55 07 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 34 FC 7E", true);
		cdmaTerm.SendTerminalCommand("27 55 07 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 34 FC 7E", true);
		cdmaTerm.SendTerminalCommand("27 55 07 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 34 FC 7E", true);
		cdmaTerm.SendTerminalCommand("4B 13 0C 00 01 00 00 00 1E 00 00 00 A3 00 7E", true);
		cdmaTerm.SendTerminalCommand("4B 13 0C 00 01 00 00 00 1E 00 00 00 A3 00 7E", true);
		cdmaTerm.SendTerminalCommand("4B 13 0C 00 01 00 00 00 1E 00 00 00 A3 00 7E", true);
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("Success");
	}

	private void Guna2Button7_Click(object sender, EventArgs e)
	{
		start();
		ThreadNew = new Thread(method_adb15);
		ThreadNew.Start();
	}

	public void method_adb15()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.CTS);
		Form1.SharedUI.ProgressBar1.Text = "Connecting....";
		method_infoadb2();
		if (Operators.CompareString(cancel, "Cancel", TextCompare: false) == 0)
		{
			finshonly();
		}
		else if (Operators.CompareString(TextBox10, "NOT", TextCompare: false) != 0)
		{
			Remove_polesman();
		}
	}

	public void Remove_polesman()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Analyze Device Port : ");
		Form1.SharedUI.ProgressBar1.Text = "Analyzeing..";
		if (Guna2ComboBox1.Text.Contains("USB Serial Port") | Guna2ComboBox1.Text.Contains("HS-USB") | Guna2ComboBox1.Text.Contains("Diagnostics"))
		{
			Name_Com = checked(Guna2ComboBox1.Text.Substring(Guna2ComboBox1.Text.IndexOf("(") + 1, Guna2ComboBox1.Text.Length - 2 - Guna2ComboBox1.Text.IndexOf("("))).Replace(")", "");
			cdmaTerm.Connect(Name_Com);
			if (!cdmaTerm.portIsOpen)
			{
				cdmaTerm.Disconnect();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
				Form1.SharedUI.RichTextBox1.AppendText("Port Opening Failed");
				finshonly();
			}
			else if (cdmaTerm.portIsOpen)
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Connected");
				Info();
				if (Operators.CompareString(Method, "no", TextCompare: false) == 0)
				{
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
					Form1.SharedUI.RichTextBox1.AppendText("Port Opening Failed, Please Select Other Port");
					Form1.SharedUI.RichTextBox1.Update();
					cdmaTerm.Disconnect();
					finshonly();
					return;
				}
				Method = "";
				SPC_PWD3();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Remove Policyman : ");
				Form1.SharedUI.ProgressBar1.Text = "Removeing..";
				method_Erase();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("OK");
				method_re();
				cdmaTerm.Disconnect();
				finsh();
			}
		}
		else
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText("Port Not Found");
			finshonly();
		}
	}

	private void Guna2Button5_Click(object sender, EventArgs e)
	{
		start();
		ThreadNew = new Thread(method_adb16);
		ThreadNew.Start();
	}

	public void method_adb16()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.CTS);
		Form1.SharedUI.ProgressBar1.Text = "Connecting....";
		method_infoadb2();
		if (Operators.CompareString(cancel, "Cancel", TextCompare: false) == 0)
		{
			finshonly();
		}
		else if (Operators.CompareString(TextBox10, "NOT", TextCompare: false) != 0)
		{
			Write_3G();
		}
	}

	public void Write_3G()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Analyze Device Port : ");
		Form1.SharedUI.ProgressBar1.Text = "Analyzeing..";
		if (Guna2ComboBox1.Text.Contains("USB Serial Port") | Guna2ComboBox1.Text.Contains("HS-USB") | Guna2ComboBox1.Text.Contains("Diagnostics"))
		{
			Name_Com = checked(Guna2ComboBox1.Text.Substring(Guna2ComboBox1.Text.IndexOf("(") + 1, Guna2ComboBox1.Text.Length - 2 - Guna2ComboBox1.Text.IndexOf("("))).Replace(")", "");
			cdmaTerm.Connect(Name_Com);
			if (!cdmaTerm.portIsOpen)
			{
				cdmaTerm.Disconnect();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
				Form1.SharedUI.RichTextBox1.AppendText("Port Opening Failed");
				finshonly();
			}
			else if (cdmaTerm.portIsOpen)
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Connected");
				Info();
				if (Operators.CompareString(Method, "no", TextCompare: false) == 0)
				{
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
					Form1.SharedUI.RichTextBox1.AppendText("Port Opening Failed, Please Select Other Port");
					Form1.SharedUI.RichTextBox1.Update();
					cdmaTerm.Disconnect();
					finshonly();
					return;
				}
				Method = "";
				SPC_PWD3();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Write 3G Setting Config : ");
				Form1.SharedUI.ProgressBar1.Text = "Writeing..";
				auot3gnew();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("OK");
				method_PRL();
				method_re();
				cdmaTerm.Disconnect();
				finsh();
			}
		}
		else
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText("Port Not Found");
			finshonly();
		}
	}

	private void Guna2Button11_Click(object sender, EventArgs e)
	{
		start();
		ThreadNew = new Thread(method_adb17);
		ThreadNew.Start();
	}

	public void method_adb17()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.CTS);
		Form1.SharedUI.ProgressBar1.Text = "Connecting....";
		method_infoadb2();
		if (Operators.CompareString(cancel, "Cancel", TextCompare: false) == 0)
		{
			finshonly();
		}
		else if (Operators.CompareString(TextBox10, "NOT", TextCompare: false) != 0)
		{
			Write_edit_sim();
		}
	}

	public void Write_edit_sim()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Analyze Device Port : ");
		Form1.SharedUI.ProgressBar1.Text = "Analyzeing..";
		if (Guna2ComboBox1.Text.Contains("USB Serial Port") | Guna2ComboBox1.Text.Contains("HS-USB") | Guna2ComboBox1.Text.Contains("Diagnostics"))
		{
			Name_Com = checked(Guna2ComboBox1.Text.Substring(Guna2ComboBox1.Text.IndexOf("(") + 1, Guna2ComboBox1.Text.Length - 2 - Guna2ComboBox1.Text.IndexOf("("))).Replace(")", "");
			cdmaTerm.Connect(Name_Com);
			if (!cdmaTerm.portIsOpen)
			{
				cdmaTerm.Disconnect();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
				Form1.SharedUI.RichTextBox1.AppendText("Port Opening Failed");
				finshonly();
			}
			else if (cdmaTerm.portIsOpen)
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Connected");
				Info();
				if (Operators.CompareString(Method, "no", TextCompare: false) == 0)
				{
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
					Form1.SharedUI.RichTextBox1.AppendText("Port Opening Failed, Please Select Other Port");
					Form1.SharedUI.RichTextBox1.Update();
					cdmaTerm.Disconnect();
					finshonly();
					return;
				}
				Method = "";
				SPC_PWD3();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Write SIM Patch [Auto 3G Setting] : ");
				SIMEDIT();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Write 3G Setting Config : ");
				Form1.SharedUI.ProgressBar1.Text = "Writeing..";
				auot3gnew();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("OK");
				editmix();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Write SIM Patch2 For 3G : ");
				SIMEDIT();
				method_PRL();
				method_re();
				cdmaTerm.Disconnect();
				finsh();
			}
		}
		else
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText("Port Not Found");
			finshonly();
		}
	}

	private void editmix()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Starting Edit 3G SIM MAX : ");
		Form1.SharedUI.RichTextBox1.Update();
		TX("2705000200000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000", crc: true);
		TX("2711000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000", crc: true);
		TX("2712000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000", crc: true);
		TX("271F000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000", crc: true);
		TX("27200000B2937600B29376000000000000000000000000000000000000000000000000000000000000000000000000000000000000", crc: true);
		TX("2722000001010000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000", crc: true);
		TX("2723000001010000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000", crc: true);
		TX("2724000001010000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000", crc: true);
		TX("2725000007070000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000", crc: true);
		TX("2726000000000000472C01000000000000000000000000000000000000000000000000000000000000000000000000000000000000", crc: true);
		TX("272C000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000", crc: true);
		TX("272D000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000", crc: true);
		TX("272F000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000", crc: true);
		TX("273100472C472CFF001F00000000000000000000000000000000000000000000000000000000000000000000000000000000000000", crc: true);
		TX("273200405B0300C0B60900000000000000000000000000000000000000000000000000000000000000000000000000000000000000", crc: true);
		TX("2772000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000", crc: true);
		TX("27B0000036010000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000", crc: true);
		TX("27B100005C000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000", crc: true);
		TX("27B2000030303030303030303030000000000000000000000000000000000000000000000000000000000000000000000000000000", crc: true);
		TX("27D10000FF000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000", crc: true);
		TX("27D2000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000", crc: true);
		TX("27D3000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000", crc: true);
		TX("27D40000FFFFFFFF000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000", crc: true);
		TX("27D5000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000", crc: true);
		TX("27D70000000F0F0F0F0F0F0F0F0F0F0F0F0F0F0F000000000000000000000000000000000000000000000000000000000000000000", crc: true);
		TX("27030100472C0100000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000", crc: true);
		TX("2704010001000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000", crc: true);
		TX("2705010000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000", crc: true);
		TX("2728010100000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000", crc: true);
		TX("27CB010100000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000", crc: true);
		TX("2743020F31313235383534303537404556444F00000000000000000000000000000000000000000000000000000000000000000000", crc: true);
		TX("278A030000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000", crc: true);
		TX("278E0307796D6F62696C65000000000000000000000000000000000000000000000000000000000000000000000000000000000000", crc: true);
		TX("27AA040F31313235383534303537404556444F00000000000000000000000000000000000000000000000000000000000000000000", crc: true);
		TX("274C150000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000", crc: true);
		TX("274D150200000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000", crc: true);
		TX("274E150007796D6F62696C650000000000000000000000000000000000000000000000000000000000000000000000000000000000", crc: true);
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("OK");
	}

	private void SIMEDIT()
	{
		try
		{
			cdmaTerm.ReadAllNam();
			string text = "42103" + cdmaTerm.thePhone.Min;
			string text2 = "0" + text[0] + "0" + text[1] + "0" + text[2] + "0" + text[3] + "0" + text[4] + "0" + text[5] + "0" + text[6] + "0" + text[7] + "0" + text[8] + "0" + text[9] + "0" + text[10] + "0" + text[11] + "0" + text[12] + "0" + text[13] + "0" + text[14] + "00000000000000";
			cdmaTerm.SendTerminalCommand("27 D7 00 00 0f" + text2 + " 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00", true);
			cdmaTerm.SendTerminalCommand("27 CB 01 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00", true);
			Form1.SharedUI.RichTextBox1.Update();
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("OK");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Guna2Button13_Click(object sender, EventArgs e)
	{
		start();
		ThreadNew = new Thread(method_adb18);
		ThreadNew.Start();
	}

	public void method_adb18()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.CTS);
		Form1.SharedUI.ProgressBar1.Text = "Connecting....";
		method_infoadb2();
		if (Operators.CompareString(cancel, "Cancel", TextCompare: false) == 0)
		{
			finshonly();
		}
		else if (Operators.CompareString(TextBox10, "NOT", TextCompare: false) != 0)
		{
			Enable_Bands();
		}
	}

	public void Enable_Bands()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Analyze Device Port : ");
		Form1.SharedUI.ProgressBar1.Text = "Analyzeing..";
		if (Guna2ComboBox1.Text.Contains("USB Serial Port") | Guna2ComboBox1.Text.Contains("HS-USB") | Guna2ComboBox1.Text.Contains("Diagnostics"))
		{
			Name_Com = checked(Guna2ComboBox1.Text.Substring(Guna2ComboBox1.Text.IndexOf("(") + 1, Guna2ComboBox1.Text.Length - 2 - Guna2ComboBox1.Text.IndexOf("("))).Replace(")", "");
			cdmaTerm.Connect(Name_Com);
			if (!cdmaTerm.portIsOpen)
			{
				cdmaTerm.Disconnect();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
				Form1.SharedUI.RichTextBox1.AppendText("Port Opening Failed");
				finshonly();
			}
			else if (cdmaTerm.portIsOpen)
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Connected");
				Info();
				if (Operators.CompareString(Method, "no", TextCompare: false) == 0)
				{
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
					Form1.SharedUI.RichTextBox1.AppendText("Port Opening Failed, Please Select Other Port");
					Form1.SharedUI.RichTextBox1.Update();
					cdmaTerm.Disconnect();
					finshonly();
				}
				else
				{
					Method = "";
					SPC_PWD3();
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
					Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Enable Bands : ");
					Form1.SharedUI.ProgressBar1.Text = "Enable..";
					method_enablebend();
					method_re();
					cdmaTerm.Disconnect();
					finsh();
				}
			}
		}
		else
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText("Port Not Found");
			finshonly();
		}
	}

	private void Guna2Button12_Click(object sender, EventArgs e)
	{
		start();
		ThreadNew = new Thread(method_adb19);
		ThreadNew.Start();
	}

	public void method_adb19()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.CTS);
		Form1.SharedUI.ProgressBar1.Text = "Connecting....";
		method_infoadb2();
		if (Operators.CompareString(cancel, "Cancel", TextCompare: false) == 0)
		{
			finshonly();
		}
		else if (Operators.CompareString(TextBox10, "NOT", TextCompare: false) != 0)
		{
			disable_Bands();
		}
	}

	public void disable_Bands()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Analyze Device Port : ");
		Form1.SharedUI.ProgressBar1.Text = "Analyzeing..";
		if (Guna2ComboBox1.Text.Contains("USB Serial Port") | Guna2ComboBox1.Text.Contains("HS-USB") | Guna2ComboBox1.Text.Contains("Diagnostics"))
		{
			Name_Com = checked(Guna2ComboBox1.Text.Substring(Guna2ComboBox1.Text.IndexOf("(") + 1, Guna2ComboBox1.Text.Length - 2 - Guna2ComboBox1.Text.IndexOf("("))).Replace(")", "");
			cdmaTerm.Connect(Name_Com);
			if (!cdmaTerm.portIsOpen)
			{
				cdmaTerm.Disconnect();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
				Form1.SharedUI.RichTextBox1.AppendText("Port Opening Failed");
				finshonly();
			}
			else if (cdmaTerm.portIsOpen)
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Connected");
				Info();
				if (Operators.CompareString(Method, "no", TextCompare: false) == 0)
				{
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
					Form1.SharedUI.RichTextBox1.AppendText("Port Opening Failed, Please Select Other Port");
					Form1.SharedUI.RichTextBox1.Update();
					cdmaTerm.Disconnect();
					finshonly();
				}
				else
				{
					Method = "";
					SPC_PWD3();
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
					Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Disable Bands : ");
					Form1.SharedUI.ProgressBar1.Text = "Disable..";
					DISELTEBAND();
					method_re();
					cdmaTerm.Disconnect();
					finsh();
				}
			}
		}
		else
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText("Port Not Found");
			finshonly();
		}
	}

	private void DISELTEBAND()
	{
		cdmaTerm.SendTerminalCommand("27AC1A0400000000000000040000000000000000000000000000000000000000000000000000000000000000", true);
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("OK");
		Form1.SharedUI.RichTextBox1.Update();
	}

	private void Guna2Button14_Click(object sender, EventArgs e)
	{
		start();
		ThreadNew = new Thread(method_adb20);
		ThreadNew.Start();
	}

	public void method_adb20()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.CTS);
		Form1.SharedUI.ProgressBar1.Text = "Connecting....";
		method_infoadb2();
		if (Operators.CompareString(cancel, "Cancel", TextCompare: false) == 0)
		{
			finshonly();
		}
		else if (Operators.CompareString(TextBox10, "NOT", TextCompare: false) != 0)
		{
			Replace_SIM();
		}
	}

	public void Replace_SIM()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Analyze Device Port : ");
		Form1.SharedUI.ProgressBar1.Text = "Analyzeing..";
		if (Guna2ComboBox1.Text.Contains("USB Serial Port") | Guna2ComboBox1.Text.Contains("HS-USB") | Guna2ComboBox1.Text.Contains("Diagnostics"))
		{
			Name_Com = checked(Guna2ComboBox1.Text.Substring(Guna2ComboBox1.Text.IndexOf("(") + 1, Guna2ComboBox1.Text.Length - 2 - Guna2ComboBox1.Text.IndexOf("("))).Replace(")", "");
			cdmaTerm.Connect(Name_Com);
			if (!cdmaTerm.portIsOpen)
			{
				cdmaTerm.Disconnect();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
				Form1.SharedUI.RichTextBox1.AppendText("Port Opening Failed");
				finshonly();
			}
			else if (cdmaTerm.portIsOpen)
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Connected");
				Info();
				if (Operators.CompareString(Method, "no", TextCompare: false) == 0)
				{
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
					Form1.SharedUI.RichTextBox1.AppendText("Port Opening Failed, Please Select Other Port");
					Form1.SharedUI.RichTextBox1.Update();
					cdmaTerm.Disconnect();
					finshonly();
					return;
				}
				Method = "";
				SPC_PWD3();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Starting No Service After Repalce SIM : ");
				Form1.SharedUI.ProgressBar1.Text = "Repairing..";
				Replace();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("OK");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Repair CDMA Netowrk No Service : ");
				method_CONVRT1();
				finsh();
			}
		}
		else
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText("Port Not Found");
			finshonly();
		}
	}

	public void Replace()
	{
		cdmaTerm.EfsQc.DeleteFromEFS("mcfg_rfs_sw_digest_version", "nv/item_files/mcfg");
		cdmaTerm.EfsQc.DeleteFromEFS("mcfg_sel_db.xml", "nv/item_files/mcfg");
		cdmaTerm.EfsQc.DeleteFromEFS("mcfg_setting", "nv/item_files/mcfg");
		cdmaTerm.EfsQc.DeleteFromEFS("mcfg_setting_1", "nv/item_files/mcfg");
		cdmaTerm.EfsQc.DeleteFromEFS("mcfg_sw_config_digest_version_Subscription01", "nv/item_files/mcfg");
		cdmaTerm.EfsQc.DeleteFromEFS("mcfg_sw_muxd_version_8", "nv/item_files/mcfg");
		cdmaTerm.EfsQc.DeleteFromEFS("mcfg_sw_muxd_version_99", "nv/item_files/mcfg");
		cdmaTerm.EfsQc.DeleteFromEFS("mcfg_activated_config", "nv/item_files/mcfg");
		cdmaTerm.EfsQc.DeleteFromEFS("mcfg_def_config_hw_version", "nv/item_files/mcfg");
		cdmaTerm.EfsQc.DeleteFromEFS("mcfg_def_config_sw_version", "nv/item_files/mcfg");
		cdmaTerm.EfsQc.DeleteFromEFS("mcfg_def_config_sw_version_Subscription01", "nv/item_files/mcfg");
		cdmaTerm.EfsQc.DeleteFromEFS("mcfg_sw_muxd_version_1", "nv/item_files/mcfg");
		cdmaTerm.EfsQc.DeleteFromEFS("mcfg_setting_Subscription01", "nv/item_files/mcfg");
		cdmaTerm.EfsQc.DeleteFromEFS("mcfg_autoselect_by_uim ", "nv/item_files/mcfg");
		cdmaTerm.EfsQc.DeleteFromEFS("mcfg_autoselect_by_uim_Subscription01", "nv/item_files/mcfg");
		cdmaTerm.EfsQc.DeleteFromEFS("mcfg_autoselect_by_uim_Subscription01_backupmcfg_autoselect_by_uim_backup", "nv/item_files/mcfg");
		cdmaTerm.EfsQc.DeleteFromEFS(" mcfg_def_config_sw_versionmcfg_def_config_sw_version_Subscription01", "nv/item_files/mcfg");
		cdmaTerm.EfsQc.DeleteFromEFS("mcfg_default_hw_digest_version", "nv/item_files/mcfg");
		cdmaTerm.EfsQc.DeleteFromEFS("mcfg_default_sw_digest_version", "nv/item_files/mcfg");
		cdmaTerm.EfsQc.DeleteFromEFS("mcfg_default_sw_digest_version_Subscription01", "nv/item_files/mcfg");
		cdmaTerm.EfsQc.DeleteFromEFS("mcfg_hw_config_digest_version", "nv/item_files/mcfg");
		cdmaTerm.EfsQc.DeleteFromEFS("mcfg_hw_img_new_version", "nv/item_files/mcfg");
		cdmaTerm.EfsQc.DeleteFromEFS("mcfg_rfs_hw_digest_version", "nv/item_files/mcfg");
		cdmaTerm.EfsQc.DeleteFromEFS("mcfg_rfs_sw_digest_version", "nv/item_files/mcfg");
		cdmaTerm.EfsQc.DeleteFromEFS("mcfg_autoselect_by_uim", "nv/item_files/mcfg");
		cdmaTerm.EfsQc.DeleteFromEFS("mcfg_def_config_hw_version", "nv/item_files/mcfg");
		cdmaTerm.EfsQc.DeleteFromEFS("mcfg_def_config_sw_version", "nv/item_files/mcfg");
		cdmaTerm.EfsQc.DeleteFromEFS("mcfg_default_hw_digest_version", "nv/item_files/mcfg");
		cdmaTerm.EfsQc.DeleteFromEFS("mcfg_default_sw_digest_version", "nv/item_files/mcfg");
		cdmaTerm.EfsQc.DeleteFromEFS("mcfg_default_sw_digest_version_Subscription01", "nv/item_files/mcfg");
		cdmaTerm.EfsQc.DeleteFromEFS("mcfg_hw_config_digest_version", "nv/item_files/mcfg");
		cdmaTerm.EfsQc.DeleteFromEFS("mcfg_multi_mbn_config_version", "nv/item_files/mcfg");
		cdmaTerm.EfsQc.DeleteFromEFS("mcfg_rfs_hw_digest_version", "nv/item_files/mcfg");
		cdmaTerm.EfsQc.DeleteFromEFS("mcfg_rfs_sw_digest_version", "nv/item_files/mcfg");
		cdmaTerm.EfsQc.DeleteFromEFS("mcfg_segload_config", "nv/item_files/mcfg");
		cdmaTerm.EfsQc.DeleteFromEFS("mcfg_sw_config_digest_version", "nv/item_files/mcfg");
		cdmaTerm.EfsQc.DeleteFromEFS("mcfg_sw_config_digest_version_Subscription01", "nv/item_files/mcfg");
		cdmaTerm.EfsQc.DeleteFromEFS("mcfg_sw_muxd_version_1", "nv/item_files/mcfg");
		cdmaTerm.EfsQc.DeleteFromEFS("mcfg_sw_muxd_version_2", "nv/item_files/mcfg");
		cdmaTerm.EfsQc.DeleteFromEFS("mcfg_sw_muxd_version_32", "nv/item_files/mcfg");
		cdmaTerm.EfsQc.DeleteFromEFS("mcfg_sw_muxd_version_8", "nv/item_files/mcfg");
		cdmaTerm.EfsQc.DeleteFromEFS("mcfg_sw_muxd_version_9", "nv/item_files/mcfg");
	}

	private void Guna2Button15_Click(object sender, EventArgs e)
	{
		start();
		ThreadNew = new Thread(method_adb21);
		ThreadNew.Start();
	}

	public void method_adb21()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.CTS);
		Form1.SharedUI.ProgressBar1.Text = "Connecting....";
		method_infoadb2();
		if (Operators.CompareString(cancel, "Cancel", TextCompare: false) == 0)
		{
			finshonly();
		}
		else if (Operators.CompareString(TextBox10, "NOT", TextCompare: false) != 0)
		{
			QCNFILE();
		}
	}

	public void QCNFILE()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Analyze Device Port : ");
		Form1.SharedUI.ProgressBar1.Text = "Analyzeing..";
		checked
		{
			try
			{
				Process[] processesByName = Process.GetProcessesByName("7z");
				int num = 0;
				do
				{
					processesByName[num].Kill();
					num++;
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
			try
			{
				Process[] processesByName2 = Process.GetProcessesByName("qc");
				int num2 = 0;
				do
				{
					processesByName2[num2].Kill();
					num2++;
				}
				while (num2 < processesByName2.Length);
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception projectError2 = ex2;
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
			}
			try
			{
				Process[] processesByName3 = Process.GetProcessesByName("Tunlocker Tool");
				int num3 = 0;
				do
				{
					processesByName3[num3].Kill();
					num3++;
				}
				while (num3 < processesByName3.Length);
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception projectError3 = ex3;
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
			}
			if (Guna2ComboBox1.Text.Contains("USB Serial Port") | Guna2ComboBox1.Text.Contains("HS-USB") | Guna2ComboBox1.Text.Contains("Diagnostics"))
			{
				Name_Com = Guna2ComboBox1.Text.Substring(Guna2ComboBox1.Text.IndexOf("(") + 1, Guna2ComboBox1.Text.Length - 2 - Guna2ComboBox1.Text.IndexOf("(")).Replace(")", "");
				cdmaTerm.Connect(Name_Com);
				if (!cdmaTerm.portIsOpen)
				{
					cdmaTerm.Disconnect();
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
					Form1.SharedUI.RichTextBox1.AppendText("Port Opening Failed");
					finshonly();
				}
				else if (cdmaTerm.portIsOpen)
				{
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
					Form1.SharedUI.RichTextBox1.AppendText("Connected");
					Info();
					if (Operators.CompareString(Method, "no", TextCompare: false) == 0)
					{
						Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
						Form1.SharedUI.RichTextBox1.AppendText("Port Opening Failed, Please Select Other Port");
						Form1.SharedUI.RichTextBox1.Update();
						cdmaTerm.Disconnect();
						finshonly();
					}
					else
					{
						Method = "";
						SPC_PWD3();
						IMEI = read_IMEI();
						MEID = read_MEID();
						WRITEQCN();
					}
				}
			}
			else
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
				Form1.SharedUI.RichTextBox1.AppendText("Port Not Found");
				finshonly();
			}
		}
	}

	private void WRITEQCN()
	{
		tmp = txtqcn.Text;
		nembr_com = Conversions.ToInteger(Name_Com.Replace("COM", ""));
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Prepair Device : ");
		if (nembr_com > 200)
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText("Failed, Ports Zero And Try Again");
			finshonly();
			return;
		}
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("OK");
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Prepair Files : ");
		namefile = "N.zip";
		tmpWinrarr = "N";
		string path = ThisLocation + "tmp\\" + namefile;
		try
		{
			File.Delete(path);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		path = ThisLocation + "tmp\\" + tmpWinrarr;
		try
		{
			MyProject.Computer.FileSystem.DeleteDirectory(path, DeleteDirectoryOption.DeleteAllContents);
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			ProjectData.ClearProjectError();
		}
		Delay(1.0);
		File.WriteAllBytes(ThisLocation + "tmp\\" + namefile, Resources.QCN);
		Delay(1.0);
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("OK");
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Writeing QCN : ");
		Form1.SharedUI.ProgressBar1.Text = "Writeing QCN..";
		runExFB("bin\\7z.exe x tmp\\N.zip -p911 -otmp\\N");
		Form1.SharedUI.ProgressBar1.Text = "Writeing QCN...";
		Delay(1.0);
		runExFB("tmp\\N\\qc.exe qcnwrite -p " + Name_Com + " -f \"" + tmp + "\" -spc 000000");
		cdmaTerm.Connect(Name_Com);
		path = ThisLocation + "tmp\\" + namefile;
		try
		{
			File.Delete(path);
		}
		catch (Exception ex5)
		{
			ProjectData.SetProjectError(ex5);
			Exception ex6 = ex5;
			ProjectData.ClearProjectError();
		}
		path = ThisLocation + "tmp\\" + tmpWinrarr;
		try
		{
			MyProject.Computer.FileSystem.DeleteDirectory(path, DeleteDirectoryOption.DeleteAllContents);
		}
		catch (Exception ex7)
		{
			ProjectData.SetProjectError(ex7);
			Exception ex8 = ex7;
			ProjectData.ClearProjectError();
		}
		SPC_PWD2();
		W_IMEI(IMEI);
		WMEID(MEID);
		method_re();
		finsh();
	}

	private void Guna2Button18_Click(object sender, EventArgs e)
	{
		start();
		ThreadNew = new Thread(method_adb22);
		ThreadNew.Start();
	}

	public void method_adb22()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.CTS);
		Form1.SharedUI.ProgressBar1.Text = "Connecting....";
		method_infoadb2();
		if (Operators.CompareString(cancel, "Cancel", TextCompare: false) == 0)
		{
			finshonly();
		}
		else if (Operators.CompareString(TextBox10, "NOT", TextCompare: false) != 0)
		{
			Repair_4G();
		}
	}

	public void Repair_4G()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Prepair Device : ");
		Form1.SharedUI.ProgressBar1.Text = "Prepairing..";
		Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + serialno.Text + " shell am broadcast -a android.intent.action.AIRPLANE_MODE", new object[0]), false);
		Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + serialno.Text + " shell settings put global device_provisioned 1", new object[0]), false);
		Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + serialno.Text + " shell settings put secure user_setup_complete 1", new object[0]), false);
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("OK");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Repair 4G LTE Config : ");
		Form1.SharedUI.ProgressBar1.Text = "Repairing..";
		Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + serialno.Text + " shell service call phone 42 s16 com.android.phone", new object[0]), false);
		Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + serialno.Text + " shell settings get global multi_sim_data_call", new object[0]), false);
		Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + serialno.Text + " shell settings put global multi_sim_data_call 1", new object[0]), false);
		Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + serialno.Text + " shell settings put global preferred_network_mode1 8", new object[0]), false);
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("OK");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Reboot Device : ");
		Form1.SharedUI.ProgressBar1.Text = "Rebooting..";
		Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + serialno.Text + " shell reboot", new object[0]), false);
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("OK");
		Form1.SharedUI.RichTextBox1.Update();
		finsh();
	}

	private void Guna2Button10_Click(object sender, EventArgs e)
	{
		OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.Filter = "All Files (*.QCN*)|*.QCN*";
		if (DialogResult.OK == openFileDialog.ShowDialog())
		{
			string fileName = openFileDialog.FileName;
			txtqcn.Text = fileName;
			a = openFileDialog.FileName;
			a = Strings.Replace(a, " ", "\" \"");
		}
	}

	public void method_Cancel()
	{
		cancel = "Cancel";
		try
		{
			SerialCOM.process.Kill();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception projectError = ex;
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		checked
		{
			try
			{
				Process[] processesByName = Process.GetProcessesByName("7z");
				int num = 0;
				do
				{
					processesByName[num].Kill();
					num++;
				}
				while (num < processesByName.Length);
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception projectError2 = ex2;
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
			}
			try
			{
				Process[] processesByName2 = Process.GetProcessesByName("DCAPI");
				int num2 = 0;
				do
				{
					processesByName2[num2].Kill();
					num2++;
				}
				while (num2 < processesByName2.Length);
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception projectError3 = ex3;
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
			}
			try
			{
				Process[] processesByName3 = Process.GetProcessesByName("adb");
				int num3 = 0;
				do
				{
					processesByName3[num3].Kill();
					num3++;
				}
				while (num3 < processesByName3.Length);
			}
			catch (Exception ex4)
			{
				ProjectData.SetProjectError(ex4);
				Exception projectError4 = ex4;
				ProjectData.SetProjectError(projectError4);
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
			}
			try
			{
				ThreadNew.Abort();
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception projectError5 = ex5;
				ProjectData.SetProjectError(projectError5);
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
			}
			ProgressBa = "Cen";
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		if (Operators.CompareString(SevaClass.canaclstring, "Can", TextCompare: false) == 0)
		{
			SevaClass.canaclstring = "";
			method_Cancel();
		}
		if (Operators.CompareString(ProgressBa, "MESSAGA12", TextCompare: false) == 0)
		{
			ProgressBa = "O";
			MyProject.Forms.Dialog3.ShowDialog();
		}
	}

	private void Guna2ComboBox1_Click(object sender, EventArgs e)
	{
	}

	private void Guna2Button9_Click(object sender, EventArgs e)
	{
		Guna2ComboBox1.Items.Clear();
		foreach (COMPortInfoB item in COMPortInfoB.GetCOMPortsInfo())
		{
			Guna2ComboBox1.Items.Add(item.DeviceName);
		}
		if (Guna2ComboBox1.Items.Count != 0)
		{
			Guna2ComboBox1.SelectedIndex = 0;
		}
	}

	public void Misc()
	{
		if (Guna2RadioButton6.Checked)
		{
			Open_Diag_Menu_LG_Sprint();
		}
		if (Guna2RadioButton5.Checked)
		{
			Open_Add_APN_Menu_LG();
		}
		if (Guna2RadioButton3.Checked)
		{
			Open_Enable_Bands_Menu_LG_MTK();
		}
		if (Guna2RadioButton9.Checked)
		{
			Open_NOA_Test_Settings_LG();
		}
		if (Guna2RadioButton8.Checked)
		{
			Open_MCFG_Edit_Menu_LG();
		}
		if (Guna2RadioButton25.Checked)
		{
			Open_Diag_Menu_ZTE();
		}
		if (Guna2RadioButton19.Checked)
		{
			Open_SPC_Menu_Samsung();
		}
		if (Guna2RadioButton18.Checked)
		{
			open_usb();
		}
		if (Guna2RadioButton17.Checked)
		{
			Open_Hidden_Services_Samsung();
		}
		if (Guna2RadioButton16.Checked)
		{
			Open_Change_CSC_Menu_Samsung();
		}
		if (Guna2RadioButton26.Checked)
		{
			open_network();
		}
		if (Guna2RadioButton27.Checked)
		{
			Enabel_Daig_For_All();
		}
	}

	private void Guna2Button19_Click(object sender, EventArgs e)
	{
		start();
		ThreadNew = new Thread(method_adb30);
		ThreadNew.Start();
	}

	private void Guna2Button21_Click(object sender, EventArgs e)
	{
		start();
		ThreadNew = new Thread(method_adb29);
		ThreadNew.Start();
	}

	public void method_adb29()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.CTS);
		Form1.SharedUI.ProgressBar1.Text = "Connecting....";
		method_infoadb2();
		if (Operators.CompareString(cancel, "Cancel", TextCompare: false) == 0)
		{
			finshonly();
		}
		else if (Operators.CompareString(TextBox10, "NOT", TextCompare: false) != 0)
		{
			VoLTE_Custom();
		}
	}

	public void method_adb30()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.CTS);
		Form1.SharedUI.ProgressBar1.Text = "Connecting....";
		method_infoadb2();
		if (Operators.CompareString(cancel, "Cancel", TextCompare: false) == 0)
		{
			finshonly();
		}
		else if (Operators.CompareString(TextBox10, "NOT", TextCompare: false) != 0)
		{
			Misc();
		}
	}

	public void open_network()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Open Radio Info Main : ");
		Form1.SharedUI.ProgressBar1.Text = "Opening..";
		Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + serialno.Text + " shell am start -n com.android.settings/com.android.settings.RadioInfo", new object[0]), false);
		Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + serialno.Text + " shell am start -n com.android.settings/.RadioInfo", new object[0]), false);
		Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + serialno.Text + " shell am start -n com.android.phone/.settings.RadioInfo", new object[0]), false);
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("OK");
		finsh();
	}

	public void open_usb()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Open USB Setting Meun : ");
		Form1.SharedUI.ProgressBar1.Text = "Opening..";
		runExFB(Form1.String_73 + "adb.exe shell input keyevent KEYCODE_HOME; settings put secure assistant 'com.sec.usbsettings/com.sec.usbsettings.USBSettings';input keyevent --longpress KEYCODE_HOME;settings put secure assistant 'com.sec.usbsettings/com.sec.usbsettings.USBSettings'");
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("OK");
		finsh();
	}

	public void Open_Diag_Menu_LG_Sprint()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Open Diag Menu LG Sprint : ");
		Form1.SharedUI.ProgressBar1.Text = "Opening..";
		runExFB(Form1.String_73 + "adb.exe shell input keyevent KEYCODE_HOME; settings put secure assistant 'com.lge.operator.hiddenmenu/.spr.sprintspec.DIAG';input keyevent --longpress KEYCODE_HOME;settings put secure assistant 'com.google.android.googlequicksearchbox/com.google.android.voceinteraction.GsaVoiceInteractionService'");
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("OK");
		finsh();
	}

	public void Open_Add_APN_Menu_LG()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Open Add APN Menu LG : ");
		Form1.SharedUI.ProgressBar1.Text = "Opening..";
		runExFB(Form1.String_73 + "adb.exe shell input keyevent KEYCODE_HOME; settings put secure assistant 'com.lge.hiddenmenu/com.lge.hiddenmenu.ModemProtocol.ApnSettings';input keyevent --longpress KEYCODE_HOME;settings put secure assistant 'com.google.android.googlequicksearchbox/com.gogle.android.voiceinteraction.GsaVoiceInteractionService'");
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("OK");
		finsh();
	}

	public void Open_Enable_Bands_Menu_LG_MTK()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Open Enable Bands Menu LG MTK : ");
		Form1.SharedUI.ProgressBar1.Text = "Opening..";
		runExFB(Form1.String_73 + "adb.exe shell input keyevent KEYCODE_HOME; settings put secure assistant 'com.mediatek.engineermode/com.mediatek.engineermode.bandselect.BandSelect';input keyevent --longpress KEYCODE_HOME;settings put secure assistant 'com.google.android.googlequicksearchox/com.google.android.voiceinteraction.GsaVoiceInteractionService'");
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("OK");
		finsh();
	}

	public void Open_NOA_Test_Settings_LG()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Open NOA Test Settings LG : ");
		Form1.SharedUI.ProgressBar1.Text = "Opening..";
		runExFB(Form1.String_73 + "adb.exe shell input keyevent KEYCODE_HOME; settings put secure assistant 'com.lge.hiddenmenu/com.lge.hiddenmenu.FieldTest.naot.NAOTestEnabler';input keyevent --longpress KEYCODE_HOME;settings put secure assistant 'com.google.android.googlequicksearchbox/co.google.android.voiceinteraction.GsaVoiceInteractionService'");
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("OK");
		finsh();
	}

	public void Open_MCFG_Edit_Menu_LG()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Open MCFG Edit Menu LG : ");
		Form1.SharedUI.ProgressBar1.Text = "Opening..";
		runExFB(Form1.String_73 + "adb.exe shell input keyevent KEYCODE_HOME; settings put secure assistant 'com.lge.hiddenmenu/.ModemProtocol.MCFG_Buffet';input keyevent --longpress KEYCODE_HOME;settings put secure assistant 'com.google.android.googlequicksearchbox/com.google.android.voicenteraction.GsaVoiceInteractionService'");
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("OK");
		finsh();
	}

	public void Open_Diag_Menu_ZTE()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Open Diag Menu ZTE [ General Mehod ] : ");
		Form1.SharedUI.ProgressBar1.Text = "Opening..";
		runExFB(Form1.String_73 + "adb.exe shell input keyevent KEYCODE_HOME;settings put secure assistant 'com.zte.emode/.UsbSwitch';input keyevent --longpress KEYCODE_ASSIST;settings put secure assistant 'com.google.android.googlequicksearchbox/com.google.android.voiceinteraction.GsaVoicenteractionService'");
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("OK");
		finsh();
	}

	public void Open_SPC_Menu_Samsung()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Open SPC Menu Samsung : ");
		Form1.SharedUI.ProgressBar1.Text = "Opening..";
		runExFB(Form1.String_73 + "adb.exe shell input keyevent KEYCODE_HOME; settings put secure assistant 'com.sec.hiddenmenu/com.sec.hiddenmenu.Program_Edit';input keyevent --longpress KEYCODE_HOME;settings put secure assistant 'com.google.android.googlequicksearchbox/com.google.android.oiceinteraction.GsaVoiceInteractionService'");
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("OK");
		finsh();
	}

	public void Open_Hidden_Services_Samsung()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Open Hidden Services Samsung : ");
		Form1.SharedUI.ProgressBar1.Text = "Opening..";
		runExFB(Form1.String_73 + "adb.exe shell input keyevent KEYCODE_HOME; settings put secure assistant 'com.sec.android.app.factorymode/com.sec.android.app.factorymode.FactoryCTRL';input keyevent --longpress KEYCODE_HOME;settings put secure assistant 'com.google.android.googlequicksearhbox/com.google.android.voiceinteraction.GsaVoiceInteractionService'");
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("OK");
		finsh();
	}

	public void Open_Change_CSC_Menu_Samsung()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Open Change CSC Menu Samsung : ");
		Form1.SharedUI.ProgressBar1.Text = "Opening..";
		runExFB(Form1.String_73 + "adb.exe shell input keyevent KEYCODE_HOME; settings put secure assistant 'com.samsung.sec.android.application.csc/com.samsung.sec.android.application.preconfig.Preconfig';input keyevent --longpress KEYCODE_HOME;settings put secure assistant 'com.google.andoid.googlequicksearchbox/com.google.android.voiceinteraction.GsaVoiceInteractionService'");
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("OK");
		finsh();
	}

	public void VoLTE_Custom()
	{
		if (Guna2RadioButton7.Checked)
		{
			OpenSPD_Enginnger_Menu();
		}
		if (Guna2RadioButton12.Checked)
		{
			Open_SPD_Enginnger_Menu_Mth2();
		}
		if (Guna2RadioButton11.Checked)
		{
			Open_SPD_Enginnger_Menu_Mth3();
		}
		if (Guna2RadioButton10.Checked)
		{
			Open_SPD_Enginnger_Menu_Mth4();
		}
		if (Guna2RadioButton15.Checked)
		{
			Open_SPD_Operator_Settings_Menu();
		}
		if (Guna2RadioButton14.Checked)
		{
			Open_SPD_Gcf_Settings_Menu();
		}
		if (Guna2RadioButton13.Checked)
		{
			Open_IMS_Menu_Direct_ZTE();
		}
		if (Guna2RadioButton20.Checked)
		{
			Open_IMS_Menu_Direct_LG();
		}
		if (Guna2RadioButton22.Checked)
		{
			Open_IMS_Menu_MTK();
		}
		if (Guna2RadioButton21.Checked)
		{
			Open_Engineer_Mode_MTK();
		}
		if (Guna2RadioButton24.Checked)
		{
			Open_Network_Menu_MTK();
		}
		if (Guna2RadioButton23.Checked)
		{
			Open_MiscConfig_Menu_MTK();
		}
		if (Guna2RadioButton30.Checked)
		{
			Open_MBN_Config_Edit_X();
		}
		if (Guna2RadioButton29.Checked)
		{
			Open_MBN_Config_Edit_Q();
		}
		if (Guna2RadioButton28.Checked)
		{
			Enable_VoLTE_All_MTK();
		}
	}

	public void OpenSPD_Enginnger_Menu()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Open SPD Enginnger Menu : ");
		Form1.SharedUI.ProgressBar1.Text = "Opening..";
		runExFB(Form1.String_73 + "adb.exe shell input keyevent KEYCODE_HOME; settings put secure assistant 'com.sprd.engineermode/.EngineerModeActivity_2';input keyevent --longpress KEYCODE_HOME;settings put secure assistant 'com.google.android.googlequicksearchbox/com.google.android.voicenteraction.GsaVoiceInteractionService'");
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("OK");
		finsh();
	}

	public void Open_SPD_Enginnger_Menu_Mth2()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Open SPD Enginnger Menu Mth2 : ");
		Form1.SharedUI.ProgressBar1.Text = "Opening..";
		runExFB(Form1.String_73 + "adb.exe shell input keyevent KEYCODE_HOME; settings put secure assistant 'com.sprd.engineermode/.gcf.IotActivity';input keyevent --longpress KEYCODE_HOME;settings put secure assistant 'com.google.android.googlequicksearchbox/com.google.android.voiceinteracion.GsaVoiceInteractionService'");
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("OK");
		finsh();
	}

	public void Open_SPD_Enginnger_Menu_Mth3()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Open SPD Enginnger Menu Mth3 : ");
		Form1.SharedUI.ProgressBar1.Text = "Opening..";
		runExFB(Form1.String_73 + "adb.exe shell input keyevent KEYCODE_HOME;settings put secure assistant 'com.sprd.engineermode/.EngineerModeActivity';input keyevent --longpress KEYCODE_HOME;input keyevent --longpress KEYCODE_ASSIST;settings put secure assistant 'com.google.android.googleuicksearchbox/com.google.android.voiceinteraction.GsaVoiceInteractionService'");
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("OK");
		finsh();
	}

	public void Open_SPD_Enginnger_Menu_Mth4()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Open SPD Enginnger Menu Mth4 : ");
		Form1.SharedUI.ProgressBar1.Text = "Opening..";
		runExFB(Form1.String_73 + "adb.exe shell input keyevent KEYCODE_HOME;settings put secure assistant 'com.sprd.engineermode/.EngineerModeActivity';input keyevent --longpress KEYCODE_HOME;input keyevent 26 26;settings put secure assistant 'com.google.android.googlequicksearchbox/com.goole.android.voiceinteraction.GsaVoiceInteractionService'");
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("OK");
		finsh();
	}

	public void Open_SPD_Operator_Settings_Menu()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Open SPD Operator Settings Menu : ");
		Form1.SharedUI.ProgressBar1.Text = "Opening..";
		runExFB(Form1.String_73 + "adb.exe shell input keyevent KEYCODE_HOME; settings put secure assistant 'com.sprd.engineermode/.gcf.OperatorActivity';input keyevent --longpress KEYCODE_HOME;settings put secure assistant 'com.google.android.googlequicksearchbox/com.google.android.voiceineraction.GsaVoiceInteractionService'");
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("OK");
		finsh();
	}

	public void Open_SPD_Gcf_Settings_Menu()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Open SPD Gcf Settings Menu : ");
		Form1.SharedUI.ProgressBar1.Text = "Opening..";
		runExFB(Form1.String_73 + "adb.exe shell input keyevent KEYCODE_HOME; settings put secure assistant 'com.sprd.engineermode/.gcf.GcfActivity';input keyevent --longpress KEYCODE_HOME;settings put secure assistant 'com.google.android.googlequicksearchbox/com.google.android.voiceinteracion.GsaVoiceInteractionService'");
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("OK");
		finsh();
	}

	public void Open_IMS_Menu_Direct_ZTE()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Open IMS Menu Direct ZTE : ");
		Form1.SharedUI.ProgressBar1.Text = "Opening..";
		runExFB("");
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("OK");
		finsh();
	}

	public void Open_IMS_Menu_Direct_LG()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Open IMS Menu Direct LG : ");
		Form1.SharedUI.ProgressBar1.Text = "Opening..";
		runExFB(Form1.String_73 + "adb.exe shell input keyevent KEYCODE_HOME; settings put secure assistant 'com.lge.ims/.volte.hidden.IMSProvisioning';input keyevent --longpress KEYCODE_HOME;settings put secure assistant 'com.google.android.googlequicksearchbox/com.google.android.voiceinteaction.GsaVoiceInteractionService'");
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("OK");
		finsh();
	}

	public void Open_IMS_Menu_MTK()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Open IMS Menu MTK : ");
		Form1.SharedUI.ProgressBar1.Text = "Opening..";
		runExFB(Form1.String_73 + "adb.exe shell input keyevent KEYCODE_HOME;settings put secure assistant 'com.mediatek.engineermode.ims.ImsActivity';input keyevent --longpress KEYCODE_ASSIST;settings put secure assistant 'com.google.android.googlequicksearchbox/com.google.android.voiceintraction.GsaVoiceInteractionService'");
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("OK");
		finsh();
	}

	public void Open_Engineer_Mode_MTK()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Open Engineer Mode MTK : ");
		Form1.SharedUI.ProgressBar1.Text = "Opening..";
		runExFB(Form1.String_73 + "adb.exe shell input keyevent KEYCODE_HOME;settings put secure assistant 'com.mediatek.engineermode/com.mediatek.engineermode.EngineerMode';input keyevent --longpress KEYCODE_ASSIST;");
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("OK");
		finsh();
	}

	public void Open_Network_Menu_MTK()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Open Selection Operator MTK : ");
		Form1.SharedUI.ProgressBar1.Text = "Opening..";
		runExFB(Form1.String_73 + "adb.exe shell input keyevent KEYCODE_HOME;settings put secure assistant 'com.mediatek.engineermode/com.mediatek.engineermode.ims.ImsActivity';input keyevent --longpress KEYCODE_ASSIST;");
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("OK");
		finsh();
	}

	public void Open_MiscConfig_Menu_MTK()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Open MiscConfig Menu MTK : ");
		Form1.SharedUI.ProgressBar1.Text = "Opening..";
		runExFB(Form1.String_73 + "adb.exe shell input keyevent KEYCODE_HOME;settings put secure assistant 'com.mediatek.engineermode/com.mediatek.engineermode.misc.MiscConfig';input keyevent --longpress KEYCODE_ASSIST;");
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("OK");
		finsh();
	}

	public void Open_MBN_Config_Edit_X()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Open MBN Config Edit Menu [Xiaomi] : ");
		Form1.SharedUI.ProgressBar1.Text = "Opening..";
		runExFB(Form1.String_73 + "adb.exe shell am start -n com.xiaomi.mtb/com.xiaomi.mtb.activity.ModemTestBoxMainActivity");
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("OK");
		finsh();
	}

	public void Open_MBN_Config_Edit_Q()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Open MBN Test Menu : ");
		Form1.SharedUI.ProgressBar1.Text = "Opening..";
		runExFB(Form1.String_73 + "adb.exe shell input keyevent KEYCODE_HOME;settings put secure assistant 'com.qualcomm.qti.modemtestmode/.ModemTestActivity';input keyevent --longpress KEYCODE_ASSIST;settings put secure assistant 'com.google.android.googlequicksearchbox/com.google.android.oiceinteraction.GsaVoiceInteractionService'");
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("OK");
		finsh();
	}

	public void Enable_VoLTE_All_MTK()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Enable VoLTE All MTK [Root] : ");
		Form1.SharedUI.ProgressBar1.Text = "Start Enabled..";
		runExFB(Form1.String_73 + "adb.exe shell su -c 'setprop settings put global volte_subscriptione 1'");
		runExFB(Form1.String_73 + "adb.exe shell su -c 'setprop settings put global volte_subscription1 1'");
		runExFB(Form1.String_73 + "adb.exe shell su -c 'setprop persist.dbg.ims_volte enable 1'");
		runExFB(Form1.String_73 + "adb.exe shell su -c 'setprop persist.dbg.volte_avail_ovr 1'");
		runExFB(Form1.String_73 + "adb.exe shell su -c 'setprop persist.dbg.vt_avail_ovr 1'");
		runExFB(Form1.String_73 + "adb.exe shell su -c 'setprop persist.dbg.wfc_avail_ovr 1'");
		runExFB(Form1.String_73 + "adb.exe shell su -c 'setprop persist.vendor.mtk_dynamic_ims_switch o'");
		runExFB(Form1.String_73 + "adb.exe shell su -c 'setprop persist.vendor.mtk.vilte.enable 1'");
		runExFB(Form1.String_73 + "adb.exe shell su -c 'setprop persist.vendor.mtk.volte.enable 1'");
		runExFB(Form1.String_73 + "adb.exe shell su -c 'setprop persist.vendor.mtk.vonr.enable 1'");
		runExFB(Form1.String_73 + "adb.exe shell su -c 'setprop persist.vendor.mtk.wfc.enable 1'");
		runExFB(Form1.String_73 + "adb.exe shell su -c 'setprop persist.vendor.mtk_dynamic_ims_switch 0'");
		runExFB(Form1.String_73 + "adb.exe shell su -c 'setprop persist.vendor.radio.volte_state 1'");
		runExFB(Form1.String_73 + "adb.exe shell su -c 'setprop vendor.ril.mtk_hvolte_indicator 1,1'");
		runExFB(Form1.String_73 + "adb.exe shell su -c 'setprop vendor.ril.mtk_hvolte_indicator 1'");
		runExFB(Form1.String_73 + "adb.exe shell su -c 'setprop persist.vendor.volte_support 1'");
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("OK");
		finsh();
	}

	public void Enabel_Daig_For_All()
	{
		Label15.Contains("samsung");
		Label15.Contains("LT");
		Label15.Contains("ZTE");
		Label15.Contains("LG");
		Label15.Contains("samsung");
		Label15.Contains("samsung");
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Start Enable Diag : ");
		Form1.SharedUI.ProgressBar1.Text = "Opening..";
		runExFB(Form1.String_73 + "adb.exe shell input keyevent KEYCODE_HOME; settings put secure assistant 'com.samsung.sec.android.application.csc/com.samsung.sec.android.application.preconfig.Preconfig';input keyevent --longpress KEYCODE_HOME;settings put secure assistant 'com.google.andoid.googlequicksearchbox/com.google.android.voiceinteraction.GsaVoiceInteractionService'");
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("OK");
		finsh();
	}

	private void Services_Network_Load(object sender, EventArgs e)
	{
	}

	private void Guna2Button17_Click(object sender, EventArgs e)
	{
		start();
		ThreadNew = new Thread(Zeroports);
		ThreadNew.Start();
	}

	public void Zeroports()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText("- Starting Zero Ports : ");
		Form1.SharedUI.ProgressBar1.Text = "Checking Files..";
		try
		{
			File.Delete(ThisLocation + "tmp\\DCAPI.exe");
			File.Delete(ThisLocation + "tmp\\reset.bat");
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		File.WriteAllBytes(ThisLocation + "tmp\\DCAPI.exe", Resources.DCAPI);
		File.WriteAllBytes(ThisLocation + "tmp\\reset.bat", Resources.comportreset);
		Delay(2.0);
		Form1.SharedUI.ProgressBar1.Text = "Zero Ports..";
		string_13 = "tmp\\DCAPI.exe *";
		Zero_ALL_2();
		if (Operators.CompareString(cancel, "Cancel", TextCompare: false) == 0)
		{
			Form1.SharedUI.ProgressBar1.Text = "100%";
			return;
		}
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Checking Zero All Ports : ");
		Form1.SharedUI.ProgressBar1.Text = "Checking..";
		Delay(3.0);
		runExFB("tmp\\reset.bat");
		Delay(2.0);
		if (Operators.CompareString(cancel, "Cancel", TextCompare: false) == 0)
		{
			Form1.SharedUI.ProgressBar1.Text = "100%";
			return;
		}
		try
		{
			File.Delete(ThisLocation + "tmp\\DCAPI.exe");
			File.Delete(ThisLocation + "tmp\\reset.bat");
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			ProjectData.ClearProjectError();
		}
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("OK");
		finsh();
	}

	private void Guna2Button48_Click(object sender, EventArgs e)
	{
		start();
		ThreadNew = new Thread(method_adb31);
		ThreadNew.Start();
	}

	public void method_adb31()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.CTS);
		Form1.SharedUI.ProgressBar1.Text = "Connecting....";
		method_infoadb2();
		if (Operators.CompareString(cancel, "Cancel", TextCompare: false) == 0)
		{
			finshonly();
		}
		else if (Operators.CompareString(TextBox10, "NOT", TextCompare: false) != 0)
		{
			Repair_Call_Not_Sent();
		}
	}

	public void Repair_Call_Not_Sent()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Prepair Device : ");
		Form1.SharedUI.ProgressBar1.Text = "Prepairing...";
		namefile = "1.dll";
		string path = ThisLocation + "tmp\\" + namefile;
		try
		{
			File.Delete(path);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		string path2 = ThisLocation + "tmp\\1.apk";
		File.WriteAllBytes(path2, Resources.KG);
		Delay(1.0);
		if (Operators.CompareString(cancel, "Cancel", TextCompare: false) == 0)
		{
			Form1.SharedUI.ProgressBar1.Text = "100%";
			return;
		}
		Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + serialno.Text + " wait-for-device install -r tmp\\1.apk", new object[0]), false);
		Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + serialno.Text + " wait-for-device shell dpm set-device-owner com.skataha.bp/com.skataha.bp.Hubris", new object[0]), false);
		Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + serialno.Text + " wait-for-device shell pm grant com.skamdm.knox android.permission.WRITE_SECURE_SETTINGS", new object[0]), false);
		Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + serialno.Text + " reboot", new object[0]), false);
		try
		{
			File.Delete(path2);
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			ProjectData.ClearProjectError();
		}
		if (Operators.CompareString(cancel, "Cancel", TextCompare: false) == 0)
		{
			Form1.SharedUI.ProgressBar1.Text = "100%";
			return;
		}
		wait_booted(log_allow: true);
		Delay(2.0);
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("OK");
		if (Operators.CompareString(cancel, "Cancel", TextCompare: false) == 0)
		{
			Form1.SharedUI.ProgressBar1.Text = "100%";
			return;
		}
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + ClassDevronix.IDD);
		Form1.SharedUI.ProgressBar1.Text = ClassDevronix.I2;
		Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + serialno.Text + " wait-for-device shell content insert --uri content://settings/secure --bind name:s:user_setup_complete --bind value:s:1", new object[0]), false);
		Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + serialno.Text + " wait-for-device shell settings put secure enabled_accessibility_services com.skamdm.knox/com.olalab.lockscreen.LockScreenAccessibilityService", new object[0]), false);
		Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + serialno.Text + " wait-for-device shell settings put global policy_control immersive.full=com.skamdm.knox", new object[0]), false);
		wronganswer_wave();
		ProgressBa = "MESSAGA12";
		while (Operators.CompareString(ProgressBa, "", TextCompare: false) != 0)
		{
		}
		if (Operators.CompareString(cancel, "Cancel", TextCompare: false) == 0)
		{
			Form1.SharedUI.ProgressBar1.Text = "100%";
			return;
		}
		wait_booted(log_allow: true);
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("OK");
		if (Operators.CompareString(cancel, "Cancel", TextCompare: false) == 0)
		{
			Form1.SharedUI.ProgressBar1.Text = "100%";
			return;
		}
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Repair Call Not Sent : ");
		Form1.SharedUI.ProgressBar1.Text = "Repairing..";
		Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + serialno.Text + " wait-for-device shell pm disable-user com.samsung.android.kgclient", new object[0]), false);
		Form1.SharedUI.ProgressBar1.Text = "Waiting..";
		wronganswer_wave();
		Form1.SharedUI.Guna2MessageDialog1.Text = "Disconnect The Cable And Reconnect It\r\n\r\nThen Click OK To Continue...";
		Form1.SharedUI.Guna2MessageDialog1.Show();
		Form1.SharedUI.ProgressBar1.Text = "Clear..";
		Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + serialno.Text + " wait-for-device shell pm clear com.samsung.android.kgclient", new object[0]), false);
		Form1.SharedUI.ProgressBar1.Text = "Reboot..";
		Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + serialno.Text + " wait-for-device shell reboot", new object[0]), false);
		if (Operators.CompareString(cancel, "Cancel", TextCompare: false) == 0)
		{
			Form1.SharedUI.ProgressBar1.Text = "100%";
			return;
		}
		wait_booted(log_allow: true);
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("OK");
		if (Operators.CompareString(cancel, "Cancel", TextCompare: false) == 0)
		{
			Form1.SharedUI.ProgressBar1.Text = "100%";
			return;
		}
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Remove KG\\Knox Lock : ");
		Form1.SharedUI.ProgressBar1.Text = "Removeing..";
		Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + serialno.Text + " wait-for-device shell pm enable com.samsung.android.kgclient", new object[0]), false);
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("OK");
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Reboot Device : ");
		Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + serialno.Text + " wait-for-device shell reboot", new object[0]), false);
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("OK");
		finsh();
	}

	private void Guna2Button22_Click(object sender, EventArgs e)
	{
		start();
		ThreadNew = new Thread(method_adb32);
		ThreadNew.Start();
	}

	public void method_adb32()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.CTS);
		Form1.SharedUI.ProgressBar1.Text = "Connecting....";
		method_infoadb2();
		if (Operators.CompareString(cancel, "Cancel", TextCompare: false) == 0)
		{
			finshonly();
		}
		else if (Operators.CompareString(TextBox10, "NOT", TextCompare: false) != 0)
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Check If Model Supported : ");
			check_3g_moto();
		}
	}

	public void check_3g_moto()
	{
		if ("XT1765-XT1921-XT1922-XT1952-XT1955-XT1962-XT2005-XT2041-XT2043-XT2045-XT2052-XT2093DL-XT2113DL-XT2115DL-XT2117-XT2131".Contains(Label4))
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Supported");
			Form1.SharedUI.RichTextBox1.Update();
			if ("XT1765".Contains(Label4))
			{
				NameConfig = "K0";
			}
			if ("XT1921".Contains(Label4))
			{
				NameConfig = "K1";
			}
			if ("XT1922".Contains(Label4))
			{
				NameConfig = "K2";
			}
			if ("XT1952".Contains(Label4))
			{
				NameConfig = "K3";
			}
			if ("XT1955".Contains(Label4))
			{
				NameConfig = "K4";
			}
			if ("XT1962".Contains(Label4))
			{
				NameConfig = "K5";
			}
			if ("XT2005".Contains(Label4))
			{
				NameConfig = "K6";
			}
			if ("XT2041".Contains(Label4))
			{
				NameConfig = "K7";
			}
			if ("XT2043".Contains(Label4))
			{
				NameConfig = "K8";
			}
			if ("XT2045".Contains(Label4))
			{
				NameConfig = "K9";
			}
			if ("XT2052".Contains(Label4))
			{
				NameConfig = "K10";
			}
			if ("XT2093DL".Contains(Label4))
			{
				NameConfig = "K11";
			}
			if ("XT2113DL".Contains(Label4))
			{
				NameConfig = "K12";
			}
			if ("XT2115DL".Contains(Label4))
			{
				NameConfig = "K13";
			}
			if ("XT2117".Contains(Label4))
			{
				NameConfig = "K14";
			}
			if ("XT2131".Contains(Label4))
			{
				NameConfig = "K15";
			}
			Write_3g_moto();
		}
		else
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText("Not Supported");
			Form1.SharedUI.RichTextBox1.Update();
			finshonly();
		}
	}

	private void method_chakccable()
	{
		Form1.SharedUI.ProgressBar4.Value = 0;
		ProgressChanged = Conversions.ToString(0);
		TextBox41 = "";
		TextBox10 = "";
		Form1.SharedUI.ProgressBar1.Text = "Start Fastboot Deamon..";
		while (true)
		{
			TextBox10 = Fastboot.ExecuteFastbootCommand(Fastboot.FormFastbootCommand("devices", new string[0]));
			if (TextBox10.Contains("fastboot"))
			{
				TextBox10 = "";
				ProgressBa = "DISREAD";
				Form1.SharedUI.ProgressBar1.Text = "Checking Device State..";
				return;
			}
			if (Operators.CompareString(cancel, "Cancel", TextCompare: false) == 0)
			{
				ProgressBa = "Cen";
				cancel = "Cancel";
				return;
			}
			if (Form1.SharedUI.ProgressBar4.Value == 100)
			{
				break;
			}
			ProgressBa = "ENREADDEVICE";
			ProgressChanged = Conversions.ToString(Form1.SharedUI.ProgressBar4.Value);
			Form1.SharedUI.ProgressBar4.Text = "Wait For Device.." + ProgressChanged + "%";
		}
		ProgressBa = "Cen";
		TextBox10 = "NOT";
	}

	public string Extracttext(string input, string word)
	{
		string pattern = word + "\\s*([A-Za-z0-9]+)";
		Match match = Regex.Match(input, pattern);
		if (match.Success)
		{
			return match.Groups[1].Value;
		}
		return string.Empty;
	}

	private void DownloadAndExtractZip(string zipUrl, string extractPath, string password)
	{
		try
		{
			string text = extractPath + namefile;
			string text2 = extractPath + tmpWinrarr;
			try
			{
				MyProject.Computer.FileSystem.DeleteDirectory(text2, DeleteDirectoryOption.DeleteAllContents);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			try
			{
				MyProject.Computer.FileSystem.DeleteDirectory(text2, DeleteDirectoryOption.DeleteAllContents);
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ProjectData.ClearProjectError();
			}
			try
			{
				MyProject.Computer.FileSystem.DeleteDirectory(text2, DeleteDirectoryOption.DeleteAllContents);
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				ProjectData.ClearProjectError();
			}
			if (File.Exists(text))
			{
				runExFB(("bin\\7z.exe x " + text + " -p" + password + " -o" + text2) ?? "");
				if (Directory.Exists(text2))
				{
					DownloadFileCompleted = true;
				}
				else
				{
					DownloadFileCompleted = false;
				}
				return;
			}
			if (Operators.CompareString(namefile, "Up.zip", TextCompare: false) == 0)
			{
				SerialCOM.MSL = "ENREADdonload_Update";
			}
			else
			{
				SerialCOM.MSL = "ENREADdonload";
			}
			using WebClient webClient = new WebClient();
			webClient.DownloadProgressChanged += WebClient_DownloadProgressChanged;
			webClient.DownloadFileCompleted += WebClient_DownloadFileCompleted;
			webClient.DownloadFileAsync(new Uri(zipUrl), extractPath + namefile);
			while (webClient.IsBusy)
			{
				Application.DoEvents();
			}
			runExFB(("bin\\7z.exe x " + text + " -p" + password + " -o" + text2) ?? "");
			if (Directory.Exists(text2))
			{
				DownloadFileCompleted = true;
			}
			else
			{
				DownloadFileCompleted = false;
			}
		}
		catch (Exception ex7)
		{
			ProjectData.SetProjectError(ex7);
			Exception ex8 = ex7;
			ProjectData.ClearProjectError();
		}
	}

	private void WebClient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
	{
		Form1.SharedUI.ProgressBar4.Value = e.ProgressPercentage;
	}

	private void WebClient_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
	{
		if (e.Error != null)
		{
			DownloadFileCompleted = false;
		}
		else
		{
			DownloadFileCompleted = true;
		}
		SerialCOM.MSL = "DISREAD";
	}

	public void Write_3g_moto()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Getting Data From Server : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.ProgressBar1.Text = "Getting Data..";
		link = "https://firebasestorage.googleapis.com/v0/b/motounlock-7d7d0.appspot.com/o/Config?alt=media&token=99ae727c-82a2-4d49-be0c-e110edafbe40";
		namefile = "Config.zip";
		tmpWinrarr = "Config";
		DownloadAndExtractZip(link, ClassDevronix.CWQ, "efeeeefe0100000004000000");
		if (!DownloadFileCompleted)
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringF);
			finshonly();
			return;
		}
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringO);
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Switching To (BL Mode) : ");
		Form1.SharedUI.ProgressBar1.Text = "Switching...";
		Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + serialno.Text + " wait-for-device reboot bootloader", new object[0]), false);
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringO);
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Waiting for Usb Device : ");
		method_chakccable();
		if (Operators.CompareString(cancel, "Cancel", TextCompare: false) == 0 || Operators.CompareString(TextBox10, "NOT", TextCompare: false) == 0)
		{
			return;
		}
		string input = Fastboot.ExecuteFastbootCommand(Fastboot.FormFastbootCommand("getvar all", new string[0]));
		Label4 = Extracttext(input, "sku:");
		IMEI = Extracttext(input, "imei:");
		baseband = Extracttext(input, "factory-modes:");
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText("OK");
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Phone Model : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(Label4);
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Phone IMEI : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(IMEI);
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Check Factory Mode : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(baseband);
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + ClassDevronix.IDD);
		Form1.SharedUI.ProgressBar1.Text = ClassDevronix.I2;
		namefile = ClassDevronix.CWQ + "Config\\" + NameConfig;
		if (!File.Exists(namefile))
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringF);
			Form1.SharedUI.RichTextBox1.Update();
			finshonly();
			return;
		}
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringO);
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Write 3G Setting [ ");
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.LightGreen;
		Form1.SharedUI.RichTextBox1.AppendText(NameConfig);
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(" ] Config : ");
		Form1.SharedUI.ProgressBar1.Text = "Writing...";
		string text;
		if ("XT2131".Contains(Label4))
		{
			Fastboot.ExecuteFastbootCommand(Fastboot.FormFastbootCommand("flash fsg_a " + namefile, new string[0]));
			text = Fastboot.ExecuteFastbootCommand(Fastboot.FormFastbootCommand("flash fsg_b " + namefile, new string[0]));
		}
		else
		{
			text = Fastboot.ExecuteFastbootCommand(Fastboot.FormFastbootCommand("flash fsg " + namefile, new string[0]));
		}
		if (text.Contains("OK"))
		{
			string directory = ClassDevronix.CWQ + tmpWinrarr;
			try
			{
				MyProject.Computer.FileSystem.DeleteDirectory(directory, DeleteDirectoryOption.DeleteAllContents);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			SerialCOM.MSL = "ENREAD";
			Form1.SharedUI.ProgressBar4.Value = 10;
			Form1.SharedUI.ProgressBar4.Text = "10%";
			Thread.Sleep(30);
			Form1.SharedUI.ProgressBar4.Value = 15;
			Form1.SharedUI.ProgressBar4.Text = "15%";
			Thread.Sleep(30);
			Form1.SharedUI.ProgressBar4.Value = 20;
			Form1.SharedUI.ProgressBar4.Text = "20%";
			Thread.Sleep(30);
			Form1.SharedUI.ProgressBar4.Value = 25;
			Form1.SharedUI.ProgressBar4.Text = "25%";
			Thread.Sleep(30);
			Form1.SharedUI.ProgressBar4.Value = 30;
			Form1.SharedUI.ProgressBar4.Text = "30%";
			Thread.Sleep(30);
			Fastboot.ExecuteFastbootCommand(Fastboot.FormFastbootCommand("erase modemst1", new string[0]));
			Form1.SharedUI.ProgressBar4.Value = 35;
			Form1.SharedUI.ProgressBar4.Text = "35%";
			Thread.Sleep(30);
			Form1.SharedUI.ProgressBar4.Value = 40;
			Form1.SharedUI.ProgressBar4.Text = "40%";
			Thread.Sleep(30);
			Form1.SharedUI.ProgressBar4.Value = 45;
			Form1.SharedUI.ProgressBar4.Text = "45%";
			Thread.Sleep(30);
			Form1.SharedUI.ProgressBar4.Value = 50;
			Form1.SharedUI.ProgressBar4.Text = "50%";
			Thread.Sleep(30);
			Form1.SharedUI.ProgressBar4.Value = 55;
			Form1.SharedUI.ProgressBar4.Text = "55%";
			Thread.Sleep(30);
			Form1.SharedUI.ProgressBar4.Value = 60;
			Form1.SharedUI.ProgressBar4.Text = "60%";
			Thread.Sleep(30);
			Form1.SharedUI.ProgressBar4.Value = 65;
			Form1.SharedUI.ProgressBar4.Text = "65%";
			Thread.Sleep(30);
			Form1.SharedUI.ProgressBar4.Value = 70;
			Form1.SharedUI.ProgressBar4.Text = "70%";
			Thread.Sleep(30);
			Fastboot.ExecuteFastbootCommand(Fastboot.FormFastbootCommand("erase modemst2", new string[0]));
			Form1.SharedUI.ProgressBar4.Value = 75;
			Form1.SharedUI.ProgressBar4.Text = "75%";
			Thread.Sleep(30);
			Form1.SharedUI.ProgressBar4.Value = 80;
			Form1.SharedUI.ProgressBar4.Text = "80%";
			Thread.Sleep(30);
			Form1.SharedUI.ProgressBar4.Value = 85;
			Form1.SharedUI.ProgressBar4.Text = "85%";
			Thread.Sleep(30);
			Form1.SharedUI.ProgressBar4.Value = 90;
			Form1.SharedUI.ProgressBar4.Text = "90%";
			Thread.Sleep(30);
			Form1.SharedUI.ProgressBar4.Value = 95;
			Form1.SharedUI.ProgressBar4.Text = "95%";
			Thread.Sleep(30);
			Form1.SharedUI.ProgressBar4.Value = 100;
			Form1.SharedUI.ProgressBar4.Text = "100%";
			SerialCOM.MSL = "DISREAD";
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringO);
			Form1.SharedUI.RichTextBox1.Update();
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Reboot Device : ");
			Form1.SharedUI.ProgressBar1.Text = "Rebooting...";
			Fastboot.ExecuteFastbootCommand(Fastboot.FormFastbootCommand("reboot", new string[0]));
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringO);
			Form1.SharedUI.RichTextBox1.Update();
			finsh();
		}
		else
		{
			string directory2 = ClassDevronix.CWQ + tmpWinrarr;
			try
			{
				MyProject.Computer.FileSystem.DeleteDirectory(directory2, DeleteDirectoryOption.DeleteAllContents);
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ProjectData.ClearProjectError();
			}
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringF);
			Form1.SharedUI.RichTextBox1.Update();
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Reboot Device : ");
			Form1.SharedUI.ProgressBar1.Text = "Rebooting...";
			Fastboot.ExecuteFastbootCommand(Fastboot.FormFastbootCommand("reboot", new string[0]));
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringO);
			Form1.SharedUI.RichTextBox1.Update();
			finshonly();
		}
	}

	private void Guna2Button40_Click(object sender, EventArgs e)
	{
		start();
		ThreadNew = new Thread(method_adb31);
		ThreadNew.Start();
	}

    private void CKAUTO_CONN_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void CheckBox2_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void Guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void Guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void Guna2RadioButton1_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void Guna2RadioButton2_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void Guna2RadioButton4_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void txtqcn_TextChanged(object sender, EventArgs e)
    {

    }
}
