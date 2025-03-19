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
            panel1 = new Panel();
            label2 = new Label();
            MainPanel = new Panel();
            label3 = new Label();
            label1 = new Label();
            CommitteeNametxt = new TextBox();
            cmbItec = new ComboBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            commitee_id = new DataGridViewTextBoxColumn();
            Itec_ID = new DataGridViewTextBoxColumn();
            CommiteeName = new DataGridViewTextBoxColumn();
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
            panel1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gill Sans MT", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(347, 9);
            label2.Name = "label2";
            label2.Size = new Size(320, 30);
            label2.TabIndex = 3;
            label2.Text = "Committee & Role Management";
            // 
            // MainPanel
            // 
            MainPanel.BackColor = SystemColors.ButtonFace;
            MainPanel.Controls.Add(label3);
            MainPanel.Controls.Add(label1);
            MainPanel.Controls.Add(CommitteeNametxt);
            MainPanel.Controls.Add(cmbItec);
            MainPanel.Controls.Add(button4);
            MainPanel.Controls.Add(button3);
            MainPanel.Controls.Add(button2);
            MainPanel.Controls.Add(button1);
            MainPanel.Controls.Add(dataGridView1);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 49);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(982, 495);
            MainPanel.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Cross;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(19, 89);
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
            label1.Location = new Point(45, 47);
            label1.Name = "label1";
            label1.Size = new Size(37, 20);
            label1.TabIndex = 44;
            label1.Text = "Itec:";
            // 
            // CommitteeNametxt
            // 
            CommitteeNametxt.Location = new Point(173, 89);
            CommitteeNametxt.Name = "CommitteeNametxt";
            CommitteeNametxt.Size = new Size(114, 23);
            CommitteeNametxt.TabIndex = 41;
            // 
            // cmbItec
            // 
            cmbItec.FormattingEnabled = true;
            cmbItec.Items.AddRange(new object[] { "1", "2", "3" });
            cmbItec.Location = new Point(173, 44);
            cmbItec.Name = "cmbItec";
            cmbItec.Size = new Size(114, 23);
            cmbItec.TabIndex = 38;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaption;
            button4.Font = new Font("Sitka Small", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(522, 345);
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
            button3.Location = new Point(366, 398);
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
            button2.Location = new Point(300, 326);
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
            button1.Location = new Point(127, 398);
            button1.Name = "button1";
            button1.Size = new Size(75, 31);
            button1.TabIndex = 13;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { commitee_id, Itec_ID, CommiteeName });
            dataGridView1.Location = new Point(634, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(343, 278);
            dataGridView1.TabIndex = 0;
            // 
            // commitee_id
            // 
            commitee_id.HeaderText = "Committee_id";
            commitee_id.Name = "commitee_id";
            // 
            // Itec_ID
            // 
            Itec_ID.HeaderText = "Itec_id";
            Itec_ID.Name = "Itec_ID";
            // 
            // CommiteeName
            // 
            CommiteeName.HeaderText = "CommitteeName";
            CommiteeName.Name = "CommiteeName";
            // 
            // CommiteesUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(MainPanel);
            Controls.Add(panel1);
            Name = "CommiteesUC";
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
        private ComboBox cmbItec;
        private TextBox CommitteeNametxt;
        private Label label3;
        private Label label1;
        private DataGridViewTextBoxColumn commitee_id;
        private DataGridViewTextBoxColumn Itec_ID;
        private DataGridViewTextBoxColumn CommiteeName;
    }
}
