using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace motoulocked.Controls;

public class TabControlExt : TabControl
{
	private Color _backColor;

	private Color closeBtnColorField;

	private Color _borderColor;

	private Color _headSelectedBorderColor;

	private Color _headerBackColor;

	private Color _headSelectedBackColor;

	private Color _tabTextColor;

	[Description("是否显示关闭按钮")]
	[Category("自定义")]
	public bool IsShowCloseBtn { get; set; }

	[Description("不可关闭的标签序号列表，下标0")]
	[Category("自定义")]
	public int[] UncloseTabIndexs { get; set; }

	[Browsable(true)]
	[EditorBrowsable(EditorBrowsableState.Always)]
	[DefaultValue(typeof(Color), "White")]
	public override Color BackColor
	{
		get
		{
			return _backColor;
		}
		set
		{
			_backColor = value;
			Invalidate(invalidateChildren: true);
		}
	}

	[Description("关闭按钮颜色")]
	public Color CloseBtnColor
	{
		get
		{
			return closeBtnColorField;
		}
		set
		{
			closeBtnColorField = value;
		}
	}

	[DefaultValue(typeof(Color), "232, 232, 232")]
	[Description("TabContorl边框色")]
	public Color BorderColor
	{
		get
		{
			return _borderColor;
		}
		set
		{
			_borderColor = value;
			Invalidate(invalidateChildren: true);
		}
	}

	[DefaultValue(typeof(Color), "232, 232, 232")]
	[Description("TabPage头部选中后的边框颜色")]
	public Color HeadSelectedBorderColor
	{
		get
		{
			return _headSelectedBorderColor;
		}
		set
		{
			_headSelectedBorderColor = value;
		}
	}

	[DefaultValue(typeof(Color), "White")]
	[Description("TabPage头部默认背景颜色")]
	public Color HeaderBackColor
	{
		get
		{
			return _headerBackColor;
		}
		set
		{
			_headerBackColor = value;
		}
	}

	[DefaultValue(typeof(Color), "255, 85, 51")]
	[Description("TabPage头部选中后的背景颜色")]
	public Color HeadSelectedBackColor
	{
		get
		{
			return _headSelectedBackColor;
		}
		set
		{
			_headSelectedBackColor = value;
			Invalidate(invalidateChildren: true);
		}
	}

	[DefaultValue(typeof(Color), "Black")]
	[Description("TabPage标题文本颜色")]
	public Color TabTextColor
	{
		get
		{
			return _tabTextColor;
		}
		set
		{
			_tabTextColor = value;
			Invalidate(invalidateChildren: true);
		}
	}

	public TabControlExt()
	{
		_backColor = Color.White;
		closeBtnColorField = Color.FromArgb(255, 85, 51);
		_borderColor = Color.FromArgb(232, 232, 232);
		_headSelectedBorderColor = Color.FromArgb(232, 232, 232);
		_headerBackColor = Color.White;
		_headSelectedBackColor = Color.FromArgb(255, 85, 51);
		_tabTextColor = Color.Black;
		SetStyles();
		base.ItemSize = new Size(base.ItemSize.Width, 50);
	}

