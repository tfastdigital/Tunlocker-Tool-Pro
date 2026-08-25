using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
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

namespace motoulocked;

[DesignerGenerated]
public class EDL : Form
{
	private IContainer components;

	[CompilerGenerated]
	[AccessedThroughProperty("Timer2")]
	private System.Windows.Forms.Timer _Timer2;

	[CompilerGenerated]
	[AccessedThroughProperty("ComboBoxBrand")]
	private Guna2ComboBox _ComboBoxBrand;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2Button15")]
	private Guna2Button _Guna2Button15;

	[CompilerGenerated]
	[AccessedThroughProperty("ComboBoxModel")]
	private ListBox _ComboBoxModel;

	[CompilerGenerated]
	[AccessedThroughProperty("CkAutoSwitchHighSpeedUSB")]
	private Guna2CheckBox _CkAutoSwitchHighSpeedUSB;

	[CompilerGenerated]
	[AccessedThroughProperty("BtnIdentify")]
	private Guna2Button _BtnIdentify;

	[CompilerGenerated]
	[AccessedThroughProperty("DataView")]
	private DataGridView _DataView;

	[CompilerGenerated]
	[AccessedThroughProperty("buttonerase")]
	private Guna2Button _buttonerase;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2RadioButton11")]
	private Guna2RadioButton _Guna2RadioButton11;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2RadioButton4")]
	private Guna2RadioButton _Guna2RadioButton4;

	[CompilerGenerated]
	[AccessedThroughProperty("cbsetboot")]
	private Guna2CheckBox _cbsetboot;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2Button1")]
	private Guna2Button _Guna2Button1;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2CheckBox5")]
	private Guna2CheckBox _Guna2CheckBox5;

	[CompilerGenerated]
	[AccessedThroughProperty("DataGridView1")]
	private DataGridView _DataGridView1;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2Button11")]
	private Guna2Button _Guna2Button11;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2Button6")]
	private Guna2Button _Guna2Button6;

	[CompilerGenerated]
	[AccessedThroughProperty("cbstorage")]
	private ComboBox _cbstorage;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2Button5")]
	private Guna2Button _Guna2Button5;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2Button4")]
	private Guna2Button _Guna2Button4;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2Button3")]
	private Guna2Button _Guna2Button3;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2Button2")]
	private Guna2Button _Guna2Button2;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2Button9")]
	private Guna2Button _Guna2Button9;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2Button10")]
	private Guna2Button _Guna2Button10;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2Button7")]
	private Guna2Button _Guna2Button7;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2Button12")]
	private Guna2Button _Guna2Button12;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2Button8")]
	private Guna2Button _Guna2Button8;

	public static EDL SharedEDL;

	public static string Link_Loader;

	public static string String_14;

	public static string String_12;

	public static string ProgressChanged;

	public static string cancel;

	public static string String_35;

	public static string String_75;

	public static string String_24;

	private string Log;

	private Thread ThreadNew;

	public static string ThisLocation = AppDomain.CurrentDomain.BaseDirectory;

	private string idproos;

	private string startTime;

	private bool Boolean_2;

	private string loder_temp;

	private string namefile;

	public static string nameXML;

	private string tmpwin;

	private string text22;
	/*
	[field: AccessedThroughProperty("ComboBoxUSB")]
	internal  Guna2ComboBox ComboBoxUSB
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

	[field: AccessedThroughProperty("RichTextBox2")]
	internal  RichTextBox RichTextBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal  Guna2ComboBox ComboBoxBrand
	{
		[CompilerGenerated]
		get
		{
			return _ComboBoxBrand;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ComboBoxBrand_SelectedIndexChanged;
			Guna2ComboBox comboBoxBrand = _ComboBoxBrand;
			if (comboBoxBrand != null)
			{
				comboBoxBrand.SelectedIndexChanged -= value2;
			}
			_ComboBoxBrand = value;
			comboBoxBrand = _ComboBoxBrand;
			if (comboBoxBrand != null)
			{
				comboBoxBrand.SelectedIndexChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Guna2GroupBox2")]
	internal  Guna2GroupBox Guna2GroupBox2
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

	[field: AccessedThroughProperty("txtloader")]
	internal  Guna2TextBox txtloader
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Model")]
	internal  Guna2GroupBox Model
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal  ListBox ComboBoxModel
	{
		[CompilerGenerated]
		get
		{
			return _ComboBoxModel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ComboBoxModel_SelectedIndexChanged;
			ListBox comboBoxModel = _ComboBoxModel;
			if (comboBoxModel != null)
			{
				comboBoxModel.SelectedIndexChanged -= value2;
			}
			_ComboBoxModel = value;
			comboBoxModel = _ComboBoxModel;
			if (comboBoxModel != null)
			{
				comboBoxModel.SelectedIndexChanged += value2;
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

	[field: AccessedThroughProperty("Guna2RadioButton8")]
	internal  Guna2RadioButton Guna2RadioButton8
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

	[field: AccessedThroughProperty("Guna2RadioButton6")]
	internal  Guna2RadioButton Guna2RadioButton6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal  Guna2CheckBox CkAutoSwitchHighSpeedUSB
	{
		[CompilerGenerated]
		get
		{
			return _CkAutoSwitchHighSpeedUSB;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = CkAutoSwitchHighSpeedUSB_CheckedChanged;
			Guna2CheckBox ckAutoSwitchHighSpeedUSB = _CkAutoSwitchHighSpeedUSB;
			if (ckAutoSwitchHighSpeedUSB != null)
			{
				ckAutoSwitchHighSpeedUSB.CheckedChanged -= value2;
			}
			_CkAutoSwitchHighSpeedUSB = value;
			ckAutoSwitchHighSpeedUSB = _CkAutoSwitchHighSpeedUSB;
			if (ckAutoSwitchHighSpeedUSB != null)
			{
				ckAutoSwitchHighSpeedUSB.CheckedChanged += value2;
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

	[field: AccessedThroughProperty("Guna2GroupBox1")]
	internal  Guna2GroupBox Guna2GroupBox1
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

	internal  DataGridView DataView
	{
		[CompilerGenerated]
		get
		{
			return _DataView;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DataGridViewCellEventHandler value2 = DataView_CellDoubleClick;
			DataGridView dataView = _DataView;
			if (dataView != null)
			{
				dataView.CellDoubleClick -= value2;
			}
			_DataView = value;
			dataView = _DataView;
			if (dataView != null)
			{
				dataView.CellDoubleClick += value2;
			}
		}
	}

	internal  Guna2Button buttonerase
	{
		[CompilerGenerated]
		get
		{
			return _buttonerase;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = buttonerase_Click;
			Guna2Button guna2Button = _buttonerase;
			if (guna2Button != null)
			{
				guna2Button.Click -= value2;
			}
			_buttonerase = value;
			guna2Button = _buttonerase;
			if (guna2Button != null)
			{
				guna2Button.Click += value2;
			}
		}
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

	internal  Guna2CheckBox cbsetboot
	{
		[CompilerGenerated]
		get
		{
			return _cbsetboot;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = cbsetboot_CheckedChanged;
			Guna2CheckBox guna2CheckBox = _cbsetboot;
			if (guna2CheckBox != null)
			{
				guna2CheckBox.CheckedChanged -= value2;
			}
			_cbsetboot = value;
			guna2CheckBox = _cbsetboot;
			if (guna2CheckBox != null)
			{
				guna2CheckBox.CheckedChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("cbreboot")]
	internal  Guna2CheckBox cbreboot
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

	internal  Guna2CheckBox Guna2CheckBox5
	{
		[CompilerGenerated]
		get
		{
			return _Guna2CheckBox5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Guna2CheckBox5_CheckedChanged;
			Guna2CheckBox guna2CheckBox = _Guna2CheckBox5;
			if (guna2CheckBox != null)
			{
				guna2CheckBox.CheckedChanged -= value2;
			}
			_Guna2CheckBox5 = value;
			guna2CheckBox = _Guna2CheckBox5;
			if (guna2CheckBox != null)
			{
				guna2CheckBox.CheckedChanged += value2;
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

	internal  DataGridView DataGridView1
	{
		[CompilerGenerated]
		get
		{
			return _DataGridView1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DataGridViewCellEventHandler value2 = DataGridView1_CellDoubleClick;
			DataGridView dataGridView = _DataGridView1;
			if (dataGridView != null)
			{
				dataGridView.CellDoubleClick -= value2;
			}
			_DataGridView1 = value;
			dataGridView = _DataGridView1;
			if (dataGridView != null)
			{
				dataGridView.CellDoubleClick += value2;
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

	[field: AccessedThroughProperty("txtrawxml")]
	internal  Guna2TextBox txtrawxml
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	public  ComboBox cbstorage
	{
		[CompilerGenerated]
		get
		{
			return _cbstorage;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = cbstorage_SelectedIndexChanged;
			ComboBox comboBox = _cbstorage;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
			}
			_cbstorage = value;
			comboBox = _cbstorage;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged += value2;
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

	[field: AccessedThroughProperty("ComboBoxSecurity")]
	internal  Guna2ComboBox ComboBoxSecurity
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

	[field: AccessedThroughProperty("Guna2ComboBox1")]
	internal  Guna2ComboBox Guna2ComboBox1
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

	[field: AccessedThroughProperty("label")]
	internal  DataGridViewTextBoxColumn label
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("filename")]
	internal  DataGridViewTextBoxColumn filename
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("start_sector")]
	internal  DataGridViewTextBoxColumn start_sector
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("num_partition_sectors")]
	internal  DataGridViewTextBoxColumn num_partition_sectors
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("physical_partition_number")]
	internal  DataGridViewTextBoxColumn physical_partition_number
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("SECTOR_SIZE_IN_BYTE")]
	internal  DataGridViewTextBoxColumn SECTOR_SIZE_IN_BYTE
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



	[field: AccessedThroughProperty("String_29")]
	public  WebClient String_29
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}
	*/
	public WebClient String_29;

    public ComboBox cbstorage;
    public static string LoadFolderXml { get; set; }

    public static string _hwid { get; set; }
    internal Guna2ComboBox ComboBoxUSB;
    internal System.Windows.Forms.Timer Timer2;
    internal RichTextBox RichTextBox2;
    internal Guna2ComboBox ComboBoxBrand;
    internal Guna2GroupBox Guna2GroupBox2;
    internal Guna2Button Guna2Button15;
    internal Guna2TextBox txtloader;
    internal Guna2GroupBox Model;
    internal ListBox ComboBoxModel;
    internal motoulocked.Controls.TabControlExt TabControlExt1;
    internal TabPage TabPage2;
    internal TabPage TabPage3;
    internal TabPage TabPage4;
    internal Guna2RadioButton Guna2RadioButton8;
    internal Guna2RadioButton Guna2RadioButton7;
    internal Guna2RadioButton Guna2RadioButton6;
    internal Guna2CheckBox CkAutoSwitchHighSpeedUSB;
    internal Guna2Button BtnIdentify;
    internal Guna2GroupBox Guna2GroupBox1;
    internal Guna2VScrollBar Guna2VScrollBar2;
    internal DataGridView DataView;
    internal Guna2Button buttonerase;
    internal Guna2RadioButton Guna2RadioButton11;
    internal Guna2RadioButton Guna2RadioButton4;
    internal Guna2CheckBox cbsetboot;
    internal Guna2CheckBox cbreboot;
    internal Guna2Button Guna2Button1;
    internal Guna2CheckBox Guna2CheckBox5;
    internal Guna2GroupBox Guna2GroupBox9;
    internal Guna2VScrollBar Guna2VScrollBar1;
    internal DataGridView DataGridView1;
    internal Guna2Button Guna2Button11;
    internal Guna2TextBox txtrawxml;
    internal Guna2Button Guna2Button6;
    internal Guna2Button Guna2Button5;
    internal Guna2Button Guna2Button4;
    internal Guna2Button Guna2Button3;
    internal Guna2Button Guna2Button2;
    internal Guna2Button Guna2Button9;
    internal Guna2ComboBox ComboBoxSecurity;
    internal Guna2Button Guna2Button10;
    internal Guna2ComboBox Guna2ComboBox1;
    internal DataGridViewCheckBoxColumn Column0;
    internal DataGridViewTextBoxColumn label;
    internal DataGridViewTextBoxColumn filename;
    internal DataGridViewTextBoxColumn start_sector;
    internal DataGridViewTextBoxColumn num_partition_sectors;
    internal DataGridViewTextBoxColumn physical_partition_number;
    internal DataGridViewTextBoxColumn SECTOR_SIZE_IN_BYTE;
    internal DataGridViewTextBoxColumn Column2;
    internal DataGridViewCheckBoxColumn DataGridViewCheckBoxColumn1;
    internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
    internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn2;
    internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn3;
    internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn4;
    internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn5;
    internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn6;
    internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn7;
    internal Guna2Button Guna2Button7;
    internal Guna2Button Guna2Button12;
    internal Guna2Button Guna2Button8;

    public static string _username { get; set; }

