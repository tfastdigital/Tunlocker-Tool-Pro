using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic.CompilerServices;
using motoulocked.motoulocked;
using Properties;

namespace motoulocked;

[DesignerGenerated]
public class Dialog5 : Form
{
	private IContainer components;

	[CompilerGenerated]
	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[CompilerGenerated]
	[AccessedThroughProperty("MaterialButton10")]
	private Guna2Button _MaterialButton10;
    /*
	[field: AccessedThroughProperty("Guna2GroupBox1")]
	internal  Guna2GroupBox Guna2GroupBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("QcomString")]
	internal  Label QcomString
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Guna2Separator3")]
	internal  Guna2Separator Guna2Separator3
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

	[field: AccessedThroughProperty("PictureBox1")]
	internal  PictureBox PictureBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal  Timer Timer1
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
			Timer timer = _Timer1;
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
	*/
    internal Guna2GroupBox Guna2GroupBox1;
    internal Label QcomString;
    internal Guna2Separator Guna2Separator3;
    internal Label Label2;
    internal PictureBox PictureBox1;
    internal Timer Timer1;
    internal Guna2Button MaterialButton10;

    public Dialog5()
	{
		base.Load += Dialog5_Load;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dialog5));
            this.Guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.MaterialButton10 = new Guna.UI2.WinForms.Guna2Button();
            this.QcomString = new System.Windows.Forms.Label();
            this.Guna2Separator3 = new Guna.UI2.WinForms.Guna2Separator();
            this.Label2 = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.Guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Guna2GroupBox1
            // 
            this.Guna2GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.Guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2GroupBox1.BorderRadius = 6;
            this.Guna2GroupBox1.BorderThickness = 2;
            this.Guna2GroupBox1.Controls.Add(this.MaterialButton10);
            this.Guna2GroupBox1.Controls.Add(this.QcomString);
            this.Guna2GroupBox1.Controls.Add(this.Guna2Separator3);
            this.Guna2GroupBox1.Controls.Add(this.Label2);
            this.Guna2GroupBox1.Controls.Add(this.PictureBox1);
            this.Guna2GroupBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.Guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.Guna2GroupBox1.Location = new System.Drawing.Point(31, 21);
            this.Guna2GroupBox1.Name = "Guna2GroupBox1";
            this.Guna2GroupBox1.ShadowDecoration.BorderRadius = 9;
            this.Guna2GroupBox1.ShadowDecoration.Color = System.Drawing.Color.White;
            this.Guna2GroupBox1.ShadowDecoration.Depth = 15;
            this.Guna2GroupBox1.Size = new System.Drawing.Size(692, 437);
            this.Guna2GroupBox1.TabIndex = 482;
            // 
            // MaterialButton10
            // 
            this.MaterialButton10.Animated = true;
            this.MaterialButton10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.MaterialButton10.BorderRadius = 4;
            this.MaterialButton10.BorderThickness = 2;
            this.MaterialButton10.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.MaterialButton10.CheckedState.FillColor = System.Drawing.Color.LightGray;
            this.MaterialButton10.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.MaterialButton10.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.MaterialButton10.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.MaterialButton10.DisabledState.FillColor = System.Drawing.Color.Gainsboro;
            this.MaterialButton10.DisabledState.ForeColor = System.Drawing.Color.DimGray;
            this.MaterialButton10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.MaterialButton10.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.MaterialButton10.ForeColor = System.Drawing.Color.White;
            this.MaterialButton10.HoverState.BorderColor = System.Drawing.Color.Red;
            this.MaterialButton10.HoverState.CustomBorderColor = System.Drawing.Color.Red;
            this.MaterialButton10.ImageSize = new System.Drawing.Size(23, 23);
            this.MaterialButton10.Location = new System.Drawing.Point(546, 400);
            this.MaterialButton10.Name = "MaterialButton10";
            this.MaterialButton10.PressedColor = System.Drawing.Color.Empty;
            this.MaterialButton10.Size = new System.Drawing.Size(136, 26);
            this.MaterialButton10.TabIndex = 490;
            this.MaterialButton10.Text = " Stop Waiting";
            this.MaterialButton10.TextFormatNoPrefix = true;
            this.MaterialButton10.Click += new System.EventHandler(this.MaterialButton10_Click_1);
            // 
            // QcomString
            // 
            this.QcomString.AutoSize = true;
            this.QcomString.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QcomString.ForeColor = System.Drawing.Color.White;
            this.QcomString.Location = new System.Drawing.Point(43, 404);
            this.QcomString.Name = "QcomString";
            this.QcomString.Size = new System.Drawing.Size(468, 20);
            this.QcomString.TabIndex = 489;
            this.QcomString.Text = "Please Connect The Test-Point. The Program Is Waiting To Continue.";
            // 
            // Guna2Separator3
            // 
            this.Guna2Separator3.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Separator3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guna2Separator3.FillColor = System.Drawing.Color.DimGray;
            this.Guna2Separator3.FillThickness = 2;
            this.Guna2Separator3.Location = new System.Drawing.Point(3, 364);
            this.Guna2Separator3.Name = "Guna2Separator3";
            this.Guna2Separator3.Size = new System.Drawing.Size(686, 10);
            this.Guna2Separator3.TabIndex = 484;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(88, 381);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(381, 17);
            this.Label2.TabIndex = 482;
            this.Label2.Text = "يرجى توصيل نقطة الاختبار. البرنامج ينتظر حتى نتمكن من المتابعة";
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox1.Location = new System.Drawing.Point(61, 8);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(572, 355);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 471;
            this.PictureBox1.TabStop = false;
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 1;
            // 
            // Dialog5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(752, 483);
            this.ControlBox = false;
            this.Controls.Add(this.Guna2GroupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dialog5";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = " ";
            this.Guna2GroupBox1.ResumeLayout(false);
            this.Guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);

	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		if (Operators.CompareString(SerialCOM.MSL, "MESSAG_Test_Point=OK", TextCompare: false) == 0)
		{
			Close();
		}
	}

	private void MaterialButton10_Click(object sender, EventArgs e)
	{
		SerialCOM.MSL = "MESSAG_Test_Point=Stop";
		Close();
	}

	private void Dialog5_Load(object sender, EventArgs e)
	{
		if ("SM-A136U-SM-A136U1".Contains(device_info.model))
		{
			PictureBox1.Image = Resources.Samsung_A13_5G_SM_A136U;
		}
		else
		{
			PictureBox1.Image = Resources.A326U_TP2;
		}
	}

    private void MaterialButton10_Click_1(object sender, EventArgs e)
    {

    }
}
