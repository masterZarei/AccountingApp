namespace AccountingApp.Forms
{
    partial class Frm_Decrease
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
      button2 = new Button();
      button1 = new Button();
      txt_Amount = new TextBox();
      label2 = new Label();
      txt_AccountId = new TextBox();
      label1 = new Label();
      SuspendLayout();
      // 
      // button2
      // 
      button2.BackColor = Color.DarkGray;
      button2.FlatStyle = FlatStyle.Flat;
      button2.Font = new Font("Vazir", 12F, FontStyle.Bold, GraphicsUnit.Point);
      button2.ForeColor = SystemColors.ActiveCaptionText;
      button2.Location = new Point(12, 297);
      button2.Name = "button2";
      button2.Size = new Size(180, 48);
      button2.TabIndex = 11;
      button2.Text = "بازگشت";
      button2.UseVisualStyleBackColor = false;
      button2.Click += button2_Click;
      // 
      // button1
      // 
      button1.BackColor = Color.Lime;
      button1.FlatStyle = FlatStyle.Flat;
      button1.Font = new Font("Vazir", 12F, FontStyle.Bold, GraphicsUnit.Point);
      button1.ForeColor = SystemColors.ActiveCaptionText;
      button1.Location = new Point(240, 297);
      button1.Name = "button1";
      button1.Size = new Size(180, 48);
      button1.TabIndex = 10;
      button1.Text = "تایید";
      button1.UseVisualStyleBackColor = false;
      button1.Click += button1_Click;
      // 
      // txt_Amount
      // 
      txt_Amount.Location = new Point(12, 132);
      txt_Amount.Name = "txt_Amount";
      txt_Amount.Size = new Size(176, 27);
      txt_Amount.TabIndex = 9;
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Font = new Font("Vazir", 15F, FontStyle.Regular, GraphicsUnit.Point);
      label2.Location = new Point(350, 125);
      label2.Name = "label2";
      label2.RightToLeft = RightToLeft.Yes;
      label2.Size = new Size(70, 39);
      label2.TabIndex = 8;
      label2.Text = "مبلغ:";
      // 
      // txt_AccountId
      // 
      txt_AccountId.Location = new Point(12, 44);
      txt_AccountId.Name = "txt_AccountId";
      txt_AccountId.Size = new Size(176, 27);
      txt_AccountId.TabIndex = 7;
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Font = new Font("Vazir", 15F, FontStyle.Regular, GraphicsUnit.Point);
      label1.Location = new Point(253, 44);
      label1.Name = "label1";
      label1.RightToLeft = RightToLeft.Yes;
      label1.Size = new Size(167, 39);
      label1.TabIndex = 6;
      label1.Text = "شناسه حساب:";
      // 
      // Frm_Decrease
      // 
      AutoScaleDimensions = new SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(432, 388);
      Controls.Add(button2);
      Controls.Add(button1);
      Controls.Add(txt_Amount);
      Controls.Add(label2);
      Controls.Add(txt_AccountId);
      Controls.Add(label1);
      FormBorderStyle = FormBorderStyle.FixedDialog;
      Name = "Frm_Decrease";
      Text = "برداشت وجه";
      Load += Frm_Decrease_Load;
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Button button2;
        private Button button1;
        private TextBox txt_Amount;
        private Label label2;
        private TextBox txt_AccountId;
        private Label label1;
    }
}
