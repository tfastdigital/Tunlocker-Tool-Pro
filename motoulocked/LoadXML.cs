using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic.CompilerServices;

namespace motoulocked;

[DesignerGenerated]
public class LoadXML : Form
{
	private IContainer components;

	[CompilerGenerated]
	[AccessedThroughProperty("ListView1")]
	private ListView _ListView1;

	[CompilerGenerated]
	[AccessedThroughProperty("CheckBox1")]
	private CheckBox _CheckBox1;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2Button11")]
	private Guna2Button _Guna2Button11;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2Button1")]
	private Guna2Button _Guna2Button1;

	public static string LoadFolder = "";
	/*
	internal  ListView ListView1
	{
		[CompilerGenerated]
		get
		{
			return _ListView1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ListView1_SelectedIndexChanged;
			ListView listView = _ListView1;
			if (listView != null)
			{
				listView.SelectedIndexChanged -= value2;
			}
			_ListView1 = value;
			listView = _ListView1;
			if (listView != null)
			{
				listView.SelectedIndexChanged += value2;
			}
		}
	}

	private  CheckBox CheckBox1
	{
		[CompilerGenerated]
		get
		{
			return _CheckBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = CheckBox1_CheckedChanged;
			CheckBox checkBox = _CheckBox1;
			if (checkBox != null)
			{
				checkBox.CheckedChanged -= value2;
			}
			_CheckBox1 = value;
			checkBox = _CheckBox1;
			if (checkBox != null)
			{
				checkBox.CheckedChanged += value2;
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

	[field: AccessedThroughProperty("Guna2GroupBox5")]
	internal  Guna2GroupBox Guna2GroupBox5
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
	*/
	internal ListView ListView1;

	internal Guna2Button Guna2Button11;

	internal Guna2Button Guna2Button1;

	internal Guna2GroupBox Guna2GroupBox5;

	internal Guna2GroupBox Guna2GroupBox1;


    private CheckBox CheckBox1;

    private ListViewItem Lvi { get; set; }

