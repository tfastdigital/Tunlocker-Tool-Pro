using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace motoulocked.HZH_Controls.Controls;

public class UCProcessRoll : Control
{
	private Color rollColor;

	private string displayText;

	private Color borderColor;

	private int borderRadius;

	private DashStyle borderStyle;

	private int borderThickness;

	private Color fillColor;

	private Timer timer;

	private Rectangle workRect;

	[Description("滚动的颜色")]
	[Category("自定义")]
	public Color RollColor1
	{
		get
		{
			return rollColor;
		}
		set
		{
			rollColor = value;
			Invalidate();
		}
	}

	[Description("是否滚动")]
	[Category("自定义")]
	public bool Roll
	{
		get
		{
			return timer.Enabled;
		}
		set
		{
			timer.Enabled = value;
			if (!value)
			{
				workRect = checked(new Rectangle((int)Math.Round((double)(-base.Width) / 3.0), 0, (int)Math.Round((double)base.Width / 3.0), base.Height));
				Invalidate();
			}
		}
	}

	[Description("滚动间隔时间")]
	[Category("自定义")]
	public int SplitTime
	{
		get
		{
			return timer.Interval;
		}
		set
		{
			timer.Interval = value;
		}
	}

	[Description("显示的文本")]
	[Category("自定义")]
	public new string Text
	{
		get
		{
			return displayText;
		}
		set
		{
			displayText = value;
			Invalidate();
		}
	}

	[Description("边框颜色")]
	[Category("自定义")]
	public Color BorderColor1
	{
		get
		{
			return borderColor;
		}
		set
		{
			borderColor = value;
			Invalidate();
		}
	}

	[Description("边框半径")]
	[Category("自定义")]
	public int BorderRadius1
	{
		get
		{
			return borderRadius;
		}
		set
		{
			borderRadius = value;
			Invalidate();
		}
	}

	[Description("边框样式")]
	[Category("自定义")]
	public DashStyle BorderStyle1
	{
		get
		{
			return borderStyle;
		}
		set
		{
			borderStyle = value;
			Invalidate();
		}
	}

	[Description("边框厚度")]
	[Category("自定义")]
	public int BorderThickness1
	{
		get
		{
			return borderThickness;
		}
		set
		{
			borderThickness = value;
			Invalidate();
		}
	}

	[Description("填充颜色")]
	[Category("自定义")]
	public Color FillColor1
	{
		get
		{
			return fillColor;
		}
		set
		{
			fillColor = value;
			Invalidate();
		}
	}

	public UCProcessRoll()
	{
		rollColor = Color.FromArgb(0, 122, 204);
		displayText = "Processing...";
		borderColor = Color.Black;
		borderRadius = 0;
		borderStyle = DashStyle.Solid;
		borderThickness = 1;
		fillColor = Color.White;
		timer = new Timer();
		SetStyle(ControlStyles.AllPaintingInWmPaint, value: true);
		SetStyle(ControlStyles.DoubleBuffer, value: true);
		SetStyle(ControlStyles.ResizeRedraw, value: true);
		SetStyle(ControlStyles.Selectable, value: true);
		SetStyle(ControlStyles.SupportsTransparentBackColor, value: true);
		SetStyle(ControlStyles.UserPaint, value: true);
		base.SizeChanged += UCProcessRoll_SizeChanged;
		base.Size = new Size(300, 30);
		BackColor = Color.White;
		timer.Interval = 1;
		timer.Tick += timer_Tick;
		timer.Enabled = true;
	}

