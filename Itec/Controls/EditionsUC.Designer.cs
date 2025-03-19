namespace Itec.Controls
{
    partial class EditionsUC
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
            Yeartxt = new DateTimePicker();
            Descriptiontxt = new RichTextBox();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            label3 = new Label();
            Themetxt = new TextBox();
            UpdateBtn = new Button();
            DeleteBtn = new Button();
            AddBtn = new Button();
            dataGridView1 = new DataGridView();
            Year = new DataGridViewTextBoxColumn();
            Theme = new DataGridViewTextBoxColumn();
            Description1 = new DataGridViewTextBoxColumn();
            NoOfEvents = new DataGridViewTextBoxColumn();
            NoOfParticipants = new DataGridViewTextBoxColumn();
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
            label2.Size = new Size(284, 30);
            label2.TabIndex = 5;
            label2.Text = "ITEC Editions Management";
            // 
            // MainPanel
            // 
            MainPanel.BackColor = SystemColors.ButtonFace;
            MainPanel.Controls.Add(Yeartxt);
            MainPanel.Controls.Add(Descriptiontxt);
            MainPanel.Controls.Add(label5);
            MainPanel.Controls.Add(label4);
            MainPanel.Controls.Add(label1);
            MainPanel.Controls.Add(label3);
            MainPanel.Controls.Add(Themetxt);
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
            // Yeartxt
            // 
            Yeartxt.CustomFormat = "yyyy";
            Yeartxt.Format = DateTimePickerFormat.Custom;
            Yeartxt.Location = new Point(149, 96);
            Yeartxt.Name = "Yeartxt";
            Yeartxt.Size = new Size(158, 23);
            Yeartxt.TabIndex = 43;
            // 
            // Descriptiontxt
            // 
            Descriptiontxt.Location = new Point(149, 206);
            Descriptiontxt.Name = "Descriptiontxt";
            Descriptiontxt.Size = new Size(158, 88);
            Descriptiontxt.TabIndex = 42;
            Descriptiontxt.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.Cross;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(45, 205);
            label5.Name = "label5";
            label5.Size = new Size(91, 20);
            label5.TabIndex = 26;
            label5.Text = "Description:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Cross;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(45, 149);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 25;
            label4.Text = "Theme:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Cross;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(-402, -50);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 24;
            label1.Text = "Theme:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Cross;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(45, 96);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 23;
            label3.Text = "Year:";
            // 
            // Themetxt
            // 
            Themetxt.Location = new Point(149, 150);
            Themetxt.Name = "Themetxt";
            Themetxt.Size = new Size(100, 23);
            Themetxt.TabIndex = 19;
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = SystemColors.ActiveCaption;
            UpdateBtn.Font = new Font("Sitka Small", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UpdateBtn.Location = new Point(232, 323);
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
            DeleteBtn.Location = new Point(149, 375);
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
            AddBtn.Location = new Point(71, 323);
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Year, Theme, Description1, NoOfEvents, NoOfParticipants });
            dataGridView1.Location = new Point(365, 18);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(603, 291);
            dataGridView1.TabIndex = 12;
            // 
            // Year
            // 
            Year.HeaderText = "Year";
            Year.Name = "Year";
            // 
            // Theme
            // 
            Theme.HeaderText = "Theme";
            Theme.Name = "Theme";
            // 
            // Description1
            // 
            Description1.HeaderText = "Description";
            Description1.Name = "Description1";
            Description1.Width = 160;
            // 
            // NoOfEvents
            // 
            NoOfEvents.HeaderText = "NoOfEvents";
            NoOfEvents.Name = "NoOfEvents";
            // 
            // NoOfParticipants
            // 
            NoOfParticipants.HeaderText = "NoOfParticipants";
            NoOfParticipants.Name = "NoOfParticipants";
            // 
            // EditionsUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(MainPanel);
            Controls.Add(panel1);
            Name = "EditionsUC";
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
        private Button UpdateBtn;
        private Button DeleteBtn;
        private Button AddBtn;
        private DataGridView dataGridView1;
        private TextBox Themetxt;
        private Label label1;
        private Label label3;
        private Label label5;
        private Label label4;
        private RichTextBox Descriptiontxt;
        private DataGridViewTextBoxColumn Year;
        private DataGridViewTextBoxColumn Theme;
        private DataGridViewTextBoxColumn Description1;
        private DataGridViewTextBoxColumn NoOfEvents;
        private DataGridViewTextBoxColumn NoOfParticipants;
        private DateTimePicker Yeartxt;
    }
}