	private void SetStyles()
	{
		SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer | ControlStyles.OptimizedDoubleBuffer, value: true);
		UpdateStyles();
	}

	protected override void OnPaintBackground(PaintEventArgs pevent)
	{
		if (base.DesignMode)
		{
			LinearGradientBrush linearGradientBrush = new LinearGradientBrush(base.Bounds, SystemColors.ControlLightLight, SystemColors.ControlLight, LinearGradientMode.Vertical);
			pevent.Graphics.FillRectangle(linearGradientBrush, base.Bounds);
			linearGradientBrush.Dispose();
		}
		else
		{
			PaintTransparentBackground(pevent.Graphics, base.ClientRectangle);
		}
	}

	protected void PaintTransparentBackground(Graphics g, Rectangle clipRect)
	{
		checked
		{
			if (base.Parent != null)
			{
				clipRect.Offset(base.Location);
				PaintEventArgs e = new PaintEventArgs(g, clipRect);
				GraphicsState gstate = g.Save();
				g.SmoothingMode = SmoothingMode.HighSpeed;
				try
				{
					g.TranslateTransform(-base.Location.X, -base.Location.Y);
					InvokePaintBackground(base.Parent, e);
					InvokePaint(base.Parent, e);
					return;
				}
				finally
				{
					g.Restore(gstate);
					clipRect.Offset(-base.Location.X, -base.Location.Y);
					using SolidBrush brush = new SolidBrush(_backColor);
					clipRect.Inflate(1, 1);
					g.FillRectangle(brush, clipRect);
				}
			}
			LinearGradientBrush linearGradientBrush = new LinearGradientBrush(base.Bounds, SystemColors.ControlLightLight, SystemColors.ControlLight, LinearGradientMode.Vertical);
			g.FillRectangle(linearGradientBrush, base.Bounds);
			linearGradientBrush.Dispose();
		}
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		base.OnPaint(e);
		PaintTransparentBackground(e.Graphics, base.ClientRectangle);
		PaintAllTheTabs(e);
		PaintTheTabPageBorder(e);
	}

	private void PaintAllTheTabs(PaintEventArgs e)
	{
		checked
		{
			if (base.TabCount > 0)
			{
				int num = base.TabCount - 1;
				for (int i = 0; i <= num; i++)
				{
					PaintTab(e, i);
				}
			}
		}
	}

	private void PaintTab(PaintEventArgs e, int index)
	{
		GraphicsPath tabPath = GetTabPath(index);
		PaintTabBackground(e.Graphics, index, tabPath);
		PaintTabBorder(e.Graphics, index, tabPath);
		PaintTabText(e.Graphics, index);
		PaintTabImage(e.Graphics, index);
		checked
		{
			if (IsShowCloseBtn && (UncloseTabIndexs == null || !UncloseTabIndexs.ToList().Contains(index)))
			{
				Rectangle tabRect = GetTabRect(index);
				e.Graphics.DrawLine(new Pen(closeBtnColorField, 1f), new Point(tabRect.Right - 15, tabRect.Top + 5), new Point(tabRect.Right - 5, tabRect.Top + 15));
				e.Graphics.DrawLine(new Pen(closeBtnColorField, 1f), new Point(tabRect.Right - 5, tabRect.Top + 5), new Point(tabRect.Right - 15, tabRect.Top + 15));
			}
		}
	}

	private void PaintTabBackground(Graphics graph, int index, GraphicsPath path)
	{
		Rectangle tabRect = GetTabRect(index);
		if (tabRect.Width != 0 && tabRect.Height != 0)
		{
			Brush brush = ((index != base.SelectedIndex) ? ((Brush)new LinearGradientBrush(tabRect, _headerBackColor, _headerBackColor, LinearGradientMode.Vertical)) : ((Brush)new SolidBrush(_headSelectedBackColor)));
			graph.FillPath(brush, path);
			brush.Dispose();
		}
	}

	private void PaintTabBorder(Graphics graph, int index, GraphicsPath path)
	{
		Pen pen = new Pen(_borderColor);
		if (index == base.SelectedIndex)
		{
			pen = new Pen(_headSelectedBorderColor);
		}
		graph.DrawPath(pen, path);
		pen.Dispose();
	}

	private void PaintTabImage(Graphics g, int index)
	{
		Image image = null;
		if (base.TabPages[index].ImageIndex > -1 && base.ImageList != null)
		{
			image = base.ImageList.Images[base.TabPages[index].ImageIndex];
		}
		else if (base.TabPages[index].ImageKey.Trim().Length > 0 && base.ImageList != null)
		{
			image = base.ImageList.Images[base.TabPages[index].ImageKey];
		}
		if (image != null)
		{
			Rectangle tabRect = GetTabRect(index);
			g.DrawImage(image, checked(new Point(tabRect.X + 3, tabRect.Y + 3)));
		}
	}

	private void PaintTabText(Graphics graph, int index)
	{
		Rectangle tabRect = GetTabRect(index);
		if (tabRect.Width != 0 && tabRect.Height != 0)
		{
			RectangleF layoutRectangle = GetTabRect(index);
			StringFormat stringFormat = new StringFormat();
			stringFormat.Alignment = StringAlignment.Center;
			stringFormat.LineAlignment = StringAlignment.Center;
			Font font = Font;
			Brush brush = new SolidBrush(_tabTextColor);
			graph.DrawString(base.TabPages[index].Text, font, brush, layoutRectangle, stringFormat);
		}
	}

	private GraphicsPath GetTabPath(int index)
	{
		GraphicsPath graphicsPath = new GraphicsPath();
		GetTabRect(index);
		Rectangle tabRect = GetTabRect(index);
		graphicsPath.AddRectangle(tabRect);
		return graphicsPath;
	}

	private void PaintTheTabPageBorder(PaintEventArgs e)
	{
		//if (base.TabCount > 0)
		//{
		//	Rectangle bounds = base.TabPages[base.SelectedIndex].Bounds;
		//	bounds.Inflate(1, 1);
		//	e.Graphics.DrawRectangle(new Pen(_borderColor), bounds);
		//}
	}
}
