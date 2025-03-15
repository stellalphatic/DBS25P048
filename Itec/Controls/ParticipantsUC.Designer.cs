namespace Itec.Controls
{
    partial class ParticipantsUC
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
            label8 = new Label();
            label9 = new Label();
            RollIDtxt = new TextBox();
            Institutetxt = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            Contacttxt = new TextBox();
            Emailtxt = new TextBox();
            Nametxt = new TextBox();
            ItecIDtxt = new TextBox();
            ParticipantIDtxt = new TextBox();
            SearchBtn = new Button();
            UpdateBtn = new Button();
            DeleteBtn = new Button();
            AddBtn = new Button();
            dataGridView1 = new DataGridView();
            Participant_ID = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            Itec_ID = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Contact = new DataGridViewTextBoxColumn();
            Institute = new DataGridViewTextBoxColumn();
            Role_ID = new DataGridViewTextBoxColumn();
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
            label2.Location = new Point(359, 9);
            label2.Name = "label2";
            label2.Size = new Size(249, 30);
            label2.TabIndex = 8;
            label2.Text = "Participant Registration";
            // 
            // MainPanel
            // 
            MainPanel.BackColor = SystemColors.ButtonFace;
            MainPanel.Controls.Add(label8);
            MainPanel.Controls.Add(label9);
            MainPanel.Controls.Add(RollIDtxt);
            MainPanel.Controls.Add(Institutetxt);
            MainPanel.Controls.Add(label7);
            MainPanel.Controls.Add(label6);
            MainPanel.Controls.Add(label5);
            MainPanel.Controls.Add(label4);
            MainPanel.Controls.Add(label3);
            MainPanel.Controls.Add(Contacttxt);
            MainPanel.Controls.Add(Emailtxt);
            MainPanel.Controls.Add(Nametxt);
            MainPanel.Controls.Add(ItecIDtxt);
            MainPanel.Controls.Add(ParticipantIDtxt);
            MainPanel.Controls.Add(SearchBtn);
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
            // label8
            // 
            label8.AutoSize = true;
            label8.Cursor = Cursors.Cross;
            label8.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(21, 237);
            label8.Name = "label8";
            label8.Size = new Size(60, 20);
            label8.TabIndex = 30;
            label8.Text = "Roll_ID:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Cursor = Cursors.Cross;
            label9.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(21, 206);
            label9.Name = "label9";
            label9.Size = new Size(68, 20);
            label9.TabIndex = 29;
            label9.Text = "Institute:";
            // 
            // RollIDtxt
            // 
            RollIDtxt.Location = new Point(133, 238);
            RollIDtxt.Name = "RollIDtxt";
            RollIDtxt.Size = new Size(114, 23);
            RollIDtxt.TabIndex = 28;
            // 
            // Institutetxt
            // 
            Institutetxt.Location = new Point(133, 206);
            Institutetxt.Name = "Institutetxt";
            Institutetxt.Size = new Size(114, 23);
            Institutetxt.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Cursor = Cursors.Cross;
            label7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(21, 176);
            label7.Name = "label7";
            label7.Size = new Size(65, 20);
            label7.TabIndex = 26;
            label7.Text = "Contact:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Cross;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(21, 144);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 25;
            label6.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.Cross;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(21, 105);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 24;
            label5.Text = "Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Cross;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(21, 69);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 23;
            label4.Text = "Itec_ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Cross;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(21, 37);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 22;
            label3.Text = "Participant_ID:";
            // 
            // Contacttxt
            // 
            Contacttxt.Location = new Point(133, 173);
            Contacttxt.Name = "Contacttxt";
            Contacttxt.Size = new Size(114, 23);
            Contacttxt.TabIndex = 21;
            // 
            // Emailtxt
            // 
            Emailtxt.Location = new Point(133, 141);
            Emailtxt.Name = "Emailtxt";
            Emailtxt.Size = new Size(114, 23);
            Emailtxt.TabIndex = 20;
            // 
            // Nametxt
            // 
            Nametxt.Location = new Point(133, 105);
            Nametxt.Name = "Nametxt";
            Nametxt.Size = new Size(114, 23);
            Nametxt.TabIndex = 19;
            // 
            // ItecIDtxt
            // 
            ItecIDtxt.Location = new Point(133, 70);
            ItecIDtxt.Name = "ItecIDtxt";
            ItecIDtxt.Size = new Size(114, 23);
            ItecIDtxt.TabIndex = 18;
            // 
            // ParticipantIDtxt
            // 
            ParticipantIDtxt.Location = new Point(133, 38);
            ParticipantIDtxt.Name = "ParticipantIDtxt";
            ParticipantIDtxt.Size = new Size(114, 23);
            ParticipantIDtxt.TabIndex = 17;
            // 
            // SearchBtn
            // 
            SearchBtn.BackColor = SystemColors.ActiveCaption;
            SearchBtn.Font = new Font("Sitka Small", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchBtn.Location = new Point(214, 341);
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
            UpdateBtn.Location = new Point(79, 341);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(75, 31);
            UpdateBtn.TabIndex = 15;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = false;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = SystemColors.ActiveCaption;
            DeleteBtn.Font = new Font("Sitka Small", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeleteBtn.Location = new Point(133, 293);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(75, 31);
            DeleteBtn.TabIndex = 14;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = SystemColors.ActiveCaption;
            AddBtn.Font = new Font("Sitka Small", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddBtn.Location = new Point(21, 293);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(75, 31);
            AddBtn.TabIndex = 13;
            AddBtn.Text = "Insert";
            AddBtn.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Participant_ID, FullName, Itec_ID, Email, Contact, Institute, Role_ID });
            dataGridView1.Location = new Point(352, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(627, 291);
            dataGridView1.TabIndex = 12;
        
            // 
            // Participant_ID
            // 
            Participant_ID.HeaderText = "Participant_ID";
            Participant_ID.MaxInputLength = 3211;
            Participant_ID.Name = "Participant_ID";
            Participant_ID.Width = 85;
            // 
            // FullName
            // 
            FullName.HeaderText = "Name";
            FullName.Name = "FullName";
            // 
            // Itec_ID
            // 
            Itec_ID.HeaderText = "Itec_ID";
            Itec_ID.Name = "Itec_ID";
            Itec_ID.Width = 50;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.Name = "Email";
            // 
            // Contact
            // 
            Contact.HeaderText = "Contact";
            Contact.Name = "Contact";
            // 
            // Institute
            // 
            Institute.HeaderText = "Institute";
            Institute.Name = "Institute";
            // 
            // Role_ID
            // 
            Role_ID.HeaderText = "Role_ID";
            Role_ID.Name = "Role_ID";
            Role_ID.Width = 50;
            // 
            // ParticipantsUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(MainPanel);
            Controls.Add(panel1);
            Name = "ParticipantsUC";
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
        private Label label8;
        private Label label9;
        private TextBox RollIDtxt;
        private TextBox Institutetxt;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox Contacttxt;
        private TextBox Emailtxt;
        private TextBox Nametxt;
        private TextBox ItecIDtxt;
        private TextBox ParticipantIDtxt;
        private Button SearchBtn;
        private Button UpdateBtn;
        private Button DeleteBtn;
        private Button AddBtn;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Participant_ID;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn Itec_ID;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Contact;
        private DataGridViewTextBoxColumn Institute;
        private DataGridViewTextBoxColumn Role_ID;
    }
}
