namespace AccountingApp.Forms
{
    partial class Frm_CreateAccount
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
            txt_Balance = new TextBox();
            txt_PersonName = new TextBox();
            label1 = new Label();
            label2 = new Label();
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
            button2.TabIndex = 10;
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
            button1.TabIndex = 9;
            button1.Text = "تایید";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txt_Balance
            // 
            txt_Balance.Location = new Point(12, 132);
            txt_Balance.Name = "txt_Balance";
            txt_Balance.Size = new Size(176, 27);
            txt_Balance.TabIndex = 8;
            // 
            // txt_PersonName
            // 
            txt_PersonName.Location = new Point(12, 44);
            txt_PersonName.Name = "txt_PersonName";
            txt_PersonName.Size = new Size(176, 27);
            txt_PersonName.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Vazir", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(212, 44);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(208, 39);
            label1.TabIndex = 6;
            label1.Text = "نام و نام خانوادگی:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Vazir", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(277, 125);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(143, 39);
            label2.TabIndex = 11;
            label2.Text = "مبلغ واریزی:";
            // 
            // Frm_CreateAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 388);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txt_Balance);
            Controls.Add(txt_PersonName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Frm_CreateAccount";
            ShowIcon = false;
            Text = "ایجاد حساب ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private TextBox txt_Balance;
        private TextBox txt_PersonName;
        private Label label1;
        private Label label2;
    }
}