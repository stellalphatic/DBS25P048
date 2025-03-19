namespace Itec.Controls
{
    partial class EventsManageUC
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
            label7 = new Label();
            cmbVenue = new ComboBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label5 = new Label();
            Descriptiontxt = new RichTextBox();
            EventNametxt = new TextBox();
            dtpDate = new DateTimePicker();
            cmbEventCategory = new ComboBox();
            cmbCommittee = new ComboBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            EventId = new DataGridViewTextBoxColumn();
            EventName = new DataGridViewTextBoxColumn();
            EventCategoryId = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            EventDate = new DataGridViewTextBoxColumn();
            VenueId = new DataGridViewTextBoxColumn();
            CommitteeId = new DataGridViewTextBoxColumn();
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
            label2.Location = new Point(348, 9);
            label2.Name = "label2";
            label2.Size = new Size(205, 30);
            label2.TabIndex = 6;
            label2.Text = "Event Management";
            // 
            // MainPanel
            // 
            MainPanel.BackColor = SystemColors.ButtonFace;
            MainPanel.Controls.Add(label7);
            MainPanel.Controls.Add(cmbVenue);
            MainPanel.Controls.Add(label6);
            MainPanel.Controls.Add(label4);
            MainPanel.Controls.Add(label3);
            MainPanel.Controls.Add(label1);
            MainPanel.Controls.Add(label5);
            MainPanel.Controls.Add(Descriptiontxt);
            MainPanel.Controls.Add(EventNametxt);
            MainPanel.Controls.Add(dtpDate);
            MainPanel.Controls.Add(cmbEventCategory);
            MainPanel.Controls.Add(cmbCommittee);
            MainPanel.Controls.Add(button4);
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Cursor = Cursors.Cross;
            label7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(39, 166);
            label7.Name = "label7";
            label7.Size = new Size(56, 20);
            label7.TabIndex = 48;
            label7.Text = "Venue:";
            // 
            // cmbVenue
            // 
            cmbVenue.FormattingEnabled = true;
            cmbVenue.Items.AddRange(new object[] { "1", "2", "3" });
            cmbVenue.Location = new Point(161, 172);
            cmbVenue.Name = "cmbVenue";
            cmbVenue.Size = new Size(114, 23);
            cmbVenue.TabIndex = 47;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Cross;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(39, 238);
            label6.Name = "label6";
            label6.Size = new Size(91, 20);
            label6.TabIndex = 46;
            label6.Text = "Description:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Cross;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(39, 203);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 45;
            label4.Text = "Event Date:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Cross;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(39, 130);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 44;
            label3.Text = "Committee:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Cross;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 90);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 43;
            label1.Text = "Event Category:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.Cross;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(39, 48);
            label5.Name = "label5";
            label5.Size = new Size(96, 20);
            label5.TabIndex = 42;
            label5.Text = "Event Name:";
            // 
            // Descriptiontxt
            // 
            Descriptiontxt.Location = new Point(161, 238);
            Descriptiontxt.Name = "Descriptiontxt";
            Descriptiontxt.Size = new Size(158, 55);
            Descriptiontxt.TabIndex = 41;
            Descriptiontxt.Text = "";
            // 
            // EventNametxt
            // 
            EventNametxt.Location = new Point(163, 49);
            EventNametxt.Name = "EventNametxt";
            EventNametxt.Size = new Size(114, 23);
            EventNametxt.TabIndex = 40;
            // 
            // dtpDate
            // 
            dtpDate.CustomFormat = "yyyy-MM-dd";
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.Location = new Point(161, 201);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(186, 23);
            dtpDate.TabIndex = 38;
            dtpDate.Value = new DateTime(2025, 7, 24, 0, 0, 0, 0);
            // 
            // cmbEventCategory
            // 
            cmbEventCategory.FormattingEnabled = true;
            cmbEventCategory.Items.AddRange(new object[] { "1", "2", "3" });
            cmbEventCategory.Location = new Point(163, 90);
            cmbEventCategory.Name = "cmbEventCategory";
            cmbEventCategory.Size = new Size(114, 23);
            cmbEventCategory.TabIndex = 37;
            // 
            // cmbCommittee
            // 
            cmbCommittee.FormattingEnabled = true;
            cmbCommittee.Items.AddRange(new object[] { "1", "2", "3" });
            cmbCommittee.Location = new Point(163, 127);
            cmbCommittee.Name = "cmbCommittee";
            cmbCommittee.Size = new Size(114, 23);
            cmbCommittee.TabIndex = 33;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaption;
            button4.Font = new Font("Sitka Small", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(325, 358);
            button4.Name = "button4";
            button4.Size = new Size(75, 31);
            button4.TabIndex = 16;
            button4.Text = "Search";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Font = new Font("Sitka Small", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(251, 321);
            button3.Name = "button3";
            button3.Size = new Size(75, 31);
            button3.TabIndex = 15;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = false;
           
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Font = new Font("Sitka Small", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(161, 352);
            button2.Name = "button2";
            button2.Size = new Size(75, 31);
            button2.TabIndex = 14;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Sitka Small", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(69, 321);
            button1.Name = "button1";
            button1.Size = new Size(75, 31);
            button1.TabIndex = 13;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = false;
           
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { EventId, EventName, EventCategoryId, Description, EventDate, VenueId, CommitteeId });
            dataGridView1.Location = new Point(353, 15);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(626, 291);
            dataGridView1.TabIndex = 12;
            // 
            // EventId
            // 
            EventId.HeaderText = "Event_id";
            EventId.Name = "EventId";
            // 
            // EventName
            // 
            EventName.HeaderText = "Event Name";
            EventName.Name = "EventName";
            // 
            // EventCategoryId
            // 
            EventCategoryId.HeaderText = "Event_category_Id";
            EventCategoryId.Name = "EventCategoryId";
            // 
            // Description
            // 
            Description.HeaderText = "Description";
            Description.Name = "Description";
            // 
            // EventDate
            // 
            EventDate.HeaderText = "Event Date";
            EventDate.Name = "EventDate";
            // 
            // VenueId
            // 
            VenueId.HeaderText = "Venue ID";
            VenueId.Name = "VenueId";
            // 
            // CommitteeId
            // 
            CommitteeId.HeaderText = "Committee Id";
            CommitteeId.Name = "CommitteeId";
            // 
            // EventsManageUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(MainPanel);
            Controls.Add(panel1);
            Name = "EventsManageUC";
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
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private ComboBox cmbEventCategory;
        private ComboBox cmbCommittee;
        private DateTimePicker dtpDate;
        private TextBox EventNametxt;
        private RichTextBox Descriptiontxt;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label5;
        private Label label7;
        private ComboBox cmbVenue;
        private DataGridViewTextBoxColumn EventId;
        private DataGridViewTextBoxColumn EventName;
        private DataGridViewTextBoxColumn EventCategoryId;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn EventDate;
        private DataGridViewTextBoxColumn VenueId;
        private DataGridViewTextBoxColumn CommitteeId;
    }
}