	public static byte[] OutDecripted { get; set; }

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EDL));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ComboBoxUSB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.RichTextBox2 = new System.Windows.Forms.RichTextBox();
            this.ComboBoxBrand = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.Model = new Guna.UI2.WinForms.Guna2GroupBox();
            this.ComboBoxModel = new System.Windows.Forms.ListBox();
            this.Guna2Button15 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2RadioButton11 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.Guna2RadioButton4 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.txtloader = new Guna.UI2.WinForms.Guna2TextBox();
            this.Timer2 = new System.Windows.Forms.Timer(this.components);
            this.TabControlExt1 = new motoulocked.Controls.TabControlExt();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.Guna2Button12 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2Button8 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2Button7 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2Button10 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Guna2Button9 = new Guna.UI2.WinForms.Guna2Button();
            this.ComboBoxSecurity = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
            this.TabPage3 = new System.Windows.Forms.TabPage();
            this.Guna2RadioButton8 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.BtnIdentify = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2RadioButton7 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.buttonerase = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2RadioButton6 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.Guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.Guna2VScrollBar2 = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.DataView = new System.Windows.Forms.DataGridView();
            this.Column0 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.start_sector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_partition_sectors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.physical_partition_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SECTOR_SIZE_IN_BYTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CkAutoSwitchHighSpeedUSB = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cbreboot = new Guna.UI2.WinForms.Guna2CheckBox();
            this.TabPage4 = new System.Windows.Forms.TabPage();
            this.cbsetboot = new Guna.UI2.WinForms.Guna2CheckBox();
            this.Guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2CheckBox5 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.Guna2GroupBox9 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.Guna2VScrollBar1 = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.DataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Guna2Button11 = new Guna.UI2.WinForms.Guna2Button();
            this.txtrawxml = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbstorage = new System.Windows.Forms.ComboBox();
            this.Guna2GroupBox2.SuspendLayout();
            this.Model.SuspendLayout();
            this.TabControlExt1.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.TabPage3.SuspendLayout();
            this.Guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).BeginInit();
            this.TabPage4.SuspendLayout();
            this.Guna2GroupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ComboBoxUSB
            // 
            this.ComboBoxUSB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ComboBoxUSB.BorderRadius = 4;
            this.ComboBoxUSB.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.ComboBoxUSB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxUSB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxUSB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxUSB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxUSB.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.ComboBoxUSB.ForeColor = System.Drawing.Color.Black;
            this.ComboBoxUSB.FormattingEnabled = true;
            this.ComboBoxUSB.ItemHeight = 30;
            this.ComboBoxUSB.Location = new System.Drawing.Point(1524, 322);
            this.ComboBoxUSB.Name = "ComboBoxUSB";
            this.ComboBoxUSB.ShadowDecoration.BorderRadius = 4;
            this.ComboBoxUSB.ShadowDecoration.Depth = 7;
            this.ComboBoxUSB.Size = new System.Drawing.Size(10, 36);
            this.ComboBoxUSB.TabIndex = 474;
            this.ComboBoxUSB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RichTextBox2
            // 
            this.RichTextBox2.Location = new System.Drawing.Point(1524, 333);
            this.RichTextBox2.Name = "RichTextBox2";
            this.RichTextBox2.Size = new System.Drawing.Size(10, 10);
            this.RichTextBox2.TabIndex = 482;
            this.RichTextBox2.Text = "";
            this.RichTextBox2.Visible = false;
            // 
            // ComboBoxBrand
            // 
            this.ComboBoxBrand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ComboBoxBrand.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.ComboBoxBrand.BorderRadius = 4;
            this.ComboBoxBrand.BorderThickness = 2;
            this.ComboBoxBrand.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ComboBoxBrand.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ComboBoxBrand.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.ComboBoxBrand.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxBrand.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ComboBoxBrand.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxBrand.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxBrand.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBoxBrand.ForeColor = System.Drawing.Color.White;
            this.ComboBoxBrand.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.ComboBoxBrand.ItemHeight = 26;
            this.ComboBoxBrand.Items.AddRange(new object[] {
            "Samsung",
            "Realme",
            "Xiaomi",
            "Huawei",
            "LGE",
            "Oppo",
            "Vivo",
            "Sugar",
            "General"});
            this.ComboBoxBrand.ItemsAppearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.ComboBoxBrand.ItemsAppearance.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxBrand.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.ComboBoxBrand.Location = new System.Drawing.Point(8, 9);
            this.ComboBoxBrand.MaxDropDownItems = 5;
            this.ComboBoxBrand.MaxLength = 5;
            this.ComboBoxBrand.Name = "ComboBoxBrand";
            this.ComboBoxBrand.Size = new System.Drawing.Size(291, 32);
            this.ComboBoxBrand.StartIndex = 0;
            this.ComboBoxBrand.TabIndex = 514;
            this.ComboBoxBrand.SelectedIndexChanged += new System.EventHandler(this.ComboBoxBrand_SelectedIndexChanged);
            // 
            // Guna2GroupBox2
            // 
            this.Guna2GroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.Guna2GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Guna2GroupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2GroupBox2.BorderRadius = 6;
            this.Guna2GroupBox2.Controls.Add(this.Model);
            this.Guna2GroupBox2.Controls.Add(this.Guna2Button15);
            this.Guna2GroupBox2.Controls.Add(this.Guna2RadioButton11);
            this.Guna2GroupBox2.Controls.Add(this.Guna2RadioButton4);
            this.Guna2GroupBox2.Controls.Add(this.ComboBoxBrand);
            this.Guna2GroupBox2.Controls.Add(this.txtloader);
            this.Guna2GroupBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2GroupBox2.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.Guna2GroupBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Guna2GroupBox2.Location = new System.Drawing.Point(8, 8);
            this.Guna2GroupBox2.Name = "Guna2GroupBox2";
            this.Guna2GroupBox2.ShadowDecoration.BorderRadius = 9;
            this.Guna2GroupBox2.ShadowDecoration.Color = System.Drawing.Color.White;
            this.Guna2GroupBox2.ShadowDecoration.Depth = 15;
            this.Guna2GroupBox2.Size = new System.Drawing.Size(480, 196);
            this.Guna2GroupBox2.TabIndex = 515;
            // 
            // Model
            // 
            this.Model.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Model.BackColor = System.Drawing.Color.Transparent;
            this.Model.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Model.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Model.BorderThickness = 2;
            this.Model.Controls.Add(this.ComboBoxModel);
            this.Model.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Model.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Model.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.Model.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Model.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Model.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Model.Location = new System.Drawing.Point(8, 47);
            this.Model.Name = "Model";
            this.Model.ShadowDecoration.BorderRadius = 9;
            this.Model.ShadowDecoration.Color = System.Drawing.Color.White;
            this.Model.ShadowDecoration.Depth = 15;
            this.Model.Size = new System.Drawing.Size(464, 146);
            this.Model.TabIndex = 521;
            // 
            // ComboBoxModel
            // 
            this.ComboBoxModel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ComboBoxModel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ComboBoxModel.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxModel.ForeColor = System.Drawing.Color.White;
            this.ComboBoxModel.FormattingEnabled = true;
            this.ComboBoxModel.ItemHeight = 17;
            this.ComboBoxModel.Location = new System.Drawing.Point(2, 3);
            this.ComboBoxModel.Name = "ComboBoxModel";
            this.ComboBoxModel.Size = new System.Drawing.Size(458, 136);
            this.ComboBoxModel.TabIndex = 520;
            this.ComboBoxModel.SelectedIndexChanged += new System.EventHandler(this.ComboBoxModel_SelectedIndexChanged);
            // 
            // Guna2Button15
            // 
            this.Guna2Button15.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Guna2Button15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
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
            this.Guna2Button15.Location = new System.Drawing.Point(424, 161);
            this.Guna2Button15.Name = "Guna2Button15";
            this.Guna2Button15.PressedColor = System.Drawing.Color.Empty;
            this.Guna2Button15.Size = new System.Drawing.Size(48, 26);
            this.Guna2Button15.TabIndex = 518;
            this.Guna2Button15.TextFormatNoPrefix = true;
            this.Guna2Button15.Click += new System.EventHandler(this.Guna2Button15_Click);
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
            this.Guna2RadioButton11.Location = new System.Drawing.Point(388, 16);
            this.Guna2RadioButton11.Name = "Guna2RadioButton11";
            this.Guna2RadioButton11.Size = new System.Drawing.Size(85, 19);
            this.Guna2RadioButton11.TabIndex = 500;
            this.Guna2RadioButton11.Text = "By Firehose";
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
            this.Guna2RadioButton4.Location = new System.Drawing.Point(307, 16);
            this.Guna2RadioButton4.Name = "Guna2RadioButton4";
            this.Guna2RadioButton4.Size = new System.Drawing.Size(75, 19);
            this.Guna2RadioButton4.TabIndex = 474;
            this.Guna2RadioButton4.TabStop = true;
            this.Guna2RadioButton4.Text = "By Model";
            this.Guna2RadioButton4.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2RadioButton4.UncheckedState.BorderThickness = 3;
            this.Guna2RadioButton4.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2RadioButton4.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2RadioButton4.CheckedChanged += new System.EventHandler(this.Guna2RadioButton4_CheckedChanged);
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
            this.txtloader.Location = new System.Drawing.Point(8, 161);
            this.txtloader.Name = "txtloader";
            this.txtloader.PasswordChar = '\0';
            this.txtloader.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtloader.PlaceholderText = "Loader";
            this.txtloader.SelectedText = "";
            this.txtloader.ShadowDecoration.Color = System.Drawing.Color.DimGray;
            this.txtloader.ShadowDecoration.Depth = 15;
            this.txtloader.Size = new System.Drawing.Size(410, 26);
            this.txtloader.TabIndex = 519;
            this.txtloader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtloader.TextChanged += new System.EventHandler(this.txtloader_TextChanged);
            // 
            // Timer2
            // 
            this.Timer2.Enabled = true;
            // 
            // TabControlExt1
            // 
            this.TabControlExt1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TabControlExt1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TabControlExt1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.TabControlExt1.CloseBtnColor = System.Drawing.Color.White;
            this.TabControlExt1.Controls.Add(this.TabPage2);
            this.TabControlExt1.Controls.Add(this.TabPage3);
            this.TabControlExt1.Controls.Add(this.TabPage4);
            this.TabControlExt1.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControlExt1.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.TabControlExt1.HeadSelectedBackColor = System.Drawing.Color.FromArgb(0, 85, 207);
            this.TabControlExt1.HeadSelectedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.TabControlExt1.IsShowCloseBtn = false;
            this.TabControlExt1.ItemSize = new System.Drawing.Size(0, 26);
            this.TabControlExt1.Location = new System.Drawing.Point(8, 208);
            this.TabControlExt1.Name = "TabControlExt1";
            this.TabControlExt1.SelectedIndex = 0;
            this.TabControlExt1.Size = new System.Drawing.Size(480, 318);
            this.TabControlExt1.TabIndex = 525;
            this.TabControlExt1.TabTextColor = System.Drawing.Color.White;
            this.TabControlExt1.UncloseTabIndexs = null;
            // 
            // TabPage2
            // 
            this.TabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TabPage2.Controls.Add(this.Guna2Button12);
            this.TabPage2.Controls.Add(this.Guna2Button8);
            this.TabPage2.Controls.Add(this.Guna2Button7);
            this.TabPage2.Controls.Add(this.Guna2Button10);
            this.TabPage2.Controls.Add(this.Guna2ComboBox1);
            this.TabPage2.Controls.Add(this.Guna2Button9);
            this.TabPage2.Controls.Add(this.ComboBoxSecurity);
            this.TabPage2.Controls.Add(this.Guna2Button5);
            this.TabPage2.Controls.Add(this.Guna2Button4);
            this.TabPage2.Controls.Add(this.Guna2Button3);
            this.TabPage2.Controls.Add(this.Guna2Button2);
            this.TabPage2.Controls.Add(this.Guna2Button6);
            this.TabPage2.Location = new System.Drawing.Point(4, 30);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(472, 284);
            this.TabPage2.TabIndex = 0;
            this.TabPage2.Text = "Services";
            // 
            // Guna2Button12
            // 
            this.Guna2Button12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Guna2Button12.Animated = true;
            this.Guna2Button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2Button12.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2Button12.BorderRadius = 4;
            this.Guna2Button12.BorderThickness = 2;
            this.Guna2Button12.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button12.CheckedState.FillColor = System.Drawing.Color.LightGray;
            this.Guna2Button12.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button12.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
            this.Guna2Button12.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button12.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.Guna2Button12.Enabled = false;
            this.Guna2Button12.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2Button12.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Guna2Button12.ForeColor = System.Drawing.Color.White;
            this.Guna2Button12.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button12.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button12.Image = global::Properties.Resources.Samsung_Knox;
            this.Guna2Button12.ImageSize = new System.Drawing.Size(28, 17);
            this.Guna2Button12.Location = new System.Drawing.Point(239, 125);
            this.Guna2Button12.Name = "Guna2Button12";
            this.Guna2Button12.PressedColor = System.Drawing.Color.Empty;
            this.Guna2Button12.Size = new System.Drawing.Size(225, 33);
            this.Guna2Button12.TabIndex = 548;
            this.Guna2Button12.Text = "Remove Knox | KG (Fast)";
            this.Guna2Button12.TextFormatNoPrefix = true;
            this.Guna2Button12.Click += new System.EventHandler(this.Guna2Button12_Click);
            // 
            // Guna2Button8
            // 
            this.Guna2Button8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Guna2Button8.Animated = true;
            this.Guna2Button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2Button8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2Button8.BorderRadius = 4;
            this.Guna2Button8.BorderThickness = 2;
            this.Guna2Button8.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button8.CheckedState.FillColor = System.Drawing.Color.LightGray;
            this.Guna2Button8.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button8.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
            this.Guna2Button8.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button8.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.Guna2Button8.Enabled = false;
            this.Guna2Button8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2Button8.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Guna2Button8.ForeColor = System.Drawing.Color.White;
            this.Guna2Button8.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button8.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button8.Image = global::Properties.Resources.kyrgyzstan;
            this.Guna2Button8.ImageSize = new System.Drawing.Size(22, 25);
            this.Guna2Button8.Location = new System.Drawing.Point(239, 86);
            this.Guna2Button8.Name = "Guna2Button8";
            this.Guna2Button8.PressedColor = System.Drawing.Color.Empty;
            this.Guna2Button8.Size = new System.Drawing.Size(225, 33);
            this.Guna2Button8.TabIndex = 547;
            this.Guna2Button8.Text = "Remove KG (New)";
            this.Guna2Button8.TextFormatNoPrefix = true;
            this.Guna2Button8.Click += new System.EventHandler(this.Guna2Button8_Click);
            // 
            // Guna2Button7
            // 
            this.Guna2Button7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Guna2Button7.Animated = true;
            this.Guna2Button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2Button7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2Button7.BorderRadius = 4;
            this.Guna2Button7.BorderThickness = 2;
            this.Guna2Button7.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button7.CheckedState.FillColor = System.Drawing.Color.LightGray;
            this.Guna2Button7.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button7.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
            this.Guna2Button7.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button7.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.Guna2Button7.Enabled = false;
            this.Guna2Button7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2Button7.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Guna2Button7.ForeColor = System.Drawing.Color.White;
            this.Guna2Button7.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button7.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button7.Image = global::Properties.Resources.Samsung_Knox;
            this.Guna2Button7.ImageSize = new System.Drawing.Size(28, 17);
            this.Guna2Button7.Location = new System.Drawing.Point(239, 47);
            this.Guna2Button7.Name = "Guna2Button7";
            this.Guna2Button7.PressedColor = System.Drawing.Color.Empty;
            this.Guna2Button7.Size = new System.Drawing.Size(225, 33);
            this.Guna2Button7.TabIndex = 546;
            this.Guna2Button7.Text = "Remove Knox (New)";
            this.Guna2Button7.TextFormatNoPrefix = true;
            this.Guna2Button7.Click += new System.EventHandler(this.Guna2Button7_Click);
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
            this.Guna2Button10.Image = global::Properties.Resources.broom__1_;
            this.Guna2Button10.ImageSize = new System.Drawing.Size(25, 25);
            this.Guna2Button10.Location = new System.Drawing.Point(9, 241);
            this.Guna2Button10.Name = "Guna2Button10";
            this.Guna2Button10.PressedColor = System.Drawing.Color.Empty;
            this.Guna2Button10.Size = new System.Drawing.Size(224, 32);
            this.Guna2Button10.TabIndex = 544;
            this.Guna2Button10.Text = " Start =>";
            this.Guna2Button10.TextFormatNoPrefix = true;
            this.Guna2Button10.Click += new System.EventHandler(this.Guna2Button10_Click);
            // 
            // Guna2ComboBox1
            // 
            this.Guna2ComboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Guna2ComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
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
            "Factory Reset (EXT4)",
            "Factory Reset (Misc)"});
            this.Guna2ComboBox1.ItemsAppearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2ComboBox1.ItemsAppearance.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2ComboBox1.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2ComboBox1.Location = new System.Drawing.Point(239, 241);
            this.Guna2ComboBox1.MaxDropDownItems = 5;
            this.Guna2ComboBox1.MaxLength = 5;
            this.Guna2ComboBox1.Name = "Guna2ComboBox1";
            this.Guna2ComboBox1.Size = new System.Drawing.Size(225, 32);
            this.Guna2ComboBox1.StartIndex = 0;
            this.Guna2ComboBox1.TabIndex = 545;
            // 
            // Guna2Button9
            // 
            this.Guna2Button9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Guna2Button9.Animated = true;
            this.Guna2Button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2Button9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2Button9.BorderRadius = 4;
            this.Guna2Button9.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.Guna2Button9.BorderThickness = 2;
            this.Guna2Button9.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button9.CheckedState.FillColor = System.Drawing.Color.LightGray;
            this.Guna2Button9.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
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
            this.Guna2Button9.Image = global::Properties.Resources.cogwheel__1_;
            this.Guna2Button9.ImageSize = new System.Drawing.Size(22, 22);
            this.Guna2Button9.Location = new System.Drawing.Point(9, 203);
            this.Guna2Button9.Name = "Guna2Button9";
            this.Guna2Button9.PressedColor = System.Drawing.Color.Empty;
            this.Guna2Button9.Size = new System.Drawing.Size(224, 32);
            this.Guna2Button9.TabIndex = 542;
            this.Guna2Button9.Text = " Start =>";
            this.Guna2Button9.TextFormatNoPrefix = true;
            this.Guna2Button9.Click += new System.EventHandler(this.Guna2Button9_Click);
            // 
            // ComboBoxSecurity
            // 
            this.ComboBoxSecurity.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            "Backup EFS",
            "Reset EFS"});
            this.ComboBoxSecurity.ItemsAppearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.ComboBoxSecurity.ItemsAppearance.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxSecurity.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.ComboBoxSecurity.Location = new System.Drawing.Point(239, 203);
            this.ComboBoxSecurity.MaxDropDownItems = 5;
            this.ComboBoxSecurity.MaxLength = 5;
            this.ComboBoxSecurity.Name = "ComboBoxSecurity";
            this.ComboBoxSecurity.Size = new System.Drawing.Size(225, 32);
            this.ComboBoxSecurity.StartIndex = 0;
            this.ComboBoxSecurity.TabIndex = 543;
            // 
            // Guna2Button5
            // 
            this.Guna2Button5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Guna2Button5.Animated = true;
            this.Guna2Button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2Button5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2Button5.BorderRadius = 4;
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
            this.Guna2Button5.Image = global::Properties.Resources.settings;
            this.Guna2Button5.Location = new System.Drawing.Point(9, 164);
            this.Guna2Button5.Name = "Guna2Button5";
            this.Guna2Button5.PressedColor = System.Drawing.Color.Empty;
            this.Guna2Button5.Size = new System.Drawing.Size(455, 33);
            this.Guna2Button5.TabIndex = 539;
            this.Guna2Button5.Text = "Reset Modems";
            this.Guna2Button5.TextFormatNoPrefix = true;
            this.Guna2Button5.Click += new System.EventHandler(this.Guna2Button5_Click);
            // 
            // Guna2Button4
            // 
            this.Guna2Button4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Guna2Button4.Animated = true;
            this.Guna2Button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2Button4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2Button4.BorderRadius = 4;
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
            this.Guna2Button4.Image = global::Properties.Resources.fingerprint;
            this.Guna2Button4.ImageSize = new System.Drawing.Size(25, 25);
            this.Guna2Button4.Location = new System.Drawing.Point(9, 125);
            this.Guna2Button4.Name = "Guna2Button4";
            this.Guna2Button4.PressedColor = System.Drawing.Color.Empty;
            this.Guna2Button4.Size = new System.Drawing.Size(224, 33);
            this.Guna2Button4.TabIndex = 538;
            this.Guna2Button4.Text = " Remove Huawei ID";
            this.Guna2Button4.TextFormatNoPrefix = true;
            this.Guna2Button4.Click += new System.EventHandler(this.Guna2Button4_Click);
            // 
            // Guna2Button3
            // 
            this.Guna2Button3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Guna2Button3.Animated = true;
            this.Guna2Button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2Button3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2Button3.BorderRadius = 4;
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
            this.Guna2Button3.Image = global::Properties.Resources.xiaomi__1_;
            this.Guna2Button3.Location = new System.Drawing.Point(9, 86);
            this.Guna2Button3.Name = "Guna2Button3";
            this.Guna2Button3.PressedColor = System.Drawing.Color.Empty;
            this.Guna2Button3.Size = new System.Drawing.Size(224, 33);
            this.Guna2Button3.TabIndex = 537;
            this.Guna2Button3.Text = " Remove Mi Acounnt M2";
            this.Guna2Button3.TextFormatNoPrefix = true;
            this.Guna2Button3.Click += new System.EventHandler(this.Guna2Button3_Click);
            // 
            // Guna2Button2
            // 
            this.Guna2Button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Guna2Button2.Animated = true;
            this.Guna2Button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2Button2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2Button2.BorderRadius = 4;
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
            this.Guna2Button2.Image = global::Properties.Resources.xiaomi__1_;
            this.Guna2Button2.Location = new System.Drawing.Point(9, 47);
            this.Guna2Button2.Name = "Guna2Button2";
            this.Guna2Button2.PressedColor = System.Drawing.Color.Empty;
            this.Guna2Button2.Size = new System.Drawing.Size(224, 33);
            this.Guna2Button2.TabIndex = 536;
            this.Guna2Button2.Text = " Remove Mi Acounnt (A-R)";
            this.Guna2Button2.TextFormatNoPrefix = true;
            this.Guna2Button2.Click += new System.EventHandler(this.Guna2Button2_Click);
            // 
            // Guna2Button6
            // 
            this.Guna2Button6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Guna2Button6.Animated = true;
            this.Guna2Button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2Button6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2Button6.BorderRadius = 4;
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
            this.Guna2Button6.Image = global::Properties.Resources.google__2_;
            this.Guna2Button6.Location = new System.Drawing.Point(9, 8);
            this.Guna2Button6.Name = "Guna2Button6";
            this.Guna2Button6.PressedColor = System.Drawing.Color.Empty;
            this.Guna2Button6.Size = new System.Drawing.Size(455, 33);
            this.Guna2Button6.TabIndex = 535;
            this.Guna2Button6.Text = " Remove FRP Lock";
            this.Guna2Button6.TextFormatNoPrefix = true;
            this.Guna2Button6.Click += new System.EventHandler(this.Guna2Button6_Click);
            // 
            // TabPage3
            // 
            this.TabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TabPage3.Controls.Add(this.Guna2RadioButton8);
            this.TabPage3.Controls.Add(this.BtnIdentify);
            this.TabPage3.Controls.Add(this.Guna2RadioButton7);
            this.TabPage3.Controls.Add(this.buttonerase);
            this.TabPage3.Controls.Add(this.Guna2RadioButton6);
            this.TabPage3.Controls.Add(this.Guna2GroupBox1);
            this.TabPage3.Controls.Add(this.CkAutoSwitchHighSpeedUSB);
            this.TabPage3.Controls.Add(this.cbreboot);
            this.TabPage3.Location = new System.Drawing.Point(4, 30);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage3.Size = new System.Drawing.Size(472, 284);
            this.TabPage3.TabIndex = 1;
            this.TabPage3.Text = "Partition Manger";
            // 
            // Guna2RadioButton8
            // 
            this.Guna2RadioButton8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
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
            this.Guna2RadioButton8.Location = new System.Drawing.Point(221, 254);
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
            this.BtnIdentify.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
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
            this.BtnIdentify.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.BtnIdentify.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnIdentify.ForeColor = System.Drawing.Color.White;
            this.BtnIdentify.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.BtnIdentify.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.BtnIdentify.Image = global::Properties.Resources.link;
            this.BtnIdentify.ImageSize = new System.Drawing.Size(22, 22);
            this.BtnIdentify.Location = new System.Drawing.Point(6, 218);
            this.BtnIdentify.Name = "BtnIdentify";
            this.BtnIdentify.PressedColor = System.Drawing.Color.Empty;
            this.BtnIdentify.Size = new System.Drawing.Size(460, 24);
            this.BtnIdentify.TabIndex = 496;
            this.BtnIdentify.Text = " List Partition";
            this.BtnIdentify.TextFormatNoPrefix = true;
            this.BtnIdentify.Click += new System.EventHandler(this.BtnIdentify_Click);
            // 
            // Guna2RadioButton7
            // 
            this.Guna2RadioButton7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
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
            this.Guna2RadioButton7.Location = new System.Drawing.Point(280, 254);
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
            this.buttonerase.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonerase.Animated = true;
            this.buttonerase.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.buttonerase.BorderRadius = 4;
            this.buttonerase.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.buttonerase.BorderThickness = 2;
            this.buttonerase.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonerase.CheckedState.FillColor = System.Drawing.Color.LightGray;
            this.buttonerase.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
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
            this.buttonerase.Location = new System.Drawing.Point(338, 248);
            this.buttonerase.Name = "buttonerase";
            this.buttonerase.PressedColor = System.Drawing.Color.Empty;
            this.buttonerase.Size = new System.Drawing.Size(128, 29);
            this.buttonerase.TabIndex = 523;
            this.buttonerase.Text = " Start Job";
            this.buttonerase.TextFormatNoPrefix = true;
            this.buttonerase.Click += new System.EventHandler(this.buttonerase_Click);
            // 
            // Guna2RadioButton6
            // 
            this.Guna2RadioButton6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
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
            this.Guna2RadioButton6.Location = new System.Drawing.Point(165, 254);
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
            this.Guna2GroupBox1.Controls.Add(this.DataView);
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
            this.Guna2GroupBox1.Size = new System.Drawing.Size(460, 206);
            this.Guna2GroupBox1.TabIndex = 514;
            // 
            // Guna2VScrollBar2
            // 
            this.Guna2VScrollBar2.AutoRoundedCorners = true;
            this.Guna2VScrollBar2.AutoScroll = true;
            this.Guna2VScrollBar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2VScrollBar2.BindingContainer = this.DataView;
            this.Guna2VScrollBar2.BorderRadius = 8;
            this.Guna2VScrollBar2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2VScrollBar2.HighlightOnWheel = true;
            this.Guna2VScrollBar2.InUpdate = false;
            this.Guna2VScrollBar2.LargeChange = 10;
            this.Guna2VScrollBar2.Location = new System.Drawing.Point(438, 3);
            this.Guna2VScrollBar2.Minimum = 1;
            this.Guna2VScrollBar2.Name = "Guna2VScrollBar2";
            this.Guna2VScrollBar2.ScrollbarSize = 18;
            this.Guna2VScrollBar2.Size = new System.Drawing.Size(18, 200);
            this.Guna2VScrollBar2.TabIndex = 497;
            this.Guna2VScrollBar2.ThumbColor = System.Drawing.Color.FromArgb(0, 85, 207);
            this.Guna2VScrollBar2.ThumbSize = 35F;
            this.Guna2VScrollBar2.ThumbStyle = Guna.UI2.WinForms.Enums.ThumbStyle.Inset;
            this.Guna2VScrollBar2.Value = 1;
            // 
            // DataView
            // 
            this.DataView.AllowUserToAddRows = false;
            this.DataView.AllowUserToDeleteRows = false;
            this.DataView.AllowUserToResizeColumns = false;
            this.DataView.AllowUserToResizeRows = false;
            this.DataView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.DataView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.DataView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column0,
            this.label,
            this.filename,
            this.start_sector,
            this.num_partition_sectors,
            this.physical_partition_number,
            this.SECTOR_SIZE_IN_BYTE,
            this.Column2});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataView.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.DataView.EnableHeadersVisualStyles = false;
            this.DataView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.DataView.Location = new System.Drawing.Point(7, 3);
            this.DataView.MultiSelect = false;
            this.DataView.Name = "DataView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataView.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.DataView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DataView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.DataView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.DataView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.DataView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DataView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataView.Size = new System.Drawing.Size(449, 200);
            this.DataView.TabIndex = 484;
            // 
            // Column0
            // 
            this.Column0.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column0.Frozen = true;
            this.Column0.HeaderText = " ";
            this.Column0.Name = "Column0";
            this.Column0.Width = 19;
            // 
            // label
            // 
            this.label.FillWeight = 40F;
            this.label.HeaderText = "Partition";
            this.label.Name = "label";
            this.label.ReadOnly = true;
            // 
            // filename
            // 
            this.filename.FillWeight = 80F;
            this.filename.HeaderText = "FileName";
            this.filename.Name = "filename";
            this.filename.ReadOnly = true;
            // 
            // start_sector
            // 
            this.start_sector.FillWeight = 40F;
            this.start_sector.HeaderText = "Start Sector";
            this.start_sector.Name = "start_sector";
            this.start_sector.Visible = false;
            // 
            // num_partition_sectors
            // 
            this.num_partition_sectors.FillWeight = 40F;
            this.num_partition_sectors.HeaderText = "Num Sector";
            this.num_partition_sectors.Name = "num_partition_sectors";
            this.num_partition_sectors.Visible = false;
            // 
            // physical_partition_number
            // 
            this.physical_partition_number.FillWeight = 50F;
            this.physical_partition_number.HeaderText = "LUN";
            this.physical_partition_number.Name = "physical_partition_number";
            this.physical_partition_number.ReadOnly = true;
            this.physical_partition_number.Visible = false;
            // 
            // SECTOR_SIZE_IN_BYTE
            // 
            this.SECTOR_SIZE_IN_BYTE.FillWeight = 50F;
            this.SECTOR_SIZE_IN_BYTE.HeaderText = "Part Size";
            this.SECTOR_SIZE_IN_BYTE.Name = "SECTOR_SIZE_IN_BYTE";
            this.SECTOR_SIZE_IN_BYTE.ReadOnly = true;
            this.SECTOR_SIZE_IN_BYTE.Visible = false;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 35F;
            this.Column2.HeaderText = "Part Size";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // CkAutoSwitchHighSpeedUSB
            // 
            this.CkAutoSwitchHighSpeedUSB.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CkAutoSwitchHighSpeedUSB.Animated = true;
            this.CkAutoSwitchHighSpeedUSB.AutoSize = true;
            this.CkAutoSwitchHighSpeedUSB.BackColor = System.Drawing.Color.Transparent;
            this.CkAutoSwitchHighSpeedUSB.CheckedState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.CkAutoSwitchHighSpeedUSB.CheckedState.BorderRadius = 4;
            this.CkAutoSwitchHighSpeedUSB.CheckedState.BorderThickness = 2;
            this.CkAutoSwitchHighSpeedUSB.CheckedState.FillColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.CkAutoSwitchHighSpeedUSB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CkAutoSwitchHighSpeedUSB.ForeColor = System.Drawing.Color.White;
            this.CkAutoSwitchHighSpeedUSB.Location = new System.Drawing.Point(9, 255);
            this.CkAutoSwitchHighSpeedUSB.Name = "CkAutoSwitchHighSpeedUSB";
            this.CkAutoSwitchHighSpeedUSB.Size = new System.Drawing.Size(78, 19);
            this.CkAutoSwitchHighSpeedUSB.TabIndex = 525;
            this.CkAutoSwitchHighSpeedUSB.Text = "Select All";
            this.CkAutoSwitchHighSpeedUSB.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.CkAutoSwitchHighSpeedUSB.UncheckedState.BorderRadius = 3;
            this.CkAutoSwitchHighSpeedUSB.UncheckedState.BorderThickness = 1;
            this.CkAutoSwitchHighSpeedUSB.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.CkAutoSwitchHighSpeedUSB.UseVisualStyleBackColor = false;
            this.CkAutoSwitchHighSpeedUSB.CheckedChanged += new System.EventHandler(this.CkAutoSwitchHighSpeedUSB_CheckedChanged);
            // 
            // cbreboot
            // 
            this.cbreboot.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
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
            this.cbreboot.Location = new System.Drawing.Point(92, 255);
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
            // TabPage4
            // 
            this.TabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TabPage4.Controls.Add(this.cbsetboot);
            this.TabPage4.Controls.Add(this.Guna2Button1);
            this.TabPage4.Controls.Add(this.Guna2CheckBox5);
            this.TabPage4.Controls.Add(this.Guna2GroupBox9);
            this.TabPage4.Controls.Add(this.Guna2Button11);
            this.TabPage4.Controls.Add(this.txtrawxml);
            this.TabPage4.Location = new System.Drawing.Point(4, 30);
            this.TabPage4.Name = "TabPage4";
            this.TabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage4.Size = new System.Drawing.Size(472, 284);
            this.TabPage4.TabIndex = 2;
            this.TabPage4.Text = "Flasher";
            // 
            // cbsetboot
            // 
            this.cbsetboot.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbsetboot.Animated = true;
            this.cbsetboot.AutoSize = true;
            this.cbsetboot.BackColor = System.Drawing.Color.Transparent;
            this.cbsetboot.CheckedState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.cbsetboot.CheckedState.BorderRadius = 4;
            this.cbsetboot.CheckedState.BorderThickness = 2;
            this.cbsetboot.CheckedState.FillColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.cbsetboot.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbsetboot.ForeColor = System.Drawing.Color.White;
            this.cbsetboot.Location = new System.Drawing.Point(97, 228);
            this.cbsetboot.Name = "cbsetboot";
            this.cbsetboot.Size = new System.Drawing.Size(75, 19);
            this.cbsetboot.TabIndex = 552;
            this.cbsetboot.Text = "Set Boot";
            this.cbsetboot.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.cbsetboot.UncheckedState.BorderRadius = 3;
            this.cbsetboot.UncheckedState.BorderThickness = 1;
            this.cbsetboot.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.cbsetboot.UseVisualStyleBackColor = false;
            this.cbsetboot.CheckedChanged += new System.EventHandler(this.cbsetboot_CheckedChanged);
            // 
            // Guna2Button1
            // 
            this.Guna2Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Guna2Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2Button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2Button1.BorderRadius = 4;
            this.Guna2Button1.BorderThickness = 2;
            this.Guna2Button1.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button1.CheckedState.FillColor = System.Drawing.Color.LightGray;
            this.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
            this.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2Button1.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2Button1.ForeColor = System.Drawing.Color.White;
            this.Guna2Button1.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button1.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button1.Image = global::Properties.Resources.search_in_folder;
            this.Guna2Button1.ImageSize = new System.Drawing.Size(25, 25);
            this.Guna2Button1.Location = new System.Drawing.Point(6, 251);
            this.Guna2Button1.Name = "Guna2Button1";
            this.Guna2Button1.PressedColor = System.Drawing.Color.Empty;
            this.Guna2Button1.Size = new System.Drawing.Size(48, 27);
            this.Guna2Button1.TabIndex = 547;
            this.Guna2Button1.TextFormatNoPrefix = true;
            this.Guna2Button1.Click += new System.EventHandler(this.Guna2Button1_Click);
            // 
            // Guna2CheckBox5
            // 
            this.Guna2CheckBox5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Guna2CheckBox5.Animated = true;
            this.Guna2CheckBox5.AutoSize = true;
            this.Guna2CheckBox5.BackColor = System.Drawing.Color.Transparent;
            this.Guna2CheckBox5.CheckedState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2CheckBox5.CheckedState.BorderRadius = 4;
            this.Guna2CheckBox5.CheckedState.BorderThickness = 2;
            this.Guna2CheckBox5.CheckedState.FillColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2CheckBox5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2CheckBox5.ForeColor = System.Drawing.Color.White;
            this.Guna2CheckBox5.Location = new System.Drawing.Point(13, 228);
            this.Guna2CheckBox5.Name = "Guna2CheckBox5";
            this.Guna2CheckBox5.Size = new System.Drawing.Size(78, 19);
            this.Guna2CheckBox5.TabIndex = 550;
            this.Guna2CheckBox5.Text = "Select All";
            this.Guna2CheckBox5.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2CheckBox5.UncheckedState.BorderRadius = 3;
            this.Guna2CheckBox5.UncheckedState.BorderThickness = 1;
            this.Guna2CheckBox5.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2CheckBox5.UseVisualStyleBackColor = false;
            this.Guna2CheckBox5.CheckedChanged += new System.EventHandler(this.Guna2CheckBox5_CheckedChanged);
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
            this.Guna2GroupBox9.Controls.Add(this.Guna2VScrollBar1);
            this.Guna2GroupBox9.Controls.Add(this.DataGridView1);
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
            this.Guna2GroupBox9.Size = new System.Drawing.Size(460, 216);
            this.Guna2GroupBox9.TabIndex = 549;
            // 
            // Guna2VScrollBar1
            // 
            this.Guna2VScrollBar1.AutoRoundedCorners = true;
            this.Guna2VScrollBar1.AutoScroll = true;
            this.Guna2VScrollBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2VScrollBar1.BindingContainer = this.DataGridView1;
            this.Guna2VScrollBar1.BorderRadius = 8;
            this.Guna2VScrollBar1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2VScrollBar1.HighlightOnWheel = true;
            this.Guna2VScrollBar1.InUpdate = false;
            this.Guna2VScrollBar1.LargeChange = 10;
            this.Guna2VScrollBar1.Location = new System.Drawing.Point(439, 3);
            this.Guna2VScrollBar1.Minimum = 1;
            this.Guna2VScrollBar1.Name = "Guna2VScrollBar1";
            this.Guna2VScrollBar1.ScrollbarSize = 18;
            this.Guna2VScrollBar1.Size = new System.Drawing.Size(18, 210);
            this.Guna2VScrollBar1.TabIndex = 530;
            this.Guna2VScrollBar1.ThumbColor = System.Drawing.Color.FromArgb(0, 85, 207);
            this.Guna2VScrollBar1.ThumbSize = 35F;
            this.Guna2VScrollBar1.ThumbStyle = Guna.UI2.WinForms.Enums.ThumbStyle.Inset;
            this.Guna2VScrollBar1.Value = 1;
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.AllowUserToResizeColumns = false;
            this.DataGridView1.AllowUserToResizeRows = false;
            this.DataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
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
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            this.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.DataGridView1.EnableHeadersVisualStyles = false;
            this.DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.DataGridView1.Location = new System.Drawing.Point(6, 3);
            this.DataGridView1.MultiSelect = false;
            this.DataGridView1.Name = "DataGridView1";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.DataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.DataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.DataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(451, 210);
            this.DataGridView1.TabIndex = 529;
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
            this.DataGridViewTextBoxColumn1.FillWeight = 40F;
            this.DataGridViewTextBoxColumn1.HeaderText = "Partition";
            this.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
            this.DataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn2
            // 
            this.DataGridViewTextBoxColumn2.FillWeight = 80F;
            this.DataGridViewTextBoxColumn2.HeaderText = "FileName";
            this.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2";
            this.DataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn3
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridViewTextBoxColumn3.FillWeight = 40F;
            this.DataGridViewTextBoxColumn3.HeaderText = "Start Sector";
            this.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3";
            this.DataGridViewTextBoxColumn3.Visible = false;
            // 
            // DataGridViewTextBoxColumn4
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle7;
            this.DataGridViewTextBoxColumn4.FillWeight = 40F;
            this.DataGridViewTextBoxColumn4.HeaderText = "Num Sector";
            this.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4";
            this.DataGridViewTextBoxColumn4.Visible = false;
            // 
            // DataGridViewTextBoxColumn5
            // 
            this.DataGridViewTextBoxColumn5.FillWeight = 50F;
            this.DataGridViewTextBoxColumn5.HeaderText = "LUN";
            this.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5";
            this.DataGridViewTextBoxColumn5.ReadOnly = true;
            this.DataGridViewTextBoxColumn5.Visible = false;
            // 
            // DataGridViewTextBoxColumn6
            // 
            this.DataGridViewTextBoxColumn6.FillWeight = 50F;
            this.DataGridViewTextBoxColumn6.HeaderText = "Part Size";
            this.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6";
            this.DataGridViewTextBoxColumn6.ReadOnly = true;
            this.DataGridViewTextBoxColumn6.Visible = false;
            // 
            // DataGridViewTextBoxColumn7
            // 
            this.DataGridViewTextBoxColumn7.FillWeight = 35F;
            this.DataGridViewTextBoxColumn7.HeaderText = "Part Size";
            this.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7";
            this.DataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // Guna2Button11
            // 
            this.Guna2Button11.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Guna2Button11.Animated = true;
            this.Guna2Button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2Button11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2Button11.BorderRadius = 4;
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
            this.Guna2Button11.Image = global::Properties.Resources.flash__1_;
            this.Guna2Button11.ImageSize = new System.Drawing.Size(25, 25);
            this.Guna2Button11.Location = new System.Drawing.Point(341, 252);
            this.Guna2Button11.Name = "Guna2Button11";
            this.Guna2Button11.PressedColor = System.Drawing.Color.Empty;
            this.Guna2Button11.Size = new System.Drawing.Size(125, 26);
            this.Guna2Button11.TabIndex = 546;
            this.Guna2Button11.Text = "Start Flash";
            this.Guna2Button11.TextFormatNoPrefix = true;
            this.Guna2Button11.Click += new System.EventHandler(this.Guna2Button11_Click);
            // 
            // txtrawxml
            // 
            this.txtrawxml.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
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
            this.txtrawxml.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txtrawxml.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtrawxml.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrawxml.ForeColor = System.Drawing.Color.White;
            this.txtrawxml.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.txtrawxml.Location = new System.Drawing.Point(60, 252);
            this.txtrawxml.Name = "txtrawxml";
            this.txtrawxml.PasswordChar = '\0';
            this.txtrawxml.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtrawxml.PlaceholderText = "XML | Dump File";
            this.txtrawxml.SelectedText = "";
            this.txtrawxml.ShadowDecoration.Color = System.Drawing.Color.DimGray;
            this.txtrawxml.ShadowDecoration.Depth = 15;
            this.txtrawxml.Size = new System.Drawing.Size(275, 26);
            this.txtrawxml.TabIndex = 548;
            this.txtrawxml.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbstorage
            // 
            this.cbstorage.ForeColor = System.Drawing.Color.DarkRed;
            this.cbstorage.FormattingEnabled = true;
            this.cbstorage.Items.AddRange(new object[] {
            "auto",
            "emmc",
            "ufs"});
            this.cbstorage.Location = new System.Drawing.Point(1524, 322);
            this.cbstorage.Name = "cbstorage";
            this.cbstorage.Size = new System.Drawing.Size(10, 21);
            this.cbstorage.TabIndex = 526;
            this.cbstorage.Visible = false;
            // 
            // EDL
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(496, 534);
            this.ControlBox = false;
            this.Controls.Add(this.cbstorage);
            this.Controls.Add(this.TabControlExt1);
            this.Controls.Add(this.Guna2GroupBox2);
            this.Controls.Add(this.RichTextBox2);
            this.Controls.Add(this.ComboBoxUSB);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EDL";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Services Qualcomm";
            this.Load += new System.EventHandler(this.EDL_Load);
            this.Guna2GroupBox2.ResumeLayout(false);
            this.Guna2GroupBox2.PerformLayout();
            this.Model.ResumeLayout(false);
            this.TabControlExt1.ResumeLayout(false);
            this.TabPage2.ResumeLayout(false);
            this.TabPage3.ResumeLayout(false);
            this.TabPage3.PerformLayout();
            this.Guna2GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).EndInit();
            this.TabPage4.ResumeLayout(false);
            this.TabPage4.PerformLayout();
            this.Guna2GroupBox9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);

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
		StartProcess();
		FIREHOSE_MANAGER.StringXml = "";
		SAHARA_MANAGER.IsAutoLoader = false;
		SerialCOM.MSL = null;
		if (Operators.CompareString(cancel, "Cancel", TextCompare: false) == 0)
		{
			cancel = "";
		}
		device_info.Android = "......";
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
		if (Operators.CompareString(UiManager.Hh, "ok", TextCompare: false) != 0)
		{
			return;
		}
		try
		{
			if (PortIOMe.Ports.IsOpen)
			{
				PortIOMe.Ports.Close();
				PortIOMe.Ports.Dispose();
				PortIOMe.Ports = null;
			}
			DiskWriter.Closeport();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		SerialCOM.MSL = "";
		SerialCOM.MSL = "";
		SerialCOM.MSL = "";
		Form1.SharedUI.MaterialButton8.Enabled = false;
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
		Form1.SharedUI.RichTextBox1.AppendText("> Operation Failed, Try Agine");
		Form1.SharedUI.ProgressBar1.Text = "Finish Server Data..";
		Form1.SharedUI.ProgressBar4.Visible = false;
		Form1.SharedUI.ProgressBar4.Value = 0;
		Form1.SharedUI.ProgressBar1.Text = "100%";
		Form1.SharedUI.Guna2TaskBarProgress1.State = Guna2TaskBarProgress.TaskbarStates.Error;
		Form1.SharedUI.Guna2TaskBarProgress1.Value = 0;
		Form1.SharedUI.Guna2TaskBarProgress1.Value = 0;
		Form1.SharedUI.Guna2TaskBarProgress1.Value = 0;
		Form1.SharedUI.Guna2TaskBarProgress1.Value = 0;
		Form1.SharedUI.ProgressBar1.Roll = false;
		Form1.SharedUI.MaterialCard3.Enabled = true;
		Form1.SharedUI.MaterialCard5.Enabled = true;
		UiManager.ScanTemWav();
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
			Baseband = device_info.secunumber,
			Brand = device_info.Brand,
			Carrier = "Unknown",
			Credit = Convert.ToDecimal(String_75),
			Imei = "Unknown",
			modle = device_info.model,
			OprationStatus = true,
			OprationTypes = String_35,
			PhoneId = SAHARA_MANAGER._pblInfo.msm_id,
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
			PhoneId = SAHARA_MANAGER._pblInfo.msm_id,
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
							device_info.model = SAHARA_MANAGER._pblInfo.msm_id;
						}
						device_info.serialno = SAHARA_MANAGER._pblInfo.serial;
						Task.Run([SpecialName] async () =>
						{
							await MethodD_43();
						}).Wait();
						if (Operators.CompareString(device_info.model, SAHARA_MANAGER._pblInfo.msm_id, TextCompare: false) == 0)
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
					String_75 = Conversions.ToString(0);
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
		SerialCOM.MSL = "";
		Form1.SharedUI.MaterialButton8.Enabled = false;
		Form1.SharedUI.MaterialCard3.Enabled = true;
		Form1.SharedUI.MaterialCard5.Enabled = true;
		Form1.SharedUI.ProgressBar4.Visible = false;
		Form1.SharedUI.ProgressBar4.Maximum = 100;
		Form1.SharedUI.ProgressBar4.Value = 0;
		Form1.SharedUI.ProgressBar1.Text = "100%";
		Form1.SharedUI.ProgressBar1.Roll = false;
		Form1.SharedUI.Guna2TaskBarProgress1.State = Guna2TaskBarProgress.TaskbarStates.Normal;
		Form1.SharedUI.Guna2TaskBarProgress1.Value = 0;
		Form1.SharedUI.Guna2TaskBarProgress1.Value = 0;
		Form1.SharedUI.Guna2TaskBarProgress1.Value = 0;
	}

	private void Guna2RadioButton4_CheckedChanged(object sender, EventArgs e)
	{
		ComboBoxBrand.Enabled = true;
		Model.Enabled = true;
		Model.Size = new Size(464, 142);
		if (ComboBoxBrand.SelectedIndex == 0)
		{
			Guna2Button7.Enabled = true;
			Guna2Button8.Enabled = true;
			Guna2Button12.Enabled = true;
		}
		else
		{
			Guna2Button7.Enabled = false;
			Guna2Button8.Enabled = false;
			Guna2Button12.Enabled = false;
		}
		if (ComboBoxBrand.SelectedIndex == 2)
		{
			Guna2Button2.Enabled = true;
			Guna2Button3.Enabled = true;
		}
		else
		{
			Guna2Button2.Enabled = false;
			Guna2Button3.Enabled = false;
		}
		if (ComboBoxBrand.SelectedIndex == 3)
		{
			Guna2Button4.Enabled = true;
		}
		else
		{
			Guna2Button4.Enabled = false;
		}
	}

	private void Guna2RadioButton11_CheckedChanged(object sender, EventArgs e)
	{
		ComboBoxBrand.Enabled = false;
		Model.Enabled = false;
		Model.Size = new Size(464, 108);
		Guna2Button7.Enabled = true;
		Guna2Button8.Enabled = true;
		Guna2Button12.Enabled = true;
		Guna2Button2.Enabled = true;
		Guna2Button3.Enabled = true;
		Guna2Button4.Enabled = true;
	}

	private void Timer2_Tick(object sender, EventArgs e)
	{
		if (Operators.CompareString(SevaClass.canaclstring, "Can", TextCompare: false) != 0)
		{
			return;
		}
		SevaClass.canaclstring = "";
		cancel = "Cancel";
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
		try
		{
			if (PortIOMe.Ports.IsOpen)
			{
				PortIOMe.Ports.Close();
				PortIOMe.Ports.Dispose();
				PortIOMe.Ports = null;
			}
			DiskWriter.Closeport();
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			ProjectData.ClearProjectError();
		}
		SerialCOM.MSL = "Cen";
	}

	private void Guna2Button15_Click(object sender, EventArgs e)
	{
		txtloader.Text = "";
		OpenFileDialog openFileDialog = new OpenFileDialog
		{
			Title = "Select Loader",
			InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer),
			FileName = "",
			Filter = "all file |*.*;*.* ",
			FilterIndex = 2,
			RestoreDirectory = true
		};
		if (openFileDialog.ShowDialog() == DialogResult.OK)
		{
			txtloader.Text = openFileDialog.FileName;
			new FileInfo(openFileDialog.FileName);
		}
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

	public void Loadsss(string xml)
	{
		LoadXmlFolder(xml);
	}

	private void LoadXmlFolder(string xml)
	{
		DataGridView1.Rows.Clear();
		FIREHOSE_MANAGER.PatchString = "";
		string[] array = xml.Split(',');
		checked
		{
			int num = array.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = array[i];
				if (string.IsNullOrEmpty(text))
				{
					break;
				}
				string text2 = "";
				XmlReader xmlReader = XmlReader.Create(LoadFolderXml + "\\" + text);
				while (xmlReader.Read())
				{
					if (xmlReader.NodeType == XmlNodeType.Element && Operators.CompareString(xmlReader.Name, "program", TextCompare: false) == 0)
					{
						string text3 = null;
						text3 = (string.IsNullOrEmpty(xmlReader.GetAttribute("filename")) ? "Double Click For Add File" : (LoadFolderXml + "\\" + xmlReader.GetAttribute("filename")));
						string fileCalculator = UiManager.GetFileCalculator(Conversions.ToDouble(xmlReader.GetAttribute("num_partition_sectors")) * 1024.0 / 2.0);
						DataGridView1.Rows.Add(false, xmlReader.GetAttribute("label"), text3, xmlReader.GetAttribute("start_sector"), xmlReader.GetAttribute("num_partition_sectors"), xmlReader.GetAttribute("physical_partition_number"), xmlReader.GetAttribute("SECTOR_SIZE_IN_BYTES"), fileCalculator);
						text2 = xmlReader.GetAttribute("SECTOR_SIZE_IN_BYTES");
					}
					if (xmlReader.NodeType == XmlNodeType.Element && Operators.CompareString(xmlReader.Name, "patch", TextCompare: false) == 0)
					{
						FIREHOSE_MANAGER.PatchString = FIREHOSE_MANAGER.PatchString + text + ",";
						break;
					}
				}
				foreach (DataGridViewRow item in (IEnumerable)DataGridView1.Rows)
				{
					if (Operators.CompareString(item.Cells[1].Value.ToString(), "modem", TextCompare: false) == 0 || Operators.CompareString(item.Cells[1].Value.ToString(), "modemst1", TextCompare: false) == 0 || Operators.CompareString(item.Cells[1].Value.ToString(), "modemst2", TextCompare: false) == 0 || Operators.CompareString(item.Cells[1].Value.ToString(), "fsg", TextCompare: false) == 0)
					{
						Console.WriteLine(item.Cells[1].Value.ToString());
						item.DefaultCellStyle.ForeColor = Color.Red;
					}
				}
				foreach (DataGridViewRow item2 in (IEnumerable)DataGridView1.Rows)
				{
					if (Operators.CompareString(Convert.ToString(RuntimeHelpers.GetObjectValue(item2.Cells[2].Value)), "Double Click For Add File", TextCompare: false) == 0)
					{
						item2.Cells[0].Value = false;
					}
					else
					{
						item2.Cells[0].Value = true;
					}
				}
				if (text2.Contains("512"))
				{
					cbstorage.SelectedItem = "emmc";
					FIREHOSE_MANAGER.TypeMemory = "emmc";
					FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES = "512";
				}
				else if (text2.Contains("4096"))
				{
					cbstorage.SelectedItem = "ufs";
					FIREHOSE_MANAGER.TypeMemory = "ufs";
					FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES = "4096";
				}
			}
		}
	}

	public void CancelLOad()
	{
		LoadFolderXml = null;
		txtrawxml.Clear();
	}

	private void EDL_Load(object sender, EventArgs e)
	{
		cbstorage.Text = "auto";
		PortIOMe.PortCOM = 0;
		SAHARA_MANAGER.sendingloaderStatus = false;
		FIREHOSE_OPERATIONS.MenuEx = default(FIREHOSE_OPERATIONS.MenuEksekusi);
		FIREHOSE_OPERATIONS.MenuEx = FIREHOSE_OPERATIONS.MenuEksekusi.manual;
		FIREHOSE_MANAGER.TypeMemory = "auto";
		FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES = "";
	}

	public EDL()
	{
		base.Load += EDL_Load;
		text22 = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName()).Replace(".", "");
		InitializeComponent();
		SharedEDL = this;
	}

	private void cbstorage_SelectedIndexChanged(object sender, EventArgs e)
	{
		FIREHOSE_OPERATIONS.MenuEx = FIREHOSE_OPERATIONS.MenuEksekusi.manual;
		if (Operators.CompareString(cbstorage.Text, "emmc", TextCompare: false) == 0 || Operators.CompareString(cbstorage.Text, "auto", TextCompare: false) == 0)
		{
			FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES = "512";
			FIREHOSE_MANAGER.TypeMemory = "emmc";
		}
		else
		{
			FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES = "4096";
			FIREHOSE_MANAGER.TypeMemory = "ufs";
		}
	}

	private void BtnIdentify_Click(object sender, EventArgs e)
	{
		start();
		ThreadNew = new Thread(Identify);
		ThreadNew.Start();
	}

	public void Identify()
	{
		if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0 && Conversions.ToDouble(Form1.SharedUI.Label25.Text) == 0.0)
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.YDNHBPR);
			finshonly();
			return;
		}
		if (Guna2RadioButton11.Checked)
		{
			if (string.IsNullOrEmpty(txtloader.Text))
			{
				UiManager.Richlogs("Select Loader File First!", Color.Red, isBold: false);
				finshonly();
				return;
			}
			SAHARA_MANAGER.Loader = File.ReadAllBytes(txtloader.Text);
			if (!Encoding.UTF8.GetString(SAHARA_MANAGER.Loader).Contains("ELF"))
			{
				UiManager.Richlogs("Loader is Invalid Or Encrypted", Color.Red, isBold: false);
				finshonly();
				return;
			}
		}
		FIREHOSE_OPERATIONS.MenuEx = FIREHOSE_OPERATIONS.MenuEksekusi.manual;
		FIREHOSE_OPERATIONS.MenuMan = FIREHOSE_OPERATIONS.MenuManual.ident;
		FIREHOSE_MANAGER.Partition_Name = "readinfo";
		DataView.Rows.Clear();
		UiManager.CariPortQcom_Tick();
		if (Form1.SharedUI.RichTextBox1.Text.Contains("- Scanning Partitions Data : Found") | Form1.SharedUI.RichTextBox1.Text.Contains("Userarea :"))
		{
			finshonly();
		}
		else
		{
			finshfile();
		}
	}

	private void ComboBoxBrand_SelectedIndexChanged(object sender, EventArgs e)
	{
		start();
		ThreadNew = new Thread(Get_Modelsand_add);
		ThreadNew.Start();
	}

	public void Get_Modelsand_add()
	{
		ComboBoxModel.Items.Clear();
		ComboBoxModel.Text = "";
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
		Form1.SharedUI.RichTextBox1.AppendText("- List Models From Server : ");
		try
		{
			MyProject.Computer.FileSystem.DeleteDirectory("Tmp\\1", DeleteDirectoryOption.DeleteAllContents);
			File.Delete(SPDR.ThisLocation + "Tmp\\1.zip");
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
			//return;
		}
		String_14 = "1";
		MethodD_100();
		if (!Boolean_2)
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringF);
			finshonly();
			//return;
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
					ComboBoxModel.Items.Add(list[i][0]);
					FIREHOSE_MANAGER.gettypehpnya.Items.Add(list[i][0] + ":" + list[i][1].ToString());
					if (i == 0)
					{
						ComboBoxModel.Text = Convert.ToString(list[0][0]);
					}
				}
				File.Delete(ThisLocation + "Tmp\\" + String_14);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringO);
				if (ComboBoxBrand.SelectedIndex == 0)
				{
					Guna2Button7.Enabled = true;
					Guna2Button8.Enabled = true;
					Guna2Button12.Enabled = true;
				}
				else
				{
					Guna2Button7.Enabled = false;
					Guna2Button8.Enabled = false;
					Guna2Button12.Enabled = false;
				}
				if (ComboBoxBrand.SelectedIndex == 2)
				{
					Guna2Button2.Enabled = true;
					Guna2Button3.Enabled = true;
				}
				else
				{
					Guna2Button2.Enabled = false;
					Guna2Button3.Enabled = false;
				}
				if (ComboBoxBrand.SelectedIndex == 3)
				{
					Guna2Button4.Enabled = true;
				}
				else
				{
					Guna2Button4.Enabled = false;
				}
				finshonly();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
				Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringF);
				if (ComboBoxBrand.SelectedIndex == 0)
				{
					Guna2Button7.Enabled = true;
					Guna2Button8.Enabled = true;
					Guna2Button12.Enabled = true;
				}
				else
				{
					Guna2Button7.Enabled = false;
					Guna2Button8.Enabled = false;
					Guna2Button12.Enabled = false;
				}
				if (ComboBoxBrand.SelectedIndex == 2)
				{
					Guna2Button2.Enabled = true;
					Guna2Button3.Enabled = true;
				}
				else
				{
					Guna2Button2.Enabled = false;
					Guna2Button3.Enabled = false;
				}
				if (ComboBoxBrand.SelectedIndex == 3)
				{
					Guna2Button4.Enabled = true;
				}
				else
				{
					Guna2Button4.Enabled = false;
				}
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
			FirebaseResponse obj = Form1.String_107.Get(ClassDevronix.LF + ComboBoxBrand.Text);
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

	private void MethodD_111()
	{
		ThreadNew = new Thread(MethodD_113);
		ThreadNew.Start();
	}

	public void MethodD_113()
	{
		MethodD_115(ThisLocation + "Tmp\\" + String_14, Form1.String_7);
	}

	public void MethodD_115(string AA, string GG)
	{
		byte[] bBB = File.ReadAllBytes(AA);
		byte[] bytes = Encoding.UTF8.GetBytes(GG);
		bytes = SHA256.Create().ComputeHash(bytes);
		byte[] bytes2 = MethodD_116(bBB, bytes);
		File.WriteAllBytes(AA, bytes2);
	}

	public static byte[] MethodD_116(byte[] BBB, byte[] GGG)
	{
		byte[] array = null;
		byte[] salt = new byte[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
		checked
		{
			using MemoryStream memoryStream = new MemoryStream();
			using AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider();
			aesCryptoServiceProvider.KeySize = 256;
			aesCryptoServiceProvider.BlockSize = 128;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(GGG, salt, 1000);
			aesCryptoServiceProvider.Key = rfc2898DeriveBytes.GetBytes((int)Math.Round((double)aesCryptoServiceProvider.KeySize / 8.0));
			aesCryptoServiceProvider.IV = rfc2898DeriveBytes.GetBytes((int)Math.Round((double)aesCryptoServiceProvider.BlockSize / 8.0));
			aesCryptoServiceProvider.Mode = CipherMode.CBC;
			using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aesCryptoServiceProvider.CreateDecryptor(), CryptoStreamMode.Write))
			{
				cryptoStream.Write(BBB, 0, BBB.Length);
				cryptoStream.Close();
			}
			return memoryStream.ToArray();
		}
	}

	private void ComboBoxModel_SelectedIndexChanged(object sender, EventArgs e)
	{
		string right = ComboBoxModel.Text;
		checked
		{
			int num = FIREHOSE_MANAGER.gettypehpnya.Items.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(FIREHOSE_MANAGER.gettypehpnya.Items[i]), null, "Split", new object[1] { ':' }, null, null, null)));
				if (Operators.ConditionalCompareObjectEqual(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(RuntimeHelpers.GetObjectValue(objectValue), new object[1] { 0 }, null)), right, TextCompare: false))
				{
					FIREHOSE_MANAGER.typeterpilih = Conversions.ToString(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(RuntimeHelpers.GetObjectValue(objectValue), new object[1] { 1 }, null)));
					Link_Loader = "https://firebasestorage.googleapis.com/v0/b/motounlock-7d7d0.appspot.com/o/Loaders_EDL%" + FIREHOSE_MANAGER.typeterpilih;
				}
			}
		}
	}

	private void Guna2Button6_Click(object sender, EventArgs e)
	{
		start();
		ThreadNew = new Thread(REMOVE_FRP);
		ThreadNew.Start();
	}

	public void REMOVE_FRP()
	{
		if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0 && Conversions.ToDouble(Form1.SharedUI.Label25.Text) == 0.0)
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.YDNHBPR);
			finshonly();
			return;
		}
		String_35 = "Remove FRP [EDL]";
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
		if (Guna2RadioButton11.Checked)
		{
			if (string.IsNullOrEmpty(txtloader.Text))
			{
				UiManager.Richlogs("Select Loader File First!", Color.Red, isBold: false);
				finshonly();
				return;
			}
			SAHARA_MANAGER.Loader = File.ReadAllBytes(txtloader.Text);
			if (!Encoding.UTF8.GetString(SAHARA_MANAGER.Loader).Contains("ELF"))
			{
				UiManager.Richlogs("Loader is Invalid Or Encrypted", Color.Red, isBold: false);
				finshonly();
				return;
			}
		}
		FIREHOSE_OPERATIONS.MenuEx = FIREHOSE_OPERATIONS.MenuEksekusi.manual;
		FIREHOSE_OPERATIONS.MenuMan = FIREHOSE_OPERATIONS.MenuManual.readgpt_erase;
		FIREHOSE_MANAGER.Partition_Name = "frp";
		DataView.Rows.Clear();
		UiManager.CariPortQcom_Tick();
		if (Form1.SharedUI.RichTextBox1.Text.Contains("- Reboot Device : Done") | Form1.SharedUI.RichTextBox1.Text.Contains("- Remove Frp"))
		{
			finsh();
			Form1.SharedUI.ProgressBar1.Text = "Remove FRP Done!";
		}
		else
		{
			finshfile();
		}
	}

	private void CkAutoSwitchHighSpeedUSB_CheckedChanged(object sender, EventArgs e)
	{
		checked
		{
			if (CkAutoSwitchHighSpeedUSB.CheckState != CheckState.Checked)
			{
				{
					foreach (DataGridViewRow item in (IEnumerable)DataView.Rows)
					{
						int num = item.Cells.Count - 1;
						for (int i = 0; i <= num; i++)
						{
							item.Cells[0].Value = false;
						}
					}
					return;
				}
			}
			foreach (DataGridViewRow item2 in (IEnumerable)DataView.Rows)
			{
				int num2 = item2.Cells.Count - 1;
				for (int j = 0; j <= num2; j++)
				{
					if (Operators.CompareString(item2.Cells[1].Value.ToString(), "userdata", TextCompare: false) != 0)
					{
						item2.Cells[0].Value = true;
					}
				}
			}
		}
	}

	private void buttonerase_Click(object sender, EventArgs e)
	{
		if (Guna2RadioButton6.Checked)
		{
			DataView.ClearSelection();
			if (DataView.Rows.Count > 0)
			{
				FIREHOSE_OPERATIONS.MenuEx = FIREHOSE_OPERATIONS.MenuEksekusi.manual;
				Form1 sharedUI = Form1.SharedUI;
				if (new FolderPicker().ShowDialog(sharedUI) == DialogResult.OK)
				{
					FIREHOSE_MANAGER.foldersave = UiManager.Selected_Folder;
					bool flag = false;
					foreach (DataGridViewRow item in (IEnumerable)DataView.Rows)
					{
						if (Convert.ToBoolean(RuntimeHelpers.GetObjectValue(item.Cells[0].Value)))
						{
							flag = true;
						}
					}
					if (flag)
					{
						start();
						ThreadNew = new Thread(READ_PART);
						ThreadNew.Start();
					}
					else
					{
						MessageBox.Show("Please Select The Partition First!", MyProject.Forms.Form1.Text, MessageBoxButtons.OK);
					}
				}
			}
			else
			{
				MessageBox.Show("Please Insert The Raw XML/Definition File First!", MyProject.Forms.Form1.Text, MessageBoxButtons.OK);
			}
		}
		if (Guna2RadioButton8.Checked)
		{
			if (DataView.Rows.Count > 0)
			{
				bool flag2 = false;
				foreach (DataGridViewRow item2 in (IEnumerable)DataView.Rows)
				{
					if (Convert.ToBoolean(RuntimeHelpers.GetObjectValue(item2.Cells[0].Value)))
					{
						flag2 = true;
					}
				}
				if (flag2)
				{
					start();
					ThreadNew = new Thread(Write_PART);
					ThreadNew.Start();
				}
				else
				{
					MessageBox.Show("Please Select The Partition First!", MyProject.Forms.Form1.Text, MessageBoxButtons.OK);
				}
			}
			else
			{
				MessageBox.Show("Please Insert The Raw XML/Definition File First!", MyProject.Forms.Form1.Text, MessageBoxButtons.OK);
			}
		}
		if (!Guna2RadioButton7.Checked)
		{
			return;
		}
		if (DataView.Rows.Count > 0)
		{
			bool flag3 = false;
			foreach (DataGridViewRow item3 in (IEnumerable)DataView.Rows)
			{
				if (Convert.ToBoolean(RuntimeHelpers.GetObjectValue(item3.Cells[0].Value)))
				{
					flag3 = true;
				}
			}
			if (flag3)
			{
				start();
				ThreadNew = new Thread(Erase_PART);
				ThreadNew.Start();
			}
			else
			{
				MessageBox.Show("Please Insert The Raw XML/Definition File First!", MyProject.Forms.Form1.Text, MessageBoxButtons.OK);
			}
		}
		else
		{
			MessageBox.Show("Please Select The Partition First!", MyProject.Forms.Form1.Text, MessageBoxButtons.OK);
		}
	}

	public void READ_PART()
	{
		if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0 && Conversions.ToDouble(Form1.SharedUI.Label25.Text) == 0.0)
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.YDNHBPR);
			finshonly();
			return;
		}
		if (Guna2RadioButton11.Checked)
		{
			if (string.IsNullOrEmpty(txtloader.Text))
			{
				UiManager.Richlogs("Select Loader File First!", Color.Red, isBold: false);
				finshonly();
				return;
			}
			SAHARA_MANAGER.Loader = File.ReadAllBytes(txtloader.Text);
			if (!Encoding.UTF8.GetString(SAHARA_MANAGER.Loader).Contains("ELF"))
			{
				UiManager.Richlogs("Loader is Invalid Or Encrypted", Color.Red, isBold: false);
				finshonly();
				return;
			}
		}
		FIREHOSE_OPERATIONS.MenuEx = FIREHOSE_OPERATIONS.MenuEksekusi.manual;
		FIREHOSE_OPERATIONS.MenuMan = FIREHOSE_OPERATIONS.MenuManual.read;
		FIREHOSE_MANAGER.StringXml += "<?xml version=\"1.0\" ?>\r\n";
		FIREHOSE_MANAGER.StringXml += "<data>\r\n";
		FIREHOSE_MANAGER.totalchecked = 0;
		checked
		{
			foreach (DataGridViewRow item in (IEnumerable)DataView.Rows)
			{
				if (Convert.ToBoolean(RuntimeHelpers.GetObjectValue(item.Cells[DataView.Columns[0].Index].Value)))
				{
					FIREHOSE_MANAGER.totalchecked++;
					FIREHOSE_MANAGER.StringXml = FIREHOSE_MANAGER.StringXml + $"<read SECTOR_SIZE_IN_BYTES=\"{FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES}\" file_sector_offset=\"0\" filename=\"{item.Cells[DataView.Columns[2].Index].Value}\" label=\"{item.Cells[DataView.Columns[1].Index].Value}\" num_partition_sectors=\"{item.Cells[DataView.Columns[4].Index].Value}\" physical_partition_number=\"{item.Cells[DataView.Columns[5].Index].Value}\" start_sector=\"{item.Cells[DataView.Columns[3].Index].Value}\"/>" + "\r\n";
				}
			}
			FIREHOSE_MANAGER.StringXml += "</data>";
			UiManager.CariPortQcom_Tick();
			if (Form1.SharedUI.RichTextBox1.Text.Contains("- Reboot Device : Done"))
			{
				finsh();
			}
			else if (Form1.SharedUI.RichTextBox1.Text.Contains("- Scanning Partitions Data : Found") | Form1.SharedUI.RichTextBox1.Text.Contains("Userdata :") | Form1.SharedUI.RichTextBox1.Text.Contains("- Reading Partition"))
			{
				if (Form1.SharedUI.RichTextBox1.Text.Contains("Failed"))
				{
					finshfile();
				}
				else
				{
					finshonly();
				}
			}
			else
			{
				finshfile();
			}
		}
	}

	public void Write_PART()
	{
		if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0 && Conversions.ToDouble(Form1.SharedUI.Label25.Text) == 0.0)
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.YDNHBPR);
			finshonly();
			return;
		}
		if (Guna2RadioButton11.Checked)
		{
			if (string.IsNullOrEmpty(txtloader.Text))
			{
				UiManager.Richlogs("Select Loader File First!", Color.Red, isBold: false);
				finshonly();
				return;
			}
			SAHARA_MANAGER.Loader = File.ReadAllBytes(txtloader.Text);
			if (!Encoding.UTF8.GetString(SAHARA_MANAGER.Loader).Contains("ELF"))
			{
				UiManager.Richlogs("Loader is Invalid Or Encrypted", Color.Red, isBold: false);
				finshonly();
				return;
			}
		}
		FIREHOSE_OPERATIONS.MenuEx = FIREHOSE_OPERATIONS.MenuEksekusi.manual;
		FIREHOSE_OPERATIONS.MenuMan = FIREHOSE_OPERATIONS.MenuManual.flash;
		FIREHOSE_MANAGER.StringXml += "<?xml version=\"1.0\" ?>\r\n";
		FIREHOSE_MANAGER.StringXml += "<data>\r\n";
		FIREHOSE_MANAGER.totalchecked = 0;
		checked
		{
			foreach (DataGridViewRow item in (IEnumerable)DataView.Rows)
			{
				if (Convert.ToBoolean(RuntimeHelpers.GetObjectValue(item.Cells[DataView.Columns[0].Index].Value)) && File.Exists(item.Cells[DataView.Columns[2].Index].Value.ToString()))
				{
					FIREHOSE_MANAGER.totalchecked++;
					FIREHOSE_MANAGER.StringXml = FIREHOSE_MANAGER.StringXml + $"<program SECTOR_SIZE_IN_BYTES=\"{FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES}\" file_sector_offset=\"0\" filename=\"{item.Cells[DataView.Columns[2].Index].Value}\" label=\"{item.Cells[DataView.Columns[1].Index].Value}\" num_partition_sectors=\"{item.Cells[DataView.Columns[4].Index].Value}\" physical_partition_number=\"{item.Cells[DataView.Columns[5].Index].Value}\" start_sector=\"{item.Cells[DataView.Columns[3].Index].Value}\"/>" + "\r\n";
				}
				if (!File.Exists(item.Cells[DataView.Columns[2].Index].Value.ToString()))
				{
					FIREHOSE_MANAGER.StringXml = null;
				}
			}
			if (Operators.CompareString(FIREHOSE_MANAGER.StringXml, null, TextCompare: false) == 0)
			{
				UiManager.Richlogs(">> Some Files Not Exists Please Checking The Files!", Color.Red, isBold: false);
				finshonly();
				return;
			}
			FIREHOSE_MANAGER.StringXml += "</data>";
			UiManager.CariPortQcom_Tick();
			if (Form1.SharedUI.RichTextBox1.Text.Contains("- Reboot Device : Done"))
			{
				finsh();
			}
			else if (Form1.SharedUI.RichTextBox1.Text.Contains("- Scanning Partitions Data : Found") | Form1.SharedUI.RichTextBox1.Text.Contains("Userdata :"))
			{
				if (Form1.SharedUI.RichTextBox1.Text.Contains("Failed"))
				{
					finshfile();
				}
				else
				{
					finshonly();
				}
			}
			else
			{
				finshfile();
			}
		}
	}

	public void Erase_PART()
	{
		if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0 && Conversions.ToDouble(Form1.SharedUI.Label25.Text) == 0.0)
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.YDNHBPR);
			finshonly();
			return;
		}
		if (Guna2RadioButton11.Checked)
		{
			if (string.IsNullOrEmpty(txtloader.Text))
			{
				UiManager.Richlogs("Select Loader File First!", Color.Red, isBold: false);
				finshonly();
				return;
			}
			SAHARA_MANAGER.Loader = File.ReadAllBytes(txtloader.Text);
			if (!Encoding.UTF8.GetString(SAHARA_MANAGER.Loader).Contains("ELF"))
			{
				UiManager.Richlogs("Loader is Invalid Or Encrypted", Color.Red, isBold: false);
				finshonly();
				return;
			}
		}
		FIREHOSE_OPERATIONS.MenuEx = FIREHOSE_OPERATIONS.MenuEksekusi.manual;
		FIREHOSE_OPERATIONS.MenuMan = FIREHOSE_OPERATIONS.MenuManual.erase;
		FIREHOSE_MANAGER.StringXml += "<?xml version=\"1.0\" ?>\r\n";
		FIREHOSE_MANAGER.StringXml += "<data>\r\n";
		FIREHOSE_MANAGER.totalchecked = 0;
		checked
		{
			foreach (DataGridViewRow item in (IEnumerable)DataView.Rows)
			{
				if (Convert.ToBoolean(RuntimeHelpers.GetObjectValue(item.Cells[DataView.Columns[0].Index].Value)))
				{
					FIREHOSE_MANAGER.totalchecked++;
					FIREHOSE_MANAGER.StringXml = FIREHOSE_MANAGER.StringXml + $"<program SECTOR_SIZE_IN_BYTES=\"{FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES}\" file_sector_offset=\"0\" filename=\"{item.Cells[DataView.Columns[2].Index].Value}\" label=\"{item.Cells[DataView.Columns[1].Index].Value}\" num_partition_sectors=\"{item.Cells[DataView.Columns[4].Index].Value}\" physical_partition_number=\"{item.Cells[DataView.Columns[5].Index].Value}\" start_sector=\"{item.Cells[DataView.Columns[3].Index].Value}\"/>" + "\r\n";
				}
			}
			FIREHOSE_MANAGER.StringXml += "</data>";
			UiManager.CariPortQcom_Tick();
			if (Form1.SharedUI.RichTextBox1.Text.Contains("- Reboot Device : Done"))
			{
				finsh();
			}
			else if (Form1.SharedUI.RichTextBox1.Text.Contains("- Scanning Partitions Data : Found") | Form1.SharedUI.RichTextBox1.Text.Contains("Userarea :"))
			{
				if (Form1.SharedUI.RichTextBox1.Text.Contains("Failed"))
				{
					finshfile();
				}
				else
				{
					finshonly();
				}
			}
			else
			{
				finshfile();
			}
		}
	}

	private void DataView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		if (DataView.Rows.Count > 0 && e.ColumnIndex == 2)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog
			{
				Title = "Choose File " + DataView.CurrentRow.Cells[1].Value.ToString(),
				InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer),
				FileName = "",
				Filter = "ALL FILE  (*.*)|*.*",
				FilterIndex = 2,
				RestoreDirectory = true
			};
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				DataView.CurrentRow.Cells[0].Value = true;
				DataView.CurrentRow.Cells[2].Value = openFileDialog.FileName;
			}
		}
	}

	private void Guna2CheckBox5_CheckedChanged(object sender, EventArgs e)
	{
		checked
		{
			if (Guna2CheckBox5.CheckState != CheckState.Checked)
			{
				{
					foreach (DataGridViewRow item in (IEnumerable)DataGridView1.Rows)
					{
						int num = item.Cells.Count - 1;
						for (int i = 0; i <= num; i++)
						{
							item.Cells[0].Value = false;
						}
					}
					return;
				}
			}
			foreach (DataGridViewRow item2 in (IEnumerable)DataGridView1.Rows)
			{
				int num2 = item2.Cells.Count - 1;
				for (int j = 0; j <= num2; j++)
				{
					if (Operators.CompareString(item2.Cells[1].Value.ToString(), "userdata", TextCompare: false) != 0)
					{
						item2.Cells[0].Value = true;
					}
				}
			}
		}
	}

	private void cbsetboot_CheckedChanged(object sender, EventArgs e)
	{
		if (cbsetboot.Checked)
		{
			if (MessageBox.Show("Set boot only used after replace eMMC / UFS Storage for fixing boot issues." + Environment.NewLine + "Are you sure?", MyProject.Forms.Form1.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				FIREHOSE_MANAGER.SetBoot = true;
				return;
			}
			FIREHOSE_MANAGER.SetBoot = false;
			cbsetboot.Checked = false;
		}
		else
		{
			FIREHOSE_MANAGER.SetBoot = false;
		}
	}

	private void Guna2Button1_Click(object sender, EventArgs e)
	{
		Form1 sharedUI = Form1.SharedUI;
		if (new FolderPicker().ShowDialog(sharedUI) == DialogResult.OK)
		{
			string loadFolderXml = ((!Directory.Exists(UiManager.Selected_Folder + "\\images")) ? UiManager.Selected_Folder : (UiManager.Selected_Folder + "\\images"));
			LoadFolderXml = loadFolderXml;
			MyProject.Forms.LoadXML.ShowDialog();
			if (Operators.CompareString(nameXML, "", TextCompare: false) == 0)
			{
				CancelLOad();
				return;
			}
			Loadsss(nameXML);
			txtrawxml.Text = LoadFolderXml;
		}
	}

	private void Guna2Button11_Click(object sender, EventArgs e)
	{
		if (DataGridView1.Rows.Count > 0)
		{
			bool flag = false;
			foreach (DataGridViewRow item in (IEnumerable)DataGridView1.Rows)
			{
				if (Convert.ToBoolean(RuntimeHelpers.GetObjectValue(item.Cells[0].Value)))
				{
					flag = true;
				}
			}
			if (flag)
			{
				start();
				ThreadNew = new Thread(flash);
				ThreadNew.Start();
			}
			else
			{
				MessageBox.Show("Please Select The Partition First!", MyProject.Forms.Form1.Text, MessageBoxButtons.OK);
			}
		}
		else
		{
			MessageBox.Show("Please Insert The Raw XML/Definition File First!", MyProject.Forms.Form1.Text, MessageBoxButtons.OK);
		}
	}

	public void flash()
	{
		if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0 && Conversions.ToDouble(Form1.SharedUI.Label25.Text) == 0.0)
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.YDNHBPR);
			finshonly();
			return;
		}
		if (Guna2RadioButton11.Checked)
		{
			if (string.IsNullOrEmpty(txtloader.Text))
			{
				UiManager.Richlogs("Select Loader File First!", Color.Red, isBold: false);
				finshonly();
				return;
			}
			SAHARA_MANAGER.Loader = File.ReadAllBytes(txtloader.Text);
			if (!Encoding.UTF8.GetString(SAHARA_MANAGER.Loader).Contains("ELF"))
			{
				UiManager.Richlogs("Loader is Invalid Or Encrypted", Color.Red, isBold: false);
				finshonly();
				return;
			}
		}
		FIREHOSE_OPERATIONS.MenuEx = FIREHOSE_OPERATIONS.MenuEksekusi.manual;
		FIREHOSE_OPERATIONS.MenuMan = FIREHOSE_OPERATIONS.MenuManual.flash;
		FIREHOSE_MANAGER.StringXml += "<?xml version=\"1.0\" ?>\r\n";
		FIREHOSE_MANAGER.StringXml += "<data>\r\n";
		FIREHOSE_MANAGER.totalchecked = 0;
		checked
		{
			foreach (DataGridViewRow item in (IEnumerable)DataGridView1.Rows)
			{
				if (Convert.ToBoolean(RuntimeHelpers.GetObjectValue(item.Cells[DataGridView1.Columns[0].Index].Value)) && File.Exists(item.Cells[DataGridView1.Columns[2].Index].Value.ToString()))
				{
					FIREHOSE_MANAGER.totalchecked++;
					FIREHOSE_MANAGER.StringXml = FIREHOSE_MANAGER.StringXml + $"<program SECTOR_SIZE_IN_BYTES=\"{FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES}\" file_sector_offset=\"0\" filename=\"{item.Cells[DataGridView1.Columns[2].Index].Value}\" label=\"{item.Cells[DataGridView1.Columns[1].Index].Value}\" num_partition_sectors=\"{item.Cells[DataGridView1.Columns[4].Index].Value}\" physical_partition_number=\"{item.Cells[DataGridView1.Columns[5].Index].Value}\" start_sector=\"{item.Cells[DataGridView1.Columns[3].Index].Value}\"/>" + "\r\n";
				}
			}
			FIREHOSE_MANAGER.StringXml += "</data>";
			UiManager.CariPortQcom_Tick();
			if (Form1.SharedUI.RichTextBox1.Text.Contains("- Reboot Device : Done"))
			{
				finsh();
			}
			else if (Form1.SharedUI.RichTextBox1.Text.Contains("- Scanning Partitions Data : Found") | Form1.SharedUI.RichTextBox1.Text.Contains("Userarea :"))
			{
				if (Form1.SharedUI.RichTextBox1.Text.Contains("Failed"))
				{
					finshfile();
				}
				else
				{
					finshonly();
				}
			}
			else
			{
				finshfile();
			}
		}
	}

	private void Guna2Button2_Click(object sender, EventArgs e)
	{
		start();
		ThreadNew = new Thread(REMOVE_MI_BY_patch);
		ThreadNew.Start();
	}

	public void REMOVE_MI_BY_patch()
	{
		if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0 && Conversions.ToDouble(Form1.SharedUI.Label25.Text) == 0.0)
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.YDNHBPR);
			finshonly();
			return;
		}
		String_35 = "Remove Mi Account [EDL]";
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
		if (Guna2RadioButton11.Checked)
		{
			if (string.IsNullOrEmpty(txtloader.Text))
			{
				UiManager.Richlogs("Select Loader File First!", Color.Red, isBold: false);
				finshonly();
				return;
			}
			SAHARA_MANAGER.Loader = File.ReadAllBytes(txtloader.Text);
			if (!Encoding.UTF8.GetString(SAHARA_MANAGER.Loader).Contains("ELF"))
			{
				UiManager.Richlogs("Loader is Invalid Or Encrypted", Color.Red, isBold: false);
				finshonly();
				return;
			}
		}
		FIREHOSE_OPERATIONS.MenuEx = FIREHOSE_OPERATIONS.MenuEksekusi.manual;
		FIREHOSE_OPERATIONS.MenuMan = FIREHOSE_OPERATIONS.MenuManual.readgpt_clean_mi;
		DataView.Rows.Clear();
		UiManager.CariPortQcom_Tick();
		if (Form1.SharedUI.RichTextBox1.Text.Contains("- Reboot Device : Done") | Form1.SharedUI.RichTextBox1.Text.Contains("- Patching Mi Account Data"))
		{
			finsh();
		}
		else
		{
			finshfile();
		}
	}

	private void Guna2Button3_Click(object sender, EventArgs e)
	{
		start();
		ThreadNew = new Thread(REMOVE_MI_BY_clean);
		ThreadNew.Start();
	}

	public void REMOVE_MI_BY_clean()
	{
		if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0 && Conversions.ToDouble(Form1.SharedUI.Label25.Text) == 0.0)
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.YDNHBPR);
			finshonly();
			return;
		}
		String_35 = "Remove Mi Account [EDL]";
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
		if (Guna2RadioButton11.Checked)
		{
			if (string.IsNullOrEmpty(txtloader.Text))
			{
				UiManager.Richlogs("Select Loader File First!", Color.Red, isBold: false);
				finshonly();
				return;
			}
			SAHARA_MANAGER.Loader = File.ReadAllBytes(txtloader.Text);
			if (!Encoding.UTF8.GetString(SAHARA_MANAGER.Loader).Contains("ELF"))
			{
				UiManager.Richlogs("Loader is Invalid Or Encrypted", Color.Red, isBold: false);
				finshonly();
				return;
			}
		}
		FIREHOSE_OPERATIONS.MenuEx = FIREHOSE_OPERATIONS.MenuEksekusi.manual;
		FIREHOSE_OPERATIONS.MenuMan = FIREHOSE_OPERATIONS.MenuManual.readgpt_clean_mi;
		DataView.Rows.Clear();
		UiManager.CariPortQcom_Tick();
		if (Form1.SharedUI.RichTextBox1.Text.Contains("- Reboot Device : Done") | Form1.SharedUI.RichTextBox1.Text.Contains("- Patching Mi Account Data"))
		{
			finsh();
		}
		else
		{
			finshfile();
		}
	}

	private void Guna2Button4_Click(object sender, EventArgs e)
	{
		start();
		ThreadNew = new Thread(REMOVE_ID_BY_clean);
		ThreadNew.Start();
	}

	public void REMOVE_ID_BY_clean()
	{
		if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0 && Conversions.ToDouble(Form1.SharedUI.Label25.Text) == 0.0)
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.YDNHBPR);
			finshonly();
			return;
		}
		String_35 = "Remove ID Huawei [EDL]";
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
		if (Guna2RadioButton11.Checked)
		{
			if (string.IsNullOrEmpty(txtloader.Text))
			{
				UiManager.Richlogs("Select Loader File First!", Color.Red, isBold: false);
				finshonly();
				return;
			}
			SAHARA_MANAGER.Loader = File.ReadAllBytes(txtloader.Text);
			if (!Encoding.UTF8.GetString(SAHARA_MANAGER.Loader).Contains("ELF"))
			{
				UiManager.Richlogs("Loader is Invalid Or Encrypted", Color.Red, isBold: false);
				finshonly();
				return;
			}
		}
		FIREHOSE_OPERATIONS.MenuEx = FIREHOSE_OPERATIONS.MenuEksekusi.manual;
		FIREHOSE_OPERATIONS.MenuMan = FIREHOSE_OPERATIONS.MenuManual.readgpt_erase;
		FIREHOSE_MANAGER.Partition_Name = "ID";
		DataView.Rows.Clear();
		UiManager.CariPortQcom_Tick();
		if (Form1.SharedUI.RichTextBox1.Text.Contains("- Reboot Device : Done") | Form1.SharedUI.RichTextBox1.Text.Contains("- Remove ID"))
		{
			finsh();
		}
		else
		{
			finshfile();
		}
	}

	private void Guna2Button5_Click(object sender, EventArgs e)
	{
		start();
		ThreadNew = new Thread(reset_modems);
		ThreadNew.Start();
	}

	public void reset_modems()
	{
		if (Guna2RadioButton11.Checked)
		{
			if (string.IsNullOrEmpty(txtloader.Text))
			{
				UiManager.Richlogs("Select Loader File First!", Color.Red, isBold: false);
				finshonly();
				return;
			}
			SAHARA_MANAGER.Loader = File.ReadAllBytes(txtloader.Text);
			if (!Encoding.UTF8.GetString(SAHARA_MANAGER.Loader).Contains("ELF"))
			{
				UiManager.Richlogs("Loader is Invalid Or Encrypted", Color.Red, isBold: false);
				finshonly();
				return;
			}
		}
		FIREHOSE_OPERATIONS.MenuEx = FIREHOSE_OPERATIONS.MenuEksekusi.manual;
		FIREHOSE_OPERATIONS.MenuMan = FIREHOSE_OPERATIONS.MenuManual.readgpt_erase;
		FIREHOSE_MANAGER.Partition_Name = "modems";
		UiManager.CariPortQcom_Tick();
		if (Form1.SharedUI.RichTextBox1.Text.Contains("- Reboot Device : Done") | Form1.SharedUI.RichTextBox1.Text.Contains("- Reset Modems"))
		{
			finsh();
		}
		else
		{
			finshfile();
		}
	}

	private void Guna2Button9_Click(object sender, EventArgs e)
	{
		if (ComboBoxSecurity.SelectedIndex == 0)
		{
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog
			{
				ShowNewFolderButton = true
			};
			if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				FIREHOSE_MANAGER.foldersave = folderBrowserDialog.SelectedPath;
				start();
				ThreadNew = new Thread(read_efs);
				ThreadNew.Start();
			}
		}
		if (ComboBoxSecurity.SelectedIndex == 1)
		{
			start();
			ThreadNew = new Thread(reset_efs);
			ThreadNew.Start();
		}
	}

	public void read_efs()
	{
		if (Guna2RadioButton11.Checked)
		{
			if (string.IsNullOrEmpty(txtloader.Text))
			{
				UiManager.Richlogs("Select Loader File First!", Color.Red, isBold: false);
				finshonly();
				return;
			}
			SAHARA_MANAGER.Loader = File.ReadAllBytes(txtloader.Text);
			if (!Encoding.UTF8.GetString(SAHARA_MANAGER.Loader).Contains("ELF"))
			{
				UiManager.Richlogs("Loader is Invalid Or Encrypted", Color.Red, isBold: false);
				finshonly();
				return;
			}
		}
		FIREHOSE_OPERATIONS.MenuEx = FIREHOSE_OPERATIONS.MenuEksekusi.manual;
		FIREHOSE_OPERATIONS.MenuMan = FIREHOSE_OPERATIONS.MenuManual.readgpt_read;
		FIREHOSE_MANAGER.Partition_Name = "efs";
		UiManager.CariPortQcom_Tick();
		if (Form1.SharedUI.RichTextBox1.Text.Contains("- Reboot Device : Done") | Form1.SharedUI.RichTextBox1.Text.Contains("- Reading Partition"))
		{
			finsh();
		}
		else
		{
			finshfile();
		}
	}

	public void reset_efs()
	{
		if (Guna2RadioButton11.Checked)
		{
			if (string.IsNullOrEmpty(txtloader.Text))
			{
				UiManager.Richlogs("Select Loader File First!", Color.Red, isBold: false);
				finshonly();
				return;
			}
			SAHARA_MANAGER.Loader = File.ReadAllBytes(txtloader.Text);
			if (!Encoding.UTF8.GetString(SAHARA_MANAGER.Loader).Contains("ELF"))
			{
				UiManager.Richlogs("Loader is Invalid Or Encrypted", Color.Red, isBold: false);
				finshonly();
				return;
			}
		}
		FIREHOSE_OPERATIONS.MenuEx = FIREHOSE_OPERATIONS.MenuEksekusi.manual;
		FIREHOSE_OPERATIONS.MenuMan = FIREHOSE_OPERATIONS.MenuManual.readgpt_erase;
		FIREHOSE_MANAGER.Partition_Name = "efs";
		UiManager.CariPortQcom_Tick();
		if (Form1.SharedUI.RichTextBox1.Text.Contains("- Reboot Device : Done") | Form1.SharedUI.RichTextBox1.Text.Contains("- Wieping EFS"))
		{
			finsh();
		}
		else
		{
			finshfile();
		}
	}

	private void Guna2Button10_Click(object sender, EventArgs e)
	{
		start();
		ThreadNew = new Thread(reset_data);
		ThreadNew.Start();
	}

	private void Guna2Button7_Click(object sender, EventArgs e)
	{
		start();
		ThreadNew = new Thread(REMOVE_kg_BY_clean);
		ThreadNew.Start();
	}

	public void REMOVE_knox()
	{
		if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0 && Conversions.ToDouble(Form1.SharedUI.Label25.Text) == 0.0)
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.YDNHBPR);
			finshonly();
			return;
		}
		String_35 = "Remove Knox [EDL]";
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
		if (Guna2RadioButton11.Checked)
		{
			if (string.IsNullOrEmpty(txtloader.Text))
			{
				UiManager.Richlogs("Select Loader File First!", Color.Red, isBold: false);
				finshonly();
				return;
			}
			SAHARA_MANAGER.Loader = File.ReadAllBytes(txtloader.Text);
			if (!Encoding.UTF8.GetString(SAHARA_MANAGER.Loader).Contains("ELF"))
			{
				UiManager.Richlogs("Loader is Invalid Or Encrypted", Color.Red, isBold: false);
				finshonly();
				return;
			}
		}
		FIREHOSE_OPERATIONS.MenuEx = FIREHOSE_OPERATIONS.MenuEksekusi.manual;
		FIREHOSE_OPERATIONS.MenuMan = FIREHOSE_OPERATIONS.MenuManual.readgpt_erase;
		FIREHOSE_MANAGER.Partition_Name = "knox";
		DataView.Rows.Clear();
		UiManager.CariPortQcom_Tick();
		if (Form1.SharedUI.RichTextBox1.Text.Contains("- Reboot Device : Done") | Form1.SharedUI.RichTextBox1.Text.Contains("- Remove Knox"))
		{
			finsh();
		}
		else
		{
			finshfile();
		}
	}

	private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		if (DataGridView1.Rows.Count > 0 && e.ColumnIndex == 2)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog
			{
				Title = "Choose File " + DataGridView1.CurrentRow.Cells[1].Value.ToString(),
				InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer),
				FileName = "",
				Filter = "ALL FILE  (*.*)|*.*",
				FilterIndex = 2,
				RestoreDirectory = true
			};
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				DataGridView1.CurrentRow.Cells[0].Value = true;
				DataGridView1.CurrentRow.Cells[2].Value = openFileDialog.FileName;
			}
		}
	}

	public void REMOVE_kg_BY_clean()
	{
		if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0 && Conversions.ToDouble(Form1.SharedUI.Label25.Text) == 0.0)
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.YDNHBPR);
			finshonly();
			return;
		}
		String_35 = "Remove KG/Knox [EDL]";
		if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
		{
			String_75 = Conversions.ToString(2);
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
		if (Guna2RadioButton11.Checked)
		{
			if (string.IsNullOrEmpty(txtloader.Text))
			{
				UiManager.Richlogs("Select Loader File First!", Color.Red, isBold: false);
				finshonly();
				return;
			}
			SAHARA_MANAGER.Loader = File.ReadAllBytes(txtloader.Text);
			if (!Encoding.UTF8.GetString(SAHARA_MANAGER.Loader).Contains("ELF"))
			{
				UiManager.Richlogs("Loader is Invalid Or Encrypted", Color.Red, isBold: false);
				finshonly();
				return;
			}
		}
		FIREHOSE_OPERATIONS.MenuEx = FIREHOSE_OPERATIONS.MenuEksekusi.manual;
		FIREHOSE_OPERATIONS.MenuMan = FIREHOSE_OPERATIONS.MenuManual.readgpt_patch_kg;
		DataView.Rows.Clear();
		UiManager.CariPortQcom_Tick();
		if (Form1.SharedUI.RichTextBox1.Text.Contains("- Reboot Device : Done") | Form1.SharedUI.RichTextBox1.Text.Contains("- Verfing KG/Knox States"))
		{
			finsh();
		}
		else
		{
			finshfile();
		}
	}

	private void Guna2Button8_Click(object sender, EventArgs e)
	{
		start();
		ThreadNew = new Thread(REMOVE_kg_BY_clean);
		ThreadNew.Start();
	}

	private void Guna2Button12_Click(object sender, EventArgs e)
	{
		start();
		ThreadNew = new Thread(REMOVE_knox);
		ThreadNew.Start();
	}

	public void reset_data()
	{
		if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0 && Conversions.ToDouble(Form1.SharedUI.Label25.Text) == 0.0)
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.YDNHBPR);
			finshonly();
			return;
		}
		String_35 = "Factory Reset [EDL]";
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
		if (Guna2RadioButton11.Checked)
		{
			if (string.IsNullOrEmpty(txtloader.Text))
			{
				UiManager.Richlogs("Select Loader File First!", Color.Red, isBold: false);
				finshonly();
				return;
			}
			SAHARA_MANAGER.Loader = File.ReadAllBytes(txtloader.Text);
			if (!Encoding.UTF8.GetString(SAHARA_MANAGER.Loader).Contains("ELF"))
			{
				UiManager.Richlogs("Loader is Invalid Or Encrypted", Color.Red, isBold: false);
				finshonly();
				return;
			}
		}
		FIREHOSE_OPERATIONS.MenuEx = FIREHOSE_OPERATIONS.MenuEksekusi.manual;
		FIREHOSE_OPERATIONS.MenuMan = FIREHOSE_OPERATIONS.MenuManual.readgpt_erase_user;
		FIREHOSE_MANAGER.Partition_Name = "misc";
		UiManager.CariPortQcom_Tick();
		if (Form1.SharedUI.RichTextBox1.Text.Contains("- Reboot Device : Done") | Form1.SharedUI.RichTextBox1.Text.Contains("- Factory Reset"))
		{
			finsh();
		}
		else
		{
			finshfile();
		}
	}

    private void Guna2Button15_Click_1(object sender, EventArgs e)
    {

    }

    private void txtloader_TextChanged(object sender, EventArgs e)
    {

    }

    private void EDL_Load_1(object sender, EventArgs e)
    {

    }
}
