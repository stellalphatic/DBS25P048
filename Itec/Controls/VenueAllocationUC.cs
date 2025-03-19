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
    public partial class VenueAllocationUC : UserControl
    {
        public VenueAllocationUC()
        {
            InitializeComponent();
            LoadVenueAllocations();
            FillComboboxes();
        }
        
        private void LoadVenueAllocations()
        {
            try
            {
                var allocations = VenueAllocationDL.GetAllVenueAllocations();
                dataGridView1.Rows.Clear();

                foreach (var allocation in allocations)
                {
                    dataGridView1.Rows.Add(
                        allocation.VenueAllocationId,
                        allocation.EventId,
                        allocation.VenueId,
                        allocation.AssignedDate.ToShortDateString(),
                        allocation.AssignedTime.ToString()
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading venue allocations: {ex.Message}");
            }
        }

        private void FillComboboxes()
        {
            //Event combobox
            string eventQuery = "SELECT event_id, event_name FROM itec_events";
            DataTable eventData = DatabaseHelper.GetData(eventQuery);
            cmbEvent.DataSource = eventData;
            cmbEvent.DisplayMember = "event_name";
            cmbEvent.ValueMember = "event_id";

            //Venue combobox
            string venueQuery = "SELECT venue_id, venue_name FROM venues";
            DataTable venueData = DatabaseHelper.GetData(venueQuery);
            cmbVenue.DataSource = venueData;
            cmbVenue.DisplayMember = "venue_name";
            cmbVenue.ValueMember = "venue_id";
        }

         
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                cmbEvent.SelectedValue = selectedRow.Cells["Event_id"].Value;
                cmbVenue.SelectedValue = selectedRow.Cells["Venue_id"].Value;
                dtpDate.Value = Convert.ToDateTime(selectedRow.Cells["Assigned_date"].Value);
                dtpTime.Value = DateTime.Today.Add(TimeSpan.Parse(selectedRow.Cells["Assigned_time"].Value.ToString()));
            }
        }
        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {
        }
        private void VenuesBtn_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            VenuesUC venueUC = new VenuesUC();
            MainPanel.Controls.Add(venueUC);
            venueUC.Dock = DockStyle.Fill;
        }
        //Delete button
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;

            int allocationId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Allocation_id"].Value);

            try
            {
                VenueAllocationDL.DeleteVenueAllocation(allocationId);
                LoadVenueAllocations();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting venue allocation: {ex.Message}");
            }
        }
        //Update button
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;

            int allocationId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Allocation_id"].Value);

            var updatedAllocation = new VenueAllocation
            {
                VenueAllocationId = allocationId,
                EventId = Convert.ToInt32(cmbEvent.SelectedValue),
                VenueId = Convert.ToInt32(cmbVenue.SelectedValue),
                AssignedDate = dtpDate.Value,
                AssignedTime = dtpTime.Value.TimeOfDay
            };

            try
            {
                VenueAllocationDL.UpdateVenueAllocation(updatedAllocation);
                LoadVenueAllocations(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating venue allocation: {ex.Message}");
            }
        }
        //Insert button
        private void AddBtn_Click(object sender, EventArgs e)
        {
            var newAllocation = new VenueAllocation
            {
                EventId = Convert.ToInt32(cmbEvent.SelectedValue),
                VenueId = Convert.ToInt32(cmbVenue.SelectedValue),
                AssignedDate = dtpDate.Value,

                AssignedTime = dtpTime.Value.TimeOfDay
            };

            try
            {
                VenueAllocationDL.AddVenueAllocation(newAllocation);
                LoadVenueAllocations();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding venue allocation: {ex.Message}");
            }

        }
    }
}
