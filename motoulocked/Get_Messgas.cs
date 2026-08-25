using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using FireSharp;
using FireSharp.Interfaces;
using FireSharp.Response;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using motoulocked.motoulocked;
using Properties;

namespace motoulocked;

[DesignerGenerated]
public class Get_Messgas : Form
{
	public class informationChecker
	{
		public string ID;

		public string UserName;

		public string NameAp;

		public string vrigonAp;

		public string Datee;

		public string timee;

		public string Cont_Messgas;

		public string Cont_Messgas2;

		public string Sabjct;

		public string Email;
	}

	private IContainer components;

	[CompilerGenerated]
	[AccessedThroughProperty("Timer1")]
	private System.Windows.Forms.Timer _Timer1;

	private string _curr;

	private int _con;

	public static string Cont_Messgas;

	private string Sabjct0;

	private string Email0;

	private string Sabjct;

	private string Email;

	private string Sabjct1;

	private string Email1;

	private string Sabjct2;

	private string Email2;

	private string Sabjct3;

	private string Email3;

	private string Sabjct4;

	private string Email4;

	private string Sabjct5;

	private string Email5;

	private string Sabjct6;

	private string Email6;

	private string Sabjct7;

	private string Email7;

	private string Sabjct8;

	private string Email8;

	private string Sabjct9;

	private string Email9;

	private string Sabjct10;

	private string Email10;

	private string ThisLocation;
    /*
	[field: AccessedThroughProperty("FlowLayoutPanel1")]
	internal  FlowLayoutPanel FlowLayoutPanel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("BackgroundWorker1")]
	public  BackgroundWorker BackgroundWorker1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Guna2DataGridView3")]
	internal  Guna2DataGridView Guna2DataGridView3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cost2")]
	internal  DataGridViewTextBoxColumn cost2
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

	[field: AccessedThroughProperty("PictureBox5")]
	internal  PictureBox PictureBox5
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

	[field: AccessedThroughProperty("Guna2GroupBox4")]
	internal  Guna2GroupBox Guna2GroupBox4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}
	*/
    internal FlowLayoutPanel FlowLayoutPanel1;
    internal Guna2DataGridView Guna2DataGridView3;
    internal DataGridViewTextBoxColumn cost2;
    internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
    internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn2;
    internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn3;
    internal System.Windows.Forms.Timer Timer1;
    internal PictureBox PictureBox5;
    internal PictureBox PictureBox1;
    internal Guna2GroupBox Guna2GroupBox4;
    public BackgroundWorker BackgroundWorker1;

