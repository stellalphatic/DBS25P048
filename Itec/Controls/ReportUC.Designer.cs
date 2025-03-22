namespace Itec.Controls
{
    partial class ReportUC
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
            panel2 = new Panel();
            panel3 = new Panel();
            cmbItecEditions = new ComboBox();
            label6 = new Label();
            dgvReport = new DataGridView();
            cmbReport = new ComboBox();
            btnLoad = new Button();
            btnPrint = new Button();
            label4 = new Label();
            btnExport = new Button();
            label3 = new Label();
            comboBox1 = new ComboBox();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            dataGridView2 = new DataGridView();
            label1 = new Label();
            cmbReportType = new ComboBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            MainPanel.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(966, 49);
            panel1.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gill Sans MT", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(334, 9);
            label2.Name = "label2";
            label2.Size = new Size(318, 30);
            label2.TabIndex = 8;
            label2.Text = "Automated Report Generation";
            // 
            // MainPanel
            // 
            MainPanel.BackColor = SystemColors.ButtonFace;
            MainPanel.Controls.Add(panel2);
            MainPanel.Controls.Add(label1);
            MainPanel.Controls.Add(cmbReportType);
            MainPanel.Controls.Add(button4);
            MainPanel.Controls.Add(button3);
            MainPanel.Controls.Add(button2);
            MainPanel.Controls.Add(button1);
            MainPanel.Controls.Add(dataGridView1);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 49);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(966, 456);
            MainPanel.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button7);
            panel2.Controls.Add(button8);
            panel2.Controls.Add(dataGridView2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(966, 456);
            panel2.TabIndex = 45;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonFace;
            panel3.Controls.Add(cmbItecEditions);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(dgvReport);
            panel3.Controls.Add(cmbReport);
            panel3.Controls.Add(btnLoad);
            panel3.Controls.Add(btnPrint);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(btnExport);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(966, 456);
            panel3.TabIndex = 45;
            // 
            // cmbItecEditions
            // 
            cmbItecEditions.FormattingEnabled = true;
            cmbItecEditions.Location = new Point(129, 65);
            cmbItecEditions.Name = "cmbItecEditions";
            cmbItecEditions.Size = new Size(121, 23);
            cmbItecEditions.TabIndex = 57;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Cross;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(34, 68);
            label6.Name = "label6";
            label6.Size = new Size(61, 20);
            label6.TabIndex = 56;
            label6.Text = "Edition:";
            // 
            // dgvReport
            // 
            dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReport.Location = new Point(336, 36);
            dgvReport.Name = "dgvReport";
            dgvReport.Size = new Size(505, 290);
            dgvReport.TabIndex = 54;
            // 
            // cmbReport
            // 
            cmbReport.FormattingEnabled = true;
            cmbReport.Location = new Point(129, 15);
            cmbReport.Name = "cmbReport";
            cmbReport.Size = new Size(121, 23);
            cmbReport.TabIndex = 53;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = SystemColors.ActiveCaption;
            btnLoad.Font = new Font("Sitka Small", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLoad.Location = new Point(34, 195);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(108, 31);
            btnLoad.TabIndex = 52;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = SystemColors.ActiveCaption;
            btnPrint.Font = new Font("Sitka Small", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPrint.Location = new Point(34, 319);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(108, 31);
            btnPrint.TabIndex = 48;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Cross;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(34, 18);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 44;
            label4.Text = "Report:";
            // 
            // btnExport
            // 
            btnExport.BackColor = SystemColors.ActiveCaption;
            btnExport.Font = new Font("Sitka Small", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExport.Location = new Point(34, 250);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(108, 31);
            btnExport.TabIndex = 13;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Cross;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(64, 39);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 44;
            label3.Text = "Report:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1", "2", "3" });
            comboBox1.Location = new Point(141, 36);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(114, 23);
            comboBox1.TabIndex = 34;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ActiveCaption;
            button5.Font = new Font("Sitka Small", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(408, 342);
            button5.Name = "button5";
            button5.Size = new Size(75, 31);
            button5.TabIndex = 16;
            button5.Text = "Search";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ActiveCaption;
            button6.Font = new Font("Sitka Small", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.Location = new Point(348, 250);
            button6.Name = "button6";
            button6.Size = new Size(75, 31);
            button6.TabIndex = 15;
            button6.Text = "Update";
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ActiveCaption;
            button7.Font = new Font("Sitka Small", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.Location = new Point(322, 287);
            button7.Name = "button7";
            button7.Size = new Size(75, 31);
            button7.TabIndex = 14;
            button7.Text = "Delete";
            button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.ActiveCaption;
            button8.Font = new Font("Sitka Small", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.Location = new Point(180, 342);
            button8.Name = "button8";
            button8.Size = new Size(75, 31);
            button8.TabIndex = 13;
            button8.Text = "Insert";
            button8.UseVisualStyleBackColor = false;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(459, 18);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(495, 291);
            dataGridView2.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Cross;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(64, 39);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 44;
            label1.Text = "Report:";
            // 
            // cmbReportType
            // 
            cmbReportType.FormattingEnabled = true;
            cmbReportType.Items.AddRange(new object[] { "1", "2", "3" });
            cmbReportType.Location = new Point(141, 36);
            cmbReportType.Name = "cmbReportType";
            cmbReportType.Size = new Size(114, 23);
            cmbReportType.TabIndex = 34;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaption;
            button4.Font = new Font("Sitka Small", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(408, 342);
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
            button3.Location = new Point(348, 250);
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
            button2.Location = new Point(322, 287);
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
            button1.Location = new Point(180, 342);
            button1.Name = "button1";
            button1.Size = new Size(75, 31);
            button1.TabIndex = 13;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(459, 18);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(495, 291);
            dataGridView1.TabIndex = 12;
            // 
            // ReportUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(MainPanel);
            Controls.Add(panel1);
            Name = "ReportUC";
            Size = new Size(966, 505);
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
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
        private ComboBox cmbReportType;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Label label5;
        private ComboBox cmbEditions;
        private Label label4;
        private ComboBox comboBox2;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button btnExport;
        private Label label3;
        private ComboBox comboBox1;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private DataGridView dataGridView2;
        private Button btnPrint;
        private Panel panelFilters;
        private DataGridView dataGridViewReports;
        private ComboBox cmbCategoryFilter;
        private ComboBox cmbEventFilter;
        private ComboBox cmbRoleFilter;
        private Button btnLoad;
        private DataGridView dgvReport;
        private ComboBox cmbReport;
        private Label label6;
        private ComboBox cmbItecEditions;
    }
}
