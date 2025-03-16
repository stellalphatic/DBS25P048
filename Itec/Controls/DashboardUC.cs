using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Itec.DB;
using Itec.DL;

namespace Itec.Controls
{
    public partial class DashboardUC : UserControl
    {
        public DashboardUC()
        {
            InitializeComponent();
            LoadPendingUsers();
            PopulateComboboxes();
        }

        private void LoadPendingUsers()
        {
            try
            {
                var users = UserDL.GetPendingUsers();
                dataGridView1.Rows.Clear();

                foreach (var user in users)
                {
                    dataGridView1.Rows.Add(
                        user.UserId,
                        user.Username,
                        user.Email
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading pending users: {ex.Message}");
            }
        }



        private void PopulateComboboxes()
        {
            //Role combobox
            string roleQuery = "SELECT role_id, role_name FROM roles";
            DataTable roleData = DatabaseHelper.GetData(roleQuery);
            cmbRole.DataSource = roleData;
            cmbRole.DisplayMember = "role_name";
            cmbRole.ValueMember = "role_id";
        }

        private void AssignRollBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user!");
                return;
            }

            int userId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["User_id"].Value);
            MessageBox.Show($"Selected UserId: {userId}");

            int roleId = Convert.ToInt32(cmbRole.SelectedValue);
            MessageBox.Show($"Selected RoleId: {roleId}");

            try
            {
                UserDL.AssignRole(userId, roleId);
                LoadPendingUsers(); // Refresh the list
                MessageBox.Show("Role assigned successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error assigning role: {ex.Message}");
            }
        }
    }
}
