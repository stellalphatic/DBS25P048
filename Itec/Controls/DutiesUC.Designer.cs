namespace Itec.Controls
{
    partial class DutiesUC
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
            txtAssignedTo = new TextBox();
            label5 = new Label();
            dtpDeadline = new DateTimePicker();
            TaskDescriptiontxt = new RichTextBox();
            cmbStatus = new ComboBox();
            cmbCommittee = new ComboBox();
            label12 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            DutyId = new DataGridViewTextBoxColumn();
            CommitteeID = new DataGridViewTextBoxColumn();
            CommitteeName = new DataGridViewTextBoxColumn();
            AssignedTo = new DataGridViewTextBoxColumn();
            TaskDescription = new DataGridViewTextBoxColumn();
            Deadline = new DataGridViewTextBoxColumn();
            StatusId = new DataGridViewTextBoxColumn();
            StatusName = new DataGridViewTextBoxColumn();
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
            label2.Location = new Point(329, 9);
            label2.Name = "label2";
            label2.Size = new Size(283, 30);
            label2.TabIndex = 4;
            label2.Text = "Duty Assignment & Tracking";
            // 
            // MainPanel
            // 
            MainPanel.BackColor = SystemColors.ButtonFace;
            MainPanel.Controls.Add(txtAssignedTo);
            MainPanel.Controls.Add(label5);
            MainPanel.Controls.Add(dtpDeadline);
            MainPanel.Controls.Add(TaskDescriptiontxt);
            MainPanel.Controls.Add(cmbStatus);
            MainPanel.Controls.Add(cmbCommittee);
            MainPanel.Controls.Add(label12);
            MainPanel.Controls.Add(label4);
            MainPanel.Controls.Add(label3);
            MainPanel.Controls.Add(label1);
            MainPanel.Controls.Add(button3);
            MainPanel.Controls.Add(button2);
            MainPanel.Controls.Add(button1);
            MainPanel.Controls.Add(dataGridView1);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 49);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(982, 495);
            MainPanel.TabIndex = 11;
            // 
            // txtAssignedTo
            // 
            txtAssignedTo.Location = new Point(174, 102);
            txtAssignedTo.Name = "txtAssignedTo";
            txtAssignedTo.Size = new Size(158, 23);
            txtAssignedTo.TabIndex = 54;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.Cross;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(44, 101);
            label5.Name = "label5";
            label5.Size = new Size(92, 20);
            label5.TabIndex = 53;
            label5.Text = "Assigned to:";
            // 
            // dtpDeadline
            // 
            dtpDeadline.CustomFormat = "yyyy-MM-dd";
            dtpDeadline.Format = DateTimePickerFormat.Custom;
            dtpDeadline.Location = new Point(174, 152);
            dtpDeadline.Name = "dtpDeadline";
            dtpDeadline.Size = new Size(158, 23);
            dtpDeadline.TabIndex = 51;
            dtpDeadline.ValueChanged += dtpDeadline_ValueChanged;
            // 
            // TaskDescriptiontxt
            // 
            TaskDescriptiontxt.Location = new Point(174, 240);
            TaskDescriptiontxt.Name = "TaskDescriptiontxt";
            TaskDescriptiontxt.Size = new Size(158, 55);
            TaskDescriptiontxt.TabIndex = 50;
            TaskDescriptiontxt.Text = "";
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "1", "2", "3" });
            cmbStatus.Location = new Point(174, 196);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(158, 23);
            cmbStatus.TabIndex = 49;
            // 
            // cmbCommittee
            // 
            cmbCommittee.FormattingEnabled = true;
            cmbCommittee.Items.AddRange(new object[] { "1", "2", "3" });
            cmbCommittee.Location = new Point(174, 49);
            cmbCommittee.Name = "cmbCommittee";
            cmbCommittee.Size = new Size(158, 23);
            cmbCommittee.TabIndex = 48;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Cursor = Cursors.Cross;
            label12.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(44, 240);
            label12.Name = "label12";
            label12.Size = new Size(124, 20);
            label12.TabIndex = 47;
            label12.Text = "Task Description:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Cross;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(44, 199);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 46;
            label4.Text = "Status:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Cross;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(44, 154);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 45;
            label3.Text = "Deadline:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Cross;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(44, 49);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 44;
            label1.Text = "Committee:";
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Font = new Font("Sitka Small", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(290, 341);
            button3.Name = "button3";
            button3.Size = new Size(75, 31);
            button3.TabIndex = 8;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Font = new Font("Sitka Small", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(185, 362);
            button2.Name = "button2";
            button2.Size = new Size(75, 31);
            button2.TabIndex = 7;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Sitka Small", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(77, 326);
            button1.Name = "button1";
            button1.Size = new Size(75, 31);
            button1.TabIndex = 6;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { DutyId, CommitteeID, CommitteeName, AssignedTo, TaskDescription, Deadline, StatusId, StatusName });
            dataGridView1.Location = new Point(414, 18);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(543, 291);
            dataGridView1.TabIndex = 5;
            // 
            // DutyId
            // 
            DutyId.HeaderText = "DutyId";
            DutyId.Name = "DutyId";
            // 
            // CommitteeID
            // 
            CommitteeID.HeaderText = "CommitteeID";
            CommitteeID.Name = "CommitteeID";
            // 
            // CommitteeName
            // 
            CommitteeName.HeaderText = "CommitteeName";
            CommitteeName.Name = "CommitteeName";
            // 
            // AssignedTo
            // 
            AssignedTo.HeaderText = "Assigned_to";
            AssignedTo.Name = "AssignedTo";
            // 
            // TaskDescription
            // 
            TaskDescription.HeaderText = "Task_Description";
            TaskDescription.Name = "TaskDescription";
            // 
            // Deadline
            // 
            Deadline.HeaderText = "Deadline";
            Deadline.Name = "Deadline";
            // 
            // StatusId
            // 
            StatusId.HeaderText = "StatusId";
            StatusId.Name = "StatusId";
            // 
            // StatusName
            // 
            StatusName.HeaderText = "Status";
            StatusName.Name = "StatusName";
            // 
            // DutiesUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(MainPanel);
            Controls.Add(panel1);
            Name = "DutiesUC";
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
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private Label label12;
        private Label label4;
        private Label label3;
        private Label label1;
        private ComboBox cmbStatus;
        private ComboBox cmbCommittee;
        private RichTextBox TaskDescriptiontxt;
        private DateTimePicker dtpDeadline;
        private Label label5;
        private TextBox txtAssignedTo;
        private DataGridViewTextBoxColumn DutyId;
        private DataGridViewTextBoxColumn CommitteeID;
        private DataGridViewTextBoxColumn CommitteeName;
        private DataGridViewTextBoxColumn AssignedTo;
        private DataGridViewTextBoxColumn TaskDescription;
        private DataGridViewTextBoxColumn Deadline;
        private DataGridViewTextBoxColumn StatusId;
        private DataGridViewTextBoxColumn StatusName;
    }
}
