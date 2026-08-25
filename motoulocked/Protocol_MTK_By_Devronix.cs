using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp;
using FireSharp.Interfaces;
using FireSharp.Response;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;

using motoulocked.core;
using motoulocked.motoulocked;
using motoulocked.mtkclient2;
using motoulocked.mtkclient2.library;
using motoulocked.mtkclient2.MTK.Client;
using motoulocked.mtkclient2.MTK.Client.Scatter;
using motoulocked.mtkclient2.Tasks;
using motoulocked.My;
using Properties;

namespace motoulocked;

[DesignerGenerated]
public class Protocol_MTK_By_Devronix : Form
{
	[CompilerGenerated]
	internal sealed class _Closure_0024__364_002D0
	{
		public string _0024VB_0024Local_folder;

		public _Closure_0024__364_002D0(_Closure_0024__364_002D0 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_folder = arg0._0024VB_0024Local_folder;
			}
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__364_002D1
	{
		public CancellationToken _0024VB_0024Local_token;

		public _Closure_0024__364_002D0 _0024VB_0024NonLocal__0024VB_0024Closure_2;

		public _Closure_0024__364_002D1(_Closure_0024__364_002D1 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_token = arg0._0024VB_0024Local_token;
			}
		}

		[SpecialName]
		internal Task _Lambda_0024__0()
		{
			return MtkTask.Read2(_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_folder, _0024VB_0024Local_token);
		}

		[SpecialName]
		internal Task _Lambda_0024__1()
		{
			return MtkTask.InitAsync2(_0024VB_0024Local_token);
		}

