namespace Itec.Controls
{
    partial class EventParticipantsUC
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
            cmbParticipant = new ComboBox();
            FeeAmounttxt = new NumericUpDown();
            cmbEvent = new ComboBox();
            label7 = new Label();
            label3 = new Label();
            label1 = new Label();
            label5 = new Label();
            cmbStatus = new ComboBox();
            UpdateBtn = new Button();
            DeleteBtn = new Button();
            AddBtn = new Button();
            dataGridView1 = new DataGridView();
            RegistrationId = new DataGridViewTextBoxColumn();
            EventName = new DataGridViewTextBoxColumn();
            ParticipantName = new DataGridViewTextBoxColumn();
            PaymentStatus = new DataGridViewTextBoxColumn();
            FeeAmount = new DataGridViewTextBoxColumn();
            MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FeeAmounttxt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.BackColor = SystemColors.ButtonFace;
            MainPanel.Controls.Add(cmbParticipant);
            MainPanel.Controls.Add(FeeAmounttxt);
            MainPanel.Controls.Add(cmbEvent);
            MainPanel.Controls.Add(label7);
            MainPanel.Controls.Add(label3);
            MainPanel.Controls.Add(label1);
            MainPanel.Controls.Add(label5);
            MainPanel.Controls.Add(cmbStatus);
            MainPanel.Controls.Add(UpdateBtn);
            MainPanel.Controls.Add(DeleteBtn);
            MainPanel.Controls.Add(AddBtn);
            MainPanel.Controls.Add(dataGridView1);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(982, 495);
            MainPanel.TabIndex = 12;
            // 
            // cmbParticipant
            // 
            cmbParticipant.FormattingEnabled = true;
            cmbParticipant.Items.AddRange(new object[] { "1", "2", "3" });
            cmbParticipant.Location = new Point(167, 87);
            cmbParticipant.Name = "cmbParticipant";
            cmbParticipant.Size = new Size(114, 23);
            cmbParticipant.TabIndex = 51;
            // 
            // FeeAmounttxt
            // 
            FeeAmounttxt.Location = new Point(161, 168);
            FeeAmounttxt.Name = "FeeAmounttxt";
            FeeAmounttxt.Size = new Size(120, 23);
            FeeAmounttxt.TabIndex = 50;
            // 
            // cmbEvent
            // 
            cmbEvent.FormattingEnabled = true;
            cmbEvent.Items.AddRange(new object[] { "1", "2", "3" });
            cmbEvent.Location = new Point(163, 42);
            cmbEvent.Name = "cmbEvent";
            cmbEvent.Size = new Size(114, 23);
            cmbEvent.TabIndex = 49;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Cursor = Cursors.Cross;
            label7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(39, 166);
            label7.Name = "label7";
            label7.Size = new Size(68, 20);
            label7.TabIndex = 48;
            label7.Text = "Amount:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Cross;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(39, 130);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 44;
            label3.Text = "Status:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Cross;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 90);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 43;
            label1.Text = "Participant:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.Cross;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(40, 41);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 42;
            label5.Text = "Event :";
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "1", "2", "3" });
            cmbStatus.Location = new Point(163, 127);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(114, 23);
            cmbStatus.TabIndex = 33;
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = SystemColors.ActiveCaption;
            UpdateBtn.Font = new Font("Sitka Small", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UpdateBtn.Location = new Point(258, 262);
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
            DeleteBtn.Location = new Point(161, 305);
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
            AddBtn.Location = new Point(51, 262);
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { RegistrationId, EventName, ParticipantName, PaymentStatus, FeeAmount });
            dataGridView1.Location = new Point(438, 32);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(495, 291);
            dataGridView1.TabIndex = 12;
            // 
            // RegistrationId
            // 
            RegistrationId.HeaderText = "RegistrationId";
            RegistrationId.Name = "RegistrationId";
            // 
            // EventName
            // 
            EventName.HeaderText = "EventName";
            EventName.Name = "EventName";
            // 
            // ParticipantName
            // 
            ParticipantName.HeaderText = "ParticipantName";
            ParticipantName.Name = "ParticipantName";
            // 
            // PaymentStatus
            // 
            PaymentStatus.HeaderText = "PaymentStatus";
            PaymentStatus.Name = "PaymentStatus";
            // 
            // FeeAmount
            // 
            FeeAmount.HeaderText = "FeeAmount";
            FeeAmount.Name = "FeeAmount";
            // 
            // EventParticipantsUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(MainPanel);
            Name = "EventParticipantsUC";
            Size = new Size(982, 495);
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)FeeAmounttxt).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel MainPanel;
        private Label label8;
        private ComboBox cmbEvent;
        private Label label7;
        private ComboBox cmbVenue;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label5;
        private RichTextBox Descriptiontxt;
        private DateTimePicker dtpDate;
        private ComboBox cmbCategory;
        private ComboBox cmbStatus;
        private Button UpdateBtn;
        private Button DeleteBtn;
        private Button AddBtn;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn RegistrationId;
        private DataGridViewTextBoxColumn EventName;
        private DataGridViewTextBoxColumn ParticipantName;
        private DataGridViewTextBoxColumn PaymentStatus;
        private DataGridViewTextBoxColumn FeeAmount;
        private NumericUpDown FeeAmounttxt;
        private ComboBox cmbParticipant;
    }
}