    public Get_Messgas()
	{
		base.Load += Get_Messgas_Load;
		_curr = null;
		_con = 0;
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Get_Messgas));
            this.Guna2DataGridView3 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cost2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BackgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.Guna2GroupBox4 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.PictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2DataGridView3)).BeginInit();
            this.Guna2GroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // Guna2DataGridView3
            // 
            this.Guna2DataGridView3.AllowUserToAddRows = false;
            this.Guna2DataGridView3.AllowUserToDeleteRows = false;
            this.Guna2DataGridView3.AllowUserToResizeColumns = false;
            this.Guna2DataGridView3.AllowUserToResizeRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.Guna2DataGridView3.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.Guna2DataGridView3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Guna2DataGridView3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Guna2DataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.Guna2DataGridView3.ColumnHeadersHeight = 19;
            this.Guna2DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Guna2DataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cost2,
            this.DataGridViewTextBoxColumn1,
            this.DataGridViewTextBoxColumn2,
            this.DataGridViewTextBoxColumn3});
            this.Guna2DataGridView3.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Guna2DataGridView3.DefaultCellStyle = dataGridViewCellStyle18;
            this.Guna2DataGridView3.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Guna2DataGridView3.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Guna2DataGridView3.Location = new System.Drawing.Point(912, 313);
            this.Guna2DataGridView3.Name = "Guna2DataGridView3";
            this.Guna2DataGridView3.ReadOnly = true;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Guna2DataGridView3.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.Guna2DataGridView3.RowHeadersVisible = false;
            this.Guna2DataGridView3.RowHeadersWidth = 90;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2DataGridView3.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.Guna2DataGridView3.Size = new System.Drawing.Size(10, 10);
            this.Guna2DataGridView3.TabIndex = 396;
            this.Guna2DataGridView3.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.Guna2DataGridView3.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.Guna2DataGridView3.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.Guna2DataGridView3.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.Guna2DataGridView3.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.Guna2DataGridView3.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.Guna2DataGridView3.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.Guna2DataGridView3.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Guna2DataGridView3.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Guna2DataGridView3.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Guna2DataGridView3.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2DataGridView3.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.Guna2DataGridView3.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Guna2DataGridView3.ThemeStyle.HeaderStyle.Height = 19;
            this.Guna2DataGridView3.ThemeStyle.ReadOnly = true;
            this.Guna2DataGridView3.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.Guna2DataGridView3.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Guna2DataGridView3.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2DataGridView3.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Guna2DataGridView3.ThemeStyle.RowsStyle.Height = 22;
            this.Guna2DataGridView3.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.Guna2DataGridView3.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.Guna2DataGridView3.Visible = false;
            // 
            // cost2
            // 
            this.cost2.HeaderText = "cost2";
            this.cost2.Name = "cost2";
            this.cost2.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn1
            // 
            this.DataGridViewTextBoxColumn1.FillWeight = 100.2561F;
            this.DataGridViewTextBoxColumn1.HeaderText = "UserName";
            this.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
            this.DataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn2
            // 
            this.DataGridViewTextBoxColumn2.FillWeight = 101.4293F;
            this.DataGridViewTextBoxColumn2.HeaderText = "Subjct";
            this.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2";
            this.DataGridViewTextBoxColumn2.ReadOnly = true;
            this.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DataGridViewTextBoxColumn3
            // 
            this.DataGridViewTextBoxColumn3.FillWeight = 100.1667F;
            this.DataGridViewTextBoxColumn3.HeaderText = "Cont";
            this.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3";
            this.DataGridViewTextBoxColumn3.ReadOnly = true;
            this.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // FlowLayoutPanel1
            // 
            this.FlowLayoutPanel1.AutoScroll = true;
            this.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.FlowLayoutPanel1.Location = new System.Drawing.Point(2, 4);
            this.FlowLayoutPanel1.Name = "FlowLayoutPanel1";
            this.FlowLayoutPanel1.Size = new System.Drawing.Size(475, 518);
            this.FlowLayoutPanel1.TabIndex = 0;
            this.FlowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.FlowLayoutPanel1_Paint);
            // 
            // BackgroundWorker1
            // 
            this.BackgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Guna2GroupBox4
            // 
            this.Guna2GroupBox4.BackColor = System.Drawing.Color.Transparent;
            this.Guna2GroupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Guna2GroupBox4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2GroupBox4.BorderRadius = 6;
            this.Guna2GroupBox4.Controls.Add(this.PictureBox1);
            this.Guna2GroupBox4.Controls.Add(this.PictureBox5);
            this.Guna2GroupBox4.Controls.Add(this.FlowLayoutPanel1);
            this.Guna2GroupBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guna2GroupBox4.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2GroupBox4.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.Guna2GroupBox4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2GroupBox4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2GroupBox4.ForeColor = System.Drawing.Color.White;
            this.Guna2GroupBox4.Location = new System.Drawing.Point(10, 7);
            this.Guna2GroupBox4.Name = "Guna2GroupBox4";
            this.Guna2GroupBox4.ShadowDecoration.BorderRadius = 9;
            this.Guna2GroupBox4.ShadowDecoration.Color = System.Drawing.Color.White;
            this.Guna2GroupBox4.ShadowDecoration.Depth = 15;
            this.Guna2GroupBox4.Size = new System.Drawing.Size(479, 526);
            this.Guna2GroupBox4.TabIndex = 513;
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PictureBox1.Image = global::Properties.Resources.unnamed;
            this.PictureBox1.Location = new System.Drawing.Point(191, 210);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(101, 92);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 486;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.Visible = false;
            this.PictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // PictureBox5
            // 
            this.PictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PictureBox5.Image = global::Properties.Resources.chat;
            this.PictureBox5.Location = new System.Drawing.Point(191, 210);
            this.PictureBox5.Name = "PictureBox5";
            this.PictureBox5.Size = new System.Drawing.Size(101, 92);
            this.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox5.TabIndex = 485;
            this.PictureBox5.TabStop = false;
            this.PictureBox5.Visible = false;
            // 
            // Get_Messgas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(498, 540);
            this.Controls.Add(this.Guna2GroupBox4);
            this.Controls.Add(this.Guna2DataGridView3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Get_Messgas";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                                   Messages";
            ((System.ComponentModel.ISupportInitialize)(this.Guna2DataGridView3)).EndInit();
            this.Guna2GroupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox5)).EndInit();
            this.ResumeLayout(false);

	}

	public void create_new()
	{
		Panel panel = new Panel();
		panel.BackColor = Color.FromArgb(70, 70, 70);
		panel.Size = new Size(468, 90);
		checked
		{
			panel.Name = "Mess" + (_con + 1);
			//_ = null;
			FlowLayoutPanel1.Controls.Add(panel);
			_curr = panel.Name;
			_con++;
		}
	}

	public void createtxt_new(string Text_show, string panelname)
	{
		Label label = new Label();
		label.AutoSize = true;
		label.Location = new Point(65, 10);
		label.Name = "Sabjct" + checked(_con + 1);
		label.BackColor = Color.FromArgb(70, 70, 70);
		label.ForeColor = Color.White;
		label.Font = new Font("Yu Gothic UI", 11.25f, FontStyle.Bold);
		label.Text = Text_show;
		//_ = null;
		foreach (Control control in FlowLayoutPanel1.Controls)
		{
			if (Operators.CompareString(control.Name, panelname, TextCompare: false) == 0)
			{
				control.Controls.Add(label);
			}
		}
	}

	public void createimg_new(string panelname)
	{
		PictureBox pictureBox = new PictureBox();
		pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
		pictureBox.Size = new Size(45, 45);
		pictureBox.Location = new Point(10, 20);
		pictureBox.Name = "img" + checked(_con + 1);
		pictureBox.Image = Resources.Messages1;
		//_ = null;
		foreach (Control control in FlowLayoutPanel1.Controls)
		{
			if (Operators.CompareString(control.Name, panelname, TextCompare: false) == 0)
			{
				control.Controls.Add(pictureBox);
			}
		}
		createimg_newexit(_curr);
	}

	public void createimg_newexit(string panelname)
	{
		PictureBox pictureBox = new PictureBox();
		pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
		pictureBox.Size = new Size(25, 25);
		pictureBox.Location = new Point(425, 30);
		pictureBox.Name = "imgexit" + checked(_con + 1);
		pictureBox.Image = Resources.close__1_;
		//_ = null;
		foreach (Control control in FlowLayoutPanel1.Controls)
		{
			if (Operators.CompareString(control.Name, panelname, TextCompare: false) == 0)
			{
				control.Controls.Add(pictureBox);
			}
		}
		pictureBox.Click += DynamicButton_Click;
	}

	public void createmail_new(string Text_show, string panelname)
	{
		Label label = new Label();
		label.AutoSize = true;
		label.Location = new Point(66, 30);
		label.Name = "Mail" + checked(_con + 1);
		label.BackColor = Color.FromArgb(70, 70, 70);
		label.ForeColor = Color.Silver;
		label.Font = new Font("Yu Gothic UI", 9.57f, FontStyle.Bold);
		label.Text = Text_show;
		//_ = null;
		foreach (Control control in FlowLayoutPanel1.Controls)
		{
			if (Operators.CompareString(control.Name, panelname, TextCompare: false) == 0)
			{
				control.Controls.Add(label);
			}
		}
	}

	public void DynamicButton_Click(object sender, EventArgs e)
	{
		string right = null;
		foreach (Control control4 in FlowLayoutPanel1.Controls)
		{
			foreach (Control control5 in control4.Controls)
			{
				if (Operators.ConditionalCompareObjectEqual(control5.Name, NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null), TextCompare: false))
				{
					control5.Click -= DynamicButton_Click;
					right = control5.Parent.Name;
				}
			}
		}
		foreach (Control control6 in FlowLayoutPanel1.Controls)
		{
			if (Operators.CompareString(control6.Name, right, TextCompare: false) == 0)
			{
				FlowLayoutPanel1.Controls.Remove(control6);
				control6.Dispose();
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

	public void start()
	{
		PictureBox1.Visible = true;
	}

	public void finsh()
	{
		PictureBox1.Visible = false;
	}

	private void Get_Messgas_Load(object sender, EventArgs e)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		FlowLayoutPanel1.Controls.Clear();
		Form1.String_105 = (IFirebaseClient)new FirebaseClient((IFirebaseConfig)(object)Form1.String_106);
		start();
		new Thread(Check).Start();
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

	public void CHECKMESSG()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		Guna2DataGridView3.Rows.Clear();
		Cont_Messgas = "0";
		SevaClass.Cont_Messgas2 = "0";
		Form1.String_105 = (IFirebaseClient)new FirebaseClient((IFirebaseConfig)(object)Form1.String_106);
		try
		{
			Dictionary<string, informationChecker> dictionary = Form1.String_105.Get(ClassDevronix.MFU + SevaClass.Userr).ResultAs<Dictionary<string, informationChecker>>();
			foreach (KeyValuePair<string, informationChecker> item in dictionary)
			{
				Guna2DataGridView3.Rows.Add(item.Value.Cont_Messgas);
			}
			double num = 0.0;
			foreach (DataGridViewRow item2 in (IEnumerable)Guna2DataGridView3.Rows)
			{
				if (Operators.ConditionalCompareObjectGreater(item2.Cells[0].Value, num, TextCompare: false))
				{
					Cont_Messgas = Conversions.ToString(item2.Cells[0].Value);
					SevaClass.Cont_Messgas2 = Cont_Messgas;
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void Check()
	{
		if (!chacknet())
		{
			Cont_Messgas = "0";
			Email0 = "";
			SerialCOM.MSL = "Set";
			finsh();
			return;
		}
		informationChecker informationChecker = new informationChecker();
		try
		{
			informationChecker = Form1.String_105.Get(ClassDevronix.MFA).ResultAs<informationChecker>();
			Sabjct0 = "Hello " + SevaClass.Userr;
			Email0 = informationChecker.Email;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Email0 = "";
			ProjectData.ClearProjectError();
		}
		CHECKMESSG();
		if (Operators.CompareString(informationChecker.Email, "", TextCompare: false) != 0)
		{
			SevaClass.Cont_Messgas2 = Conversions.ToString(Conversions.ToDouble(SevaClass.Cont_Messgas2) + 1.0);
		}
		if (Operators.CompareString(Cont_Messgas, "1", TextCompare: false) == 0)
		{
			informationChecker = Form1.String_105.Get(ClassDevronix.MFU + SevaClass.Userr + "/Messga1").ResultAs<informationChecker>();
			Sabjct = informationChecker.Sabjct;
			Email = informationChecker.Email;
		}
		if (Operators.CompareString(Cont_Messgas, "2", TextCompare: false) == 0)
		{
			informationChecker = Form1.String_105.Get(ClassDevronix.MFU + SevaClass.Userr + "/Messga1").ResultAs<informationChecker>();
			Sabjct = informationChecker.Sabjct;
			Email = informationChecker.Email;
			FirebaseResponse obj = Form1.String_105.Get(ClassDevronix.MFU + SevaClass.Userr + "/Messga2");
			informationChecker = new informationChecker();
			informationChecker = obj.ResultAs<informationChecker>();
			Sabjct1 = informationChecker.Sabjct;
			Email1 = informationChecker.Email;
		}
		if (Operators.CompareString(Cont_Messgas, "3", TextCompare: false) == 0)
		{
			informationChecker = Form1.String_105.Get(ClassDevronix.MFU + SevaClass.Userr + "/Messga1").ResultAs<informationChecker>();
			Sabjct = informationChecker.Sabjct;
			Email = informationChecker.Email;
			FirebaseResponse obj2 = Form1.String_105.Get(ClassDevronix.MFU + SevaClass.Userr + "/Messga2");
			informationChecker = new informationChecker();
			informationChecker = obj2.ResultAs<informationChecker>();
			Sabjct1 = informationChecker.Sabjct;
			Email1 = informationChecker.Email;
			FirebaseResponse obj3 = Form1.String_105.Get(ClassDevronix.MFU + SevaClass.Userr + "/Messga2");
			informationChecker = new informationChecker();
			informationChecker = obj3.ResultAs<informationChecker>();
			Sabjct2 = informationChecker.Sabjct;
			Email2 = informationChecker.Email;
		}
		if (Operators.CompareString(Cont_Messgas, "4", TextCompare: false) == 0)
		{
			informationChecker = Form1.String_105.Get(ClassDevronix.MFU + SevaClass.Userr + "/Messga1").ResultAs<informationChecker>();
			Sabjct = informationChecker.Sabjct;
			Email = informationChecker.Email;
			FirebaseResponse obj4 = Form1.String_105.Get(ClassDevronix.MFU + SevaClass.Userr + "/Messga2");
			informationChecker = new informationChecker();
			informationChecker = obj4.ResultAs<informationChecker>();
			Sabjct1 = informationChecker.Sabjct;
			Email1 = informationChecker.Email;
			FirebaseResponse obj5 = Form1.String_105.Get(ClassDevronix.MFU + SevaClass.Userr + "/Messga3");
			informationChecker = new informationChecker();
			informationChecker = obj5.ResultAs<informationChecker>();
			Sabjct2 = informationChecker.Sabjct;
			Email2 = informationChecker.Email;
			FirebaseResponse obj6 = Form1.String_105.Get(ClassDevronix.MFU + SevaClass.Userr + "/Messga4");
			informationChecker = new informationChecker();
			informationChecker = obj6.ResultAs<informationChecker>();
			Sabjct3 = informationChecker.Sabjct;
			Email3 = informationChecker.Email;
		}
		if (Operators.CompareString(Cont_Messgas, "5", TextCompare: false) == 0)
		{
			informationChecker = Form1.String_105.Get(ClassDevronix.MFU + SevaClass.Userr + "/Messga1").ResultAs<informationChecker>();
			Sabjct = informationChecker.Sabjct;
			Email = informationChecker.Email;
			FirebaseResponse obj7 = Form1.String_105.Get(ClassDevronix.MFU + SevaClass.Userr + "/Messga2");
			informationChecker = new informationChecker();
			informationChecker = obj7.ResultAs<informationChecker>();
			Sabjct1 = informationChecker.Sabjct;
			Email1 = informationChecker.Email;
			FirebaseResponse obj8 = Form1.String_105.Get(ClassDevronix.MFU + SevaClass.Userr + "/Messga3");
			informationChecker = new informationChecker();
			informationChecker = obj8.ResultAs<informationChecker>();
			Sabjct2 = informationChecker.Sabjct;
			Email2 = informationChecker.Email;
			FirebaseResponse obj9 = Form1.String_105.Get(ClassDevronix.MFU + SevaClass.Userr + "/Messga4");
			informationChecker = new informationChecker();
			informationChecker = obj9.ResultAs<informationChecker>();
			Sabjct3 = informationChecker.Sabjct;
			Email3 = informationChecker.Email;
			FirebaseResponse obj10 = Form1.String_105.Get(ClassDevronix.MFU + SevaClass.Userr + "/Messga5");
			informationChecker = new informationChecker();
			informationChecker = obj10.ResultAs<informationChecker>();
			Sabjct4 = informationChecker.Sabjct;
			Email4 = informationChecker.Email;
		}
		if (Operators.CompareString(Cont_Messgas, "6", TextCompare: false) == 0)
		{
			informationChecker = Form1.String_105.Get(ClassDevronix.MFU + SevaClass.Userr + "/Messga1").ResultAs<informationChecker>();
			Sabjct = informationChecker.Sabjct;
			Email = informationChecker.Email;
			FirebaseResponse obj11 = Form1.String_105.Get(ClassDevronix.MFU + SevaClass.Userr + "/Messga2");
			informationChecker = new informationChecker();
			informationChecker = obj11.ResultAs<informationChecker>();
			Sabjct1 = informationChecker.Sabjct;
			Email1 = informationChecker.Email;
			FirebaseResponse obj12 = Form1.String_105.Get(ClassDevronix.MFU + SevaClass.Userr + "/Messga3");
			informationChecker = new informationChecker();
			informationChecker = obj12.ResultAs<informationChecker>();
			Sabjct2 = informationChecker.Sabjct;
			Email2 = informationChecker.Email;
			FirebaseResponse obj13 = Form1.String_105.Get(ClassDevronix.MFU + SevaClass.Userr + "/Messga4");
			informationChecker = new informationChecker();
			informationChecker = obj13.ResultAs<informationChecker>();
			Sabjct3 = informationChecker.Sabjct;
			Email3 = informationChecker.Email;
			FirebaseResponse obj14 = Form1.String_105.Get(ClassDevronix.MFU + SevaClass.Userr + "/Messga5");
			informationChecker = new informationChecker();
			informationChecker = obj14.ResultAs<informationChecker>();
			Sabjct4 = informationChecker.Sabjct;
			Email4 = informationChecker.Email;
			FirebaseResponse obj15 = Form1.String_105.Get(ClassDevronix.MFU + SevaClass.Userr + "/Messga6");
			informationChecker = new informationChecker();
			informationChecker = obj15.ResultAs<informationChecker>();
			Sabjct5 = informationChecker.Sabjct;
			Email5 = informationChecker.Email;
		}
		if (Operators.CompareString(Cont_Messgas, "7", TextCompare: false) == 0)
		{
			informationChecker = Form1.String_105.Get(ClassDevronix.MFU + SevaClass.Userr + "/Messga1").ResultAs<informationChecker>();
			Sabjct = informationChecker.Sabjct;
			Email = informationChecker.Email;
			FirebaseResponse obj16 = Form1.String_105.Get(ClassDevronix.MFU + SevaClass.Userr + "/Messga2");
			informationChecker = new informationChecker();
			informationChecker = obj16.ResultAs<informationChecker>();
			Sabjct1 = informationChecker.Sabjct;
			Email1 = informationChecker.Email;
			FirebaseResponse obj17 = Form1.String_105.Get(ClassDevronix.MFU + SevaClass.Userr + "/Messga3");
			informationChecker = new informationChecker();
			informationChecker = obj17.ResultAs<informationChecker>();
			Sabjct2 = informationChecker.Sabjct;
			Email2 = informationChecker.Email;
			FirebaseResponse obj18 = Form1.String_105.Get(ClassDevronix.MFU + SevaClass.Userr + "/Messga4");
			informationChecker = new informationChecker();
			informationChecker = obj18.ResultAs<informationChecker>();
			Sabjct3 = informationChecker.Sabjct;
			Email3 = informationChecker.Email;
			FirebaseResponse obj19 = Form1.String_105.Get(ClassDevronix.MFU + SevaClass.Userr + "/Messga5");
			informationChecker = new informationChecker();
			informationChecker = obj19.ResultAs<informationChecker>();
			Sabjct4 = informationChecker.Sabjct;
			Email4 = informationChecker.Email;
			FirebaseResponse obj20 = Form1.String_105.Get(ClassDevronix.MFU + SevaClass.Userr + "/Messga6");
			informationChecker = new informationChecker();
			informationChecker = obj20.ResultAs<informationChecker>();
			Sabjct5 = informationChecker.Sabjct;
			Email5 = informationChecker.Email;
			FirebaseResponse obj21 = Form1.String_105.Get(ClassDevronix.MFU + SevaClass.Userr + "/Messga7");
			informationChecker = new informationChecker();
			informationChecker = obj21.ResultAs<informationChecker>();
			Sabjct6 = informationChecker.Sabjct;
			Email6 = informationChecker.Email;
		}
		if (Operators.CompareString(Cont_Messgas, "8", TextCompare: false) == 0)
		{
			informationChecker = Form1.String_105.Get(ClassDevronix.MFU + SevaClass.Userr + "/Messga1").ResultAs<informationChecker>();
			Sabjct = informationChecker.Sabjct;
			Email = informationChecker.Email;
			FirebaseResponse obj22 = Form1.String_105.Get(ClassDevronix.MFU + SevaClass.Userr + "/Messga2");
			informationChecker = new informationChecker();
			informationChecker = obj22.ResultAs<informationChecker>();
			Sabjct1 = informationChecker.Sabjct;
			Email1 = informationChecker.Email;
			FirebaseResponse obj23 = Form1.String_105.Get(ClassDevronix.MFU + SevaClass.Userr + "/Messga3");
			informationChecker = new informationChecker();
			informationChecker = obj23.ResultAs<informationChecker>();
			Sabjct2 = informationChecker.Sabjct;
			Email2 = informationChecker.Email;
			FirebaseResponse obj24 = Form1.String_105.Get(ClassDevronix.MFU + SevaClass.Userr + "/Messga4");
			informationChecker = new informationChecker();
			informationChecker = obj24.ResultAs<informationChecker>();
			Sabjct3 = informationChecker.Sabjct;
			Email3 = informationChecker.Email;
			FirebaseResponse obj25 = Form1.String_105.Get(ClassDevronix.MFU + SevaClass.Userr + "/Messga5");
			informationChecker = new informationChecker();
			informationChecker = obj25.ResultAs<informationChecker>();
			Sabjct4 = informationChecker.Sabjct;
			Email4 = informationChecker.Email;
			FirebaseResponse obj26 = Form1.String_105.Get(ClassDevronix.MFU + SevaClass.Userr + "/Messga6");
			informationChecker = new informationChecker();
			informationChecker = obj26.ResultAs<informationChecker>();
			Sabjct5 = informationChecker.Sabjct;
			Email5 = informationChecker.Email;
			FirebaseResponse obj27 = Form1.String_105.Get(ClassDevronix.MFU + SevaClass.Userr + "/Messga7");
			informationChecker = new informationChecker();
			informationChecker = obj27.ResultAs<informationChecker>();
			Sabjct6 = informationChecker.Sabjct;
			Email6 = informationChecker.Email;
			FirebaseResponse obj28 = Form1.String_105.Get(ClassDevronix.MFU + SevaClass.Userr + "/Messga8");
			informationChecker = new informationChecker();
			informationChecker = obj28.ResultAs<informationChecker>();
			Sabjct7 = informationChecker.Sabjct;
			Email7 = informationChecker.Email;
		}
		if (Operators.CompareString(Cont_Messgas, "9", TextCompare: false) == 0)
		{
			informationChecker = Form1.String_105.Get(ClassDevronix.MFU + SevaClass.Userr + "/Messga1").ResultAs<informationChecker>();
			Sabjct = informationChecker.Sabjct;
			Email = informationChecker.Email;
			FirebaseResponse obj29 = Form1.String_105.Get(ClassDevronix.MFU + SevaClass.Userr + "/Messga2");
			informationChecker = new informationChecker();
			informationChecker = obj29.ResultAs<informationChecker>();
			Sabjct1 = informationChecker.Sabjct;
			Email1 = informationChecker.Email;
			FirebaseResponse obj30 = Form1.String_105.Get(ClassDevronix.MFU + SevaClass.Userr + "/Messga3");
			informationChecker = new informationChecker();
			informationChecker = obj30.ResultAs<informationChecker>();
			Sabjct2 = informationChecker.Sabjct;
			Email2 = informationChecker.Email;
			FirebaseResponse obj31 = Form1.String_105.Get(ClassDevronix.MFU + SevaClass.Userr + "/Messga4");
			informationChecker = new informationChecker();
			informationChecker = obj31.ResultAs<informationChecker>();
			Sabjct3 = informationChecker.Sabjct;
			Email3 = informationChecker.Email;
			FirebaseResponse obj32 = Form1.String_105.Get(ClassDevronix.MFU + SevaClass.Userr + "/Messga5");
			informationChecker = new informationChecker();
			informationChecker = obj32.ResultAs<informationChecker>();
			Sabjct4 = informationChecker.Sabjct;
			Email4 = informationChecker.Email;
			FirebaseResponse obj33 = Form1.String_105.Get(ClassDevronix.MFU + SevaClass.Userr + "/Messga6");
			informationChecker = new informationChecker();
			informationChecker = obj33.ResultAs<informationChecker>();
			Sabjct5 = informationChecker.Sabjct;
			Email5 = informationChecker.Email;
			FirebaseResponse obj34 = Form1.String_105.Get(ClassDevronix.MFU + SevaClass.Userr + "/Messga7");
			informationChecker = new informationChecker();
			informationChecker = obj34.ResultAs<informationChecker>();
			Sabjct6 = informationChecker.Sabjct;
			Email6 = informationChecker.Email;
			FirebaseResponse obj35 = Form1.String_105.Get(ClassDevronix.MFU + SevaClass.Userr + "/Messga8");
			informationChecker = new informationChecker();
			informationChecker = obj35.ResultAs<informationChecker>();
			Sabjct7 = informationChecker.Sabjct;
			Email7 = informationChecker.Email;
			FirebaseResponse obj36 = Form1.String_105.Get(ClassDevronix.MFU + SevaClass.Userr + "/Messga9");
			informationChecker = new informationChecker();
			informationChecker = obj36.ResultAs<informationChecker>();
			Sabjct8 = informationChecker.Sabjct;
			Email8 = informationChecker.Email;
		}
		if (Operators.CompareString(Cont_Messgas, "10", TextCompare: false) == 0)
		{
			informationChecker = Form1.String_105.Get(ClassDevronix.MFU + SevaClass.Userr + "/Messga1").ResultAs<informationChecker>();
			Sabjct = informationChecker.Sabjct;
			Email = informationChecker.Email;
			FirebaseResponse obj37 = Form1.String_105.Get(ClassDevronix.MFU + SevaClass.Userr + "/Messga2");
			informationChecker = new informationChecker();
			informationChecker = obj37.ResultAs<informationChecker>();
			Sabjct1 = informationChecker.Sabjct;
			Email1 = informationChecker.Email;
			FirebaseResponse obj38 = Form1.String_105.Get(ClassDevronix.MFU + SevaClass.Userr + "/Messga3");
			informationChecker = new informationChecker();
			informationChecker = obj38.ResultAs<informationChecker>();
			Sabjct2 = informationChecker.Sabjct;
			Email2 = informationChecker.Email;
			FirebaseResponse obj39 = Form1.String_105.Get(ClassDevronix.MFU + SevaClass.Userr + "/Messga4");
			informationChecker = new informationChecker();
			informationChecker = obj39.ResultAs<informationChecker>();
			Sabjct3 = informationChecker.Sabjct;
			Email3 = informationChecker.Email;
			FirebaseResponse obj40 = Form1.String_105.Get(ClassDevronix.MFU + SevaClass.Userr + "/Messga5");
			informationChecker = new informationChecker();
			informationChecker = obj40.ResultAs<informationChecker>();
			Sabjct4 = informationChecker.Sabjct;
			Email4 = informationChecker.Email;
			FirebaseResponse obj41 = Form1.String_105.Get(ClassDevronix.MFU + SevaClass.Userr + "/Messga6");
			informationChecker = new informationChecker();
			informationChecker = obj41.ResultAs<informationChecker>();
			Sabjct5 = informationChecker.Sabjct;
			Email5 = informationChecker.Email;
			FirebaseResponse obj42 = Form1.String_105.Get(ClassDevronix.MFU + SevaClass.Userr + "/Messga7");
			informationChecker = new informationChecker();
			informationChecker = obj42.ResultAs<informationChecker>();
			Sabjct6 = informationChecker.Sabjct;
			Email6 = informationChecker.Email;
			FirebaseResponse obj43 = Form1.String_105.Get(ClassDevronix.MFU + SevaClass.Userr + "/Messga8");
			informationChecker = new informationChecker();
			informationChecker = obj43.ResultAs<informationChecker>();
			Sabjct7 = informationChecker.Sabjct;
			Email7 = informationChecker.Email;
			FirebaseResponse obj44 = Form1.String_105.Get(ClassDevronix.MFU + SevaClass.Userr + "/Messga9");
			informationChecker = new informationChecker();
			informationChecker = obj44.ResultAs<informationChecker>();
			Sabjct8 = informationChecker.Sabjct;
			Email8 = informationChecker.Email;
			FirebaseResponse obj45 = Form1.String_105.Get(ClassDevronix.MFU + SevaClass.Userr + "/Messga10");
			informationChecker = new informationChecker();
			informationChecker = obj45.ResultAs<informationChecker>();
			Sabjct9 = informationChecker.Sabjct;
			Email9 = informationChecker.Email;
		}
		SerialCOM.MSL = "Set";
		finsh();
	}

	private void BackgroundWorke()
	{
		if (Operators.CompareString(Email0, "", TextCompare: false) != 0)
		{
			create_new();
			createtxt_new(Sabjct0, _curr);
			createmail_new(Email0, _curr);
			createimg_new(_curr);
		}
		if (Operators.CompareString(Cont_Messgas, "1", TextCompare: false) == 0)
		{
			create_new();
			createtxt_new(Sabjct, _curr);
			createmail_new(Email, _curr);
			createimg_new(_curr);
		}
		if (Operators.CompareString(Cont_Messgas, "2", TextCompare: false) == 0)
		{
			create_new();
			createtxt_new(Sabjct, _curr);
			createmail_new(Email, _curr);
			createimg_new(_curr);
			create_new();
			createtxt_new(Sabjct1, _curr);
			createmail_new(Email1, _curr);
			createimg_new(_curr);
		}
		if (Operators.CompareString(Cont_Messgas, "3", TextCompare: false) == 0)
		{
			create_new();
			createtxt_new(Sabjct, _curr);
			createmail_new(Email, _curr);
			createimg_new(_curr);
			create_new();
			createimg_newexit(_curr);
			createtxt_new(Sabjct1, _curr);
			createmail_new(Email1, _curr);
			createimg_new(_curr);
			create_new();
			createimg_newexit(_curr);
			createtxt_new(Sabjct2, _curr);
			createmail_new(Email2, _curr);
			createimg_new(_curr);
		}
		if (Operators.CompareString(Cont_Messgas, "4", TextCompare: false) == 0)
		{
			create_new();
			createtxt_new(Sabjct, _curr);
			createmail_new(Email, _curr);
			createimg_new(_curr);
			create_new();
			createtxt_new(Sabjct1, _curr);
			createmail_new(Email1, _curr);
			createimg_new(_curr);
			create_new();
			createtxt_new(Sabjct2, _curr);
			createmail_new(Email2, _curr);
			createimg_new(_curr);
			create_new();
			createtxt_new(Sabjct3, _curr);
			createmail_new(Email3, _curr);
			createimg_new(_curr);
		}
		if (Operators.CompareString(Cont_Messgas, "5", TextCompare: false) == 0)
		{
			create_new();
			createtxt_new(Sabjct, _curr);
			createmail_new(Email, _curr);
			createimg_new(_curr);
			create_new();
			createtxt_new(Sabjct1, _curr);
			createmail_new(Email1, _curr);
			createimg_new(_curr);
			create_new();
			createtxt_new(Sabjct2, _curr);
			createmail_new(Email2, _curr);
			createimg_new(_curr);
			create_new();
			createtxt_new(Sabjct3, _curr);
			createmail_new(Email3, _curr);
			createimg_new(_curr);
			create_new();
			createtxt_new(Sabjct4, _curr);
			createmail_new(Email4, _curr);
			createimg_new(_curr);
		}
		if (Operators.CompareString(Cont_Messgas, "6", TextCompare: false) == 0)
		{
			create_new();
			createtxt_new(Sabjct, _curr);
			createmail_new(Email, _curr);
			createimg_new(_curr);
			create_new();
			createtxt_new(Sabjct1, _curr);
			createmail_new(Email1, _curr);
			createimg_new(_curr);
			create_new();
			createtxt_new(Sabjct2, _curr);
			createmail_new(Email2, _curr);
			createimg_new(_curr);
			create_new();
			createtxt_new(Sabjct3, _curr);
			createmail_new(Email3, _curr);
			createimg_new(_curr);
			create_new();
			createtxt_new(Sabjct4, _curr);
			createmail_new(Email4, _curr);
			createimg_new(_curr);
			create_new();
			createtxt_new(Sabjct5, _curr);
			createmail_new(Email5, _curr);
			createimg_new(_curr);
		}
		if (Operators.CompareString(Cont_Messgas, "7", TextCompare: false) == 0)
		{
			create_new();
			createtxt_new(Sabjct, _curr);
			createmail_new(Email, _curr);
			createimg_new(_curr);
			create_new();
			createtxt_new(Sabjct1, _curr);
			createmail_new(Email1, _curr);
			createimg_new(_curr);
			create_new();
			createtxt_new(Sabjct2, _curr);
			createmail_new(Email2, _curr);
			createimg_new(_curr);
			create_new();
			createtxt_new(Sabjct3, _curr);
			createmail_new(Email3, _curr);
			createimg_new(_curr);
			create_new();
			createtxt_new(Sabjct4, _curr);
			createmail_new(Email4, _curr);
			createimg_new(_curr);
			create_new();
			createtxt_new(Sabjct5, _curr);
			createmail_new(Email5, _curr);
			createimg_new(_curr);
			create_new();
			createtxt_new(Sabjct6, _curr);
			createmail_new(Email6, _curr);
			createimg_new(_curr);
		}
		if (Operators.CompareString(Cont_Messgas, "8", TextCompare: false) == 0)
		{
			create_new();
			createtxt_new(Sabjct, _curr);
			createmail_new(Email, _curr);
			createimg_new(_curr);
			create_new();
			createtxt_new(Sabjct1, _curr);
			createmail_new(Email1, _curr);
			createimg_new(_curr);
			create_new();
			createtxt_new(Sabjct2, _curr);
			createmail_new(Email2, _curr);
			createimg_new(_curr);
			create_new();
			createtxt_new(Sabjct3, _curr);
			createmail_new(Email3, _curr);
			createimg_new(_curr);
			create_new();
			createtxt_new(Sabjct4, _curr);
			createmail_new(Email4, _curr);
			createimg_new(_curr);
			create_new();
			createtxt_new(Sabjct5, _curr);
			createmail_new(Email5, _curr);
			createimg_new(_curr);
			create_new();
			createtxt_new(Sabjct6, _curr);
			createmail_new(Email6, _curr);
			createimg_new(_curr);
			create_new();
			createtxt_new(Sabjct7, _curr);
			createmail_new(Email7, _curr);
			createimg_new(_curr);
		}
		if (Operators.CompareString(Cont_Messgas, "9", TextCompare: false) == 0)
		{
			create_new();
			createtxt_new(Sabjct, _curr);
			createmail_new(Email, _curr);
			createimg_new(_curr);
			create_new();
			createtxt_new(Sabjct1, _curr);
			createmail_new(Email1, _curr);
			createimg_new(_curr);
			create_new();
			createtxt_new(Sabjct2, _curr);
			createmail_new(Email2, _curr);
			createimg_new(_curr);
			create_new();
			createtxt_new(Sabjct3, _curr);
			createmail_new(Email3, _curr);
			createimg_new(_curr);
			create_new();
			createtxt_new(Sabjct4, _curr);
			createmail_new(Email4, _curr);
			createimg_new(_curr);
			create_new();
			createtxt_new(Sabjct5, _curr);
			createmail_new(Email5, _curr);
			createimg_new(_curr);
			create_new();
			createtxt_new(Sabjct6, _curr);
			createmail_new(Email6, _curr);
			createimg_new(_curr);
			create_new();
			createtxt_new(Sabjct7, _curr);
			createmail_new(Email7, _curr);
			createimg_new(_curr);
			create_new();
			createtxt_new(Sabjct8, _curr);
			createmail_new(Email8, _curr);
			createimg_new(_curr);
		}
		if (Operators.CompareString(Cont_Messgas, "10", TextCompare: false) == 0)
		{
			create_new();
			createtxt_new(Sabjct, _curr);
			createmail_new(Email, _curr);
			createimg_new(_curr);
			create_new();
			createtxt_new(Sabjct1, _curr);
			createmail_new(Email1, _curr);
			createimg_new(_curr);
			create_new();
			createtxt_new(Sabjct2, _curr);
			createmail_new(Email2, _curr);
			createimg_new(_curr);
			create_new();
			createtxt_new(Sabjct3, _curr);
			createmail_new(Email3, _curr);
			createimg_new(_curr);
			create_new();
			createtxt_new(Sabjct4, _curr);
			createmail_new(Email4, _curr);
			createimg_new(_curr);
			create_new();
			createtxt_new(Sabjct5, _curr);
			createmail_new(Email5, _curr);
			createimg_new(_curr);
			create_new();
			createtxt_new(Sabjct6, _curr);
			createmail_new(Email6, _curr);
			createimg_new(_curr);
			create_new();
			createtxt_new(Sabjct7, _curr);
			createmail_new(Email7, _curr);
			createimg_new(_curr);
			create_new();
			createtxt_new(Sabjct8, _curr);
			createmail_new(Email8, _curr);
			createimg_new(_curr);
			create_new();
			createtxt_new(Sabjct9, _curr);
			createmail_new(Email9, _curr);
			createimg_new(_curr);
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		if (Operators.CompareString(SerialCOM.MSL, "Set", TextCompare: false) == 0)
		{
			if ((Operators.CompareString(Cont_Messgas, "0", TextCompare: false) == 0) & (Operators.CompareString(Email0, "", TextCompare: false) == 0))
			{
				SevaClass.Cont_Messgas2 = Cont_Messgas;
				PictureBox5.Visible = true;
			}
			else
			{
				PictureBox5.Visible = false;
			}
			SerialCOM.MSL = "";
			BackgroundWorke();
		}
	}

    private void FlowLayoutPanel1_Paint(object sender, PaintEventArgs e)
    {

    }

    private void PictureBox1_Click(object sender, EventArgs e)
    {

    }

    private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
    {

    }
}
