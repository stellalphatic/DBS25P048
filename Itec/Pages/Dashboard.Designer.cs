namespace Itec
{
    partial class Dashboard
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
            label1 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            sidePanel = new Panel();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            reportBtn = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            EditionsBtn = new FontAwesome.Sharp.IconButton();
            venuesBtn = new FontAwesome.Sharp.IconButton();
            ParticipantsBtn = new FontAwesome.Sharp.IconButton();
            EventBtn = new FontAwesome.Sharp.IconButton();
            commiteesBtn = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            sidePanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(iconButton1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(866, 49);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gill Sans Ultra Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(407, 6);
            label1.Name = "label1";
            label1.Size = new Size(89, 39);
            label1.TabIndex = 2;
            label1.Text = "ITEC";
            label1.Click += label1_Click;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = SystemColors.ButtonFace;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.AlignJustify;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(3, 6);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(49, 37);
            iconButton1.TabIndex = 2;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // sidePanel
            // 
            sidePanel.BackColor = SystemColors.ActiveCaptionText;
            sidePanel.Controls.Add(iconButton4);
            sidePanel.Controls.Add(reportBtn);
            sidePanel.Controls.Add(iconButton3);
            sidePanel.Controls.Add(EditionsBtn);
            sidePanel.Controls.Add(venuesBtn);
            sidePanel.Controls.Add(ParticipantsBtn);
            sidePanel.Controls.Add(EventBtn);
            sidePanel.Controls.Add(commiteesBtn);
            sidePanel.Controls.Add(iconButton2);
            sidePanel.Dock = DockStyle.Left;
            sidePanel.ForeColor = SystemColors.ButtonHighlight;
            sidePanel.Location = new Point(0, 49);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(161, 542);
            sidePanel.TabIndex = 1;
            // 
            // iconButton4
            // 
            iconButton4.BackColor = SystemColors.Desktop;
            iconButton4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.CediSign;
            iconButton4.IconColor = Color.White;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.IconSize = 30;
            iconButton4.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton4.Location = new Point(12, 497);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(112, 33);
            iconButton4.TabIndex = 8;
            iconButton4.Text = "Logout";
            iconButton4.UseVisualStyleBackColor = false;
            // 
            // reportBtn
            // 
            reportBtn.BackColor = SystemColors.Desktop;
            reportBtn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            reportBtn.FlatAppearance.BorderSize = 0;
            reportBtn.FlatAppearance.MouseOverBackColor = SystemColors.ControlDarkDark;
            reportBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reportBtn.IconChar = FontAwesome.Sharp.IconChar.FileText;
            reportBtn.IconColor = Color.White;
            reportBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            reportBtn.IconSize = 30;
            reportBtn.ImageAlign = ContentAlignment.MiddleLeft;
            reportBtn.Location = new Point(12, 358);
            reportBtn.Name = "reportBtn";
            reportBtn.Size = new Size(130, 33);
            reportBtn.TabIndex = 7;
            reportBtn.Text = "Report";
            reportBtn.UseVisualStyleBackColor = false;
            // 
            // iconButton3
            // 
            iconButton3.BackColor = SystemColors.Desktop;
            iconButton3.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            iconButton3.FlatAppearance.BorderSize = 0;
            iconButton3.FlatAppearance.MouseOverBackColor = SystemColors.ControlDarkDark;
            iconButton3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.Donate;
            iconButton3.IconColor = Color.White;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 30;
            iconButton3.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton3.Location = new Point(12, 309);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(130, 33);
            iconButton3.TabIndex = 6;
            iconButton3.Text = "Finances";
            iconButton3.UseVisualStyleBackColor = false;
            // 
            // EditionsBtn
            // 
            EditionsBtn.BackColor = SystemColors.Desktop;
            EditionsBtn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            EditionsBtn.FlatAppearance.BorderSize = 0;
            EditionsBtn.FlatAppearance.MouseOverBackColor = SystemColors.ControlDarkDark;
            EditionsBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EditionsBtn.IconChar = FontAwesome.Sharp.IconChar.Mizuni;
            EditionsBtn.IconColor = Color.White;
            EditionsBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            EditionsBtn.IconSize = 30;
            EditionsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            EditionsBtn.Location = new Point(12, 260);
            EditionsBtn.Name = "EditionsBtn";
            EditionsBtn.Size = new Size(130, 33);
            EditionsBtn.TabIndex = 5;
            EditionsBtn.Text = "Editions";
            EditionsBtn.UseVisualStyleBackColor = false;
            // 
            // venuesBtn
            // 
            venuesBtn.BackColor = SystemColors.Desktop;
            venuesBtn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            venuesBtn.FlatAppearance.BorderSize = 0;
            venuesBtn.FlatAppearance.MouseOverBackColor = SystemColors.ControlDarkDark;
            venuesBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            venuesBtn.IconChar = FontAwesome.Sharp.IconChar.Building;
            venuesBtn.IconColor = Color.White;
            venuesBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            venuesBtn.IconSize = 30;
            venuesBtn.ImageAlign = ContentAlignment.MiddleLeft;
            venuesBtn.Location = new Point(12, 212);
            venuesBtn.Name = "venuesBtn";
            venuesBtn.Size = new Size(130, 33);
            venuesBtn.TabIndex = 4;
            venuesBtn.Text = "Venues";
            venuesBtn.UseVisualStyleBackColor = false;
            // 
            // ParticipantsBtn
            // 
            ParticipantsBtn.BackColor = SystemColors.Desktop;
            ParticipantsBtn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            ParticipantsBtn.FlatAppearance.BorderSize = 0;
            ParticipantsBtn.FlatAppearance.MouseOverBackColor = SystemColors.ControlDarkDark;
            ParticipantsBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ParticipantsBtn.IconChar = FontAwesome.Sharp.IconChar.Users;
            ParticipantsBtn.IconColor = Color.White;
            ParticipantsBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ParticipantsBtn.IconSize = 32;
            ParticipantsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            ParticipantsBtn.Location = new Point(12, 113);
            ParticipantsBtn.Name = "ParticipantsBtn";
            ParticipantsBtn.Size = new Size(130, 33);
            ParticipantsBtn.TabIndex = 3;
            ParticipantsBtn.Text = "Participants";
            ParticipantsBtn.TextAlign = ContentAlignment.MiddleRight;
            ParticipantsBtn.UseVisualStyleBackColor = false;
            // 
            // EventBtn
            // 
            EventBtn.BackColor = SystemColors.Desktop;
            EventBtn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            EventBtn.FlatAppearance.BorderSize = 0;
            EventBtn.FlatAppearance.MouseOverBackColor = SystemColors.ControlDarkDark;
            EventBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EventBtn.IconChar = FontAwesome.Sharp.IconChar.DiceD20;
            EventBtn.IconColor = Color.White;
            EventBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            EventBtn.IconSize = 30;
            EventBtn.ImageAlign = ContentAlignment.MiddleLeft;
            EventBtn.Location = new Point(12, 64);
            EventBtn.Name = "EventBtn";
            EventBtn.Size = new Size(130, 33);
            EventBtn.TabIndex = 2;
            EventBtn.Text = "Events";
            EventBtn.UseVisualStyleBackColor = false;
            // 
            // commiteesBtn
            // 
            commiteesBtn.BackColor = SystemColors.Desktop;
            commiteesBtn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            commiteesBtn.FlatAppearance.BorderSize = 0;
            commiteesBtn.FlatAppearance.MouseOverBackColor = SystemColors.ControlDarkDark;
            commiteesBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            commiteesBtn.IconChar = FontAwesome.Sharp.IconChar.Connectdevelop;
            commiteesBtn.IconColor = Color.White;
            commiteesBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            commiteesBtn.IconSize = 35;
            commiteesBtn.ImageAlign = ContentAlignment.MiddleLeft;
            commiteesBtn.Location = new Point(12, 164);
            commiteesBtn.Name = "commiteesBtn";
            commiteesBtn.Size = new Size(130, 33);
            commiteesBtn.TabIndex = 1;
            commiteesBtn.Text = "Commitees";
            commiteesBtn.TextAlign = ContentAlignment.MiddleRight;
            commiteesBtn.UseVisualStyleBackColor = false;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = SystemColors.ActiveCaptionText;
            iconButton2.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            iconButton2.FlatAppearance.MouseOverBackColor = SystemColors.ControlDarkDark;
            iconButton2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Modx;
            iconButton2.IconColor = Color.White;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 30;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(12, 16);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(130, 33);
            iconButton2.TabIndex = 0;
            iconButton2.Text = "Dashboard";
            iconButton2.TextAlign = ContentAlignment.MiddleRight;
            iconButton2.UseVisualStyleBackColor = false;
            iconButton2.Click += iconButton2_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(866, 591);
            Controls.Add(sidePanel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Dashboard";
            Text = "Dashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            sidePanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Panel sidePanel;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton EditionsBtn;
        private FontAwesome.Sharp.IconButton venuesBtn;
        private FontAwesome.Sharp.IconButton ParticipantsBtn;
        private FontAwesome.Sharp.IconButton EventBtn;
        private FontAwesome.Sharp.IconButton commiteesBtn;
        private FontAwesome.Sharp.IconButton reportBtn;
        private FontAwesome.Sharp.IconButton iconButton3;
        private Label label1;
        private FontAwesome.Sharp.IconButton iconButton4;
        private UIclasses.RoundedPanel roundedPanel1;
    }
}