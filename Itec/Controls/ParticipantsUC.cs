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
using Itec.DL;

namespace Itec.Controls
{
    public partial class ParticipantsUC : UserControl
    {
        public ParticipantsUC()
        {
            InitializeComponent();
            LoadParticipants();
        }

        // Load participants into DataGridView
        private void LoadParticipants()
        {
            try
            {
                var participants = ParticipantsDL.GetAllParticipants();
                dataGridView1.DataSource = participants;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }
        }

        // Add a new participant
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Nametxt.Text) || string.IsNullOrWhiteSpace(Emailtxt.Text))
            {
                MessageBox.Show("Name and Email are required!");
                return;
            }

            var newParticipant = new Participant
            {
                Name = Nametxt.Text,
                Email = Emailtxt.Text,
                Contact = Contacttxt.Text,
                Institute = Institutetxt.Text
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

        // Update selected participant
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;

            var selected = (Participant)dataGridView1.SelectedRows[0].DataBoundItem;

            if (string.IsNullOrWhiteSpace(Nametxt.Text) || string.IsNullOrWhiteSpace(Emailtxt.Text))
            {
                MessageBox.Show("Name and Email are required!");
                return;
            }

            selected.Name = Nametxt.Text;
            selected.Email = Emailtxt.Text;
            selected.Contact = Contacttxt.Text;
            selected.Institute = Institutetxt.Text;

            try
            {
                ParticipantsDL.UpdateParticipant(selected);
                LoadParticipants();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating participant: {ex.Message}");
            }
        }

        // Delete selected participant
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;

            var selected = (Participant)dataGridView1.SelectedRows[0].DataBoundItem;

            if (MessageBox.Show("Delete this participant?", "Confirm",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    ParticipantsDL.DeleteParticipant(selected.ParticipantId);
                    LoadParticipants();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting: {ex.Message}");
                }
            }
        }

        // Show selected participant data in textboxes
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selected = (Participant)dataGridView1.SelectedRows[0].DataBoundItem;
                Nametxt.Text = selected.Name;
                Emailtxt.Text = selected.Email;
                Contacttxt.Text = selected.Contact;
                Institutetxt.Text = selected.Institute;
            }
        }

        // Clear input fields
        private void ClearFields()
        {
            Nametxt.Clear();
            Emailtxt.Clear();
            Contacttxt.Clear();
            Institutetxt.Clear();
        }
    }
}