	public LoadXML()
	{
		base.Load += LoadXML_Load;
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
            this.ListView1 = new System.Windows.Forms.ListView();
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            this.Guna2Button11 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2GroupBox5 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.Guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.Guna2GroupBox5.SuspendLayout();
            this.Guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListView1
            // 
            this.ListView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ListView1.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListView1.ForeColor = System.Drawing.Color.White;
            this.ListView1.HideSelection = false;
            this.ListView1.Location = new System.Drawing.Point(3, 4);
            this.ListView1.Name = "ListView1";
            this.ListView1.Size = new System.Drawing.Size(424, 179);
            this.ListView1.TabIndex = 17;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            // 
            // CheckBox1
            // 
            this.CheckBox1.AutoSize = true;
            this.CheckBox1.BackColor = System.Drawing.Color.White;
            this.CheckBox1.Location = new System.Drawing.Point(10, 11);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(15, 14);
            this.CheckBox1.TabIndex = 20;
            this.CheckBox1.UseVisualStyleBackColor = false;
            // 
            // Guna2Button11
            // 
            this.Guna2Button11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.Guna2Button11.ImageSize = new System.Drawing.Size(25, 25);
            this.Guna2Button11.Location = new System.Drawing.Point(174, 8);
            this.Guna2Button11.Name = "Guna2Button11";
            this.Guna2Button11.PressedColor = System.Drawing.Color.Empty;
            this.Guna2Button11.Size = new System.Drawing.Size(247, 31);
            this.Guna2Button11.TabIndex = 498;
            this.Guna2Button11.Text = "Selected";
            this.Guna2Button11.TextFormatNoPrefix = true;
            this.Guna2Button11.Click += new System.EventHandler(this.Guna2Button11_Click);
            // 
            // Guna2Button1
            // 
            this.Guna2Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Guna2Button1.Animated = true;
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
            this.Guna2Button1.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Guna2Button1.ForeColor = System.Drawing.Color.White;
            this.Guna2Button1.HoverState.BorderColor = System.Drawing.Color.Red;
            this.Guna2Button1.HoverState.CustomBorderColor = System.Drawing.Color.Red;
            this.Guna2Button1.ImageSize = new System.Drawing.Size(25, 25);
            this.Guna2Button1.Location = new System.Drawing.Point(10, 8);
            this.Guna2Button1.Name = "Guna2Button1";
            this.Guna2Button1.PressedColor = System.Drawing.Color.Empty;
            this.Guna2Button1.Size = new System.Drawing.Size(158, 31);
            this.Guna2Button1.TabIndex = 499;
            this.Guna2Button1.Text = "Cancel";
            this.Guna2Button1.TextFormatNoPrefix = true;
            this.Guna2Button1.Click += new System.EventHandler(this.Guna2Button1_Click);
            // 
            // Guna2GroupBox5
            // 
            this.Guna2GroupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Guna2GroupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2GroupBox5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2GroupBox5.BorderRadius = 6;
            this.Guna2GroupBox5.Controls.Add(this.Guna2Button11);
            this.Guna2GroupBox5.Controls.Add(this.Guna2Button1);
            this.Guna2GroupBox5.Cursor = System.Windows.Forms.Cursors.Default;
            this.Guna2GroupBox5.CustomBorderColor = System.Drawing.Color.Empty;
            this.Guna2GroupBox5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2GroupBox5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Guna2GroupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Guna2GroupBox5.Location = new System.Drawing.Point(12, 205);
            this.Guna2GroupBox5.Name = "Guna2GroupBox5";
            this.Guna2GroupBox5.ShadowDecoration.BorderRadius = 9;
            this.Guna2GroupBox5.ShadowDecoration.Color = System.Drawing.Color.White;
            this.Guna2GroupBox5.ShadowDecoration.Depth = 15;
            this.Guna2GroupBox5.Size = new System.Drawing.Size(430, 48);
            this.Guna2GroupBox5.TabIndex = 534;
            // 
            // Guna2GroupBox1
            // 
            this.Guna2GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Guna2GroupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2GroupBox1.BorderRadius = 6;
            this.Guna2GroupBox1.Controls.Add(this.CheckBox1);
            this.Guna2GroupBox1.Controls.Add(this.ListView1);
            this.Guna2GroupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Empty;
            this.Guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Guna2GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.Guna2GroupBox1.Name = "Guna2GroupBox1";
            this.Guna2GroupBox1.ShadowDecoration.BorderRadius = 9;
            this.Guna2GroupBox1.ShadowDecoration.Color = System.Drawing.Color.White;
            this.Guna2GroupBox1.ShadowDecoration.Depth = 15;
            this.Guna2GroupBox1.Size = new System.Drawing.Size(430, 187);
            this.Guna2GroupBox1.TabIndex = 535;
            // 
            // LoadXML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(454, 265);
            this.ControlBox = false;
            this.Controls.Add(this.Guna2GroupBox1);
            this.Controls.Add(this.Guna2GroupBox5);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoadXML";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " ";
            this.Guna2GroupBox5.ResumeLayout(false);
            this.Guna2GroupBox1.ResumeLayout(false);
            this.Guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);

	}

	private void LoadXML_Load(object sender, EventArgs e)
	{
		LoadFolder = EDL.LoadFolderXml;
		DirectoryInfo directoryInfo = new DirectoryInfo(LoadFolder);
		ListView1.Columns.Clear();
		ListView1.Items.Clear();
		ListView1.Columns.Add("", 25);
		ListView1.Columns.Add("Files XML", 280, HorizontalAlignment.Left);
		ListView1.View = View.Details;
		ListView1.CheckBoxes = true;
		ListView1.FullRowSelect = true;
		FileInfo[] files = directoryInfo.GetFiles();
		foreach (FileInfo fileInfo in files)
		{
			if (fileInfo != null && (fileInfo.Name.ToLower().Contains("raw") || fileInfo.Name.ToLower().Contains("patch")) && Operators.CompareString(Path.GetExtension(fileInfo.ToString().ToLower()), ".xml", TextCompare: false) == 0)
			{
				Lvi = new ListViewItem();
				Lvi.SubItems.Add(fileInfo.ToString());
				ListView1.Items.Add(Lvi);
			}
		}
		CheckBox1.Checked = true;
	}

	private void Guna2Button11_Click(object sender, EventArgs e)
	{
		string text = "";
		foreach (ListViewItem checkedItem in ListView1.CheckedItems)
		{
			text = text + checkedItem.SubItems[1].Text + ",";
		}
		EDL.nameXML = text;
		Close();
	}

	private void Guna2Button1_Click(object sender, EventArgs e)
	{
		EDL.nameXML = "";
		Close();
	}

	private void CheckBox1_CheckedChanged(object sender, EventArgs e)
	{
		if (ListView1.Items.Count == 0)
		{
			return;
		}
		if (CheckBox1.Checked)
		{
			{
				foreach (ListViewItem item in ListView1.Items)
				{
					item.Checked = true;
				}
				return;
			}
		}
		foreach (ListViewItem item2 in ListView1.Items)
		{
			item2.Checked = false;
		}
	}

	private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
	{
	}


}
