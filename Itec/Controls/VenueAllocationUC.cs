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

            //dtpTime.Format = DateTimePickerFormat.Time;
            //dtpTime.ShowUpDown = true;
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
                        allocation.EventName,
                        allocation.VenueId,
                        allocation.VenueName,
                        allocation.AssignedDate.ToShortDateString(),
                        allocation.AssignedTime.ToString()
                    );
                }
                dataGridView1.Columns["Allocation_id"].Visible = false;
                dataGridView1.Columns["Venue_id"].Visible = false;
                dataGridView1.Columns["Event_id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading venue allocations: {ex.Message}");
            }
        }

        private void FillComboboxes()
        {
            // Event combobox
            string eventQuery = "SELECT event_id, event_name FROM itec_events";
            DataTable eventData = DatabaseHelper.GetData(eventQuery);
            cmbEvent.DataSource = eventData;
            cmbEvent.DisplayMember = "event_name"; 
            cmbEvent.ValueMember = "event_id";  

            // Venue combobox
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

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (cmbEvent.SelectedValue == null || cmbVenue.SelectedValue == null)
            {
                MessageBox.Show("Please select an event and a venue.");
                return;
            }

            var newAllocation = new VenueAllocation
            {
                EventId = Convert.ToInt32( cmbEvent.SelectedValue),
                VenueId = Convert.ToInt32(cmbVenue.SelectedValue),
                AssignedDate = dtpDate.Value,
                AssignedTime = dtpTime.Value.TimeOfDay
            };

            try
            {
                VenueAllocationDL.AddVenueAllocation(newAllocation);
                LoadVenueAllocations();
                MessageBox.Show("Venue allocation added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding venue allocation: {ex.Message}");
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a venue allocation to update");
                return;
            }

            if (cmbEvent.SelectedItem == null || cmbVenue.SelectedItem == null)
            {
                MessageBox.Show("Please select an event and a venue");
                return;
            }
            DataRowView selectedEvent = cmbEvent.SelectedItem as DataRowView;
            DataRowView selectedVenue = cmbVenue.SelectedItem as DataRowView;

            if (selectedEvent == null || selectedVenue == null)
            {
                MessageBox.Show("Invalid selection.");
                return;
            }

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
                MessageBox.Show("Venue allocation updated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating venue allocation: {ex.Message}");
            }

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a venue allocation to delete.");
                return;
            }

            int allocationId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Allocation_id"].Value);

            try
            {
                VenueAllocationDL.DeleteVenueAllocation(allocationId);
                LoadVenueAllocations();
                MessageBox.Show("Venue allocation deleted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting venue allocation: {ex.Message}");
            }
        }
    }
}
