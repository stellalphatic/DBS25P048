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
            FinancesBtn = new Button();
            SponsorsBtn = new Button();
            label2 = new Label();
            MainPanel = new Panel();
            label14 = new Label();
            dtpDate = new DateTimePicker();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            Balancelbl = new Label();
            Expenseslbl = new Label();
            Incomelbl = new Label();
            GenerateReportBtn = new Button();
            cmbToEntity = new ComboBox();
            cmbFromEntity = new ComboBox();
            Amounttxt = new NumericUpDown();
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
            cmbItec = new ComboBox();
            cmbEvent = new ComboBox();
            UpdateBtn = new Button();
            DeleteBtn = new Button();
            AddBtn = new Button();
            dataGridView1 = new DataGridView();
            TransactionId = new DataGridViewTextBoxColumn();
            ItecYear = new DataGridViewTextBoxColumn();
            EventName = new DataGridViewTextBoxColumn();
            FinanceType = new DataGridViewTextBoxColumn();
            amount12 = new DataGridViewTextBoxColumn();
            From = new DataGridViewTextBoxColumn();
            Toentity = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Amounttxt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(FinancesBtn);
            panel1.Controls.Add(SponsorsBtn);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 49);
            panel1.TabIndex = 9;
            // 
            // FinancesBtn
            // 
            FinancesBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FinancesBtn.Location = new Point(747, 13);
            FinancesBtn.Name = "FinancesBtn";
            FinancesBtn.Size = new Size(205, 30);
            FinancesBtn.TabIndex = 31;
            FinancesBtn.Text = "Finances Management";
            FinancesBtn.UseVisualStyleBackColor = true;
            FinancesBtn.Click += FinancesBtn_Click;
            // 
            // SponsorsBtn
            // 
            SponsorsBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SponsorsBtn.Location = new Point(549, 13);
            SponsorsBtn.Name = "SponsorsBtn";
            SponsorsBtn.Size = new Size(166, 30);
            SponsorsBtn.TabIndex = 30;
            SponsorsBtn.Text = "Sponsors";
            SponsorsBtn.UseVisualStyleBackColor = true;
            SponsorsBtn.Click += SponsorsBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gill Sans MT", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(17, 16);
            label2.Name = "label2";
            label2.Size = new Size(459, 30);
            label2.TabIndex = 7;
            label2.Text = "Financial Management & Sponsorship Tracking";
            // 
            // MainPanel
            // 
            MainPanel.BackColor = SystemColors.ButtonFace;
            MainPanel.Controls.Add(label14);
            MainPanel.Controls.Add(dtpDate);
            MainPanel.Controls.Add(label13);
            MainPanel.Controls.Add(label12);
            MainPanel.Controls.Add(label11);
            MainPanel.Controls.Add(Balancelbl);
            MainPanel.Controls.Add(Expenseslbl);
            MainPanel.Controls.Add(Incomelbl);
            MainPanel.Controls.Add(GenerateReportBtn);
            MainPanel.Controls.Add(cmbToEntity);
            MainPanel.Controls.Add(cmbFromEntity);
            MainPanel.Controls.Add(Amounttxt);
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
            MainPanel.Controls.Add(cmbItec);
            MainPanel.Controls.Add(cmbEvent);
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
            // label14
            // 
            label14.AutoSize = true;
            label14.Cursor = Cursors.Cross;
            label14.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(17, 334);
            label14.Name = "label14";
            label14.Size = new Size(45, 20);
            label14.TabIndex = 68;
            label14.Text = "Date:";
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(107, 331);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 23);
            dtpDate.TabIndex = 67;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Cursor = Cursors.Cross;
            label13.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(558, 432);
            label13.Name = "label13";
            label13.Size = new Size(66, 20);
            label13.TabIndex = 66;
            label13.Text = "Balance:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Cursor = Cursors.Cross;
            label12.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(558, 401);
            label12.Name = "label12";
            label12.Size = new Size(75, 20);
            label12.TabIndex = 65;
            label12.Text = "Expenses:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Cursor = Cursors.Cross;
            label11.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(558, 365);
            label11.Name = "label11";
            label11.Size = new Size(63, 20);
            label11.TabIndex = 64;
            label11.Text = "Income:";
            // 
            // Balancelbl
            // 
            Balancelbl.AutoSize = true;
            Balancelbl.Cursor = Cursors.Cross;
            Balancelbl.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Balancelbl.Location = new Point(686, 432);
            Balancelbl.Name = "Balancelbl";
            Balancelbl.Size = new Size(52, 20);
            Balancelbl.TabIndex = 63;
            Balancelbl.Text = "Rs0.00";
            // 
            // Expenseslbl
            // 
            Expenseslbl.AutoSize = true;
            Expenseslbl.Cursor = Cursors.Cross;
            Expenseslbl.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Expenseslbl.Location = new Point(686, 401);
            Expenseslbl.Name = "Expenseslbl";
            Expenseslbl.Size = new Size(52, 20);
            Expenseslbl.TabIndex = 62;
            Expenseslbl.Text = "Rs0.00";
            // 
            // Incomelbl
            // 
            Incomelbl.AutoSize = true;
            Incomelbl.Cursor = Cursors.Cross;
            Incomelbl.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Incomelbl.Location = new Point(686, 366);
            Incomelbl.Name = "Incomelbl";
            Incomelbl.Size = new Size(52, 20);
            Incomelbl.TabIndex = 61;
            Incomelbl.Text = "Rs0.00";
            Incomelbl.Click += label11_Click;
            // 
            // GenerateReportBtn
            // 
            GenerateReportBtn.BackColor = SystemColors.ActiveCaption;
            GenerateReportBtn.Font = new Font("Sitka Small", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GenerateReportBtn.Location = new Point(382, 323);
            GenerateReportBtn.Name = "GenerateReportBtn";
            GenerateReportBtn.Size = new Size(158, 31);
            GenerateReportBtn.TabIndex = 60;
            GenerateReportBtn.Text = "Generate Report:";
            GenerateReportBtn.UseVisualStyleBackColor = false;
            GenerateReportBtn.Click += GenerateReportBtn_Click;
            // 
            // cmbToEntity
            // 
            cmbToEntity.FormattingEnabled = true;
            cmbToEntity.Items.AddRange(new object[] { "1", "2", "3" });
            cmbToEntity.Location = new Point(106, 296);
            cmbToEntity.Name = "cmbToEntity";
            cmbToEntity.Size = new Size(114, 23);
            cmbToEntity.TabIndex = 59;
            // 
            // cmbFromEntity
            // 
            cmbFromEntity.FormattingEnabled = true;
            cmbFromEntity.Items.AddRange(new object[] { "1", "2", "3" });
            cmbFromEntity.Location = new Point(106, 221);
            cmbFromEntity.Name = "cmbFromEntity";
            cmbFromEntity.Size = new Size(114, 23);
            cmbFromEntity.TabIndex = 58;
            // 
            // Amounttxt
            // 
            Amounttxt.Location = new Point(107, 134);
            Amounttxt.Name = "Amounttxt";
            Amounttxt.Size = new Size(120, 23);
            Amounttxt.TabIndex = 57;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Cursor = Cursors.Cross;
            label10.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(16, 299);
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
            label9.Location = new Point(16, 258);
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
            label8.Location = new Point(17, 220);
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
            label4.Location = new Point(16, 176);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 51;
            label4.Text = "From Type:";
            label4.Click += label4_Click;
            // 
            // cmbToEntityType
            // 
            cmbToEntityType.FormattingEnabled = true;
            cmbToEntityType.Items.AddRange(new object[] { "1", "2", "3" });
            cmbToEntityType.Location = new Point(107, 255);
            cmbToEntityType.Name = "cmbToEntityType";
            cmbToEntityType.Size = new Size(114, 23);
            cmbToEntityType.TabIndex = 50;
            // 
            // cmbFromEntityType
            // 
            cmbFromEntityType.FormattingEnabled = true;
            cmbFromEntityType.Items.AddRange(new object[] { "1", "2", "3" });
            cmbFromEntityType.Location = new Point(108, 177);
            cmbFromEntityType.Name = "cmbFromEntityType";
            cmbFromEntityType.Size = new Size(114, 23);
            cmbFromEntityType.TabIndex = 49;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Cursor = Cursors.Cross;
            label7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(16, 91);
            label7.Name = "label7";
            label7.Size = new Size(45, 20);
            label7.TabIndex = 48;
            label7.Text = "Type:";
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Items.AddRange(new object[] { "1", "2", "3" });
            cmbType.Location = new Point(106, 92);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(114, 23);
            cmbType.TabIndex = 47;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Cross;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(16, 376);
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
            label3.Location = new Point(17, 53);
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
            label1.Location = new Point(16, 15);
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
            label5.Location = new Point(17, 132);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 42;
            label5.Text = "Amount:";
            // 
            // Descriptiontxt
            // 
            Descriptiontxt.Location = new Point(113, 376);
            Descriptiontxt.Name = "Descriptiontxt";
            Descriptiontxt.Size = new Size(158, 55);
            Descriptiontxt.TabIndex = 41;
            Descriptiontxt.Text = "";
            Descriptiontxt.TextChanged += Descriptiontxt_TextChanged;
            // 
            // cmbItec
            // 
            cmbItec.FormattingEnabled = true;
            cmbItec.Items.AddRange(new object[] { "1", "2", "3" });
            cmbItec.Location = new Point(106, 16);
            cmbItec.Name = "cmbItec";
            cmbItec.Size = new Size(114, 23);
            cmbItec.TabIndex = 37;
            // 
            // cmbEvent
            // 
            cmbEvent.FormattingEnabled = true;
            cmbEvent.Items.AddRange(new object[] { "1", "2", "3" });
            cmbEvent.Location = new Point(106, 54);
            cmbEvent.Name = "cmbEvent";
            cmbEvent.Size = new Size(114, 23);
            cmbEvent.TabIndex = 33;
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = SystemColors.ActiveCaption;
            UpdateBtn.Font = new Font("Sitka Small", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UpdateBtn.Location = new Point(310, 448);
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
            DeleteBtn.Location = new Point(178, 448);
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
            AddBtn.Location = new Point(32, 448);
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { TransactionId, ItecYear, EventName, FinanceType, amount12, From, Toentity, Description, Date });
            dataGridView1.Location = new Point(238, 15);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(741, 291);
            dataGridView1.TabIndex = 12;
            // 
            // TransactionId
            // 
            TransactionId.HeaderText = "TransactionId";
            TransactionId.Name = "TransactionId";
            // 
            // ItecYear
            // 
            ItecYear.HeaderText = "ItecYear";
            ItecYear.Name = "ItecYear";
            ItecYear.Width = 50;
            // 
            // EventName
            // 
            EventName.HeaderText = "EventName";
            EventName.Name = "EventName";
            EventName.Width = 85;
            // 
            // FinanceType
            // 
            FinanceType.HeaderText = "FinanceType";
            FinanceType.Name = "FinanceType";
            FinanceType.Width = 85;
            // 
            // amount12
            // 
            amount12.HeaderText = "Amount";
            amount12.Name = "amount12";
            amount12.Width = 80;
            // 
            // From
            // 
            From.HeaderText = "From";
            From.Name = "From";
            // 
            // Toentity
            // 
            Toentity.HeaderText = "To";
            Toentity.Name = "Toentity";
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
            Date.Width = 70;
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
            ((System.ComponentModel.ISupportInitialize)Amounttxt).EndInit();
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
        private ComboBox cmbItec;
        private ComboBox cmbEvent;
        private Button UpdateBtn;
        private Button DeleteBtn;
        private Button AddBtn;
        private DataGridView dataGridView1;
        private ComboBox cmbToEntityType;
        private ComboBox cmbFromEntityType;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label4;
        private NumericUpDown Amounttxt;
        private ComboBox cmbToEntity;
        private ComboBox cmbFromEntity;
        private Button VenuesBtn;
        private Button SponsorsBtn;
        private Button FinancesBtn;
        private Label Expenseslbl;
        private Label Incomelbl;
        private Button GenerateReportBtn;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label Balancelbl;
        private DateTimePicker dtpDate;
        private Label label14;
        private DataGridViewTextBoxColumn TransactionId;
        private DataGridViewTextBoxColumn ItecYear;
        private DataGridViewTextBoxColumn EventName;
        private DataGridViewTextBoxColumn FinanceType;
        private DataGridViewTextBoxColumn amount12;
        private DataGridViewTextBoxColumn From;
        private DataGridViewTextBoxColumn Toentity;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Date;
    }
}
