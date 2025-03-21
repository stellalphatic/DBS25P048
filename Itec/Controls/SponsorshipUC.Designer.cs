namespace Itec.Controls
{
    partial class SponsorshipUC
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
            label1 = new Label();
            Contacttxt = new TextBox();
            SponsorNametxt = new TextBox();
            label5 = new Label();
            UpdateBtn = new Button();
            DeleteBtn = new Button();
            AddBtn = new Button();
            dataGridView1 = new DataGridView();
            SponsorId = new DataGridViewTextBoxColumn();
            SponsorName = new DataGridViewTextBoxColumn();
            Contact = new DataGridViewTextBoxColumn();
            TotalAmount = new DataGridViewTextBoxColumn();
            MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.BackColor = SystemColors.ButtonFace;
            MainPanel.Controls.Add(label1);
            MainPanel.Controls.Add(Contacttxt);
            MainPanel.Controls.Add(SponsorNametxt);
            MainPanel.Controls.Add(label5);
            MainPanel.Controls.Add(UpdateBtn);
            MainPanel.Controls.Add(DeleteBtn);
            MainPanel.Controls.Add(AddBtn);
            MainPanel.Controls.Add(dataGridView1);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(982, 544);
            MainPanel.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Cross;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(44, 133);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 56;
            label1.Text = "Contact:";
            // 
            // Contacttxt
            // 
            Contacttxt.Location = new Point(163, 130);
            Contacttxt.Name = "Contacttxt";
            Contacttxt.Size = new Size(158, 23);
            Contacttxt.TabIndex = 55;
            // 
            // SponsorNametxt
            // 
            SponsorNametxt.Location = new Point(163, 63);
            SponsorNametxt.Name = "SponsorNametxt";
            SponsorNametxt.Size = new Size(158, 23);
            SponsorNametxt.TabIndex = 54;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.Cross;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(44, 62);
            label5.Name = "label5";
            label5.Size = new Size(114, 20);
            label5.TabIndex = 53;
            label5.Text = "Sponsor Name:";
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = SystemColors.ActiveCaption;
            UpdateBtn.Font = new Font("Sitka Small", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UpdateBtn.Location = new Point(246, 222);
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
            DeleteBtn.Location = new Point(141, 262);
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
            AddBtn.Location = new Point(44, 222);
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { SponsorId, SponsorName, Contact, TotalAmount });
            dataGridView1.Location = new Point(433, 32);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(521, 291);
            dataGridView1.TabIndex = 5;
            // 
            // SponsorId
            // 
            SponsorId.HeaderText = "SponsorId";
            SponsorId.Name = "SponsorId";
            // 
            // SponsorName
            // 
            SponsorName.HeaderText = "Sponsor Name";
            SponsorName.Name = "SponsorName";
            SponsorName.Width = 150;
            // 
            // Contact
            // 
            Contact.HeaderText = "Contact";
            Contact.Name = "Contact";
            Contact.Width = 150;
            // 
            // TotalAmount
            // 
            TotalAmount.HeaderText = "TotalAmount";
            TotalAmount.Name = "TotalAmount";
            TotalAmount.Width = 150;
            // 
            // SponsorshipUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(MainPanel);
            Name = "SponsorshipUC";
            Size = new Size(982, 544);
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel MainPanel;
        private TextBox SponsorNametxt;
        private Label label5;
        private Button UpdateBtn;
        private Button DeleteBtn;
        private Button AddBtn;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn SponsorId;
        private DataGridViewTextBoxColumn SponsorName;
        private DataGridViewTextBoxColumn Contact;
        private DataGridViewTextBoxColumn TotalAmount;
        private Label label1;
        private TextBox Contacttxt;
    }
}
