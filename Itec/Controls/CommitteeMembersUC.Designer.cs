namespace Itec.Controls
{
    partial class CommitteeMembersUC
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
            CommitteeBtn = new Button();
            CommitteMembersBtn = new Button();
            label2 = new Label();
            MainPanel = new Panel();
            label3 = new Label();
            cmbRole = new ComboBox();
            cmbCommittee = new ComboBox();
            label1 = new Label();
            Nametxt = new TextBox();
            label5 = new Label();
            UpdateBtn = new Button();
            DeleteBtn = new Button();
            AddBtn = new Button();
            dataGridView1 = new DataGridView();
            MemberId = new DataGridViewTextBoxColumn();
            CommitteeName = new DataGridViewTextBoxColumn();
            MemberName = new DataGridViewTextBoxColumn();
            RoleName = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(CommitteeBtn);
            panel1.Controls.Add(CommitteMembersBtn);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 49);
            panel1.TabIndex = 7;
            // 
            // CommitteeBtn
            // 
            CommitteeBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CommitteeBtn.Location = new Point(759, 13);
            CommitteeBtn.Name = "CommitteeBtn";
            CommitteeBtn.Size = new Size(166, 30);
            CommitteeBtn.TabIndex = 31;
            CommitteeBtn.Text = "Committees";
            CommitteeBtn.UseVisualStyleBackColor = true;
            CommitteeBtn.Click += CommitteeBtn_Click;
            // 
            // CommitteMembersBtn
            // 
            CommitteMembersBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CommitteMembersBtn.Location = new Point(510, 13);
            CommitteMembersBtn.Name = "CommitteMembersBtn";
            CommitteMembersBtn.Size = new Size(182, 30);
            CommitteMembersBtn.TabIndex = 30;
            CommitteMembersBtn.Text = "Committee Members";
            CommitteMembersBtn.UseVisualStyleBackColor = true;
            CommitteMembersBtn.Click += CommitteMembersBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gill Sans MT", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(69, 16);
            label2.Name = "label2";
            label2.Size = new Size(320, 30);
            label2.TabIndex = 3;
            label2.Text = "Committee & Role Management";
            // 
            // MainPanel
            // 
            MainPanel.BackColor = SystemColors.ButtonFace;
            MainPanel.Controls.Add(label3);
            MainPanel.Controls.Add(cmbRole);
            MainPanel.Controls.Add(cmbCommittee);
            MainPanel.Controls.Add(label1);
            MainPanel.Controls.Add(Nametxt);
            MainPanel.Controls.Add(label5);
            MainPanel.Controls.Add(UpdateBtn);
            MainPanel.Controls.Add(DeleteBtn);
            MainPanel.Controls.Add(AddBtn);
            MainPanel.Controls.Add(dataGridView1);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 49);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(982, 505);
            MainPanel.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Cross;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(44, 113);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 59;
            label3.Text = "Committee:";
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "1", "2", "3" });
            cmbRole.Location = new Point(163, 166);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(125, 23);
            cmbRole.TabIndex = 58;
            // 
            // cmbCommittee
            // 
            cmbCommittee.FormattingEnabled = true;
            cmbCommittee.Items.AddRange(new object[] { "1", "2", "3" });
            cmbCommittee.Location = new Point(163, 111);
            cmbCommittee.Name = "cmbCommittee";
            cmbCommittee.Size = new Size(125, 23);
            cmbCommittee.TabIndex = 57;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Cross;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(44, 165);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 56;
            label1.Text = "Role:";
            // 
            // Nametxt
            // 
            Nametxt.Location = new Point(163, 63);
            Nametxt.Name = "Nametxt";
            Nametxt.Size = new Size(158, 23);
            Nametxt.TabIndex = 54;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.Cross;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(44, 62);
            label5.Name = "label5";
            label5.Size = new Size(116, 20);
            label5.TabIndex = 53;
            label5.Text = "Member Name:";
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = SystemColors.ActiveCaption;
            UpdateBtn.Font = new Font("Sitka Small", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UpdateBtn.Location = new Point(246, 242);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(75, 31);
            UpdateBtn.TabIndex = 8;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = SystemColors.ActiveCaption;
            DeleteBtn.Font = new Font("Sitka Small", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeleteBtn.Location = new Point(141, 292);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(75, 31);
            DeleteBtn.TabIndex = 7;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = SystemColors.ActiveCaption;
            AddBtn.Font = new Font("Sitka Small", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddBtn.Location = new Point(33, 242);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(75, 31);
            AddBtn.TabIndex = 6;
            AddBtn.Text = "Insert";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MemberId, CommitteeName, MemberName, RoleName });
            dataGridView1.Location = new Point(430, 32);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(524, 291);
            dataGridView1.TabIndex = 5;
       
            // 
            // MemberId
            // 
            MemberId.HeaderText = "MemberId";
            MemberId.Name = "MemberId";
            // 
            // CommitteeName
            // 
            CommitteeName.HeaderText = "Committee";
            CommitteeName.Name = "CommitteeName";
            CommitteeName.Width = 150;
            // 
            // MemberName
            // 
            MemberName.HeaderText = "Name";
            MemberName.Name = "MemberName";
            MemberName.Width = 150;
            // 
            // RoleName
            // 
            RoleName.HeaderText = "Role";
            RoleName.Name = "RoleName";
            RoleName.Width = 170;
            // 
            // CommitteeMembersUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(MainPanel);
            Controls.Add(panel1);
            Name = "CommitteeMembersUC";
            Size = new Size(982, 554);
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
        private Label label1;
        private TextBox Nametxt;
        private Label label5;
        private Button UpdateBtn;
        private Button DeleteBtn;
        private Button AddBtn;
        private DataGridView dataGridView1;
        private Button CommitteeBtn;
        private Button CommitteMembersBtn;
        private ComboBox cmbCommittee;
        private Label label3;
        private ComboBox cmbRole;
        private DataGridViewTextBoxColumn MemberId;
        private DataGridViewTextBoxColumn CommitteeName;
        private DataGridViewTextBoxColumn MemberName;
        private DataGridViewTextBoxColumn RoleName;
    }
}
