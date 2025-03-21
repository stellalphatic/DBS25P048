using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Itec.BL;
using Itec.DB;
using Itec.DL;
using Org.BouncyCastle.Asn1.Cmp;

namespace Itec.Controls
{
    public partial class DutiesUC : UserControl
    {
        public DutiesUC()
        {
            InitializeComponent();
            LoadDuties();
            PopulateComboboxes();

        }

        private void LoadDuties()
        {
            var duties = DutyDL.GetAllDuties();
            dataGridView1.Rows.Clear();

            foreach (var duty in duties)
            {
                dataGridView1.Rows.Add(
                    duty.DutyId,
                    duty.CommitteeId,
                    duty.CommitteeName,
                    duty.AssignedTo,
                    duty.TaskDescription,
                    duty.Deadline.ToString("yyyy-MM-dd"),
                    duty.StatusId,
                    duty.StatusName
                );
            }
            dataGridView1.Columns["CommitteeID"].Visible = false;
            dataGridView1.Columns["StatusId"].Visible = false;
            dataGridView1.Columns["DutyId"].Visible = false;
        }

        private void PopulateComboboxes()
        {
            //Committtees
            string committeeQuery = "SELECT committee_id, committee_name FROM committees";
            DataTable committeeData = DatabaseHelper.GetData(committeeQuery);
            cmbCommittee.DataSource = committeeData;
            cmbCommittee.DisplayMember = "committee_name";
            cmbCommittee.ValueMember = "committee_id";

            //Statuses
            string statusQuery = "SELECT lookup_id, value FROM lookup WHERE category = 'DutyStatus'";
            DataTable statusData = DatabaseHelper.GetData(statusQuery);
            cmbStatus.DataSource = statusData;
            cmbStatus.DisplayMember = "value";
            cmbStatus.ValueMember = "lookup_id";
        }





        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];


                cmbCommittee.SelectedValue = selectedRow.Cells["CommitteeId"].Value;
                TaskDescriptiontxt.Text = selectedRow.Cells["TaskDescription"].Value.ToString();
                dtpDeadline.Value = Convert.ToDateTime(selectedRow.Cells["Deadline"].Value);
                cmbStatus.SelectedValue = selectedRow.Cells["StatusId"].Value;
                txtAssignedTo.Text = selectedRow.Cells["AssignedTo"].Value.ToString();

            }
        }


        //Insert Button
        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbCommittee.SelectedValue == null || string.IsNullOrEmpty(txtAssignedTo.Text))
            {
                MessageBox.Show("Please select a committee and enter an assignee");
                return;
            }

            var newDuty = new Duty
            {
                CommitteeId = Convert.ToInt32(cmbCommittee.SelectedValue),
                AssignedTo = txtAssignedTo.Text,
                TaskDescription = TaskDescriptiontxt.Text,
                Deadline = dtpDeadline.Value,
                StatusId = cmbStatus.SelectedValue != null ? Convert.ToInt32(cmbStatus.SelectedValue) : 0
            };

            try
            {
                DutyDL.AddDuty(newDuty);
                LoadDuties();
                MessageBox.Show("Duty added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding duty: {ex.Message}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a duty to update.");
                return;
            }
            else
            {
                var selectedRow = dataGridView1.SelectedRows[0];

                //Input fields
                cmbCommittee.SelectedValue = selectedRow.Cells["CommitteeID"].Value;
                txtAssignedTo.Text = selectedRow.Cells["AssignedTo"].Value.ToString();
                TaskDescriptiontxt.Text = selectedRow.Cells["TaskDescription"].Value.ToString();
                dtpDeadline.Value = Convert.ToDateTime(selectedRow.Cells["Deadline"].Value);
                cmbStatus.SelectedValue = selectedRow.Cells["StatusId"].Value;

            }

            int dutyId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["DutyId"].Value);

            var updatedDuty = new Duty
            {
                DutyId = dutyId,
                CommitteeId = Convert.ToInt32(cmbCommittee.SelectedValue),
                AssignedTo = txtAssignedTo.Text,
                TaskDescription = TaskDescriptiontxt.Text,
                Deadline = dtpDeadline.Value,
                StatusId = cmbStatus.SelectedValue != null ? Convert.ToInt32(cmbStatus.SelectedValue) : 0
            };

            try
            {
                DutyDL.UpdateDuty(updatedDuty);
                LoadDuties();
                MessageBox.Show("Duty updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating duty: {ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a duty to delete");
                return;
            }

            int dutyId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["DutyId"].Value);

            try
            {
                DutyDL.DeleteDuty(dutyId);
                LoadDuties();
                MessageBox.Show("Duty deleted successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting duty: {ex.Message}");
            }
        }

        private void dtpDeadline_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
