namespace Itec.Controls
{
    partial class ParticipantsUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label2 = new Label();
            MainPanel = new Panel();
            cmbItec = new ComboBox();
            cmbRole = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            Institutetxt = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            Contacttxt = new TextBox();
            Emailtxt = new TextBox();
            Nametxt = new TextBox();
            UpdateBtn = new Button();
            DeleteBtn = new Button();
            AddBtn = new Button();
            dataGridView1 = new DataGridView();
            ParticipantId = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            ItecId = new DataGridViewTextBoxColumn();
            ItecYear = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Contact = new DataGridViewTextBoxColumn();
            Institute = new DataGridViewTextBoxColumn();
            RoleId = new DataGridViewTextBoxColumn();
            RoleName = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 49);
            panel1.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gill Sans MT", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(359, 9);
            label2.Name = "label2";
            label2.Size = new Size(249, 30);
            label2.TabIndex = 8;
            label2.Text = "Participant Registration";
            // 
            // MainPanel
            // 
            MainPanel.BackColor = SystemColors.ButtonFace;
            MainPanel.Controls.Add(cmbItec);
            MainPanel.Controls.Add(cmbRole);
            MainPanel.Controls.Add(label8);
            MainPanel.Controls.Add(label9);
            MainPanel.Controls.Add(Institutetxt);
            MainPanel.Controls.Add(label7);
            MainPanel.Controls.Add(label6);
            MainPanel.Controls.Add(label5);
            MainPanel.Controls.Add(label4);
            MainPanel.Controls.Add(Contacttxt);
            MainPanel.Controls.Add(Emailtxt);
            MainPanel.Controls.Add(Nametxt);
            MainPanel.Controls.Add(UpdateBtn);
            MainPanel.Controls.Add(DeleteBtn);
            MainPanel.Controls.Add(AddBtn);
            MainPanel.Controls.Add(dataGridView1);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 49);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(982, 495);
            MainPanel.TabIndex = 11;
            // 
            // cmbItec
            // 
            cmbItec.FormattingEnabled = true;
            cmbItec.Items.AddRange(new object[] { "1", "2", "3" });
            cmbItec.Location = new Point(98, 7);
            cmbItec.Name = "cmbItec";
            cmbItec.Size = new Size(114, 23);
            cmbItec.TabIndex = 32;
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "1", "2", "3" });
            cmbRole.Location = new Point(96, 210);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(114, 23);
            cmbRole.TabIndex = 31;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Cursor = Cursors.Cross;
            label8.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(22, 213);
            label8.Name = "label8";
            label8.Size = new Size(43, 20);
            label8.TabIndex = 30;
            label8.Text = "Role:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Cursor = Cursors.Cross;
            label9.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(22, 168);
            label9.Name = "label9";
            label9.Size = new Size(68, 20);
            label9.TabIndex = 29;
            label9.Text = "Institute:";
            // 
            // Institutetxt
            // 
            Institutetxt.Location = new Point(96, 165);
            Institutetxt.Name = "Institutetxt";
            Institutetxt.Size = new Size(114, 23);
            Institutetxt.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Cursor = Cursors.Cross;
            label7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(20, 126);
            label7.Name = "label7";
            label7.Size = new Size(65, 20);
            label7.TabIndex = 26;
            label7.Text = "Contact:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Cross;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(22, 93);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 25;
            label6.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.Cross;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(20, 50);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 24;
            label5.Text = "Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Cross;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(20, 10);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 23;
            label4.Text = "Itec:";
            // 
            // Contacttxt
            // 
            Contacttxt.Location = new Point(98, 126);
            Contacttxt.Name = "Contacttxt";
            Contacttxt.Size = new Size(114, 23);
            Contacttxt.TabIndex = 21;
            // 
            // Emailtxt
            // 
            Emailtxt.Location = new Point(98, 90);
            Emailtxt.Name = "Emailtxt";
            Emailtxt.Size = new Size(114, 23);
            Emailtxt.TabIndex = 20;
            // 
            // Nametxt
            // 
            Nametxt.Location = new Point(98, 47);
            Nametxt.Name = "Nametxt";
            Nametxt.Size = new Size(114, 23);
            Nametxt.TabIndex = 19;
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = SystemColors.ActiveCaption;
            UpdateBtn.Font = new Font("Sitka Small", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UpdateBtn.Location = new Point(491, 335);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(75, 31);
            UpdateBtn.TabIndex = 15;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = SystemColors.ActiveCaption;
            DeleteBtn.Font = new Font("Sitka Small", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeleteBtn.Location = new Point(616, 335);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(75, 31);
            DeleteBtn.TabIndex = 14;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = SystemColors.ActiveCaption;
            AddBtn.Font = new Font("Sitka Small", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddBtn.Location = new Point(322, 335);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(75, 31);
            AddBtn.TabIndex = 13;
            AddBtn.Text = "Insert";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ParticipantId, Name, ItecId, ItecYear, Email, Contact, Institute, RoleId, RoleName });
            dataGridView1.Location = new Point(272, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(707, 291);
            dataGridView1.TabIndex = 12;
            // 
            // ParticipantId
            // 
            ParticipantId.HeaderText = "Participant_ID";
            ParticipantId.MaxInputLength = 3211;
            ParticipantId.Name = "ParticipantId";
            ParticipantId.Width = 85;
            // 
            // Name
            // 
            Name.HeaderText = "Name";
            Name.Name = "Name";
            // 
            // ItecId
            // 
            ItecId.HeaderText = "Itec_ID";
            ItecId.Name = "ItecId";
            ItecId.Width = 50;
            // 
            // ItecYear
            // 
            ItecYear.HeaderText = "ItecYear";
            ItecYear.Name = "ItecYear";
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.Name = "Email";
            // 
            // Contact
            // 
            Contact.HeaderText = "Contact";
            Contact.Name = "Contact";
            // 
            // Institute
            // 
            Institute.HeaderText = "Institute";
            Institute.Name = "Institute";
            // 
            // RoleId
            // 
            RoleId.HeaderText = "Role_ID";
            RoleId.Name = "RoleId";
            RoleId.Width = 50;
            // 
            // RoleName
            // 
            RoleName.HeaderText = "Role";
            RoleName.Name = "RoleName";
            // 
            // ParticipantsUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(MainPanel);
            Controls.Add(panel1);
            Size = new Size(982, 544);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Panel MainPanel;
        private Label label8;
        private Label label9;
        private TextBox Institutetxt;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox Contacttxt;
        private TextBox Emailtxt;
        private TextBox Nametxt;
        private TextBox ItecIDtxt;
        private TextBox ParticipantIDtxt;
        private Button SearchBtn;
        private Button UpdateBtn;
        private Button DeleteBtn;
        private Button AddBtn;
        private DataGridView dataGridView1;
        private ComboBox cmbRole;
        private ComboBox cmbItec;
        private DataGridViewTextBoxColumn ParticipantId;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn ItecId;
        private DataGridViewTextBoxColumn ItecYear;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Contact;
        private DataGridViewTextBoxColumn Institute;
        private DataGridViewTextBoxColumn RoleId;
        private DataGridViewTextBoxColumn RoleName;
    }
}
