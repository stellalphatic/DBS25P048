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
    public partial class EventResultsUC : UserControl
    {
        public EventResultsUC()
        {
            InitializeComponent();
            LoadResults();
            PopulateComboboxes();
        }

        private void LoadResults()
        {
            try
            {
                var results = EventResultDL.GetAllResults();
                dataGridView1.Rows.Clear();

                foreach (var r in results)
                {
                    dataGridView1.Rows.Add(
                        r.ResultId,
                        r.EventName,
                        r.ParticipantName,
                        r.TeamName,
                        r.Position,
                        r.Score,
                        r.Remarks
                    );
                }
                dataGridView1.Columns["ResultId"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading results: {ex.Message}");
            }
        }

        private void PopulateComboboxes()
        {
            // Events
            string eventQuery = "SELECT event_id, event_name FROM itec_events";
            cmbEvent.DataSource = DatabaseHelper.GetData(eventQuery);
            cmbEvent.DisplayMember = "event_name";
            cmbEvent.ValueMember = "event_id";

            // Participants
            string participantQuery = "SELECT participant_id, name FROM participants";
            cmbParticipant.DataSource = DatabaseHelper.GetData(participantQuery);
            cmbParticipant.DisplayMember = "name";
            cmbParticipant.ValueMember = "participant_id";

            // Teams
            string teamQuery = "SELECT team_id, team_name FROM teams";
            cmbTeam.DataSource = DatabaseHelper.GetData(teamQuery);
            cmbTeam.DisplayMember = "team_name";
            cmbTeam.ValueMember = "team_id";
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
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                cmbEvent.SelectedValue = GetIdFromName(row.Cells["Event"].Value.ToString(), "event");
                cmbParticipant.SelectedValue = GetIdFromName(row.Cells["Participant"].Value.ToString(), "participant");
                cmbTeam.SelectedValue = GetIdFromName(row.Cells["Team"].Value.ToString(), "team");
                numPosition.Value = Convert.ToInt32(row.Cells["Position"].Value);
                numScore.Value = Convert.ToDecimal(row.Cells["Score"].Value);
                Remarkstxt.Text = row.Cells["Remarks"].Value.ToString();
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            var newResult = new EventResult
            {
                EventId = Convert.ToInt32(cmbEvent.SelectedValue),
                ParticipantId = cmbParticipant.SelectedValue != null ? Convert.ToInt32(cmbParticipant.SelectedValue) : (int?)null,
                TeamId = cmbTeam.SelectedValue != null ? Convert.ToInt32(cmbTeam.SelectedValue) : (int?)null,
                Position = (int)numPosition.Value,
                Score = numScore.Value,
                Remarks = Remarkstxt.Text
            };

            if (newResult.ParticipantId == null && newResult.TeamId == null)
            {
                MessageBox.Show("Please select either participant or team");
                return;
            }

            try
            {
                EventResultDL.AddResult(newResult);
                LoadResults();
                MessageBox.Show("Result added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding result: {ex.Message}");
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a participant to delete");
                return;
            }

            int resultId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ResultId"].Value);

            try
            {
                EventResultDL.DeleteResult(resultId);
                LoadResults();
                MessageBox.Show("Result deleted successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting Result: {ex.Message}");
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Please select a Result to delete");
                return;
            }
            var newResult = new EventResult
            {
                EventId = Convert.ToInt32(cmbEvent.SelectedValue),
                ParticipantId = cmbParticipant.SelectedValue != null ? Convert.ToInt32(cmbParticipant.SelectedValue) : (int?)null,
                TeamId = cmbTeam.SelectedValue != null ? Convert.ToInt32(cmbTeam.SelectedValue) : (int?)null,
                Position = (int)numPosition.Value,
                Score = numScore.Value,
                Remarks = Remarkstxt.Text
            };
            try
            {
                EventResultDL.UpdateResult(newResult);
                LoadResults();
                MessageBox.Show("Result updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating Result: {ex.Message}");
            }
        }
    }
}
