using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
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
using motoulocked.Controls;
using motoulocked.core;
using motoulocked.motoulocked;
using motoulocked.My;
using Properties;
using motoulocked.SPD;
using motoulocked.SPD.Worker;

namespace motoulocked;

[DesignerGenerated]
public class SPDR : Form
{
	private IContainer components;

	[CompilerGenerated]
	[AccessedThroughProperty("LIST_SPD")]
	private ListBox _LIST_SPD;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2Button19")]
	private Guna2Button _Guna2Button19;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2Button20")]
	private Guna2Button _Guna2Button20;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2Button8")]
	private Guna2Button _Guna2Button8;

	[CompilerGenerated]
	[AccessedThroughProperty("Timer2")]
	private System.Windows.Forms.Timer _Timer2;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2Button10")]
	private Guna2Button _Guna2Button10;

	public static SPDR SharedUI;

	public static string String_14;

	public static string String_12;

	public static string String_13;

	public static string ProgressChanged;

	public static string cancel;

	public static string Link_Payload;

	private Thread ThreadNew;

	public static string ThisLocation = AppDomain.CurrentDomain.BaseDirectory;

	private string idproos;

	public static string startTime;

	public static string TxtFDL1;

	public static string TxtFDL2;

	public static string TxtFDL1Address;

	public static string TxtFDL2Address;

	public static string TxtPacFirmware;

	public static string Type_Operation;

	public static string String_35;

	public static string String_75;

	public static string String_24;

	private string Log;

	public static string String_30;

	private bool Boolean_2;
    /*
	[field: AccessedThroughProperty("Guna2TextBox1")]
	internal  Guna2TextBox Guna2TextBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtloader")]
	internal  Guna2TextBox txtloader
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Guna2Button5")]
	internal  Guna2Button Guna2Button5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Guna2Button1")]
	internal  Guna2Button Guna2Button1
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

	[field: AccessedThroughProperty("Guna2GroupBox5")]
	internal  Guna2GroupBox Guna2GroupBox5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal  ListBox LIST_SPD
	{
		[CompilerGenerated]
		get
		{
			return _LIST_SPD;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = LIST_SPD_SelectedIndexChanged;
			ListBox lIST_SPD = _LIST_SPD;
			if (lIST_SPD != null)
			{
				lIST_SPD.SelectedIndexChanged -= value2;
			}
			_LIST_SPD = value;
			lIST_SPD = _LIST_SPD;
			if (lIST_SPD != null)
			{
				lIST_SPD.SelectedIndexChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Guna2Button6")]
	internal  Guna2Button Guna2Button6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Guna2TextBox3")]
	internal  Guna2TextBox Guna2TextBox3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Guna2Button7")]
	internal  Guna2Button Guna2Button7
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

	[field: AccessedThroughProperty("TabPage3")]
	internal  TabPage TabPage3
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

	[field: AccessedThroughProperty("TabPage4")]
	internal  TabPage TabPage4
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

	[field: AccessedThroughProperty("BtnIdentify")]
	internal  Guna2Button BtnIdentify
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

	[field: AccessedThroughProperty("buttonerase")]
	internal  Guna2Button buttonerase
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

	[field: AccessedThroughProperty("Guna2GroupBox2")]
	internal  Guna2GroupBox Guna2GroupBox2
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

	[field: AccessedThroughProperty("CkAutoSwitchHighSpeedUSB")]
	internal  Guna2CheckBox CkAutoSwitchHighSpeedUSB
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cbreboot")]
	internal  Guna2CheckBox cbreboot
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TabPage5")]
	internal  TabPage TabPage5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal  Guna2Button Guna2Button20
	{
		[CompilerGenerated]
		get
		{
			return _Guna2Button20;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Guna2Button20_Click;
			Guna2Button guna2Button = _Guna2Button20;
			if (guna2Button != null)
			{
				guna2Button.Click -= value2;
			}
			_Guna2Button20 = value;
			guna2Button = _Guna2Button20;
			if (guna2Button != null)
			{
				guna2Button.Click += value2;
			}
		}
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

	[field: AccessedThroughProperty("txtrawxml")]
	internal  Guna2TextBox txtrawxml
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataViewPartition")]
	internal  DataGridView DataViewPartition
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Guna2Button13")]
	internal  Guna2Button Guna2Button13
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataView")]
	internal  DataGridView DataView
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

	[field: AccessedThroughProperty("Guna2GroupBox8")]
	internal  Guna2GroupBox Guna2GroupBox8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Guna2HScrollBar1")]
	internal  Guna2HScrollBar Guna2HScrollBar1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	[field: AccessedThroughProperty("DataGridViewCheckBoxColumn1")]
	internal  DataGridViewCheckBoxColumn DataGridViewCheckBoxColumn1
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

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn13")]
	internal  DataGridViewTextBoxColumn DataGridViewTextBoxColumn13
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewCheckBoxColumn2")]
	internal  DataGridViewCheckBoxColumn DataGridViewCheckBoxColumn2
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

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn10")]
	internal  DataGridViewTextBoxColumn DataGridViewTextBoxColumn10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn11")]
	internal  DataGridViewTextBoxColumn DataGridViewTextBoxColumn11
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

	[field: AccessedThroughProperty("ComboBox_Factory")]
	internal  Guna2ComboBox ComboBox_Factory
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("String_29")]
	public  WebClient String_29
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}
	*/

    internal Guna2TextBox Guna2TextBox1;
    internal Guna2TextBox txtloader;
    internal Guna2Button Guna2Button5;
    internal Guna2Button Guna2Button1;
    internal Guna2GroupBox Guna2GroupBox4;
    internal Guna2GroupBox Guna2GroupBox5;
    internal ListBox LIST_SPD;
    internal Guna2Button Guna2Button6;
    internal Guna2TextBox Guna2TextBox3;
    internal Guna2Button Guna2Button7;
    internal TabControlExt TabControlExt1;
    internal TabPage TabPage3;
    internal Guna2Button Guna2Button19;
    internal TabPage TabPage4;
    internal Guna2RadioButton Guna2RadioButton8;
    internal Guna2Button BtnIdentify;
    internal Guna2RadioButton Guna2RadioButton7;
    internal Guna2Button buttonerase;
    internal Guna2RadioButton Guna2RadioButton6;
    internal Guna2GroupBox Guna2GroupBox2;
    internal Guna2VScrollBar Guna2VScrollBar2;
    internal Guna2CheckBox CkAutoSwitchHighSpeedUSB;
    internal Guna2CheckBox cbreboot;
    internal TabPage TabPage5;
    internal Guna2Button Guna2Button20;
    internal Guna2GroupBox Guna2GroupBox9;
    internal Guna2VScrollBar Guna2VScrollBar1;
    internal Guna2TextBox txtrawxml;
    internal DataGridView DataViewPartition;
    internal Guna2Button Guna2Button13;
    internal DataGridView DataView;
    internal Guna2Button Guna2Button8;
    internal Guna2GroupBox Guna2GroupBox8;
    internal Guna2HScrollBar Guna2HScrollBar1;
    internal System.Windows.Forms.Timer Timer2;
    internal DataGridViewCheckBoxColumn DataGridViewCheckBoxColumn1;
    internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
    internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn2;
    internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn3;
    internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn4;
    internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn5;
    internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn13;
    internal DataGridViewCheckBoxColumn DataGridViewCheckBoxColumn2;
    internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn6;
    internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn7;
    internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn8;
    internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn9;
    internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn10;
    internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn11;
    internal Guna2Button Guna2Button10;
    internal Guna2ComboBox ComboBox_Factory;

