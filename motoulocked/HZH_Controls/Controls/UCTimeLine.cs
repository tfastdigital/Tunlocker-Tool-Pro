using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace motoulocked.HZH_Controls.Controls;

public class UCTimeLine : UserControl
{
	private Color lineColorField;

	private Font titleFontField;

	private Color titleForcolorField;

	private Font detailsFontField;

	private Color detailsForcolorField;

	private TimeLineItem[] itemsField;

	[Description("连接线颜色")]
	[Category("自定义")]
	public Color LineColor
	{
		get
		{
			return lineColorField;
		}
		set
		{
			lineColorField = value;
			Invalidate();
		}
	}

	[Description("标题字体")]
	[Category("自定义")]
	public Font TitleFont
	{
		get
		{
			return titleFontField;
		}
		set
		{
			titleFontField = value;
			ReloadItems();
		}
	}

	[Description("标题颜色")]
	[Category("自定义")]
	public Color TitleForcolor
	{
		get
		{
			return titleForcolorField;
		}
		set
		{
			titleForcolorField = value;
			ReloadItems();
		}
	}

	[Description("详情字体")]
	[Category("自定义")]
	public Font DetailsFont
	{
		get
		{
			return detailsFontField;
		}
		set
		{
			detailsFontField = value;
			ReloadItems();
		}
	}

	[Description("详情颜色")]
	[Category("自定义")]
	public Color DetailsForcolor
	{
		get
		{
			return detailsForcolorField;
		}
		set
		{
			detailsForcolorField = value;
			ReloadItems();
		}
	}

	[Description("项列表")]
	[Category("自定义")]
	public TimeLineItem[] Items
	{
		get
		{
			return itemsField;
		}
		set
		{
			itemsField = value;
			ReloadItems();
		}
	}

	public UCTimeLine()
	{
		lineColorField = TextColors.Light;
		titleFontField = new Font("微软雅黑", 14f);
		titleForcolorField = TextColors.MoreDark;
		detailsFontField = new Font("微软雅黑", 10f);
		detailsForcolorField = TextColors.Light;
		SetStyle(ControlStyles.AllPaintingInWmPaint, value: true);
		SetStyle(ControlStyles.DoubleBuffer, value: true);
		SetStyle(ControlStyles.ResizeRedraw, value: true);
		SetStyle(ControlStyles.Selectable, value: true);
		SetStyle(ControlStyles.SupportsTransparentBackColor, value: true);
		SetStyle(ControlStyles.UserPaint, value: true);
		InitializeComponent();
		itemsField = new TimeLineItem[0];
		checked
		{
			if (ControlHelper.IsDesignMode())
			{
				itemsField = new TimeLineItem[4];
				int num = 0;
				do
				{
					itemsField[num] = new TimeLineItem
					{
						Title = DateTime.Now.AddMonths(-1 * (3 - num)).ToString("yyyy年MM月"),
						Details = DateTime.Now.AddMonths(-1 * (3 - num)).ToString("yyyy年MM月") + "发生了一件大事，咔嚓一声打了一个炸雷，咔嚓一声打了一个炸雷，咔嚓一声打了一个炸雷，咔嚓一声打了一个炸雷，咔嚓一声打了一个炸雷，咔嚓一声打了一个炸雷，咔嚓一声打了一个炸雷，咔嚓一声打了一个炸雷，咔嚓一声打了一个炸雷，然后王二麻子他爹王咔嚓出生了。"
					};
					num++;
				}
				while (num <= 3);
				ReloadItems();
			}
		}
	}

	private void ReloadItems()
	{
		try
		{
			ControlHelper.FreezeControl(this, blnToFreeze: true);
			base.Controls.Clear();
			if (itemsField != null)
			{
				TimeLineItem[] array = itemsField;
				foreach (TimeLineItem timeLineItem in array)
				{
					FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
					flowLayoutPanel.Dock = DockStyle.Top;
					flowLayoutPanel.AutoScroll = false;
					flowLayoutPanel.Padding = new Padding(5);
					flowLayoutPanel.Name = "title_" + Guid.NewGuid().ToString();
					Label label = new Label();
					label.Dock = DockStyle.Top;
					label.AutoSize = true;
					label.Font = titleFontField;
					label.ForeColor = titleForcolorField;
					label.Text = timeLineItem.Title;
					label.SizeChanged += item_SizeChanged;
					flowLayoutPanel.Controls.Add(label);
					base.Controls.Add(flowLayoutPanel);
					flowLayoutPanel.BringToFront();
					FlowLayoutPanel flowLayoutPanel2 = new FlowLayoutPanel();
					flowLayoutPanel2.Dock = DockStyle.Top;
					flowLayoutPanel2.AutoScroll = false;
					flowLayoutPanel2.Padding = new Padding(5);
					flowLayoutPanel2.Name = "details_" + Guid.NewGuid().ToString();
					Label label2 = new Label();
					label2.AutoSize = true;
					label2.Dock = DockStyle.Top;
					label2.Font = detailsFontField;
					label2.ForeColor = detailsForcolorField;
					label2.Text = timeLineItem.Details;
					label2.SizeChanged += item_SizeChanged;
					flowLayoutPanel2.Controls.Add(label2);
					base.Controls.Add(flowLayoutPanel2);
					flowLayoutPanel2.BringToFront();
				}
			}
		}
		finally
		{
			ControlHelper.FreezeControl(this, blnToFreeze: false);
		}
	}

	private void item_SizeChanged(object sender, EventArgs e)
	{
		Label label = (Label)sender;
		label.Parent.Height = checked(label.Height + 10);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		base.OnPaint(e);
		Graphics graphics = e.Graphics;
		SetGDIHigh(graphics);
		List<Control> list = (from Control p in base.Controls
			where p.Name.StartsWith("title_")
			select p).ToList();
		checked
		{
			int num = list.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				graphics.DrawEllipse(new Pen(new SolidBrush(LineColor)), new Rectangle(7, list[i].Location.Y + 10, 16, 16));
				if (i != list.Count - 1)
				{
					graphics.DrawLine(new Pen(new SolidBrush(LineColor)), new Point(15, list[i].Location.Y + 10 - 2), new Point(15, list[i + 1].Location.Y + 10 + 16 + 2));
				}
			}
		}
	}

	private void SetGDIHigh(Graphics g)
	{
		g.SmoothingMode = SmoothingMode.AntiAlias;
		g.InterpolationMode = InterpolationMode.HighQualityBicubic;
		g.PixelOffsetMode = PixelOffsetMode.HighQuality;
	}

	private void InitializeComponent()
	{
		base.SuspendLayout();
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		this.AutoScroll = true;
		base.Name = "UCTimeLine";
		base.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
		base.Size = new System.Drawing.Size(673, 377);
		base.ResumeLayout(false);
	}
}
