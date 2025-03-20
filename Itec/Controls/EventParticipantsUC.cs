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
    public partial class EventParticipantsUC : UserControl
    {
        public EventParticipantsUC()
        {
            InitializeComponent();
            LoadParticipants();
            PopulateComboboxes();
        }

        private void LoadParticipants()
        {
            try
            {
                var participants = EventParticipantDL.GetAllParticipants();
                dataGridView1.Rows.Clear();

                foreach (var p in participants)
                {
                    dataGridView1.Rows.Add(
                        p.RegistrationId,
                        p.EventName,
                        p.ParticipantName,
                        p.PaymentStatus,
                        p.FeeAmount.ToString("C")
                    );
                }
                dataGridView1.Columns["RegistrationId"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading participants: {ex.Message}");
            }
        }

        private void PopulateComboboxes()
        {
            //Events combobox
            string eventQuery = "SELECT event_id, event_name FROM itec_events";
            DataTable eventData = DatabaseHelper.GetData(eventQuery);
            cmbEvent.DataSource = eventData;
            cmbEvent.DisplayMember = "event_name";
            cmbEvent.ValueMember = "event_id";

            //Participants xombobox
            string participantQuery = "SELECT participant_id, name FROM participants";
            DataTable participantData = DatabaseHelper.GetData(participantQuery);
            cmbParticipant.DataSource = participantData;
            cmbParticipant.DisplayMember = "name";
            cmbParticipant.ValueMember = "participant_id";

            //Payment Statuses combobox
            string statusQuery = "SELECT lookup_id, value FROM lookup WHERE category = 'PaymentStatus'";
            DataTable statusData = DatabaseHelper.GetData(statusQuery);
            cmbStatus.DataSource = statusData;
            cmbStatus.DisplayMember = "value";
            cmbStatus.ValueMember = "lookup_id";
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                cmbEvent.SelectedValue = GetIdFromName(row.Cells["Event"].Value.ToString(), "event");
                cmbParticipant.SelectedValue = GetIdFromName(row.Cells["Participant"].Value.ToString(), "participant");
                cmbStatus.SelectedValue = GetIdFromName(row.Cells["PaymentStatus"].Value.ToString(), "PaymentStatus");
                FeeAmounttxt.Text = row.Cells["FeeAmount"].Value.ToString().Replace("$", "");
            }
        }

        private int GetIdFromName(string name, string type)
        {
            string query = type switch
            {
                "event" => $"SELECT event_id FROM itec_events WHERE event_name = '{name}'",
                "participant" => $"SELECT participant_id FROM participants WHERE name = '{name}'",
                "PaymentStatus" => $"SELECT lookup_id FROM lookup WHERE value = '{name}'",
                _ => ""
            };

            DataTable dt = DatabaseHelper.GetData(query);
            return dt.Rows.Count > 0 ? Convert.ToInt32(dt.Rows[0][0]) : 0;
        }



        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (cmbEvent.SelectedValue == null || cmbParticipant.SelectedValue == null)
            {
                MessageBox.Show("Please select event and participant");
                return;
            }

            var newParticipant = new EventParticipant
            {
                EventId = Convert.ToInt32(cmbEvent.SelectedValue),
                ParticipantId = Convert.ToInt32(cmbParticipant.SelectedValue),
                PaymentStatusId = Convert.ToInt32(cmbStatus.SelectedValue),
                FeeAmount = decimal.Parse(FeeAmounttxt.Text)
            };

            try
            {
                EventParticipantDL.AddParticipant(newParticipant);
                LoadParticipants();
                MessageBox.Show("Participant added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding participant: {ex.Message}");
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a participant to update");
                return;
            }

            int registrationId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["RegistrationId"].Value);

            var updatedParticipant = new EventParticipant
            {
                RegistrationId = registrationId,
                EventId = Convert.ToInt32(cmbEvent.SelectedValue),
                ParticipantId = Convert.ToInt32(cmbParticipant.SelectedValue),
                PaymentStatusId = Convert.ToInt32(cmbStatus.SelectedValue),
                FeeAmount = decimal.Parse(FeeAmounttxt.Text)
            };

            try
            {
                EventParticipantDL.UpdateParticipant(updatedParticipant);
                LoadParticipants();
                MessageBox.Show("Participant updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating participant: {ex.Message}");
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a participant to delete");
                return;
            }

            int registrationId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["RegistrationId"].Value);

            try
            {
                EventParticipantDL.DeleteParticipant(registrationId);
                LoadParticipants();
                MessageBox.Show("Participant deleted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting participant: {ex.Message}");
            }
        }
    }
}
