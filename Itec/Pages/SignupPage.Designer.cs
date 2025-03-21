namespace Itec
{
    partial class SignupPage
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
            panel1 = new Panel();
            SignupBtn = new Button();
            ConfirmPassword = new MaskedTextBox();
            Passwordtxt = new MaskedTextBox();
            Emailtxt = new MaskedTextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            Usernametxt = new MaskedTextBox();
            label1 = new Label();
            panel2 = new Panel();
            label5 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.mysticpurple;
            panel1.Controls.Add(SignupBtn);
            panel1.Controls.Add(ConfirmPassword);
            panel1.Controls.Add(Passwordtxt);
            panel1.Controls.Add(Emailtxt);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(Usernametxt);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(214, 88);
            panel1.Name = "panel1";
            panel1.Size = new Size(369, 294);
            panel1.TabIndex = 0;
            // 
            // SignupBtn
            // 
            SignupBtn.BackColor = SystemColors.MenuHighlight;
            SignupBtn.BackgroundImage = Properties.Resources.mysticpurple;
            SignupBtn.BackgroundImageLayout = ImageLayout.Stretch;
            SignupBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignupBtn.ForeColor = SystemColors.ButtonHighlight;
            SignupBtn.Location = new Point(125, 229);
            SignupBtn.Name = "SignupBtn";
            SignupBtn.Size = new Size(99, 39);
            SignupBtn.TabIndex = 8;
            SignupBtn.Text = "Signup";
            SignupBtn.UseVisualStyleBackColor = false;
            SignupBtn.Click += SignupBtn_Click;
            // 
            // ConfirmPassword
            // 
            ConfirmPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ConfirmPassword.Location = new Point(145, 168);
            ConfirmPassword.Name = "ConfirmPassword";
            ConfirmPassword.Size = new Size(144, 27);
            ConfirmPassword.TabIndex = 7;
            // 
            // Passwordtxt
            // 
            Passwordtxt.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Passwordtxt.Location = new Point(145, 120);
            Passwordtxt.Name = "Passwordtxt";
            Passwordtxt.Size = new Size(144, 27);
            Passwordtxt.TabIndex = 6;
            // 
            // Emailtxt
            // 
            Emailtxt.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Emailtxt.Location = new Point(145, 73);
            Emailtxt.Name = "Emailtxt";
            Emailtxt.Size = new Size(144, 27);
            Emailtxt.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(11, 168);
            label4.Name = "label4";
            label4.Size = new Size(128, 25);
            label4.TabIndex = 4;
            label4.Text = "Confirm Pass:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(11, 119);
            label3.Name = "label3";
            label3.Size = new Size(96, 25);
            label3.TabIndex = 3;
            label3.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(16, 72);
            label2.Name = "label2";
            label2.Size = new Size(64, 25);
            label2.TabIndex = 2;
            label2.Text = "Email:";
            // 
            // Usernametxt
            // 
            Usernametxt.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Usernametxt.Location = new Point(145, 27);
            Usernametxt.Name = "Usernametxt";
            Usernametxt.Size = new Size(144, 27);
            Usernametxt.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(16, 27);
            label1.Name = "label1";
            label1.Size = new Size(103, 25);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Navy;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(label5);
            panel2.Location = new Point(214, 20);
            panel2.Name = "panel2";
            panel2.Size = new Size(369, 62);
            panel2.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.DarkBlue;
            label5.Font = new Font("Gill Sans Ultra Bold", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(115, 11);
            label5.Name = "label5";
            label5.Size = new Size(122, 51);
            label5.TabIndex = 0;
            label5.Text = "ITEC";
            // 
            // SignupPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.purple2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(809, 463);
            Controls.Add(panel2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "SignupPage";
            Text = "Signup";
            Load += SignupPage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private MaskedTextBox ConfirmPassword;
        private MaskedTextBox Passwordtxt;
        private Label label4;
        private Label label3;
        private MaskedTextBox Usernametxt;
        private Label label1;
        private Button SignupBtn;
        private MaskedTextBox Emailtxt;
        private Label label2;
        private Panel panel2;
        private Label label5;
    }
}