    public static int WaktuCari { get; set; } = 0;


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SPDR));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Guna2GroupBox4 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.Guna2GroupBox5 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.LIST_SPD = new System.Windows.Forms.ListBox();
            this.Guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2TextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.Timer2 = new System.Windows.Forms.Timer(this.components);
            this.TabControlExt1 = new Controls.TabControlExt();
            this.TabPage3 = new System.Windows.Forms.TabPage();
            this.Guna2Button10 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2GroupBox8 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtloader = new Guna.UI2.WinForms.Guna2TextBox();
            this.Guna2Button7 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.Guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2Button8 = new Guna.UI2.WinForms.Guna2Button();
            this.ComboBox_Factory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Guna2Button19 = new Guna.UI2.WinForms.Guna2Button();
            this.TabPage4 = new System.Windows.Forms.TabPage();
            this.Guna2RadioButton8 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.BtnIdentify = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2RadioButton7 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.buttonerase = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2RadioButton6 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.Guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.Guna2VScrollBar2 = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.DataViewPartition = new System.Windows.Forms.DataGridView();
            this.DataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CkAutoSwitchHighSpeedUSB = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cbreboot = new Guna.UI2.WinForms.Guna2CheckBox();
            this.TabPage5 = new System.Windows.Forms.TabPage();
            this.Guna2Button13 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2Button20 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2GroupBox9 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.Guna2HScrollBar1 = new Guna.UI2.WinForms.Guna2HScrollBar();
            this.DataView = new System.Windows.Forms.DataGridView();
            this.DataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Guna2VScrollBar1 = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.txtrawxml = new Guna.UI2.WinForms.Guna2TextBox();
            this.Guna2GroupBox4.SuspendLayout();
            this.Guna2GroupBox5.SuspendLayout();
            this.TabControlExt1.SuspendLayout();
            this.TabPage3.SuspendLayout();
            this.Guna2GroupBox8.SuspendLayout();
            this.TabPage4.SuspendLayout();
            this.Guna2GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataViewPartition)).BeginInit();
            this.TabPage5.SuspendLayout();
            this.Guna2GroupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).BeginInit();
            this.SuspendLayout();
            // 
            // Guna2GroupBox4
            // 
            this.Guna2GroupBox4.BackColor = System.Drawing.Color.Transparent;
            this.Guna2GroupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Guna2GroupBox4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2GroupBox4.BorderRadius = 6;
            this.Guna2GroupBox4.Controls.Add(this.Guna2GroupBox5);
            this.Guna2GroupBox4.Controls.Add(this.Guna2Button6);
            this.Guna2GroupBox4.Controls.Add(this.Guna2TextBox3);
            this.Guna2GroupBox4.Cursor = System.Windows.Forms.Cursors.Default;
            this.Guna2GroupBox4.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2GroupBox4.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.Guna2GroupBox4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2GroupBox4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Guna2GroupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Guna2GroupBox4.Location = new System.Drawing.Point(9, 7);
            this.Guna2GroupBox4.Name = "Guna2GroupBox4";
            this.Guna2GroupBox4.ShadowDecoration.BorderRadius = 9;
            this.Guna2GroupBox4.ShadowDecoration.Color = System.Drawing.Color.White;
            this.Guna2GroupBox4.ShadowDecoration.Depth = 15;
            this.Guna2GroupBox4.Size = new System.Drawing.Size(480, 196);
            this.Guna2GroupBox4.TabIndex = 524;
            // 
            // Guna2GroupBox5
            // 
            this.Guna2GroupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Guna2GroupBox5.BackColor = System.Drawing.Color.Transparent;
            this.Guna2GroupBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Guna2GroupBox5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2GroupBox5.BorderRadius = 6;
            this.Guna2GroupBox5.Controls.Add(this.LIST_SPD);
            this.Guna2GroupBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guna2GroupBox5.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2GroupBox5.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.Guna2GroupBox5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2GroupBox5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Guna2GroupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Guna2GroupBox5.Location = new System.Drawing.Point(6, 6);
            this.Guna2GroupBox5.Name = "Guna2GroupBox5";
            this.Guna2GroupBox5.ShadowDecoration.BorderRadius = 9;
            this.Guna2GroupBox5.ShadowDecoration.Color = System.Drawing.Color.White;
            this.Guna2GroupBox5.ShadowDecoration.Depth = 15;
            this.Guna2GroupBox5.Size = new System.Drawing.Size(468, 184);
            this.Guna2GroupBox5.TabIndex = 521;
            // 
            // LIST_SPD
            // 
            this.LIST_SPD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LIST_SPD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.LIST_SPD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LIST_SPD.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LIST_SPD.ForeColor = System.Drawing.Color.White;
            this.LIST_SPD.FormattingEnabled = true;
            this.LIST_SPD.ItemHeight = 17;
            this.LIST_SPD.Location = new System.Drawing.Point(4, 4);
            this.LIST_SPD.Name = "LIST_SPD";
            this.LIST_SPD.Size = new System.Drawing.Size(460, 170);
            this.LIST_SPD.TabIndex = 520;
            // 
            // Guna2Button6
            // 
            this.Guna2Button6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Guna2Button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2Button6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2Button6.BorderRadius = 4;
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
            this.Guna2Button6.Image = global::Properties.Resources.search_in_folder;
            this.Guna2Button6.ImageSize = new System.Drawing.Size(25, 25);
            this.Guna2Button6.Location = new System.Drawing.Point(424, 161);
            this.Guna2Button6.Name = "Guna2Button6";
            this.Guna2Button6.PressedColor = System.Drawing.Color.Empty;
            this.Guna2Button6.Size = new System.Drawing.Size(48, 26);
            this.Guna2Button6.TabIndex = 518;
            this.Guna2Button6.TextFormatNoPrefix = true;
            // 
            // Guna2TextBox3
            // 
            this.Guna2TextBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Guna2TextBox3.Animated = true;
            this.Guna2TextBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2TextBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2TextBox3.BorderRadius = 5;
            this.Guna2TextBox3.BorderThickness = 2;
            this.Guna2TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Guna2TextBox3.DefaultText = "";
            this.Guna2TextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2TextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2TextBox3.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.Guna2TextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.Guna2TextBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2TextBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Guna2TextBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2TextBox3.ForeColor = System.Drawing.Color.White;
            this.Guna2TextBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2TextBox3.Location = new System.Drawing.Point(8, 161);
            this.Guna2TextBox3.Name = "Guna2TextBox3";
            this.Guna2TextBox3.PasswordChar = '\0';
            this.Guna2TextBox3.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.Guna2TextBox3.PlaceholderText = "Loader";
            this.Guna2TextBox3.SelectedText = "";
            this.Guna2TextBox3.ShadowDecoration.Color = System.Drawing.Color.DimGray;
            this.Guna2TextBox3.ShadowDecoration.Depth = 15;
            this.Guna2TextBox3.Size = new System.Drawing.Size(410, 26);
            this.Guna2TextBox3.TabIndex = 519;
            this.Guna2TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Timer2
            // 
            this.Timer2.Enabled = true;
            // 
            // TabControlExt1
            // 
            this.TabControlExt1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TabControlExt1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.TabControlExt1.CloseBtnColor = System.Drawing.Color.White;
            this.TabControlExt1.Controls.Add(this.TabPage3);
            this.TabControlExt1.Controls.Add(this.TabPage4);
            this.TabControlExt1.Controls.Add(this.TabPage5);
            this.TabControlExt1.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControlExt1.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.TabControlExt1.HeadSelectedBackColor = System.Drawing.Color.FromArgb(0, 85, 207);
            this.TabControlExt1.HeadSelectedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.TabControlExt1.IsShowCloseBtn = false;
            this.TabControlExt1.ItemSize = new System.Drawing.Size(0, 26);
            this.TabControlExt1.Location = new System.Drawing.Point(9, 209);
            this.TabControlExt1.Name = "TabControlExt1";
            this.TabControlExt1.SelectedIndex = 0;
            this.TabControlExt1.Size = new System.Drawing.Size(480, 318);
            this.TabControlExt1.TabIndex = 526;
            this.TabControlExt1.TabTextColor = System.Drawing.Color.White;
            this.TabControlExt1.UncloseTabIndexs = null;
            // 
            // TabPage3
            // 
            this.TabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TabPage3.Controls.Add(this.Guna2Button10);
            this.TabPage3.Controls.Add(this.Guna2GroupBox8);
            this.TabPage3.Controls.Add(this.Guna2Button8);
            this.TabPage3.Controls.Add(this.ComboBox_Factory);
            this.TabPage3.Controls.Add(this.Guna2Button19);
            this.TabPage3.Location = new System.Drawing.Point(4, 30);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage3.Size = new System.Drawing.Size(472, 284);
            this.TabPage3.TabIndex = 0;
            this.TabPage3.Text = "Services";
            // 
            // Guna2Button10
            // 
            this.Guna2Button10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Guna2Button10.Animated = true;
            this.Guna2Button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2Button10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2Button10.BorderRadius = 4;
            this.Guna2Button10.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.Guna2Button10.BorderThickness = 2;
            this.Guna2Button10.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button10.CheckedState.FillColor = System.Drawing.Color.LightGray;
            this.Guna2Button10.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
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
            this.Guna2Button10.Image = global::Properties.Resources.tools;
            this.Guna2Button10.ImageSize = new System.Drawing.Size(23, 23);
            this.Guna2Button10.Location = new System.Drawing.Point(9, 85);
            this.Guna2Button10.Name = "Guna2Button10";
            this.Guna2Button10.PressedColor = System.Drawing.Color.Empty;
            this.Guna2Button10.Size = new System.Drawing.Size(232, 32);
            this.Guna2Button10.TabIndex = 549;
            this.Guna2Button10.Text = " Start =>";
            this.Guna2Button10.TextFormatNoPrefix = true;
            // 
            // Guna2GroupBox8
            // 
            this.Guna2GroupBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2GroupBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Guna2GroupBox8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2GroupBox8.BorderRadius = 6;
            this.Guna2GroupBox8.Controls.Add(this.txtloader);
            this.Guna2GroupBox8.Controls.Add(this.Guna2Button7);
            this.Guna2GroupBox8.Controls.Add(this.Guna2Button5);
            this.Guna2GroupBox8.Controls.Add(this.Guna2TextBox1);
            this.Guna2GroupBox8.Controls.Add(this.Guna2Button1);
            this.Guna2GroupBox8.Cursor = System.Windows.Forms.Cursors.Default;
            this.Guna2GroupBox8.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2GroupBox8.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.Guna2GroupBox8.Enabled = false;
            this.Guna2GroupBox8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2GroupBox8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Guna2GroupBox8.ForeColor = System.Drawing.Color.White;
            this.Guna2GroupBox8.Location = new System.Drawing.Point(9, 123);
            this.Guna2GroupBox8.Name = "Guna2GroupBox8";
            this.Guna2GroupBox8.ShadowDecoration.BorderRadius = 9;
            this.Guna2GroupBox8.ShadowDecoration.Color = System.Drawing.Color.White;
            this.Guna2GroupBox8.ShadowDecoration.Depth = 15;
            this.Guna2GroupBox8.Size = new System.Drawing.Size(455, 153);
            this.Guna2GroupBox8.TabIndex = 548;
            // 
            // txtloader
            // 
            this.txtloader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtloader.Animated = true;
            this.txtloader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtloader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.txtloader.BorderRadius = 5;
            this.txtloader.BorderThickness = 2;
            this.txtloader.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtloader.DefaultText = "";
            this.txtloader.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.txtloader.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.txtloader.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.txtloader.DisabledState.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtloader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txtloader.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtloader.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtloader.ForeColor = System.Drawing.Color.White;
            this.txtloader.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.txtloader.Location = new System.Drawing.Point(6, 46);
            this.txtloader.Name = "txtloader";
            this.txtloader.PasswordChar = '\0';
            this.txtloader.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtloader.PlaceholderText = "IMEI 1";
            this.txtloader.SelectedText = "";
            this.txtloader.ShadowDecoration.Color = System.Drawing.Color.DimGray;
            this.txtloader.ShadowDecoration.Depth = 15;
            this.txtloader.Size = new System.Drawing.Size(442, 28);
            this.txtloader.TabIndex = 525;
            this.txtloader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Guna2Button7
            // 
            this.Guna2Button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Guna2Button7.Animated = true;
            this.Guna2Button7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2Button7.BorderRadius = 4;
            this.Guna2Button7.BorderThickness = 2;
            this.Guna2Button7.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button7.CheckedState.FillColor = System.Drawing.Color.LightGray;
            this.Guna2Button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guna2Button7.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button7.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
            this.Guna2Button7.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button7.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.Guna2Button7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2Button7.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Guna2Button7.ForeColor = System.Drawing.Color.White;
            this.Guna2Button7.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button7.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button7.Image = global::Properties.Resources.info__1_;
            this.Guna2Button7.Location = new System.Drawing.Point(6, 114);
            this.Guna2Button7.Name = "Guna2Button7";
            this.Guna2Button7.PressedColor = System.Drawing.Color.Empty;
            this.Guna2Button7.Size = new System.Drawing.Size(106, 32);
            this.Guna2Button7.TabIndex = 527;
            this.Guna2Button7.Text = " Read";
            this.Guna2Button7.TextFormatNoPrefix = true;
            // 
            // Guna2Button5
            // 
            this.Guna2Button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Guna2Button5.Animated = true;
            this.Guna2Button5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2Button5.BorderRadius = 4;
            this.Guna2Button5.BorderThickness = 2;
            this.Guna2Button5.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button5.CheckedState.FillColor = System.Drawing.Color.LightGray;
            this.Guna2Button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guna2Button5.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
            this.Guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button5.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.Guna2Button5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2Button5.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Guna2Button5.ForeColor = System.Drawing.Color.White;
            this.Guna2Button5.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button5.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button5.Image = global::Properties.Resources.edit__1_;
            this.Guna2Button5.Location = new System.Drawing.Point(118, 114);
            this.Guna2Button5.Name = "Guna2Button5";
            this.Guna2Button5.PressedColor = System.Drawing.Color.Empty;
            this.Guna2Button5.Size = new System.Drawing.Size(330, 32);
            this.Guna2Button5.TabIndex = 524;
            this.Guna2Button5.Text = " Write";
            this.Guna2Button5.TextFormatNoPrefix = true;
            // 
            // Guna2TextBox1
            // 
            this.Guna2TextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
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
            this.Guna2TextBox1.Location = new System.Drawing.Point(6, 80);
            this.Guna2TextBox1.Name = "Guna2TextBox1";
            this.Guna2TextBox1.PasswordChar = '\0';
            this.Guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.Guna2TextBox1.PlaceholderText = "IMEI 2";
            this.Guna2TextBox1.SelectedText = "";
            this.Guna2TextBox1.ShadowDecoration.Color = System.Drawing.Color.DimGray;
            this.Guna2TextBox1.ShadowDecoration.Depth = 15;
            this.Guna2TextBox1.Size = new System.Drawing.Size(442, 28);
            this.Guna2TextBox1.TabIndex = 526;
            this.Guna2TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Guna2Button1
            // 
            this.Guna2Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Guna2Button1.Animated = true;
            this.Guna2Button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2Button1.BorderRadius = 4;
            this.Guna2Button1.BorderThickness = 2;
            this.Guna2Button1.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button1.CheckedState.FillColor = System.Drawing.Color.LightGray;
            this.Guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
            this.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2Button1.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Guna2Button1.ForeColor = System.Drawing.Color.White;
            this.Guna2Button1.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button1.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button1.Image = global::Properties.Resources.imggunlock;
            this.Guna2Button1.Location = new System.Drawing.Point(6, 8);
            this.Guna2Button1.Name = "Guna2Button1";
            this.Guna2Button1.PressedColor = System.Drawing.Color.Empty;
            this.Guna2Button1.Size = new System.Drawing.Size(442, 32);
            this.Guna2Button1.TabIndex = 492;
            this.Guna2Button1.Text = "Unlock Network";
            this.Guna2Button1.TextFormatNoPrefix = true;
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
            this.Guna2Button8.Location = new System.Drawing.Point(9, 47);
            this.Guna2Button8.Name = "Guna2Button8";
            this.Guna2Button8.PressedColor = System.Drawing.Color.Empty;
            this.Guna2Button8.Size = new System.Drawing.Size(455, 32);
            this.Guna2Button8.TabIndex = 546;
            this.Guna2Button8.Text = "Remove MDM (Beta)";
            this.Guna2Button8.TextFormatNoPrefix = true;
            // 
            // ComboBox_Factory
            // 
            this.ComboBox_Factory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ComboBox_Factory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ComboBox_Factory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.ComboBox_Factory.BorderRadius = 4;
            this.ComboBox_Factory.BorderThickness = 2;
            this.ComboBox_Factory.Cursor = System.Windows.Forms.Cursors.Default;
            this.ComboBox_Factory.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ComboBox_Factory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ComboBox_Factory.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.ComboBox_Factory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox_Factory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Factory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ComboBox_Factory.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBox_Factory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBox_Factory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBox_Factory.ForeColor = System.Drawing.Color.White;
            this.ComboBox_Factory.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.ComboBox_Factory.ItemHeight = 26;
            this.ComboBox_Factory.Items.AddRange(new object[] {
            "Factory Reset (New)",
            "Factory Reset (Old)"});
            this.ComboBox_Factory.ItemsAppearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.ComboBox_Factory.ItemsAppearance.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_Factory.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.ComboBox_Factory.Location = new System.Drawing.Point(247, 85);
            this.ComboBox_Factory.MaxDropDownItems = 5;
            this.ComboBox_Factory.MaxLength = 5;
            this.ComboBox_Factory.Name = "ComboBox_Factory";
            this.ComboBox_Factory.Size = new System.Drawing.Size(217, 32);
            this.ComboBox_Factory.StartIndex = 0;
            this.ComboBox_Factory.TabIndex = 550;
            // 
            // Guna2Button19
            // 
            this.Guna2Button19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Guna2Button19.Animated = true;
            this.Guna2Button19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2Button19.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2Button19.BorderRadius = 4;
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
            this.Guna2Button19.Image = global::Properties.Resources.google__2_;
            this.Guna2Button19.Location = new System.Drawing.Point(9, 8);
            this.Guna2Button19.Name = "Guna2Button19";
            this.Guna2Button19.PressedColor = System.Drawing.Color.Empty;
            this.Guna2Button19.Size = new System.Drawing.Size(455, 33);
            this.Guna2Button19.TabIndex = 535;
            this.Guna2Button19.Text = " Remove FRP Lock";
            this.Guna2Button19.TextFormatNoPrefix = true;
            // 
            // TabPage4
            // 
            this.TabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TabPage4.Controls.Add(this.Guna2RadioButton8);
            this.TabPage4.Controls.Add(this.BtnIdentify);
            this.TabPage4.Controls.Add(this.Guna2RadioButton7);
            this.TabPage4.Controls.Add(this.buttonerase);
            this.TabPage4.Controls.Add(this.Guna2RadioButton6);
            this.TabPage4.Controls.Add(this.Guna2GroupBox2);
            this.TabPage4.Controls.Add(this.CkAutoSwitchHighSpeedUSB);
            this.TabPage4.Controls.Add(this.cbreboot);
            this.TabPage4.Location = new System.Drawing.Point(4, 30);
            this.TabPage4.Name = "TabPage4";
            this.TabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage4.Size = new System.Drawing.Size(472, 284);
            this.TabPage4.TabIndex = 1;
            this.TabPage4.Text = "Partition Manger";
            // 
            // Guna2RadioButton8
            // 
            this.Guna2RadioButton8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Guna2RadioButton8.Animated = true;
            this.Guna2RadioButton8.AutoSize = true;
            this.Guna2RadioButton8.BackColor = System.Drawing.Color.Transparent;
            this.Guna2RadioButton8.CheckedState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2RadioButton8.CheckedState.BorderThickness = 3;
            this.Guna2RadioButton8.CheckedState.FillColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2RadioButton8.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(99)))), ((int)(((byte)(129)))));
            this.Guna2RadioButton8.CheckedState.InnerOffset = -6;
            this.Guna2RadioButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guna2RadioButton8.Enabled = false;
            this.Guna2RadioButton8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2RadioButton8.ForeColor = System.Drawing.Color.White;
            this.Guna2RadioButton8.Location = new System.Drawing.Point(221, 256);
            this.Guna2RadioButton8.Name = "Guna2RadioButton8";
            this.Guna2RadioButton8.Size = new System.Drawing.Size(54, 19);
            this.Guna2RadioButton8.TabIndex = 538;
            this.Guna2RadioButton8.Text = "Write";
            this.Guna2RadioButton8.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2RadioButton8.UncheckedState.BorderThickness = 3;
            this.Guna2RadioButton8.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2RadioButton8.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2RadioButton8.UseVisualStyleBackColor = false;
            // 
            // BtnIdentify
            // 
            this.BtnIdentify.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnIdentify.Animated = true;
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
            this.BtnIdentify.Enabled = false;
            this.BtnIdentify.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.BtnIdentify.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnIdentify.ForeColor = System.Drawing.Color.White;
            this.BtnIdentify.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.BtnIdentify.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.BtnIdentify.Image = global::Properties.Resources.link;
            this.BtnIdentify.ImageSize = new System.Drawing.Size(22, 22);
            this.BtnIdentify.Location = new System.Drawing.Point(6, 224);
            this.BtnIdentify.Name = "BtnIdentify";
            this.BtnIdentify.PressedColor = System.Drawing.Color.Empty;
            this.BtnIdentify.Size = new System.Drawing.Size(460, 24);
            this.BtnIdentify.TabIndex = 496;
            this.BtnIdentify.Text = " List Partition";
            this.BtnIdentify.TextFormatNoPrefix = true;
            // 
            // Guna2RadioButton7
            // 
            this.Guna2RadioButton7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Guna2RadioButton7.Animated = true;
            this.Guna2RadioButton7.AutoSize = true;
            this.Guna2RadioButton7.BackColor = System.Drawing.Color.Transparent;
            this.Guna2RadioButton7.CheckedState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2RadioButton7.CheckedState.BorderThickness = 3;
            this.Guna2RadioButton7.CheckedState.FillColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2RadioButton7.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(99)))), ((int)(((byte)(129)))));
            this.Guna2RadioButton7.CheckedState.InnerOffset = -6;
            this.Guna2RadioButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guna2RadioButton7.Enabled = false;
            this.Guna2RadioButton7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2RadioButton7.ForeColor = System.Drawing.Color.White;
            this.Guna2RadioButton7.Location = new System.Drawing.Point(280, 256);
            this.Guna2RadioButton7.Name = "Guna2RadioButton7";
            this.Guna2RadioButton7.Size = new System.Drawing.Size(52, 19);
            this.Guna2RadioButton7.TabIndex = 537;
            this.Guna2RadioButton7.Text = "Erase";
            this.Guna2RadioButton7.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2RadioButton7.UncheckedState.BorderThickness = 3;
            this.Guna2RadioButton7.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2RadioButton7.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2RadioButton7.UseVisualStyleBackColor = false;
            // 
            // buttonerase
            // 
            this.buttonerase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonerase.Animated = true;
            this.buttonerase.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.buttonerase.BorderRadius = 4;
            this.buttonerase.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.buttonerase.BorderThickness = 2;
            this.buttonerase.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonerase.CheckedState.FillColor = System.Drawing.Color.LightGray;
            this.buttonerase.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.buttonerase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonerase.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.buttonerase.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
            this.buttonerase.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.buttonerase.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.buttonerase.Enabled = false;
            this.buttonerase.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.buttonerase.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonerase.ForeColor = System.Drawing.Color.White;
            this.buttonerase.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.buttonerase.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.buttonerase.Image = global::Properties.Resources.video;
            this.buttonerase.Location = new System.Drawing.Point(338, 253);
            this.buttonerase.Name = "buttonerase";
            this.buttonerase.PressedColor = System.Drawing.Color.Empty;
            this.buttonerase.Size = new System.Drawing.Size(128, 24);
            this.buttonerase.TabIndex = 523;
            this.buttonerase.Text = " Start Job";
            this.buttonerase.TextFormatNoPrefix = true;
            // 
            // Guna2RadioButton6
            // 
            this.Guna2RadioButton6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Guna2RadioButton6.Animated = true;
            this.Guna2RadioButton6.AutoSize = true;
            this.Guna2RadioButton6.BackColor = System.Drawing.Color.Transparent;
            this.Guna2RadioButton6.Checked = true;
            this.Guna2RadioButton6.CheckedState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2RadioButton6.CheckedState.BorderThickness = 3;
            this.Guna2RadioButton6.CheckedState.FillColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2RadioButton6.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(99)))), ((int)(((byte)(129)))));
            this.Guna2RadioButton6.CheckedState.InnerOffset = -6;
            this.Guna2RadioButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guna2RadioButton6.Enabled = false;
            this.Guna2RadioButton6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2RadioButton6.ForeColor = System.Drawing.Color.White;
            this.Guna2RadioButton6.Location = new System.Drawing.Point(165, 256);
            this.Guna2RadioButton6.Name = "Guna2RadioButton6";
            this.Guna2RadioButton6.Size = new System.Drawing.Size(51, 19);
            this.Guna2RadioButton6.TabIndex = 536;
            this.Guna2RadioButton6.TabStop = true;
            this.Guna2RadioButton6.Text = "Read";
            this.Guna2RadioButton6.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2RadioButton6.UncheckedState.BorderThickness = 3;
            this.Guna2RadioButton6.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2RadioButton6.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2RadioButton6.UseVisualStyleBackColor = false;
            // 
            // Guna2GroupBox2
            // 
            this.Guna2GroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Guna2GroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.Guna2GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Guna2GroupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2GroupBox2.BorderRadius = 6;
            this.Guna2GroupBox2.BorderThickness = 2;
            this.Guna2GroupBox2.Controls.Add(this.Guna2VScrollBar2);
            this.Guna2GroupBox2.Controls.Add(this.DataViewPartition);
            this.Guna2GroupBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2GroupBox2.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.Guna2GroupBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Guna2GroupBox2.Location = new System.Drawing.Point(6, 6);
            this.Guna2GroupBox2.Name = "Guna2GroupBox2";
            this.Guna2GroupBox2.ShadowDecoration.BorderRadius = 9;
            this.Guna2GroupBox2.ShadowDecoration.Color = System.Drawing.Color.White;
            this.Guna2GroupBox2.ShadowDecoration.Depth = 15;
            this.Guna2GroupBox2.Size = new System.Drawing.Size(460, 213);
            this.Guna2GroupBox2.TabIndex = 514;
            // 
            // Guna2VScrollBar2
            // 
            this.Guna2VScrollBar2.AutoRoundedCorners = true;
            this.Guna2VScrollBar2.AutoScroll = true;
            this.Guna2VScrollBar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2VScrollBar2.BindingContainer = this.DataViewPartition;
            this.Guna2VScrollBar2.BorderRadius = 8;
            this.Guna2VScrollBar2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2VScrollBar2.HighlightOnWheel = true;
            this.Guna2VScrollBar2.InUpdate = false;
            this.Guna2VScrollBar2.LargeChange = 10;
            this.Guna2VScrollBar2.Location = new System.Drawing.Point(439, 3);
            this.Guna2VScrollBar2.Minimum = 1;
            this.Guna2VScrollBar2.Name = "Guna2VScrollBar2";
            this.Guna2VScrollBar2.ScrollbarSize = 18;
            this.Guna2VScrollBar2.Size = new System.Drawing.Size(18, 207);
            this.Guna2VScrollBar2.TabIndex = 497;
            this.Guna2VScrollBar2.ThumbColor = System.Drawing.Color.FromArgb(0, 85, 207);
            this.Guna2VScrollBar2.ThumbSize = 35F;
            this.Guna2VScrollBar2.ThumbStyle = Guna.UI2.WinForms.Enums.ThumbStyle.Inset;
            this.Guna2VScrollBar2.Value = 1;
            // 
            // DataViewPartition
            // 
            this.DataViewPartition.AllowUserToAddRows = false;
            this.DataViewPartition.AllowUserToDeleteRows = false;
            this.DataViewPartition.AllowUserToResizeColumns = false;
            this.DataViewPartition.AllowUserToResizeRows = false;
            this.DataViewPartition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DataViewPartition.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataViewPartition.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataViewPartition.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.DataViewPartition.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataViewPartition.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.DataViewPartition.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataViewPartition.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataViewPartition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataViewPartition.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewCheckBoxColumn1,
            this.DataGridViewTextBoxColumn1,
            this.DataGridViewTextBoxColumn2,
            this.DataGridViewTextBoxColumn3,
            this.DataGridViewTextBoxColumn4,
            this.DataGridViewTextBoxColumn5,
            this.DataGridViewTextBoxColumn13});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataViewPartition.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataViewPartition.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.DataViewPartition.EnableHeadersVisualStyles = false;
            this.DataViewPartition.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.DataViewPartition.Location = new System.Drawing.Point(4, 3);
            this.DataViewPartition.MultiSelect = false;
            this.DataViewPartition.Name = "DataViewPartition";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataViewPartition.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataViewPartition.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.DataViewPartition.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DataViewPartition.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.DataViewPartition.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataViewPartition.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.DataViewPartition.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.DataViewPartition.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DataViewPartition.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataViewPartition.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataViewPartition.Size = new System.Drawing.Size(453, 207);
            this.DataViewPartition.TabIndex = 498;
            // 
            // DataGridViewCheckBoxColumn1
            // 
            this.DataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DataGridViewCheckBoxColumn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DataGridViewCheckBoxColumn1.Frozen = true;
            this.DataGridViewCheckBoxColumn1.HeaderText = " ";
            this.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1";
            this.DataGridViewCheckBoxColumn1.Width = 19;
            // 
            // DataGridViewTextBoxColumn1
            // 
            this.DataGridViewTextBoxColumn1.FillWeight = 50F;
            this.DataGridViewTextBoxColumn1.HeaderText = "File Name";
            this.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
            this.DataGridViewTextBoxColumn1.ReadOnly = true;
            this.DataGridViewTextBoxColumn1.Width = 84;
            // 
            // DataGridViewTextBoxColumn2
            // 
            this.DataGridViewTextBoxColumn2.FillWeight = 70F;
            this.DataGridViewTextBoxColumn2.HeaderText = "Partition";
            this.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2";
            this.DataGridViewTextBoxColumn2.ReadOnly = true;
            this.DataGridViewTextBoxColumn2.Width = 76;
            // 
            // DataGridViewTextBoxColumn3
            // 
            this.DataGridViewTextBoxColumn3.FillWeight = 40F;
            this.DataGridViewTextBoxColumn3.HeaderText = "Sectors";
            this.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3";
            this.DataGridViewTextBoxColumn3.Width = 69;
            // 
            // DataGridViewTextBoxColumn4
            // 
            this.DataGridViewTextBoxColumn4.FillWeight = 40F;
            this.DataGridViewTextBoxColumn4.HeaderText = "Lengths";
            this.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4";
            this.DataGridViewTextBoxColumn4.Visible = false;
            this.DataGridViewTextBoxColumn4.Width = 73;
            // 
            // DataGridViewTextBoxColumn5
            // 
            this.DataGridViewTextBoxColumn5.HeaderText = "File Sizes";
            this.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5";
            this.DataGridViewTextBoxColumn5.Width = 77;
            // 
            // DataGridViewTextBoxColumn13
            // 
            this.DataGridViewTextBoxColumn13.FillWeight = 50F;
            this.DataGridViewTextBoxColumn13.HeaderText = "Locations";
            this.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13";
            this.DataGridViewTextBoxColumn13.ReadOnly = true;
            this.DataGridViewTextBoxColumn13.Width = 82;
            // 
            // CkAutoSwitchHighSpeedUSB
            // 
            this.CkAutoSwitchHighSpeedUSB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CkAutoSwitchHighSpeedUSB.Animated = true;
            this.CkAutoSwitchHighSpeedUSB.AutoSize = true;
            this.CkAutoSwitchHighSpeedUSB.BackColor = System.Drawing.Color.Transparent;
            this.CkAutoSwitchHighSpeedUSB.CheckedState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.CkAutoSwitchHighSpeedUSB.CheckedState.BorderRadius = 4;
            this.CkAutoSwitchHighSpeedUSB.CheckedState.BorderThickness = 2;
            this.CkAutoSwitchHighSpeedUSB.CheckedState.FillColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.CkAutoSwitchHighSpeedUSB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CkAutoSwitchHighSpeedUSB.ForeColor = System.Drawing.Color.White;
            this.CkAutoSwitchHighSpeedUSB.Location = new System.Drawing.Point(9, 257);
            this.CkAutoSwitchHighSpeedUSB.Name = "CkAutoSwitchHighSpeedUSB";
            this.CkAutoSwitchHighSpeedUSB.Size = new System.Drawing.Size(78, 19);
            this.CkAutoSwitchHighSpeedUSB.TabIndex = 525;
            this.CkAutoSwitchHighSpeedUSB.Text = "Select All";
            this.CkAutoSwitchHighSpeedUSB.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.CkAutoSwitchHighSpeedUSB.UncheckedState.BorderRadius = 3;
            this.CkAutoSwitchHighSpeedUSB.UncheckedState.BorderThickness = 1;
            this.CkAutoSwitchHighSpeedUSB.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.CkAutoSwitchHighSpeedUSB.UseVisualStyleBackColor = false;
            // 
            // cbreboot
            // 
            this.cbreboot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbreboot.Animated = true;
            this.cbreboot.AutoSize = true;
            this.cbreboot.BackColor = System.Drawing.Color.Transparent;
            this.cbreboot.Checked = true;
            this.cbreboot.CheckedState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.cbreboot.CheckedState.BorderRadius = 4;
            this.cbreboot.CheckedState.BorderThickness = 2;
            this.cbreboot.CheckedState.FillColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.cbreboot.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbreboot.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbreboot.ForeColor = System.Drawing.Color.White;
            this.cbreboot.Location = new System.Drawing.Point(92, 257);
            this.cbreboot.Name = "cbreboot";
            this.cbreboot.Size = new System.Drawing.Size(67, 19);
            this.cbreboot.TabIndex = 539;
            this.cbreboot.Text = "Reboot";
            this.cbreboot.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.cbreboot.UncheckedState.BorderRadius = 3;
            this.cbreboot.UncheckedState.BorderThickness = 1;
            this.cbreboot.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.cbreboot.UseVisualStyleBackColor = false;
            // 
            // TabPage5
            // 
            this.TabPage5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TabPage5.Controls.Add(this.Guna2Button13);
            this.TabPage5.Controls.Add(this.Guna2Button20);
            this.TabPage5.Controls.Add(this.Guna2GroupBox9);
            this.TabPage5.Controls.Add(this.txtrawxml);
            this.TabPage5.Location = new System.Drawing.Point(4, 30);
            this.TabPage5.Name = "TabPage5";
            this.TabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage5.Size = new System.Drawing.Size(472, 284);
            this.TabPage5.TabIndex = 2;
            this.TabPage5.Text = "Flasher";
            // 
            // Guna2Button13
            // 
            this.Guna2Button13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Guna2Button13.Animated = true;
            this.Guna2Button13.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2Button13.BorderRadius = 4;
            this.Guna2Button13.BorderThickness = 2;
            this.Guna2Button13.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button13.CheckedState.FillColor = System.Drawing.Color.LightGray;
            this.Guna2Button13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guna2Button13.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button13.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
            this.Guna2Button13.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button13.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.Guna2Button13.Enabled = false;
            this.Guna2Button13.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2Button13.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Guna2Button13.ForeColor = System.Drawing.Color.White;
            this.Guna2Button13.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button13.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button13.Image = global::Properties.Resources.edit__1_;
            this.Guna2Button13.Location = new System.Drawing.Point(341, 248);
            this.Guna2Button13.Name = "Guna2Button13";
            this.Guna2Button13.PressedColor = System.Drawing.Color.Empty;
            this.Guna2Button13.Size = new System.Drawing.Size(125, 27);
            this.Guna2Button13.TabIndex = 553;
            this.Guna2Button13.Text = "Write";
            this.Guna2Button13.TextFormatNoPrefix = true;
            // 
            // Guna2Button20
            // 
            this.Guna2Button20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Guna2Button20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2Button20.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2Button20.BorderRadius = 4;
            this.Guna2Button20.BorderThickness = 2;
            this.Guna2Button20.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button20.CheckedState.FillColor = System.Drawing.Color.LightGray;
            this.Guna2Button20.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button20.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
            this.Guna2Button20.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button20.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.Guna2Button20.Enabled = false;
            this.Guna2Button20.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2Button20.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2Button20.ForeColor = System.Drawing.Color.White;
            this.Guna2Button20.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button20.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button20.Image = global::Properties.Resources.search_in_folder;
            this.Guna2Button20.ImageSize = new System.Drawing.Size(25, 25);
            this.Guna2Button20.Location = new System.Drawing.Point(6, 248);
            this.Guna2Button20.Name = "Guna2Button20";
            this.Guna2Button20.PressedColor = System.Drawing.Color.Empty;
            this.Guna2Button20.Size = new System.Drawing.Size(48, 27);
            this.Guna2Button20.TabIndex = 547;
            this.Guna2Button20.TextFormatNoPrefix = true;
            // 
            // Guna2GroupBox9
            // 
            this.Guna2GroupBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Guna2GroupBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2GroupBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Guna2GroupBox9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2GroupBox9.BorderRadius = 6;
            this.Guna2GroupBox9.BorderThickness = 2;
            this.Guna2GroupBox9.Controls.Add(this.Guna2HScrollBar1);
            this.Guna2GroupBox9.Controls.Add(this.Guna2VScrollBar1);
            this.Guna2GroupBox9.Controls.Add(this.DataView);
            this.Guna2GroupBox9.Cursor = System.Windows.Forms.Cursors.Default;
            this.Guna2GroupBox9.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2GroupBox9.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.Guna2GroupBox9.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2GroupBox9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Guna2GroupBox9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Guna2GroupBox9.Location = new System.Drawing.Point(6, 6);
            this.Guna2GroupBox9.Name = "Guna2GroupBox9";
            this.Guna2GroupBox9.ShadowDecoration.BorderRadius = 9;
            this.Guna2GroupBox9.ShadowDecoration.Color = System.Drawing.Color.White;
            this.Guna2GroupBox9.ShadowDecoration.Depth = 15;
            this.Guna2GroupBox9.Size = new System.Drawing.Size(460, 236);
            this.Guna2GroupBox9.TabIndex = 549;
            // 
            // Guna2HScrollBar1
            // 
            this.Guna2HScrollBar1.AutoRoundedCorners = true;
            this.Guna2HScrollBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2HScrollBar1.BindingContainer = this.DataView;
            this.Guna2HScrollBar1.BorderRadius = 8;
            this.Guna2HScrollBar1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2HScrollBar1.InUpdate = false;
            this.Guna2HScrollBar1.LargeChange = 10;
            this.Guna2HScrollBar1.Location = new System.Drawing.Point(4, 215);
            this.Guna2HScrollBar1.Minimum = 1;
            this.Guna2HScrollBar1.Name = "Guna2HScrollBar1";
            this.Guna2HScrollBar1.ScrollbarSize = 18;
            this.Guna2HScrollBar1.Size = new System.Drawing.Size(453, 18);
            this.Guna2HScrollBar1.TabIndex = 532;
            this.Guna2HScrollBar1.ThumbColor = System.Drawing.Color.FromArgb(0, 85, 207);
            this.Guna2HScrollBar1.ThumbSize = 35F;
            this.Guna2HScrollBar1.ThumbStyle = Guna.UI2.WinForms.Enums.ThumbStyle.Inset;
            this.Guna2HScrollBar1.Value = 1;
            // 
            // DataView
            // 
            this.DataView.AllowUserToAddRows = false;
            this.DataView.AllowUserToDeleteRows = false;
            this.DataView.AllowUserToResizeColumns = false;
            this.DataView.AllowUserToResizeRows = false;
            this.DataView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.DataView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.DataView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewCheckBoxColumn2,
            this.DataGridViewTextBoxColumn6,
            this.DataGridViewTextBoxColumn7,
            this.DataGridViewTextBoxColumn8,
            this.DataGridViewTextBoxColumn9,
            this.DataGridViewTextBoxColumn10,
            this.DataGridViewTextBoxColumn11});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataView.DefaultCellStyle = dataGridViewCellStyle6;
            this.DataView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.DataView.EnableHeadersVisualStyles = false;
            this.DataView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.DataView.Location = new System.Drawing.Point(4, 3);
            this.DataView.MultiSelect = false;
            this.DataView.Name = "DataView";
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataView.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DataView.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.DataView.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.DataView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.DataView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.DataView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.DataView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DataView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataView.Size = new System.Drawing.Size(453, 230);
            this.DataView.TabIndex = 531;
            // 
            // DataGridViewCheckBoxColumn2
            // 
            this.DataGridViewCheckBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DataGridViewCheckBoxColumn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DataGridViewCheckBoxColumn2.Frozen = true;
            this.DataGridViewCheckBoxColumn2.HeaderText = " ";
            this.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2";
            this.DataGridViewCheckBoxColumn2.Width = 19;
            // 
            // DataGridViewTextBoxColumn6
            // 
            this.DataGridViewTextBoxColumn6.FillWeight = 50F;
            this.DataGridViewTextBoxColumn6.HeaderText = "File Name";
            this.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6";
            this.DataGridViewTextBoxColumn6.ReadOnly = true;
            this.DataGridViewTextBoxColumn6.Width = 84;
            // 
            // DataGridViewTextBoxColumn7
            // 
            this.DataGridViewTextBoxColumn7.FillWeight = 70F;
            this.DataGridViewTextBoxColumn7.HeaderText = "Partition";
            this.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7";
            this.DataGridViewTextBoxColumn7.ReadOnly = true;
            this.DataGridViewTextBoxColumn7.Width = 76;
            // 
            // DataGridViewTextBoxColumn8
            // 
            this.DataGridViewTextBoxColumn8.FillWeight = 40F;
            this.DataGridViewTextBoxColumn8.HeaderText = "Sectors";
            this.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8";
            this.DataGridViewTextBoxColumn8.Width = 69;
            // 
            // DataGridViewTextBoxColumn9
            // 
            this.DataGridViewTextBoxColumn9.FillWeight = 40F;
            this.DataGridViewTextBoxColumn9.HeaderText = "Lengths";
            this.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9";
            this.DataGridViewTextBoxColumn9.Visible = false;
            this.DataGridViewTextBoxColumn9.Width = 73;
            // 
            // DataGridViewTextBoxColumn10
            // 
            this.DataGridViewTextBoxColumn10.HeaderText = "File Sizes";
            this.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10";
            this.DataGridViewTextBoxColumn10.Width = 77;
            // 
            // DataGridViewTextBoxColumn11
            // 
            this.DataGridViewTextBoxColumn11.FillWeight = 50F;
            this.DataGridViewTextBoxColumn11.HeaderText = "Locations";
            this.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11";
            this.DataGridViewTextBoxColumn11.ReadOnly = true;
            this.DataGridViewTextBoxColumn11.Width = 82;
            // 
            // Guna2VScrollBar1
            // 
            this.Guna2VScrollBar1.AutoRoundedCorners = true;
            this.Guna2VScrollBar1.AutoScroll = true;
            this.Guna2VScrollBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2VScrollBar1.BindingContainer = this.DataView;
            this.Guna2VScrollBar1.BorderRadius = 8;
            this.Guna2VScrollBar1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2VScrollBar1.HighlightOnWheel = true;
            this.Guna2VScrollBar1.InUpdate = false;
            this.Guna2VScrollBar1.LargeChange = 10;
            this.Guna2VScrollBar1.Location = new System.Drawing.Point(439, 3);
            this.Guna2VScrollBar1.Minimum = 1;
            this.Guna2VScrollBar1.Name = "Guna2VScrollBar1";
            this.Guna2VScrollBar1.ScrollbarSize = 18;
            this.Guna2VScrollBar1.Size = new System.Drawing.Size(18, 230);
            this.Guna2VScrollBar1.TabIndex = 530;
            this.Guna2VScrollBar1.ThumbColor = System.Drawing.Color.FromArgb(0, 85, 207);
            this.Guna2VScrollBar1.ThumbSize = 35F;
            this.Guna2VScrollBar1.ThumbStyle = Guna.UI2.WinForms.Enums.ThumbStyle.Inset;
            this.Guna2VScrollBar1.Value = 1;
            // 
            // txtrawxml
            // 
            this.txtrawxml.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtrawxml.Animated = true;
            this.txtrawxml.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtrawxml.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.txtrawxml.BorderRadius = 5;
            this.txtrawxml.BorderThickness = 2;
            this.txtrawxml.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtrawxml.DefaultText = "";
            this.txtrawxml.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.txtrawxml.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.txtrawxml.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.txtrawxml.DisabledState.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtrawxml.Enabled = false;
            this.txtrawxml.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txtrawxml.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtrawxml.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrawxml.ForeColor = System.Drawing.Color.White;
            this.txtrawxml.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.txtrawxml.Location = new System.Drawing.Point(60, 248);
            this.txtrawxml.Name = "txtrawxml";
            this.txtrawxml.PasswordChar = '\0';
            this.txtrawxml.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtrawxml.PlaceholderText = "Firmware File | .pac";
            this.txtrawxml.SelectedText = "";
            this.txtrawxml.ShadowDecoration.Color = System.Drawing.Color.DimGray;
            this.txtrawxml.ShadowDecoration.Depth = 15;
            this.txtrawxml.Size = new System.Drawing.Size(275, 27);
            this.txtrawxml.TabIndex = 548;
            this.txtrawxml.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SPDR
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(496, 534);
            this.Controls.Add(this.TabControlExt1);
            this.Controls.Add(this.Guna2GroupBox4);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SPDR";
            this.Text = "SPDR";
            this.Guna2GroupBox4.ResumeLayout(false);
            this.Guna2GroupBox5.ResumeLayout(false);
            this.TabControlExt1.ResumeLayout(false);
            this.TabPage3.ResumeLayout(false);
            this.Guna2GroupBox8.ResumeLayout(false);
            this.TabPage4.ResumeLayout(false);
            this.TabPage4.PerformLayout();
            this.Guna2GroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataViewPartition)).EndInit();
            this.TabPage5.ResumeLayout(false);
            this.Guna2GroupBox9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).EndInit();
            this.ResumeLayout(false);

	}

	public SPDR()
	{
		base.Load += SPDR_Load;
		InitializeComponent();
		SharedUI = this;
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
		FIREHOSE_MANAGER.StringXml = "";
		SAHARA_MANAGER.IsAutoLoader = false;
		SerialCOM.MSL = null;
		if (Operators.CompareString(cancel, "Cancel", TextCompare: false) == 0)
		{
			cancel = "";
		}
		device_info.Android = "......";
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
		Form1.SharedUI.RichTextBox1.Clear();
		ProgressChanged = Conversions.ToString(0);
		ProgressChanged = "0";
		WorkerDownload.totalchecked2 = 0;
		WorkerDownload.totaldo = 0;
		Form1.SharedUI.ProgressBar1.Text = "100%";
		Form1.SharedUI.ProgressBar4.Maximum = 100;
		Form1.SharedUI.ProgressBar4.Value = 0;
		Form1.SharedUI.ProgressBar4.Text = "0%";
		Form1.SharedUI.Guna2TaskBarProgress1.Value = 0;
		Form1.SharedUI.Guna2TaskBarProgress1.State = Guna2TaskBarProgress.TaskbarStates.Indeterminate;
		Form1.SharedUI.ProgressBar1.Roll = true;
		Form1.SharedUI.MaterialCard3.Enabled = false;
		Form1.SharedUI.MaterialButton8.Enabled = true;
	}

	public void finshfile()
	{
		if (Operators.CompareString(UiManager.Hh, "ok", TextCompare: false) == 0)
		{
			SerialCOM.MSL = "";
			Form1.SharedUI.MaterialButton8.Enabled = false;
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText("> Finish Operation Failed, Try Agine");
			Form1.SharedUI.ProgressBar1.Text = "Finish Server Data..";
			Form1.SharedUI.ProgressBar4.Visible = false;
			Form1.SharedUI.ProgressBar4.Value = 0;
			Form1.SharedUI.ProgressBar1.Text = "100%";
			Form1.SharedUI.Guna2TaskBarProgress1.State = Guna2TaskBarProgress.TaskbarStates.Error;
			Form1.SharedUI.Guna2TaskBarProgress1.Value = 0;
			Form1.SharedUI.ProgressBar1.Roll = false;
			Form1.SharedUI.MaterialCard3.Enabled = true;
			Form1.SharedUI.MaterialCard5.Enabled = true;
			UiManager.ScanTemWav();
		}
	}

	private string GenerateRandomString(int length)
	{
		string text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
		Random random = new Random();
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 1; i <= length; i = checked(i + 1))
		{
			int index = random.Next(0, text.Length);
			stringBuilder.Append(text[index]);
		}
		return stringBuilder.ToString();
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

	public async Task MethodD_45()
	{
		String_24 = await Send_Log.sndlogm(new OperationToolapi
		{
			Userame = SevaClass.Userr,
			token = SevaClass.Token,
			Hwid = SevaClass.IDRegistration,
			androidos = device_info.Android,
			Baseband = device_info.security_patch,
			Brand = device_info.Brand,
			Carrier = "Unknown",
			Credit = Convert.ToDecimal(String_75),
			Imei = "Unknown",
			modle = device_info.model,
			OprationStatus = true,
			OprationTypes = String_35,
			PhoneId = device_info.serialno,
			SN = device_info.serialno,
			LogOpration = Log
		});
	}

	public async Task MethodD_44()
	{
		String_24 = await Send_Log.sndlogm(new OperationToolapi
		{
			Userame = SevaClass.Userr,
			token = SevaClass.Token,
			Hwid = SevaClass.IDRegistration,
			androidos = "Unknown",
			Baseband = "Unknown",
			Brand = "Unknown",
			Carrier = "Unknown",
			Credit = Convert.ToDecimal(String_75),
			Imei = "Unknown",
			modle = device_info.model,
			OprationStatus = true,
			OprationTypes = String_35,
			PhoneId = device_info.serialno,
			SN = device_info.serialno,
			LogOpration = Log
		});
	}

	public void finsh()
	{
		string msg = Conversions.ToString(ShowElapsedTime());
		checked
		{
			try
			{
				SerialCOM.MSL = null;
				Form1.SharedUI.MaterialButton8.Enabled = false;
				Form1.SharedUI.ProgressBar4.Visible = false;
				Form1.SharedUI.ProgressBar4.Value = 0;
				Form1.SharedUI.ProgressBar1.Text = "Finish Server Data..";
				if (Operators.CompareString(String_35, "", TextCompare: false) != 0)
				{
					Log = Form1.SharedUI.RichTextBox1.Text;
					UiManager.Richlogs("- ID Operation : ", Color.Black, isBold: false);
					if (!UiManager.IsOnline())
					{
						int num = Conversions.ToInteger(Form1.SharedUI.Label25.Text);
						num = (int)Math.Round((double)num - Conversions.ToDouble(Form1.String_75));
						Form1.SharedUI.Label25.Text = Conversions.ToString(num);
						int num2 = Conversions.ToInteger(Form1.SharedUI.Temp_Credits.Text);
						num2 = (int)Math.Round((double)num2 + Conversions.ToDouble(Form1.String_75));
						Form1.SharedUI.Temp_Credits.Text = Conversions.ToString(num2);
						lass0.PortShow();
						UiManager.Richlogs("Check The Internet Connection", Color.Red, isBold: true, NextLine: true);
						Form1.SharedUI.ProgressBar1.Roll = false;
						Form1.SharedUI.ProgressBar1.Text = "100%";
						UiManager.Richlogs("- Time Elapsed : ", Color.Black, isBold: false);
						UiManager.Richlogs(msg, Color.FromArgb(21, 87, 255));
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
						Form1.SharedUI.ProgressBar1.Text = "Finish Server Data...";
						if (Operators.CompareString(device_info.Android, "......", TextCompare: false) == 0)
						{
							device_info.model = LIST_SPD.SelectedItem.ToString();
							device_info.serialno = GenerateRandomString(12);
						}
						Task.Run([SpecialName] async () =>
						{
							await MethodD_43();
						}).Wait();
						if (Operators.CompareString(device_info.model, LIST_SPD.SelectedItem.ToString(), TextCompare: false) == 0)
						{
							Task.Run([SpecialName] async () =>
							{
								await MethodD_44();
							}).Wait();
						}
						else
						{
							Task.Run([SpecialName] async () =>
							{
								await MethodD_45();
							}).Wait();
						}
					}
					UiManager.Richlogs(String_24, Color.FromArgb(21, 87, 255), isBold: true, NextLine: true);
					UiManager.Richlogs("- Time Elapsed : ", Color.Black, isBold: false);
					UiManager.Richlogs(msg, Color.FromArgb(21, 87, 255));
					Form1.SharedUI.Guna2TaskBarProgress1.State = Guna2TaskBarProgress.TaskbarStates.Normal;
					Form1.SharedUI.Guna2TaskBarProgress1.Value = 0;
					Form1.SharedUI.Guna2TaskBarProgress1.State = Guna2TaskBarProgress.TaskbarStates.Normal;
					Form1.SharedUI.Guna2TaskBarProgress1.Value = 0;
					Form1.SharedUI.ProgressBar1.Roll = false;
					Form1.SharedUI.ProgressBar1.Text = "100%";
					Form1.SharedUI.MaterialButton8.Enabled = false;
					Form1.SharedUI.MaterialCard3.Enabled = true;
					Form1.SharedUI.MaterialCard5.Enabled = true;
					UiManager.wesreampung_wav();
				}
				else
				{
					UiManager.Richlogs("- Time Elapsed : ", Color.Black, isBold: false);
					UiManager.Richlogs(msg, Color.FromArgb(21, 87, 255));
					Form1.SharedUI.MaterialButton8.Enabled = false;
					Form1.SharedUI.MaterialCard3.Enabled = true;
					Form1.SharedUI.MaterialCard5.Enabled = true;
					Form1.SharedUI.ProgressBar1.Roll = false;
					Form1.SharedUI.ProgressBar1.Text = "100%";
					Form1.SharedUI.Guna2TaskBarProgress1.State = Guna2TaskBarProgress.TaskbarStates.Normal;
					Form1.SharedUI.Guna2TaskBarProgress1.Value = 0;
					Form1.SharedUI.Guna2TaskBarProgress1.State = Guna2TaskBarProgress.TaskbarStates.Normal;
					Form1.SharedUI.Guna2TaskBarProgress1.Value = 0;
					UiManager.wesreampung_wav();
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

	public void finshonly()
	{
		SerialCOM.MSL = "";
		Form1.SharedUI.MaterialButton8.Enabled = false;
		Form1.SharedUI.MaterialCard3.Enabled = true;
		Form1.SharedUI.MaterialCard5.Enabled = true;
		Form1.SharedUI.ProgressBar4.Visible = false;
		Form1.SharedUI.ProgressBar4.Maximum = 100;
		Form1.SharedUI.ProgressBar4.Value = 0;
		Form1.SharedUI.Guna2TaskBarProgress1.State = Guna2TaskBarProgress.TaskbarStates.Normal;
		Form1.SharedUI.Guna2TaskBarProgress1.Value = 0;
		Form1.SharedUI.ProgressBar1.Roll = false;
		Form1.SharedUI.ProgressBar1.Text = "100%";
	}

	public void Get_Modelsand_add()
	{
		LIST_SPD.Items.Clear();
		LIST_SPD.Text = "";
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText("- List CPU From Server : ");
		try
		{
			MyProject.Computer.FileSystem.DeleteDirectory("Tmp\\1", DeleteDirectoryOption.DeleteAllContents);
			File.Delete(ThisLocation + "Tmp\\1.zip");
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		if (!Get_Data_0910909820())
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringF);
			finshonly();
			return;
		}
		String_14 = "1";
		MethodD_100();
		if (!Boolean_2)
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringF);
			finshonly();
			return;
		}
		checked
		{
			try
			{
				string text = ThisLocation + "Tmp\\" + String_14;
				FIREHOSE_MANAGER.gettypehpnya = new ComboBox();
				List<string[]> list = (from line in File.ReadAllLines(Path.Combine(text))
					select line.Split(':')).ToList();
				int num = list.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					LIST_SPD.Items.Add(list[i][0]);
					FIREHOSE_MANAGER.gettypehpnya.Items.Add(list[i][0] + ":" + list[i][1].ToString());
					if (i == 0)
					{
						LIST_SPD.Text = Convert.ToString(list[0][0]);
					}
				}
				File.Delete(ThisLocation + "Tmp\\" + String_14);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringO);
				finshonly();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
				Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringF);
				finshonly();
				ProjectData.ClearProjectError();
			}
		}
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
			FirebaseResponse obj = Form1.String_107.Get(ClassDevronix.LF + "RDSP");
			new Form1.IClass1();
			Form1.IClass1 @class = obj.ResultAs<Form1.IClass1>();
			Form1.String_19 = @class.Password;
			string link = @class.Link;
			string token = @class.Token;
			Form1.String_19 = encr.Decrypt(Form1.String_19, Form1.SharedUI.textpss.Text);
			token = encr.Decrypt(token, Form1.String_19);
			link = encr.Decrypt(link, token);
			String_12 = link;
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

	private void MethodD_100()
	{
		try
		{
			string text = ThisLocation + "Tmp\\" + String_14;
			try
			{
				File.Delete(text);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			using WebClient webClient = new WebClient();
			webClient.DownloadProgressChanged += MethodD_98;
			webClient.DownloadFileCompleted += MethodD_99;
			webClient.DownloadFileAsync(new Uri(String_12), text);
			while (webClient.IsBusy)
			{
				Application.DoEvents();
			}
			if (File.Exists(text))
			{
				Boolean_2 = true;
			}
			else
			{
				Boolean_2 = false;
			}
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
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
	}

	private void LIST_SPD_SelectedIndexChanged(object sender, EventArgs e)
	{
		string right = LIST_SPD.Text;
		checked
		{
			int num = FIREHOSE_MANAGER.gettypehpnya.Items.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(FIREHOSE_MANAGER.gettypehpnya.Items[i]), null, "Split", new object[1] { ':' }, null, null, null)));
				if (Operators.ConditionalCompareObjectEqual(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(RuntimeHelpers.GetObjectValue(objectValue), new object[1] { 0 }, null)), right, TextCompare: false))
				{
					FIREHOSE_MANAGER.typeterpilih = Conversions.ToString(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(RuntimeHelpers.GetObjectValue(objectValue), new object[1] { 1 }, null)));
					Link_Payload = "https://firebasestorage.googleapis.com/v0/b/motounlock-7d7d0.appspot.com/o/Payload_SPRD%" + FIREHOSE_MANAGER.typeterpilih;
				}
			}
		}
	}

	private void Guna2Button19_Click(object sender, EventArgs e)
	{
		start();
		ThreadNew = new Thread(remove_frp);
		ThreadNew.Start();
	}

	public void remove_frp()
	{
		if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0 && Conversions.ToDouble(Form1.SharedUI.Label25.Text) == 0.0)
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.YDNHBPR);
			finshonly();
			return;
		}
		String_35 = "Remove FRP Lock [SPD]";
		if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
		{
			String_75 = Conversions.ToString(1);
			UiManager.Richlogs(ClassDevronix.UAWC, Color.Black, isBold: false);
			Form1.SharedUI.ProgressBar1.Text = "Waiting..";
			Form1.SharedUI.Guna2MessageDialog3.Text = ClassDevronix.TPWCY + String_75 + " Credits Do You Want To Continue";
			UiManager.wronganswer();
			if (Form1.SharedUI.Guna2MessageDialog3.Show() != DialogResult.OK)
			{
				UiManager.Richlogs(ClassDevronix.CBU, Color.Red);
				finshonly();
				return;
			}
			UiManager.Richlogs(ClassDevronix.StringO, Color.FromArgb(21, 87, 255), isBold: true, NextLine: true);
		}
		else
		{
			String_75 = Conversions.ToString(0);
		}
		Type_Operation = "Remove_Frp";
		if (WorkerDownload.remove_frp())
		{
			if (Form1.SharedUI.RichTextBox1.Text.Contains("Reboot Device"))
			{
				UiManager.Richlogs("OK", Color.FromArgb(0, 85, 207), isBold: true, NextLine: true);
				finsh();
			}
			else
			{
				finshfile();
			}
		}
		else
		{
			finshfile();
		}
	}

	public void remove_data()
	{
		if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0 && Conversions.ToDouble(Form1.SharedUI.Label25.Text) == 0.0)
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.YDNHBPR);
			finshonly();
			return;
		}
		String_35 = "Factory Reset [SPD]";
		if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
		{
			String_75 = Conversions.ToString(1);
			UiManager.Richlogs(ClassDevronix.UAWC, Color.Black, isBold: false);
			Form1.SharedUI.ProgressBar1.Text = "Waiting..";
			Form1.SharedUI.Guna2MessageDialog3.Text = ClassDevronix.TPWCY + String_75 + " Credits Do You Want To Continue";
			UiManager.wronganswer();
			if (Form1.SharedUI.Guna2MessageDialog3.Show() != DialogResult.OK)
			{
				UiManager.Richlogs(ClassDevronix.CBU, Color.Red);
				finshonly();
				return;
			}
			UiManager.Richlogs(ClassDevronix.StringO, Color.FromArgb(21, 87, 255), isBold: true, NextLine: true);
		}
		else
		{
			String_75 = Conversions.ToString(0);
		}
		Type_Operation = "Remove Frp_Userdata";
		if (WorkerDownload.remove_Userdata())
		{
			if (Form1.SharedUI.RichTextBox1.Text.Contains("Reboot Device"))
			{
				UiManager.Richlogs("OK", Color.FromArgb(0, 85, 207), isBold: true, NextLine: true);
				UiManager.Richlogs("- Note : ", Color.White, isBold: false);
				UiManager.Richlogs("If Not Rebooting Please Reboot Manual", Color.FromArgb(0, 85, 207), isBold: true, NextLine: true);
				finsh();
			}
			else
			{
				finshfile();
			}
		}
		else
		{
			finshfile();
		}
	}

	public void remove_data_misc()
	{
		if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0 && Conversions.ToDouble(Form1.SharedUI.Label25.Text) == 0.0)
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.YDNHBPR);
			finshonly();
			return;
		}
		String_35 = "Factory Reset [SPD]";
		if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
		{
			String_75 = Conversions.ToString(1);
			UiManager.Richlogs(ClassDevronix.UAWC, Color.Black, isBold: false);
			Form1.SharedUI.ProgressBar1.Text = "Waiting..";
			Form1.SharedUI.Guna2MessageDialog3.Text = ClassDevronix.TPWCY + String_75 + " Credits Do You Want To Continue";
			UiManager.wronganswer();
			if (Form1.SharedUI.Guna2MessageDialog3.Show() != DialogResult.OK)
			{
				UiManager.Richlogs(ClassDevronix.CBU, Color.Red);
				finshonly();
				return;
			}
			UiManager.Richlogs(ClassDevronix.StringO, Color.FromArgb(21, 87, 255), isBold: true, NextLine: true);
		}
		else
		{
			String_75 = Conversions.ToString(0);
		}
		Type_Operation = "Factory_Reset_Data";
		if (WorkerDownload.Factory_Reset_Data())
		{
			if (Form1.SharedUI.RichTextBox1.Text.Contains("Reboot Device"))
			{
				UiManager.Richlogs("OK", Color.FromArgb(0, 85, 207), isBold: true, NextLine: true);
				finsh();
			}
			else
			{
				finshfile();
			}
		}
		else
		{
			finshfile();
		}
	}

	private void Guna2Button20_Click(object sender, EventArgs e)
	{
		OpenFileDialog openFileDialog = new OpenFileDialog
		{
			Title = "Select PAC Firmware",
			InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer),
			FileName = "*.*",
			Filter = "PAC Firmware |*.pac* ",
			FilterIndex = 2,
			RestoreDirectory = true
		};
		if (openFileDialog.ShowDialog() == DialogResult.OK)
		{
			DataView.Rows.Clear();
			Form1.SharedUI.RichTextBox1.Clear();
			UiManager.ProcessBar1(0);
			TxtPacFirmware = openFileDialog.SafeFileName;
			WorkerDownload.UniFirmware = openFileDialog.FileName;
			String_13 = "debug";
			if (!Directory.Exists(Path.GetDirectoryName(WorkerDownload.UniFirmware) + "\\ImageFiles"))
			{
				Directory.CreateDirectory(Path.GetDirectoryName(WorkerDownload.UniFirmware) + "\\ImageFiles");
			}
			PACExtractor.StartExtraction(new string[3]
			{
				WorkerDownload.UniFirmware,
				Path.GetDirectoryName(WorkerDownload.UniFirmware) + "\\ImageFiles",
				"-debug"
			});
		}
	}

	private void SPDR_Load(object sender, EventArgs e)
	{
		start();
		ThreadNew = new Thread(Get_Modelsand_add);
		ThreadNew.Start();
	}

	private void Timer2_Tick(object sender, EventArgs e)
	{
		if (Operators.CompareString(SevaClass.canaclstring, "Can", TextCompare: false) == 0)
		{
			SevaClass.canaclstring = "";
			cancel = "Cancel";
			SerialCOM.MSL = "Cen";
			try
			{
				ThreadNew.Abort();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			uni.ProcessKill();
			uni.CleanerTmp();
			uni.Cleaner();
		}
	}

	private void Guna2Button10_Click(object sender, EventArgs e)
	{
		if (ComboBox_Factory.SelectedIndex == 0)
		{
			start();
			ThreadNew = new Thread(remove_data_misc);
			ThreadNew.Start();
		}
		else
		{
			start();
			ThreadNew = new Thread(remove_data);
			ThreadNew.Start();
		}
	}

	private void Guna2Button8_Click(object sender, EventArgs e)
	{
		start();
		ThreadNew = new Thread(remove_data_misc);
		ThreadNew.Start();
	}
}
