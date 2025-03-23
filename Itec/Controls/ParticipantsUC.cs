using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Itec.BL;
using Itec.DB;
using Itec.DL;

namespace Itec.Controls
{
    public partial class ParticipantsUC : UserControl
    {
        public ParticipantsUC()
        {
            InitializeComponent();
            LoadParticipants();
            PopulateComboboxes();

            // Attach the event handler
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }

        //Loading participants to grid

        private void LoadParticipants()
        {
            try
            {
                var participants = ParticipantsDL.GetAllParticipants();
                dataGridView1.DataSource = participants;

                // Hide unnecessary columns
                dataGridView1.Columns["ParticipantId"].Visible = false;
                dataGridView1.Columns["RoleId"].Visible = false;
                dataGridView1.Columns["ItecId"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }
        }

        //Insert button
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Nametxt.Text) || string.IsNullOrWhiteSpace(Emailtxt.Text))
            {
                MessageBox.Show("Name and Email are required");
                return;
            }

            var newParticipant = new Participant
            {
                ItecId = Convert.ToInt32(cmbItec.SelectedValue),
                Name = Nametxt.Text,
                Email = Emailtxt.Text,
                Contact = Contacttxt.Text,
                Institute = Institutetxt.Text,
                RoleId = Convert.ToInt32(cmbRole.SelectedValue)
            };

            try
            {
                ParticipantsDL.AddParticipant(newParticipant);
                LoadParticipants();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding participant: {ex.Message}");
            }
        }

        //Update button
        private void UpdateBtn_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count == 0) return;

            var selected = (Participant)dataGridView1.SelectedRows[0].DataBoundItem;
            Nametxt.Text = selected.Name;
            Emailtxt.Text = selected.Email;
            Contacttxt.Text = selected.Contact;
            Institutetxt.Text = selected.Institute;

            var selectedRow = dataGridView1.SelectedRows[0];
            int participantId = Convert.ToInt32(selectedRow.Cells["ParticipantId"].Value);

            var updatedParticipant = new Participant
            {
                ParticipantId = participantId,
                ItecId = Convert.ToInt32(cmbItec.SelectedValue),
                Name = Nametxt.Text,
                Email = Emailtxt.Text,
                Contact = Contacttxt.Text,
                Institute = Institutetxt.Text,
                RoleId = Convert.ToInt32(cmbRole.SelectedValue)
            };

            try
            {
                ParticipantsDL.UpdateParticipant(updatedParticipant);
                LoadParticipants();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating participant: {ex.Message}");
            }
        }

        //Delete Button
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;

            var selectedRow = dataGridView1.SelectedRows[0];
            int participantId = Convert.ToInt32(selectedRow.Cells["ParticipantId"].Value);

            if (MessageBox.Show("Delete this participant?", "Confirm",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    ParticipantsDL.DeleteParticipant(participantId);
                    LoadParticipants(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting: {ex.Message}");
                }
            }
        }

        //Showing selected date from grid to textboxes
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    var selected = dataGridView1.SelectedRows[0].DataBoundItem as Participant;

                    if (selected == null)
                    {
                        MessageBox.Show("Selected row does not contain valid participant data.");
                        return;
                    }

                    // Populate the fields
                    Nametxt.Text = selected.Name;
                    Emailtxt.Text = selected.Email;
                    Contacttxt.Text = selected.Contact;
                    Institutetxt.Text = selected.Institute;

                    // Set combobox values
                    cmbItec.SelectedValue = selected.ItecId;
                    cmbRole.SelectedValue = selected.RoleId;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in selection change: {ex.Message}");
            }
        }

        //Clearing textboxes
        private void ClearFields()
        {
            Nametxt.Clear();
            Emailtxt.Clear();
            Contacttxt.Clear();
            Institutetxt.Clear();
        }
        private void PopulateComboboxes()
        {
            //Itec year combobox
            string itecQuery = "SELECT itec_id, year FROM itec_editions";
            DataTable itecData = DatabaseHelper.GetData(itecQuery);
            cmbItec.DataSource = itecData;
            cmbItec.DisplayMember = "year";
            cmbItec.ValueMember = "itec_id";

            //Roles combobox
            string roleQuery = "SELECT role_id, role_name FROM roles";
            DataTable roleData = DatabaseHelper.GetData(roleQuery);
            cmbRole.DataSource = roleData;
            cmbRole.DisplayMember = "role_name";
            cmbRole.ValueMember = "role_id";
        }

        
    }
}
