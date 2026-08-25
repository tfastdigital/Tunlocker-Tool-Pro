using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;
using Microsoft.VisualBasic.CompilerServices;
using motoulocked.HuaweiUnlocker.DIAGNOS;
using motoulocked.HuaweiUnlocker.TOOLS;
using Properties;

namespace motoulocked;

[DesignerGenerated]
public class kirin : Form
{
	private struct RECT
	{
		public int Left;

		public int Top;

		public int Right;

		public int Bottom;
	}




    /*
	internal  Button Button1
	{
		[CompilerGenerated]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button1_Click;
			Button button = _Button1;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button1 = value;
			button = _Button1;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Guna2TabControl1")]
	internal  Guna2TabControl Guna2TabControl1
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

	[field: AccessedThroughProperty("TabPage2")]
	internal  TabPage TabPage2
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

	[field: AccessedThroughProperty("Guna2GroupBox2")]
	internal  Guna2GroupBox Guna2GroupBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal  Guna2RadioButton Guna2RadioButton11
	{
		[CompilerGenerated]
		get
		{
			return _Guna2RadioButton11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Guna2RadioButton11_CheckedChanged;
			Guna2RadioButton guna2RadioButton = _Guna2RadioButton11;
			if (guna2RadioButton != null)
			{
				guna2RadioButton.CheckedChanged -= value2;
			}
			_Guna2RadioButton11 = value;
			guna2RadioButton = _Guna2RadioButton11;
			if (guna2RadioButton != null)
			{
				guna2RadioButton.CheckedChanged += value2;
			}
		}
	}

	internal  Guna2RadioButton Guna2RadioButton4
	{
		[CompilerGenerated]
		get
		{
			return _Guna2RadioButton4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Guna2RadioButton4_CheckedChanged;
			Guna2RadioButton guna2RadioButton = _Guna2RadioButton4;
			if (guna2RadioButton != null)
			{
				guna2RadioButton.CheckedChanged -= value2;
			}
			_Guna2RadioButton4 = value;
			guna2RadioButton = _Guna2RadioButton4;
			if (guna2RadioButton != null)
			{
				guna2RadioButton.CheckedChanged += value2;
			}
		}
	}

	internal  Guna2ComboBox Brand
	{
		[CompilerGenerated]
		get
		{
			return _Brand;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Brand_SelectedIndexChanged;
			Guna2ComboBox brand = _Brand;
			if (brand != null)
			{
				brand.SelectedIndexChanged -= value2;
			}
			_Brand = value;
			brand = _Brand;
			if (brand != null)
			{
				brand.SelectedIndexChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel_SPD")]
	internal  Guna2GroupBox Panel_SPD
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

	[field: AccessedThroughProperty("Guna2Button4")]
	internal  Guna2Button Guna2Button4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Guna2ComboBox2")]
	internal  Guna2ComboBox Guna2ComboBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Guna2Button3")]
	internal  Guna2Button Guna2Button3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Guna2ComboBox1")]
	internal  Guna2ComboBox Guna2ComboBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Guna2Button2")]
	internal  Guna2Button Guna2Button2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ComboBoxSecurity")]
	internal  Guna2ComboBox ComboBoxSecurity
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

	internal  Guna2ComboBox ComboBoxBoot
	{
		[CompilerGenerated]
		get
		{
			return _ComboBoxBoot;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ComboBoxBoot_SelectedIndexChanged;
			Guna2ComboBox comboBoxBoot = _ComboBoxBoot;
			if (comboBoxBoot != null)
			{
				comboBoxBoot.SelectedIndexChanged -= value2;
			}
			_ComboBoxBoot = value;
			comboBoxBoot = _ComboBoxBoot;
			if (comboBoxBoot != null)
			{
				comboBoxBoot.SelectedIndexChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Model")]
	internal  Guna2GroupBox Model
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

	[field: AccessedThroughProperty("LIST_SPD")]
	internal  ListBox LIST_SPD
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel_Kirin")]
	internal  Guna2GroupBox Panel_Kirin
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

	[field: AccessedThroughProperty("Guna2TabControl2")]
	internal  Guna2TabControl Guna2TabControl2
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

	[field: AccessedThroughProperty("Guna2Button6")]
	internal  Guna2Button Guna2Button6
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

	[field: AccessedThroughProperty("Guna2Button10")]
	internal  Guna2Button Guna2Button10
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

	[field: AccessedThroughProperty("Guna2GroupBox7")]
	internal  Guna2GroupBox Guna2GroupBox7
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

	[field: AccessedThroughProperty("LIST_KIRIN")]
	internal  ListBox LIST_KIRIN
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal  Guna2RadioButton Guna2RadioButton1
	{
		[CompilerGenerated]
		get
		{
			return _Guna2RadioButton1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Guna2RadioButton1_CheckedChanged;
			Guna2RadioButton guna2RadioButton = _Guna2RadioButton1;
			if (guna2RadioButton != null)
			{
				guna2RadioButton.CheckedChanged -= value2;
			}
			_Guna2RadioButton1 = value;
			guna2RadioButton = _Guna2RadioButton1;
			if (guna2RadioButton != null)
			{
				guna2RadioButton.CheckedChanged += value2;
			}
		}
	}

	internal  Guna2RadioButton Guna2RadioButton2
	{
		[CompilerGenerated]
		get
		{
			return _Guna2RadioButton2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Guna2RadioButton2_CheckedChanged;
			Guna2RadioButton guna2RadioButton = _Guna2RadioButton2;
			if (guna2RadioButton != null)
			{
				guna2RadioButton.CheckedChanged -= value2;
			}
			_Guna2RadioButton2 = value;
			guna2RadioButton = _Guna2RadioButton2;
			if (guna2RadioButton != null)
			{
				guna2RadioButton.CheckedChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Guna2TextBox2")]
	internal  Guna2TextBox Guna2TextBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Guna2Button8")]
	internal  Guna2Button Guna2Button8
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

	[field: AccessedThroughProperty("Guna2VScrollBar3")]
	internal  Guna2VScrollBar Guna2VScrollBar3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataViewmtk")]
	internal  DataGridView DataViewmtk
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

	[field: AccessedThroughProperty("cblistdataview")]
	internal  CheckBox cblistdataview
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Guna2Button15")]
	internal  Guna2Button Guna2Button15
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Guna2Button9")]
	internal  Guna2Button Guna2Button9
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

	[field: AccessedThroughProperty("Guna2Button11")]
	internal  Guna2Button Guna2Button11
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

	[field: AccessedThroughProperty("Guna2VScrollBar4")]
	internal  Guna2VScrollBar Guna2VScrollBar4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridView1")]
	internal  DataGridView DataGridView1
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

	[field: AccessedThroughProperty("CheckBox1")]
	internal  CheckBox CheckBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Guna2Button12")]
	internal  Guna2Button Guna2Button12
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}
	*/
    private IContainer components;
    internal Button Button1;
    internal Guna2TabControl Guna2TabControl1;
    internal TabPage TabPage1;
    internal TabPage TabPage2;
    internal Guna2Button Guna2Button1;
    internal Guna2GroupBox Guna2GroupBox2;
    internal Guna2RadioButton Guna2RadioButton11;
    internal Guna2RadioButton Guna2RadioButton4;
    internal Guna2ComboBox Brand;
    internal Guna2GroupBox Panel_SPD;
    internal Guna2Button Guna2Button5;
    internal Guna2Button Guna2Button4;
    internal Guna2ComboBox Guna2ComboBox2;
    internal Guna2Button Guna2Button3;
    internal Guna2ComboBox Guna2ComboBox1;
    internal Guna2Button Guna2Button2;
    internal Guna2ComboBox ComboBoxSecurity;
    internal Guna2GroupBox Guna2GroupBox3;
    internal Guna2TextBox Guna2TextBox1;
    internal Guna2TextBox txtloader;
    internal Guna2ComboBox ComboBoxBoot;
    internal Guna2GroupBox Model;
    internal Guna2VScrollBar Guna2VScrollBar2;
    internal ListBox LIST_SPD;
    internal Guna2GroupBox Panel_Kirin;
    internal Guna2GroupBox Guna2GroupBox5;
    internal Guna2TabControl Guna2TabControl2;
    internal TabPage TabPage3;
    internal TabPage TabPage4;
    internal Guna2Button Guna2Button6;
    internal Guna2Button Guna2Button7;
    internal Guna2Button Guna2Button10;
    internal Guna2GroupBox Guna2GroupBox6;
    internal Guna2GroupBox Guna2GroupBox7;
    internal Guna2VScrollBar Guna2VScrollBar1;
    internal ListBox LIST_KIRIN;
    internal Guna2RadioButton Guna2RadioButton1;
    internal Guna2RadioButton Guna2RadioButton2;
    internal Guna2TextBox Guna2TextBox2;
    internal Guna2Button Guna2Button8;
    internal Guna2GroupBox Guna2GroupBox1;
    internal Guna2VScrollBar Guna2VScrollBar3;
    internal DataGridView DataViewmtk;
    internal DataGridViewCheckBoxColumn Column0;
    internal DataGridViewTextBoxColumn Column3;
    internal DataGridViewTextBoxColumn part;
    internal DataGridViewTextBoxColumn Column1;
    internal DataGridViewTextBoxColumn Column2;
    internal DataGridViewTextBoxColumn Column5;
    internal DataGridViewTextBoxColumn Column4;
    internal DataGridViewTextBoxColumn Column6;
    internal CheckBox cblistdataview;
    internal Guna2Button Guna2Button15;
    internal Guna2Button Guna2Button9;
    internal Guna2TextBox Guna2TextBox3;
    internal Guna2Button Guna2Button11;
    internal Guna2GroupBox Guna2GroupBox4;
    internal Guna2VScrollBar Guna2VScrollBar4;
    internal DataGridView DataGridView1;
    internal DataGridViewCheckBoxColumn DataGridViewCheckBoxColumn1;
    internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
    internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn2;
    internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn3;
    internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn4;
    internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn5;
    internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn6;
    internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn7;
    internal CheckBox CheckBox1;
    internal Guna2Button Guna2Button12;

