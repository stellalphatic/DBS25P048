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
    public partial class EventsManageUC : UserControl
    {
        public EventsManageUC()
        {
            InitializeComponent();
            LoadEvents();
            PopulateComboboxes();
        }

        private void LoadEvents()
        {
            var events = EventDL.GetAllEvents();
            dataGridView1.Rows.Clear();

            foreach (var ev in events)
            {
                dataGridView1.Rows.Add(
                    ev.EventId,
                    ev.EventName,
                    ev.EventCategoryId,
                    ev.Description,
                    ev.EventDate?.ToString("yyyy-MM-dd"),
                    ev.VenueId,
                    ev.CommitteeId
                );
            }
        }

        private void PopulateComboboxes()
        {
            //Categories combobox
            string categoryQuery = "SELECT event_category_id, category_name FROM event_categories";
            DataTable categoryData = DatabaseHelper.GetData(categoryQuery);
            cmbEventCategory.DataSource = categoryData;
            cmbEventCategory.DisplayMember = "category_name";
            cmbEventCategory.ValueMember = "event_category_id";

            //Venues combobox
            string venueQuery = "SELECT venue_id, venue_name FROM venues";
            DataTable venueData = DatabaseHelper.GetData(venueQuery);
            cmbVenue.DataSource = venueData;
            cmbVenue.DisplayMember = "venue_name";
            cmbVenue.ValueMember = "venue_id";

            //Committees combbox
            string committeeQuery = "SELECT committee_id, committee_name FROM committees";
            DataTable committeeData = DatabaseHelper.GetData(committeeQuery);
            cmbCommittee.DataSource = committeeData;
            cmbCommittee.DisplayMember = "committee_name";
            cmbCommittee.ValueMember = "committee_id";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var newEvent = new Event
            {
                EventName = EventNametxt.Text,
                EventCategoryId = cmbEventCategory.SelectedValue != null ? Convert.ToInt32(cmbEventCategory.SelectedValue) : (int?)null,
                Description = Descriptiontxt.Text,
                EventDate = dtpDate.Value,
                VenueId = cmbVenue.SelectedValue != null ? Convert.ToInt32(cmbCommittee.SelectedValue) : (int?)null,
                CommitteeId = cmbCommittee.SelectedValue != null ? Convert.ToInt32(cmbCommittee.SelectedValue) : (int?)null
            };

            try
            {
                EventDL.AddEvent(newEvent);
                LoadEvents();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding event: {ex.Message}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;

            int eventId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["EventId"].Value);

            var updatedEvent = new Event
            {
                EventId = eventId,
                EventName = EventNametxt.Text,
                EventCategoryId = cmbEventCategory.SelectedValue != null ? Convert.ToInt32(cmbEventCategory.SelectedValue) : (int?)null,
                Description = Descriptiontxt.Text,
                EventDate = dtpDate.Value,
                VenueId = cmbCommittee.SelectedValue != null ? Convert.ToInt32(cmbCommittee.SelectedValue) : (int?)null,
                CommitteeId = cmbCommittee.SelectedValue != null ? Convert.ToInt32(cmbCommittee.SelectedValue) : (int?)null
            };

            try
            {
                EventDL.UpdateEvent(updatedEvent);
                LoadEvents(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating event: {ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;

            int eventId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["EventId"].Value);

            try
            {
                EventDL.DeleteEvent(eventId);
                LoadEvents(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting event: {ex.Message}");
            }
        }
    }
}