	private void UCProcessRoll_SizeChanged(object sender, EventArgs e)
	{
		workRect = checked(new Rectangle((int)Math.Round((double)(-base.Width) / 3.0), 0, (int)Math.Round((double)base.Width / 3.0), base.Height));
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		base.OnPaint(e);
		Graphics graphics = e.Graphics;
		Extensions.SetGDIHigh(graphics);
		checked
		{
			using (SolidBrush brush = new SolidBrush(fillColor))
			{
				if (borderRadius > 0)
				{
					GraphicsPath graphicsPath = new GraphicsPath();
					graphicsPath.AddArc(0, 0, borderRadius, borderRadius, 180f, 90f);
					graphicsPath.AddArc(base.Width - borderRadius, 0, borderRadius, borderRadius, 270f, 90f);
					graphicsPath.AddArc(base.Width - borderRadius, base.Height - borderRadius, borderRadius, borderRadius, 0f, 90f);
					graphicsPath.AddArc(0, base.Height - borderRadius, borderRadius, borderRadius, 90f, 90f);
					graphicsPath.CloseAllFigures();
					graphics.FillPath(brush, graphicsPath);
				}
				else
				{
					graphics.FillRectangle(brush, 0, 0, base.Width, base.Height);
				}
			}
			RectangleF rect = new RectangleF(new Point(workRect.Left - 1, workRect.Top), new Size((int)Math.Round((double)workRect.Width / 3.0 + 1.0), workRect.Height));
			RectangleF rect2 = new RectangleF(new Point((int)Math.Round((double)workRect.Right - (double)workRect.Width / 3.0), workRect.Top), new Size((int)Math.Round((double)workRect.Width / 3.0), workRect.Height));
			LinearGradientBrush brush2 = new LinearGradientBrush(rect, Color.FromArgb(0, rollColor), rollColor, 0f);
			LinearGradientBrush brush3 = new LinearGradientBrush(rect2, rollColor, Color.FromArgb(0, rollColor), 0f);
			graphics.FillRectangle(brush2, new Rectangle(new Point(workRect.Left, workRect.Top), new Size((int)Math.Round((double)workRect.Width / 3.0), workRect.Height)));
			graphics.FillRectangle(new SolidBrush(rollColor), new RectangleF((float)((double)workRect.Left + (double)workRect.Width / 3.0 - 1.0), workRect.Top, (float)((double)workRect.Width / 3.0 + 3.0), workRect.Height));
			graphics.FillRectangle(brush3, rect2);
			SizeF sizeF = graphics.MeasureString(displayText, Font);
			float num = ((float)base.Width - sizeF.Width) / 2f;
			float num2 = ((float)base.Height - sizeF.Height) / 2f;
			graphics.DrawString(displayText, Font, Brushes.White, num, num2);
			using Pen pen = new Pen(borderColor, borderThickness);
			pen.DashStyle = borderStyle;
			if (borderRadius > 0)
			{
				GraphicsPath graphicsPath2 = new GraphicsPath();
				graphicsPath2.AddArc(0, 0, borderRadius, borderRadius, 180f, 90f);
				graphicsPath2.AddArc(base.Width - borderRadius, 0, borderRadius, borderRadius, 270f, 90f);
				graphicsPath2.AddArc(base.Width - borderRadius, base.Height - borderRadius, borderRadius, borderRadius, 0f, 90f);
				graphicsPath2.AddArc(0, base.Height - borderRadius, borderRadius, borderRadius, 90f, 90f);
				graphicsPath2.CloseAllFigures();
				graphics.DrawPath(pen, graphicsPath2);
			}
			else
			{
				graphics.DrawRectangle(pen, 0, 0, base.Width - 1, base.Height - 1);
			}
		}
	}

	private void timer_Tick(object sender, EventArgs e)
	{
		checked
		{
			if (!(workRect == default(Rectangle)))
			{
				workRect = new Rectangle(workRect.Left + 20, 0, (int)Math.Round((double)base.Width / 4.0), base.Height);
				if (workRect.Left >= base.ClientRectangle.Right)
				{
					workRect = new Rectangle((int)Math.Round((double)(-base.Width) / 4.0), 0, (int)Math.Round((double)base.Width / 4.0), base.Height);
				}
				Invalidate();
			}
		}
	}
}
