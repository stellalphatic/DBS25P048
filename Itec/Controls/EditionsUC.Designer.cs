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
            Themetxt = new TextBox();
            Descriptiontxt = new TextBox();
            Yeartxt = new TextBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
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
            MainPanel.Controls.Add(Themetxt);
            MainPanel.Controls.Add(Descriptiontxt);
            MainPanel.Controls.Add(Yeartxt);
            MainPanel.Controls.Add(button4);
            MainPanel.Controls.Add(button3);
            MainPanel.Controls.Add(button2);
            MainPanel.Controls.Add(button1);
            MainPanel.Controls.Add(dataGridView1);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 49);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(982, 495);
            MainPanel.TabIndex = 11;
            // 
            // Themetxt
            // 
            Themetxt.Location = new Point(113, 92);
            Themetxt.Name = "Themetxt";
            Themetxt.Size = new Size(100, 23);
            Themetxt.TabIndex = 19;
            // 
            // Descriptiontxt
            // 
            Descriptiontxt.Location = new Point(113, 152);
            Descriptiontxt.Name = "Descriptiontxt";
            Descriptiontxt.Size = new Size(100, 23);
            Descriptiontxt.TabIndex = 18;
            // 
            // Yeartxt
            // 
            Yeartxt.Location = new Point(113, 34);
            Yeartxt.Name = "Yeartxt";
            Yeartxt.Size = new Size(100, 23);
            Yeartxt.TabIndex = 17;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaption;
            button4.Font = new Font("Sitka Small", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(493, 356);
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
            button3.Location = new Point(364, 346);
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
            button2.Location = new Point(175, 400);
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
            button1.Location = new Point(175, 346);
            button1.Name = "button1";
            button1.Size = new Size(75, 31);
            button1.TabIndex = 13;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Year, Theme, Description1, NoOfEvents, NoOfParticipants });
            dataGridView1.Location = new Point(426, 18);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(541, 291);
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
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Year;
        private DataGridViewTextBoxColumn Theme;
        private DataGridViewTextBoxColumn Description1;
        private DataGridViewTextBoxColumn NoOfEvents;
        private DataGridViewTextBoxColumn NoOfParticipants;
        private TextBox Themetxt;
        private TextBox Descriptiontxt;
        private TextBox Yeartxt;
    }
}
