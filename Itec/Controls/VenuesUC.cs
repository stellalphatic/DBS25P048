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
using Itec.DL;
using Itec.Pages;

namespace Itec.Controls
{
    public partial class VenuesUC : UserControl
    {
        public VenuesUC()
        {
            InitializeComponent();
            LoadVenues();
        }

        private void LoadVenues()
        {
            try
            {
                var venues = VenueDL.GetAllVenues();
                dataGridView1.Rows.Clear();
                dataGridView1.Columns["venue_id"].Visible = false;
                foreach (var venue in venues)
                {
                    dataGridView1.Rows.Add(
                        venue.VenueId,
                        venue.VenueName,
                        venue.Capacity,
                        venue.Location
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading venues: {ex.Message}");
            }
        }
        //Setting values of Selected Grid to texboxes
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                VenueNametxt.Text = selectedRow.Cells["VenueName"].Value.ToString();
                Capacitytxt.Text = selectedRow.Cells["Capacity"].Value.ToString();
                Locationtxt.Text = selectedRow.Cells["Location"].Value?.ToString();
            }
        }

        private void ClearFields()
        {
            VenueNametxt.Clear();
            Capacitytxt.Clear();
            Locationtxt.Clear();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Capacitytxt_Click(object sender, EventArgs e)
        {

        }

        private void VenueAllocationBtn_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            VenueAllocationUC venueAllocationUC = new VenueAllocationUC();
            MainPanel.Controls.Add(venueAllocationUC);
            venueAllocationUC.Dock = DockStyle.Fill;
        }

        private void VenuesBtn_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            VenuesUC venueUC = new VenuesUC();
            MainPanel.Controls.Add(venueUC);
            venueUC.Dock = DockStyle.Fill;
        }
        //Insert Button
        private void AddBtn_Click(object sender, EventArgs e)
        {
            var newVenue = new Venue
            {
                VenueName = VenueNametxt.Text,
                Capacity = Convert.ToInt32(Capacitytxt.Text),
                Location = Locationtxt.Text
            };

            try
            {
                VenueDL.AddVenue(newVenue);
                LoadVenues(); 
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding venue: {ex.Message}");
            }
        }
        //Update button
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;

            int venueId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Venue_id"].Value);

            var updatedVenue = new Venue
            {
                VenueId = venueId,
                VenueName = VenueNametxt.Text,
                Capacity = Convert.ToInt32(Capacitytxt.Text),
                Location = Locationtxt.Text
            };

            try
            {
                VenueDL.UpdateVenue(updatedVenue);
                LoadVenues();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating venue: {ex.Message}");
            }
        }
        //Delete Button
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;

            int venueId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Venue_id"].Value);

            try
            {
                VenueDL.DeleteVenue(venueId);
                LoadVenues(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting venue: {ex.Message}");
            }
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
