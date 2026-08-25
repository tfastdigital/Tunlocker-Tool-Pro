using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Properties;

namespace motoulocked;

[DesignerGenerated]
public class No_Internet : Form
{
	private IContainer components;

	[field: AccessedThroughProperty("Label3")]
	internal Label Label3
;

	[field: AccessedThroughProperty("PictureBox9")]
	internal PictureBox PictureBox9
;

	public No_Internet()
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
            this.Label3 = new System.Windows.Forms.Label();
            this.PictureBox9 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // Label3
            // 
            this.Label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label3.AutoSize = true;
            this.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label3.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(168, 300);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(152, 17);
            this.Label3.TabIndex = 524;
            this.Label3.Text = "No Internet Connection";
            // 
            // PictureBox9
            // 
            this.PictureBox9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PictureBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PictureBox9.Image = global::Properties.Resources.no_wifi;
            this.PictureBox9.Location = new System.Drawing.Point(199, 195);
            this.PictureBox9.Name = "PictureBox9";
            this.PictureBox9.Size = new System.Drawing.Size(87, 86);
            this.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox9.TabIndex = 523;
            this.PictureBox9.TabStop = false;
            // 
            // No_Internet
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(496, 534);
            this.ControlBox = false;
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.PictureBox9);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "No_Internet";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.No_Internet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

	}

    private void No_Internet_Load(object sender, System.EventArgs e)
    {

    }
}
