namespace Itec.Controls
{
    partial class FinancesUC
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
            ToEntityIdtxt = new TextBox();
            FromEntityIdtxt = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label4 = new Label();
            cmbToEntityType = new ComboBox();
            cmbFromEntityType = new ComboBox();
            label7 = new Label();
            cmbType = new ComboBox();
            label6 = new Label();
            label3 = new Label();
            label1 = new Label();
            label5 = new Label();
            Descriptiontxt = new RichTextBox();
            Amounttxt = new TextBox();
            cmbItec = new ComboBox();
            cmbEvent = new ComboBox();
            button4 = new Button();
            UpdateBtn = new Button();
            DeleteBtn = new Button();
            AddBtn = new Button();
            dataGridView1 = new DataGridView();
            Tx_id = new DataGridViewTextBoxColumn();
            ItecID = new DataGridViewTextBoxColumn();
            EventID = new DataGridViewTextBoxColumn();
            TypeID = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            FromType = new DataGridViewTextBoxColumn();
            FromID = new DataGridViewTextBoxColumn();
            ToType = new DataGridViewTextBoxColumn();
            To_id = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
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
            label2.Location = new Point(247, 9);
            label2.Name = "label2";
            label2.Size = new Size(459, 30);
            label2.TabIndex = 7;
            label2.Text = "Financial Management & Sponsorship Tracking";
            // 
            // MainPanel
            // 
            MainPanel.BackColor = SystemColors.ButtonFace;
            MainPanel.Controls.Add(ToEntityIdtxt);
            MainPanel.Controls.Add(FromEntityIdtxt);
            MainPanel.Controls.Add(label10);
            MainPanel.Controls.Add(label9);
            MainPanel.Controls.Add(label8);
            MainPanel.Controls.Add(label4);
            MainPanel.Controls.Add(cmbToEntityType);
            MainPanel.Controls.Add(cmbFromEntityType);
            MainPanel.Controls.Add(label7);
            MainPanel.Controls.Add(cmbType);
            MainPanel.Controls.Add(label6);
            MainPanel.Controls.Add(label3);
            MainPanel.Controls.Add(label1);
            MainPanel.Controls.Add(label5);
            MainPanel.Controls.Add(Descriptiontxt);
            MainPanel.Controls.Add(Amounttxt);
            MainPanel.Controls.Add(cmbItec);
            MainPanel.Controls.Add(cmbEvent);
            MainPanel.Controls.Add(button4);
            MainPanel.Controls.Add(UpdateBtn);
            MainPanel.Controls.Add(DeleteBtn);
            MainPanel.Controls.Add(AddBtn);
            MainPanel.Controls.Add(dataGridView1);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 49);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(982, 495);
            MainPanel.TabIndex = 12;
            // 
            // ToEntityIdtxt
            // 
            ToEntityIdtxt.Location = new Point(107, 323);
            ToEntityIdtxt.Name = "ToEntityIdtxt";
            ToEntityIdtxt.Size = new Size(114, 23);
            ToEntityIdtxt.TabIndex = 56;
            // 
            // FromEntityIdtxt
            // 
            FromEntityIdtxt.Location = new Point(107, 248);
            FromEntityIdtxt.Name = "FromEntityIdtxt";
            FromEntityIdtxt.Size = new Size(114, 23);
            FromEntityIdtxt.TabIndex = 55;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Cursor = Cursors.Cross;
            label10.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(17, 322);
            label10.Name = "label10";
            label10.Size = new Size(50, 20);
            label10.TabIndex = 54;
            label10.Text = "TO ID:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Cursor = Cursors.Cross;
            label9.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(16, 286);
            label9.Name = "label9";
            label9.Size = new Size(65, 20);
            label9.TabIndex = 53;
            label9.Text = "To Type:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Cursor = Cursors.Cross;
            label8.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(16, 247);
            label8.Name = "label8";
            label8.Size = new Size(68, 20);
            label8.TabIndex = 52;
            label8.Text = "From ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Cross;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(16, 208);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 51;
            label4.Text = "From Type:";
            // 
            // cmbToEntityType
            // 
            cmbToEntityType.FormattingEnabled = true;
            cmbToEntityType.Items.AddRange(new object[] { "1", "2", "3" });
            cmbToEntityType.Location = new Point(107, 287);
            cmbToEntityType.Name = "cmbToEntityType";
            cmbToEntityType.Size = new Size(114, 23);
            cmbToEntityType.TabIndex = 50;
            // 
            // cmbFromEntityType
            // 
            cmbFromEntityType.FormattingEnabled = true;
            cmbFromEntityType.Items.AddRange(new object[] { "1", "2", "3" });
            cmbFromEntityType.Location = new Point(106, 205);
            cmbFromEntityType.Name = "cmbFromEntityType";
            cmbFromEntityType.Size = new Size(114, 23);
            cmbFromEntityType.TabIndex = 49;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Cursor = Cursors.Cross;
            label7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(16, 116);
            label7.Name = "label7";
            label7.Size = new Size(45, 20);
            label7.TabIndex = 48;
            label7.Text = "Type:";
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Items.AddRange(new object[] { "1", "2", "3" });
            cmbType.Location = new Point(106, 116);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(114, 23);
            cmbType.TabIndex = 47;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Cross;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(16, 365);
            label6.Name = "label6";
            label6.Size = new Size(91, 20);
            label6.TabIndex = 46;
            label6.Text = "Description:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Cross;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(16, 70);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 44;
            label3.Text = "Event:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Cross;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 32);
            label1.Name = "label1";
            label1.Size = new Size(37, 20);
            label1.TabIndex = 43;
            label1.Text = "Itec:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.Cross;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(16, 166);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 42;
            label5.Text = "Amount:";
            // 
            // Descriptiontxt
            // 
            Descriptiontxt.Location = new Point(106, 366);
            Descriptiontxt.Name = "Descriptiontxt";
            Descriptiontxt.Size = new Size(158, 55);
            Descriptiontxt.TabIndex = 41;
            Descriptiontxt.Text = "";
            // 
            // Amounttxt
            // 
            Amounttxt.Location = new Point(106, 163);
            Amounttxt.Name = "Amounttxt";
            Amounttxt.Size = new Size(114, 23);
            Amounttxt.TabIndex = 40;
            // 
            // cmbItec
            // 
            cmbItec.FormattingEnabled = true;
            cmbItec.Items.AddRange(new object[] { "1", "2", "3" });
            cmbItec.Location = new Point(106, 32);
            cmbItec.Name = "cmbItec";
            cmbItec.Size = new Size(114, 23);
            cmbItec.TabIndex = 37;
            // 
            // cmbEvent
            // 
            cmbEvent.FormattingEnabled = true;
            cmbEvent.Items.AddRange(new object[] { "1", "2", "3" });
            cmbEvent.Location = new Point(106, 70);
            cmbEvent.Name = "cmbEvent";
            cmbEvent.Size = new Size(114, 23);
            cmbEvent.TabIndex = 33;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaption;
            button4.Font = new Font("Sitka Small", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(607, 392);
            button4.Name = "button4";
            button4.Size = new Size(75, 31);
            button4.TabIndex = 16;
            button4.Text = "Search";
            button4.UseVisualStyleBackColor = false;
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = SystemColors.ActiveCaption;
            UpdateBtn.Font = new Font("Sitka Small", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UpdateBtn.Location = new Point(527, 332);
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
            DeleteBtn.Location = new Point(431, 386);
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
            AddBtn.Location = new Point(353, 332);
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Tx_id, ItecID, EventID, TypeID, Amount, FromType, FromID, ToType, To_id, Description, Date });
            dataGridView1.Location = new Point(235, 15);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(743, 291);
            dataGridView1.TabIndex = 12;
            // 
            // Tx_id
            // 
            Tx_id.HeaderText = "Tx_id";
            Tx_id.Name = "Tx_id";
            Tx_id.Width = 40;
            // 
            // ItecID
            // 
            ItecID.HeaderText = "ItecId";
            ItecID.Name = "ItecID";
            ItecID.Width = 40;
            // 
            // EventID
            // 
            EventID.HeaderText = "EventID";
            EventID.Name = "EventID";
            EventID.Width = 50;
            // 
            // TypeID
            // 
            TypeID.HeaderText = "TypeID";
            TypeID.Name = "TypeID";
            TypeID.Width = 50;
            // 
            // Amount
            // 
            Amount.HeaderText = "Amount";
            Amount.Name = "Amount";
            Amount.Width = 80;
            // 
            // FromType
            // 
            FromType.HeaderText = "FromType";
            FromType.Name = "FromType";
            FromType.Width = 80;
            // 
            // FromID
            // 
            FromID.HeaderText = "FromID";
            FromID.Name = "FromID";
            FromID.Width = 50;
            // 
            // ToType
            // 
            ToType.HeaderText = "ToType";
            ToType.Name = "ToType";
            ToType.Width = 80;
            // 
            // To_id
            // 
            To_id.HeaderText = "To_id";
            To_id.Name = "To_id";
            To_id.Width = 50;
            // 
            // Description
            // 
            Description.HeaderText = "Description";
            Description.Name = "Description";
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.Name = "Date";
            Date.Width = 80;
            // 
            // FinancesUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(MainPanel);
            Controls.Add(panel1);
            Name = "FinancesUC";
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
        private Label label7;
        private ComboBox cmbType;
        private Label label6;
        private Label label3;
        private Label label1;
        private Label label5;
        private RichTextBox Descriptiontxt;
        private TextBox Amounttxt;
        private ComboBox cmbItec;
        private ComboBox cmbEvent;
        private Button button4;
        private Button UpdateBtn;
        private Button DeleteBtn;
        private Button AddBtn;
        private DataGridView dataGridView1;
        private ComboBox cmbToEntityType;
        private ComboBox cmbFromEntityType;
        private TextBox ToEntityIdtxt;
        private TextBox FromEntityIdtxt;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label4;
        private DataGridViewTextBoxColumn Tx_id;
        private DataGridViewTextBoxColumn ItecID;
        private DataGridViewTextBoxColumn EventID;
        private DataGridViewTextBoxColumn TypeID;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn FromType;
        private DataGridViewTextBoxColumn FromID;
        private DataGridViewTextBoxColumn ToType;
        private DataGridViewTextBoxColumn To_id;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Date;
    }
}
