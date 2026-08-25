using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;
using Microsoft.VisualBasic.CompilerServices;
using motoulocked.HZH_Controls.Controls;
using motoulocked.motoulocked;
using Properties;

namespace motoulocked;

[DesignerGenerated]
public class log_Updeta : Form
{
	private IContainer components;

	[CompilerGenerated]
	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2Button28")]
	private Guna2Button _Guna2Button28;
    /*
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

	internal  Guna2Button Guna2Button28
	{
		[CompilerGenerated]
		get
		{
			return _Guna2Button28;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Guna2Button28_Click;
			Guna2Button guna2Button = _Guna2Button28;
			if (guna2Button != null)
			{
				guna2Button.Click -= value2;
			}
			_Guna2Button28 = value;
			guna2Button = _Guna2Button28;
			if (guna2Button != null)
			{
				guna2Button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("UcTimeLine1")]
	internal  UCTimeLine UcTimeLine1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}
	*/
    internal Timer Timer1;
    internal Guna2GroupBox Guna2GroupBox2;
    internal Guna2VScrollBar Guna2VScrollBar2;
    internal Guna2Button Guna2Button28;
    internal UCTimeLine UcTimeLine1;

    public log_Updeta()
	{
		base.Load += log_Updeta_Load;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(log_Updeta));
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.Guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.Guna2VScrollBar2 = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.UcTimeLine1 = new HZH_Controls.Controls.UCTimeLine();
            this.Guna2Button28 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 500;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Guna2GroupBox2
            // 
            this.Guna2GroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Guna2GroupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guna2GroupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2GroupBox2.BorderRadius = 5;
            this.Guna2GroupBox2.BorderThickness = 2;
            this.Guna2GroupBox2.Controls.Add(this.Guna2VScrollBar2);
            this.Guna2GroupBox2.Controls.Add(this.UcTimeLine1);
            this.Guna2GroupBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2GroupBox2.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.Guna2GroupBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2GroupBox2.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2GroupBox2.Location = new System.Drawing.Point(9, 9);
            this.Guna2GroupBox2.Name = "Guna2GroupBox2";
            this.Guna2GroupBox2.ShadowDecoration.BorderRadius = 9;
            this.Guna2GroupBox2.ShadowDecoration.Color = System.Drawing.Color.White;
            this.Guna2GroupBox2.ShadowDecoration.Depth = 15;
            this.Guna2GroupBox2.Size = new System.Drawing.Size(648, 540);
            this.Guna2GroupBox2.TabIndex = 509;
            this.Guna2GroupBox2.Text = "Updeta Logs";
            // 
            // Guna2VScrollBar2
            // 
            this.Guna2VScrollBar2.AutoRoundedCorners = true;
            this.Guna2VScrollBar2.AutoScroll = true;
            this.Guna2VScrollBar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2VScrollBar2.BindingContainer = this.UcTimeLine1;
            this.Guna2VScrollBar2.BorderRadius = 8;
            this.Guna2VScrollBar2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2VScrollBar2.HighlightOnWheel = true;
            this.Guna2VScrollBar2.InUpdate = false;
            this.Guna2VScrollBar2.LargeChange = 10;
            this.Guna2VScrollBar2.Location = new System.Drawing.Point(627, 43);
            this.Guna2VScrollBar2.MouseWheelBarPartitions = 100;
            this.Guna2VScrollBar2.Name = "Guna2VScrollBar2";
            this.Guna2VScrollBar2.ScrollbarSize = 18;
            this.Guna2VScrollBar2.Size = new System.Drawing.Size(18, 494);
            this.Guna2VScrollBar2.TabIndex = 227;
            this.Guna2VScrollBar2.ThumbColor = System.Drawing.Color.FromArgb(0, 85, 207);
            this.Guna2VScrollBar2.ThumbSize = 50F;
            this.Guna2VScrollBar2.ThumbStyle = Guna.UI2.WinForms.Enums.ThumbStyle.Inset;
            // 
            // UcTimeLine1
            // 
            this.UcTimeLine1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UcTimeLine1.AutoScroll = true;
            this.UcTimeLine1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.UcTimeLine1.DetailsFont = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.UcTimeLine1.DetailsForcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.UcTimeLine1.Items = new HZH_Controls.Controls.TimeLineItem[0];
            this.UcTimeLine1.LineColor = System.Drawing.Color.Gray;
            this.UcTimeLine1.Location = new System.Drawing.Point(2, 43);
            this.UcTimeLine1.Name = "UcTimeLine1";
            this.UcTimeLine1.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.UcTimeLine1.Size = new System.Drawing.Size(643, 494);
            this.UcTimeLine1.TabIndex = 228;
            this.UcTimeLine1.TitleFont = new System.Drawing.Font("Microsoft YaHei", 14F);
            this.UcTimeLine1.TitleForcolor = System.Drawing.Color.White;
            // 
            // Guna2Button28
            // 
            this.Guna2Button28.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Guna2Button28.Animated = true;
            this.Guna2Button28.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Guna2Button28.BorderRadius = 4;
            this.Guna2Button28.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.Guna2Button28.BorderThickness = 2;
            this.Guna2Button28.CheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button28.CheckedState.FillColor = System.Drawing.Color.LightGray;
            this.Guna2Button28.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.Guna2Button28.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guna2Button28.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button28.DisabledState.CustomBorderColor = System.Drawing.Color.DimGray;
            this.Guna2Button28.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Guna2Button28.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.Guna2Button28.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Guna2Button28.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2Button28.ForeColor = System.Drawing.Color.White;
            this.Guna2Button28.HoverState.BorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button28.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(21, 87, 255);
            this.Guna2Button28.Image = global::Properties.Resources.tick1;
            this.Guna2Button28.Location = new System.Drawing.Point(9, 555);
            this.Guna2Button28.Name = "Guna2Button28";
            this.Guna2Button28.PressedColor = System.Drawing.Color.Empty;
            this.Guna2Button28.Size = new System.Drawing.Size(648, 32);
            this.Guna2Button28.TabIndex = 510;
            this.Guna2Button28.Text = "Okey";
            this.Guna2Button28.TextFormatNoPrefix = true;
            this.Guna2Button28.Click += new System.EventHandler(this.Guna2Button28_Click);
            // 
            // log_Updeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(666, 596);
            this.ControlBox = false;
            this.Controls.Add(this.Guna2Button28);
            this.Controls.Add(this.Guna2GroupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(591, 588);
            this.Name = "log_Updeta";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.log_Updeta_Load);
            this.Guna2GroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

	}

	private void log_Updeta_Load(object sender, EventArgs e)
	{
		LoadTimelineItems();
	}

	public void LoadTimelineItems()
	{
		string text = Api_Core.FromBase64(SevaClass.log);
		List<TimeLineItem> list = ParseTimelineItems(text);
		UcTimeLine1.Items = list.ToArray();
		lass0.Check_Show_Change_Log();
	}

	private List<TimeLineItem> ParseTimelineItems(string text)
	{
		List<TimeLineItem> list = new List<TimeLineItem>();
		MatchCollection matchCollection = new Regex("▪\ufe0f▪\ufe0f▪\ufe0f▪\ufe0f▪\ufe0f▪\ufe0f▪\ufe0f▪\ufe0f▪\ufe0f▪\ufe0f\\[(V[^\\]]+)\\]▪\ufe0f▪\ufe0f▪\ufe0f▪\ufe0f▪\ufe0f▪\ufe0f▪\ufe0f▪\ufe0f▪\ufe0f▪\ufe0f\\s*(.*?)\\s*(?=▪\ufe0f▪\ufe0f▪\ufe0f▪\ufe0f▪\ufe0f▪\ufe0f▪\ufe0f▪\ufe0f▪\ufe0f▪\ufe0f\\[|$\\]▪\ufe0f▪\ufe0f▪\ufe0f▪\ufe0f▪\ufe0f▪\ufe0f▪\ufe0f▪\ufe0f▪\ufe0f▪\ufe0f)", RegexOptions.Multiline | RegexOptions.Singleline).Matches(text);
		foreach (Match item in matchCollection)
		{
			string text2 = item.Groups[1].Value.Trim();
			string details = item.Groups[2].Value.Trim();
			TimeLineItem timeLineItem = new TimeLineItem();
			timeLineItem.Title = "Update " + text2;
			timeLineItem.Details = details;
			list.Add(timeLineItem);
		}
		return list;
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		Timer1.Enabled = false;
	}

	private void Guna2Button28_Click(object sender, EventArgs e)
	{
		Close();
	}








}
