using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic.CompilerServices;
using motoulocked.motoulocked;


namespace motoulocked;
public class Dialog1 : Form
{
	private IContainer components;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2Button17")]
	private Guna2Button _Guna2Button17;

	[CompilerGenerated]
	[AccessedThroughProperty("MaterialButton10")]
	private Guna2Button _MaterialButton10;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2Button2")]
	private Guna2Button _Guna2Button2;

	[CompilerGenerated]
	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[CompilerGenerated]
	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[CompilerGenerated]
	[AccessedThroughProperty("Label12")]
	private Label _Label12;

	[CompilerGenerated]
	[AccessedThroughProperty("QcomString")]
	private Label _Label11;

	[CompilerGenerated]
	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	[CompilerGenerated]
	[AccessedThroughProperty("CheckBox2")]
	private Guna2CheckBox _CheckBox2;

	[field: AccessedThroughProperty("TableLayoutPanel1")]
    /*
	internal  TableLayoutPanel TableLayoutPanel1
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

	internal  Guna2Button MaterialButton10
	{
		[CompilerGenerated]
		get
		{
			return _MaterialButton10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = MaterialButton10_Click;
			Guna2Button materialButton = _MaterialButton10;
			if (materialButton != null)
			{
				materialButton.Click -= value2;
			}
			_MaterialButton10 = value;
			materialButton = _MaterialButton10;
			if (materialButton != null)
			{
				materialButton.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("PictureBox1")]
	internal  PictureBox PictureBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label4")]
	internal  Label Label4
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

	[field: AccessedThroughProperty("Label1")]
	internal  Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label5")]
	internal  Label Label5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label3")]
	internal  Label Label3
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

	[field: AccessedThroughProperty("Label7")]
	internal  Label Label7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label6")]
	internal  Label Label6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal  Label Label9
	{
		[CompilerGenerated]
		get
		{
			return _Label9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Label9_Click;
			Label label = _Label9;
			if (label != null)
			{
				label.Click -= value2;
			}
			_Label9 = value;
			label = _Label9;
			if (label != null)
			{
				label.Click += value2;
			}
		}
	}

	internal  Label Label8
	{
		[CompilerGenerated]
		get
		{
			return _Label8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Label8_Click;
			Label label = _Label8;
			if (label != null)
			{
				label.Click -= value2;
			}
			_Label8 = value;
			label = _Label8;
			if (label != null)
			{
				label.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Guna2Separator1")]
	internal  Guna2Separator Guna2Separator1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Guna2Separator2")]
	internal  Guna2Separator Guna2Separator2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal  Label Label12
	{
		[CompilerGenerated]
		get
		{
			return _Label12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Label12_Click;
			Label label = _Label12;
			if (label != null)
			{
				label.Click -= value2;
			}
			_Label12 = value;
			label = _Label12;
			if (label != null)
			{
				label.Click += value2;
			}
		}
	}

	internal  Label QcomString
	{
		[CompilerGenerated]
		get
		{
			return _Label11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Label11_Click;
			Label label = _Label11;
			if (label != null)
			{
				label.Click -= value2;
			}
			_Label11 = value;
			label = _Label11;
			if (label != null)
			{
				label.Click += value2;
			}
		}
	}

	internal  Label Label10
	{
		[CompilerGenerated]
		get
		{
			return _Label10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Label10_Click;
			Label label = _Label10;
			if (label != null)
			{
				label.Click -= value2;
			}
			_Label10 = value;
			label = _Label10;
			if (label != null)
			{
				label.Click += value2;
			}
		}
	}

	internal  Guna2CheckBox CheckBox2
	{
		[CompilerGenerated]
		get
		{
			return _CheckBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = CheckBox2_CheckedChanged;
			Guna2CheckBox checkBox = _CheckBox2;
			if (checkBox != null)
			{
				checkBox.CheckedChanged -= value2;
			}
			_CheckBox2 = value;
			checkBox = _CheckBox2;
			if (checkBox != null)
			{
				checkBox.CheckedChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Guna2GroupBox1")]
	internal  Guna2GroupBox Guna2GroupBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label15")]
	internal  Label Label15
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label14")]
	internal  Label Label14
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label13")]
	internal  Label Label13
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}
	*/
    public Dialog1()
	{
		base.Load += Dialog1_Load;
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
	
    internal  TableLayoutPanel TableLayoutPanel1;
    internal  Guna2Button Guna2Button17;
    internal  Guna2Button MaterialButton10;
    internal  PictureBox PictureBox1;
    internal  Label Label4;
    internal  Label Label2;
    internal  Label Label1;
    internal  Label Label5;
    internal  Label Label3;
    internal  Guna2Button Guna2Button2;
    internal  Label Label7;
    internal  Label Label6;
    internal  Label Label9;
    internal  Label Label8;
    internal  Guna2Separator Guna2Separator1;
    internal  Guna2Separator Guna2Separator2;
    internal  Label Label12;
    internal  Label QcomString;
    internal  Label Label10;
    internal  Guna2CheckBox CheckBox2;
    internal  Guna2GroupBox Guna2GroupBox1;
    internal  Label Label15;
    internal  Label Label14;
    internal  Label Label13;

    [System.Diagnostics.DebuggerStepThrough]
	private void InitializeComponent()
	{
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dialog1));
		this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
		this.MaterialButton10 = new Guna.UI2.WinForms.Guna2Button();
		this.Guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
		this.Guna2Button17 = new Guna.UI2.WinForms.Guna2Button();
		this.CheckBox2 = new Guna.UI2.WinForms.Guna2CheckBox();
		this.Label12 = new System.Windows.Forms.Label();
		this.QcomString = new System.Windows.Forms.Label();
		this.Label10 = new System.Windows.Forms.Label();
		this.Label9 = new System.Windows.Forms.Label();
		this.Label8 = new System.Windows.Forms.Label();
		this.Guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
		this.Guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
		this.Label7 = new System.Windows.Forms.Label();
		this.Label6 = new System.Windows.Forms.Label();
		this.Label5 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label1 = new System.Windows.Forms.Label();
		this.Label4 = new System.Windows.Forms.Label();
		this.Guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
		this.Label15 = new System.Windows.Forms.Label();
		this.Label14 = new System.Windows.Forms.Label();
		this.Label13 = new System.Windows.Forms.Label();
		this.PictureBox1 = new System.Windows.Forms.PictureBox();
		this.TableLayoutPanel1.SuspendLayout();
		this.Guna2GroupBox1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
		base.SuspendLayout();
		this.TableLayoutPanel1.ColumnCount = 3;
		this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.94017f));
		this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.05983f));
		this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 118f));
		this.TableLayoutPanel1.Controls.Add(this.MaterialButton10, 0, 0);
		this.TableLayoutPanel1.Controls.Add(this.Guna2Button2, 1, 0);
		this.TableLayoutPanel1.Controls.Add(this.Guna2Button17, 2, 0);
		this.TableLayoutPanel1.Location = new System.Drawing.Point(6, 449);
		this.TableLayoutPanel1.Name = "TableLayoutPanel1";
		this.TableLayoutPanel1.RowCount = 1;
		this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50f));
		this.TableLayoutPanel1.Size = new System.Drawing.Size(586, 32);
		this.TableLayoutPanel1.TabIndex = 0;
		this.MaterialButton10.Animated = true;
		this.MaterialButton10.BorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.MaterialButton10.BorderRadius = 4;
		this.MaterialButton10.BorderThickness = 2;
		this.MaterialButton10.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
		this.MaterialButton10.CheckedState.FillColor = System.Drawing.Color.LightGray;
		this.MaterialButton10.DialogResult = System.Windows.Forms.DialogResult.OK;
		this.MaterialButton10.DisabledState.BorderColor = System.Drawing.Color.FromArgb(55, 55, 55);
		this.MaterialButton10.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
		this.MaterialButton10.DisabledState.FillColor = System.Drawing.Color.FromArgb(55, 55, 55);
		this.MaterialButton10.DisabledState.ForeColor = System.Drawing.Color.Gray;
		this.MaterialButton10.Enabled = false;
		this.MaterialButton10.FillColor = System.Drawing.Color.FromArgb(70, 70, 70);
		this.MaterialButton10.Font = new System.Drawing.Font("Yu Gothic UI", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.MaterialButton10.ForeColor = System.Drawing.Color.White;
		this.MaterialButton10.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
		this.MaterialButton10.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
		this.MaterialButton10.Image =global::Properties.Resources.tick;
		this.MaterialButton10.ImageSize = new System.Drawing.Size(17, 17);
		this.MaterialButton10.Location = new System.Drawing.Point(3, 3);
		this.MaterialButton10.Name = "MaterialButton10";
		this.MaterialButton10.PressedColor = System.Drawing.Color.Empty;
		this.MaterialButton10.Size = new System.Drawing.Size(325, 26);
		this.MaterialButton10.TabIndex = 438;
		this.MaterialButton10.Text = " OK";
		this.MaterialButton10.TextFormatNoPrefix = true;
		this.Guna2Button2.Animated = true;
		this.Guna2Button2.BorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.Guna2Button2.BorderRadius = 4;
		this.Guna2Button2.BorderThickness = 2;
		this.Guna2Button2.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
		this.Guna2Button2.CheckedState.FillColor = System.Drawing.Color.LightGray;
		this.Guna2Button2.DialogResult = System.Windows.Forms.DialogResult.OK;
		this.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(55, 55, 55);
		this.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
		this.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(55, 55, 55);
		this.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.Gray;
		this.Guna2Button2.FillColor = System.Drawing.Color.FromArgb(70, 70, 70);
		this.Guna2Button2.Font = new System.Drawing.Font("Yu Gothic UI", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Guna2Button2.ForeColor = System.Drawing.Color.White;
		this.Guna2Button2.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
		this.Guna2Button2.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
		this.Guna2Button2.Image = Properties.Resources.tweezer__1_;
		this.Guna2Button2.ImageSize = new System.Drawing.Size(28, 28);
		this.Guna2Button2.Location = new System.Drawing.Point(334, 3);
		this.Guna2Button2.Name = "Guna2Button2";
		this.Guna2Button2.PressedColor = System.Drawing.Color.Empty;
		this.Guna2Button2.Size = new System.Drawing.Size(130, 26);
		this.Guna2Button2.TabIndex = 455;
		this.Guna2Button2.Text = "  Test Point";
		this.Guna2Button2.TextFormatNoPrefix = true;
		this.Guna2Button17.Animated = true;
		this.Guna2Button17.BackColor = System.Drawing.Color.Transparent;
		this.Guna2Button17.BorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.Guna2Button17.BorderRadius = 4;
		this.Guna2Button17.BorderThickness = 2;
		this.Guna2Button17.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
		this.Guna2Button17.CheckedState.FillColor = System.Drawing.Color.LightGray;
		this.Guna2Button17.CheckedState.Image = (System.Drawing.Image)resources.GetObject("resource.Image");
		this.Guna2Button17.DialogResult = System.Windows.Forms.DialogResult.Cancel;
		this.Guna2Button17.DisabledState.BorderColor = System.Drawing.Color.FromArgb(55, 55, 55);
		this.Guna2Button17.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
		this.Guna2Button17.DisabledState.FillColor = System.Drawing.Color.FromArgb(55, 55, 55);
		this.Guna2Button17.DisabledState.ForeColor = System.Drawing.Color.Gray;
		this.Guna2Button17.FillColor = System.Drawing.Color.FromArgb(70, 70, 70);
		this.Guna2Button17.FocusedColor = System.Drawing.Color.Transparent;
		this.Guna2Button17.Font = new System.Drawing.Font("Yu Gothic UI", 9.75f, System.Drawing.FontStyle.Bold);
		this.Guna2Button17.ForeColor = System.Drawing.Color.White;
		this.Guna2Button17.HoverState.BorderColor = System.Drawing.Color.Red;
		this.Guna2Button17.HoverState.CustomBorderColor = System.Drawing.Color.Red;
		this.Guna2Button17.Image = Properties.Resources.close__1_;
		this.Guna2Button17.ImageSize = new System.Drawing.Size(18, 18);
		this.Guna2Button17.Location = new System.Drawing.Point(470, 3);
		this.Guna2Button17.Name = "Guna2Button17";
		this.Guna2Button17.PressedColor = System.Drawing.Color.Empty;
		this.Guna2Button17.ShadowDecoration.BorderRadius = 3;
		this.Guna2Button17.ShadowDecoration.Depth = 15;
		this.Guna2Button17.Size = new System.Drawing.Size(113, 26);
		this.Guna2Button17.TabIndex = 454;
		this.Guna2Button17.Text = "Cancel";
		this.Guna2Button17.TextFormatNoPrefix = true;
		this.CheckBox2.Animated = true;
		this.CheckBox2.AutoSize = true;
		this.CheckBox2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
		this.CheckBox2.CheckedState.BorderRadius = 4;
		this.CheckBox2.CheckedState.BorderThickness = 1;
		this.CheckBox2.CheckedState.FillColor = System.Drawing.Color.FromArgb(21, 87, 255);
		this.CheckBox2.Font = new System.Drawing.Font("Yu Gothic UI", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.CheckBox2.ForeColor = System.Drawing.Color.White;
		this.CheckBox2.Location = new System.Drawing.Point(12, 423);
		this.CheckBox2.Name = "CheckBox2";
		this.CheckBox2.Size = new System.Drawing.Size(576, 21);
		this.CheckBox2.TabIndex = 484;
		this.CheckBox2.Text = "I Accept The Terms And Conditions                                                                                    ";
		this.CheckBox2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.CheckBox2.UncheckedState.BorderRadius = 4;
		this.CheckBox2.UncheckedState.BorderThickness = 1;
		this.CheckBox2.UncheckedState.FillColor = System.Drawing.Color.FromArgb(55, 55, 55);
		this.Label12.Font = new System.Drawing.Font("Yu Gothic UI", 11.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label12.ForeColor = System.Drawing.Color.White;
		this.Label12.Location = new System.Drawing.Point(8, 121);
		this.Label12.Name = "Label12";
		this.Label12.Size = new System.Drawing.Size(395, 41);
		this.Label12.TabIndex = 485;
		this.Label12.Text = "4- Release The Keys And The Press (Volume Up) Key To\r\nContinue To Download Mode";
		this.QcomString.AutoSize = true;
		this.QcomString.Font = new System.Drawing.Font("Yu Gothic UI", 11.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.QcomString.ForeColor = System.Drawing.Color.White;
		this.QcomString.Location = new System.Drawing.Point(8, 96);
		this.QcomString.Name = "QcomString";
		this.QcomString.Size = new System.Drawing.Size(396, 20);
		this.QcomString.TabIndex = 482;
		this.QcomString.Text = "3- Press And Hold (Volume Up + Volume Down + Power)";
		this.Label10.AutoSize = true;
		this.Label10.Font = new System.Drawing.Font("Yu Gothic UI", 11.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label10.ForeColor = System.Drawing.Color.White;
		this.Label10.Location = new System.Drawing.Point(8, 70);
		this.Label10.Name = "Label10";
		this.Label10.Size = new System.Drawing.Size(134, 20);
		this.Label10.TabIndex = 481;
		this.Label10.Text = "2- Turn Off Mobile";
		this.Label9.AutoSize = true;
		this.Label9.Font = new System.Drawing.Font("Yu Gothic UI", 11.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label9.ForeColor = System.Drawing.Color.White;
		this.Label9.Location = new System.Drawing.Point(8, 43);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(265, 20);
		this.Label9.TabIndex = 480;
		this.Label9.Text = "1- Disconnect Mobile From USB Cable";
		this.Label8.AutoSize = true;
		this.Label8.Font = new System.Drawing.Font("Yu Gothic UI", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label8.ForeColor = System.Drawing.Color.White;
		this.Label8.Location = new System.Drawing.Point(4, 12);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(305, 21);
		this.Label8.TabIndex = 479;
		this.Label8.Text = "- How To Check KG And Sec Ctrl Status :-";
		this.Guna2Separator1.FillColor = System.Drawing.Color.Gray;
		this.Guna2Separator1.FillThickness = 2;
		this.Guna2Separator1.Location = new System.Drawing.Point(1, 345);
		this.Guna2Separator1.Name = "Guna2Separator1";
		this.Guna2Separator1.Size = new System.Drawing.Size(596, 10);
		this.Guna2Separator1.TabIndex = 478;
		this.Guna2Separator2.FillColor = System.Drawing.Color.Gray;
		this.Guna2Separator2.FillThickness = 2;
		this.Guna2Separator2.Location = new System.Drawing.Point(1, 180);
		this.Guna2Separator2.Name = "Guna2Separator2";
		this.Guna2Separator2.Size = new System.Drawing.Size(596, 10);
		this.Guna2Separator2.TabIndex = 477;
		this.Label7.AutoSize = true;
		this.Label7.Font = new System.Drawing.Font("Yu Gothic UI", 11.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label7.ForeColor = System.Drawing.Color.Silver;
		this.Label7.Location = new System.Drawing.Point(8, 400);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(302, 20);
		this.Label7.TabIndex = 476;
		this.Label7.Text = "▪\ufe0f IF Press Cancel Will Be Cancel Unlocking\r\n";
		this.Label6.AutoSize = true;
		this.Label6.Font = new System.Drawing.Font("Yu Gothic UI", 11.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label6.ForeColor = System.Drawing.Color.Silver;
		this.Label6.Location = new System.Drawing.Point(8, 379);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(463, 20);
		this.Label6.TabIndex = 475;
		this.Label6.Text = "▪\ufe0f IF Press Test Point Will Unlock The Device In Method (Test Point)";
		this.Label5.AutoSize = true;
		this.Label5.Font = new System.Drawing.Font("Yu Gothic UI", 11.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label5.ForeColor = System.Drawing.Color.Silver;
		this.Label5.Location = new System.Drawing.Point(8, 358);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(434, 20);
		this.Label5.TabIndex = 474;
		this.Label5.Text = "▪\ufe0f IF Press OK Will Unlock The Device In Method (Brom Mode)";
		this.Label3.AutoSize = true;
		this.Label3.Font = new System.Drawing.Font("Yu Gothic UI", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label3.ForeColor = System.Drawing.Color.White;
		this.Label3.Location = new System.Drawing.Point(4, 315);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(323, 21);
		this.Label3.TabIndex = 472;
		this.Label3.Text = "● IF Sec Ctrl Status (       ) Cancel Unlocking";
		this.Label2.AutoSize = true;
		this.Label2.Font = new System.Drawing.Font("Yu Gothic UI", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label2.ForeColor = System.Drawing.Color.White;
		this.Label2.Location = new System.Drawing.Point(4, 275);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(460, 21);
		this.Label2.TabIndex = 469;
		this.Label2.Text = "● IF KG Status (                                                  ) Cancel Unlocking";
		this.Label1.AutoSize = true;
		this.Label1.Font = new System.Drawing.Font("Yu Gothic UI", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label1.ForeColor = System.Drawing.Color.White;
		this.Label1.Location = new System.Drawing.Point(17, 239);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(477, 21);
		this.Label1.TabIndex = 468;
		this.Label1.Text = "Turn On Your Mobile Then Agree And Continue Unlocking Safely";
		this.Label4.AutoSize = true;
		this.Label4.Font = new System.Drawing.Font("Yu Gothic UI", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label4.ForeColor = System.Drawing.Color.White;
		this.Label4.Location = new System.Drawing.Point(4, 201);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(550, 21);
		this.Label4.TabIndex = 466;
		this.Label4.Text = "● IF KG Status (                                                                    ) Continue Unlocking";
		this.Guna2GroupBox1.BackColor = System.Drawing.Color.Transparent;
		this.Guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.Guna2GroupBox1.BorderRadius = 6;
		this.Guna2GroupBox1.BorderThickness = 2;
		this.Guna2GroupBox1.Controls.Add(this.Label15);
		this.Guna2GroupBox1.Controls.Add(this.Label14);
		this.Guna2GroupBox1.Controls.Add(this.Label13);
		this.Guna2GroupBox1.Controls.Add(this.CheckBox2);
		this.Guna2GroupBox1.Controls.Add(this.Label12);
		this.Guna2GroupBox1.Controls.Add(this.TableLayoutPanel1);
		this.Guna2GroupBox1.Controls.Add(this.QcomString);
		this.Guna2GroupBox1.Controls.Add(this.Label4);
		this.Guna2GroupBox1.Controls.Add(this.Label10);
		this.Guna2GroupBox1.Controls.Add(this.PictureBox1);
		this.Guna2GroupBox1.Controls.Add(this.Label9);
		this.Guna2GroupBox1.Controls.Add(this.Label1);
		this.Guna2GroupBox1.Controls.Add(this.Label8);
		this.Guna2GroupBox1.Controls.Add(this.Label2);
		this.Guna2GroupBox1.Controls.Add(this.Guna2Separator1);
		this.Guna2GroupBox1.Controls.Add(this.Guna2Separator2);
		this.Guna2GroupBox1.Controls.Add(this.Label7);
		this.Guna2GroupBox1.Controls.Add(this.Label3);
		this.Guna2GroupBox1.Controls.Add(this.Label6);
		this.Guna2GroupBox1.Controls.Add(this.Label5);
		this.Guna2GroupBox1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(70, 70, 70);
		this.Guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0);
		this.Guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(50, 50, 50);
		this.Guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Guna2GroupBox1.ForeColor = System.Drawing.Color.White;
		this.Guna2GroupBox1.Location = new System.Drawing.Point(7, 7);
		this.Guna2GroupBox1.Name = "Guna2GroupBox1";
		this.Guna2GroupBox1.ShadowDecoration.BorderRadius = 9;
		this.Guna2GroupBox1.ShadowDecoration.Color = System.Drawing.Color.White;
		this.Guna2GroupBox1.ShadowDecoration.Depth = 15;
		this.Guna2GroupBox1.Size = new System.Drawing.Size(598, 487);
		this.Guna2GroupBox1.TabIndex = 5;
		this.Label15.AutoSize = true;
		this.Label15.Font = new System.Drawing.Font("Yu Gothic UI", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label15.ForeColor = System.Drawing.Color.Red;
		this.Label15.Location = new System.Drawing.Point(164, 316);
		this.Label15.Name = "Label15";
		this.Label15.Size = new System.Drawing.Size(19, 21);
		this.Label15.TabIndex = 488;
		this.Label15.Text = "0";
		this.Label14.AutoSize = true;
		this.Label14.Font = new System.Drawing.Font("Yu Gothic UI", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label14.ForeColor = System.Drawing.Color.Red;
		this.Label14.Location = new System.Drawing.Point(129, 275);
		this.Label14.Name = "Label14";
		this.Label14.Size = new System.Drawing.Size(191, 21);
		this.Label14.TabIndex = 487;
		this.Label14.Text = "Active - Locked - Normal";
		this.Label13.AutoSize = true;
		this.Label13.Font = new System.Drawing.Font("Yu Gothic UI", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label13.ForeColor = System.Drawing.Color.Lime;
		this.Label13.Location = new System.Drawing.Point(130, 201);
		this.Label13.Name = "Label13";
		this.Label13.Size = new System.Drawing.Size(262, 21);
		this.Label13.TabIndex = 486;
		this.Label13.Text = "Checking - Completed - Prenormal";
		this.PictureBox1.BackColor = System.Drawing.Color.Transparent;
		this.PictureBox1.Image = Properties.Resources.post_479942_1640732582;
		this.PictureBox1.Location = new System.Drawing.Point(408, 7);
		this.PictureBox1.Name = "PictureBox1";
		this.PictureBox1.Size = new System.Drawing.Size(183, 172);
		this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.PictureBox1.TabIndex = 467;
		this.PictureBox1.TabStop = false;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
		base.ClientSize = new System.Drawing.Size(612, 501);
		base.ControlBox = false;
		base.Controls.Add(this.Guna2GroupBox1);
		this.DoubleBuffered = true;
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "Dialog1";
		base.ShowInTaskbar = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "                                                                            KG & Sec Ctrl Status Check";
		this.TableLayoutPanel1.ResumeLayout(false);
		this.Guna2GroupBox1.ResumeLayout(false);
		this.Guna2GroupBox1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
		base.ResumeLayout(false);
	}

	private void MaterialButton10_Click(object sender, EventArgs e)
	{
		Form1.String_60 = "Brom";
		SerialCOM.MSL = "";
		Close();
	}

	private void Guna2Button2_Click(object sender, EventArgs e)
	{
		Form1.String_60 = "Test";
		SerialCOM.MSL = "";
		Close();
	}

	private void Guna2Button17_Click(object sender, EventArgs e)
	{
		Form1.String_60 = "Cancel";
		SerialCOM.MSL = "";
		Close();
	}

	private void CheckBox2_CheckedChanged(object sender, EventArgs e)
	{
		if (!CheckBox2.Checked)
		{
			MaterialButton10.Enabled = false;
		}
		else
		{
			MaterialButton10.Enabled = true;
		}
	}

	private void Dialog1_Load(object sender, EventArgs e)
	{
		if ("SM-A136U-SM-A136U1".Contains(device_info.model))
		{
			Guna2Button2.Enabled = false;
		}
		else
		{
			Guna2Button2.Enabled = true;
		}
	}

	private void Label12_Click(object sender, EventArgs e)
	{
	}

	private void Label11_Click(object sender, EventArgs e)
	{
	}

	private void Label10_Click(object sender, EventArgs e)
	{
	}

	private void Label9_Click(object sender, EventArgs e)
	{
	}

	private void Label8_Click(object sender, EventArgs e)
	{
	}
}
