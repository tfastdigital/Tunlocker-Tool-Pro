using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic.CompilerServices;
using Properties;

namespace motoulocked;

[DesignerGenerated]
public class Select_Prtitoin : Form
{
	private IContainer components;

	[CompilerGenerated]
	[AccessedThroughProperty("OK_Button")]
	private Guna2Button _OK_Button;

	[CompilerGenerated]
	[AccessedThroughProperty("Cancel_Button")]
	private Guna2Button _Cancel_Button;

	[CompilerGenerated]
	[AccessedThroughProperty("cblistdataview")]
	private CheckBox _cblistdataview;

	public static string FileName;

	public static string Fileto;

	public static string DialogResultt;
    /*
	[field: AccessedThroughProperty("TableLayoutPanel1")]
	internal  TableLayoutPanel TableLayoutPanel1
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

	internal  Guna2Button OK_Button
	{
		[CompilerGenerated]
		get
		{
			return _OK_Button;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = OK_Button_Click_1;
			Guna2Button oK_Button = _OK_Button;
			if (oK_Button != null)
			{
				oK_Button.Click -= value2;
			}
			_OK_Button = value;
			oK_Button = _OK_Button;
			if (oK_Button != null)
			{
				oK_Button.Click += value2;
			}
		}
	}

	internal  Guna2Button Cancel_Button
	{
		[CompilerGenerated]
		get
		{
			return _Cancel_Button;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Cancel_Button_Click_1;
			Guna2Button cancel_Button = _Cancel_Button;
			if (cancel_Button != null)
			{
				cancel_Button.Click -= value2;
			}
			_Cancel_Button = value;
			cancel_Button = _Cancel_Button;
			if (cancel_Button != null)
			{
				cancel_Button.Click += value2;
			}
		}
	}

	internal  CheckBox cblistdataview
	{
		[CompilerGenerated]
		get
		{
			return _cblistdataview;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = cblistdataview_CheckedChanged;
			CheckBox checkBox = _cblistdataview;
			if (checkBox != null)
			{
				checkBox.CheckedChanged -= value2;
			}
			_cblistdataview = value;
			checkBox = _cblistdataview;
			if (checkBox != null)
			{
				checkBox.CheckedChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Column0")]
	internal  DataGridViewCheckBoxColumn Column0
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
	*/
    internal TableLayoutPanel TableLayoutPanel1;
    internal DataGridView DataViewmtk;
    internal Guna2Button OK_Button;
    internal Guna2Button Cancel_Button;
    internal CheckBox cblistdataview;
    internal DataGridViewCheckBoxColumn Column0;
    internal DataGridViewTextBoxColumn part;
    internal DataGridViewTextBoxColumn Column1;

