namespace Itec.Controls
{
    partial class VenueAllocationUC
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
            dtpTime = new DateTimePicker();
            label1 = new Label();
            dtpDate = new DateTimePicker();
            cmbEvent = new ComboBox();
            cmbVenue = new ComboBox();
            LocationLabel = new Label();
            capacityLabel = new Label();
            VenueNameLabel = new Label();
            SearchBtn = new Button();
            UpdateBtn = new Button();
            DeleteBtn = new Button();
            AddBtn = new Button();
            dataGridView1 = new DataGridView();
            Allocation_id = new DataGridViewTextBoxColumn();
            Event_id = new DataGridViewTextBoxColumn();
            EventName = new DataGridViewTextBoxColumn();
            Venue_id = new DataGridViewTextBoxColumn();
            VenueName = new DataGridViewTextBoxColumn();
            Assigned_date = new DataGridViewTextBoxColumn();
            Assigned_time = new DataGridViewTextBoxColumn();
            MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.BackColor = SystemColors.ButtonFace;
            MainPanel.Controls.Add(dtpTime);
            MainPanel.Controls.Add(label1);
            MainPanel.Controls.Add(dtpDate);
            MainPanel.Controls.Add(cmbEvent);
            MainPanel.Controls.Add(cmbVenue);
            MainPanel.Controls.Add(LocationLabel);
            MainPanel.Controls.Add(capacityLabel);
            MainPanel.Controls.Add(VenueNameLabel);
            MainPanel.Controls.Add(SearchBtn);
            MainPanel.Controls.Add(UpdateBtn);
            MainPanel.Controls.Add(DeleteBtn);
            MainPanel.Controls.Add(AddBtn);
            MainPanel.Controls.Add(dataGridView1);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(982, 496);
            MainPanel.TabIndex = 12;
            // 
            // dtpTime
            // 
            dtpTime.CustomFormat = "hh:mm:ss";
            dtpTime.Format = DateTimePickerFormat.Custom;
            dtpTime.Location = new Point(161, 199);
            dtpTime.Name = "dtpTime";
            dtpTime.ShowUpDown = true;
            dtpTime.Size = new Size(200, 23);
            dtpTime.TabIndex = 36;
            dtpTime.Value = new DateTime(2025, 3, 20, 7, 26, 0, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Cross;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 199);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 35;
            label1.Text = "Assigned(time):";
            // 
            // dtpDate
            // 
            dtpDate.CustomFormat = "yyyy-mm-dd";
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.Location = new Point(161, 164);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(186, 23);
            dtpDate.TabIndex = 34;
            dtpDate.Value = new DateTime(2025, 7, 24, 0, 0, 0, 0);
            // 
            // cmbEvent
            // 
            cmbEvent.FormattingEnabled = true;
            cmbEvent.Items.AddRange(new object[] { "1", "2", "3" });
            cmbEvent.Location = new Point(161, 82);
            cmbEvent.Name = "cmbEvent";
            cmbEvent.Size = new Size(114, 23);
            cmbEvent.TabIndex = 33;
            // 
            // cmbVenue
            // 
            cmbVenue.FormattingEnabled = true;
            cmbVenue.Items.AddRange(new object[] { "1", "2", "3" });
            cmbVenue.Location = new Point(161, 126);
            cmbVenue.Name = "cmbVenue";
            cmbVenue.Size = new Size(114, 23);
            cmbVenue.TabIndex = 32;
            // 
            // LocationLabel
            // 
            LocationLabel.AutoSize = true;
            LocationLabel.Cursor = Cursors.Cross;
            LocationLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LocationLabel.Location = new Point(30, 164);
            LocationLabel.Name = "LocationLabel";
            LocationLabel.Size = new Size(93, 20);
            LocationLabel.TabIndex = 25;
            LocationLabel.Text = "Assigned_at:";
            // 
            // capacityLabel
            // 
            capacityLabel.AutoSize = true;
            capacityLabel.Cursor = Cursors.Cross;
            capacityLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            capacityLabel.Location = new Point(30, 126);
            capacityLabel.Name = "capacityLabel";
            capacityLabel.Size = new Size(56, 20);
            capacityLabel.TabIndex = 24;
            capacityLabel.Text = "Venue:";
            // 
            // VenueNameLabel
            // 
            VenueNameLabel.AutoSize = true;
            VenueNameLabel.Cursor = Cursors.Cross;
            VenueNameLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            VenueNameLabel.Location = new Point(30, 81);
            VenueNameLabel.Name = "VenueNameLabel";
            VenueNameLabel.Size = new Size(51, 20);
            VenueNameLabel.TabIndex = 23;
            VenueNameLabel.Text = "Event:";
            // 
            // SearchBtn
            // 
            SearchBtn.BackColor = SystemColors.ActiveCaption;
            SearchBtn.Font = new Font("Sitka Small", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchBtn.Location = new Point(230, 290);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(75, 31);
            SearchBtn.TabIndex = 16;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = false;
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = SystemColors.ActiveCaption;
            UpdateBtn.Font = new Font("Sitka Small", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UpdateBtn.Location = new Point(161, 253);
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
            DeleteBtn.Location = new Point(81, 290);
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
            AddBtn.Location = new Point(11, 253);
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Allocation_id, Event_id, EventName, Venue_id, VenueName, Assigned_date, Assigned_time });
            dataGridView1.Location = new Point(409, 30);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(543, 291);
            dataGridView1.TabIndex = 12;
            // 
            // Allocation_id
            // 
            Allocation_id.HeaderText = "Allocation_id";
            Allocation_id.Name = "Allocation_id";
            // 
            // Event_id
            // 
            Event_id.HeaderText = "Event_id";
            Event_id.Name = "Event_id";
            // 
            // EventName
            // 
            EventName.HeaderText = "Event";
            EventName.Name = "EventName";
            // 
            // Venue_id
            // 
            Venue_id.HeaderText = "Venue_id";
            Venue_id.Name = "Venue_id";
            // 
            // VenueName
            // 
            VenueName.HeaderText = "Venue";
            VenueName.Name = "VenueName";
            // 
            // Assigned_date
            // 
            Assigned_date.HeaderText = "Assigned_date";
            Assigned_date.Name = "Assigned_date";
            // 
            // Assigned_time
            // 
            Assigned_time.HeaderText = "Assigned_time";
            Assigned_time.Name = "Assigned_time";
            // 
            // VenueAllocationUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(MainPanel);
            Name = "VenueAllocationUC";
            Size = new Size(982, 496);
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel MainPanel;
        private Label LocationLabel;
        private Label capacityLabel;
        private Label VenueNameLabel;
        private Button SearchBtn;
        private Button UpdateBtn;
        private Button DeleteBtn;
        private Button AddBtn;
        private DataGridView dataGridView1;
        private ComboBox cmbEvent;
        private ComboBox cmbVenue;
        private DateTimePicker dtpDate;
        private Label label1;
        private DateTimePicker dtpTime;
        private DataGridViewTextBoxColumn Allocation_id;
        private DataGridViewTextBoxColumn Event_id;
        private DataGridViewTextBoxColumn EventName;
        private DataGridViewTextBoxColumn Venue_id;
        private DataGridViewTextBoxColumn VenueName;
        private DataGridViewTextBoxColumn Assigned_date;
        private DataGridViewTextBoxColumn Assigned_time;
    }
}
