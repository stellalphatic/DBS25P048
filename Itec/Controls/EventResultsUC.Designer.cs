namespace Itec.Controls
{
    partial class EventResultsUC
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
            MainPanel = new Panel();
            cmbEvent = new ComboBox();
            cmbParticipant = new ComboBox();
            numScore = new NumericUpDown();
            label1 = new Label();
            numPosition = new NumericUpDown();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label3 = new Label();
            label5 = new Label();
            Remarkstxt = new RichTextBox();
            cmbTeam = new ComboBox();
            UpdateBtn = new Button();
            DeleteBtn = new Button();
            AddBtn = new Button();
            dataGridView1 = new DataGridView();
            ResultId = new DataGridViewTextBoxColumn();
            EventName = new DataGridViewTextBoxColumn();
            ParticipantName = new DataGridViewTextBoxColumn();
            TeamName = new DataGridViewTextBoxColumn();
            Position = new DataGridViewTextBoxColumn();
            Score = new DataGridViewTextBoxColumn();
            Remarks = new DataGridViewTextBoxColumn();
            MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numScore).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPosition).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.BackColor = SystemColors.ButtonFace;
            MainPanel.Controls.Add(cmbEvent);
            MainPanel.Controls.Add(cmbParticipant);
            MainPanel.Controls.Add(numScore);
            MainPanel.Controls.Add(label1);
            MainPanel.Controls.Add(numPosition);
            MainPanel.Controls.Add(label8);
            MainPanel.Controls.Add(label7);
            MainPanel.Controls.Add(label6);
            MainPanel.Controls.Add(label3);
            MainPanel.Controls.Add(label5);
            MainPanel.Controls.Add(Remarkstxt);
            MainPanel.Controls.Add(cmbTeam);
            MainPanel.Controls.Add(UpdateBtn);
            MainPanel.Controls.Add(DeleteBtn);
            MainPanel.Controls.Add(AddBtn);
            MainPanel.Controls.Add(dataGridView1);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(982, 495);
            MainPanel.TabIndex = 13;
            // 
            // cmbEvent
            // 
            cmbEvent.FormattingEnabled = true;
            cmbEvent.Items.AddRange(new object[] { "1", "2", "3" });
            cmbEvent.Location = new Point(161, 37);
            cmbEvent.Name = "cmbEvent";
            cmbEvent.Size = new Size(114, 23);
            cmbEvent.TabIndex = 55;
            // 
            // cmbParticipant
            // 
            cmbParticipant.FormattingEnabled = true;
            cmbParticipant.Items.AddRange(new object[] { "1", "2", "3" });
            cmbParticipant.Location = new Point(161, 90);
            cmbParticipant.Name = "cmbParticipant";
            cmbParticipant.Size = new Size(114, 23);
            cmbParticipant.TabIndex = 54;
            // 
            // numScore
            // 
            numScore.Location = new Point(163, 200);
            numScore.Name = "numScore";
            numScore.Size = new Size(120, 23);
            numScore.TabIndex = 53;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Cross;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 200);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 52;
            label1.Text = "Score:";
            // 
            // numPosition
            // 
            numPosition.Location = new Point(161, 163);
            numPosition.Name = "numPosition";
            numPosition.Size = new Size(120, 23);
            numPosition.TabIndex = 51;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Cursor = Cursors.Cross;
            label8.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(39, 90);
            label8.Name = "label8";
            label8.Size = new Size(87, 20);
            label8.TabIndex = 50;
            label8.Text = "Participant:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Cursor = Cursors.Cross;
            label7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(39, 166);
            label7.Name = "label7";
            label7.Size = new Size(68, 20);
            label7.TabIndex = 48;
            label7.Text = "position:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Cross;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(35, 238);
            label6.Name = "label6";
            label6.Size = new Size(71, 20);
            label6.TabIndex = 46;
            label6.Text = "Remarks:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Cross;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(39, 130);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 44;
            label3.Text = "Team:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.Cross;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(39, 40);
            label5.Name = "label5";
            label5.Size = new Size(96, 20);
            label5.TabIndex = 42;
            label5.Text = "Event Name:";
            // 
            // Remarkstxt
            // 
            Remarkstxt.Location = new Point(161, 238);
            Remarkstxt.Name = "Remarkstxt";
            Remarkstxt.Size = new Size(158, 55);
            Remarkstxt.TabIndex = 41;
            Remarkstxt.Text = "";
            // 
            // cmbTeam
            // 
            cmbTeam.FormattingEnabled = true;
            cmbTeam.Items.AddRange(new object[] { "1", "2", "3" });
            cmbTeam.Location = new Point(163, 127);
            cmbTeam.Name = "cmbTeam";
            cmbTeam.Size = new Size(114, 23);
            cmbTeam.TabIndex = 33;
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = SystemColors.ActiveCaption;
            UpdateBtn.Font = new Font("Sitka Small", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UpdateBtn.Location = new Point(251, 321);
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
            DeleteBtn.Location = new Point(161, 352);
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
            AddBtn.Location = new Point(69, 321);
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ResultId, EventName, ParticipantName, TeamName, Position, Score, Remarks });
            dataGridView1.Location = new Point(325, 15);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(654, 291);
            dataGridView1.TabIndex = 12;
            // 
            // ResultId
            // 
            ResultId.HeaderText = "ResultId";
            ResultId.Name = "ResultId";
            // 
            // EventName
            // 
            EventName.HeaderText = "Event";
            EventName.Name = "EventName";
            // 
            // ParticipantName
            // 
            ParticipantName.HeaderText = "ParticipantName";
            ParticipantName.Name = "ParticipantName";
            // 
            // TeamName
            // 
            TeamName.HeaderText = "TeamName";
            TeamName.Name = "TeamName";
            // 
            // Position
            // 
            Position.HeaderText = "Position";
            Position.Name = "Position";
            // 
            // Score
            // 
            Score.HeaderText = "Score";
            Score.Name = "Score";
            // 
            // Remarks
            // 
            Remarks.HeaderText = "Remarks";
            Remarks.Name = "Remarks";
            // 
            // EventResultsUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(MainPanel);
            Name = "EventResultsUC";
            Size = new Size(982, 495);
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numScore).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPosition).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel MainPanel;
        private Label label8;
        private ComboBox cmbItec;
        private Label label7;
        private ComboBox cmbVenue;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label5;
        private RichTextBox Remarkstxt;
        private TextBox EventNametxt;
        private DateTimePicker dtpDate;
        private ComboBox cmbCategory;
        private ComboBox cmbTeam;
        private Button UpdateBtn;
        private Button DeleteBtn;
        private Button AddBtn;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ResultId;
        private DataGridViewTextBoxColumn EventName;
        private DataGridViewTextBoxColumn ParticipantName;
        private DataGridViewTextBoxColumn TeamName;
        private DataGridViewTextBoxColumn Position;
        private DataGridViewTextBoxColumn Score;
        private DataGridViewTextBoxColumn Remarks;
        private NumericUpDown numPosition;
        private DataGridViewTextBoxColumn EventId;
        private DataGridViewTextBoxColumn ItecId;
        private DataGridViewTextBoxColumn ItecYear;
        private DataGridViewTextBoxColumn CategoryId;
        private DataGridViewTextBoxColumn EventCategoryName;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn EventDate;
        private DataGridViewTextBoxColumn VenueId;
        private DataGridViewTextBoxColumn VenueName;
        private DataGridViewTextBoxColumn CommitteeId;
        private DataGridViewTextBoxColumn CommitteeName;
        private NumericUpDown numScore;
        private ComboBox cmbEvent;
        private ComboBox cmbParticipant;
    }
}
