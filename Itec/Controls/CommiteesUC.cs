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

namespace Itec.Controls
{
    public partial class CommiteesUC : UserControl
    {
        public CommiteesUC()
        {
            InitializeComponent();
            LoadCommittees();
            PopulateComboboxes();
        }

        private void LoadCommittees()
        {
            var committees = CommitteeDL.GetAllCommittees();
            dataGridView1.Rows.Clear();

            foreach (var committee in committees)
            {
                dataGridView1.Rows.Add(
                    committee.CommitteeId,
                    committee.ItecId,
                    committee.Year,
                    committee.CommitteeName
                );
            }
            dataGridView1.Columns["CommitteeId"].Visible = false;
            dataGridView1.Columns["ItecId"].Visible = false;
        }

        private void PopulateComboboxes()
        {
            string itecQuery = "SELECT itec_id, year FROM itec_editions";
            DataTable itecData = DatabaseHelper.GetData(itecQuery);
            cmbItec.DataSource = itecData;
            cmbItec.DisplayMember = "year";
            cmbItec.ValueMember = "itec_id";
        }

        //Insert Button
        private void button1_Click(object sender, EventArgs e)
        {
            var newCommittee = new Committee
            {
                ItecId = cmbItec.SelectedValue != null ? Convert.ToInt32(cmbItec.SelectedValue) : (int?)null,
                CommitteeName = CommitteeNametxt.Text
            };

            try
            {
                CommitteeDL.AddCommittee(newCommittee);
                LoadCommittees();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding committee: {ex.Message}");
            }
        }
        //Update Button
        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;

            int committeeId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["CommitteeId"].Value);

            var updatedCommittee = new Committee
            {
                CommitteeId = committeeId,
                ItecId = cmbItec.SelectedValue != null ? Convert.ToInt32(cmbItec.SelectedValue) : (int?)null,
                CommitteeName = CommitteeNametxt.Text
            };

            try
            {
                CommitteeDL.UpdateCommittee(updatedCommittee);
                LoadCommittees();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating committee: {ex.Message}");
            }
        }
        //Delete Button
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;

            int committeeId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["CommitteeId"].Value);

            try
            {
                CommitteeDL.DeleteCommittee(committeeId);
                LoadCommittees();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting committee: {ex.Message}");
            }
        }
    }
}
