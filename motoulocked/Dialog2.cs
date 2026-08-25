using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic.CompilerServices;
using Properties;

namespace motoulocked;

[DesignerGenerated]
public class Dialog2 : Form
{
	private IContainer components;

	[CompilerGenerated]
	[AccessedThroughProperty("MaterialButton10")]
	private Guna2Button _MaterialButton10;
    internal PictureBox PictureBox1;
    internal TableLayoutPanel TableLayoutPanel1;
    internal Guna2Button MaterialButton10;
    internal Guna2GroupBox Guna2GroupBox1;

   // [field: AccessedThroughProperty("PictureBox1")]
	/*
	internal  PictureBox PictureBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TableLayoutPanel1")]
	internal  TableLayoutPanel TableLayoutPanel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	[field: AccessedThroughProperty("Guna2GroupBox1")]
	internal  Guna2GroupBox Guna2GroupBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}
	*/
	public Dialog2()
	{
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
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.MaterialButton10 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.TableLayoutPanel1.SuspendLayout();
            this.Guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox1.Image = global::Properties.Resources.Screenshot_20240114_000853_Phone_services;
            this.PictureBox1.Location = new System.Drawing.Point(21, 34);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(260, 455);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 467;
            this.PictureBox1.TabStop = false;
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.ColumnCount = 1;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel1.Controls.Add(this.MaterialButton10, 0, 0);
            this.TableLayoutPanel1.Location = new System.Drawing.Point(5, 492);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 1;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(292, 32);
            this.TableLayoutPanel1.TabIndex = 0;
            // 
            // MaterialButton10
            // 
            this.MaterialButton10.Animated = true;
            this.MaterialButton10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.MaterialButton10.BorderRadius = 4;
            this.MaterialButton10.BorderThickness = 2;
            this.MaterialButton10.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.MaterialButton10.CheckedState.FillColor = System.Drawing.Color.LightGray;
            this.MaterialButton10.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.MaterialButton10.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.MaterialButton10.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.MaterialButton10.DisabledState.FillColor = System.Drawing.Color.Gainsboro;
            this.MaterialButton10.DisabledState.ForeColor = System.Drawing.Color.DimGray;
            this.MaterialButton10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.MaterialButton10.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaterialButton10.ForeColor = System.Drawing.Color.White;
            this.MaterialButton10.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.MaterialButton10.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.MaterialButton10.Image = global::Properties.Resources.tick;
            this.MaterialButton10.ImageSize = new System.Drawing.Size(23, 23);
            this.MaterialButton10.Location = new System.Drawing.Point(3, 3);
            this.MaterialButton10.Name = "MaterialButton10";
            this.MaterialButton10.PressedColor = System.Drawing.Color.Empty;
            this.MaterialButton10.Size = new System.Drawing.Size(286, 26);
            this.MaterialButton10.TabIndex = 438;
            this.MaterialButton10.Text = "OK";
            this.MaterialButton10.TextFormatNoPrefix = true;
            this.MaterialButton10.Click += new System.EventHandler(this.MaterialButton10_Click);
            // 
            // Guna2GroupBox1
            // 
            this.Guna2GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.Guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2GroupBox1.BorderRadius = 6;
            this.Guna2GroupBox1.BorderThickness = 2;
            this.Guna2GroupBox1.Controls.Add(this.PictureBox1);
            this.Guna2GroupBox1.Controls.Add(this.TableLayoutPanel1);
            this.Guna2GroupBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.Guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.Guna2GroupBox1.Location = new System.Drawing.Point(7, 5);
            this.Guna2GroupBox1.Name = "Guna2GroupBox1";
            this.Guna2GroupBox1.ShadowDecoration.BorderRadius = 9;
            this.Guna2GroupBox1.ShadowDecoration.Color = System.Drawing.Color.White;
            this.Guna2GroupBox1.ShadowDecoration.Depth = 15;
            this.Guna2GroupBox1.Size = new System.Drawing.Size(303, 530);
            this.Guna2GroupBox1.TabIndex = 6;
            this.Guna2GroupBox1.Text = "  Pleses Select WCDMA Only Then Enter OK";
            // 
            // Dialog2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(317, 541);
            this.ControlBox = false;
            this.Controls.Add(this.Guna2GroupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dialog2";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Dialog2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.TableLayoutPanel1.ResumeLayout(false);
            this.Guna2GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

	}

	private void OK_Button_Click(object sender, EventArgs e)
	{
	}

	private void Cancel_Button_Click(object sender, EventArgs e)
	{
		base.DialogResult = DialogResult.Cancel;
		Close();
	}

	private void MaterialButton10_Click(object sender, EventArgs e)
	{
		base.DialogResult = DialogResult.OK;
		Close();
	}



    private void Dialog2_Load(object sender, EventArgs e)
    {

    }
}
