namespace Itec.Controls
{
    partial class CommiteesUC
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
            label3 = new Label();
            label1 = new Label();
            CommitteeNametxt = new TextBox();
            cmbItec = new ComboBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            CommitteeId = new DataGridViewTextBoxColumn();
            ItecId = new DataGridViewTextBoxColumn();
            Year = new DataGridViewTextBoxColumn();
            CommiteeName = new DataGridViewTextBoxColumn();
            MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.BackColor = SystemColors.ButtonFace;
            MainPanel.Controls.Add(label3);
            MainPanel.Controls.Add(label1);
            MainPanel.Controls.Add(CommitteeNametxt);
            MainPanel.Controls.Add(cmbItec);
            MainPanel.Controls.Add(button3);
            MainPanel.Controls.Add(button2);
            MainPanel.Controls.Add(button1);
            MainPanel.Controls.Add(dataGridView1);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(982, 544);
            MainPanel.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Cross;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(45, 118);
            label3.Name = "label3";
            label3.Size = new Size(132, 20);
            label3.TabIndex = 45;
            label3.Text = "Committee Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Cross;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(45, 75);
            label1.Name = "label1";
            label1.Size = new Size(37, 20);
            label1.TabIndex = 44;
            label1.Text = "Itec:";
            // 
            // CommitteeNametxt
            // 
            CommitteeNametxt.Location = new Point(183, 115);
            CommitteeNametxt.Name = "CommitteeNametxt";
            CommitteeNametxt.Size = new Size(139, 23);
            CommitteeNametxt.TabIndex = 41;
            // 
            // cmbItec
            // 
            cmbItec.FormattingEnabled = true;
            cmbItec.Items.AddRange(new object[] { "1", "2", "3" });
            cmbItec.Location = new Point(183, 72);
            cmbItec.Name = "cmbItec";
            cmbItec.Size = new Size(125, 23);
            cmbItec.TabIndex = 38;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Font = new Font("Sitka Small", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(292, 289);
            button3.Name = "button3";
            button3.Size = new Size(75, 31);
            button3.TabIndex = 15;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Font = new Font("Sitka Small", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(183, 253);
            button2.Name = "button2";
            button2.Size = new Size(75, 31);
            button2.TabIndex = 14;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Sitka Small", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(89, 289);
            button1.Name = "button1";
            button1.Size = new Size(75, 31);
            button1.TabIndex = 13;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { CommitteeId, ItecId, Year, CommiteeName });
            dataGridView1.Location = new Point(580, 42);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(345, 278);
            dataGridView1.TabIndex = 0;
            // 
            // CommitteeId
            // 
            CommitteeId.HeaderText = "Committee_id";
            CommitteeId.Name = "CommitteeId";
            // 
            // ItecId
            // 
            ItecId.HeaderText = "Itec_id";
            ItecId.Name = "ItecId";
            // 
            // Year
            // 
            Year.HeaderText = "Year";
            Year.Name = "Year";
            // 
            // CommiteeName
            // 
            CommiteeName.HeaderText = "CommitteeName";
            CommiteeName.Name = "CommiteeName";
            CommiteeName.Width = 200;
            // 
            // CommiteesUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(MainPanel);
            Name = "CommiteesUC";
            Size = new Size(982, 544);
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel MainPanel;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private ComboBox cmbItec;
        private TextBox CommitteeNametxt;
        private Label label3;
        private Label label1;
        private DataGridViewTextBoxColumn CommitteeId;
        private DataGridViewTextBoxColumn ItecId;
        private DataGridViewTextBoxColumn Year;
        private DataGridViewTextBoxColumn CommiteeName;
    }
}
