namespace Itec
{
    partial class LoginPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            SignupBtn = new Button();
            label3 = new Label();
            label4 = new Label();
            lblToast = new Label();
            label5 = new Label();
            LoginUsername = new MaskedTextBox();
            label7 = new Label();
            LoginPassword = new MaskedTextBox();
            LoginBtn = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaptionText;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(270, 467);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Impact", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(57, 91);
            label1.Name = "label1";
            label1.Size = new Size(142, 36);
            label1.TabIndex = 4;
            label1.Text = "New Here?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(33, 162);
            label2.MaximumSize = new Size(200, 50);
            label2.Name = "label2";
            label2.Size = new Size(196, 46);
            label2.TabIndex = 5;
            label2.Text = "Signup below to use the Application";
            // 
            // SignupBtn
            // 
            SignupBtn.AutoEllipsis = true;
            SignupBtn.BackColor = SystemColors.ActiveCaptionText;
            SignupBtn.Cursor = Cursors.Hand;
            SignupBtn.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SignupBtn.Location = new Point(70, 236);
            SignupBtn.Name = "SignupBtn";
            SignupBtn.Size = new Size(97, 33);
            SignupBtn.TabIndex = 6;
            SignupBtn.Text = "Signup";
            SignupBtn.UseVisualStyleBackColor = false;
            SignupBtn.Click += SignupBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.Font = new Font("Gill Sans Ultra Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(514, 19);
            label3.Name = "label3";
            label3.Size = new Size(159, 69);
            label3.TabIndex = 7;
            label3.Text = "ITEC";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(450, 91);
            label4.Name = "label4";
            label4.Size = new Size(268, 22);
            label4.TabIndex = 8;
            label4.Text = "Event  Management  System";
            // 
            // lblToast
            // 
            lblToast.BackColor = SystemColors.ActiveCaptionText;
            lblToast.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblToast.Location = new Point(501, 127);
            lblToast.Name = "lblToast";
            lblToast.Size = new Size(100, 23);
            lblToast.TabIndex = 11;
            lblToast.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaptionText;
            label5.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(13, 47);
            label5.Name = "label5";
            label5.Size = new Size(104, 26);
            label5.TabIndex = 9;
            label5.Text = "Username:";
            label5.Click += label5_Click;
            // 
            // LoginUsername
            // 
            LoginUsername.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginUsername.Location = new Point(155, 50);
            LoginUsername.Name = "LoginUsername";
            LoginUsername.Size = new Size(147, 27);
            LoginUsername.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ActiveCaptionText;
            label7.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(13, 103);
            label7.Name = "label7";
            label7.Size = new Size(101, 26);
            label7.TabIndex = 12;
            label7.Text = "Password:";
            // 
            // LoginPassword
            // 
            LoginPassword.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginPassword.Location = new Point(155, 106);
            LoginPassword.Name = "LoginPassword";
            LoginPassword.Size = new Size(147, 27);
            LoginPassword.TabIndex = 14;
            LoginPassword.UseSystemPasswordChar = true;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.Purple;
            LoginBtn.Cursor = Cursors.Hand;
            LoginBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            LoginBtn.IconColor = Color.Black;
            LoginBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            LoginBtn.Location = new Point(155, 165);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(94, 40);
            LoginBtn.TabIndex = 15;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // iconButton1
            // 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Eye;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 30;
            iconButton1.Location = new Point(309, 107);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(27, 27);
            iconButton1.TabIndex = 16;
            iconButton1.Text = "iconButton1";
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.mysticpurple;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(iconButton1);
            panel1.Controls.Add(LoginBtn);
            panel1.Controls.Add(LoginPassword);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(LoginUsername);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(382, 153);
            panel1.Name = "panel1";
            panel1.Size = new Size(362, 266);
            panel1.TabIndex = 10;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(839, 467);
            Controls.Add(lblToast);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(SignupBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            ForeColor = SystemColors.ButtonFace;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "LoginPage";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button SignupBtn;
        private Label label3;
        private Label label4;
        private Label lblToast;
        private Label label5;
        private MaskedTextBox LoginUsername;
        private Label label7;
        private MaskedTextBox LoginPassword;
        private FontAwesome.Sharp.IconButton LoginBtn;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Panel panel1;
    }
}