    public kirin()
	{
		base.Load += kirin_Load;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kirin));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle65 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle70 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle71 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle72 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle66 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle67 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle68 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle69 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle73 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle78 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle79 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle80 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle74 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle75 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle76 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle77 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Button1 = new System.Windows.Forms.Button();
            this.Guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.Guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtloader = new Guna.UI2.WinForms.Guna2TextBox();
            this.Guna2ComboBox2 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ComboBoxSecurity = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.Guna2Button15 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.Guna2Button8 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.Guna2VScrollBar3 = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.DataViewmtk = new System.Windows.Forms.DataGridView();
            this.Column0 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.part = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cblistdataview = new System.Windows.Forms.CheckBox();
            this.Guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.Model = new Guna.UI2.WinForms.Guna2GroupBox();
            this.Guna2VScrollBar2 = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.LIST_SPD = new System.Windows.Forms.ListBox();
            this.Guna2RadioButton11 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.Guna2RadioButton4 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.Brand = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Panel_SPD = new Guna.UI2.WinForms.Guna2GroupBox();
            this.Guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.ComboBoxBoot = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Panel_Kirin = new Guna.UI2.WinForms.Guna2GroupBox();
            this.Guna2GroupBox5 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.Guna2TabControl2 = new Guna.UI2.WinForms.Guna2TabControl();
            this.TabPage4 = new System.Windows.Forms.TabPage();
            this.Guna2Button12 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2Button7 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2Button10 = new Guna.UI2.WinForms.Guna2Button();
            this.TabPage3 = new System.Windows.Forms.TabPage();
            this.Guna2Button9 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2TextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.Guna2Button11 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2GroupBox4 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.Guna2VScrollBar4 = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.DataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            this.Guna2GroupBox6 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.Guna2GroupBox7 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.Guna2VScrollBar1 = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.LIST_KIRIN = new System.Windows.Forms.ListBox();
            this.Guna2RadioButton1 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.Guna2RadioButton2 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.Guna2TabControl1.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.Guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataViewmtk)).BeginInit();
            this.Guna2GroupBox2.SuspendLayout();
            this.Model.SuspendLayout();
            this.Panel_SPD.SuspendLayout();
            this.Guna2GroupBox3.SuspendLayout();
            this.Panel_Kirin.SuspendLayout();
            this.Guna2GroupBox5.SuspendLayout();
            this.Guna2TabControl2.SuspendLayout();
            this.TabPage4.SuspendLayout();
            this.TabPage3.SuspendLayout();
            this.Guna2GroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.Guna2GroupBox6.SuspendLayout();
            this.Guna2GroupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(292, 544);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 23);
            this.Button1.TabIndex = 1;
            this.Button1.Text = "Button1";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Visible = false;
            // 
            // Guna2TabControl1
            // 
            this.Guna2TabControl1.Controls.Add(this.TabPage2);
            this.Guna2TabControl1.Controls.Add(this.TabPage1);
            this.Guna2TabControl1.ItemSize = new System.Drawing.Size(80, 25);
            this.Guna2TabControl1.Location = new System.Drawing.Point(3, 5);
            this.Guna2TabControl1.Name = "Guna2TabControl1";
            this.Guna2TabControl1.SelectedIndex = 0;
            this.Guna2TabControl1.Size = new System.Drawing.Size(465, 301);
            this.Guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Guna2TabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.Guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.Guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(0, 85, 207);
            this.Guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.Guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2TabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.Guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.Guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.Guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.Guna2TabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.Guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.Guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.Guna2TabControl1.TabButtonSize = new System.Drawing.Size(80, 25);
            this.Guna2TabControl1.TabIndex = 2;
            this.Guna2TabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2TabControl1.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // TabPage2
            // 
            this.TabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TabPage2.Controls.Add(this.Guna2TextBox1);
            this.TabPage2.Controls.Add(this.txtloader);
            this.TabPage2.Controls.Add(this.Guna2ComboBox2);
            this.TabPage2.Controls.Add(this.Guna2ComboBox1);
            this.TabPage2.Controls.Add(this.ComboBoxSecurity);
            this.TabPage2.Controls.Add(this.Guna2Button5);
            this.TabPage2.Controls.Add(this.Guna2Button4);
            this.TabPage2.Controls.Add(this.Guna2Button3);
            this.TabPage2.Controls.Add(this.Guna2Button1);
            this.TabPage2.Controls.Add(this.Guna2Button2);
            this.TabPage2.Location = new System.Drawing.Point(4, 29);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(457, 268);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "Services";
            // 
            // Guna2TextBox1
            // 
            this.Guna2TextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Guna2TextBox1.Animated = true;
            this.Guna2TextBox1.BackColor = System.Drawing.Color.Transparent;
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
            this.Guna2TextBox1.Location = new System.Drawing.Point(10, 194);
            this.Guna2TextBox1.Name = "Guna2TextBox1";
            this.Guna2TextBox1.PasswordChar = '\0';
            this.Guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.Guna2TextBox1.PlaceholderText = "IMEI 2";
            this.Guna2TextBox1.SelectedText = "";
            this.Guna2TextBox1.ShadowDecoration.Color = System.Drawing.Color.DimGray;
            this.Guna2TextBox1.ShadowDecoration.Depth = 15;
            this.Guna2TextBox1.Size = new System.Drawing.Size(436, 26);
            this.Guna2TextBox1.TabIndex = 526;
            this.Guna2TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtloader
            // 
            this.txtloader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtloader.Animated = true;
            this.txtloader.BackColor = System.Drawing.Color.Transparent;
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
            this.txtloader.Location = new System.Drawing.Point(10, 162);
            this.txtloader.Name = "txtloader";
            this.txtloader.PasswordChar = '\0';
            this.txtloader.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtloader.PlaceholderText = "IMEI 1";
            this.txtloader.SelectedText = "";
            this.txtloader.ShadowDecoration.Color = System.Drawing.Color.DimGray;
            this.txtloader.ShadowDecoration.Depth = 15;
            this.txtloader.Size = new System.Drawing.Size(436, 26);
            this.txtloader.TabIndex = 525;
            this.txtloader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Guna2ComboBox2
            // 
            this.Guna2ComboBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Guna2ComboBox2.BackColor = System.Drawing.Color.Transparent;
            this.Guna2ComboBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2ComboBox2.BorderRadius = 4;
            this.Guna2ComboBox2.BorderThickness = 2;
            this.Guna2ComboBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Guna2ComboBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2ComboBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2ComboBox2.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.Guna2ComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Guna2ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Guna2ComboBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2ComboBox2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Guna2ComboBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Guna2ComboBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Guna2ComboBox2.ForeColor = System.Drawing.Color.White;
            this.Guna2ComboBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2ComboBox2.ItemHeight = 26;
            this.Guna2ComboBox2.Items.AddRange(new object[] {
            "Remove FRP",
            "Wiep Data"});
            this.Guna2ComboBox2.ItemsAppearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2ComboBox2.ItemsAppearance.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2ComboBox2.ItemsAppearance.ForeColor = System.Drawing.Color.White;
            this.Guna2ComboBox2.ItemsAppearance.SelectedBackColor = System.Drawing.Color.Gray;
            this.Guna2ComboBox2.ItemsAppearance.SelectedForeColor = System.Drawing.Color.White;
            this.Guna2ComboBox2.Location = new System.Drawing.Point(236, 48);
            this.Guna2ComboBox2.MaxDropDownItems = 5;
            this.Guna2ComboBox2.MaxLength = 5;
            this.Guna2ComboBox2.Name = "Guna2ComboBox2";
            this.Guna2ComboBox2.Size = new System.Drawing.Size(210, 32);
            this.Guna2ComboBox2.StartIndex = 0;
            this.Guna2ComboBox2.TabIndex = 523;
            // 
            // Guna2ComboBox1
            // 
            this.Guna2ComboBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.Guna2ComboBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2ComboBox1.BorderRadius = 4;
            this.Guna2ComboBox1.BorderThickness = 2;
            this.Guna2ComboBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Guna2ComboBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2ComboBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2ComboBox1.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.Guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Guna2ComboBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Guna2ComboBox1.ForeColor = System.Drawing.Color.White;
            this.Guna2ComboBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2ComboBox1.ItemHeight = 26;
            this.Guna2ComboBox1.Items.AddRange(new object[] {
            "Read RPMB",
            "Write RPMB"});
            this.Guna2ComboBox1.ItemsAppearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2ComboBox1.ItemsAppearance.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2ComboBox1.ItemsAppearance.ForeColor = System.Drawing.Color.White;
            this.Guna2ComboBox1.ItemsAppearance.SelectedBackColor = System.Drawing.Color.Gray;
            this.Guna2ComboBox1.ItemsAppearance.SelectedForeColor = System.Drawing.Color.White;
            this.Guna2ComboBox1.Location = new System.Drawing.Point(236, 86);
            this.Guna2ComboBox1.MaxDropDownItems = 5;
            this.Guna2ComboBox1.MaxLength = 5;
            this.Guna2ComboBox1.Name = "Guna2ComboBox1";
            this.Guna2ComboBox1.Size = new System.Drawing.Size(210, 32);
            this.Guna2ComboBox1.StartIndex = 0;
            this.Guna2ComboBox1.TabIndex = 521;
            // 
            // ComboBoxSecurity
            // 
            this.ComboBoxSecurity.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ComboBoxSecurity.BackColor = System.Drawing.Color.Transparent;
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
            "Unlock Bootloader",
            "Relock Bootloader"});
            this.ComboBoxSecurity.ItemsAppearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.ComboBoxSecurity.ItemsAppearance.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxSecurity.ItemsAppearance.ForeColor = System.Drawing.Color.White;
            this.ComboBoxSecurity.ItemsAppearance.SelectedBackColor = System.Drawing.Color.Gray;
            this.ComboBoxSecurity.ItemsAppearance.SelectedForeColor = System.Drawing.Color.White;
            this.ComboBoxSecurity.Location = new System.Drawing.Point(236, 124);
            this.ComboBoxSecurity.MaxDropDownItems = 5;
            this.ComboBoxSecurity.MaxLength = 5;
            this.ComboBoxSecurity.Name = "ComboBoxSecurity";
            this.ComboBoxSecurity.Size = new System.Drawing.Size(210, 32);
            this.ComboBoxSecurity.StartIndex = 0;
            this.ComboBoxSecurity.TabIndex = 519;
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
            this.Guna2Button5.Location = new System.Drawing.Point(10, 226);
            this.Guna2Button5.Name = "Guna2Button5";
            this.Guna2Button5.PressedColor = System.Drawing.Color.Empty;
            this.Guna2Button5.Size = new System.Drawing.Size(436, 32);
            this.Guna2Button5.TabIndex = 524;
            this.Guna2Button5.Text = "Write IMEI";
            this.Guna2Button5.TextFormatNoPrefix = true;
            // 
            // Guna2Button4
            // 
            this.Guna2Button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Guna2Button4.Animated = true;
            this.Guna2Button4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2Button4.BorderRadius = 4;
            this.Guna2Button4.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.Guna2Button4.BorderThickness = 2;
            this.Guna2Button4.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button4.CheckedState.FillColor = System.Drawing.Color.LightGray;
            this.Guna2Button4.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
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
            this.Guna2Button4.Image = global::Properties.Resources.video;
            this.Guna2Button4.Location = new System.Drawing.Point(10, 48);
            this.Guna2Button4.Name = "Guna2Button4";
            this.Guna2Button4.PressedColor = System.Drawing.Color.Empty;
            this.Guna2Button4.Size = new System.Drawing.Size(220, 32);
            this.Guna2Button4.TabIndex = 522;
            this.Guna2Button4.Text = " Start ==>";
            this.Guna2Button4.TextFormatNoPrefix = true;
            // 
            // Guna2Button3
            // 
            this.Guna2Button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Guna2Button3.Animated = true;
            this.Guna2Button3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2Button3.BorderRadius = 4;
            this.Guna2Button3.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.Guna2Button3.BorderThickness = 2;
            this.Guna2Button3.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button3.CheckedState.FillColor = System.Drawing.Color.LightGray;
            this.Guna2Button3.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.Guna2Button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guna2Button3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
            this.Guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button3.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.Guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2Button3.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2Button3.ForeColor = System.Drawing.Color.White;
            this.Guna2Button3.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button3.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button3.Image = global::Properties.Resources.video;
            this.Guna2Button3.Location = new System.Drawing.Point(10, 86);
            this.Guna2Button3.Name = "Guna2Button3";
            this.Guna2Button3.PressedColor = System.Drawing.Color.Empty;
            this.Guna2Button3.Size = new System.Drawing.Size(220, 32);
            this.Guna2Button3.TabIndex = 520;
            this.Guna2Button3.Text = " Start ==>";
            this.Guna2Button3.TextFormatNoPrefix = true;
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
            this.Guna2Button1.Location = new System.Drawing.Point(10, 10);
            this.Guna2Button1.Name = "Guna2Button1";
            this.Guna2Button1.PressedColor = System.Drawing.Color.Empty;
            this.Guna2Button1.Size = new System.Drawing.Size(436, 32);
            this.Guna2Button1.TabIndex = 492;
            this.Guna2Button1.Text = "Unlock Network";
            this.Guna2Button1.TextFormatNoPrefix = true;
            // 
            // Guna2Button2
            // 
            this.Guna2Button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Guna2Button2.Animated = true;
            this.Guna2Button2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2Button2.BorderRadius = 4;
            this.Guna2Button2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.Guna2Button2.BorderThickness = 2;
            this.Guna2Button2.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button2.CheckedState.FillColor = System.Drawing.Color.LightGray;
            this.Guna2Button2.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
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
            this.Guna2Button2.Location = new System.Drawing.Point(10, 124);
            this.Guna2Button2.Name = "Guna2Button2";
            this.Guna2Button2.PressedColor = System.Drawing.Color.Empty;
            this.Guna2Button2.Size = new System.Drawing.Size(220, 32);
            this.Guna2Button2.TabIndex = 518;
            this.Guna2Button2.Text = " Start ==>";
            this.Guna2Button2.TextFormatNoPrefix = true;
            // 
            // TabPage1
            // 
            this.TabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TabPage1.Controls.Add(this.Guna2Button15);
            this.TabPage1.Controls.Add(this.Guna2TextBox2);
            this.TabPage1.Controls.Add(this.Guna2Button8);
            this.TabPage1.Controls.Add(this.Guna2GroupBox1);
            this.TabPage1.Location = new System.Drawing.Point(4, 29);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(457, 268);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Flasher";
            // 
            // Guna2Button15
            // 
            this.Guna2Button15.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Guna2Button15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2Button15.BorderRadius = 4;
            this.Guna2Button15.BorderThickness = 2;
            this.Guna2Button15.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button15.CheckedState.FillColor = System.Drawing.Color.LightGray;
            this.Guna2Button15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guna2Button15.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button15.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
            this.Guna2Button15.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button15.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.Guna2Button15.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2Button15.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2Button15.ForeColor = System.Drawing.Color.White;
            this.Guna2Button15.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button15.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button15.Image = global::Properties.Resources.search_in_folder;
            this.Guna2Button15.ImageSize = new System.Drawing.Size(25, 25);
            this.Guna2Button15.Location = new System.Drawing.Point(7, 235);
            this.Guna2Button15.Name = "Guna2Button15";
            this.Guna2Button15.PressedColor = System.Drawing.Color.Empty;
            this.Guna2Button15.Size = new System.Drawing.Size(45, 26);
            this.Guna2Button15.TabIndex = 529;
            this.Guna2Button15.TextFormatNoPrefix = true;
            // 
            // Guna2TextBox2
            // 
            this.Guna2TextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Guna2TextBox2.Animated = true;
            this.Guna2TextBox2.BackColor = System.Drawing.Color.Transparent;
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
            this.Guna2TextBox2.Location = new System.Drawing.Point(58, 235);
            this.Guna2TextBox2.Name = "Guna2TextBox2";
            this.Guna2TextBox2.PasswordChar = '\0';
            this.Guna2TextBox2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.Guna2TextBox2.PlaceholderText = "Firmware File | .pac";
            this.Guna2TextBox2.SelectedText = "";
            this.Guna2TextBox2.ShadowDecoration.Color = System.Drawing.Color.DimGray;
            this.Guna2TextBox2.ShadowDecoration.Depth = 15;
            this.Guna2TextBox2.Size = new System.Drawing.Size(284, 26);
            this.Guna2TextBox2.TabIndex = 528;
            this.Guna2TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Guna2Button8
            // 
            this.Guna2Button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Guna2Button8.Animated = true;
            this.Guna2Button8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2Button8.BorderRadius = 4;
            this.Guna2Button8.BorderThickness = 2;
            this.Guna2Button8.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button8.CheckedState.FillColor = System.Drawing.Color.LightGray;
            this.Guna2Button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guna2Button8.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button8.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
            this.Guna2Button8.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button8.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.Guna2Button8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2Button8.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Guna2Button8.ForeColor = System.Drawing.Color.White;
            this.Guna2Button8.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button8.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button8.Image = global::Properties.Resources.edit__1_;
            this.Guna2Button8.Location = new System.Drawing.Point(348, 235);
            this.Guna2Button8.Name = "Guna2Button8";
            this.Guna2Button8.PressedColor = System.Drawing.Color.Empty;
            this.Guna2Button8.Size = new System.Drawing.Size(102, 26);
            this.Guna2Button8.TabIndex = 527;
            this.Guna2Button8.Text = "Write";
            this.Guna2Button8.TextFormatNoPrefix = true;
            // 
            // Guna2GroupBox1
            // 
            this.Guna2GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Guna2GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.Guna2GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2GroupBox1.BorderRadius = 6;
            this.Guna2GroupBox1.BorderThickness = 2;
            this.Guna2GroupBox1.Controls.Add(this.Guna2VScrollBar3);
            this.Guna2GroupBox1.Controls.Add(this.cblistdataview);
            this.Guna2GroupBox1.Controls.Add(this.DataViewmtk);
            this.Guna2GroupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.Guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Guna2GroupBox1.Location = new System.Drawing.Point(7, 6);
            this.Guna2GroupBox1.Name = "Guna2GroupBox1";
            this.Guna2GroupBox1.ShadowDecoration.BorderRadius = 9;
            this.Guna2GroupBox1.ShadowDecoration.Color = System.Drawing.Color.White;
            this.Guna2GroupBox1.ShadowDecoration.Depth = 15;
            this.Guna2GroupBox1.Size = new System.Drawing.Size(444, 223);
            this.Guna2GroupBox1.TabIndex = 515;
            // 
            // Guna2VScrollBar3
            // 
            this.Guna2VScrollBar3.AutoRoundedCorners = true;
            this.Guna2VScrollBar3.AutoScroll = true;
            this.Guna2VScrollBar3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2VScrollBar3.BindingContainer = this.DataViewmtk;
            this.Guna2VScrollBar3.BorderRadius = 8;
            this.Guna2VScrollBar3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2VScrollBar3.HighlightOnWheel = true;
            this.Guna2VScrollBar3.InUpdate = false;
            this.Guna2VScrollBar3.LargeChange = 10;
            this.Guna2VScrollBar3.Location = new System.Drawing.Point(423, 3);
            this.Guna2VScrollBar3.Minimum = 1;
            this.Guna2VScrollBar3.Name = "Guna2VScrollBar3";
            this.Guna2VScrollBar3.ScrollbarSize = 18;
            this.Guna2VScrollBar3.Size = new System.Drawing.Size(18, 216);
            this.Guna2VScrollBar3.TabIndex = 479;
            this.Guna2VScrollBar3.ThumbColor = System.Drawing.Color.FromArgb(0, 85, 207);
            this.Guna2VScrollBar3.ThumbStyle = Guna.UI2.WinForms.Enums.ThumbStyle.Inset;
            this.Guna2VScrollBar3.Value = 1;
            // 
            // DataViewmtk
            // 
            this.DataViewmtk.AllowUserToAddRows = false;
            this.DataViewmtk.AllowUserToDeleteRows = false;
            this.DataViewmtk.AllowUserToResizeColumns = false;
            this.DataViewmtk.AllowUserToResizeRows = false;
            this.DataViewmtk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataViewmtk.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataViewmtk.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.DataViewmtk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataViewmtk.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.DataViewmtk.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle65.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle65.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle65.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle65.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle65.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle65.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle65.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataViewmtk.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle65;
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
            dataGridViewCellStyle70.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle70.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle70.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle70.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle70.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle70.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle70.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataViewmtk.DefaultCellStyle = dataGridViewCellStyle70;
            this.DataViewmtk.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.DataViewmtk.EnableHeadersVisualStyles = false;
            this.DataViewmtk.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.DataViewmtk.Location = new System.Drawing.Point(7, 3);
            this.DataViewmtk.MultiSelect = false;
            this.DataViewmtk.Name = "DataViewmtk";
            dataGridViewCellStyle71.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle71.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle71.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle71.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle71.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle71.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle71.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataViewmtk.RowHeadersDefaultCellStyle = dataGridViewCellStyle71;
            this.DataViewmtk.RowHeadersVisible = false;
            dataGridViewCellStyle72.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle72.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle72.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle72.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle72.SelectionForeColor = System.Drawing.Color.White;
            this.DataViewmtk.RowsDefaultCellStyle = dataGridViewCellStyle72;
            this.DataViewmtk.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.DataViewmtk.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataViewmtk.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.DataViewmtk.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.DataViewmtk.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DataViewmtk.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataViewmtk.Size = new System.Drawing.Size(434, 216);
            this.DataViewmtk.TabIndex = 484;
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
            dataGridViewCellStyle66.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.part.DefaultCellStyle = dataGridViewCellStyle66;
            this.part.FillWeight = 50F;
            this.part.HeaderText = "Partition";
            this.part.Name = "part";
            this.part.ReadOnly = true;
            // 
            // Column1
            // 
            dataGridViewCellStyle67.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle67;
            this.Column1.FillWeight = 50F;
            this.Column1.HeaderText = "Address";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            dataGridViewCellStyle68.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle68;
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
            dataGridViewCellStyle69.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle69;
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
            // cblistdataview
            // 
            this.cblistdataview.AutoSize = true;
            this.cblistdataview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.cblistdataview.Location = new System.Drawing.Point(11, 6);
            this.cblistdataview.Name = "cblistdataview";
            this.cblistdataview.Size = new System.Drawing.Size(15, 14);
            this.cblistdataview.TabIndex = 483;
            this.cblistdataview.UseVisualStyleBackColor = false;
            // 
            // Guna2GroupBox2
            // 
            this.Guna2GroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.Guna2GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Guna2GroupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2GroupBox2.BorderRadius = 6;
            this.Guna2GroupBox2.Controls.Add(this.Model);
            this.Guna2GroupBox2.Controls.Add(this.Guna2RadioButton11);
            this.Guna2GroupBox2.Controls.Add(this.Guna2RadioButton4);
            this.Guna2GroupBox2.Controls.Add(this.Brand);
            this.Guna2GroupBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2GroupBox2.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.Guna2GroupBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Guna2GroupBox2.Location = new System.Drawing.Point(7, 7);
            this.Guna2GroupBox2.Name = "Guna2GroupBox2";
            this.Guna2GroupBox2.ShadowDecoration.BorderRadius = 9;
            this.Guna2GroupBox2.ShadowDecoration.Color = System.Drawing.Color.White;
            this.Guna2GroupBox2.ShadowDecoration.Depth = 15;
            this.Guna2GroupBox2.Size = new System.Drawing.Size(471, 153);
            this.Guna2GroupBox2.TabIndex = 517;
            // 
            // Model
            // 
            this.Model.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Model.BackColor = System.Drawing.Color.Transparent;
            this.Model.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Model.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Model.BorderRadius = 6;
            this.Model.Controls.Add(this.Guna2VScrollBar2);
            this.Model.Controls.Add(this.LIST_SPD);
            this.Model.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Model.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Model.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.Model.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Model.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Model.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Model.Location = new System.Drawing.Point(11, 34);
            this.Model.Name = "Model";
            this.Model.ShadowDecoration.BorderRadius = 9;
            this.Model.ShadowDecoration.Color = System.Drawing.Color.White;
            this.Model.ShadowDecoration.Depth = 15;
            this.Model.Size = new System.Drawing.Size(449, 111);
            this.Model.TabIndex = 521;
            // 
            // Guna2VScrollBar2
            // 
            this.Guna2VScrollBar2.AutoRoundedCorners = true;
            this.Guna2VScrollBar2.AutoScroll = true;
            this.Guna2VScrollBar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2VScrollBar2.BindingContainer = this.LIST_SPD;
            this.Guna2VScrollBar2.BorderRadius = 8;
            this.Guna2VScrollBar2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2VScrollBar2.HighlightOnWheel = true;
            this.Guna2VScrollBar2.InUpdate = false;
            this.Guna2VScrollBar2.LargeChange = 3;
            this.Guna2VScrollBar2.Location = new System.Drawing.Point(428, 5);
            this.Guna2VScrollBar2.Name = "Guna2VScrollBar2";
            this.Guna2VScrollBar2.ScrollbarSize = 18;
            this.Guna2VScrollBar2.Size = new System.Drawing.Size(18, 102);
            this.Guna2VScrollBar2.TabIndex = 521;
            this.Guna2VScrollBar2.ThumbColor = System.Drawing.Color.FromArgb(0, 85, 207);
            this.Guna2VScrollBar2.ThumbStyle = Guna.UI2.WinForms.Enums.ThumbStyle.Inset;
            // 
            // LIST_SPD
            // 
            this.LIST_SPD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.LIST_SPD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LIST_SPD.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LIST_SPD.ForeColor = System.Drawing.Color.White;
            this.LIST_SPD.FormattingEnabled = true;
            this.LIST_SPD.ItemHeight = 17;
            this.LIST_SPD.Location = new System.Drawing.Point(3, 5);
            this.LIST_SPD.Name = "LIST_SPD";
            this.LIST_SPD.Size = new System.Drawing.Size(443, 102);
            this.LIST_SPD.TabIndex = 520;
            // 
            // Guna2RadioButton11
            // 
            this.Guna2RadioButton11.Anchor = System.Windows.Forms.AnchorStyles.Right;
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
            this.Guna2RadioButton11.Location = new System.Drawing.Point(84, 6);
            this.Guna2RadioButton11.Name = "Guna2RadioButton11";
            this.Guna2RadioButton11.Size = new System.Drawing.Size(72, 19);
            this.Guna2RadioButton11.TabIndex = 500;
            this.Guna2RadioButton11.Text = "By Brand";
            this.Guna2RadioButton11.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2RadioButton11.UncheckedState.BorderThickness = 3;
            this.Guna2RadioButton11.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2RadioButton11.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2RadioButton11.CheckedChanged += new System.EventHandler(this.Guna2RadioButton11_CheckedChanged);
            // 
            // Guna2RadioButton4
            // 
            this.Guna2RadioButton4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Guna2RadioButton4.Animated = true;
            this.Guna2RadioButton4.AutoSize = true;
            this.Guna2RadioButton4.Checked = true;
            this.Guna2RadioButton4.CheckedState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2RadioButton4.CheckedState.BorderThickness = 3;
            this.Guna2RadioButton4.CheckedState.FillColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2RadioButton4.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(99)))), ((int)(((byte)(129)))));
            this.Guna2RadioButton4.CheckedState.InnerOffset = -6;
            this.Guna2RadioButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guna2RadioButton4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2RadioButton4.ForeColor = System.Drawing.Color.White;
            this.Guna2RadioButton4.Location = new System.Drawing.Point(11, 6);
            this.Guna2RadioButton4.Name = "Guna2RadioButton4";
            this.Guna2RadioButton4.Size = new System.Drawing.Size(63, 19);
            this.Guna2RadioButton4.TabIndex = 474;
            this.Guna2RadioButton4.TabStop = true;
            this.Guna2RadioButton4.Text = "By CPU";
            this.Guna2RadioButton4.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2RadioButton4.UncheckedState.BorderThickness = 3;
            this.Guna2RadioButton4.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2RadioButton4.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2RadioButton4.CheckedChanged += new System.EventHandler(this.Guna2RadioButton4_CheckedChanged);
            // 
            // Brand
            // 
            this.Brand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Brand.BackColor = System.Drawing.Color.Transparent;
            this.Brand.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Brand.BorderRadius = 4;
            this.Brand.BorderThickness = 2;
            this.Brand.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Brand.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Brand.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.Brand.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Brand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Brand.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Brand.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Brand.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Brand.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Brand.ForeColor = System.Drawing.Color.White;
            this.Brand.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Brand.ItemHeight = 14;
            this.Brand.Items.AddRange(new object[] {
            "Samsung",
            "Nokia",
            "Realme",
            "iTel",
            "infinix",
            "Gionee",
            "Tenco"});
            this.Brand.ItemsAppearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Brand.ItemsAppearance.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Brand.ItemsAppearance.ForeColor = System.Drawing.Color.White;
            this.Brand.ItemsAppearance.SelectedBackColor = System.Drawing.Color.Gray;
            this.Brand.ItemsAppearance.SelectedForeColor = System.Drawing.Color.White;
            this.Brand.Location = new System.Drawing.Point(162, 6);
            this.Brand.MaxDropDownItems = 5;
            this.Brand.MaxLength = 5;
            this.Brand.Name = "Brand";
            this.Brand.Size = new System.Drawing.Size(298, 20);
            this.Brand.StartIndex = 0;
            this.Brand.TabIndex = 514;
            this.Brand.SelectedIndexChanged += new System.EventHandler(this.Brand_SelectedIndexChanged);
            // 
            // Panel_SPD
            // 
            this.Panel_SPD.BackColor = System.Drawing.Color.Transparent;
            this.Panel_SPD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Panel_SPD.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Panel_SPD.BorderRadius = 6;
            this.Panel_SPD.Controls.Add(this.Guna2GroupBox3);
            this.Panel_SPD.Controls.Add(this.Guna2GroupBox2);
            this.Panel_SPD.Cursor = System.Windows.Forms.Cursors.Default;
            this.Panel_SPD.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Panel_SPD.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.Panel_SPD.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Panel_SPD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Panel_SPD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Panel_SPD.Location = new System.Drawing.Point(5, 46);
            this.Panel_SPD.Name = "Panel_SPD";
            this.Panel_SPD.ShadowDecoration.BorderRadius = 9;
            this.Panel_SPD.ShadowDecoration.Color = System.Drawing.Color.White;
            this.Panel_SPD.ShadowDecoration.Depth = 15;
            this.Panel_SPD.Size = new System.Drawing.Size(485, 481);
            this.Panel_SPD.TabIndex = 522;
            // 
            // Guna2GroupBox3
            // 
            this.Guna2GroupBox3.BackColor = System.Drawing.Color.Transparent;
            this.Guna2GroupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Guna2GroupBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2GroupBox3.BorderRadius = 6;
            this.Guna2GroupBox3.Controls.Add(this.Guna2TabControl1);
            this.Guna2GroupBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.Guna2GroupBox3.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2GroupBox3.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.Guna2GroupBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2GroupBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Guna2GroupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Guna2GroupBox3.Location = new System.Drawing.Point(7, 165);
            this.Guna2GroupBox3.Name = "Guna2GroupBox3";
            this.Guna2GroupBox3.ShadowDecoration.BorderRadius = 9;
            this.Guna2GroupBox3.ShadowDecoration.Color = System.Drawing.Color.White;
            this.Guna2GroupBox3.ShadowDecoration.Depth = 15;
            this.Guna2GroupBox3.Size = new System.Drawing.Size(471, 309);
            this.Guna2GroupBox3.TabIndex = 522;
            // 
            // ComboBoxBoot
            // 
            this.ComboBoxBoot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxBoot.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxBoot.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.ComboBoxBoot.BorderRadius = 4;
            this.ComboBoxBoot.BorderThickness = 2;
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
            "Unisoc [SPD]",
            "HiSilicon [Kirin]"});
            this.ComboBoxBoot.ItemsAppearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.ComboBoxBoot.ItemsAppearance.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxBoot.ItemsAppearance.ForeColor = System.Drawing.Color.White;
            this.ComboBoxBoot.ItemsAppearance.SelectedBackColor = System.Drawing.Color.Gray;
            this.ComboBoxBoot.ItemsAppearance.SelectedForeColor = System.Drawing.Color.White;
            this.ComboBoxBoot.Location = new System.Drawing.Point(5, 8);
            this.ComboBoxBoot.MaxDropDownItems = 5;
            this.ComboBoxBoot.MaxLength = 5;
            this.ComboBoxBoot.Name = "ComboBoxBoot";
            this.ComboBoxBoot.Size = new System.Drawing.Size(485, 32);
            this.ComboBoxBoot.StartIndex = 0;
            this.ComboBoxBoot.TabIndex = 523;
            this.ComboBoxBoot.SelectedIndexChanged += new System.EventHandler(this.ComboBoxBoot_SelectedIndexChanged);
            // 
            // Panel_Kirin
            // 
            this.Panel_Kirin.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Kirin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Panel_Kirin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Panel_Kirin.BorderRadius = 6;
            this.Panel_Kirin.Controls.Add(this.Guna2GroupBox5);
            this.Panel_Kirin.Controls.Add(this.Guna2GroupBox6);
            this.Panel_Kirin.Cursor = System.Windows.Forms.Cursors.Default;
            this.Panel_Kirin.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Panel_Kirin.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.Panel_Kirin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Panel_Kirin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Panel_Kirin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Panel_Kirin.Location = new System.Drawing.Point(5, 46);
            this.Panel_Kirin.Name = "Panel_Kirin";
            this.Panel_Kirin.ShadowDecoration.BorderRadius = 9;
            this.Panel_Kirin.ShadowDecoration.Color = System.Drawing.Color.White;
            this.Panel_Kirin.ShadowDecoration.Depth = 15;
            this.Panel_Kirin.Size = new System.Drawing.Size(479, 481);
            this.Panel_Kirin.TabIndex = 524;
            this.Panel_Kirin.Visible = false;
            // 
            // Guna2GroupBox5
            // 
            this.Guna2GroupBox5.BackColor = System.Drawing.Color.Transparent;
            this.Guna2GroupBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Guna2GroupBox5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2GroupBox5.BorderRadius = 6;
            this.Guna2GroupBox5.Controls.Add(this.Guna2TabControl2);
            this.Guna2GroupBox5.Cursor = System.Windows.Forms.Cursors.Default;
            this.Guna2GroupBox5.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2GroupBox5.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.Guna2GroupBox5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2GroupBox5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Guna2GroupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Guna2GroupBox5.Location = new System.Drawing.Point(7, 165);
            this.Guna2GroupBox5.Name = "Guna2GroupBox5";
            this.Guna2GroupBox5.ShadowDecoration.BorderRadius = 9;
            this.Guna2GroupBox5.ShadowDecoration.Color = System.Drawing.Color.White;
            this.Guna2GroupBox5.ShadowDecoration.Depth = 15;
            this.Guna2GroupBox5.Size = new System.Drawing.Size(471, 309);
            this.Guna2GroupBox5.TabIndex = 522;
            // 
            // Guna2TabControl2
            // 
            this.Guna2TabControl2.Controls.Add(this.TabPage4);
            this.Guna2TabControl2.Controls.Add(this.TabPage3);
            this.Guna2TabControl2.ItemSize = new System.Drawing.Size(80, 25);
            this.Guna2TabControl2.Location = new System.Drawing.Point(3, 5);
            this.Guna2TabControl2.Name = "Guna2TabControl2";
            this.Guna2TabControl2.SelectedIndex = 0;
            this.Guna2TabControl2.Size = new System.Drawing.Size(465, 301);
            this.Guna2TabControl2.TabButtonHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2TabControl2.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Guna2TabControl2.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.Guna2TabControl2.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.Guna2TabControl2.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(0, 85, 207);
            this.Guna2TabControl2.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.Guna2TabControl2.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2TabControl2.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.Guna2TabControl2.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.Guna2TabControl2.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2TabControl2.TabButtonSelectedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.Guna2TabControl2.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.Guna2TabControl2.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.Guna2TabControl2.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.Guna2TabControl2.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.Guna2TabControl2.TabButtonSize = new System.Drawing.Size(80, 25);
            this.Guna2TabControl2.TabIndex = 2;
            this.Guna2TabControl2.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2TabControl2.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // TabPage4
            // 
            this.TabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TabPage4.Controls.Add(this.Guna2Button12);
            this.TabPage4.Controls.Add(this.Guna2Button6);
            this.TabPage4.Controls.Add(this.Guna2Button7);
            this.TabPage4.Controls.Add(this.Guna2Button10);
            this.TabPage4.Location = new System.Drawing.Point(4, 29);
            this.TabPage4.Name = "TabPage4";
            this.TabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage4.Size = new System.Drawing.Size(457, 268);
            this.TabPage4.TabIndex = 1;
            this.TabPage4.Text = "Services";
            // 
            // Guna2Button12
            // 
            this.Guna2Button12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Guna2Button12.Animated = true;
            this.Guna2Button12.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2Button12.BorderRadius = 4;
            this.Guna2Button12.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.Guna2Button12.BorderThickness = 2;
            this.Guna2Button12.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button12.CheckedState.FillColor = System.Drawing.Color.LightGray;
            this.Guna2Button12.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
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
            this.Guna2Button12.Image = global::Properties.Resources.info__1_;
            this.Guna2Button12.ImageSize = new System.Drawing.Size(18, 18);
            this.Guna2Button12.Location = new System.Drawing.Point(11, 11);
            this.Guna2Button12.Name = "Guna2Button12";
            this.Guna2Button12.PressedColor = System.Drawing.Color.Empty;
            this.Guna2Button12.Size = new System.Drawing.Size(436, 32);
            this.Guna2Button12.TabIndex = 524;
            this.Guna2Button12.Text = "Read Info";
            this.Guna2Button12.TextFormatNoPrefix = true;
            // 
            // Guna2Button6
            // 
            this.Guna2Button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Guna2Button6.Animated = true;
            this.Guna2Button6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2Button6.BorderRadius = 4;
            this.Guna2Button6.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.Guna2Button6.BorderThickness = 2;
            this.Guna2Button6.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button6.CheckedState.FillColor = System.Drawing.Color.LightGray;
            this.Guna2Button6.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
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
            this.Guna2Button6.Image = global::Properties.Resources.rotation_lock;
            this.Guna2Button6.Location = new System.Drawing.Point(11, 125);
            this.Guna2Button6.Name = "Guna2Button6";
            this.Guna2Button6.PressedColor = System.Drawing.Color.Empty;
            this.Guna2Button6.Size = new System.Drawing.Size(436, 32);
            this.Guna2Button6.TabIndex = 523;
            this.Guna2Button6.Text = "Relock Bootloader";
            this.Guna2Button6.TextFormatNoPrefix = true;
            // 
            // Guna2Button7
            // 
            this.Guna2Button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Guna2Button7.Animated = true;
            this.Guna2Button7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2Button7.BorderRadius = 4;
            this.Guna2Button7.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.Guna2Button7.BorderThickness = 2;
            this.Guna2Button7.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button7.CheckedState.FillColor = System.Drawing.Color.LightGray;
            this.Guna2Button7.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image5")));
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
            this.Guna2Button7.Image = global::Properties.Resources.google__2_;
            this.Guna2Button7.ImageSize = new System.Drawing.Size(18, 18);
            this.Guna2Button7.Location = new System.Drawing.Point(11, 49);
            this.Guna2Button7.Name = "Guna2Button7";
            this.Guna2Button7.PressedColor = System.Drawing.Color.Empty;
            this.Guna2Button7.Size = new System.Drawing.Size(436, 32);
            this.Guna2Button7.TabIndex = 522;
            this.Guna2Button7.Text = "Remove FRP";
            this.Guna2Button7.TextFormatNoPrefix = true;
            this.Guna2Button7.Click += new System.EventHandler(this.Guna2Button7_Click);
            // 
            // Guna2Button10
            // 
            this.Guna2Button10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Guna2Button10.Animated = true;
            this.Guna2Button10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2Button10.BorderRadius = 4;
            this.Guna2Button10.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.Guna2Button10.BorderThickness = 2;
            this.Guna2Button10.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button10.CheckedState.FillColor = System.Drawing.Color.LightGray;
            this.Guna2Button10.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image6")));
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
            this.Guna2Button10.Image = global::Properties.Resources.imggunlock;
            this.Guna2Button10.Location = new System.Drawing.Point(11, 87);
            this.Guna2Button10.Name = "Guna2Button10";
            this.Guna2Button10.PressedColor = System.Drawing.Color.Empty;
            this.Guna2Button10.Size = new System.Drawing.Size(436, 32);
            this.Guna2Button10.TabIndex = 518;
            this.Guna2Button10.Text = "Unlock Bootloader";
            this.Guna2Button10.TextFormatNoPrefix = true;
            // 
            // TabPage3
            // 
            this.TabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TabPage3.Controls.Add(this.Guna2Button9);
            this.TabPage3.Controls.Add(this.Guna2TextBox3);
            this.TabPage3.Controls.Add(this.Guna2Button11);
            this.TabPage3.Controls.Add(this.Guna2GroupBox4);
            this.TabPage3.Location = new System.Drawing.Point(4, 29);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage3.Size = new System.Drawing.Size(457, 268);
            this.TabPage3.TabIndex = 0;
            this.TabPage3.Text = "Flasher";
            // 
            // Guna2Button9
            // 
            this.Guna2Button9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Guna2Button9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2Button9.BorderRadius = 4;
            this.Guna2Button9.BorderThickness = 2;
            this.Guna2Button9.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button9.CheckedState.FillColor = System.Drawing.Color.LightGray;
            this.Guna2Button9.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.Guna2Button9.Location = new System.Drawing.Point(7, 235);
            this.Guna2Button9.Name = "Guna2Button9";
            this.Guna2Button9.PressedColor = System.Drawing.Color.Empty;
            this.Guna2Button9.Size = new System.Drawing.Size(45, 26);
            this.Guna2Button9.TabIndex = 533;
            this.Guna2Button9.TextFormatNoPrefix = true;
            // 
            // Guna2TextBox3
            // 
            this.Guna2TextBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Guna2TextBox3.Animated = true;
            this.Guna2TextBox3.BackColor = System.Drawing.Color.Transparent;
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
            this.Guna2TextBox3.Location = new System.Drawing.Point(58, 235);
            this.Guna2TextBox3.Name = "Guna2TextBox3";
            this.Guna2TextBox3.PasswordChar = '\0';
            this.Guna2TextBox3.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.Guna2TextBox3.PlaceholderText = "Firmware File | .img |.app";
            this.Guna2TextBox3.SelectedText = "";
            this.Guna2TextBox3.ShadowDecoration.Color = System.Drawing.Color.DimGray;
            this.Guna2TextBox3.ShadowDecoration.Depth = 15;
            this.Guna2TextBox3.Size = new System.Drawing.Size(284, 26);
            this.Guna2TextBox3.TabIndex = 532;
            this.Guna2TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Guna2Button11
            // 
            this.Guna2Button11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Guna2Button11.Animated = true;
            this.Guna2Button11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2Button11.BorderRadius = 4;
            this.Guna2Button11.BorderThickness = 2;
            this.Guna2Button11.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button11.CheckedState.FillColor = System.Drawing.Color.LightGray;
            this.Guna2Button11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guna2Button11.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button11.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
            this.Guna2Button11.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button11.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.Guna2Button11.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2Button11.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Guna2Button11.ForeColor = System.Drawing.Color.White;
            this.Guna2Button11.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button11.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button11.Image = global::Properties.Resources.edit__1_;
            this.Guna2Button11.Location = new System.Drawing.Point(348, 235);
            this.Guna2Button11.Name = "Guna2Button11";
            this.Guna2Button11.PressedColor = System.Drawing.Color.Empty;
            this.Guna2Button11.Size = new System.Drawing.Size(102, 26);
            this.Guna2Button11.TabIndex = 531;
            this.Guna2Button11.Text = "Write";
            this.Guna2Button11.TextFormatNoPrefix = true;
            // 
            // Guna2GroupBox4
            // 
            this.Guna2GroupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Guna2GroupBox4.BackColor = System.Drawing.Color.Transparent;
            this.Guna2GroupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Guna2GroupBox4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2GroupBox4.BorderRadius = 6;
            this.Guna2GroupBox4.BorderThickness = 2;
            this.Guna2GroupBox4.Controls.Add(this.Guna2VScrollBar4);
            this.Guna2GroupBox4.Controls.Add(this.CheckBox1);
            this.Guna2GroupBox4.Controls.Add(this.DataGridView1);
            this.Guna2GroupBox4.Cursor = System.Windows.Forms.Cursors.Default;
            this.Guna2GroupBox4.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2GroupBox4.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.Guna2GroupBox4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2GroupBox4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Guna2GroupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Guna2GroupBox4.Location = new System.Drawing.Point(7, 6);
            this.Guna2GroupBox4.Name = "Guna2GroupBox4";
            this.Guna2GroupBox4.ShadowDecoration.BorderRadius = 9;
            this.Guna2GroupBox4.ShadowDecoration.Color = System.Drawing.Color.White;
            this.Guna2GroupBox4.ShadowDecoration.Depth = 15;
            this.Guna2GroupBox4.Size = new System.Drawing.Size(444, 223);
            this.Guna2GroupBox4.TabIndex = 530;
            // 
            // Guna2VScrollBar4
            // 
            this.Guna2VScrollBar4.AutoRoundedCorners = true;
            this.Guna2VScrollBar4.AutoScroll = true;
            this.Guna2VScrollBar4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2VScrollBar4.BindingContainer = this.DataGridView1;
            this.Guna2VScrollBar4.BorderRadius = 8;
            this.Guna2VScrollBar4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2VScrollBar4.HighlightOnWheel = true;
            this.Guna2VScrollBar4.InUpdate = false;
            this.Guna2VScrollBar4.LargeChange = 10;
            this.Guna2VScrollBar4.Location = new System.Drawing.Point(423, 3);
            this.Guna2VScrollBar4.Minimum = 1;
            this.Guna2VScrollBar4.Name = "Guna2VScrollBar4";
            this.Guna2VScrollBar4.ScrollbarSize = 18;
            this.Guna2VScrollBar4.Size = new System.Drawing.Size(18, 216);
            this.Guna2VScrollBar4.TabIndex = 479;
            this.Guna2VScrollBar4.ThumbColor = System.Drawing.Color.FromArgb(0, 85, 207);
            this.Guna2VScrollBar4.ThumbStyle = Guna.UI2.WinForms.Enums.ThumbStyle.Inset;
            this.Guna2VScrollBar4.Value = 1;
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.AllowUserToResizeColumns = false;
            this.DataGridView1.AllowUserToResizeRows = false;
            this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle73.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle73.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle73.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle73.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle73.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle73.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle73.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle73;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewCheckBoxColumn1,
            this.DataGridViewTextBoxColumn1,
            this.DataGridViewTextBoxColumn2,
            this.DataGridViewTextBoxColumn3,
            this.DataGridViewTextBoxColumn4,
            this.DataGridViewTextBoxColumn5,
            this.DataGridViewTextBoxColumn6,
            this.DataGridViewTextBoxColumn7});
            dataGridViewCellStyle78.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle78.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle78.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle78.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle78.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle78.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle78.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView1.DefaultCellStyle = dataGridViewCellStyle78;
            this.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.DataGridView1.EnableHeadersVisualStyles = false;
            this.DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.DataGridView1.Location = new System.Drawing.Point(7, 3);
            this.DataGridView1.MultiSelect = false;
            this.DataGridView1.Name = "DataGridView1";
            dataGridViewCellStyle79.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle79.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle79.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle79.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle79.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle79.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle79.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle79;
            this.DataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle80.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle80.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle80.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle80.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle80.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle80;
            this.DataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.DataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.DataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(434, 216);
            this.DataGridView1.TabIndex = 484;
            // 
            // DataGridViewCheckBoxColumn1
            // 
            this.DataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DataGridViewCheckBoxColumn1.Frozen = true;
            this.DataGridViewCheckBoxColumn1.HeaderText = " ";
            this.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1";
            this.DataGridViewCheckBoxColumn1.Width = 19;
            // 
            // DataGridViewTextBoxColumn1
            // 
            this.DataGridViewTextBoxColumn1.HeaderText = "Region";
            this.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
            this.DataGridViewTextBoxColumn1.Visible = false;
            // 
            // DataGridViewTextBoxColumn2
            // 
            dataGridViewCellStyle74.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle74;
            this.DataGridViewTextBoxColumn2.FillWeight = 50F;
            this.DataGridViewTextBoxColumn2.HeaderText = "Partition";
            this.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2";
            this.DataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn3
            // 
            dataGridViewCellStyle75.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle75;
            this.DataGridViewTextBoxColumn3.FillWeight = 50F;
            this.DataGridViewTextBoxColumn3.HeaderText = "Address";
            this.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3";
            this.DataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn4
            // 
            dataGridViewCellStyle76.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle76;
            this.DataGridViewTextBoxColumn4.FillWeight = 50F;
            this.DataGridViewTextBoxColumn4.HeaderText = "Size";
            this.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4";
            this.DataGridViewTextBoxColumn4.Visible = false;
            // 
            // DataGridViewTextBoxColumn5
            // 
            this.DataGridViewTextBoxColumn5.FillWeight = 50F;
            this.DataGridViewTextBoxColumn5.HeaderText = "Part Size";
            this.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5";
            this.DataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn6
            // 
            dataGridViewCellStyle77.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle77;
            this.DataGridViewTextBoxColumn6.FillWeight = 50F;
            this.DataGridViewTextBoxColumn6.HeaderText = "Filename";
            this.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6";
            this.DataGridViewTextBoxColumn6.Visible = false;
            // 
            // DataGridViewTextBoxColumn7
            // 
            this.DataGridViewTextBoxColumn7.FillWeight = 50F;
            this.DataGridViewTextBoxColumn7.HeaderText = "Region";
            this.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7";
            this.DataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // CheckBox1
            // 
            this.CheckBox1.AutoSize = true;
            this.CheckBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.CheckBox1.Location = new System.Drawing.Point(11, 6);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(15, 14);
            this.CheckBox1.TabIndex = 483;
            this.CheckBox1.UseVisualStyleBackColor = false;
            // 
            // Guna2GroupBox6
            // 
            this.Guna2GroupBox6.BackColor = System.Drawing.Color.Transparent;
            this.Guna2GroupBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Guna2GroupBox6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2GroupBox6.BorderRadius = 6;
            this.Guna2GroupBox6.Controls.Add(this.Guna2GroupBox7);
            this.Guna2GroupBox6.Controls.Add(this.Guna2RadioButton1);
            this.Guna2GroupBox6.Controls.Add(this.Guna2RadioButton2);
            this.Guna2GroupBox6.Cursor = System.Windows.Forms.Cursors.Default;
            this.Guna2GroupBox6.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2GroupBox6.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.Guna2GroupBox6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2GroupBox6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Guna2GroupBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Guna2GroupBox6.Location = new System.Drawing.Point(7, 7);
            this.Guna2GroupBox6.Name = "Guna2GroupBox6";
            this.Guna2GroupBox6.ShadowDecoration.BorderRadius = 9;
            this.Guna2GroupBox6.ShadowDecoration.Color = System.Drawing.Color.White;
            this.Guna2GroupBox6.ShadowDecoration.Depth = 15;
            this.Guna2GroupBox6.Size = new System.Drawing.Size(471, 153);
            this.Guna2GroupBox6.TabIndex = 517;
            // 
            // Guna2GroupBox7
            // 
            this.Guna2GroupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Guna2GroupBox7.BackColor = System.Drawing.Color.Transparent;
            this.Guna2GroupBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Guna2GroupBox7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2GroupBox7.BorderRadius = 6;
            this.Guna2GroupBox7.Controls.Add(this.Guna2VScrollBar1);
            this.Guna2GroupBox7.Controls.Add(this.LIST_KIRIN);
            this.Guna2GroupBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guna2GroupBox7.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2GroupBox7.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.Guna2GroupBox7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2GroupBox7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Guna2GroupBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Guna2GroupBox7.Location = new System.Drawing.Point(11, 34);
            this.Guna2GroupBox7.Name = "Guna2GroupBox7";
            this.Guna2GroupBox7.ShadowDecoration.BorderRadius = 9;
            this.Guna2GroupBox7.ShadowDecoration.Color = System.Drawing.Color.White;
            this.Guna2GroupBox7.ShadowDecoration.Depth = 15;
            this.Guna2GroupBox7.Size = new System.Drawing.Size(449, 109);
            this.Guna2GroupBox7.TabIndex = 521;
            // 
            // Guna2VScrollBar1
            // 
            this.Guna2VScrollBar1.AutoRoundedCorners = true;
            this.Guna2VScrollBar1.AutoScroll = true;
            this.Guna2VScrollBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2VScrollBar1.BindingContainer = this.LIST_KIRIN;
            this.Guna2VScrollBar1.BorderRadius = 8;
            this.Guna2VScrollBar1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2VScrollBar1.HighlightOnWheel = true;
            this.Guna2VScrollBar1.InUpdate = false;
            this.Guna2VScrollBar1.LargeChange = 6;
            this.Guna2VScrollBar1.Location = new System.Drawing.Point(428, 4);
            this.Guna2VScrollBar1.Maximum = 18;
            this.Guna2VScrollBar1.Name = "Guna2VScrollBar1";
            this.Guna2VScrollBar1.ScrollbarSize = 18;
            this.Guna2VScrollBar1.Size = new System.Drawing.Size(18, 102);
            this.Guna2VScrollBar1.TabIndex = 521;
            this.Guna2VScrollBar1.ThumbColor = System.Drawing.Color.FromArgb(0, 85, 207);
            this.Guna2VScrollBar1.ThumbStyle = Guna.UI2.WinForms.Enums.ThumbStyle.Inset;
            // 
            // LIST_KIRIN
            // 
            this.LIST_KIRIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.LIST_KIRIN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LIST_KIRIN.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LIST_KIRIN.ForeColor = System.Drawing.Color.White;
            this.LIST_KIRIN.FormattingEnabled = true;
            this.LIST_KIRIN.ItemHeight = 17;
            this.LIST_KIRIN.Items.AddRange(new object[] {
            "Hisi65x",
            "Hisi620",
            "Hisi620c",
            "Hisi710",
            "Hisi710_V2",
            "Hisi710F",
            "Hisi710F_V2",
            "Hisi710F_V3",
            "Hisi810",
            "Hisi925",
            "Hisi930",
            "Hisi935",
            "Hisi950",
            "Hisi955",
            "Hisi960",
            "Hisi970",
            "Hisi970_V2",
            "Hisi980",
            "Hisi980_V2"});
            this.LIST_KIRIN.Location = new System.Drawing.Point(3, 4);
            this.LIST_KIRIN.Name = "LIST_KIRIN";
            this.LIST_KIRIN.Size = new System.Drawing.Size(443, 102);
            this.LIST_KIRIN.TabIndex = 520;
            // 
            // Guna2RadioButton1
            // 
            this.Guna2RadioButton1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Guna2RadioButton1.Animated = true;
            this.Guna2RadioButton1.AutoSize = true;
            this.Guna2RadioButton1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2RadioButton1.CheckedState.BorderThickness = 3;
            this.Guna2RadioButton1.CheckedState.FillColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2RadioButton1.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(99)))), ((int)(((byte)(129)))));
            this.Guna2RadioButton1.CheckedState.InnerOffset = -6;
            this.Guna2RadioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guna2RadioButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2RadioButton1.ForeColor = System.Drawing.Color.White;
            this.Guna2RadioButton1.Location = new System.Drawing.Point(81, 9);
            this.Guna2RadioButton1.Name = "Guna2RadioButton1";
            this.Guna2RadioButton1.Size = new System.Drawing.Size(75, 19);
            this.Guna2RadioButton1.TabIndex = 500;
            this.Guna2RadioButton1.Text = "By Model";
            this.Guna2RadioButton1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2RadioButton1.UncheckedState.BorderThickness = 3;
            this.Guna2RadioButton1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2RadioButton1.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2RadioButton1.CheckedChanged += new System.EventHandler(this.Guna2RadioButton1_CheckedChanged);
            // 
            // Guna2RadioButton2
            // 
            this.Guna2RadioButton2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Guna2RadioButton2.Animated = true;
            this.Guna2RadioButton2.AutoSize = true;
            this.Guna2RadioButton2.Checked = true;
            this.Guna2RadioButton2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2RadioButton2.CheckedState.BorderThickness = 3;
            this.Guna2RadioButton2.CheckedState.FillColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2RadioButton2.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(99)))), ((int)(((byte)(129)))));
            this.Guna2RadioButton2.CheckedState.InnerOffset = -6;
            this.Guna2RadioButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guna2RadioButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2RadioButton2.ForeColor = System.Drawing.Color.White;
            this.Guna2RadioButton2.Location = new System.Drawing.Point(15, 9);
            this.Guna2RadioButton2.Name = "Guna2RadioButton2";
            this.Guna2RadioButton2.Size = new System.Drawing.Size(63, 19);
            this.Guna2RadioButton2.TabIndex = 474;
            this.Guna2RadioButton2.TabStop = true;
            this.Guna2RadioButton2.Text = "By CPU";
            this.Guna2RadioButton2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2RadioButton2.UncheckedState.BorderThickness = 3;
            this.Guna2RadioButton2.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2RadioButton2.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2RadioButton2.CheckedChanged += new System.EventHandler(this.Guna2RadioButton2_CheckedChanged);
            // 
            // kirin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(496, 534);
            this.Controls.Add(this.Panel_Kirin);
            this.Controls.Add(this.ComboBoxBoot);
            this.Controls.Add(this.Panel_SPD);
            this.Controls.Add(this.Button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "kirin";
            this.ShowInTaskbar = false;
            this.Text = "kirin";
            this.Guna2TabControl1.ResumeLayout(false);
            this.TabPage2.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.Guna2GroupBox1.ResumeLayout(false);
            this.Guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataViewmtk)).EndInit();
            this.Guna2GroupBox2.ResumeLayout(false);
            this.Guna2GroupBox2.PerformLayout();
            this.Model.ResumeLayout(false);
            this.Panel_SPD.ResumeLayout(false);
            this.Guna2GroupBox3.ResumeLayout(false);
            this.Panel_Kirin.ResumeLayout(false);
            this.Guna2GroupBox5.ResumeLayout(false);
            this.Guna2TabControl2.ResumeLayout(false);
            this.TabPage4.ResumeLayout(false);
            this.TabPage3.ResumeLayout(false);
            this.Guna2GroupBox4.ResumeLayout(false);
            this.Guna2GroupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.Guna2GroupBox6.ResumeLayout(false);
            this.Guna2GroupBox6.PerformLayout();
            this.Guna2GroupBox7.ResumeLayout(false);
            this.ResumeLayout(false);

	}

	private void kirin_Load(object sender, EventArgs e)
	{
	}

	[DllImport("user32.dll", SetLastError = true)]
	private static extern bool PrintWindow(IntPtr hWnd, IntPtr hdcBlt, uint nFlags);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern bool GetWindowRect(IntPtr hWnd, ref RECT lpRect);

	[DllImport("user32.dll")]
	private static extern bool GetClientRect(IntPtr hWnd, ref RECT lpRect);

	private void CaptureWindow(IntPtr hWnd, string savePath)
	{
		RECT lpRect = default(RECT);
		GetWindowRect(hWnd, ref lpRect);
		checked
		{
			int num = lpRect.Right - lpRect.Left;
			int num2 = lpRect.Bottom - lpRect.Top;
			Bitmap bitmap = new Bitmap(num, num2, PixelFormat.Format32bppArgb);
			using (Graphics graphics = Graphics.FromImage(bitmap))
			{
				IntPtr hdc = graphics.GetHdc();
				PrintWindow(hWnd, hdc, 0u);
				graphics.ReleaseHdc(hdc);
			}
			bitmap.Save(savePath, ImageFormat.Png);
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		CaptureWindow(base.Handle, "C:\\Screenshot.png");
	}

	private void ComboBoxBoot_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (ComboBoxBoot.SelectedIndex == 0)
		{
			Panel_SPD.Visible = true;
			Panel_Kirin.Visible = false;
		}
		if (ComboBoxBoot.SelectedIndex == 1)
		{
			Panel_SPD.Visible = false;
			Panel_Kirin.Visible = true;
		}
	}

	private void Guna2RadioButton2_CheckedChanged(object sender, EventArgs e)
	{
		LIST_KIRIN.Items.Clear();
		LIST_KIRIN.Items.Add("Hisi65X");
		LIST_KIRIN.Items.Add("Hisi620");
		LIST_KIRIN.Items.Add("Hisi620C");
		LIST_KIRIN.Items.Add("Hisi710");
		LIST_KIRIN.Items.Add("Hisi710_V2");
		LIST_KIRIN.Items.Add("Hisi710F");
		LIST_KIRIN.Items.Add("Hisi710F_V2");
		LIST_KIRIN.Items.Add("Hisi710F_V3");
		LIST_KIRIN.Items.Add("Hisi810");
		LIST_KIRIN.Items.Add("Hisi925");
		LIST_KIRIN.Items.Add("Hisi930");
		LIST_KIRIN.Items.Add("Hisi935");
		LIST_KIRIN.Items.Add("Hisi950");
		LIST_KIRIN.Items.Add("Hisi955");
		LIST_KIRIN.Items.Add("Hisi960");
		LIST_KIRIN.Items.Add("Hisi970");
		LIST_KIRIN.Items.Add("Hisi970_V2");
		LIST_KIRIN.Items.Add("Hisi980");
		LIST_KIRIN.Items.Add("Hisi980_V2");
	}

	private void Guna2RadioButton1_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void Guna2RadioButton4_CheckedChanged(object sender, EventArgs e)
	{
		Brand.Enabled = false;
		LIST_SPD.Items.Clear();
		LIST_SPD.Items.Add("SC7731E");
		LIST_SPD.Items.Add("SC9832E");
		LIST_SPD.Items.Add("SC9863A");
		LIST_SPD.Items.Add("SC9863A_64");
		LIST_SPD.Items.Add("Tiger T310_64");
		LIST_SPD.Items.Add("Tiger T606_64");
		LIST_SPD.Items.Add("Tiger T610_64");
		LIST_SPD.Items.Add("Tiger T612_64");
		LIST_SPD.Items.Add("Tiger T616_64");
		LIST_SPD.Items.Add("Tiger T700_64");
	}

	private void Guna2RadioButton11_CheckedChanged(object sender, EventArgs e)
	{
		Brand.Enabled = true;
	}

	private void Brand_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	private void Guna2Button7_Click(object sender, EventArgs e)
	{
		ConnectKirin();
	}

	public void ConnectKirin()
	{
		string filename = "UnlockFiles\\" + LIST_KIRIN.SelectedItem.ToString() + "\\manifest.xml";
		string port = "COM3";
		HISI.FlashBootloader(Bootloader.ParseBootloader(filename), port);
		if (HISI.fb.Connect())
		{
			HISI.UnlockFRP();
		}
		HISI.Reboot();
		HISI.fb.Disconnect();
	}

  
}
