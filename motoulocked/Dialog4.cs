using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using libeay32.Device;
using Microsoft.VisualBasic.CompilerServices;
using motoulocked.motoulocked;
using Properties;

namespace motoulocked;

[DesignerGenerated]
public class Dialog4 : Form
{
	private IContainer components;

	public static string String_14;
    /*
	[field: AccessedThroughProperty("PictureBox1")]
	internal  PictureBox PictureBox1
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

	[field: AccessedThroughProperty("QcomString")]
	internal  Label QcomString
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Guna2VSeparator1")]
	internal  Guna2VSeparator Guna2VSeparator1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}
	*/
    internal PictureBox PictureBox1;
    internal Guna2GroupBox Guna2GroupBox1;
    internal Guna2Separator Guna2Separator3;
    internal Label Label2;
    internal Label QcomString;
    internal Guna2VSeparator Guna2VSeparator1;

    public Dialog4()
	{
		base.Load += Dialog4_Load;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dialog4));
		this.PictureBox1 = new System.Windows.Forms.PictureBox();
		this.Guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
		this.Guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
		this.QcomString = new System.Windows.Forms.Label();
		this.Guna2Separator3 = new Guna.UI2.WinForms.Guna2Separator();
		this.Label2 = new System.Windows.Forms.Label();
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
		this.Guna2GroupBox1.SuspendLayout();
		base.SuspendLayout();
		this.PictureBox1.BackColor = System.Drawing.Color.Transparent;
		this.PictureBox1.Image = Properties.Resources._٢٠٢٤١٠٠٢_٠٩١٥١٧;
		this.PictureBox1.Location = new System.Drawing.Point(-2, 13);
		this.PictureBox1.Name = "PictureBox1";
		this.PictureBox1.Size = new System.Drawing.Size(351, 374);
		this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.PictureBox1.TabIndex = 471;
		this.PictureBox1.TabStop = false;
		this.Guna2GroupBox1.BackColor = System.Drawing.Color.Transparent;
		this.Guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(85, 85, 85);
		this.Guna2GroupBox1.BorderRadius = 6;
		this.Guna2GroupBox1.BorderThickness = 2;
		this.Guna2GroupBox1.Controls.Add(this.Guna2VSeparator1);
		this.Guna2GroupBox1.Controls.Add(this.QcomString);
		this.Guna2GroupBox1.Controls.Add(this.Guna2Separator3);
		this.Guna2GroupBox1.Controls.Add(this.Label2);
		this.Guna2GroupBox1.Controls.Add(this.PictureBox1);
		this.Guna2GroupBox1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(70, 70, 70);
		this.Guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0);
		this.Guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(50, 50, 50);
		this.Guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Guna2GroupBox1.ForeColor = System.Drawing.Color.White;
		this.Guna2GroupBox1.Location = new System.Drawing.Point(12, 12);
		this.Guna2GroupBox1.Name = "Guna2GroupBox1";
		this.Guna2GroupBox1.ShadowDecoration.BorderRadius = 9;
		this.Guna2GroupBox1.ShadowDecoration.Color = System.Drawing.Color.White;
		this.Guna2GroupBox1.ShadowDecoration.Depth = 15;
		this.Guna2GroupBox1.Size = new System.Drawing.Size(699, 399);
		this.Guna2GroupBox1.TabIndex = 481;
		this.Guna2VSeparator1.FillColor = System.Drawing.Color.DimGray;
		this.Guna2VSeparator1.FillThickness = 2;
		this.Guna2VSeparator1.Location = new System.Drawing.Point(343, 4);
		this.Guna2VSeparator1.Name = "Guna2VSeparator1";
		this.Guna2VSeparator1.Size = new System.Drawing.Size(10, 392);
		this.Guna2VSeparator1.TabIndex = 490;
		this.QcomString.AutoSize = true;
		this.QcomString.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.QcomString.ForeColor = System.Drawing.Color.White;
		this.QcomString.Location = new System.Drawing.Point(373, 90);
		this.QcomString.Name = "QcomString";
		this.QcomString.Size = new System.Drawing.Size(301, 20);
		this.QcomString.TabIndex = 489;
		this.QcomString.Text = "Press Volume Up For Continue The Process\r\n";
		this.Guna2Separator3.BackColor = System.Drawing.Color.Transparent;
		this.Guna2Separator3.Cursor = System.Windows.Forms.Cursors.Hand;
		this.Guna2Separator3.FillColor = System.Drawing.Color.DimGray;
		this.Guna2Separator3.FillThickness = 2;
		this.Guna2Separator3.Location = new System.Drawing.Point(344, 194);
		this.Guna2Separator3.Name = "Guna2Separator3";
		this.Guna2Separator3.Size = new System.Drawing.Size(352, 10);
		this.Guna2Separator3.TabIndex = 484;
		this.Label2.AutoSize = true;
		this.Label2.Font = new System.Drawing.Font("Yu Gothic", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label2.ForeColor = System.Drawing.Color.White;
		this.Label2.Location = new System.Drawing.Point(371, 291);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(301, 17);
		this.Label2.TabIndex = 482;
		this.Label2.Text = "اضغط على زر رفع الصوت في الهاتف لمواصلة العملية";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
		base.ClientSize = new System.Drawing.Size(723, 423);
		base.ControlBox = false;
		base.Controls.Add(this.Guna2GroupBox1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "Dialog4";
		base.ShowInTaskbar = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = " ";
		base.TopMost = true;
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
		this.Guna2GroupBox1.ResumeLayout(false);
		this.Guna2GroupBox1.PerformLayout();
		base.ResumeLayout(false);
	}

	private void Dialog4_Load(object sender, EventArgs e)
	{
		new Thread(un).Start();
	}

	public void un()
	{
		Fastboot.ExecuteFastbootCommand(Fastboot.FormFastbootCommand("flashing " + String_14, new string[0]));
		SerialCOM.MSL = "";
		Close();
	}
}
