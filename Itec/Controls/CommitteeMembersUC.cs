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
using System.Xml.Linq;

namespace Itec.Controls
{
    public partial class CommitteeMembersUC : UserControl
    {
        public CommitteeMembersUC()
        {
            InitializeComponent();
            LoadCommitteeMembers();
            PopulateComboboxes();
        }

        private void LoadCommitteeMembers()
        {
            try
            {
                var members = CommitteeMemberDL.GetAllCommitteeMembers();
                dataGridView1.Rows.Clear();

                foreach (var member in members)
                {
                    dataGridView1.Rows.Add(
                        member.MemberId,
                        member.CommitteeName,
                        member.Name,
                        member.RoleName
                    );
                }
                dataGridView1.Columns["MemberId"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading members: {ex.Message}");
            }
        }

        private void PopulateComboboxes()
        {
            //Committees combobox
            string committeeQuery = "SELECT committee_id, committee_name FROM committees";
            DataTable committeeData = DatabaseHelper.GetData(committeeQuery);
            cmbCommittee.DataSource = committeeData;
            cmbCommittee.DisplayMember = "committee_name";
            cmbCommittee.ValueMember = "committee_id";

            //Roles combobox
            string roleQuery = "SELECT lookup_id, value FROM lookup WHERE category = 'CommitteeRoles'";
            DataTable roleData = DatabaseHelper.GetData(roleQuery);
            cmbRole.DataSource = roleData;
            cmbRole.DisplayMember = "value";
            cmbRole.ValueMember = "lookup_id";
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                cmbCommittee.SelectedValue = selectedRow.Cells["CommitteeId"].Value;
                Nametxt.Text = selectedRow.Cells["Name"].Value.ToString();
                cmbRole.SelectedValue = selectedRow.Cells["RoleId"].Value;
            }
        }


        //COmmittee Members Button
        private void CommitteMembersBtn_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            CommitteeMembersUC com = new CommitteeMembersUC();
            MainPanel.Controls.Add(com);
            com.Dock = DockStyle.Fill;
        }
        //Committee Button
        private void CommitteeBtn_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            CommiteesUC com = new CommiteesUC();
            MainPanel.Controls.Add(com);
            com.Dock = DockStyle.Fill;
        }
        //Insert button
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (cmbCommittee.SelectedValue == null || string.IsNullOrEmpty(Nametxt.Text))
            {
                MessageBox.Show("Please select a committee and enter member name");
                return;
            }

            var newMember = new CommitteeMember
            {
                CommitteeId = Convert.ToInt32(cmbCommittee.SelectedValue),
                Name = Nametxt.Text,
                RoleId = cmbRole.SelectedValue != null ? Convert.ToInt32(cmbRole.SelectedValue) : (int?)null
            };

            try
            {
                CommitteeMemberDL.AddCommitteeMember(newMember);
                LoadCommitteeMembers();
                MessageBox.Show("Member added successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding member: {ex.Message}");
            }
        }
        //Update BUtton
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a member to update");
                return;
            }

            int memberId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["MemberId"].Value);

            var updatedMember = new CommitteeMember
            {
                MemberId = memberId,
                CommitteeId = Convert.ToInt32(cmbCommittee.SelectedValue),
                Name = Nametxt.Text,
                RoleId = cmbRole.SelectedValue != null ? Convert.ToInt32(cmbRole.SelectedValue) : (int?)null
            };

            try
            {
                CommitteeMemberDL.UpdateCommitteeMember(updatedMember);
                LoadCommitteeMembers();
                MessageBox.Show("Member updated successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating member: {ex.Message}");
            }
        }
        //Delete Button
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a member to delete");
                return;
            }

            int memberId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["MemberId"].Value);

            try
            {
                CommitteeMemberDL.DeleteCommitteeMember(memberId);
                LoadCommitteeMembers();
                MessageBox.Show("Member deleted successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting member: {ex.Message}");
            }
        }


    }
}
