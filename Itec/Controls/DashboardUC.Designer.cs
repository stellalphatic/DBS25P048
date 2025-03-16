namespace Itec.Controls
{
    partial class DashboardUC
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
            MainPanel = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            AssignRollBtn = new Button();
            cmbRole = new ComboBox();
            dataGridView1 = new DataGridView();
            user_id = new DataGridViewTextBoxColumn();
            username = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(MainPanel);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 49);
            panel1.TabIndex = 9;
            // 
            // MainPanel
            // 
            MainPanel.BackColor = SystemColors.ButtonFace;
            MainPanel.Location = new Point(0, 49);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(982, 495);
            MainPanel.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gill Sans MT", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(423, 9);
            label2.Name = "label2";
            label2.Size = new Size(118, 30);
            label2.TabIndex = 4;
            label2.Text = "Dashboard";
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(AssignRollBtn);
            panel2.Controls.Add(cmbRole);
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 49);
            panel2.Name = "panel2";
            panel2.Size = new Size(982, 495);
            panel2.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(722, 10);
            label1.Name = "label1";
            label1.Size = new Size(114, 22);
            label1.TabIndex = 34;
            label1.Text = "New Users";
            // 
            // AssignRollBtn
            // 
            AssignRollBtn.Location = new Point(866, 282);
            AssignRollBtn.Name = "AssignRollBtn";
            AssignRollBtn.Size = new Size(75, 23);
            AssignRollBtn.TabIndex = 33;
            AssignRollBtn.Text = "Approve";
            AssignRollBtn.UseVisualStyleBackColor = true;
            AssignRollBtn.Click += AssignRollBtn_Click;
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "1", "2", "3" });
            cmbRole.Location = new Point(827, 243);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(114, 23);
            cmbRole.TabIndex = 32;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { user_id, username, email });
            dataGridView1.Location = new Point(600, 35);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(341, 192);
            dataGridView1.TabIndex = 0;
            // 
            // user_id
            // 
            user_id.HeaderText = "user_id";
            user_id.Name = "user_id";
            // 
            // username
            // 
            username.HeaderText = "username";
            username.Name = "username";
            // 
            // email
            // 
            email.HeaderText = "email";
            email.Name = "email";
            // 
            // DashboardUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "DashboardUC";
            Size = new Size(982, 544);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Panel MainPanel;
        private Panel panel2;
        private DataGridView dataGridView1;
        private ComboBox cmbRole;
        private Button AssignRollBtn;
        private Label label1;
        private DataGridViewTextBoxColumn user_id;
        private DataGridViewTextBoxColumn username;
        private DataGridViewTextBoxColumn email;
    }
}
