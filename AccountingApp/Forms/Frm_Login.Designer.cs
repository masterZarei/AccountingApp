namespace AccountingApp.Forms
{
    partial class Frm_Login
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
            txt_Password = new TextBox();
            label2 = new Label();
            txt_Username = new TextBox();
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
            // txt_Password
            // 
            txt_Password.Location = new Point(12, 132);
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new Size(176, 27);
            txt_Password.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Vazir", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(313, 125);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(107, 39);
            label2.TabIndex = 8;
            label2.Text = "رمز عبور:";
            // 
            // txt_Username
            // 
            txt_Username.Location = new Point(12, 44);
            txt_Username.Name = "txt_Username";
            txt_Username.Size = new Size(176, 27);
            txt_Username.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Vazir", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(291, 37);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(129, 39);
            label1.TabIndex = 6;
            label1.Text = "نام کاربری:";
            // 
            // Frm_Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 388);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txt_Password);
            Controls.Add(label2);
            Controls.Add(txt_Username);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Frm_Login";
            Text = "ورود";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private TextBox txt_Password;
        private Label label2;
        private TextBox txt_Username;
        private Label label1;
    }
}