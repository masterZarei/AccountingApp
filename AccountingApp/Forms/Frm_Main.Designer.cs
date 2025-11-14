namespace AccountingApp.Forms
{
    partial class Frm_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      menuStrip1 = new MenuStrip();
      ایجادحسابجدیدToolStripMenuItem = new ToolStripMenuItem();
      تراکنشجدیدToolStripMenuItem = new ToolStripMenuItem();
      افزایشموجودیToolStripMenuItem = new ToolStripMenuItem();
      کاهشموجودیToolStripMenuItem = new ToolStripMenuItem();
      انتقالوجهToolStripMenuItem = new ToolStripMenuItem();
      label1 = new Label();
      dgv = new DataGridView();
      menuStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
      SuspendLayout();
      // 
      // menuStrip1
      // 
      menuStrip1.ImageScalingSize = new Size(20, 20);
      menuStrip1.Items.AddRange(new ToolStripItem[] { ایجادحسابجدیدToolStripMenuItem, تراکنشجدیدToolStripMenuItem });
      menuStrip1.Location = new Point(0, 0);
      menuStrip1.Name = "menuStrip1";
      menuStrip1.RightToLeft = RightToLeft.Yes;
      menuStrip1.Size = new Size(802, 28);
      menuStrip1.TabIndex = 0;
      menuStrip1.Text = "menuStrip1";
      // 
      // ایجادحسابجدیدToolStripMenuItem
      // 
      ایجادحسابجدیدToolStripMenuItem.Name = "ایجادحسابجدیدToolStripMenuItem";
      ایجادحسابجدیدToolStripMenuItem.Size = new Size(131, 24);
      ایجادحسابجدیدToolStripMenuItem.Text = "ایجاد حساب جدید";
      ایجادحسابجدیدToolStripMenuItem.Click += ایجادحسابجدیدToolStripMenuItem_Click;
      // 
      // تراکنشجدیدToolStripMenuItem
      // 
      تراکنشجدیدToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { افزایشموجودیToolStripMenuItem, کاهشموجودیToolStripMenuItem, انتقالوجهToolStripMenuItem });
      تراکنشجدیدToolStripMenuItem.Name = "تراکنشجدیدToolStripMenuItem";
      تراکنشجدیدToolStripMenuItem.Size = new Size(102, 24);
      تراکنشجدیدToolStripMenuItem.Text = "تراکنش جدید";
      // 
      // افزایشموجودیToolStripMenuItem
      // 
      افزایشموجودیToolStripMenuItem.Name = "افزایشموجودیToolStripMenuItem";
      افزایشموجودیToolStripMenuItem.Size = new Size(224, 26);
      افزایشموجودیToolStripMenuItem.Text = "افزایش موجودی";
      افزایشموجودیToolStripMenuItem.Click += افزایشموجودیToolStripMenuItem_Click;
      // 
      // کاهشموجودیToolStripMenuItem
      // 
      کاهشموجودیToolStripMenuItem.Name = "کاهشموجودیToolStripMenuItem";
      کاهشموجودیToolStripMenuItem.Size = new Size(224, 26);
      کاهشموجودیToolStripMenuItem.Text = "کاهش موجودی";
      کاهشموجودیToolStripMenuItem.Click += کاهشموجودیToolStripMenuItem_Click;
      // 
      // انتقالوجهToolStripMenuItem
      // 
      انتقالوجهToolStripMenuItem.Name = "انتقالوجهToolStripMenuItem";
      انتقالوجهToolStripMenuItem.Size = new Size(224, 26);
      انتقالوجهToolStripMenuItem.Text = "انتقال وجه";
      انتقالوجهToolStripMenuItem.Click += انتقالوجهToolStripMenuItem_Click;
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Font = new Font("Vazir", 36F, FontStyle.Regular, GraphicsUnit.Point);
      label1.Location = new Point(234, 23);
      label1.Name = "label1";
      label1.Size = new Size(329, 94);
      label1.TabIndex = 1;
      label1.Text = "خوش آمدید";
      // 
      // dgv
      // 
      dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dgv.Location = new Point(12, 125);
      dgv.Name = "dgv";
      dgv.RowHeadersWidth = 51;
      dgv.RowTemplate.Height = 29;
      dgv.Size = new Size(778, 316);
      dgv.TabIndex = 2;
      // 
      // Frm_Main
      // 
      AutoScaleDimensions = new SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(802, 453);
      Controls.Add(dgv);
      Controls.Add(label1);
      Controls.Add(menuStrip1);
      FormBorderStyle = FormBorderStyle.FixedDialog;
      MainMenuStrip = menuStrip1;
      Name = "Frm_Main";
      ShowIcon = false;
      Text = "خانه";
      FormClosing += Frm_Main_FormClosing;
      Load += Frm_Main_Load;
      menuStrip1.ResumeLayout(false);
      menuStrip1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private MenuStrip menuStrip1;
        private ToolStripMenuItem ایجادحسابجدیدToolStripMenuItem;
        private ToolStripMenuItem تراکنشجدیدToolStripMenuItem;
        private ToolStripMenuItem افزایشموجودیToolStripMenuItem;
        private ToolStripMenuItem کاهشموجودیToolStripMenuItem;
        private ToolStripMenuItem انتقالوجهToolStripMenuItem;
        private Label label1;
        private DataGridView dgv;
    }
}