		[SpecialName]
		internal Task _Lambda_0024__2()
		{
			return MtkTask.Read2(_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_folder, _0024VB_0024Local_token);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__365_002D0
	{
		public CancellationToken _0024VB_0024Local_token;

		public _Closure_0024__365_002D0(_Closure_0024__365_002D0 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_token = arg0._0024VB_0024Local_token;
			}
		}

		[SpecialName]
		internal Task _Lambda_0024__0()
		{
			return MtkTask.Erase(_0024VB_0024Local_token);
		}

		[SpecialName]
		internal Task _Lambda_0024__1()
		{
			return MtkTask.InitAsync2(_0024VB_0024Local_token);
		}

		[SpecialName]
		internal Task _Lambda_0024__2()
		{
			return MtkTask.Erase(_0024VB_0024Local_token);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__365_002D1
	{
		public CancellationToken _0024VB_0024Local_token;

		public _Closure_0024__365_002D1(_Closure_0024__365_002D1 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_token = arg0._0024VB_0024Local_token;
			}
		}

		[SpecialName]
		internal Task _Lambda_0024__4()
		{
			return MtkTask.Erase(_0024VB_0024Local_token);
		}

		[SpecialName]
		internal Task _Lambda_0024__5()
		{
			return MtkTask.InitAsync2(_0024VB_0024Local_token);
		}

		[SpecialName]
		internal Task _Lambda_0024__6()
		{
			return MtkTask.Erase(_0024VB_0024Local_token);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__366_002D0
	{
		public CancellationToken _0024VB_0024Local_token;

		public _Closure_0024__366_002D0(_Closure_0024__366_002D0 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_token = arg0._0024VB_0024Local_token;
			}
		}

		[SpecialName]
		internal Task _Lambda_0024__0()
		{
			return MtkTask.Flash(_0024VB_0024Local_token);
		}

		[SpecialName]
		internal Task _Lambda_0024__1()
		{
			return MtkTask.InitAsync2(_0024VB_0024Local_token);
		}

		[SpecialName]
		internal Task _Lambda_0024__2()
		{
			return MtkTask.Flash(_0024VB_0024Local_token);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__403_002D0
	{
		public CancellationToken _0024VB_0024Local_token;

		public _Closure_0024__403_002D0(_Closure_0024__403_002D0 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_token = arg0._0024VB_0024Local_token;
			}
		}

		[SpecialName]
		internal Task _Lambda_0024__0()
		{
			return MtkTask.Flash2(_0024VB_0024Local_token);
		}

		[SpecialName]
		internal Task _Lambda_0024__1()
		{
			return MtkTask.InitAsync2(_0024VB_0024Local_token);
		}

		[SpecialName]
		internal Task _Lambda_0024__2()
		{
			return MtkTask.Flash2(_0024VB_0024Local_token);
		}
	}

	private IContainer components;

	[CompilerGenerated]
	[AccessedThroughProperty("DataViewmtk")]
	private DataGridView _DataViewmtk;

	[CompilerGenerated]
	[AccessedThroughProperty("BtnIdentify")]
	private Guna2Button _BtnIdentify;

	[CompilerGenerated]
	[AccessedThroughProperty("BtnEMI1")]
	private Guna2Button _BtnEMI1;

	[CompilerGenerated]
	[AccessedThroughProperty("buttonreboot")]
	private Guna2Button _buttonreboot;

	[CompilerGenerated]
	[AccessedThroughProperty("Timer1")]
	private System.Windows.Forms.Timer _Timer1;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2GroupBox4")]
	private Guna2GroupBox _Guna2GroupBox4;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2Button2")]
	private Guna2Button _Guna2Button2;

	[CompilerGenerated]
	[AccessedThroughProperty("MaterialButton30")]
	private Guna2Button _MaterialButton30;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2Button1")]
	private Guna2Button _Guna2Button1;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2Button5")]
	private Guna2Button _Guna2Button5;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2Button3")]
	private Guna2Button _Guna2Button3;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2CheckBox1")]
	private Guna2CheckBox _Guna2CheckBox1;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2CheckBox2")]
	private Guna2CheckBox _Guna2CheckBox2;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2Button8")]
	private Guna2Button _Guna2Button8;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2Button11")]
	private Guna2Button _Guna2Button11;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2Button4")]
	private Guna2Button _Guna2Button4;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2Button6")]
	private Guna2Button _Guna2Button6;

	[CompilerGenerated]
	[AccessedThroughProperty("MaterialButton41")]
	private Guna2Button _MaterialButton41;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2Button12")]
	private Guna2Button _Guna2Button12;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2Button10")]
	private Guna2Button _Guna2Button10;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2Button13")]
	private Guna2Button _Guna2Button13;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2Button9")]
	private Guna2Button _Guna2Button9;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2Button7")]
	private Guna2Button _Guna2Button7;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2CheckBox3")]
	private Guna2CheckBox _Guna2CheckBox3;

	[CompilerGenerated]
	[AccessedThroughProperty("BtnFlash")]
	private Guna2Button _BtnFlash;

	[CompilerGenerated]
	[AccessedThroughProperty("BtnScatter")]
	private Guna2Button _BtnScatter;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2Button14")]
	private Guna2Button _Guna2Button14;

	public static Protocol_MTK_By_Devronix SharedUI;

	public static bool isMTKClientRunning = false;

	private string ProgressBar4Valis;

	private string TextBox7;

	private string ThisLocation;

	private string MSL;

	public static CancellationTokenSource cts = new CancellationTokenSource();

	private string idproos;

	private string startTime;

	private string FileDelete2;

	private string String_24;

	public static string String_35;

	private Thread String_28;

	public static string String_75;

	private string Seva_Coun;

	private bool Boolean_2;

	public static string hexx;

	public static string hexxnew;

	private string log;
	/*
	[field: AccessedThroughProperty("ComboPort")]
	public  ComboBox ComboPort
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Guna2VScrollBar2")]
	internal  Guna2VScrollBar Guna2VScrollBar2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal  DataGridView DataViewmtk
	{
		[CompilerGenerated]
		get
		{
			return _DataViewmtk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DataGridViewCellEventHandler value2 = DataViewmtk_CellContentClick;
			DataGridViewCellFormattingEventHandler value3 = DataViewmtk_CellFormatting;
			DataGridView dataViewmtk = _DataViewmtk;
			if (dataViewmtk != null)
			{
				dataViewmtk.CellContentClick -= value2;
				dataViewmtk.CellFormatting -= value3;
			}
			_DataViewmtk = value;
			dataViewmtk = _DataViewmtk;
			if (dataViewmtk != null)
			{
				dataViewmtk.CellContentClick += value2;
				dataViewmtk.CellFormatting += value3;
			}
		}
	}

	internal  Guna2Button BtnIdentify
	{
		[CompilerGenerated]
		get
		{
			return _BtnIdentify;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = BtnIdentify_Click;
			Guna2Button btnIdentify = _BtnIdentify;
			if (btnIdentify != null)
			{
				btnIdentify.Click -= value2;
			}
			_BtnIdentify = value;
			btnIdentify = _BtnIdentify;
			if (btnIdentify != null)
			{
				btnIdentify.Click += value2;
			}
		}
	}

	internal  Guna2Button BtnEMI1
	{
		[CompilerGenerated]
		get
		{
			return _BtnEMI1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = BtnEMI1_Click;
			Guna2Button btnEMI = _BtnEMI1;
			if (btnEMI != null)
			{
				btnEMI.Click -= value2;
			}
			_BtnEMI1 = value;
			btnEMI = _BtnEMI1;
			if (btnEMI != null)
			{
				btnEMI.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("CkBromReady")]
	public  CheckBox CkBromReady
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CkAutoUnsparse")]
	public  CheckBox CkAutoUnsparse
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal  Guna2Button buttonreboot
	{
		[CompilerGenerated]
		get
		{
			return _buttonreboot;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Guna2Button2_Click;
			Guna2Button guna2Button = _buttonreboot;
			if (guna2Button != null)
			{
				guna2Button.Click -= value2;
			}
			_buttonreboot = value;
			guna2Button = _buttonreboot;
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

	[field: AccessedThroughProperty("DataGridView1")]
	internal  DataGridView DataGridView1
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

	[field: AccessedThroughProperty("Column7")]
	internal  DataGridViewTextBoxColumn Column7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal  Guna2GroupBox Guna2GroupBox4
	{
		[CompilerGenerated]
		get
		{
			return _Guna2GroupBox4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Guna2GroupBox4_Click;
			Guna2GroupBox guna2GroupBox = _Guna2GroupBox4;
			if (guna2GroupBox != null)
			{
				guna2GroupBox.Click -= value2;
			}
			_Guna2GroupBox4 = value;
			guna2GroupBox = _Guna2GroupBox4;
			if (guna2GroupBox != null)
			{
				guna2GroupBox.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Guna2GroupBox1")]
	internal  Guna2GroupBox Guna2GroupBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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
			EventHandler value2 = Guna2Button2_Click_1;
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

	[field: AccessedThroughProperty("ComboBoxPreloader")]
	internal  Guna2ComboBox ComboBoxPreloader
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal  Guna2Button MaterialButton30
	{
		[CompilerGenerated]
		get
		{
			return _MaterialButton30;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = MaterialButton30_Click;
			Guna2Button materialButton = _MaterialButton30;
			if (materialButton != null)
			{
				materialButton.Click -= value2;
			}
			_MaterialButton30 = value;
			materialButton = _MaterialButton30;
			if (materialButton != null)
			{
				materialButton.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("ComboBoxSecurity")]
	internal  Guna2ComboBox ComboBoxSecurity
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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
			EventHandler value2 = Guna2Button1_Click_1;
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

	[field: AccessedThroughProperty("Guna2GroupBox2")]
	internal  Guna2GroupBox Guna2GroupBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	[field: AccessedThroughProperty("Guna2GroupBox6")]
	internal  Guna2GroupBox Guna2GroupBox6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TxtEMI")]
	internal  Guna2TextBox TxtEMI
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal  Guna2CheckBox Guna2CheckBox1
	{
		[CompilerGenerated]
		get
		{
			return _Guna2CheckBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Guna2CheckBox1_CheckedChanged;
			Guna2CheckBox guna2CheckBox = _Guna2CheckBox1;
			if (guna2CheckBox != null)
			{
				guna2CheckBox.CheckedChanged -= value2;
			}
			_Guna2CheckBox1 = value;
			guna2CheckBox = _Guna2CheckBox1;
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

	[field: AccessedThroughProperty("Guna2GroupBox7")]
	internal  Guna2GroupBox Guna2GroupBox7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Guna2ComboWipe")]
	internal  Guna2ComboBox Guna2ComboWipe
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	[field: AccessedThroughProperty("Guna2ComboMDM")]
	internal  Guna2ComboBox Guna2ComboMDM
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	[field: AccessedThroughProperty("ComboBoxRepair")]
	internal  Guna2ComboBox ComboBoxRepair
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	[field: AccessedThroughProperty("ComboBoxBoot")]
	internal  Guna2ComboBox ComboBoxBoot
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal  Guna2Button MaterialButton41
	{
		[CompilerGenerated]
		get
		{
			return _MaterialButton41;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = MaterialButton41_Click;
			Guna2Button materialButton = _MaterialButton41;
			if (materialButton != null)
			{
				materialButton.Click -= value2;
			}
			_MaterialButton41 = value;
			materialButton = _MaterialButton41;
			if (materialButton != null)
			{
				materialButton.Click += value2;
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

	[field: AccessedThroughProperty("TabPage1")]
	internal  TabPage TabPage1
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

	[field: AccessedThroughProperty("Guna2TextBox1")]
	internal  Guna2TextBox Guna2TextBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	[field: AccessedThroughProperty("Guna2TextBox2")]
	internal  Guna2TextBox Guna2TextBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column0")]
	internal  DataGridViewCheckBoxColumn Column0
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column3")]
	internal  DataGridViewTextBoxColumn Column3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("part")]
	internal  DataGridViewTextBoxColumn part
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column1")]
	internal  DataGridViewTextBoxColumn Column1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column2")]
	internal  DataGridViewTextBoxColumn Column2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column5")]
	internal  DataGridViewTextBoxColumn Column5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column4")]
	internal  DataGridViewTextBoxColumn Column4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column6")]
	internal  DataGridViewTextBoxColumn Column6
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

	[field: AccessedThroughProperty("Guna2CheckBox4")]
	internal  Guna2CheckBox Guna2CheckBox4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal  Guna2CheckBox Guna2CheckBox3
	{
		[CompilerGenerated]
		get
		{
			return _Guna2CheckBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Guna2CheckBox3_CheckedChanged;
			Guna2CheckBox guna2CheckBox = _Guna2CheckBox3;
			if (guna2CheckBox != null)
			{
				guna2CheckBox.CheckedChanged -= value2;
			}
			_Guna2CheckBox3 = value;
			guna2CheckBox = _Guna2CheckBox3;
			if (guna2CheckBox != null)
			{
				guna2CheckBox.CheckedChanged += value2;
			}
		}
	}

	internal  Guna2Button BtnFlash
	{
		[CompilerGenerated]
		get
		{
			return _BtnFlash;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Guna2Button17_Click;
			Guna2Button btnFlash = _BtnFlash;
			if (btnFlash != null)
			{
				btnFlash.Click -= value2;
			}
			_BtnFlash = value;
			btnFlash = _BtnFlash;
			if (btnFlash != null)
			{
				btnFlash.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("TxtScatter")]
	internal  Guna2TextBox TxtScatter
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal  Guna2Button BtnScatter
	{
		[CompilerGenerated]
		get
		{
			return _BtnScatter;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Guna2Button18_Click;
			Guna2Button btnScatter = _BtnScatter;
			if (btnScatter != null)
			{
				btnScatter.Click -= value2;
			}
			_BtnScatter = value;
			btnScatter = _BtnScatter;
			if (btnScatter != null)
			{
				btnScatter.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Guna2GroupBox3")]
	internal  Guna2GroupBox Guna2GroupBox3
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

	[field: AccessedThroughProperty("DataGridFlash")]
	internal  DataGridView DataGridFlash
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn4")]
	internal  DataGridViewTextBoxColumn DataGridViewTextBoxColumn4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn5")]
	internal  DataGridViewTextBoxColumn DataGridViewTextBoxColumn5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn6")]
	internal  DataGridViewTextBoxColumn DataGridViewTextBoxColumn6
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

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn8")]
	internal  DataGridViewTextBoxColumn DataGridViewTextBoxColumn8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn9")]
	internal  DataGridViewTextBoxColumn DataGridViewTextBoxColumn9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Guna2CheckBox6")]
	internal  Guna2CheckBox Guna2CheckBox6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Guna2CheckBox5")]
	internal  Guna2CheckBox Guna2CheckBox5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Guna2GroupBox8")]
	internal  Guna2GroupBox Guna2GroupBox8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ComboBoxkg")]
	internal  Guna2ComboBox ComboBoxkg
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

	[field: AccessedThroughProperty("PictureBox14")]
	internal  PictureBox PictureBox14
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}
	*/
	public ComboBox ComboPort;

	public CheckBox CkBromReady;

	public CheckBox CkAutoUnsparse;
    internal Guna2VScrollBar Guna2VScrollBar2;
    internal DataGridView DataViewmtk;
    internal Guna2Button BtnIdentify;
    internal Guna2Button BtnEMI1;
    internal Guna2Button buttonreboot;
    internal System.Windows.Forms.Timer Timer1;
    internal DataGridView DataGridView1;
    internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
    internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn2;
    internal DataGridViewTextBoxColumn Column7;
    internal Guna2GroupBox Guna2GroupBox4;
    internal Guna2GroupBox Guna2GroupBox1;
    internal Guna2Button Guna2Button2;
    internal Guna2ComboBox ComboBoxPreloader;
    internal Guna2Button MaterialButton30;
    internal Guna2ComboBox ComboBoxSecurity;
    internal Guna2Button Guna2Button1;
    internal Guna2GroupBox Guna2GroupBox2;
    internal Guna2Button Guna2Button5;
    internal Guna2Button Guna2Button3;
    internal motoulocked.Controls.TabControlExt TabControlExt1;
    internal TabPage TabPage2;
    internal TabPage TabPage4;
    internal Guna2GroupBox Guna2GroupBox6;
    internal Guna2TextBox TxtEMI;
    internal Guna2CheckBox Guna2CheckBox1;
    internal Guna2CheckBox Guna2CheckBox2;
    internal Guna2GroupBox Guna2GroupBox7;
    internal Guna2ComboBox Guna2ComboWipe;
    internal Guna2Button Guna2Button8;
    internal Guna2ComboBox Guna2ComboMDM;
    internal Guna2Button Guna2Button11;
    internal Guna2ComboBox ComboBoxRepair;
    internal Guna2Button Guna2Button4;
    internal Guna2Button Guna2Button6;
    internal Guna2ComboBox ComboBoxBoot;
    internal Guna2Button MaterialButton41;
    internal Guna2Button Guna2Button12;
    internal Guna2Button Guna2Button10;
    internal Guna2Button Guna2Button13;
    internal TabPage TabPage1;
    internal Guna2Button Guna2Button9;
    internal Guna2TextBox Guna2TextBox1;
    internal Guna2Button Guna2Button7;
    internal Guna2TextBox Guna2TextBox2;
    internal DataGridViewCheckBoxColumn Column0;
    internal DataGridViewTextBoxColumn Column3;
    internal DataGridViewTextBoxColumn part;
    internal DataGridViewTextBoxColumn Column1;
    internal DataGridViewTextBoxColumn Column2;
    internal DataGridViewTextBoxColumn Column5;
    internal DataGridViewTextBoxColumn Column4;
    internal DataGridViewTextBoxColumn Column6;
    internal Guna2GroupBox Guna2GroupBox5;
    internal Guna2CheckBox Guna2CheckBox4;
    internal Guna2CheckBox Guna2CheckBox3;
    internal Guna2Button BtnFlash;
    internal Guna2TextBox TxtScatter;
    internal Guna2Button BtnScatter;
    internal Guna2GroupBox Guna2GroupBox3;
    internal Guna2VScrollBar Guna2VScrollBar1;
    internal DataGridView DataGridFlash;
    internal DataGridViewCheckBoxColumn DataGridViewCheckBoxColumn1;
    internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn3;
    internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn4;
    internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn5;
    internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn6;
    internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn7;
    internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn8;
    internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn9;
    internal Guna2CheckBox Guna2CheckBox6;
    internal Guna2CheckBox Guna2CheckBox5;
    internal Guna2GroupBox Guna2GroupBox8;
    internal Guna2ComboBox ComboBoxkg;
    internal Guna2Button Guna2Button14;
    internal PictureBox PictureBox14;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle45 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle46 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle47 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Protocol_MTK_By_Devronix));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle48 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle49 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle50 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle51 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle52 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle53 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle54 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle55 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CkBromReady = new System.Windows.Forms.CheckBox();
            this.CkAutoUnsparse = new System.Windows.Forms.CheckBox();
            this.ComboPort = new System.Windows.Forms.ComboBox();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.BtnEMI1 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2GroupBox6 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.TxtEMI = new Guna.UI2.WinForms.Guna2TextBox();
            this.Guna2CheckBox1 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.TabControlExt1 = new motoulocked.Controls.TabControlExt();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.Guna2GroupBox8 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.Guna2Button7 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.Guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.Guna2Button9 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2GroupBox7 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.ComboBoxkg = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Guna2Button14 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2ComboWipe = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Guna2Button8 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2ComboMDM = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Guna2Button11 = new Guna.UI2.WinForms.Guna2Button();
            this.ComboBoxRepair = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
            this.ComboBoxBoot = new Guna.UI2.WinForms.Guna2ComboBox();
            this.MaterialButton41 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2Button12 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2Button10 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2Button13 = new Guna.UI2.WinForms.Guna2Button();
            this.TabPage4 = new System.Windows.Forms.TabPage();
            this.PictureBox14 = new System.Windows.Forms.PictureBox();
            this.Guna2GroupBox4 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.Guna2CheckBox2 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.Guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.ComboBoxPreloader = new Guna.UI2.WinForms.Guna2ComboBox();
            this.MaterialButton30 = new Guna.UI2.WinForms.Guna2Button();
            this.ComboBoxSecurity = new Guna.UI2.WinForms.Guna2ComboBox();
            this.buttonreboot = new Guna.UI2.WinForms.Guna2Button();
            this.BtnIdentify = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.Guna2VScrollBar2 = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.DataViewmtk = new System.Windows.Forms.DataGridView();
            this.Column0 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.part = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.Guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.Guna2GroupBox5 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.Guna2CheckBox6 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.Guna2CheckBox5 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.Guna2CheckBox4 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.Guna2CheckBox3 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.BtnFlash = new Guna.UI2.WinForms.Guna2Button();
            this.TxtScatter = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnScatter = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.Guna2VScrollBar1 = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.DataGridFlash = new System.Windows.Forms.DataGridView();
            this.DataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.Guna2GroupBox6.SuspendLayout();
            this.TabControlExt1.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.Guna2GroupBox8.SuspendLayout();
            this.Guna2GroupBox7.SuspendLayout();
            this.TabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox14)).BeginInit();
            this.Guna2GroupBox4.SuspendLayout();
            this.Guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataViewmtk)).BeginInit();
            this.Guna2GroupBox2.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.Guna2GroupBox5.SuspendLayout();
            this.Guna2GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridFlash)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.AllowUserToResizeColumns = false;
            this.DataGridView1.AllowUserToResizeRows = false;
            this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridView1.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle45.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle45.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle45.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle45.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle45.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle45.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle45;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewTextBoxColumn1,
            this.DataGridViewTextBoxColumn2,
            this.Column7});
            dataGridViewCellStyle46.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle46.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle46.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle46.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle46.SelectionBackColor = System.Drawing.Color.FromArgb(0, 85, 207);
            dataGridViewCellStyle46.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle46.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView1.DefaultCellStyle = dataGridViewCellStyle46;
            this.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.DataGridView1.EnableHeadersVisualStyles = false;
            this.DataGridView1.GridColor = System.Drawing.Color.White;
            this.DataGridView1.Location = new System.Drawing.Point(471, 369);
            this.DataGridView1.MultiSelect = false;
            this.DataGridView1.Name = "DataGridView1";
            dataGridViewCellStyle47.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle47.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle47.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle47.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle47.SelectionBackColor = System.Drawing.Color.FromArgb(0, 85, 207);
            dataGridViewCellStyle47.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle47.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle47;
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.Size = new System.Drawing.Size(10, 10);
            this.DataGridView1.TabIndex = 514;
            this.DataGridView1.Visible = false;
            // 
            // DataGridViewTextBoxColumn1
            // 
            this.DataGridViewTextBoxColumn1.HeaderText = "Partition Name";
            this.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
            this.DataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn2
            // 
            this.DataGridViewTextBoxColumn2.HeaderText = "PathFile";
            this.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Size";
            this.Column7.Name = "Column7";
            // 
            // CkBromReady
            // 
            this.CkBromReady.AutoSize = true;
            this.CkBromReady.Location = new System.Drawing.Point(2000, 2000);
            this.CkBromReady.Name = "CkBromReady";
            this.CkBromReady.Size = new System.Drawing.Size(84, 17);
            this.CkBromReady.TabIndex = 404;
            this.CkBromReady.Text = "Brom Ready";
            this.CkBromReady.UseVisualStyleBackColor = true;
            this.CkBromReady.Visible = false;
            // 
            // CkAutoUnsparse
            // 
            this.CkAutoUnsparse.AutoSize = true;
            this.CkAutoUnsparse.Checked = true;
            this.CkAutoUnsparse.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CkAutoUnsparse.Location = new System.Drawing.Point(1763, 604);
            this.CkAutoUnsparse.Name = "CkAutoUnsparse";
            this.CkAutoUnsparse.Size = new System.Drawing.Size(15, 14);
            this.CkAutoUnsparse.TabIndex = 460;
            this.CkAutoUnsparse.UseVisualStyleBackColor = true;
            this.CkAutoUnsparse.Visible = false;
            // 
            // ComboPort
            // 
            this.ComboPort.FormattingEnabled = true;
            this.ComboPort.Location = new System.Drawing.Point(2000, 2000);
            this.ComboPort.Name = "ComboPort";
            this.ComboPort.Size = new System.Drawing.Size(10, 21);
            this.ComboPort.TabIndex = 467;
            this.ComboPort.Visible = false;
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 1;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // BtnEMI1
            // 
            this.BtnEMI1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEMI1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.BtnEMI1.BorderRadius = 4;
            this.BtnEMI1.BorderThickness = 2;
            this.BtnEMI1.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnEMI1.CheckedState.FillColor = System.Drawing.Color.LightGray;
            this.BtnEMI1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.BtnEMI1.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
            this.BtnEMI1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.BtnEMI1.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.BtnEMI1.Enabled = false;
            this.BtnEMI1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.BtnEMI1.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEMI1.ForeColor = System.Drawing.Color.White;
            this.BtnEMI1.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.BtnEMI1.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.BtnEMI1.Image = global::Properties.Resources.search_in_folder;
            this.BtnEMI1.ImageSize = new System.Drawing.Size(25, 25);
            this.BtnEMI1.Location = new System.Drawing.Point(443, 7);
            this.BtnEMI1.Name = "BtnEMI1";
            this.BtnEMI1.PressedColor = System.Drawing.Color.Empty;
            this.BtnEMI1.Size = new System.Drawing.Size(37, 26);
            this.BtnEMI1.TabIndex = 499;
            this.BtnEMI1.TextFormatNoPrefix = true;
            this.BtnEMI1.Click += new System.EventHandler(this.BtnEMI1_Click);
            // 
            // Guna2GroupBox6
            // 
            this.Guna2GroupBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2GroupBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Guna2GroupBox6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2GroupBox6.BorderRadius = 6;
            this.Guna2GroupBox6.Controls.Add(this.TxtEMI);
            this.Guna2GroupBox6.Controls.Add(this.Guna2CheckBox1);
            this.Guna2GroupBox6.Controls.Add(this.BtnEMI1);
            this.Guna2GroupBox6.Cursor = System.Windows.Forms.Cursors.Default;
            this.Guna2GroupBox6.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2GroupBox6.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.Guna2GroupBox6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2GroupBox6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Guna2GroupBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Guna2GroupBox6.Location = new System.Drawing.Point(4, 4);
            this.Guna2GroupBox6.Name = "Guna2GroupBox6";
            this.Guna2GroupBox6.ShadowDecoration.BorderRadius = 9;
            this.Guna2GroupBox6.ShadowDecoration.Color = System.Drawing.Color.White;
            this.Guna2GroupBox6.ShadowDecoration.Depth = 15;
            this.Guna2GroupBox6.Size = new System.Drawing.Size(488, 41);
            this.Guna2GroupBox6.TabIndex = 527;
            // 
            // TxtEMI
            // 
            this.TxtEMI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtEMI.Animated = true;
            this.TxtEMI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TxtEMI.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.TxtEMI.BorderRadius = 5;
            this.TxtEMI.BorderThickness = 2;
            this.TxtEMI.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtEMI.DefaultText = "";
            this.TxtEMI.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.TxtEMI.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.TxtEMI.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.TxtEMI.DisabledState.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.TxtEMI.Enabled = false;
            this.TxtEMI.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.TxtEMI.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtEMI.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEMI.ForeColor = System.Drawing.Color.White;
            this.TxtEMI.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.TxtEMI.Location = new System.Drawing.Point(88, 7);
            this.TxtEMI.Name = "TxtEMI";
            this.TxtEMI.PasswordChar = '\0';
            this.TxtEMI.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.TxtEMI.PlaceholderText = "Preloader | EMI File";
            this.TxtEMI.SelectedText = "";
            this.TxtEMI.ShadowDecoration.Color = System.Drawing.Color.DimGray;
            this.TxtEMI.ShadowDecoration.Depth = 15;
            this.TxtEMI.Size = new System.Drawing.Size(346, 26);
            this.TxtEMI.TabIndex = 524;
            this.TxtEMI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtEMI.TextChanged += new System.EventHandler(this.TxtEMI_TextChanged);
            // 
            // Guna2CheckBox1
            // 
            this.Guna2CheckBox1.AutoSize = true;
            this.Guna2CheckBox1.BackColor = System.Drawing.Color.Transparent;
            this.Guna2CheckBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2CheckBox1.CheckedState.BorderRadius = 3;
            this.Guna2CheckBox1.CheckedState.BorderThickness = 1;
            this.Guna2CheckBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2CheckBox1.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2CheckBox1.ForeColor = System.Drawing.Color.White;
            this.Guna2CheckBox1.Location = new System.Drawing.Point(10, 10);
            this.Guna2CheckBox1.Name = "Guna2CheckBox1";
            this.Guna2CheckBox1.Size = new System.Drawing.Size(74, 21);
            this.Guna2CheckBox1.TabIndex = 522;
            this.Guna2CheckBox1.Text = "Custom";
            this.Guna2CheckBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2CheckBox1.UncheckedState.BorderRadius = 3;
            this.Guna2CheckBox1.UncheckedState.BorderThickness = 1;
            this.Guna2CheckBox1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2CheckBox1.UseVisualStyleBackColor = false;
            this.Guna2CheckBox1.CheckedChanged += new System.EventHandler(this.Guna2CheckBox1_CheckedChanged);
            // 
            // TabControlExt1
            // 
            this.TabControlExt1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TabControlExt1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.TabControlExt1.CloseBtnColor = System.Drawing.Color.White;
            this.TabControlExt1.Controls.Add(this.TabPage2);
            this.TabControlExt1.Controls.Add(this.TabPage4);
            this.TabControlExt1.Controls.Add(this.TabPage1);
            this.TabControlExt1.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControlExt1.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.TabControlExt1.HeadSelectedBackColor = System.Drawing.Color.FromArgb(0, 85, 207);
            this.TabControlExt1.HeadSelectedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.TabControlExt1.IsShowCloseBtn = false;
            this.TabControlExt1.ItemSize = new System.Drawing.Size(0, 26);
            this.TabControlExt1.Location = new System.Drawing.Point(4, 51);
            this.TabControlExt1.Name = "TabControlExt1";
            this.TabControlExt1.SelectedIndex = 0;
            this.TabControlExt1.Size = new System.Drawing.Size(488, 478);
            this.TabControlExt1.TabIndex = 526;
            this.TabControlExt1.TabTextColor = System.Drawing.Color.White;
            this.TabControlExt1.UncloseTabIndexs = new int[0];
            // 
            // TabPage2
            // 
            this.TabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TabPage2.Controls.Add(this.Guna2GroupBox8);
            this.TabPage2.Controls.Add(this.Guna2GroupBox7);
            this.TabPage2.Location = new System.Drawing.Point(4, 30);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(480, 444);
            this.TabPage2.TabIndex = 0;
            this.TabPage2.Text = "Services";
            // 
            // Guna2GroupBox8
            // 
            this.Guna2GroupBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2GroupBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Guna2GroupBox8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2GroupBox8.BorderRadius = 6;
            this.Guna2GroupBox8.Controls.Add(this.Guna2Button7);
            this.Guna2GroupBox8.Controls.Add(this.Guna2TextBox2);
            this.Guna2GroupBox8.Controls.Add(this.Guna2TextBox1);
            this.Guna2GroupBox8.Controls.Add(this.Guna2Button9);
            this.Guna2GroupBox8.Cursor = System.Windows.Forms.Cursors.Default;
            this.Guna2GroupBox8.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2GroupBox8.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.Guna2GroupBox8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2GroupBox8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Guna2GroupBox8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Guna2GroupBox8.Location = new System.Drawing.Point(6, 366);
            this.Guna2GroupBox8.Name = "Guna2GroupBox8";
            this.Guna2GroupBox8.ShadowDecoration.BorderRadius = 9;
            this.Guna2GroupBox8.ShadowDecoration.Color = System.Drawing.Color.White;
            this.Guna2GroupBox8.ShadowDecoration.Depth = 15;
            this.Guna2GroupBox8.Size = new System.Drawing.Size(468, 72);
            this.Guna2GroupBox8.TabIndex = 528;
            this.Guna2GroupBox8.Visible = false;
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
            this.Guna2Button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guna2Button7.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button7.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
            this.Guna2Button7.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button7.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.Guna2Button7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2Button7.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2Button7.ForeColor = System.Drawing.Color.White;
            this.Guna2Button7.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button7.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button7.Image = global::Properties.Resources.settings__1_;
            this.Guna2Button7.ImageSize = new System.Drawing.Size(22, 22);
            this.Guna2Button7.Location = new System.Drawing.Point(7, 39);
            this.Guna2Button7.Name = "Guna2Button7";
            this.Guna2Button7.PressedColor = System.Drawing.Color.Empty;
            this.Guna2Button7.Size = new System.Drawing.Size(304, 26);
            this.Guna2Button7.TabIndex = 516;
            this.Guna2Button7.Text = " Start Calculate Security";
            this.Guna2Button7.TextFormatNoPrefix = true;
            this.Guna2Button7.Click += new System.EventHandler(this.Guna2Button7_Click);
            // 
            // Guna2TextBox2
            // 
            this.Guna2TextBox2.Animated = true;
            this.Guna2TextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2TextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2TextBox2.BorderRadius = 5;
            this.Guna2TextBox2.BorderThickness = 2;
            this.Guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Guna2TextBox2.DefaultText = "";
            this.Guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.Guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.Guna2TextBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Guna2TextBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2TextBox2.ForeColor = System.Drawing.Color.White;
            this.Guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2TextBox2.Location = new System.Drawing.Point(317, 39);
            this.Guna2TextBox2.Name = "Guna2TextBox2";
            this.Guna2TextBox2.PasswordChar = '\0';
            this.Guna2TextBox2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.Guna2TextBox2.PlaceholderText = "Name File Unlock";
            this.Guna2TextBox2.SelectedText = "";
            this.Guna2TextBox2.ShadowDecoration.Color = System.Drawing.Color.DimGray;
            this.Guna2TextBox2.ShadowDecoration.Depth = 15;
            this.Guna2TextBox2.Size = new System.Drawing.Size(144, 26);
            this.Guna2TextBox2.TabIndex = 527;
            this.Guna2TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Guna2TextBox2.TextChanged += new System.EventHandler(this.Guna2TextBox2_TextChanged);
            // 
            // Guna2TextBox1
            // 
            this.Guna2TextBox1.Animated = true;
            this.Guna2TextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2TextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2TextBox1.BorderRadius = 5;
            this.Guna2TextBox1.BorderThickness = 2;
            this.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Guna2TextBox1.DefaultText = "";
            this.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.Guna2TextBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Guna2TextBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2TextBox1.ForeColor = System.Drawing.Color.White;
            this.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2TextBox1.Location = new System.Drawing.Point(7, 7);
            this.Guna2TextBox1.Name = "Guna2TextBox1";
            this.Guna2TextBox1.PasswordChar = '\0';
            this.Guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.Guna2TextBox1.PlaceholderText = "Selected Path";
            this.Guna2TextBox1.SelectedText = "";
            this.Guna2TextBox1.ShadowDecoration.Color = System.Drawing.Color.DimGray;
            this.Guna2TextBox1.ShadowDecoration.Depth = 15;
            this.Guna2TextBox1.Size = new System.Drawing.Size(411, 26);
            this.Guna2TextBox1.TabIndex = 525;
            this.Guna2TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Guna2Button9
            // 
            this.Guna2Button9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2Button9.BorderRadius = 4;
            this.Guna2Button9.BorderThickness = 2;
            this.Guna2Button9.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button9.CheckedState.FillColor = System.Drawing.Color.LightGray;
            this.Guna2Button9.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button9.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
            this.Guna2Button9.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button9.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.Guna2Button9.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2Button9.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2Button9.ForeColor = System.Drawing.Color.White;
            this.Guna2Button9.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button9.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button9.Image = global::Properties.Resources.search_in_folder;
            this.Guna2Button9.ImageSize = new System.Drawing.Size(25, 25);
            this.Guna2Button9.Location = new System.Drawing.Point(425, 7);
            this.Guna2Button9.Name = "Guna2Button9";
            this.Guna2Button9.PressedColor = System.Drawing.Color.Empty;
            this.Guna2Button9.Size = new System.Drawing.Size(37, 26);
            this.Guna2Button9.TabIndex = 526;
            this.Guna2Button9.TextFormatNoPrefix = true;
            this.Guna2Button9.Click += new System.EventHandler(this.Guna2Button9_Click);
            // 
            // Guna2GroupBox7
            // 
            this.Guna2GroupBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2GroupBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Guna2GroupBox7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2GroupBox7.BorderRadius = 6;
            this.Guna2GroupBox7.Controls.Add(this.ComboBoxkg);
            this.Guna2GroupBox7.Controls.Add(this.Guna2Button14);
            this.Guna2GroupBox7.Controls.Add(this.Guna2ComboWipe);
            this.Guna2GroupBox7.Controls.Add(this.Guna2Button8);
            this.Guna2GroupBox7.Controls.Add(this.Guna2ComboMDM);
            this.Guna2GroupBox7.Controls.Add(this.Guna2Button11);
            this.Guna2GroupBox7.Controls.Add(this.ComboBoxRepair);
            this.Guna2GroupBox7.Controls.Add(this.Guna2Button4);
            this.Guna2GroupBox7.Controls.Add(this.Guna2Button6);
            this.Guna2GroupBox7.Controls.Add(this.ComboBoxBoot);
            this.Guna2GroupBox7.Controls.Add(this.MaterialButton41);
            this.Guna2GroupBox7.Controls.Add(this.Guna2Button12);
            this.Guna2GroupBox7.Controls.Add(this.Guna2Button10);
            this.Guna2GroupBox7.Controls.Add(this.Guna2Button13);
            this.Guna2GroupBox7.Cursor = System.Windows.Forms.Cursors.Default;
            this.Guna2GroupBox7.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2GroupBox7.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.Guna2GroupBox7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2GroupBox7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Guna2GroupBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Guna2GroupBox7.Location = new System.Drawing.Point(6, 6);
            this.Guna2GroupBox7.Name = "Guna2GroupBox7";
            this.Guna2GroupBox7.ShadowDecoration.BorderRadius = 9;
            this.Guna2GroupBox7.ShadowDecoration.Color = System.Drawing.Color.White;
            this.Guna2GroupBox7.ShadowDecoration.Depth = 15;
            this.Guna2GroupBox7.Size = new System.Drawing.Size(468, 348);
            this.Guna2GroupBox7.TabIndex = 515;
            // 
            // ComboBoxkg
            // 
            this.ComboBoxkg.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ComboBoxkg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ComboBoxkg.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.ComboBoxkg.BorderRadius = 4;
            this.ComboBoxkg.BorderThickness = 2;
            this.ComboBoxkg.Cursor = System.Windows.Forms.Cursors.Default;
            this.ComboBoxkg.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ComboBoxkg.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ComboBoxkg.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.ComboBoxkg.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxkg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxkg.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ComboBoxkg.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxkg.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxkg.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBoxkg.ForeColor = System.Drawing.Color.White;
            this.ComboBoxkg.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.ComboBoxkg.ItemHeight = 26;
            this.ComboBoxkg.Items.AddRange(new object[] {
            "Remove KG | Knox Samsung [New] ",
            "Remove KG | Knox Samsung [Old]"});
            this.ComboBoxkg.ItemsAppearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.ComboBoxkg.ItemsAppearance.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxkg.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.ComboBoxkg.Location = new System.Drawing.Point(202, 196);
            this.ComboBoxkg.MaxDropDownItems = 5;
            this.ComboBoxkg.MaxLength = 5;
            this.ComboBoxkg.Name = "ComboBoxkg";
            this.ComboBoxkg.Size = new System.Drawing.Size(260, 32);
            this.ComboBoxkg.StartIndex = 0;
            this.ComboBoxkg.TabIndex = 506;
            // 
            // Guna2Button14
            // 
            this.Guna2Button14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Guna2Button14.Animated = true;
            this.Guna2Button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2Button14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2Button14.BorderRadius = 4;
            this.Guna2Button14.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.Guna2Button14.BorderThickness = 2;
            this.Guna2Button14.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button14.CheckedState.FillColor = System.Drawing.Color.LightGray;
            this.Guna2Button14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guna2Button14.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button14.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
            this.Guna2Button14.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button14.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.Guna2Button14.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2Button14.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2Button14.ForeColor = System.Drawing.Color.White;
            this.Guna2Button14.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button14.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button14.Image = global::Properties.Resources.broom__1_;
            this.Guna2Button14.ImageSize = new System.Drawing.Size(23, 23);
            this.Guna2Button14.Location = new System.Drawing.Point(7, 196);
            this.Guna2Button14.Name = "Guna2Button14";
            this.Guna2Button14.PressedColor = System.Drawing.Color.Empty;
            this.Guna2Button14.Size = new System.Drawing.Size(189, 32);
            this.Guna2Button14.TabIndex = 505;
            this.Guna2Button14.Text = " Start ==>";
            this.Guna2Button14.TextFormatNoPrefix = true;
            this.Guna2Button14.Click += new System.EventHandler(this.Guna2Button14_Click);
            // 
            // Guna2ComboWipe
            // 
            this.Guna2ComboWipe.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Guna2ComboWipe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2ComboWipe.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2ComboWipe.BorderRadius = 4;
            this.Guna2ComboWipe.BorderThickness = 2;
            this.Guna2ComboWipe.Cursor = System.Windows.Forms.Cursors.Default;
            this.Guna2ComboWipe.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2ComboWipe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2ComboWipe.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.Guna2ComboWipe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Guna2ComboWipe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Guna2ComboWipe.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2ComboWipe.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Guna2ComboWipe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Guna2ComboWipe.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Guna2ComboWipe.ForeColor = System.Drawing.Color.White;
            this.Guna2ComboWipe.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2ComboWipe.ItemHeight = 26;
            this.Guna2ComboWipe.Items.AddRange(new object[] {
            "Factory Reset [Safe]",
            "Factory Reset [Not Safe]"});
            this.Guna2ComboWipe.ItemsAppearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2ComboWipe.ItemsAppearance.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2ComboWipe.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2ComboWipe.Location = new System.Drawing.Point(202, 158);
            this.Guna2ComboWipe.MaxDropDownItems = 5;
            this.Guna2ComboWipe.MaxLength = 5;
            this.Guna2ComboWipe.Name = "Guna2ComboWipe";
            this.Guna2ComboWipe.Size = new System.Drawing.Size(260, 32);
            this.Guna2ComboWipe.StartIndex = 0;
            this.Guna2ComboWipe.TabIndex = 504;
            // 
            // Guna2Button8
            // 
            this.Guna2Button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Guna2Button8.Animated = true;
            this.Guna2Button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2Button8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2Button8.BorderRadius = 4;
            this.Guna2Button8.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.Guna2Button8.BorderThickness = 2;
            this.Guna2Button8.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button8.CheckedState.FillColor = System.Drawing.Color.LightGray;
            this.Guna2Button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guna2Button8.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button8.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
            this.Guna2Button8.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button8.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.Guna2Button8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2Button8.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2Button8.ForeColor = System.Drawing.Color.White;
            this.Guna2Button8.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button8.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button8.Image = global::Properties.Resources.broom__1_;
            this.Guna2Button8.ImageSize = new System.Drawing.Size(23, 23);
            this.Guna2Button8.Location = new System.Drawing.Point(7, 158);
            this.Guna2Button8.Name = "Guna2Button8";
            this.Guna2Button8.PressedColor = System.Drawing.Color.Empty;
            this.Guna2Button8.Size = new System.Drawing.Size(189, 32);
            this.Guna2Button8.TabIndex = 503;
            this.Guna2Button8.Text = " Start ==>";
            this.Guna2Button8.TextFormatNoPrefix = true;
            this.Guna2Button8.Click += new System.EventHandler(this.Guna2Button8_Click);
            // 
            // Guna2ComboMDM
            // 
            this.Guna2ComboMDM.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Guna2ComboMDM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2ComboMDM.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2ComboMDM.BorderRadius = 4;
            this.Guna2ComboMDM.BorderThickness = 2;
            this.Guna2ComboMDM.Cursor = System.Windows.Forms.Cursors.Default;
            this.Guna2ComboMDM.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2ComboMDM.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2ComboMDM.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.Guna2ComboMDM.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Guna2ComboMDM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Guna2ComboMDM.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2ComboMDM.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Guna2ComboMDM.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Guna2ComboMDM.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Guna2ComboMDM.ForeColor = System.Drawing.Color.White;
            this.Guna2ComboMDM.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2ComboMDM.ItemHeight = 26;
            this.Guna2ComboMDM.Items.AddRange(new object[] {
            "Remove MDM Infinix",
            "Remove MDM Tecno",
            "Remove MDM Samsung"});
            this.Guna2ComboMDM.ItemsAppearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2ComboMDM.ItemsAppearance.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2ComboMDM.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2ComboMDM.Location = new System.Drawing.Point(202, 234);
            this.Guna2ComboMDM.MaxDropDownItems = 5;
            this.Guna2ComboMDM.MaxLength = 5;
            this.Guna2ComboMDM.Name = "Guna2ComboMDM";
            this.Guna2ComboMDM.Size = new System.Drawing.Size(260, 32);
            this.Guna2ComboMDM.StartIndex = 0;
            this.Guna2ComboMDM.TabIndex = 501;
            // 
            // Guna2Button11
            // 
            this.Guna2Button11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Guna2Button11.Animated = true;
            this.Guna2Button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2Button11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2Button11.BorderRadius = 4;
            this.Guna2Button11.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.Guna2Button11.BorderThickness = 2;
            this.Guna2Button11.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button11.CheckedState.FillColor = System.Drawing.Color.LightGray;
            this.Guna2Button11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guna2Button11.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button11.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
            this.Guna2Button11.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button11.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.Guna2Button11.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2Button11.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2Button11.ForeColor = System.Drawing.Color.White;
            this.Guna2Button11.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button11.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button11.Image = global::Properties.Resources.video;
            this.Guna2Button11.Location = new System.Drawing.Point(7, 272);
            this.Guna2Button11.Name = "Guna2Button11";
            this.Guna2Button11.PressedColor = System.Drawing.Color.Empty;
            this.Guna2Button11.Size = new System.Drawing.Size(189, 32);
            this.Guna2Button11.TabIndex = 442;
            this.Guna2Button11.Text = " Start ==>";
            this.Guna2Button11.TextFormatNoPrefix = true;
            this.Guna2Button11.Click += new System.EventHandler(this.Guna2Button11_Click);
            // 
            // ComboBoxRepair
            // 
            this.ComboBoxRepair.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ComboBoxRepair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ComboBoxRepair.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.ComboBoxRepair.BorderRadius = 4;
            this.ComboBoxRepair.BorderThickness = 2;
            this.ComboBoxRepair.Cursor = System.Windows.Forms.Cursors.Default;
            this.ComboBoxRepair.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ComboBoxRepair.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ComboBoxRepair.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.ComboBoxRepair.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxRepair.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxRepair.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ComboBoxRepair.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxRepair.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxRepair.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBoxRepair.ForeColor = System.Drawing.Color.White;
            this.ComboBoxRepair.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.ComboBoxRepair.ItemHeight = 26;
            this.ComboBoxRepair.Items.AddRange(new object[] {
            "Repair Boot [Brom Mode]",
            "Force Brom [DM Mode]"});
            this.ComboBoxRepair.ItemsAppearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.ComboBoxRepair.ItemsAppearance.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxRepair.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.ComboBoxRepair.Location = new System.Drawing.Point(202, 310);
            this.ComboBoxRepair.MaxDropDownItems = 5;
            this.ComboBoxRepair.MaxLength = 5;
            this.ComboBoxRepair.Name = "ComboBoxRepair";
            this.ComboBoxRepair.Size = new System.Drawing.Size(260, 32);
            this.ComboBoxRepair.StartIndex = 0;
            this.ComboBoxRepair.TabIndex = 500;
            // 
            // Guna2Button4
            // 
            this.Guna2Button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Guna2Button4.Animated = true;
            this.Guna2Button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2Button4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2Button4.BorderRadius = 4;
            this.Guna2Button4.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.Guna2Button4.BorderThickness = 2;
            this.Guna2Button4.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button4.CheckedState.FillColor = System.Drawing.Color.LightGray;
            this.Guna2Button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guna2Button4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
            this.Guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button4.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.Guna2Button4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2Button4.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2Button4.ForeColor = System.Drawing.Color.White;
            this.Guna2Button4.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button4.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button4.Image = global::Properties.Resources.settings__1_;
            this.Guna2Button4.ImageSize = new System.Drawing.Size(22, 22);
            this.Guna2Button4.Location = new System.Drawing.Point(6, 310);
            this.Guna2Button4.Name = "Guna2Button4";
            this.Guna2Button4.PressedColor = System.Drawing.Color.Empty;
            this.Guna2Button4.Size = new System.Drawing.Size(190, 32);
            this.Guna2Button4.TabIndex = 443;
            this.Guna2Button4.Text = " Start ==>";
            this.Guna2Button4.TextFormatNoPrefix = true;
            this.Guna2Button4.Click += new System.EventHandler(this.Guna2Button4_Click);
            // 
            // Guna2Button6
            // 
            this.Guna2Button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Guna2Button6.Animated = true;
            this.Guna2Button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2Button6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2Button6.BorderRadius = 4;
            this.Guna2Button6.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.Guna2Button6.BorderThickness = 2;
            this.Guna2Button6.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button6.CheckedState.FillColor = System.Drawing.Color.LightGray;
            this.Guna2Button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guna2Button6.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button6.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
            this.Guna2Button6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button6.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.Guna2Button6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2Button6.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2Button6.ForeColor = System.Drawing.Color.White;
            this.Guna2Button6.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button6.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button6.Image = global::Properties.Resources.broom__1_;
            this.Guna2Button6.ImageSize = new System.Drawing.Size(23, 23);
            this.Guna2Button6.Location = new System.Drawing.Point(7, 234);
            this.Guna2Button6.Name = "Guna2Button6";
            this.Guna2Button6.PressedColor = System.Drawing.Color.Empty;
            this.Guna2Button6.Size = new System.Drawing.Size(189, 32);
            this.Guna2Button6.TabIndex = 499;
            this.Guna2Button6.Text = " Start ==>";
            this.Guna2Button6.TextFormatNoPrefix = true;
            this.Guna2Button6.Click += new System.EventHandler(this.Guna2Button6_Click);
            // 
            // ComboBoxBoot
            // 
            this.ComboBoxBoot.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ComboBoxBoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ComboBoxBoot.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.ComboBoxBoot.BorderRadius = 4;
            this.ComboBoxBoot.BorderThickness = 2;
            this.ComboBoxBoot.Cursor = System.Windows.Forms.Cursors.Default;
            this.ComboBoxBoot.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ComboBoxBoot.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ComboBoxBoot.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.ComboBoxBoot.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxBoot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxBoot.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ComboBoxBoot.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxBoot.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxBoot.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBoxBoot.ForeColor = System.Drawing.Color.White;
            this.ComboBoxBoot.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.ComboBoxBoot.ItemHeight = 26;
            this.ComboBoxBoot.Items.AddRange(new object[] {
            "Unlock Bootloader",
            "ReLock Bootloader"});
            this.ComboBoxBoot.ItemsAppearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.ComboBoxBoot.ItemsAppearance.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxBoot.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.ComboBoxBoot.Location = new System.Drawing.Point(202, 272);
            this.ComboBoxBoot.MaxDropDownItems = 5;
            this.ComboBoxBoot.MaxLength = 5;
            this.ComboBoxBoot.Name = "ComboBoxBoot";
            this.ComboBoxBoot.Size = new System.Drawing.Size(260, 32);
            this.ComboBoxBoot.StartIndex = 0;
            this.ComboBoxBoot.TabIndex = 498;
            // 
            // MaterialButton41
            // 
            this.MaterialButton41.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MaterialButton41.Animated = true;
            this.MaterialButton41.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.MaterialButton41.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.MaterialButton41.BorderRadius = 4;
            this.MaterialButton41.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.MaterialButton41.BorderThickness = 2;
            this.MaterialButton41.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.MaterialButton41.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.MaterialButton41.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MaterialButton41.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.MaterialButton41.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
            this.MaterialButton41.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.MaterialButton41.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.MaterialButton41.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.MaterialButton41.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaterialButton41.ForeColor = System.Drawing.Color.White;
            this.MaterialButton41.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.MaterialButton41.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.MaterialButton41.Image = global::Properties.Resources.google__2_;
            this.MaterialButton41.Location = new System.Drawing.Point(7, 6);
            this.MaterialButton41.Name = "MaterialButton41";
            this.MaterialButton41.PressedColor = System.Drawing.Color.Empty;
            this.MaterialButton41.Size = new System.Drawing.Size(455, 32);
            this.MaterialButton41.TabIndex = 437;
            this.MaterialButton41.Text = "Remove FRP [Brom Mode]";
            this.MaterialButton41.TextFormatNoPrefix = true;
            this.MaterialButton41.Click += new System.EventHandler(this.MaterialButton41_Click);
            // 
            // Guna2Button12
            // 
            this.Guna2Button12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Guna2Button12.Animated = true;
            this.Guna2Button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2Button12.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2Button12.BorderRadius = 4;
            this.Guna2Button12.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.Guna2Button12.BorderThickness = 2;
            this.Guna2Button12.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button12.CheckedState.FillColor = System.Drawing.Color.LightGray;
            this.Guna2Button12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guna2Button12.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button12.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
            this.Guna2Button12.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button12.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.Guna2Button12.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2Button12.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2Button12.ForeColor = System.Drawing.Color.White;
            this.Guna2Button12.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button12.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button12.Image = global::Properties.Resources.fingerprint;
            this.Guna2Button12.Location = new System.Drawing.Point(7, 82);
            this.Guna2Button12.Name = "Guna2Button12";
            this.Guna2Button12.PressedColor = System.Drawing.Color.Empty;
            this.Guna2Button12.Size = new System.Drawing.Size(455, 32);
            this.Guna2Button12.TabIndex = 440;
            this.Guna2Button12.Text = "Remove Demo [Oppo/Vivo] [Brom Mode]";
            this.Guna2Button12.TextFormatNoPrefix = true;
            this.Guna2Button12.Click += new System.EventHandler(this.Guna2Button12_Click);
            // 
            // Guna2Button10
            // 
            this.Guna2Button10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Guna2Button10.Animated = true;
            this.Guna2Button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2Button10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2Button10.BorderRadius = 4;
            this.Guna2Button10.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.Guna2Button10.BorderThickness = 2;
            this.Guna2Button10.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button10.CheckedState.FillColor = System.Drawing.Color.LightGray;
            this.Guna2Button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guna2Button10.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button10.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
            this.Guna2Button10.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button10.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.Guna2Button10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2Button10.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2Button10.ForeColor = System.Drawing.Color.White;
            this.Guna2Button10.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button10.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button10.Image = global::Properties.Resources.xiaomi__1_;
            this.Guna2Button10.Location = new System.Drawing.Point(7, 44);
            this.Guna2Button10.Name = "Guna2Button10";
            this.Guna2Button10.PressedColor = System.Drawing.Color.Empty;
            this.Guna2Button10.Size = new System.Drawing.Size(455, 32);
            this.Guna2Button10.TabIndex = 439;
            this.Guna2Button10.Text = "Remove Mi Acuuont [Brom Mode]";
            this.Guna2Button10.TextFormatNoPrefix = true;
            this.Guna2Button10.Click += new System.EventHandler(this.Guna2Button10_Click);
            // 
            // Guna2Button13
            // 
            this.Guna2Button13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Guna2Button13.Animated = true;
            this.Guna2Button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2Button13.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2Button13.BorderRadius = 4;
            this.Guna2Button13.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.Guna2Button13.BorderThickness = 2;
            this.Guna2Button13.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button13.CheckedState.FillColor = System.Drawing.Color.LightGray;
            this.Guna2Button13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guna2Button13.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button13.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
            this.Guna2Button13.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button13.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.Guna2Button13.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2Button13.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2Button13.ForeColor = System.Drawing.Color.White;
            this.Guna2Button13.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button13.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button13.Image = global::Properties.Resources.fingerprint;
            this.Guna2Button13.Location = new System.Drawing.Point(7, 120);
            this.Guna2Button13.Name = "Guna2Button13";
            this.Guna2Button13.PressedColor = System.Drawing.Color.Empty;
            this.Guna2Button13.Size = new System.Drawing.Size(455, 32);
            this.Guna2Button13.TabIndex = 441;
            this.Guna2Button13.Text = "Remove ID [Huawei/Realme] [Brom Mode]";
            this.Guna2Button13.TextFormatNoPrefix = true;
            this.Guna2Button13.Click += new System.EventHandler(this.Guna2Button13_Click);
            // 
            // TabPage4
            // 
            this.TabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TabPage4.Controls.Add(this.PictureBox14);
            this.TabPage4.Controls.Add(this.Guna2GroupBox4);
            this.TabPage4.Controls.Add(this.Guna2GroupBox1);
            this.TabPage4.Location = new System.Drawing.Point(4, 30);
            this.TabPage4.Name = "TabPage4";
            this.TabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage4.Size = new System.Drawing.Size(480, 444);
            this.TabPage4.TabIndex = 2;
            this.TabPage4.Text = "Partition Manger";
            // 
            // PictureBox14
            // 
            this.PictureBox14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PictureBox14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PictureBox14.Image = global::Properties.Resources.This_For_An;
            this.PictureBox14.Location = new System.Drawing.Point(3, 3);
            this.PictureBox14.Name = "PictureBox14";
            this.PictureBox14.Size = new System.Drawing.Size(25, 438);
            this.PictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox14.TabIndex = 527;
            this.PictureBox14.TabStop = false;
            // 
            // Guna2GroupBox4
            // 
            this.Guna2GroupBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Guna2GroupBox4.BackColor = System.Drawing.Color.Transparent;
            this.Guna2GroupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Guna2GroupBox4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2GroupBox4.BorderRadius = 6;
            this.Guna2GroupBox4.Controls.Add(this.Guna2CheckBox2);
            this.Guna2GroupBox4.Controls.Add(this.Guna2Button2);
            this.Guna2GroupBox4.Controls.Add(this.ComboBoxPreloader);
            this.Guna2GroupBox4.Controls.Add(this.MaterialButton30);
            this.Guna2GroupBox4.Controls.Add(this.ComboBoxSecurity);
            this.Guna2GroupBox4.Controls.Add(this.buttonreboot);
            this.Guna2GroupBox4.Controls.Add(this.BtnIdentify);
            this.Guna2GroupBox4.Cursor = System.Windows.Forms.Cursors.Default;
            this.Guna2GroupBox4.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2GroupBox4.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.Guna2GroupBox4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2GroupBox4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Guna2GroupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Guna2GroupBox4.Location = new System.Drawing.Point(6, 325);
            this.Guna2GroupBox4.Name = "Guna2GroupBox4";
            this.Guna2GroupBox4.ShadowDecoration.BorderRadius = 9;
            this.Guna2GroupBox4.ShadowDecoration.Color = System.Drawing.Color.White;
            this.Guna2GroupBox4.ShadowDecoration.Depth = 15;
            this.Guna2GroupBox4.Size = new System.Drawing.Size(468, 113);
            this.Guna2GroupBox4.TabIndex = 513;
            // 
            // Guna2CheckBox2
            // 
            this.Guna2CheckBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Guna2CheckBox2.Animated = true;
            this.Guna2CheckBox2.AutoSize = true;
            this.Guna2CheckBox2.BackColor = System.Drawing.Color.Transparent;
            this.Guna2CheckBox2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2CheckBox2.CheckedState.BorderRadius = 4;
            this.Guna2CheckBox2.CheckedState.BorderThickness = 2;
            this.Guna2CheckBox2.CheckedState.FillColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2CheckBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2CheckBox2.ForeColor = System.Drawing.Color.White;
            this.Guna2CheckBox2.Location = new System.Drawing.Point(11, 10);
            this.Guna2CheckBox2.Name = "Guna2CheckBox2";
            this.Guna2CheckBox2.Size = new System.Drawing.Size(129, 19);
            this.Guna2CheckBox2.TabIndex = 526;
            this.Guna2CheckBox2.Text = "Select All Partition";
            this.Guna2CheckBox2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2CheckBox2.UncheckedState.BorderRadius = 3;
            this.Guna2CheckBox2.UncheckedState.BorderThickness = 1;
            this.Guna2CheckBox2.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2CheckBox2.UseVisualStyleBackColor = false;
            this.Guna2CheckBox2.CheckedChanged += new System.EventHandler(this.Guna2CheckBox2_CheckedChanged);
            // 
            // Guna2Button2
            // 
            this.Guna2Button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Guna2Button2.Animated = true;
            this.Guna2Button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2Button2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2Button2.BorderRadius = 4;
            this.Guna2Button2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.Guna2Button2.BorderThickness = 2;
            this.Guna2Button2.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button2.CheckedState.FillColor = System.Drawing.Color.LightGray;
            this.Guna2Button2.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.Guna2Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
            this.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.Guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2Button2.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2Button2.ForeColor = System.Drawing.Color.White;
            this.Guna2Button2.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button2.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button2.Image = global::Properties.Resources.video;
            this.Guna2Button2.Location = new System.Drawing.Point(6, 37);
            this.Guna2Button2.Name = "Guna2Button2";
            this.Guna2Button2.PressedColor = System.Drawing.Color.Empty;
            this.Guna2Button2.Size = new System.Drawing.Size(236, 32);
            this.Guna2Button2.TabIndex = 515;
            this.Guna2Button2.Text = " Start ==>";
            this.Guna2Button2.TextFormatNoPrefix = true;
            this.Guna2Button2.Click += new System.EventHandler(this.Guna2Button2_Click_1);
            // 
            // ComboBoxPreloader
            // 
            this.ComboBoxPreloader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxPreloader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ComboBoxPreloader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.ComboBoxPreloader.BorderRadius = 4;
            this.ComboBoxPreloader.BorderThickness = 2;
            this.ComboBoxPreloader.Cursor = System.Windows.Forms.Cursors.Default;
            this.ComboBoxPreloader.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ComboBoxPreloader.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ComboBoxPreloader.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.ComboBoxPreloader.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxPreloader.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxPreloader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ComboBoxPreloader.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxPreloader.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxPreloader.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBoxPreloader.ForeColor = System.Drawing.Color.White;
            this.ComboBoxPreloader.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.ComboBoxPreloader.ItemHeight = 26;
            this.ComboBoxPreloader.Items.AddRange(new object[] {
            "Crash Preloader",
            "Dump Preloader"});
            this.ComboBoxPreloader.ItemsAppearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.ComboBoxPreloader.ItemsAppearance.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxPreloader.ItemsAppearance.ForeColor = System.Drawing.Color.White;
            this.ComboBoxPreloader.ItemsAppearance.SelectedBackColor = System.Drawing.Color.Gray;
            this.ComboBoxPreloader.ItemsAppearance.SelectedForeColor = System.Drawing.Color.White;
            this.ComboBoxPreloader.Location = new System.Drawing.Point(248, 75);
            this.ComboBoxPreloader.MaxDropDownItems = 5;
            this.ComboBoxPreloader.MaxLength = 5;
            this.ComboBoxPreloader.Name = "ComboBoxPreloader";
            this.ComboBoxPreloader.Size = new System.Drawing.Size(214, 32);
            this.ComboBoxPreloader.StartIndex = 0;
            this.ComboBoxPreloader.TabIndex = 518;
            // 
            // MaterialButton30
            // 
            this.MaterialButton30.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MaterialButton30.Animated = true;
            this.MaterialButton30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.MaterialButton30.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.MaterialButton30.BorderRadius = 4;
            this.MaterialButton30.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.MaterialButton30.BorderThickness = 2;
            this.MaterialButton30.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.MaterialButton30.CheckedState.FillColor = System.Drawing.Color.LightGray;
            this.MaterialButton30.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.MaterialButton30.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MaterialButton30.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.MaterialButton30.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
            this.MaterialButton30.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.MaterialButton30.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.MaterialButton30.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.MaterialButton30.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaterialButton30.ForeColor = System.Drawing.Color.White;
            this.MaterialButton30.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.MaterialButton30.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.MaterialButton30.Image = global::Properties.Resources.settings;
            this.MaterialButton30.ImageSize = new System.Drawing.Size(22, 22);
            this.MaterialButton30.Location = new System.Drawing.Point(6, 75);
            this.MaterialButton30.Name = "MaterialButton30";
            this.MaterialButton30.PressedColor = System.Drawing.Color.Empty;
            this.MaterialButton30.Size = new System.Drawing.Size(236, 32);
            this.MaterialButton30.TabIndex = 516;
            this.MaterialButton30.Text = " Start ==>";
            this.MaterialButton30.TextFormatNoPrefix = true;
            this.MaterialButton30.Click += new System.EventHandler(this.MaterialButton30_Click);
            // 
            // ComboBoxSecurity
            // 
            this.ComboBoxSecurity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxSecurity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ComboBoxSecurity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.ComboBoxSecurity.BorderRadius = 4;
            this.ComboBoxSecurity.BorderThickness = 2;
            this.ComboBoxSecurity.Cursor = System.Windows.Forms.Cursors.Default;
            this.ComboBoxSecurity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ComboBoxSecurity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ComboBoxSecurity.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.ComboBoxSecurity.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxSecurity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxSecurity.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ComboBoxSecurity.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxSecurity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxSecurity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBoxSecurity.ForeColor = System.Drawing.Color.White;
            this.ComboBoxSecurity.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.ComboBoxSecurity.ItemHeight = 26;
            this.ComboBoxSecurity.Items.AddRange(new object[] {
            "Backup Security",
            "Erase Security",
            "Restore Security"});
            this.ComboBoxSecurity.ItemsAppearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.ComboBoxSecurity.ItemsAppearance.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxSecurity.ItemsAppearance.ForeColor = System.Drawing.Color.White;
            this.ComboBoxSecurity.ItemsAppearance.SelectedBackColor = System.Drawing.Color.Gray;
            this.ComboBoxSecurity.ItemsAppearance.SelectedForeColor = System.Drawing.Color.White;
            this.ComboBoxSecurity.Location = new System.Drawing.Point(248, 37);
            this.ComboBoxSecurity.MaxDropDownItems = 5;
            this.ComboBoxSecurity.MaxLength = 5;
            this.ComboBoxSecurity.Name = "ComboBoxSecurity";
            this.ComboBoxSecurity.Size = new System.Drawing.Size(214, 32);
            this.ComboBoxSecurity.StartIndex = 0;
            this.ComboBoxSecurity.TabIndex = 517;
            // 
            // buttonreboot
            // 
            this.buttonreboot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonreboot.Animated = true;
            this.buttonreboot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.buttonreboot.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.buttonreboot.BorderRadius = 4;
            this.buttonreboot.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.buttonreboot.BorderThickness = 2;
            this.buttonreboot.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonreboot.CheckedState.FillColor = System.Drawing.Color.LightGray;
            this.buttonreboot.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.buttonreboot.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
            this.buttonreboot.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.buttonreboot.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.buttonreboot.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.buttonreboot.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonreboot.ForeColor = System.Drawing.Color.White;
            this.buttonreboot.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.buttonreboot.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.buttonreboot.Image = global::Properties.Resources.power;
            this.buttonreboot.ImageSize = new System.Drawing.Size(22, 22);
            this.buttonreboot.Location = new System.Drawing.Point(146, 7);
            this.buttonreboot.Name = "buttonreboot";
            this.buttonreboot.PressedColor = System.Drawing.Color.Empty;
            this.buttonreboot.Size = new System.Drawing.Size(118, 24);
            this.buttonreboot.TabIndex = 503;
            this.buttonreboot.Text = " Reboot";
            this.buttonreboot.TextFormatNoPrefix = true;
            this.buttonreboot.Click += new System.EventHandler(this.Guna2Button2_Click);
            // 
            // BtnIdentify
            // 
            this.BtnIdentify.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnIdentify.Animated = true;
            this.BtnIdentify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnIdentify.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.BtnIdentify.BorderRadius = 4;
            this.BtnIdentify.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.BtnIdentify.BorderThickness = 2;
            this.BtnIdentify.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnIdentify.CheckedState.FillColor = System.Drawing.Color.LightGray;
            this.BtnIdentify.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.BtnIdentify.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
            this.BtnIdentify.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.BtnIdentify.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.BtnIdentify.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.BtnIdentify.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnIdentify.ForeColor = System.Drawing.Color.White;
            this.BtnIdentify.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.BtnIdentify.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.BtnIdentify.Image = global::Properties.Resources.link;
            this.BtnIdentify.ImageSize = new System.Drawing.Size(22, 22);
            this.BtnIdentify.Location = new System.Drawing.Point(270, 7);
            this.BtnIdentify.Name = "BtnIdentify";
            this.BtnIdentify.PressedColor = System.Drawing.Color.Empty;
            this.BtnIdentify.Size = new System.Drawing.Size(192, 24);
            this.BtnIdentify.TabIndex = 496;
            this.BtnIdentify.Text = " Connect";
            this.BtnIdentify.TextFormatNoPrefix = true;
            this.BtnIdentify.Click += new System.EventHandler(this.BtnIdentify_Click);
            // 
            // Guna2GroupBox1
            // 
            this.Guna2GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Guna2GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.Guna2GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2GroupBox1.BorderRadius = 6;
            this.Guna2GroupBox1.BorderThickness = 2;
            this.Guna2GroupBox1.Controls.Add(this.Guna2VScrollBar2);
            this.Guna2GroupBox1.Controls.Add(this.Guna2GroupBox2);
            this.Guna2GroupBox1.Controls.Add(this.DataViewmtk);
            this.Guna2GroupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.Guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Guna2GroupBox1.Location = new System.Drawing.Point(6, 6);
            this.Guna2GroupBox1.Name = "Guna2GroupBox1";
            this.Guna2GroupBox1.ShadowDecoration.BorderRadius = 9;
            this.Guna2GroupBox1.ShadowDecoration.Color = System.Drawing.Color.White;
            this.Guna2GroupBox1.ShadowDecoration.Depth = 15;
            this.Guna2GroupBox1.Size = new System.Drawing.Size(468, 313);
            this.Guna2GroupBox1.TabIndex = 514;
            // 
            // Guna2VScrollBar2
            // 
            this.Guna2VScrollBar2.AutoRoundedCorners = true;
            this.Guna2VScrollBar2.AutoScroll = true;
            this.Guna2VScrollBar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2VScrollBar2.BindingContainer = this.DataViewmtk;
            this.Guna2VScrollBar2.BorderRadius = 8;
            this.Guna2VScrollBar2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2VScrollBar2.HighlightOnWheel = true;
            this.Guna2VScrollBar2.InUpdate = false;
            this.Guna2VScrollBar2.LargeChange = 10;
            this.Guna2VScrollBar2.Location = new System.Drawing.Point(447, 3);
            this.Guna2VScrollBar2.Minimum = 1;
            this.Guna2VScrollBar2.Name = "Guna2VScrollBar2";
            this.Guna2VScrollBar2.ScrollbarSize = 18;
            this.Guna2VScrollBar2.Size = new System.Drawing.Size(18, 276);
            this.Guna2VScrollBar2.TabIndex = 479;
            this.Guna2VScrollBar2.ThumbColor = System.Drawing.Color.FromArgb(0, 85, 207);
            this.Guna2VScrollBar2.ThumbStyle = Guna.UI2.WinForms.Enums.ThumbStyle.Inset;
            this.Guna2VScrollBar2.Value = 1;
            // 
            // DataViewmtk
            // 
            this.DataViewmtk.AllowUserToAddRows = false;
            this.DataViewmtk.AllowUserToDeleteRows = false;
            this.DataViewmtk.AllowUserToResizeColumns = false;
            this.DataViewmtk.AllowUserToResizeRows = false;
            this.DataViewmtk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DataViewmtk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataViewmtk.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataViewmtk.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.DataViewmtk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataViewmtk.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.DataViewmtk.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle48.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle48.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle48.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle48.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle48.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle48.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataViewmtk.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle48;
            this.DataViewmtk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataViewmtk.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column0,
            this.Column3,
            this.part,
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column4,
            this.Column6});
            dataGridViewCellStyle49.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle49.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle49.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle49.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle49.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle49.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle49.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataViewmtk.DefaultCellStyle = dataGridViewCellStyle49;
            this.DataViewmtk.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.DataViewmtk.EnableHeadersVisualStyles = false;
            this.DataViewmtk.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.DataViewmtk.Location = new System.Drawing.Point(7, 3);
            this.DataViewmtk.MultiSelect = false;
            this.DataViewmtk.Name = "DataViewmtk";
            dataGridViewCellStyle50.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle50.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle50.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle50.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle50.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle50.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle50.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataViewmtk.RowHeadersDefaultCellStyle = dataGridViewCellStyle50;
            this.DataViewmtk.RowHeadersVisible = false;
            dataGridViewCellStyle51.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle51.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle51.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle51.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle51.SelectionForeColor = System.Drawing.Color.White;
            this.DataViewmtk.RowsDefaultCellStyle = dataGridViewCellStyle51;
            this.DataViewmtk.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.DataViewmtk.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataViewmtk.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.DataViewmtk.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.DataViewmtk.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DataViewmtk.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataViewmtk.Size = new System.Drawing.Size(458, 276);
            this.DataViewmtk.TabIndex = 484;
            this.DataViewmtk.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataViewmtk_CellContentClick);
            this.DataViewmtk.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataViewmtk_CellFormatting);
            // 
            // Column0
            // 
            this.Column0.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column0.Frozen = true;
            this.Column0.HeaderText = " ";
            this.Column0.Name = "Column0";
            this.Column0.Width = 19;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Region";
            this.Column3.Name = "Column3";
            this.Column3.Visible = false;
            // 
            // part
            // 
            this.part.FillWeight = 50F;
            this.part.HeaderText = "Partition";
            this.part.Name = "part";
            this.part.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 50F;
            this.Column1.HeaderText = "Address";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 50F;
            this.Column2.HeaderText = "Size";
            this.Column2.Name = "Column2";
            this.Column2.Visible = false;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 50F;
            this.Column5.HeaderText = "Part Size";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 50F;
            this.Column4.HeaderText = "Filename";
            this.Column4.Name = "Column4";
            this.Column4.Visible = false;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 50F;
            this.Column6.HeaderText = "Region";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Guna2GroupBox2
            // 
            this.Guna2GroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Guna2GroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.Guna2GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Guna2GroupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2GroupBox2.BorderRadius = 6;
            this.Guna2GroupBox2.BorderThickness = 2;
            this.Guna2GroupBox2.Controls.Add(this.Guna2Button5);
            this.Guna2GroupBox2.Controls.Add(this.Guna2Button3);
            this.Guna2GroupBox2.Controls.Add(this.Guna2Button1);
            this.Guna2GroupBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2GroupBox2.Enabled = false;
            this.Guna2GroupBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Guna2GroupBox2.Location = new System.Drawing.Point(0, 280);
            this.Guna2GroupBox2.Name = "Guna2GroupBox2";
            this.Guna2GroupBox2.ShadowDecoration.BorderRadius = 9;
            this.Guna2GroupBox2.ShadowDecoration.Color = System.Drawing.Color.White;
            this.Guna2GroupBox2.ShadowDecoration.Depth = 15;
            this.Guna2GroupBox2.Size = new System.Drawing.Size(466, 33);
            this.Guna2GroupBox2.TabIndex = 523;
            // 
            // Guna2Button5
            // 
            this.Guna2Button5.Animated = true;
            this.Guna2Button5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2Button5.BorderRadius = 4;
            this.Guna2Button5.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.Guna2Button5.BorderThickness = 2;
            this.Guna2Button5.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button5.CheckedState.FillColor = System.Drawing.Color.LightGray;
            this.Guna2Button5.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.Guna2Button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guna2Button5.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
            this.Guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2Button5.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.Guna2Button5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2Button5.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2Button5.ForeColor = System.Drawing.Color.White;
            this.Guna2Button5.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button5.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button5.Image = global::Properties.Resources.upload__1_;
            this.Guna2Button5.Location = new System.Drawing.Point(160, 5);
            this.Guna2Button5.Name = "Guna2Button5";
            this.Guna2Button5.PressedColor = System.Drawing.Color.Empty;
            this.Guna2Button5.Size = new System.Drawing.Size(72, 23);
            this.Guna2Button5.TabIndex = 524;
            this.Guna2Button5.Text = "Write";
            this.Guna2Button5.TextFormatNoPrefix = true;
            this.Guna2Button5.Click += new System.EventHandler(this.Guna2Button5_Click);
            // 
            // Guna2Button3
            // 
            this.Guna2Button3.Animated = true;
            this.Guna2Button3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2Button3.BorderRadius = 4;
            this.Guna2Button3.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.Guna2Button3.BorderThickness = 2;
            this.Guna2Button3.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button3.CheckedState.FillColor = System.Drawing.Color.LightGray;
            this.Guna2Button3.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.Guna2Button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guna2Button3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
            this.Guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2Button3.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.Guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2Button3.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2Button3.ForeColor = System.Drawing.Color.White;
            this.Guna2Button3.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button3.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button3.Image = global::Properties.Resources.eraser__2_;
            this.Guna2Button3.Location = new System.Drawing.Point(84, 5);
            this.Guna2Button3.Name = "Guna2Button3";
            this.Guna2Button3.PressedColor = System.Drawing.Color.Empty;
            this.Guna2Button3.Size = new System.Drawing.Size(72, 23);
            this.Guna2Button3.TabIndex = 523;
            this.Guna2Button3.Text = "Erase";
            this.Guna2Button3.TextFormatNoPrefix = true;
            this.Guna2Button3.Click += new System.EventHandler(this.Guna2Button3_Click);
            // 
            // Guna2Button1
            // 
            this.Guna2Button1.Animated = true;
            this.Guna2Button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2Button1.BorderRadius = 4;
            this.Guna2Button1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.Guna2Button1.BorderThickness = 2;
            this.Guna2Button1.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button1.CheckedState.FillColor = System.Drawing.Color.LightGray;
            this.Guna2Button1.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            this.Guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
            this.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2Button1.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2Button1.ForeColor = System.Drawing.Color.White;
            this.Guna2Button1.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button1.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button1.Image = global::Properties.Resources.download__3_;
            this.Guna2Button1.Location = new System.Drawing.Point(6, 5);
            this.Guna2Button1.Name = "Guna2Button1";
            this.Guna2Button1.PressedColor = System.Drawing.Color.Empty;
            this.Guna2Button1.Size = new System.Drawing.Size(72, 23);
            this.Guna2Button1.TabIndex = 522;
            this.Guna2Button1.Text = "Read";
            this.Guna2Button1.TextFormatNoPrefix = true;
            this.Guna2Button1.Click += new System.EventHandler(this.Guna2Button1_Click_1);
            // 
            // TabPage1
            // 
            this.TabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TabPage1.Controls.Add(this.Guna2GroupBox5);
            this.TabPage1.Controls.Add(this.Guna2GroupBox3);
            this.TabPage1.Location = new System.Drawing.Point(4, 30);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(480, 444);
            this.TabPage1.TabIndex = 3;
            this.TabPage1.Text = "Flasher";
            // 
            // Guna2GroupBox5
            // 
            this.Guna2GroupBox5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Guna2GroupBox5.BackColor = System.Drawing.Color.Transparent;
            this.Guna2GroupBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Guna2GroupBox5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2GroupBox5.BorderRadius = 6;
            this.Guna2GroupBox5.Controls.Add(this.Guna2CheckBox6);
            this.Guna2GroupBox5.Controls.Add(this.Guna2CheckBox5);
            this.Guna2GroupBox5.Controls.Add(this.Guna2CheckBox4);
            this.Guna2GroupBox5.Controls.Add(this.Guna2CheckBox3);
            this.Guna2GroupBox5.Controls.Add(this.BtnFlash);
            this.Guna2GroupBox5.Controls.Add(this.TxtScatter);
            this.Guna2GroupBox5.Controls.Add(this.BtnScatter);
            this.Guna2GroupBox5.Cursor = System.Windows.Forms.Cursors.Default;
            this.Guna2GroupBox5.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2GroupBox5.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.Guna2GroupBox5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2GroupBox5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Guna2GroupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Guna2GroupBox5.Location = new System.Drawing.Point(6, 371);
            this.Guna2GroupBox5.Name = "Guna2GroupBox5";
            this.Guna2GroupBox5.ShadowDecoration.BorderRadius = 9;
            this.Guna2GroupBox5.ShadowDecoration.Color = System.Drawing.Color.White;
            this.Guna2GroupBox5.ShadowDecoration.Depth = 15;
            this.Guna2GroupBox5.Size = new System.Drawing.Size(468, 67);
            this.Guna2GroupBox5.TabIndex = 516;
            // 
            // Guna2CheckBox6
            // 
            this.Guna2CheckBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Guna2CheckBox6.Animated = true;
            this.Guna2CheckBox6.AutoSize = true;
            this.Guna2CheckBox6.BackColor = System.Drawing.Color.Transparent;
            this.Guna2CheckBox6.Checked = true;
            this.Guna2CheckBox6.CheckedState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2CheckBox6.CheckedState.BorderRadius = 4;
            this.Guna2CheckBox6.CheckedState.BorderThickness = 2;
            this.Guna2CheckBox6.CheckedState.FillColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2CheckBox6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Guna2CheckBox6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2CheckBox6.ForeColor = System.Drawing.Color.White;
            this.Guna2CheckBox6.Location = new System.Drawing.Point(352, 7);
            this.Guna2CheckBox6.Name = "Guna2CheckBox6";
            this.Guna2CheckBox6.Size = new System.Drawing.Size(97, 19);
            this.Guna2CheckBox6.TabIndex = 529;
            this.Guna2CheckBox6.Text = "Auto Reboot";
            this.Guna2CheckBox6.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2CheckBox6.UncheckedState.BorderRadius = 3;
            this.Guna2CheckBox6.UncheckedState.BorderThickness = 1;
            this.Guna2CheckBox6.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2CheckBox6.UseVisualStyleBackColor = false;
            this.Guna2CheckBox6.CheckedChanged += new System.EventHandler(this.Guna2CheckBox6_CheckedChanged);
            // 
            // Guna2CheckBox5
            // 
            this.Guna2CheckBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Guna2CheckBox5.Animated = true;
            this.Guna2CheckBox5.AutoSize = true;
            this.Guna2CheckBox5.BackColor = System.Drawing.Color.Transparent;
            this.Guna2CheckBox5.CheckedState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2CheckBox5.CheckedState.BorderRadius = 4;
            this.Guna2CheckBox5.CheckedState.BorderThickness = 2;
            this.Guna2CheckBox5.CheckedState.FillColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2CheckBox5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2CheckBox5.ForeColor = System.Drawing.Color.White;
            this.Guna2CheckBox5.Location = new System.Drawing.Point(268, 7);
            this.Guna2CheckBox5.Name = "Guna2CheckBox5";
            this.Guna2CheckBox5.Size = new System.Drawing.Size(78, 19);
            this.Guna2CheckBox5.TabIndex = 528;
            this.Guna2CheckBox5.Text = "Clear FRP";
            this.Guna2CheckBox5.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2CheckBox5.UncheckedState.BorderRadius = 3;
            this.Guna2CheckBox5.UncheckedState.BorderThickness = 1;
            this.Guna2CheckBox5.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2CheckBox5.UseVisualStyleBackColor = false;
            this.Guna2CheckBox5.CheckedChanged += new System.EventHandler(this.Guna2CheckBox5_CheckedChanged);
            // 
            // Guna2CheckBox4
            // 
            this.Guna2CheckBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Guna2CheckBox4.Animated = true;
            this.Guna2CheckBox4.AutoSize = true;
            this.Guna2CheckBox4.BackColor = System.Drawing.Color.Transparent;
            this.Guna2CheckBox4.CheckedState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2CheckBox4.CheckedState.BorderRadius = 4;
            this.Guna2CheckBox4.CheckedState.BorderThickness = 2;
            this.Guna2CheckBox4.CheckedState.FillColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2CheckBox4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2CheckBox4.ForeColor = System.Drawing.Color.White;
            this.Guna2CheckBox4.Location = new System.Drawing.Point(155, 7);
            this.Guna2CheckBox4.Name = "Guna2CheckBox4";
            this.Guna2CheckBox4.Size = new System.Drawing.Size(107, 19);
            this.Guna2CheckBox4.TabIndex = 527;
            this.Guna2CheckBox4.Text = "Clear Userdata";
            this.Guna2CheckBox4.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2CheckBox4.UncheckedState.BorderRadius = 3;
            this.Guna2CheckBox4.UncheckedState.BorderThickness = 1;
            this.Guna2CheckBox4.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2CheckBox4.UseVisualStyleBackColor = false;
            this.Guna2CheckBox4.CheckedChanged += new System.EventHandler(this.Guna2CheckBox4_CheckedChanged);
            // 
            // Guna2CheckBox3
            // 
            this.Guna2CheckBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Guna2CheckBox3.Animated = true;
            this.Guna2CheckBox3.AutoSize = true;
            this.Guna2CheckBox3.BackColor = System.Drawing.Color.Transparent;
            this.Guna2CheckBox3.CheckedState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2CheckBox3.CheckedState.BorderRadius = 4;
            this.Guna2CheckBox3.CheckedState.BorderThickness = 2;
            this.Guna2CheckBox3.CheckedState.FillColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2CheckBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2CheckBox3.ForeColor = System.Drawing.Color.White;
            this.Guna2CheckBox3.Location = new System.Drawing.Point(20, 7);
            this.Guna2CheckBox3.Name = "Guna2CheckBox3";
            this.Guna2CheckBox3.Size = new System.Drawing.Size(129, 19);
            this.Guna2CheckBox3.TabIndex = 526;
            this.Guna2CheckBox3.Text = "Select All Partition";
            this.Guna2CheckBox3.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2CheckBox3.UncheckedState.BorderRadius = 3;
            this.Guna2CheckBox3.UncheckedState.BorderThickness = 1;
            this.Guna2CheckBox3.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2CheckBox3.UseVisualStyleBackColor = false;
            this.Guna2CheckBox3.CheckedChanged += new System.EventHandler(this.Guna2CheckBox3_CheckedChanged);
            // 
            // BtnFlash
            // 
            this.BtnFlash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnFlash.Animated = true;
            this.BtnFlash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnFlash.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.BtnFlash.BorderRadius = 4;
            this.BtnFlash.BorderThickness = 2;
            this.BtnFlash.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnFlash.CheckedState.FillColor = System.Drawing.Color.LightGray;
            this.BtnFlash.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.BtnFlash.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
            this.BtnFlash.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.BtnFlash.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.BtnFlash.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.BtnFlash.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnFlash.ForeColor = System.Drawing.Color.White;
            this.BtnFlash.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.BtnFlash.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.BtnFlash.Image = global::Properties.Resources.download__2_;
            this.BtnFlash.ImageSize = new System.Drawing.Size(25, 25);
            this.BtnFlash.Location = new System.Drawing.Point(335, 33);
            this.BtnFlash.Name = "BtnFlash";
            this.BtnFlash.PressedColor = System.Drawing.Color.Empty;
            this.BtnFlash.Size = new System.Drawing.Size(127, 27);
            this.BtnFlash.TabIndex = 497;
            this.BtnFlash.Text = "Flash";
            this.BtnFlash.TextFormatNoPrefix = true;
            this.BtnFlash.Click += new System.EventHandler(this.Guna2Button17_Click);
            // 
            // TxtScatter
            // 
            this.TxtScatter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtScatter.Animated = true;
            this.TxtScatter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TxtScatter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.TxtScatter.BorderRadius = 5;
            this.TxtScatter.BorderThickness = 2;
            this.TxtScatter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtScatter.DefaultText = "";
            this.TxtScatter.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.TxtScatter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.TxtScatter.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.TxtScatter.DisabledState.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.TxtScatter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.TxtScatter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtScatter.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtScatter.ForeColor = System.Drawing.Color.White;
            this.TxtScatter.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.TxtScatter.Location = new System.Drawing.Point(50, 33);
            this.TxtScatter.Name = "TxtScatter";
            this.TxtScatter.PasswordChar = '\0';
            this.TxtScatter.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.TxtScatter.PlaceholderText = "Scatter | Dump File";
            this.TxtScatter.SelectedText = "";
            this.TxtScatter.ShadowDecoration.Color = System.Drawing.Color.DimGray;
            this.TxtScatter.ShadowDecoration.Depth = 15;
            this.TxtScatter.Size = new System.Drawing.Size(279, 27);
            this.TxtScatter.TabIndex = 502;
            this.TxtScatter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtScatter.TextChanged += new System.EventHandler(this.TxtScatter_TextChanged);
            // 
            // BtnScatter
            // 
            this.BtnScatter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnScatter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnScatter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.BtnScatter.BorderRadius = 4;
            this.BtnScatter.BorderThickness = 2;
            this.BtnScatter.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnScatter.CheckedState.FillColor = System.Drawing.Color.LightGray;
            this.BtnScatter.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.BtnScatter.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
            this.BtnScatter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.BtnScatter.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.BtnScatter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.BtnScatter.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnScatter.ForeColor = System.Drawing.Color.White;
            this.BtnScatter.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.BtnScatter.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.BtnScatter.Image = global::Properties.Resources.search_in_folder;
            this.BtnScatter.ImageSize = new System.Drawing.Size(25, 25);
            this.BtnScatter.Location = new System.Drawing.Point(7, 33);
            this.BtnScatter.Name = "BtnScatter";
            this.BtnScatter.PressedColor = System.Drawing.Color.Empty;
            this.BtnScatter.Size = new System.Drawing.Size(37, 27);
            this.BtnScatter.TabIndex = 501;
            this.BtnScatter.TextFormatNoPrefix = true;
            this.BtnScatter.Click += new System.EventHandler(this.Guna2Button18_Click);
            // 
            // Guna2GroupBox3
            // 
            this.Guna2GroupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Guna2GroupBox3.BackColor = System.Drawing.Color.Transparent;
            this.Guna2GroupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Guna2GroupBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2GroupBox3.BorderRadius = 6;
            this.Guna2GroupBox3.BorderThickness = 2;
            this.Guna2GroupBox3.Controls.Add(this.Guna2VScrollBar1);
            this.Guna2GroupBox3.Controls.Add(this.DataGridFlash);
            this.Guna2GroupBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.Guna2GroupBox3.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2GroupBox3.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.Guna2GroupBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2GroupBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Guna2GroupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Guna2GroupBox3.Location = new System.Drawing.Point(6, 6);
            this.Guna2GroupBox3.Name = "Guna2GroupBox3";
            this.Guna2GroupBox3.ShadowDecoration.BorderRadius = 9;
            this.Guna2GroupBox3.ShadowDecoration.Color = System.Drawing.Color.White;
            this.Guna2GroupBox3.ShadowDecoration.Depth = 15;
            this.Guna2GroupBox3.Size = new System.Drawing.Size(468, 359);
            this.Guna2GroupBox3.TabIndex = 515;
            // 
            // Guna2VScrollBar1
            // 
            this.Guna2VScrollBar1.AutoRoundedCorners = true;
            this.Guna2VScrollBar1.AutoScroll = true;
            this.Guna2VScrollBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2VScrollBar1.BindingContainer = this.DataGridFlash;
            this.Guna2VScrollBar1.BorderRadius = 8;
            this.Guna2VScrollBar1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2VScrollBar1.HighlightOnWheel = true;
            this.Guna2VScrollBar1.InUpdate = false;
            this.Guna2VScrollBar1.LargeChange = 10;
            this.Guna2VScrollBar1.Location = new System.Drawing.Point(447, 3);
            this.Guna2VScrollBar1.Minimum = 1;
            this.Guna2VScrollBar1.Name = "Guna2VScrollBar1";
            this.Guna2VScrollBar1.ScrollbarSize = 18;
            this.Guna2VScrollBar1.Size = new System.Drawing.Size(18, 353);
            this.Guna2VScrollBar1.TabIndex = 479;
            this.Guna2VScrollBar1.ThumbColor = System.Drawing.Color.FromArgb(0, 85, 207);
            this.Guna2VScrollBar1.ThumbStyle = Guna.UI2.WinForms.Enums.ThumbStyle.Inset;
            this.Guna2VScrollBar1.Value = 1;
            // 
            // DataGridFlash
            // 
            this.DataGridFlash.AllowUserToAddRows = false;
            this.DataGridFlash.AllowUserToDeleteRows = false;
            this.DataGridFlash.AllowUserToResizeColumns = false;
            this.DataGridFlash.AllowUserToResizeRows = false;
            this.DataGridFlash.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DataGridFlash.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridFlash.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridFlash.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.DataGridFlash.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridFlash.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.DataGridFlash.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle52.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle52.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle52.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle52.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle52.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle52.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridFlash.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle52;
            this.DataGridFlash.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridFlash.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewCheckBoxColumn1,
            this.DataGridViewTextBoxColumn3,
            this.DataGridViewTextBoxColumn4,
            this.DataGridViewTextBoxColumn5,
            this.DataGridViewTextBoxColumn6,
            this.DataGridViewTextBoxColumn7,
            this.DataGridViewTextBoxColumn8,
            this.DataGridViewTextBoxColumn9});
            dataGridViewCellStyle53.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle53.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle53.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle53.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle53.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle53.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle53.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridFlash.DefaultCellStyle = dataGridViewCellStyle53;
            this.DataGridFlash.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.DataGridFlash.EnableHeadersVisualStyles = false;
            this.DataGridFlash.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.DataGridFlash.Location = new System.Drawing.Point(7, 3);
            this.DataGridFlash.MultiSelect = false;
            this.DataGridFlash.Name = "DataGridFlash";
            dataGridViewCellStyle54.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle54.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle54.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle54.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle54.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle54.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle54.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridFlash.RowHeadersDefaultCellStyle = dataGridViewCellStyle54;
            this.DataGridFlash.RowHeadersVisible = false;
            dataGridViewCellStyle55.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle55.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle55.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle55.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle55.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridFlash.RowsDefaultCellStyle = dataGridViewCellStyle55;
            this.DataGridFlash.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.DataGridFlash.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridFlash.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridFlash.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.DataGridFlash.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridFlash.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridFlash.Size = new System.Drawing.Size(458, 353);
            this.DataGridFlash.TabIndex = 484;
            // 
            // DataGridViewCheckBoxColumn1
            // 
            this.DataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DataGridViewCheckBoxColumn1.Frozen = true;
            this.DataGridViewCheckBoxColumn1.HeaderText = " ";
            this.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1";
            this.DataGridViewCheckBoxColumn1.Width = 19;
            // 
            // DataGridViewTextBoxColumn3
            // 
            this.DataGridViewTextBoxColumn3.HeaderText = "Region";
            this.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3";
            this.DataGridViewTextBoxColumn3.Visible = false;
            // 
            // DataGridViewTextBoxColumn4
            // 
            this.DataGridViewTextBoxColumn4.FillWeight = 50F;
            this.DataGridViewTextBoxColumn4.HeaderText = "Partition";
            this.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4";
            this.DataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn5
            // 
            this.DataGridViewTextBoxColumn5.FillWeight = 50F;
            this.DataGridViewTextBoxColumn5.HeaderText = "Address";
            this.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5";
            this.DataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn6
            // 
            this.DataGridViewTextBoxColumn6.FillWeight = 50F;
            this.DataGridViewTextBoxColumn6.HeaderText = "Size";
            this.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6";
            this.DataGridViewTextBoxColumn6.Visible = false;
            // 
            // DataGridViewTextBoxColumn7
            // 
            this.DataGridViewTextBoxColumn7.FillWeight = 50F;
            this.DataGridViewTextBoxColumn7.HeaderText = "Part Size";
            this.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7";
            this.DataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn8
            // 
            this.DataGridViewTextBoxColumn8.FillWeight = 50F;
            this.DataGridViewTextBoxColumn8.HeaderText = "Filename";
            this.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8";
            this.DataGridViewTextBoxColumn8.Visible = false;
            // 
            // DataGridViewTextBoxColumn9
            // 
            this.DataGridViewTextBoxColumn9.FillWeight = 50F;
            this.DataGridViewTextBoxColumn9.HeaderText = "Region";
            this.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9";
            this.DataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // Protocol_MTK_By_Devronix
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(496, 534);
            this.ControlBox = false;
            this.Controls.Add(this.Guna2GroupBox6);
            this.Controls.Add(this.TabControlExt1);
            this.Controls.Add(this.ComboPort);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.CkBromReady);
            this.Controls.Add(this.CkAutoUnsparse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Protocol_MTK_By_Devronix";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Other Services [MTK V2]";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.Guna2GroupBox6.ResumeLayout(false);
            this.Guna2GroupBox6.PerformLayout();
            this.TabControlExt1.ResumeLayout(false);
            this.TabPage2.ResumeLayout(false);
            this.Guna2GroupBox8.ResumeLayout(false);
            this.Guna2GroupBox7.ResumeLayout(false);
            this.TabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox14)).EndInit();
            this.Guna2GroupBox4.ResumeLayout(false);
            this.Guna2GroupBox4.PerformLayout();
            this.Guna2GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataViewmtk)).EndInit();
            this.Guna2GroupBox2.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.Guna2GroupBox5.ResumeLayout(false);
            this.Guna2GroupBox5.PerformLayout();
            this.Guna2GroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridFlash)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
		SerialCOM.MSL = null;
		Form1.SharedUI.RichTextBox1.Clear();
		Form1.SharedUI.ProgressBar1.Text = "100%";
		Form1.SharedUI.Guna2TaskBarProgress1.Value = 0;
		Form1.SharedUI.Guna2TaskBarProgress1.State = Guna2TaskBarProgress.TaskbarStates.Indeterminate;
		Form1.SharedUI.ProgressBar1.Roll = true;
		Form1.SharedUI.MaterialCard5.Enabled = false;
		Form1.SharedUI.MaterialCard3.Enabled = false;
		Form1.SharedUI.MaterialButton8.Enabled = true;
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

	public void finshonly()
	{
		SerialCOM.MSL = null;
		SerialCOM.MSL = null;
		SerialCOM.MSL = null;
		Form1.SharedUI.ProgressBar1.Text = "100%";
		Form1.SharedUI.ProgressBar1.Roll = false;
		Form1.SharedUI.Guna2TaskBarProgress1.State = Guna2TaskBarProgress.TaskbarStates.Normal;
		Form1.SharedUI.Guna2TaskBarProgress1.Value = 0;
		Form1.SharedUI.Guna2TaskBarProgress1.Value = 0;
		Form1.SharedUI.Guna2TaskBarProgress1.Value = 0;
		Form1.SharedUI.MaterialCard5.Enabled = true;
		Form1.SharedUI.MaterialCard3.Enabled = true;
		Form1.SharedUI.MaterialButton8.Enabled = false;
	}

	public void method_Cancel()
	{
		finshonly();
		try
		{
			cts.Cancel();
			MtkTask.closingport();
			cts.Token.ThrowIfCancellationRequested();
		}
		catch (OperationCanceledException ex)
		{
			ProjectData.SetProjectError(ex);
			OperationCanceledException ex2 = ex;
			cts = new CancellationTokenSource();
			isMTKClientRunning = false;
			ProjectData.ClearProjectError();
		}
	}

	public object ShowSelectedCheckBoxCount()
	{
		int num = 0;
		foreach (DataGridViewRow item in (IEnumerable)DataViewmtk.Rows)
		{
			if (Convert.ToBoolean(RuntimeHelpers.GetObjectValue(item.Cells[0].Value)))
			{
				num = checked(num + 1);
			}
		}
		return num;
	}

	public Protocol_MTK_By_Devronix()
	{
		base.Load += Protocol_MTK_By_Devronix_Load;
		ThisLocation = AppDomain.CurrentDomain.BaseDirectory;
		Seva_Coun = "";
		InitializeComponent();
		SharedUI = this;
	}

	public static void ProcessBar(long Process, long total)
	{
		int num = checked((int)Math.Round(Math.Round((double)(Process * 100) / (double)total)));
		if (num > 100)
		{
			num = 100;
		}
		Form1.SharedUI.ProgressBar4.Invoke((Action)([SpecialName] () =>
		{
			Form1.SharedUI.ProgressBar4.Value = num;
		}));
	}

	private async void BtnIdentify_Click(object sender, EventArgs e)
	{
		if (isMTKClientRunning)
		{
			return;
		}
		start();
		try
		{
			isMTKClientRunning = true;
			CancellationToken token = cts.Token;
			if (DataViewmtk.Rows.Count > 0)
			{
				DataViewmtk.Rows.Clear();
			}
			if (CkBromReady.Checked)
			{
				await Task.Run([SpecialName] () => MtkTask.ReadGPT2(token));
			}
			else
			{
				gui.Richlog("- Initializing Usb Device : ", Color.White);
				await Task.Run([SpecialName] () => MtkTask.InitAsync2(token));
				if (Operators.CompareString(MtkTask.CHECK, "no", TextCompare: false) == 0)
				{
					finshfile();
					return;
				}
				if (CkBromReady.Checked)
				{
					await Task.Run([SpecialName] () => MtkTask.ReadGPT2(token));
				}
			}
			finshonly();
		}
		catch (OperationCanceledException projectError)
		{
			ProjectData.SetProjectError(projectError);
			CkBromReady.Invoke((Action)([SpecialName] () =>
			{
				CkBromReady.Checked = false;
			}));
			isMTKClientRunning = false;
			ProjectData.ClearProjectError();
		}
		finally
		{
			BtnFlash.Invoke((Action)([SpecialName] () =>
			{
				BtnFlash.Enabled = true;
			}));
		}
		isMTKClientRunning = false;
	}

	private void BtnEMI1_Click(object sender, EventArgs e)
	{
		OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.Title = "Select EMI | Preloader File";
		openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
		openFileDialog.FileName = "";
		openFileDialog.Filter = "Preloader file |*.bin*;";
		openFileDialog.FilterIndex = 1;
		openFileDialog.RestoreDirectory = true;
		if (openFileDialog.ShowDialog() == DialogResult.OK)
		{
			TxtEMI.Text = openFileDialog.SafeFileName;
			Form1.SharedUI.TxtEMI.Text = openFileDialog.SafeFileName;
			Mediatek.Preloader = openFileDialog.FileName;
			Mediatek.Preloader2 = openFileDialog.FileName;
		}
		else
		{
			Form1.SharedUI.TxtEMI.Text = "";
			TxtEMI.Text = "";
			Mediatek.Preloader = null;
			Mediatek.Preloader2 = null;
		}
	}

	private async void Guna2Button2_Click(object sender, EventArgs e)
	{
		if (isMTKClientRunning)
		{
			return;
		}
		start();
		Form1.SharedUI.RichTextBox1.Clear();
		try
		{
			if (CkBromReady.Checked)
			{
				isMTKClientRunning = true;
				CancellationToken token = cts.Token;
				await Task.Run([SpecialName] () => MtkTask.Reboot(token));
				finshonly();
				isMTKClientRunning = false;
				try
				{
					cts.Cancel();
					MtkTask.closingport();
					cts.Token.ThrowIfCancellationRequested();
				}
				catch (OperationCanceledException projectError)
				{
					ProjectData.SetProjectError(projectError);
					cts = new CancellationTokenSource();
					isMTKClientRunning = false;
					ProjectData.ClearProjectError();
				}
			}
		}
		catch (OperationCanceledException projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			CkBromReady.Invoke((Action)([SpecialName] () =>
			{
				CkBromReady.Checked = false;
			}));
			isMTKClientRunning = false;
			ProjectData.ClearProjectError();
		}
		isMTKClientRunning = false;
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		if (!Form1.SharedUI.MaterialCard3.Enabled)
		{
			Guna2GroupBox4.Enabled = false;
		}
		else
		{
			if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
			{
				if (Conversions.ToDouble(Form1.SharedUI.Label25.Text) > 50.0)
				{
					PictureBox14.Visible = false;
					Guna2GroupBox4.Enabled = true;
				}
				else
				{
					PictureBox14.Visible = true;
					Guna2GroupBox4.Enabled = false;
				}
			}
			else
			{
				PictureBox14.Visible = false;
				Guna2GroupBox4.Enabled = true;
			}
			if (!CkBromReady.Checked)
			{
				buttonreboot.Enabled = false;
				Guna2GroupBox2.Enabled = false;
				BtnIdentify.Enabled = true;
			}
			else
			{
				buttonreboot.Enabled = true;
				Guna2GroupBox2.Enabled = true;
				BtnIdentify.Enabled = false;
			}
			if (Operators.CompareString(TxtScatter.Text, "", TextCompare: false) == 0)
			{
				BtnFlash.Enabled = false;
			}
			else
			{
				BtnFlash.Enabled = true;
			}
		}
		if (Operators.CompareString(SevaClass.canaclstring, "Can", TextCompare: false) == 0)
		{
			SevaClass.canaclstring = "";
			method_Cancel();
		}
	}

	public static string GetFileSize(long TheSize)
	{
		string result = "0KB";
		try
		{
			result = ((TheSize >= 1099511627776L) ? (Strings.FormatNumber((double)TheSize / 1099511627776.0, 2) + " TB") : ((TheSize >= 1073741824 && TheSize <= 1099511627775L) ? (Strings.FormatNumber((double)TheSize / 1073741824.0, 2) + " GB") : ((TheSize >= 1048576 && TheSize <= 1073741823) ? (Strings.FormatNumber((double)TheSize / 1048576.0, 2) + " MB") : ((TheSize >= 1024 && TheSize <= 1048575) ? (Strings.FormatNumber((double)TheSize / 1024.0, 2) + " KB") : ((TheSize >= 0 && TheSize <= 1023) ? (Strings.FormatNumber((double)TheSize, 2) + " bytes") : "")))));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public void CompressFilesInDirectory(string sourceDirectory, string destinationFile)
	{
		try
		{
			string[] files = Directory.GetFiles(sourceDirectory);
			ZipArchive val = ZipFile.Open(destinationFile, (ZipArchiveMode)1);
			try
			{
				string[] array = files;
				foreach (string text in array)
				{
					string fileName = Path.GetFileName(text);
					val.CreateEntryFromFile(text, fileName);
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public void LoadFilesIntoDataGridView(string folderPath, DataGridView dataGridView)
	{
		try
		{
			if (Directory.Exists(folderPath))
			{
				string[] files = Directory.GetFiles(folderPath);
				dataGridView.Rows.Clear();
				string[] array = files;
				foreach (string fileName in array)
				{
					FileInfo fileInfo = new FileInfo(fileName);
					string name = fileInfo.Name;
					string fullName = fileInfo.FullName;
					long length = new FileInfo(fullName).Length;
					dataGridView.Rows.Add(name.Replace(".img", "").Replace(".bin", ""), fullName, length);
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public void finshfile()
	{
		SerialCOM.MSL = null;
		try
		{
			cts.Cancel();
			MtkTask.closingport();
			cts.Token.ThrowIfCancellationRequested();
		}
		catch (OperationCanceledException ex)
		{
			ProjectData.SetProjectError(ex);
			OperationCanceledException ex2 = ex;
			cts = new CancellationTokenSource();
			isMTKClientRunning = false;
			ProjectData.ClearProjectError();
		}
		CkBromReady.Invoke((Action)([SpecialName] () =>
		{
			CkBromReady.Checked = false;
		}));
		isMTKClientRunning = false;
		Form1.SharedUI.MaterialButton8.Enabled = false;
		if (MtkTask.Timeout)
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "> Finish Operation Failed, Try Agine");
		}
		Form1.SharedUI.ProgressBar4.Visible = false;
		Form1.SharedUI.ProgressBar4.Value = 0;
		Form1.SharedUI.ProgressBar1.Text = "100%";
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.MaterialCard5.Enabled = true;
		Form1.SharedUI.MaterialCard3.Enabled = true;
		Form1.SharedUI.Guna2TaskBarProgress1.State = Guna2TaskBarProgress.TaskbarStates.Error;
		Form1.SharedUI.Guna2TaskBarProgress1.Value = 0;
		Form1.SharedUI.Guna2TaskBarProgress1.State = Guna2TaskBarProgress.TaskbarStates.Error;
		Form1.SharedUI.Guna2TaskBarProgress1.Value = 0;
		Form1.SharedUI.ProgressBar1.Roll = false;
		if (MtkTask.Timeout)
		{
			try
			{
				UiManager.ScanTemWav();
				Delay(2.0);
				File.Delete(Form1.String_9 + "tmp\\scan.wav");
				File.Delete(Form1.String_9 + "tmp\\wronganswer.wav");
				File.Delete(Form1.String_9 + "tmp\\wesreampung.wav");
				File.Delete(Form1.String_9 + "tmp\\notification.wav");
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ProjectData.ClearProjectError();
			}
		}
	}

	public void Delay(double dblSecs)
	{
		DateAndTime.Now.AddSeconds(1.15740740740741E-05);
		DateTime t = DateAndTime.Now.AddSeconds(1.15740740740741E-05).AddSeconds(dblSecs);
		while (DateTime.Compare(DateAndTime.Now, t) <= 0)
		{
			Application.DoEvents();
		}
	}

	private async void MaterialButton30_Click(object sender, EventArgs e)
	{
		if (ComboBoxPreloader.SelectedIndex == 0 && !isMTKClientRunning)
		{
			start();
			Form1.SharedUI.RichTextBox1.Clear();
			try
			{
				isMTKClientRunning = true;
				CancellationToken token = cts.Token;
				gui.Richlog("- Initializing Usb Device : ", Color.White);
				await Task.Run([SpecialName] () => MtkTask.InitCrashing(token));
				finshonly();
			}
			catch (OperationCanceledException projectError)
			{
				ProjectData.SetProjectError(projectError);
				CkBromReady.Invoke((Action)([SpecialName] () =>
				{
					CkBromReady.Checked = false;
				}));
				isMTKClientRunning = false;
				ProjectData.ClearProjectError();
			}
			isMTKClientRunning = false;
		}
		if (ComboBoxPreloader.SelectedIndex != 1 || isMTKClientRunning)
		{
			return;
		}
		start();
		Form1.SharedUI.RichTextBox1.Clear();
		try
		{
			isMTKClientRunning = true;
			CancellationToken token2 = cts.Token;
			gui.Richlog("- Initializing Usb Device : ", Color.White);
			await Task.Run([SpecialName] () => MtkTask.InitDump(token2));
			if (Operators.CompareString(MtkTask.CHECK, "no", TextCompare: false) == 0)
			{
				finshfile();
				return;
			}
			gui.Richlog("- Save File : ", Color.White);
			gui.Richlog(MtkTask.pre_dump, Color.FromArgb(0, 85, 207));
			Process.Start("explorer", "/select," + MtkTask.pre_dump);
			finshonly();
			try
			{
				cts.Cancel();
				MtkTask.closingport();
				cts.Token.ThrowIfCancellationRequested();
			}
			catch (OperationCanceledException projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				cts = new CancellationTokenSource();
				isMTKClientRunning = false;
				ProjectData.ClearProjectError();
			}
			CkBromReady.Invoke((Action)([SpecialName] () =>
			{
				CkBromReady.Checked = false;
			}));
			isMTKClientRunning = false;
		}
		catch (OperationCanceledException projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			CkBromReady.Invoke((Action)([SpecialName] () =>
			{
				CkBromReady.Checked = false;
			}));
			isMTKClientRunning = false;
			ProjectData.ClearProjectError();
		}
		isMTKClientRunning = false;
	}

	public void seva_file()
	{
		gui.Richlog("- Save File : ", Color.Black);
		Delay(1.0);
		string sourceDirectory = ThisLocation + "tmp\\ext";
		string fileDelete = FileDelete2;
		CompressFilesInDirectory(sourceDirectory, fileDelete);
		FileDelete2 = ThisLocation + "tmp\\ext";
		Delay(1.0);
		if (File.Exists(fileDelete))
		{
			gui.Richlog(fileDelete, Color.FromArgb(0, 85, 207));
		}
		else
		{
			gui.Richlog("Failed", Color.Red);
		}
		try
		{
			MyProject.Computer.FileSystem.DeleteDirectory(FileDelete2, DeleteDirectoryOption.DeleteAllContents);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		finshonly();
	}

	public void seva_file2()
	{
		gui.Richlog("", Color.White, isBold: false, NextLine: true);
		gui.Richlog("- Save Buckup File : ", Color.Black);
		Form1.SharedUI.ProgressBar1.Text = "Saveing Buckup..";
		Delay(1.0);
		string text = ThisLocation + "tmp\\ext";
		string text2 = FileDelete2.Replace(".zip", "_Buckup.zip");
		CompressFilesInDirectory(text, text2);
		Delay(1.0);
		if (File.Exists(text2))
		{
			gui.Richlog("OK", Color.Lime, isBold: false, NextLine: true);
			gui.Richlog("- Generation Unlock File : ", Color.Black);
			Form1.SharedUI.ProgressBar1.Text = "Generation..";
			if (Conversions.ToBoolean(Calculate(text + "\\protect1.img")))
			{
				Write(text + "\\protect1.img");
			}
			try
			{
				File.Delete(text + "\\protect2.img");
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			gui.Richlog(" OK", Color.Lime, isBold: false, NextLine: true);
			gui.Richlog("- Save Unlock File : ", Color.Black);
			Form1.SharedUI.ProgressBar1.Text = "Saveing Unlock..";
			text = ThisLocation + "tmp\\ext";
			text2 = FileDelete2.Replace(".zip", "_Unlock.zip");
			CompressFilesInDirectory(text, text2);
			Delay(1.0);
			if (File.Exists(text2))
			{
				gui.Richlog("OK", Color.Lime);
			}
			else
			{
				gui.Richlog("Failed", Color.Red);
			}
			FileDelete2 = ThisLocation + "tmp\\ext";
			try
			{
				MyProject.Computer.FileSystem.DeleteDirectory(FileDelete2, DeleteDirectoryOption.DeleteAllContents);
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ProjectData.ClearProjectError();
			}
			finshonly();
		}
		else
		{
			gui.Richlog("Failed", Color.Red, isBold: false, NextLine: true);
		}
	}

	public static object Calculate(string folderbackup)
	{
		hexx = ByteArrayToString(File.ReadAllBytes(folderbackup));
		if (hexx.Contains("535433385f30303030") | hexx.Contains("5354333341303030") | hexx.Contains("5354333441303030"))
		{
			if (hexx.Contains("535433385f30303030"))
			{
				return false;
			}
			if (hexx.Contains("5354333341303030") & hexx.Contains("5354333441303030"))
			{
				return false;
			}
		}
		if (hexx.Contains("535433385f30303830"))
		{
			hexxnew = hexx.Replace("535433385f30303830", "535433385f30303030");
			return true;
		}
		if (hexx.Contains("535433385f303038"))
		{
			hexxnew = hexx.Replace("535433385f303038", "535433385f303030");
			return true;
		}
		if (hexx.Contains("535433385f303039"))
		{
			hexxnew = hexx.Replace("535433385f303039", "535433385f303030");
			return true;
		}
		if (hexx.Contains("535433385f30303833"))
		{
			hexxnew = hexx.Replace("535433385f30303833", "535433385f30303030");
			return true;
		}
		if (hexx.Contains("5354333341303039"))
		{
			hexxnew = hexx.Replace("5354333341303039", "5354333341303030");
			return true;
		}
		if (hexx.Contains("5354333441303031"))
		{
			hexxnew = hexx.Replace("5354333441303031", "5354333441303030");
			return true;
		}
		object result = default(object);
		return result;
	}

	public static string ByteArrayToString(byte[] ba)
	{
		StringBuilder stringBuilder = new StringBuilder(checked(ba.Length * 2));
		foreach (byte b in ba)
		{
			stringBuilder.AppendFormat("{0:x2}", b);
		}
		return stringBuilder.ToString();
	}

	public static object Write(string theEncryptedFile)
	{
		checked
		{
			byte[] array = new byte[unchecked(hexxnew.Length / 2) - 1 + 1];
			int num = array.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				array[i] = Convert.ToByte(hexxnew.Substring(i * 2, 2), 16);
			}
			try
			{
				File.Delete(theEncryptedFile);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			using (StreamWriter streamWriter = File.AppendText(theEncryptedFile))
			{
				streamWriter.Write("");
				streamWriter.Flush();
				streamWriter.Close();
			}
			File.WriteAllBytes(theEncryptedFile, array);
			object result = default(object);
			return result;
		}
	}

	private async void Guna2Button2_Click_1(object sender, EventArgs e)
	{
		if (ComboBoxSecurity.SelectedIndex == 0)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Title = "Select Backup.zip";
			saveFileDialog.Filter = "backup.zip (*.zip)|*.zip";
			saveFileDialog.FileName = "backup.zip";
			saveFileDialog.FilterIndex = 2;
			saveFileDialog.RestoreDirectory = true;
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				FileDelete2 = saveFileDialog.FileName;
				try
				{
					MyProject.Computer.FileSystem.DeleteDirectory(FileDelete2, DeleteDirectoryOption.DeleteAllContents);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				if (!isMTKClientRunning)
				{
					start();
					try
					{
						Form1.SharedUI.RichTextBox1.Clear();
						isMTKClientRunning = true;
						CancellationToken token = cts.Token;
						string text = ThisLocation + "tmp\\ext\\";
						if (!Directory.Exists(text))
						{
							Directory.CreateDirectory(text);
						}
						if (CkBromReady.Checked)
						{
							await Task.Run([SpecialName] () => MtkTask.BackupNV(text, token));
							new Thread(seva_file).Start();
						}
						else
						{
							gui.Richlog("- Initializing Usb Device : ", Color.White);
							await Task.Run([SpecialName] () => MtkTask.InitAsync2(token));
							if (Operators.CompareString(MtkTask.CHECK, "no", TextCompare: false) == 0)
							{
								finshfile();
								return;
							}
							gui.Richlog("", Color.White, isBold: false, NextLine: true);
							await Task.Run([SpecialName] () => MtkTask.BackupNV(text, token));
							new Thread(seva_file).Start();
						}
					}
					catch (OperationCanceledException projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						CkBromReady.Invoke((Action)([SpecialName] () =>
						{
							CkBromReady.Checked = false;
						}));
						isMTKClientRunning = false;
						ProjectData.ClearProjectError();
					}
					isMTKClientRunning = false;
				}
			}
		}
		if (ComboBoxSecurity.SelectedIndex == 1)
		{
			UiManager.wronganswer();
			Form1.SharedUI.Guna2MessageDialog3.Text = "This Process Will Erase Security Do You Want To Continue";
			if (Form1.SharedUI.Guna2MessageDialog3.Show() == DialogResult.OK)
			{
				if (isMTKClientRunning)
				{
					return;
				}
				start();
				try
				{
					isMTKClientRunning = true;
					CancellationToken token2 = cts.Token;
					if (CkBromReady.Checked)
					{
						gui.Richlog("- Erasing Security #Block 0 : ", Color.Black);
						await Task.Run([SpecialName] () => MtkTask.EraseNV(token2));
						gui.Richlog("- Erasing Security #Block 1 : ", Color.Black);
						await Task.Run([SpecialName] () => MtkTask.EraseNV(token2));
						gui.Richlog("- Erasing Security #Block 2 : ", Color.Black);
						await Task.Run([SpecialName] () => MtkTask.EraseNV(token2));
						gui.Richlog("- Erasing Security #Block 3 : ", Color.Black);
						await Task.Run([SpecialName] () => MtkTask.EraseNV(token2));
						gui.Richlog("- Erasing Security #Block 4 : ", Color.Black);
						await Task.Run([SpecialName] () => MtkTask.EraseNV(token2));
					}
					else
					{
						gui.Richlog("- Initializing Usb Device : ", Color.White);
						await Task.Run([SpecialName] () => MtkTask.InitAsync2(token2));
						if (Operators.CompareString(MtkTask.CHECK, "no", TextCompare: false) == 0)
						{
							finshfile();
							return;
						}
						gui.Richlog("", Color.White, isBold: false, NextLine: true);
						gui.Richlog("- Erasing Security #Block 0 : ", Color.Black);
						await Task.Run([SpecialName] () => MtkTask.EraseNV(token2));
						gui.Richlog("- Erasing Security #Block 1 : ", Color.Black);
						await Task.Run([SpecialName] () => MtkTask.EraseNV(token2));
						gui.Richlog("- Erasing Security #Block 2 : ", Color.Black);
						await Task.Run([SpecialName] () => MtkTask.EraseNV(token2));
						gui.Richlog("- Erasing Security #Block 3 : ", Color.Black);
						await Task.Run([SpecialName] () => MtkTask.EraseNV(token2));
						gui.Richlog("- Erasing Security #Block 4 : ", Color.Black);
						await Task.Run([SpecialName] () => MtkTask.EraseNV(token2));
					}
					finshonly();
				}
				catch (OperationCanceledException projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					CkBromReady.Invoke((Action)([SpecialName] () =>
					{
						CkBromReady.Checked = false;
					}));
					isMTKClientRunning = false;
					ProjectData.ClearProjectError();
				}
				isMTKClientRunning = false;
			}
			else
			{
				Form1.SharedUI.RichTextBox1.Clear();
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
				Form1.SharedUI.RichTextBox1.AppendText("Cancel By User");
				finshonly();
			}
		}
		else
		{
			if (ComboBoxSecurity.SelectedIndex != 2)
			{
				return;
			}
			string directory = ThisLocation + "tmp\\ext";
			try
			{
				MyProject.Computer.FileSystem.DeleteDirectory(directory, DeleteDirectoryOption.DeleteAllContents);
			}
			catch (Exception projectError4)
			{
				ProjectData.SetProjectError(projectError4);
				ProjectData.ClearProjectError();
			}
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Title = "Select Restore.zip";
			openFileDialog.Filter = ".zip | *.zip|.zip | *.zip";
			openFileDialog.FilterIndex = 1;
			openFileDialog.RestoreDirectory = true;
			if (openFileDialog.ShowDialog() != DialogResult.OK)
			{
				return;
			}
			start();
			Select_Prtitoin.FileName = openFileDialog.FileName;
			Select_Prtitoin.Fileto = ThisLocation + "tmp\\ext\\";
			new Select_Prtitoin().ShowDialog();
			if (Operators.CompareString(Select_Prtitoin.DialogResultt, "OK", TextCompare: false) == 0)
			{
				string folderPath = ThisLocation + "tmp\\ext\\";
				LoadFilesIntoDataGridView(folderPath, DataGridView1);
				if (isMTKClientRunning)
				{
					return;
				}
				try
				{
					Form1.SharedUI.RichTextBox1.Clear();
					isMTKClientRunning = true;
					CancellationToken token3 = cts.Token;
					string folder = ThisLocation + "tmp\\ext\\";
					if (CkBromReady.Checked)
					{
						await Task.Run([SpecialName] () => MtkTask.WriteNV2(folder, token3));
					}
					else
					{
						gui.Richlog("- Initializing Usb Device : ", Color.White);
						await Task.Run([SpecialName] () => MtkTask.InitAsync2(token3));
						if (Operators.CompareString(MtkTask.CHECK, "no", TextCompare: false) == 0)
						{
							finshfile();
							return;
						}
						gui.Richlog("", Color.White, isBold: false, NextLine: true);
						await Task.Run([SpecialName] () => MtkTask.WriteNV2(folder, token3));
					}
					try
					{
						MyProject.Computer.FileSystem.DeleteDirectory(directory, DeleteDirectoryOption.DeleteAllContents);
					}
					catch (Exception projectError5)
					{
						ProjectData.SetProjectError(projectError5);
						ProjectData.ClearProjectError();
					}
					finshonly();
				}
				catch (OperationCanceledException projectError6)
				{
					ProjectData.SetProjectError(projectError6);
					CkBromReady.Invoke((Action)([SpecialName] () =>
					{
						CkBromReady.Checked = false;
					}));
					isMTKClientRunning = false;
					ProjectData.ClearProjectError();
				}
				isMTKClientRunning = false;
			}
			else
			{
				finshonly();
			}
		}
	}

	private async void Guna2Button1_Click_1(object sender, EventArgs e)
	{
		if (DataViewmtk.Rows.Count > 0)
		{
			if (isMTKClientRunning)
			{
				return;
			}
			DataViewmtk.ClearSelection();
			bool flag = false;
			foreach (DataGridViewRow item in (IEnumerable)DataViewmtk.Rows)
			{
				if (Convert.ToBoolean(RuntimeHelpers.GetObjectValue(item.Cells[0].Value)))
				{
					flag = true;
					break;
				}
			}
			if (flag)
			{
				_Closure_0024__364_002D0 arg = default(_Closure_0024__364_002D0);
				Form1 sharedUI = Form1.SharedUI;
				if (new FolderPicker().ShowDialog(sharedUI) != DialogResult.OK)
				{
					return;
				}
				arg._0024VB_0024Local_folder = UiManager.Selected_Folder;
				start();
				try
				{
					_Closure_0024__364_002D1 arg2 = default(_Closure_0024__364_002D1);
					_Closure_0024__364_002D1 CS_0024_003C_003E8__locals0 = new _Closure_0024__364_002D1(arg2);
					CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2 = arg;
					isMTKClientRunning = true;
					CS_0024_003C_003E8__locals0._0024VB_0024Local_token = cts.Token;
					if (CkBromReady.Checked)
					{
						await Task.Run([SpecialName] () => MtkTask.Read2(CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_folder, CS_0024_003C_003E8__locals0._0024VB_0024Local_token));
					}
					else
					{
						gui.Richlog("- Initializing Usb Device : ", Color.White);
						await Task.Run([SpecialName] () => MtkTask.InitAsync2(CS_0024_003C_003E8__locals0._0024VB_0024Local_token));
						if (Operators.CompareString(MtkTask.CHECK, "no", TextCompare: false) == 0)
						{
							finshfile();
							return;
						}
						gui.Richlog("", Color.White, isBold: false, NextLine: true);
						await Task.Run([SpecialName] () => MtkTask.Read2(CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_folder, CS_0024_003C_003E8__locals0._0024VB_0024Local_token));
					}
					finshonly();
				}
				catch (OperationCanceledException projectError)
				{
					ProjectData.SetProjectError(projectError);
					CkBromReady.Invoke((Action)([SpecialName] () =>
					{
						CkBromReady.Checked = false;
					}));
					isMTKClientRunning = false;
					ProjectData.ClearProjectError();
				}
				isMTKClientRunning = false;
			}
			else
			{
				gui.Richlog("- Sorry, Select The Partition First", Color.Red);
				finshonly();
			}
		}
		else
		{
			gui.Richlog("- Sorry, Connect Brom", Color.Red);
			finshonly();
		}
	}

	private async void Guna2Button3_Click(object sender, EventArgs e)
	{
		bool flag = default(bool);
		foreach (DataGridViewRow item in (IEnumerable)SharedUI.DataViewmtk.Rows)
		{
			if (Convert.ToBoolean(RuntimeHelpers.GetObjectValue(item.Cells[0].Value)))
			{
				flag = (((Operators.CompareString(item.Cells[2].Value.ToString(), "nvdata", TextCompare: false) == 0) | (Operators.CompareString(item.Cells[2].Value.ToString(), "nvram", TextCompare: false) == 0) | (Operators.CompareString(item.Cells[2].Value.ToString(), "protect1", TextCompare: false) == 0) | (Operators.CompareString(item.Cells[2].Value.ToString(), "protect2", TextCompare: false) == 0)) ? true : false);
			}
		}
		if (flag)
		{
			UiManager.wronganswer();
			Form1.SharedUI.Guna2MessageDialog3.Text = "This Process Will Erase Security Do You Want To Continue";
			if (Form1.SharedUI.Guna2MessageDialog3.Show() == DialogResult.OK)
			{
				if (DataViewmtk.Rows.Count > 0)
				{
					if (isMTKClientRunning)
					{
						return;
					}
					start();
					bool flag2 = false;
					DataViewmtk.ClearSelection();
					foreach (DataGridViewRow item2 in (IEnumerable)DataViewmtk.Rows)
					{
						if (Convert.ToBoolean(RuntimeHelpers.GetObjectValue(item2.Cells[0].Value)))
						{
							flag2 = true;
							break;
						}
					}
					if (flag2)
					{
						Form1.SharedUI.RichTextBox1.Clear();
						try
						{
							_Closure_0024__365_002D0 arg = default(_Closure_0024__365_002D0);
							_Closure_0024__365_002D0 CS_0024_003C_003E8__locals1 = new _Closure_0024__365_002D0(arg);
							isMTKClientRunning = true;
							CS_0024_003C_003E8__locals1._0024VB_0024Local_token = cts.Token;
							if (CkBromReady.Checked)
							{
								await Task.Run([SpecialName] () => MtkTask.Erase(CS_0024_003C_003E8__locals1._0024VB_0024Local_token));
							}
							else
							{
								gui.Richlog("- Initializing Usb Device : ", Color.White);
								await Task.Run([SpecialName] () => MtkTask.InitAsync2(CS_0024_003C_003E8__locals1._0024VB_0024Local_token));
								if (Operators.CompareString(MtkTask.CHECK, "no", TextCompare: false) == 0)
								{
									finshfile();
									return;
								}
								gui.Richlog("", Color.White, isBold: false, NextLine: true);
								await Task.Run([SpecialName] () => MtkTask.Erase(CS_0024_003C_003E8__locals1._0024VB_0024Local_token));
							}
							finshonly();
						}
						catch (OperationCanceledException projectError)
						{
							ProjectData.SetProjectError(projectError);
							CkBromReady.Invoke((Action)([SpecialName] () =>
							{
								CkBromReady.Checked = false;
							}));
							isMTKClientRunning = false;
							ProjectData.ClearProjectError();
						}
					}
					else
					{
						gui.Richlog("- Sorry, Select The Partition First", Color.Red);
						finshonly();
					}
					isMTKClientRunning = false;
				}
				else
				{
					gui.Richlog("- Sorry, Connect Brom", Color.Red);
					finshonly();
				}
			}
			else
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
				Form1.SharedUI.RichTextBox1.AppendText("Cancel By User");
				finshonly();
			}
		}
		else if (DataViewmtk.Rows.Count > 0)
		{
			if (isMTKClientRunning)
			{
				return;
			}
			start();
			bool flag3 = false;
			DataViewmtk.ClearSelection();
			foreach (DataGridViewRow item3 in (IEnumerable)DataViewmtk.Rows)
			{
				if (Convert.ToBoolean(RuntimeHelpers.GetObjectValue(item3.Cells[0].Value)))
				{
					flag3 = true;
					break;
				}
			}
			if (flag3)
			{
				Form1.SharedUI.RichTextBox1.Clear();
				try
				{
					_Closure_0024__365_002D1 arg2 = default(_Closure_0024__365_002D1);
					_Closure_0024__365_002D1 CS_0024_003C_003E8__locals0 = new _Closure_0024__365_002D1(arg2);
					isMTKClientRunning = true;
					CS_0024_003C_003E8__locals0._0024VB_0024Local_token = cts.Token;
					if (CkBromReady.Checked)
					{
						await Task.Run([SpecialName] () => MtkTask.Erase(CS_0024_003C_003E8__locals0._0024VB_0024Local_token));
					}
					else
					{
						gui.Richlog("- Initializing Usb Device : ", Color.White);
						await Task.Run([SpecialName] () => MtkTask.InitAsync2(CS_0024_003C_003E8__locals0._0024VB_0024Local_token));
						if (Operators.CompareString(MtkTask.CHECK, "no", TextCompare: false) == 0)
						{
							finshfile();
							return;
						}
						gui.Richlog("", Color.White, isBold: false, NextLine: true);
						await Task.Run([SpecialName] () => MtkTask.Erase(CS_0024_003C_003E8__locals0._0024VB_0024Local_token));
					}
					finshonly();
				}
				catch (OperationCanceledException projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					CkBromReady.Invoke((Action)([SpecialName] () =>
					{
						CkBromReady.Checked = false;
					}));
					isMTKClientRunning = false;
					ProjectData.ClearProjectError();
				}
			}
			else
			{
				gui.Richlog("- Sorry, Select The Partition First", Color.Red);
				finshonly();
			}
			isMTKClientRunning = false;
		}
		else
		{
			gui.Richlog("- Sorry, Connect Brom", Color.Red);
			finshonly();
		}
	}

	private async void Guna2Button5_Click(object sender, EventArgs e)
	{
		if (DataViewmtk.Rows.Count > 0)
		{
			Form1.SharedUI.RichTextBox1.Clear();
			if (Conversions.ToInteger(RuntimeHelpers.GetObjectValue(ShowSelectedCheckBoxCount())) == 1)
			{
				OpenFileDialog openFileDialog = new OpenFileDialog();
				openFileDialog.Title = "Select File Partition " + DataViewmtk.CurrentRow.Cells[2].Value.ToString();
				openFileDialog.Filter = "All File  (*.*)|*.*";
				openFileDialog.FilterIndex = 1;
				openFileDialog.RestoreDirectory = true;
				if (openFileDialog.ShowDialog() != DialogResult.OK)
				{
					return;
				}
				start();
				long length = new FileInfo(openFileDialog.FileName).Length;
				long num = Convert.ToInt64(utils.HexToLong(DataViewmtk.CurrentRow.Cells[4].Value.ToString().Replace("0x", "")));
				if (length > num)
				{
					gui.Richlog("- Sorry, The Size Of File Is Larger Than The Partition Size", Color.Red);
					finshonly();
					return;
				}
				DataViewmtk.CurrentRow.Cells[6].Value = openFileDialog.FileName;
				if (isMTKClientRunning)
				{
					return;
				}
				bool flag = false;
				foreach (DataGridViewRow item in (IEnumerable)DataViewmtk.Rows)
				{
					if (Convert.ToBoolean(RuntimeHelpers.GetObjectValue(item.Cells[0].Value)))
					{
						flag = true;
						break;
					}
				}
				if (flag)
				{
					Form1.SharedUI.RichTextBox1.Clear();
					try
					{
						_Closure_0024__366_002D0 arg = default(_Closure_0024__366_002D0);
						_Closure_0024__366_002D0 CS_0024_003C_003E8__locals0 = new _Closure_0024__366_002D0(arg);
						isMTKClientRunning = true;
						CS_0024_003C_003E8__locals0._0024VB_0024Local_token = cts.Token;
						if (CkBromReady.Checked)
						{
							await Task.Run([SpecialName] () => MtkTask.Flash(CS_0024_003C_003E8__locals0._0024VB_0024Local_token));
						}
						else
						{
							gui.Richlog("- Initializing Usb Device : ", Color.White);
							await Task.Run([SpecialName] () => MtkTask.InitAsync2(CS_0024_003C_003E8__locals0._0024VB_0024Local_token));
							if (Operators.CompareString(MtkTask.CHECK, "no", TextCompare: false) == 0)
							{
								finshfile();
								return;
							}
							gui.Richlog("", Color.White, isBold: false, NextLine: true);
							await Task.Run([SpecialName] () => MtkTask.Flash(CS_0024_003C_003E8__locals0._0024VB_0024Local_token));
						}
						isMTKClientRunning = false;
						finshonly();
					}
					catch (OperationCanceledException projectError)
					{
						ProjectData.SetProjectError(projectError);
						CkBromReady.Invoke((Action)([SpecialName] () =>
						{
							CkBromReady.Checked = false;
						}));
						isMTKClientRunning = false;
						ProjectData.ClearProjectError();
					}
					finally
					{
						string path = Application.StartupPath + "\\tmp";
						if (Directory.Exists(path))
						{
							DirectoryInfo directoryInfo = new DirectoryInfo(path);
							foreach (FileInfo item2 in directoryInfo.EnumerateFiles())
							{
								item2.Delete();
							}
							foreach (DirectoryInfo item3 in directoryInfo.EnumerateDirectories())
							{
								item3.Delete(recursive: true);
							}
							directoryInfo.Delete(recursive: true);
						}
					}
				}
				else
				{
					gui.Richlog("- Sorry, Select The Partition First", Color.Red);
					finshonly();
				}
				isMTKClientRunning = false;
			}
			else
			{
				gui.Richlog("- Sorry, It Is Not Possible To Write More Than One File From Here", Color.Red);
				finshonly();
			}
		}
		else
		{
			gui.Richlog("- Sorry, Connect Brom", Color.Red);
			finshonly();
		}
	}

	private void Guna2GroupBox4_Click(object sender, EventArgs e)
	{
	}

	private void Protocol_MTK_By_Devronix_Load(object sender, EventArgs e)
	{
		PictureBox14.Enabled = true;
		if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
		{
			if (Conversions.ToDouble(Form1.SharedUI.Label25.Text) > 50.0)
			{
				PictureBox14.Visible = false;
			}
			else
			{
				PictureBox14.Visible = true;
			}
		}
		else
		{
			PictureBox14.Visible = false;
		}
	}

	private void DataViewmtk_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void DataViewmtk_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
		if (((e.ColumnIndex == 2) & (e.Value != null)) && Operators.CompareString(Convert.ToString(RuntimeHelpers.GetObjectValue(e.Value)), "nvdata", TextCompare: false) == 0)
		{
			e.CellStyle.ForeColor = Color.Red;
		}
		if (((e.ColumnIndex == 2) & (e.Value != null)) && Operators.CompareString(Convert.ToString(RuntimeHelpers.GetObjectValue(e.Value)), "nvram", TextCompare: false) == 0)
		{
			e.CellStyle.ForeColor = Color.Red;
		}
		if (((e.ColumnIndex == 2) & (e.Value != null)) && Operators.CompareString(Convert.ToString(RuntimeHelpers.GetObjectValue(e.Value)), "protect1", TextCompare: false) == 0)
		{
			e.CellStyle.ForeColor = Color.Red;
		}
		if (((e.ColumnIndex == 2) & (e.Value != null)) && Operators.CompareString(Convert.ToString(RuntimeHelpers.GetObjectValue(e.Value)), "protect2", TextCompare: false) == 0)
		{
			e.CellStyle.ForeColor = Color.Red;
		}
	}

	private void Guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
	{
		if (Guna2CheckBox1.Checked)
		{
			BtnEMI1.Enabled = true;
			TxtEMI.Enabled = true;
			return;
		}
		TxtEMI.Text = "";
		Mediatek.Preloader = null;
		Mediatek.Preloader2 = null;
		BtnEMI1.Enabled = false;
		TxtEMI.Enabled = false;
	}

	private void Guna2CheckBox2_CheckedChanged(object sender, EventArgs e)
	{
		if (DataViewmtk.Rows.Count <= 0)
		{
			return;
		}
		if (!Guna2CheckBox2.Checked)
		{
			{
				foreach (DataGridViewRow item in (IEnumerable)DataViewmtk.Rows)
				{
					item.Cells[0].Value = false;
				}
				return;
			}
		}
		foreach (DataGridViewRow item2 in (IEnumerable)DataViewmtk.Rows)
		{
			item2.Cells[0].Value = true;
		}
	}

	private void MaterialButton41_Click(object sender, EventArgs e)
	{
		startNew();
		String_28 = new Thread(MethodD_197);
		String_28.Start();
	}

	public void startNew()
	{
		if (Operators.CompareString(TxtEMI.Text, "", TextCompare: false) == 0)
		{
			Mediatek.Preloader = null;
		}
		device_info.model = "";
		SerialCOM.MSL = null;
		if ((Operators.CompareString(Form1.TextBox41, "Cancel", TextCompare: false) == 0) | (Operators.CompareString(Services_Network.cancel, "Cancel", TextCompare: false) == 0))
		{
			Services_Network.cancel = "";
			Form1.TextBox41 = "";
		}
		device_info.Android = "......";
		device_info.Android = "......";
		Form1.SharedUI.RichTextBox1.Clear();
		try
		{
			File.Delete(Form1.String_9 + "tmp\\scan.wav");
			File.Delete(Form1.String_9 + "tmp\\wronganswer.wav");
			File.Delete(Form1.String_9 + "tmp\\wesreampung.wav");
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		String_35 = null;
		StartProcess();
		Form1.SharedUI.ProgressBar1.Text = "100%";
		Form1.SharedUI.Guna2TaskBarProgress1.Value = 0;
		Form1.SharedUI.ProgressBar4.Value = 0;
		Form1.SharedUI.ProgressBar4.Maximum = 100;
		Form1.SharedUI.Guna2TaskBarProgress1.State = Guna2TaskBarProgress.TaskbarStates.Indeterminate;
		Form1.SharedUI.ProgressBar1.Roll = true;
		Form1.SharedUI.MaterialCard3.Enabled = false;
		Form1.SharedUI.MaterialCard5.Enabled = false;
		Form1.SharedUI.MaterialButton8.Enabled = true;
		Form1.SharedUI.RichTextBox1.Clear();
	}

	public async Task MethodD_43()
	{
		if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
		{
			if (Conversions.ToDouble(String_75) == 0.0)
			{
				String_75 = Conversions.ToString(0);
				return;
			}
			Balancepdateclass ggg = new Balancepdateclass
			{
				username = SevaClass.Userr,
				token = SevaClass.Token,
				Credit = Convert.ToDecimal(String_75),
				OprationType = String_35,
				Modle = device_info.model,
				Sn = device_info.serialno
			};
			new Balancepdatetregg();
			Balancepdatetregg balancepdatetregg = await Balancepdate.cost(ggg);
			Form1.SharedUI.Label25.Text = Conversions.ToString(balancepdatetregg.Creditusernew);
			SevaClass.credits = Form1.SharedUI.Label25.Text;
		}
		else if (Conversions.ToDouble(String_75) == 0.0)
		{
			String_75 = Conversions.ToString(0);
		}
		else
		{
			Balancepdateclass ggg2 = new Balancepdateclass
			{
				username = SevaClass.Userr,
				token = SevaClass.Token,
				Credit = Convert.ToDecimal(String_75),
				OprationType = String_35,
				Modle = device_info.model,
				Sn = device_info.serialno
			};
			new Balancepdatetregg();
			Balancepdatetregg balancepdatetregg2 = await Balancepdate.cost(ggg2);
			Form1.SharedUI.Label25.Text = Conversions.ToString(balancepdatetregg2.Creditusernew);
			SevaClass.credits = Form1.SharedUI.Label25.Text;
		}
	}

	public async Task MethodD_44()
	{
		OperationToolapi ggg = new OperationToolapi
		{
			Userame = SevaClass.Userr,
			token = SevaClass.Token,
			Hwid = SevaClass.IDRegistration,
			androidos = "Unknown",
			Baseband = Form1.baseband,
			Brand = "Unknown",
			Carrier = "Unknown",
			Credit = Convert.ToDecimal(String_75),
			Imei = "Unknown",
			modle = device_info.model,
			OprationStatus = true,
			OprationTypes = String_35,
			PhoneId = device_info.serialno,
			SN = device_info.serialno,
			LogOpration = log
		};
		Protocol_MTK_By_Devronix protocol_MTK_By_Devronix = this;
		TaskAwaiter<string> taskAwaiter = Send_Log.sndlogm(ggg).GetAwaiter();
		if (!taskAwaiter.IsCompleted)
		{
			//await taskAwaiter;
			TaskAwaiter<string> taskAwaiter2 = default(TaskAwaiter<string>);
			taskAwaiter = taskAwaiter2;
		}
		protocol_MTK_By_Devronix.String_24 = taskAwaiter.GetResult();
	}

	public void finshNew()
	{
		string text = Conversions.ToString(ShowElapsedTime());
		checked
		{
			try
			{
				try
				{
					cts.Cancel();
					MtkTask.closingport();
					cts.Token.ThrowIfCancellationRequested();
				}
				catch (OperationCanceledException ex)
				{
					ProjectData.SetProjectError(ex);
					OperationCanceledException ex2 = ex;
					cts = new CancellationTokenSource();
					isMTKClientRunning = false;
					ProjectData.ClearProjectError();
				}
				SerialCOM.MSL = null;
				Form1.SharedUI.MaterialButton8.Enabled = false;
				Form1.SharedUI.MaterialButton20.Enabled = true;
				Form1.SharedUI.ProgressBar4.Visible = false;
				Form1.SharedUI.ProgressBar4.Value = 0;
				Form1.SharedUI.ProgressBar1.Text = "Finish Server Data..";
				if (Operators.CompareString(String_35, "", TextCompare: false) != 0)
				{
					log = Form1.SharedUI.RichTextBox1.Text;
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
					Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- ID Operation : ");
					Form1.SharedUI.RichTextBox1.Update();
					if (!UiManager.IsOnline())
					{
						int num = Conversions.ToInteger(Form1.SharedUI.Label25.Text);
						num = (int)Math.Round((double)num - Conversions.ToDouble(Form1.String_75));
						Form1.SharedUI.Label25.Text = Conversions.ToString(num);
						int num2 = Conversions.ToInteger(Form1.SharedUI.Temp_Credits.Text);
						num2 = (int)Math.Round((double)num2 + Conversions.ToDouble(Form1.String_75));
						Form1.SharedUI.Temp_Credits.Text = Conversions.ToString(num2);
						lass0.PortShow();
						Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
						Form1.SharedUI.RichTextBox1.AppendText("Check The Internet Connection");
						Form1.SharedUI.ProgressBar1.Roll = false;
						Form1.SharedUI.ProgressBar1.Text = "100%";
						Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
						Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Time Elapsed : ");
						Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
						Form1.SharedUI.RichTextBox1.AppendText(text);
						Form1.SharedUI.Guna2TaskBarProgress1.State = Guna2TaskBarProgress.TaskbarStates.Normal;
						Form1.SharedUI.Guna2TaskBarProgress1.Value = 0;
						Form1.SharedUI.ProgressBar1.Roll = false;
						Form1.SharedUI.ProgressBar1.Text = "100%";
						UiManager.wesreampung_wav();
						Form1.SharedUI.MaterialCard3.Enabled = false;
						Form1.SharedUI.MaterialCard5.Enabled = false;
						UiManager.MethodD_165();
					}
					else
					{
						if (Operators.CompareString(device_info.Android, "......", TextCompare: false) == 0)
						{
							device_info.model = Mediatek.Platform;
							Form1.baseband = Mediatek.basebandmtk;
							device_info.serialno = Mediatek.mied;
						}
						Task.Run([SpecialName] async () =>
						{
							await MethodD_43();
						}).Wait();
						Task.Run([SpecialName] async () =>
						{
							await MethodD_44();
						}).Wait();
					}
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
					Form1.SharedUI.RichTextBox1.AppendText(String_24);
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
					Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Time Elapsed : ");
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
					Form1.SharedUI.RichTextBox1.AppendText(text);
					Form1.SharedUI.RichTextBox1.Update();
					Form1.SharedUI.Guna2TaskBarProgress1.State = Guna2TaskBarProgress.TaskbarStates.Normal;
					Form1.SharedUI.Guna2TaskBarProgress1.Value = 0;
					Form1.SharedUI.Guna2TaskBarProgress1.State = Guna2TaskBarProgress.TaskbarStates.Normal;
					Form1.SharedUI.Guna2TaskBarProgress1.Value = 0;
					Form1.SharedUI.ProgressBar1.Roll = false;
					Form1.SharedUI.ProgressBar1.Text = "100%";
					Form1.SharedUI.MaterialButton8.Enabled = false;
					Form1.SharedUI.MaterialCard3.Enabled = true;
					Form1.SharedUI.MaterialCard5.Enabled = true;
					String_75 = Conversions.ToString(0);
					UiManager.wesreampung_wav();
				}
				else
				{
					Form1.SharedUI.RichTextBox1.Update();
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
					Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Time Elapsed : ");
					Form1.SharedUI.MaterialButton8.Enabled = false;
					Form1.SharedUI.MaterialCard3.Enabled = true;
					Form1.SharedUI.MaterialCard5.Enabled = true;
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
					Form1.SharedUI.RichTextBox1.AppendText(text);
					Form1.SharedUI.ProgressBar1.Roll = false;
					Form1.SharedUI.ProgressBar1.Text = "100%";
					Form1.SharedUI.Guna2TaskBarProgress1.State = Guna2TaskBarProgress.TaskbarStates.Normal;
					Form1.SharedUI.Guna2TaskBarProgress1.Value = 0;
					Form1.SharedUI.Guna2TaskBarProgress1.State = Guna2TaskBarProgress.TaskbarStates.Normal;
					Form1.SharedUI.Guna2TaskBarProgress1.Value = 0;
					UiManager.wesreampung_wav();
				}
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ProjectData.ClearProjectError();
			}
		}
	}

	private async void MethodD_197()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText("- Checking Drivers Mtk Usb : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.ProgressBar1.Text = "Checking...";
		if (File.Exists("C:/Program Files/UsbDk Runtime Library/UsbDk.inf"))
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringO);
			if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0 && Conversions.ToDouble(Form1.SharedUI.Label25.Text) == 0.0)
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + ClassDevronix.YDNHBPR);
				finshonly();
				return;
			}
			String_35 = "Remove FRP [Brom]";
			Form1.SharedUI.RichTextBox1.Update();
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + ClassDevronix.UAWC);
			Form1.SharedUI.ProgressBar1.Text = "Waiting..";
			UiManager.wronganswer();
			if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
			{
				String_75 = Conversions.ToString(1);
			}
			else
			{
				String_75 = Conversions.ToString(0);
			}
			if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
			{
				Form1.SharedUI.Guna2MessageDialog3.Text = ClassDevronix.TPWCY + String_75 + " Credits Do You Want To Continue";
			}
			else
			{
				if (Conversions.ToDouble(String_75) == 0.0)
				{
					Form1.SharedUI.Guna2MessageDialog3.Text = "This Process Will Be You Free Do You Want To Continue";
				}
				if (Conversions.ToDouble(String_75) == 1.0)
				{
					Form1.SharedUI.Guna2MessageDialog3.Text = "This Process Will Be You Free Do You Want To Continue";
				}
				if (Conversions.ToDouble(String_75) == 2.0)
				{
					Form1.SharedUI.Guna2MessageDialog3.Text = "This Process Will Be You Free Do You Want To Continue";
				}
			}
			if (Form1.SharedUI.Guna2MessageDialog3.Show() == DialogResult.OK)
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringO);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Initializing Usb : ");
				Form1.SharedUI.ProgressBar1.Text = "Initializing..";
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.ProgressBar1.Text = "Initializing...";
				if (!isMTKClientRunning)
				{
					try
					{
						isMTKClientRunning = true;
						CancellationToken token = cts.Token;
						await Task.Run([SpecialName] () => MtkTask.InitAsync(token));
						if (Operators.CompareString(MtkTask.CHECK, "no", TextCompare: false) == 0)
						{
							finshfile();
						}
						else
						{
							await Task.Run([SpecialName] () => MtkTask.EraseFRP(token));
							if (Operators.CompareString(MtkTask.CHECK, "no", TextCompare: false) == 0)
							{
								finshfile();
							}
							else
							{
								finshNew();
							}
							Form1.SharedUI.ProgressBar1.Text = "Remove FRP Done!";
						}
					}
					catch (OperationCanceledException projectError)
					{
						ProjectData.SetProjectError(projectError);
						isMTKClientRunning = false;
						ProjectData.ClearProjectError();
					}
					isMTKClientRunning = false;
				}
				else
				{
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
					Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringF);
					finshfile();
				}
			}
			else
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
				Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.CBU);
				finshonly();
			}
		}
		else
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringF);
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + ClassDevronix.YNIDUPIATA);
			finshonly();
		}
	}

	private async void MethodD_297()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText("- Checking Drivers Mtk Usb : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.ProgressBar1.Text = "Checking...";
		if (File.Exists("C:/Program Files/UsbDk Runtime Library/UsbDk.inf"))
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringO);
			if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0 && Conversions.ToDouble(Form1.SharedUI.Label25.Text) == 0.0)
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + ClassDevronix.YDNHBPR);
				finshonly();
				return;
			}
			String_35 = "Remove KG\\Knox [Brom]";
			Form1.SharedUI.RichTextBox1.Update();
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + ClassDevronix.UAWC);
			Form1.SharedUI.ProgressBar1.Text = "Waiting..";
			UiManager.wronganswer();
			if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
			{
				String_75 = Conversions.ToString(1);
			}
			else
			{
				String_75 = Conversions.ToString(0);
			}
			if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
			{
				Form1.SharedUI.Guna2MessageDialog3.Text = ClassDevronix.TPWCY + String_75 + " Credits Do You Want To Continue";
			}
			else
			{
				if (Conversions.ToDouble(String_75) == 0.0)
				{
					Form1.SharedUI.Guna2MessageDialog3.Text = "This Process Will Be You Free Do You Want To Continue";
				}
				if (Conversions.ToDouble(String_75) == 1.0)
				{
					Form1.SharedUI.Guna2MessageDialog3.Text = "This Process Will Be You Free Do You Want To Continue";
				}
				if (Conversions.ToDouble(String_75) == 2.0)
				{
					Form1.SharedUI.Guna2MessageDialog3.Text = "This Process Will Be You Free Do You Want To Continue";
				}
			}
			if (Form1.SharedUI.Guna2MessageDialog3.Show() == DialogResult.OK)
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringO);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Initializing Usb : ");
				Form1.SharedUI.ProgressBar1.Text = "Initializing..";
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.ProgressBar1.Text = "Initializing...";
				if (!isMTKClientRunning)
				{
					try
					{
						isMTKClientRunning = true;
						CancellationToken token = cts.Token;
						await Task.Run([SpecialName] () => MtkTask.InitAsync(token));
						if (Operators.CompareString(MtkTask.CHECK, "no", TextCompare: false) == 0)
						{
							finshfile();
						}
						else
						{
							await Task.Run([SpecialName] () => MtkTask.Remove_KG(ThisLocation + "tmp\\", token));
							if (Operators.CompareString(MtkTask.CHECK, "no", TextCompare: false) == 0)
							{
								finshfile();
							}
							else
							{
								finshNew();
							}
							Form1.SharedUI.ProgressBar1.Text = "Remove KG\\Knox Done!";
						}
					}
					catch (OperationCanceledException projectError)
					{
						ProjectData.SetProjectError(projectError);
						isMTKClientRunning = false;
						ProjectData.ClearProjectError();
					}
					isMTKClientRunning = false;
				}
				else
				{
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
					Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringF);
					finshfile();
				}
			}
			else
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
				Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.CBU);
				finshonly();
			}
		}
		else
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringF);
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + ClassDevronix.YNIDUPIATA);
			finshonly();
		}
	}

	private async void MethodD_298()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText("- Checking Drivers Mtk Usb : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.ProgressBar1.Text = "Checking...";
		if (File.Exists("C:/Program Files/UsbDk Runtime Library/UsbDk.inf"))
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringO);
			if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0 && Conversions.ToDouble(Form1.SharedUI.Label25.Text) == 0.0)
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + ClassDevronix.YDNHBPR);
				finshonly();
				return;
			}
			String_35 = "Remove KG\\Knox [Brom]";
			Form1.SharedUI.RichTextBox1.Update();
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + ClassDevronix.UAWC);
			Form1.SharedUI.ProgressBar1.Text = "Waiting..";
			UiManager.wronganswer();
			if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
			{
				String_75 = Conversions.ToString(1);
			}
			else
			{
				String_75 = Conversions.ToString(0);
			}
			if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
			{
				Form1.SharedUI.Guna2MessageDialog3.Text = ClassDevronix.TPWCY + String_75 + " Credits Do You Want To Continue";
			}
			else
			{
				if (Conversions.ToDouble(String_75) == 0.0)
				{
					Form1.SharedUI.Guna2MessageDialog3.Text = "This Process Will Be You Free Do You Want To Continue";
				}
				if (Conversions.ToDouble(String_75) == 1.0)
				{
					Form1.SharedUI.Guna2MessageDialog3.Text = "This Process Will Be You Free Do You Want To Continue";
				}
				if (Conversions.ToDouble(String_75) == 2.0)
				{
					Form1.SharedUI.Guna2MessageDialog3.Text = "This Process Will Be You Free Do You Want To Continue";
				}
			}
			if (Form1.SharedUI.Guna2MessageDialog3.Show() == DialogResult.OK)
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringO);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Initializing Usb : ");
				Form1.SharedUI.ProgressBar1.Text = "Initializing..";
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.ProgressBar1.Text = "Initializing...";
				if (!isMTKClientRunning)
				{
					try
					{
						isMTKClientRunning = true;
						CancellationToken token = cts.Token;
						await Task.Run([SpecialName] () => MtkTask.InitAsync(token));
						if (Operators.CompareString(MtkTask.CHECK, "no", TextCompare: false) == 0)
						{
							finshfile();
						}
						else
						{
							Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
							Form1.SharedUI.RichTextBox1.AppendText("- Analyzing Data From Server : ");
							Form1.SharedUI.ProgressBar1.Text = "Analyzing Server...";
							gui.Richlog(ClassDevronix.StringO, Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
							await Task.Run([SpecialName] () => MtkTask.Erasekenox(token));
							if (Operators.CompareString(MtkTask.CHECK, "no", TextCompare: false) == 0)
							{
								finshfile();
							}
							else
							{
								finshNew();
							}
							Form1.SharedUI.ProgressBar1.Text = "Remove KG\\Knox Done!";
						}
					}
					catch (OperationCanceledException projectError)
					{
						ProjectData.SetProjectError(projectError);
						isMTKClientRunning = false;
						ProjectData.ClearProjectError();
					}
					isMTKClientRunning = false;
				}
				else
				{
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
					Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringF);
					finshfile();
				}
			}
			else
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
				Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.CBU);
				finshonly();
			}
		}
		else
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringF);
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + ClassDevronix.YNIDUPIATA);
			finshonly();
		}
	}

	private void Guna2Button10_Click(object sender, EventArgs e)
	{
		startNew();
		String_28 = new Thread(MethodD_214);
		String_28.Start();
	}

	private async void MethodD_214()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText("- Checking Drivers Mtk Usb : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.ProgressBar1.Text = "Checking...";
		if (File.Exists("C:/Program Files/UsbDk Runtime Library/UsbDk.inf"))
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringO);
			if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0 && Conversions.ToDouble(Form1.SharedUI.Label25.Text) == 0.0)
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + ClassDevronix.YDNHBPR);
				finshonly();
				return;
			}
			String_35 = "Remove MI [Brom]";
			Form1.SharedUI.RichTextBox1.Update();
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + ClassDevronix.UAWC);
			Form1.SharedUI.ProgressBar1.Text = "Waiting..";
			UiManager.wronganswer();
			if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
			{
				String_75 = Conversions.ToString(1);
			}
			else
			{
				String_75 = Conversions.ToString(0);
			}
			if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
			{
				Form1.SharedUI.Guna2MessageDialog3.Text = ClassDevronix.TPWCY + String_75 + " Credits Do You Want To Continue";
			}
			else
			{
				if (Conversions.ToDouble(String_75) == 0.0)
				{
					Form1.SharedUI.Guna2MessageDialog3.Text = "This Process Will Be You Free Do You Want To Continue";
				}
				if (Conversions.ToDouble(String_75) == 1.0)
				{
					Form1.SharedUI.Guna2MessageDialog3.Text = "This Process Will Be You Free Do You Want To Continue";
				}
				if (Conversions.ToDouble(String_75) == 2.0)
				{
					Form1.SharedUI.Guna2MessageDialog3.Text = "This Process Will Be You Free Do You Want To Continue";
				}
			}
			if (Form1.SharedUI.Guna2MessageDialog3.Show() == DialogResult.OK)
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringO);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Initializing Usb : ");
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.ProgressBar1.Text = "Initializing...";
				if (!isMTKClientRunning)
				{
					try
					{
						isMTKClientRunning = true;
						CancellationToken token = cts.Token;
						await Task.Run([SpecialName] () => MtkTask.InitAsync(token));
						if (Operators.CompareString(MtkTask.CHECK, "no", TextCompare: false) == 0)
						{
							finshfile();
						}
						else
						{
							await Task.Run([SpecialName] () => MtkTask.EraseMI(token));
							if (Operators.CompareString(MtkTask.CHECK, "no", TextCompare: false) == 0)
							{
								finshfile();
							}
							else
							{
								finshNew();
							}
							Form1.SharedUI.ProgressBar1.Text = "Remove MI Done!";
						}
					}
					catch (OperationCanceledException projectError)
					{
						ProjectData.SetProjectError(projectError);
						isMTKClientRunning = false;
						ProjectData.ClearProjectError();
					}
					isMTKClientRunning = false;
				}
				else
				{
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
					Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringF);
					finshfile();
				}
			}
			else
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
				Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.CBU);
				finshonly();
			}
		}
		else
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringF);
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + ClassDevronix.YNIDUPIATA);
			finshonly();
		}
	}

	private void Guna2Button12_Click(object sender, EventArgs e)
	{
		startNew();
		String_28 = new Thread(MethodD_230);
		String_28.Start();
	}

	private async void MethodD_230()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText("- Checking Drivers Mtk Usb : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.ProgressBar1.Text = "Checking...";
		if (File.Exists("C:/Program Files/UsbDk Runtime Library/UsbDk.inf"))
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringO);
			if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0 && Conversions.ToDouble(Form1.SharedUI.Label25.Text) == 0.0)
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + ClassDevronix.YDNHBPR);
				finshonly();
				return;
			}
			String_35 = "Remove Demo";
			Form1.SharedUI.RichTextBox1.Update();
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + ClassDevronix.UAWC);
			Form1.SharedUI.ProgressBar1.Text = "Waiting..";
			UiManager.wronganswer();
			if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
			{
				String_75 = Conversions.ToString(1);
			}
			else
			{
				String_75 = Conversions.ToString(0);
			}
			if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
			{
				Form1.SharedUI.Guna2MessageDialog3.Text = ClassDevronix.TPWCY + String_75 + " Credits Do You Want To Continue";
			}
			else
			{
				if (Conversions.ToDouble(String_75) == 0.0)
				{
					Form1.SharedUI.Guna2MessageDialog3.Text = "This Process Will Be You Free Do You Want To Continue";
				}
				if (Conversions.ToDouble(String_75) == 1.0)
				{
					Form1.SharedUI.Guna2MessageDialog3.Text = "This Process Will Be You Free Do You Want To Continue";
				}
				if (Conversions.ToDouble(String_75) == 2.0)
				{
					Form1.SharedUI.Guna2MessageDialog3.Text = "This Process Will Be You Free Do You Want To Continue";
				}
			}
			if (Form1.SharedUI.Guna2MessageDialog3.Show() == DialogResult.OK)
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringO);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Initializing Usb : ");
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.ProgressBar1.Text = "Initializing...";
				if (!isMTKClientRunning)
				{
					try
					{
						isMTKClientRunning = true;
						CancellationToken token = cts.Token;
						await Task.Run([SpecialName] () => MtkTask.InitAsync(token));
						if (Operators.CompareString(MtkTask.CHECK, "no", TextCompare: false) == 0)
						{
							finshfile();
						}
						else
						{
							await Task.Run([SpecialName] () => MtkTask.EraseDEMO(token));
							if (Operators.CompareString(MtkTask.CHECK, "no", TextCompare: false) == 0)
							{
								finshfile();
							}
							else
							{
								finshNew();
							}
							Form1.SharedUI.ProgressBar1.Text = "Remove Demo Done!";
						}
					}
					catch (OperationCanceledException projectError)
					{
						ProjectData.SetProjectError(projectError);
						isMTKClientRunning = false;
						ProjectData.ClearProjectError();
					}
					isMTKClientRunning = false;
				}
				else
				{
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
					Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringF);
					finshfile();
				}
			}
			else
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
				Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.CBU);
				finshonly();
			}
		}
		else
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringF);
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + ClassDevronix.YNIDUPIATA);
			finshonly();
		}
	}

	private void Guna2Button13_Click(object sender, EventArgs e)
	{
		startNew();
		String_28 = new Thread(MethodD_231);
		String_28.Start();
	}

	private async void MethodD_231()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText("- Checking Drivers Mtk Usb : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.ProgressBar1.Text = "Checking...";
		if (File.Exists("C:/Program Files/UsbDk Runtime Library/UsbDk.inf"))
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringO);
			if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0 && Conversions.ToDouble(Form1.SharedUI.Label25.Text) == 0.0)
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + ClassDevronix.YDNHBPR);
				finshonly();
				return;
			}
			String_35 = "Remove ID";
			Form1.SharedUI.RichTextBox1.Update();
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + ClassDevronix.UAWC);
			Form1.SharedUI.ProgressBar1.Text = "Waiting..";
			UiManager.wronganswer();
			if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
			{
				String_75 = Conversions.ToString(1);
			}
			else
			{
				String_75 = Conversions.ToString(0);
			}
			if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
			{
				Form1.SharedUI.Guna2MessageDialog3.Text = ClassDevronix.TPWCY + String_75 + " Credits Do You Want To Continue";
			}
			else
			{
				if (Conversions.ToDouble(String_75) == 0.0)
				{
					Form1.SharedUI.Guna2MessageDialog3.Text = "This Process Will Be You Free Do You Want To Continue";
				}
				if (Conversions.ToDouble(String_75) == 1.0)
				{
					Form1.SharedUI.Guna2MessageDialog3.Text = "This Process Will Be You Free Do You Want To Continue";
				}
				if (Conversions.ToDouble(String_75) == 2.0)
				{
					Form1.SharedUI.Guna2MessageDialog3.Text = "This Process Will Be You Free Do You Want To Continue";
				}
			}
			if (Form1.SharedUI.Guna2MessageDialog3.Show() == DialogResult.OK)
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringO);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Initializing Usb : ");
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.ProgressBar1.Text = "Initializing...";
				if (!isMTKClientRunning)
				{
					try
					{
						isMTKClientRunning = true;
						CancellationToken token = cts.Token;
						await Task.Run([SpecialName] () => MtkTask.InitAsync(token));
						if (Operators.CompareString(MtkTask.CHECK, "no", TextCompare: false) == 0)
						{
							finshfile();
						}
						else
						{
							await Task.Run([SpecialName] () => MtkTask.EraseID(token));
							if (Operators.CompareString(MtkTask.CHECK, "no", TextCompare: false) == 0)
							{
								finshfile();
							}
							else
							{
								finshNew();
							}
							Form1.SharedUI.ProgressBar1.Text = "Remove ID Done!";
						}
					}
					catch (OperationCanceledException projectError)
					{
						ProjectData.SetProjectError(projectError);
						isMTKClientRunning = false;
						ProjectData.ClearProjectError();
					}
					isMTKClientRunning = false;
				}
				else
				{
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
					Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringF);
					finshfile();
				}
			}
			else
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
				Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.CBU);
				finshonly();
			}
		}
		else
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringF);
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + ClassDevronix.YNIDUPIATA);
			finshonly();
		}
	}

	private void Guna2Button8_Click(object sender, EventArgs e)
	{
		startNew();
		String_28 = new Thread(MethodD_229);
		String_28.Start();
	}

	private async void MethodD_229()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText("- Checking Drivers Mtk Usb : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.ProgressBar1.Text = "Checking...";
		if (File.Exists("C:/Program Files/UsbDk Runtime Library/UsbDk.inf"))
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringO);
			Form1.SharedUI.RichTextBox1.Update();
			if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0 && Conversions.ToDouble(Form1.SharedUI.Label25.Text) == 0.0)
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + ClassDevronix.YDNHBPR);
				finshonly();
				return;
			}
			String_35 = "Wipe Data";
			Form1.SharedUI.RichTextBox1.Update();
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + ClassDevronix.UAWC);
			Form1.SharedUI.ProgressBar1.Text = "Waiting..";
			UiManager.wronganswer();
			if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
			{
				String_75 = Conversions.ToString(1);
			}
			else
			{
				String_75 = Conversions.ToString(0);
			}
			if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
			{
				Form1.SharedUI.Guna2MessageDialog3.Text = ClassDevronix.TPWCY + String_75 + " Credits Do You Want To Continue";
			}
			else
			{
				if (Conversions.ToDouble(String_75) == 0.0)
				{
					Form1.SharedUI.Guna2MessageDialog3.Text = "This Process Will Be You Free Do You Want To Continue";
				}
				if (Conversions.ToDouble(String_75) == 1.0)
				{
					Form1.SharedUI.Guna2MessageDialog3.Text = "This Process Will Be You Free Do You Want To Continue";
				}
				if (Conversions.ToDouble(String_75) == 2.0)
				{
					Form1.SharedUI.Guna2MessageDialog3.Text = "This Process Will Be You Free Do You Want To Continue";
				}
			}
			if (Form1.SharedUI.Guna2MessageDialog3.Show() == DialogResult.OK)
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringO);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Initializing Usb : ");
				Form1.SharedUI.RichTextBox1.Update();
				if (Guna2ComboWipe.SelectedIndex == 0)
				{
					try
					{
						if (!Directory.Exists("bin\\mtk\\"))
						{
							Directory.CreateDirectory("bin\\mtk\\");
							File.WriteAllBytes(Form1.String_9 + "bin\\mtk\\SECUFS", Resources.SECUFS);
							File.WriteAllBytes(Form1.String_9 + "bin\\mtk\\SECEMMC", Resources.SECEMMC);
						}
						else
						{
							string directory = Form1.String_9 + "bin\\mtk";
							try
							{
								MyProject.Computer.FileSystem.DeleteDirectory(directory, DeleteDirectoryOption.DeleteAllContents);
							}
							catch (Exception projectError)
							{
								ProjectData.SetProjectError(projectError);
								ProjectData.ClearProjectError();
							}
							Directory.CreateDirectory("bin\\mtk\\");
							File.WriteAllBytes(Form1.String_9 + "bin\\mtk\\SECUFS", Resources.SECUFS);
							File.WriteAllBytes(Form1.String_9 + "bin\\mtk\\SECEMMC", Resources.SECEMMC);
						}
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
						Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringF);
						finshfile();
						ProjectData.ClearProjectError();
						return;
					}
				}
				Form1.SharedUI.ProgressBar1.Text = "Initializing...";
				if (!isMTKClientRunning)
				{
					try
					{
						isMTKClientRunning = true;
						CancellationToken token = cts.Token;
						await Task.Run([SpecialName] () => MtkTask.InitAsync(token));
						if (Operators.CompareString(MtkTask.CHECK, "no", TextCompare: false) == 0)
						{
							finshfile();
						}
						else
						{
							if (Guna2ComboWipe.SelectedIndex == 0)
							{
								await Task.Run([SpecialName] () => MtkTask.Formatseva(Form1.String_9 + "bin\\mtk\\", token));
								string directory2 = Form1.String_9 + "bin\\mtk";
								try
								{
									MyProject.Computer.FileSystem.DeleteDirectory(directory2, DeleteDirectoryOption.DeleteAllContents);
								}
								catch (Exception projectError3)
								{
									ProjectData.SetProjectError(projectError3);
									ProjectData.ClearProjectError();
								}
							}
							if (Guna2ComboWipe.SelectedIndex == 1)
							{
								await Task.Run([SpecialName] () => MtkTask.FormatUserdataFRP(token));
							}
							if (Operators.CompareString(MtkTask.CHECK, "no", TextCompare: false) == 0)
							{
								finshfile();
							}
							else
							{
								finshNew();
							}
						}
					}
					catch (OperationCanceledException projectError4)
					{
						ProjectData.SetProjectError(projectError4);
						isMTKClientRunning = false;
						ProjectData.ClearProjectError();
					}
					isMTKClientRunning = false;
				}
				else
				{
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
					Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringF);
					finshfile();
				}
			}
			else
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
				Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.CBU);
				finshonly();
			}
		}
		else
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringF);
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + ClassDevronix.YNIDUPIATA);
			finshonly();
		}
	}

	private void Guna2Button6_Click(object sender, EventArgs e)
	{
		startNew();
		String_28 = new Thread(MethodD_267);
		String_28.Start();
	}

	private void MethodD_144(string Commands)
	{
		Process process = new Process();
		process.StartInfo.FileName = Form1.String_9 + "bin\\Tunlocker Tool.exe";
		process.StartInfo.Arguments = "/c " + Commands;
		process.StartInfo.CreateNoWindow = true;
		process.StartInfo.UseShellExecute = false;
		process.StartInfo.RedirectStandardOutput = true;
		process.StartInfo.RedirectStandardError = true;
		process.Start();
		process.WaitForExit();
	}

	public bool Get_Data_0910909820()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		Form1.String_107 = (IFirebaseClient)new FirebaseClient((IFirebaseConfig)(object)Form1.String_108);
		bool result;
		try
		{
			Form1.SharedUI.ProgressBar1.Text = ClassDevronix.AW2;
			FirebaseResponse obj = Form1.String_107.Get(ClassDevronix.LF + Form1.String_15);
			new Form1.IClass1();
			Form1.IClass1 @class = obj.ResultAs<Form1.IClass1>();
			Form1.String_19 = @class.Password;
			string link = @class.Link;
			string token = @class.Token;
			Form1.String_19 = encr.Decrypt(Form1.String_19, Form1.SharedUI.textpss.Text);
			token = encr.Decrypt(token, Form1.String_19);
			link = encr.Decrypt(link, token);
			Form1.String_12 = link;
			Form1.SharedUI.ProgressBar1.Text = ClassDevronix.GA2;
			result = true;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			result = false;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private void MethodD_100(string ZZL, string EEE, string PPP)
	{
		try
		{
			string text = EEE + Form1.String_14;
			string text2 = EEE + Form1.String_15;
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
				MethodD_144(("bin\\7z.exe x " + text + " -p" + PPP + " -o" + text2) ?? "");
				if (Directory.Exists(text2))
				{
					Boolean_2 = true;
				}
				else
				{
					Boolean_2 = false;
				}
				return;
			}
			if (Operators.CompareString(SAHARA_MANAGER.String_14, "Up.zip", TextCompare: false) == 0)
			{
				SerialCOM.MSL = "ENREADString_11_Update";
			}
			else
			{
				SerialCOM.MSL = "ENREADString_11";
			}
			using WebClient webClient = new WebClient();
			webClient.DownloadProgressChanged += MethodD_98;
			webClient.DownloadFileCompleted += MethodD_99;
			webClient.DownloadFileAsync(new Uri(ZZL), EEE + SAHARA_MANAGER.String_14);
			while (webClient.IsBusy)
			{
				Application.DoEvents();
			}
			MethodD_144(("bin\\7z.exe x " + text + " -p" + PPP + " -o" + text2) ?? "");
			if (Directory.Exists(text2))
			{
				Boolean_2 = true;
			}
			else
			{
				Boolean_2 = false;
			}
		}
		catch (Exception ex7)
		{
			ProjectData.SetProjectError(ex7);
			Exception ex8 = ex7;
			ProjectData.ClearProjectError();
		}
	}

	private void MethodD_98(object sender, DownloadProgressChangedEventArgs e)
	{
		Form1.SharedUI.ProgressBar4.Value = e.ProgressPercentage;
	}

	private void MethodD_99(object sender, AsyncCompletedEventArgs e)
	{
		if (e.Error != null)
		{
			Boolean_2 = false;
		}
		else
		{
			Boolean_2 = true;
		}
		SerialCOM.MSL = "DISREAD";
	}

	private async void MethodD_267()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText("- Checking Drivers : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.ProgressBar1.Text = "Checking...";
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringO);
		Form1.SharedUI.RichTextBox1.Update();
		if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0 && Conversions.ToDouble(Form1.SharedUI.Label25.Text) == 0.0)
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + ClassDevronix.YDNHBPR);
			finshonly();
			return;
		}
		String_35 = "Remove MDM";
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + ClassDevronix.UAWC);
		Form1.SharedUI.ProgressBar1.Text = "Waiting..";
		UiManager.wronganswer();
		if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
		{
			String_75 = Conversions.ToString(1);
		}
		else
		{
			String_75 = Conversions.ToString(0);
		}
		if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
		{
			Form1.SharedUI.Guna2MessageDialog3.Text = ClassDevronix.TPWCY + String_75 + " Credits Do You Want To Continue";
		}
		else
		{
			if (Conversions.ToDouble(String_75) == 0.0)
			{
				Form1.SharedUI.Guna2MessageDialog3.Text = "This Process Will Be You Free Do You Want To Continue";
			}
			if (Conversions.ToDouble(String_75) == 1.0)
			{
				Form1.SharedUI.Guna2MessageDialog3.Text = "This Process Will Be You Free Do You Want To Continue";
			}
			if (Conversions.ToDouble(String_75) == 2.0)
			{
				Form1.SharedUI.Guna2MessageDialog3.Text = "This Process Will Be You Free Do You Want To Continue";
			}
		}
		if (Form1.SharedUI.Guna2MessageDialog3.Show() == DialogResult.OK)
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringO);
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Initializing Usb : ");
			Form1.String_14 = "Token2.zip";
			Form1.String_15 = "Token2";
			if (!Get_Data_0910909820())
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
				Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringF);
				finshfile();
				return;
			}
			Form1.SharedUI.RichTextBox1.Update();
			Form1.SharedUI.ProgressBar1.Text = "Initializing...";
			if (!isMTKClientRunning)
			{
				try
				{
					isMTKClientRunning = true;
					CancellationToken token = cts.Token;
					await Task.Run([SpecialName] () => MtkTask.InitAsync(token));
					if (Operators.CompareString(MtkTask.CHECK, "no", TextCompare: false) == 0)
					{
						finshfile();
					}
					else
					{
						Form1.SharedUI.ProgressBar1.Text = "Connnect Server...";
						gui.Richlog("- Requesting Server : ", Color.Black);
						MethodD_100(Form1.String_12, ClassDevronix.CWQ, "77Devronix");
						if (!Boolean_2)
						{
							Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
							Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringF);
							finshfile();
							return;
						}
						gui.Richlog(ClassDevronix.StringO, Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
						await Task.Run([SpecialName] () => MtkTask.Remove_MDM(ClassDevronix.CWQ + Form1.String_15 + "\\", Guna2ComboMDM.Text, token));
						if (Operators.CompareString(MtkTask.CHECK, "no", TextCompare: false) == 0)
						{
							finshfile();
						}
						else
						{
							finshNew();
							Form1.SharedUI.ProgressBar1.Text = "Remove MDM Successfully!";
						}
					}
				}
				catch (OperationCanceledException projectError)
				{
					ProjectData.SetProjectError(projectError);
					isMTKClientRunning = false;
					ProjectData.ClearProjectError();
				}
				isMTKClientRunning = false;
			}
			else
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
				Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringF);
				finshfile();
			}
		}
		else
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.CBU);
			finshonly();
		}
	}

	private void Guna2Button11_Click(object sender, EventArgs e)
	{
		startNew();
		String_28 = new Thread(MethodD_232);
		String_28.Start();
	}

	private async void MethodD_232()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText("- Checking Drivers Mtk Usb : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.ProgressBar1.Text = "Checking...";
		if (File.Exists("C:/Program Files/UsbDk Runtime Library/UsbDk.inf"))
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringO);
			Form1.SharedUI.RichTextBox1.Update();
			if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0 && Conversions.ToDouble(Form1.SharedUI.Label25.Text) == 0.0)
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + ClassDevronix.YDNHBPR);
				finshonly();
				return;
			}
			if (ComboBoxBoot.SelectedIndex == 0)
			{
				String_35 = "Unlock Bootloader";
			}
			else
			{
				String_35 = "Relock Bootloader";
			}
			Form1.SharedUI.RichTextBox1.Update();
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + ClassDevronix.UAWC);
			Form1.SharedUI.ProgressBar1.Text = "Waiting..";
			UiManager.wronganswer();
			if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
			{
				String_75 = Conversions.ToString(1);
			}
			else
			{
				String_75 = Conversions.ToString(0);
			}
			if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
			{
				Form1.SharedUI.Guna2MessageDialog3.Text = ClassDevronix.TPWCY + String_75 + " Credits Do You Want To Continue";
			}
			else
			{
				if (Conversions.ToDouble(String_75) == 0.0)
				{
					Form1.SharedUI.Guna2MessageDialog3.Text = "This Process Will Be You Free Do You Want To Continue";
				}
				if (Conversions.ToDouble(String_75) == 1.0)
				{
					Form1.SharedUI.Guna2MessageDialog3.Text = "This Process Will Be You Free Do You Want To Continue";
				}
			}
			if (Form1.SharedUI.Guna2MessageDialog3.Show() == DialogResult.OK)
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringO);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Initializing Usb : ");
				Form1.SharedUI.RichTextBox1.Update();
				Form1.SharedUI.ProgressBar1.Text = "Initializing...";
				if (!isMTKClientRunning)
				{
					try
					{
						isMTKClientRunning = true;
						CancellationToken token = cts.Token;
						await Task.Run([SpecialName] () => MtkTask.InitAsync(token));
						if (Operators.CompareString(MtkTask.CHECK, "no", TextCompare: false) == 0)
						{
							finshfile();
						}
						else
						{
							if (ComboBoxBoot.SelectedIndex != 0)
							{
								await Task.Run([SpecialName] () => MtkTask.DoUBL(token, "lock"));
							}
							else
							{
								await Task.Run([SpecialName] () => MtkTask.DoUBL(token));
							}
							if (Form1.SharedUI.RichTextBox1.Text.Contains("> Bootloader Allready"))
							{
								String_75 = Conversions.ToString(0);
								String_35 = "";
							}
							if (Operators.CompareString(MtkTask.CHECK, "no", TextCompare: false) == 0)
							{
								finshfile();
							}
							else
							{
								finshNew();
							}
						}
					}
					catch (OperationCanceledException projectError)
					{
						ProjectData.SetProjectError(projectError);
						isMTKClientRunning = false;
						ProjectData.ClearProjectError();
					}
					isMTKClientRunning = false;
				}
				else
				{
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
					Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringF);
					finshfile();
				}
			}
			else
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
				Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.CBU);
				finshonly();
			}
		}
		else
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringF);
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + ClassDevronix.YNIDUPIATA);
			finshonly();
		}
	}

	private void Guna2Button4_Click(object sender, EventArgs e)
	{
		startNew();
		if (ComboBoxRepair.SelectedIndex == 1)
		{
			String_35 = "";
			String_28 = new Thread(MethodD_236);
			String_28.Start();
		}
		if (ComboBoxRepair.SelectedIndex == 0)
		{
			String_35 = "Repair Boot";
			String_28 = new Thread(MethodD_237);
			String_28.Start();
		}
	}

	public void MethodD_236()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText("- Initializeing Device : ");
		Form1.SharedUI.ProgressBar1.Text = ClassDevronix.I2;
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringO);
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Wait For Download Mode : ");
		if (!Class0.PortShow())
		{
			return;
		}
		if (Class0.portNameSettings())
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringO);
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Gathering Phone Info : ");
			Form1.SharedUI.ProgressBar1.Text = "Gathering..";
			Class0.Check_Show_Change_Log_1();
			if (Operators.CompareString(device_info.model, "", TextCompare: false) == 0)
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
				Form1.SharedUI.RichTextBox1.AppendText("Failed Open Port");
				finshfile();
				return;
			}
			if ("SM-A125U-SM-A125U1-SM-S127DL-SM-A125M-SM-A125F".Contains(device_info.model))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.STBM);
				Form1.SharedUI.ProgressBar1.Text = "Switching..";
				SerialCOM.MSL = "ENREAD";
				Form1.SharedUI.ProgressBar4.Value = 0;
				Form1.SharedUI.ProgressBar4.Text = "0%";
				if (Class0.MethodD_24())
				{
					Form1.SharedUI.RichTextBox1.Update();
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
					Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringO);
					Form1.serialPort.Close();
					SerialCOM.MSL = "DISREAD";
				}
			}
			else if ("SM-A326U-SM-A326U1-SM-S326DL".Contains(device_info.model))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText("- Initailazing Protocol : ");
				SerialCOM.MSL = "ENREAD";
				Form1.SharedUI.ProgressBar4.Value = 0;
				Form1.SharedUI.ProgressBar4.Text = "0%";
				if (!Class0.MethodD_20())
				{
					finshfile();
					return;
				}
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringO);
				Form1.serialPort.Close();
				if (!Class0.Remeber_Me_AutoLogIn())
				{
					return;
				}
				if (!Class0.portNameSettings())
				{
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
					Form1.SharedUI.RichTextBox1.AppendText("Fail Open Port");
					finshfile();
					return;
				}
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringO);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + ClassDevronix.STBM);
				Form1.SharedUI.ProgressBar1.Text = "Switching..";
				if (Class0.MethodD_21())
				{
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
					Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringO);
					Form1.serialPort.Close();
					SerialCOM.MSL = "DISREAD";
				}
			}
			else
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.STBM);
				Form1.SharedUI.ProgressBar1.Text = "Switching..";
				SerialCOM.MSL = "ENREAD";
				Form1.SharedUI.ProgressBar4.Value = 0;
				Form1.SharedUI.ProgressBar4.Text = "0%";
				if (Class0.MethodD_23())
				{
					Form1.SharedUI.RichTextBox1.Update();
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
					Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringO);
					Form1.serialPort.Close();
				}
			}
			finshNew();
			Form1.SharedUI.ProgressBar1.Text = "Force Brom Done!";
		}
		else
		{
			Form1.SharedUI.RichTextBox1.Update();
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText("Fail Open Port");
			finshfile();
		}
	}

	public async void MethodD_237()
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText("- Checking Drivers : ");
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringO);
		String_75 = Conversions.ToString(0);
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Initializing Usb : ");
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.ProgressBar1.Text = "Initializing...";
		if (!isMTKClientRunning)
		{
			try
			{
				isMTKClientRunning = true;
				CancellationToken token = cts.Token;
				await Task.Run([SpecialName] () => MtkTask.InitAsync(token));
				if (Operators.CompareString(MtkTask.CHECK, "no", TextCompare: false) == 0)
				{
					finshfile();
				}
				else if (Mediatek.Platform.Contains("MT6853"))
				{
					await Task.Run([SpecialName] () => MtkTask.Repairing_PMT(token));
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
					Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringO);
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
					Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Wait For Download Mode : ");
					if (!Class0.PortShow())
					{
						return;
					}
					if (!Class0.portNameSettings())
					{
						Form1.SharedUI.RichTextBox1.Update();
						Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
						Form1.SharedUI.RichTextBox1.AppendText("Fail Open Port");
						finshfile();
						return;
					}
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
					Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringO);
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
					Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Write PIT File To Phone : ");
					Form1.SharedUI.ProgressBar1.Text = "Writing..";
					SerialCOM.MSL = "ENREAD";
					Form1.SharedUI.ProgressBar4.Value = 0;
					Form1.SharedUI.ProgressBar4.Text = "0%";
					if (Class0.MethodD_22())
					{
						Form1.SharedUI.RichTextBox1.Update();
						Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
						Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringO);
						Form1.serialPort.Close();
						SerialCOM.MSL = "DISREAD";
					}
					finshNew();
					Form1.SharedUI.ProgressBar1.Text = "Repair Boot Done!";
				}
				else
				{
					await Task.Run([SpecialName] () => MtkTask.Repairing_PGPT(token));
					if (Operators.CompareString(MtkTask.CHECK, "no", TextCompare: false) == 0)
					{
						finshfile();
					}
					else
					{
						finshNew();
					}
					Form1.SharedUI.ProgressBar1.Text = "Repair Boot Done!";
				}
			}
			catch (OperationCanceledException projectError)
			{
				ProjectData.SetProjectError(projectError);
				isMTKClientRunning = false;
				ProjectData.ClearProjectError();
			}
			isMTKClientRunning = false;
		}
		else
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringF);
			finshfile();
		}
	}

	private void Guna2Button9_Click(object sender, EventArgs e)
	{
		FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog
		{
			ShowNewFolderButton = true
		};
		if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
		{
			Guna2TextBox1.Text = folderBrowserDialog.SelectedPath + "\\";
		}
	}

	private async void Guna2Button7_Click(object sender, EventArgs e)
	{
		FileDelete2 = Guna2TextBox1.Text + Guna2TextBox2.Text;
		Seva_Coun = FileDelete2.Replace(".zip", "_Unlock.zip");
		if (File.Exists(Seva_Coun))
		{
			Form1.SharedUI.RichTextBox1.Clear();
			gui.Richlog("> File Is Exists, Check Name Unlock File", Color.Red);
		}
		else
		{
			if (isMTKClientRunning)
			{
				return;
			}
			start();
			try
			{
				Form1.SharedUI.RichTextBox1.Clear();
				isMTKClientRunning = true;
				CancellationToken token = cts.Token;
				string text = ThisLocation + "tmp\\ext\\";
				if (!Directory.Exists(text))
				{
					Directory.CreateDirectory(text);
				}
				if (CkBromReady.Checked)
				{
					await Task.Run([SpecialName] () => MtkTask.BackupNV(text, token));
					Form1.SharedUI.ProgressBar1.Text = "Erasing...";
					gui.Richlog("- Erasing Security #Block 0 : ", Color.Black);
					await Task.Run([SpecialName] () => MtkTask.EraseNV(token));
					gui.Richlog("- Erasing Security #Block 1 : ", Color.Black);
					await Task.Run([SpecialName] () => MtkTask.EraseNV(token));
					gui.Richlog("- Erasing Security #Block 2 : ", Color.Black);
					await Task.Run([SpecialName] () => MtkTask.EraseNV(token));
					gui.Richlog("- Erasing Security #Block 3 : ", Color.Black);
					await Task.Run([SpecialName] () => MtkTask.EraseNV(token));
					gui.Richlog("- Erasing Security #Block 4 : ", Color.Black);
					await Task.Run([SpecialName] () => MtkTask.EraseNV(token));
					await Task.Run([SpecialName] () => MtkTask.Reboot(token));
					new Thread(seva_file2).Start();
				}
				else
				{
					gui.Richlog("- Initializing Usb Device : ", Color.White);
					await Task.Run([SpecialName] () => MtkTask.InitAsync2(token));
					if (Operators.CompareString(MtkTask.CHECK, "no", TextCompare: false) == 0)
					{
						finshfile();
						return;
					}
					gui.Richlog("", Color.White, isBold: false, NextLine: true);
					await Task.Run([SpecialName] () => MtkTask.BackupNV(text, token));
					Form1.SharedUI.ProgressBar1.Text = "Erasing...";
					gui.Richlog("- Erasing Security #Block 0 : ", Color.Black);
					await Task.Run([SpecialName] () => MtkTask.EraseNV(token));
					gui.Richlog("- Erasing Security #Block 1 : ", Color.Black);
					await Task.Run([SpecialName] () => MtkTask.EraseNV(token));
					gui.Richlog("- Erasing Security #Block 2 : ", Color.Black);
					await Task.Run([SpecialName] () => MtkTask.EraseNV(token));
					gui.Richlog("- Erasing Security #Block 3 : ", Color.Black);
					await Task.Run([SpecialName] () => MtkTask.EraseNV(token));
					gui.Richlog("- Erasing Security #Block 4 : ", Color.Black);
					await Task.Run([SpecialName] () => MtkTask.EraseNV(token));
					await Task.Run([SpecialName] () => MtkTask.Reboot(token));
					new Thread(seva_file2).Start();
				}
			}
			catch (OperationCanceledException projectError)
			{
				ProjectData.SetProjectError(projectError);
				CkBromReady.Invoke((Action)([SpecialName] () =>
				{
					CkBromReady.Checked = false;
				}));
				isMTKClientRunning = false;
				ProjectData.ClearProjectError();
			}
			isMTKClientRunning = false;
		}
	}

	private async void Guna2Button17_Click(object sender, EventArgs e)
	{
		if (isMTKClientRunning)
		{
			return;
		}
		start();
		bool flag = false;
		foreach (DataGridViewRow item in (IEnumerable)DataGridFlash.Rows)
		{
			if (Convert.ToBoolean(RuntimeHelpers.GetObjectValue(item.Cells[0].Value)))
			{
				flag = true;
				break;
			}
		}
		if (flag)
		{
			Form1.SharedUI.RichTextBox1.Clear();
			try
			{
				_Closure_0024__403_002D0 arg = default(_Closure_0024__403_002D0);
				_Closure_0024__403_002D0 CS_0024_003C_003E8__locals0 = new _Closure_0024__403_002D0(arg);
				isMTKClientRunning = true;
				CS_0024_003C_003E8__locals0._0024VB_0024Local_token = cts.Token;
				if (CkBromReady.Checked)
				{
					await Task.Run([SpecialName] () => MtkTask.Flash2(CS_0024_003C_003E8__locals0._0024VB_0024Local_token));
				}
				else
				{
					gui.Richlog("- Initializing Usb Device : ", Color.White);
					await Task.Run([SpecialName] () => MtkTask.InitAsync2(CS_0024_003C_003E8__locals0._0024VB_0024Local_token));
					if (Operators.CompareString(MtkTask.CHECK, "no", TextCompare: false) == 0)
					{
						finshfile();
						return;
					}
					gui.Richlog("", Color.White, isBold: false, NextLine: true);
					await Task.Run([SpecialName] () => MtkTask.Flash2(CS_0024_003C_003E8__locals0._0024VB_0024Local_token));
				}
				finshonly();
				isMTKClientRunning = false;
				return;
			}
			catch (OperationCanceledException projectError)
			{
				ProjectData.SetProjectError(projectError);
				CkBromReady.Invoke((Action)([SpecialName] () =>
				{
					CkBromReady.Checked = false;
				}));
				isMTKClientRunning = false;
				ProjectData.ClearProjectError();
				return;
			}
			finally
			{
				string path = Application.StartupPath + "\\tmp";
				if (Directory.Exists(path))
				{
					DirectoryInfo directoryInfo = new DirectoryInfo(path);
					foreach (FileInfo item2 in directoryInfo.EnumerateFiles())
					{
						item2.Delete();
					}
					foreach (DirectoryInfo item3 in directoryInfo.EnumerateDirectories())
					{
						item3.Delete(recursive: true);
					}
					directoryInfo.Delete(recursive: true);
				}
			}
		}
		gui.Richlog("- Sorry, Select The Partition First", Color.Red);
		finshonly();
	}

	private void Guna2Button18_Click(object sender, EventArgs e)
	{
		try
		{
			OpenFileDialog openFileDialog = new OpenFileDialog
			{
				Title = "Select Scatter File !",
				Filter = "Scatter File  |*.txt"
			};
			if (openFileDialog.ShowDialog() != DialogResult.OK)
			{
				return;
			}
			DataGridFlash.Rows.Clear();
			Mediatek.Scatterfile = openFileDialog.FileName;
			DirectoryInfo directoryInfo = new DirectoryInfo(openFileDialog.FileName.Replace("\\" + openFileDialog.SafeFileName, ""));
			foreach (FileInfo item in directoryInfo.EnumerateFiles())
			{
				if (item.Name.Contains("preloader"))
				{
					Mediatek.Preloader2 = item.FullName;
				}
			}
			string text = "userarea";
			if (!MtkScatter.IsSupport(Mediatek.Scatterfile))
			{
				return;
			}
			string path = openFileDialog.FileName.Replace("\\" + openFileDialog.SafeFileName, "");
			string text2 = default(string);
			if (Operators.CompareString(MtkScatter.CPUType.ToLower(), "emmc", TextCompare: false) == 0)
			{
				MtkSparse.sectsize = 512;
				text2 = "EMMC";
			}
			else if (Operators.CompareString(MtkScatter.CPUType.ToLower(), "ufs", TextCompare: false) == 0)
			{
				MtkSparse.sectsize = 4096;
				text2 = "UFS";
			}
			List<MtkScatter.mtk> list = MtkScatter.ScatterTable(Mediatek.Scatterfile);
			if (list.Count <= 0)
			{
				return;
			}
			TxtScatter.Text = openFileDialog.SafeFileName;
			DataGridFlash.Rows.Clear();
			foreach (MtkScatter.mtk item2 in list)
			{
				string text3;
				if (Operators.CompareString(text2, "UFS", TextCompare: false) == 0)
				{
					if (Operators.CompareString(item2.Partition_name, "preloader", TextCompare: false) == 0)
					{
						text3 = text2 + "_LU0_LU1";
						text = "boot";
					}
					else
					{
						text3 = text2 + "_LU2";
						text = "userarea";
					}
				}
				else if (Operators.CompareString(item2.Partition_name, "preloader", TextCompare: false) == 0)
				{
					text3 = text2 + "_BOOT1";
					text = "boot";
				}
				else
				{
					text3 = text2 + "_USER";
					text = "userarea";
				}
				string text4 = Path.Combine(path, item2.File_name);
				if (!File.Exists(text4))
				{
					continue;
				}
				if (Operators.CompareString(item2.Partition_name, "preloader", TextCompare: false) == 0 && File.Exists(text4))
				{
					Mediatek.Preloader2 = text4;
					Mediatek.Preloader = text4;
					string text5 = text4;
					int num = text5.LastIndexOf("\\");
					if (num > -1)
					{
						text5 = text5.Substring(checked(num + 1));
						TxtEMI.Text = text5;
					}
				}
				string fileSize = GetFileSize(utils.HexToLong(item2.Partition_size.Replace(" ", "").Replace("0x", "")));
				if ((Operators.CompareString(item2.Partition_name, "nvcfg", TextCompare: false) == 0) | (Operators.CompareString(item2.Partition_name, "PGPT", TextCompare: false) == 0) | (Operators.CompareString(item2.Partition_name, "nvdata", TextCompare: false) == 0) | (Operators.CompareString(item2.Partition_name, "sec_efs", TextCompare: false) == 0) | (Operators.CompareString(item2.Partition_name, "nvram", TextCompare: false) == 0) | (Operators.CompareString(item2.Partition_name, "protect1", TextCompare: false) == 0) | (Operators.CompareString(item2.Partition_name, "protect2", TextCompare: false) == 0))
				{
					DataGridFlash.Rows.Add(false, text, item2.Partition_name, item2.Linear_start_addr, item2.Partition_size, fileSize, text4, text3);
				}
				else
				{
					DataGridFlash.Rows.Add(true, text, item2.Partition_name, item2.Linear_start_addr, item2.Partition_size, fileSize, text4, text3);
				}
				text = MtkSparse.sectsize.ToString();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Guna2CheckBox3_CheckedChanged(object sender, EventArgs e)
	{
		if (DataGridFlash.Rows.Count <= 0)
		{
			return;
		}
		if (!Guna2CheckBox3.Checked)
		{
			{
				foreach (DataGridViewRow item in (IEnumerable)DataGridFlash.Rows)
				{
					item.Cells[0].Value = false;
				}
				return;
			}
		}
		foreach (DataGridViewRow item2 in (IEnumerable)DataGridFlash.Rows)
		{
			item2.Cells[0].Value = true;
		}
	}

	private void Guna2Button14_Click(object sender, EventArgs e)
	{
		if (ComboBoxkg.SelectedIndex == 0)
		{
			startNew();
			String_28 = new Thread(MethodD_297);
			String_28.Start();
		}
		else
		{
			startNew();
			String_28 = new Thread(MethodD_298);
			String_28.Start();
		}
	}

    private void Timer1_Tick_1(object sender, EventArgs e)
    {

    }

    private void BtnEMI1_Click_1(object sender, EventArgs e)
    {

    }

    private void TxtEMI_TextChanged(object sender, EventArgs e)
    {

    }

    private void TxtScatter_TextChanged(object sender, EventArgs e)
    {

    }

    private void Guna2CheckBox1_CheckedChanged_1(object sender, EventArgs e)
    {

    }

    private void BtnIdentify_Click_1(object sender, EventArgs e)
    {

    }

    private void MaterialButton30_Click_1(object sender, EventArgs e)
    {

    }

    private void Guna2CheckBox2_CheckedChanged_1(object sender, EventArgs e)
    {

    }

    private void Guna2Button3_Click_1(object sender, EventArgs e)
    {

    }

    private void Guna2Button5_Click_1(object sender, EventArgs e)
    {

    }

    private void Guna2Button9_Click_1(object sender, EventArgs e)
    {

    }

    private void Guna2TextBox2_TextChanged(object sender, EventArgs e)
    {

    }

    private void Guna2Button7_Click_1(object sender, EventArgs e)
    {

    }

    private void Guna2CheckBox3_CheckedChanged_1(object sender, EventArgs e)
    {

    }

    private void Guna2CheckBox4_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void Guna2CheckBox5_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void Guna2CheckBox6_CheckedChanged(object sender, EventArgs e)
    {

    }
}