    public Select_Prtitoin()
	{
		base.Load += Select_Prtitoin_Load;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Select_Prtitoin));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.OK_Button = new Guna.UI2.WinForms.Guna2Button();
            this.Cancel_Button = new Guna.UI2.WinForms.Guna2Button();
            this.DataViewmtk = new System.Windows.Forms.DataGridView();
            this.Column0 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.part = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cblistdataview = new System.Windows.Forms.CheckBox();
            this.TableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataViewmtk)).BeginInit();
            this.SuspendLayout();
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutPanel1.ColumnCount = 2;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.72249F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.27751F));
            this.TableLayoutPanel1.Controls.Add(this.OK_Button, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.Cancel_Button, 1, 0);
            this.TableLayoutPanel1.Location = new System.Drawing.Point(5, 461);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 1;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(272, 29);
            this.TableLayoutPanel1.TabIndex = 0;
            // 
            // OK_Button
            // 
            this.OK_Button.Animated = true;
            this.OK_Button.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.OK_Button.BorderRadius = 4;
            this.OK_Button.BorderThickness = 2;
            this.OK_Button.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.OK_Button.CheckedState.FillColor = System.Drawing.Color.LightGray;
            this.OK_Button.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.OK_Button.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
            this.OK_Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.OK_Button.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.OK_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.OK_Button.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.OK_Button.ForeColor = System.Drawing.Color.White;
            this.OK_Button.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.OK_Button.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.OK_Button.Image = global::Properties.Resources.tick;
            this.OK_Button.Location = new System.Drawing.Point(3, 3);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.PressedColor = System.Drawing.Color.Empty;
            this.OK_Button.Size = new System.Drawing.Size(161, 23);
            this.OK_Button.TabIndex = 0;
            this.OK_Button.Text = "OK";
            this.OK_Button.TextFormatNoPrefix = true;
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cancel_Button.Animated = true;
            this.Cancel_Button.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Cancel_Button.BorderRadius = 4;
            this.Cancel_Button.BorderThickness = 2;
            this.Cancel_Button.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.Cancel_Button.CheckedState.FillColor = System.Drawing.Color.LightGray;
            this.Cancel_Button.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.Cancel_Button.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Cancel_Button.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
            this.Cancel_Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Cancel_Button.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.Cancel_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Cancel_Button.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_Button.ForeColor = System.Drawing.Color.White;
            this.Cancel_Button.HoverState.BorderColor = System.Drawing.Color.Red;
            this.Cancel_Button.HoverState.CustomBorderColor = System.Drawing.Color.Red;
            this.Cancel_Button.Image = global::Properties.Resources.close__1_;
            this.Cancel_Button.Location = new System.Drawing.Point(170, 3);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(99, 23);
            this.Cancel_Button.TabIndex = 1;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.TextFormatNoPrefix = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // DataViewmtk
            // 
            this.DataViewmtk.AllowUserToAddRows = false;
            this.DataViewmtk.AllowUserToDeleteRows = false;
            this.DataViewmtk.AllowUserToResizeColumns = false;
            this.DataViewmtk.AllowUserToResizeRows = false;
            this.DataViewmtk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataViewmtk.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataViewmtk.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.DataViewmtk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataViewmtk.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.DataViewmtk.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataViewmtk.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataViewmtk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataViewmtk.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column0,
            this.part,
            this.Column1});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(0, 85, 207);
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataViewmtk.DefaultCellStyle = dataGridViewCellStyle5;
            this.DataViewmtk.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.DataViewmtk.EnableHeadersVisualStyles = false;
            this.DataViewmtk.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.DataViewmtk.Location = new System.Drawing.Point(0, 0);
            this.DataViewmtk.MultiSelect = false;
            this.DataViewmtk.Name = "DataViewmtk";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(0, 85, 207);
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataViewmtk.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DataViewmtk.RowHeadersVisible = false;
            this.DataViewmtk.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.DataViewmtk.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataViewmtk.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.DataViewmtk.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(0, 85, 207);
            this.DataViewmtk.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DataViewmtk.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataViewmtk.Size = new System.Drawing.Size(285, 449);
            this.DataViewmtk.TabIndex = 485;
            this.DataViewmtk.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataViewmtk_CellContentClick);
            // 
            // Column0
            // 
            this.Column0.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column0.Frozen = true;
            this.Column0.HeaderText = " ";
            this.Column0.Name = "Column0";
            this.Column0.Width = 19;
            // 
            // part
            // 
            this.part.HeaderText = "Partition Name";
            this.part.Name = "part";
            this.part.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // cblistdataview
            // 
            this.cblistdataview.AutoSize = true;
            this.cblistdataview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.cblistdataview.Location = new System.Drawing.Point(3, 2);
            this.cblistdataview.Name = "cblistdataview";
            this.cblistdataview.Size = new System.Drawing.Size(15, 14);
            this.cblistdataview.TabIndex = 486;
            this.cblistdataview.UseVisualStyleBackColor = false;
            this.cblistdataview.CheckedChanged += new System.EventHandler(this.cblistdataview_CheckedChanged);
            // 
            // Select_Prtitoin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(281, 492);
            this.ControlBox = false;
            this.Controls.Add(this.cblistdataview);
            this.Controls.Add(this.DataViewmtk);
            this.Controls.Add(this.TableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Select_Prtitoin";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select Partition For Write";
            this.TableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataViewmtk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

	}

	private void Select_Prtitoin_Load(object sender, EventArgs e)
	{
		base.Enabled = false;
		new Thread(HH).Start();
	}

	public void HH()
	{
		string fileName = FileName;
		ReadFilesFromZipToDataGridView(fileName, DataViewmtk);
		base.Enabled = true;
	}

	public void ExtractCheckedFilesFromDataGridView(string compressedFilePath, string extractToPath, DataGridView dataGridView)
	{
		try
		{
			if (!Directory.Exists(extractToPath))
			{
				Directory.CreateDirectory(extractToPath);
			}
			ZipArchive val = ZipFile.OpenRead(compressedFilePath);
			try
			{
				foreach (DataGridViewRow item in (IEnumerable)dataGridView.Rows)
				{
					if (!Convert.ToBoolean(RuntimeHelpers.GetObjectValue(item.Cells[0].Value)))
					{
						continue;
					}
					string text = item.Cells[1].Value.ToString();
					ZipArchiveEntry entry = val.GetEntry(text);
					if (entry != null)
					{
						string text2 = Path.Combine(extractToPath, text);
						if (!Directory.Exists(Path.GetDirectoryName(text2)))
						{
							Directory.CreateDirectory(Path.GetDirectoryName(text2));
						}
						entry.ExtractToFile(text2, overwrite: true);
					}
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

	public void ReadFilesFromZipToDataGridView(string zipFilePath, DataGridView dataGridView)
	{
		dataGridView.Rows.Clear();
		ZipArchive val = ZipFile.OpenRead(zipFilePath);
		try
		{
			foreach (ZipArchiveEntry entry in val.Entries)
			{
				if (!entry.FullName.EndsWith("/"))
				{
					using StreamReader streamReader = new StreamReader(entry.Open());
					string text = streamReader.ReadToEnd();
					Thread.Sleep(500);
					dataGridView.Rows.Add(true, entry.FullName, text);
					cblistdataview.Checked = true;
				}
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	private void OK_Button_Click(object sender, EventArgs e)
	{
		ExtractCheckedFilesFromDataGridView(FileName, Fileto, DataViewmtk);
		DialogResultt = "OK";
		Close();
	}

	private void Cancel_Button_Click(object sender, EventArgs e)
	{
		DialogResultt = "Cansel";
		Close();
	}

	private void cblistdataview_CheckedChanged(object sender, EventArgs e)
	{
		if (DataViewmtk.Rows.Count <= 0)
		{
			return;
		}
		if (!cblistdataview.Checked)
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

    private void Cancel_Button_Click_1(object sender, EventArgs e)
    {

    }

    private void DataViewmtk_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void cblistdataview_CheckedChanged_1(object sender, EventArgs e)
    {

    }
}
