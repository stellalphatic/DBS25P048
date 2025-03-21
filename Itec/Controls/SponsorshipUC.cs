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

namespace Itec.Controls
{
    public partial class SponsorshipUC : UserControl
    {
        public SponsorshipUC()
        {
            InitializeComponent();
            LoadSponsors();
        }

        private void LoadSponsors()
        {
            var sponsors = SponsorDL.GetAllSponsors();
            dataGridView1.Rows.Clear();

            foreach (var sponsor in sponsors)
            {
                dataGridView1.Rows.Add(
                    sponsor.SponsorId,
                    sponsor.SponsorName,
                    sponsor.Contact,
                    sponsor.TotalAmount
                );
            }
            dataGridView1.Columns["SponsorId"].Visible = false;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                SponsorNametxt.Text = selectedRow.Cells["SponsorName"].Value.ToString();
                Contacttxt.Text = selectedRow.Cells["Contact"].Value.ToString();
            }
        }

        //Insert button
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SponsorNametxt.Text))
            {
                MessageBox.Show("Please enter sponsor name");
                return;
            }

            var newSponsor = new Sponsor
            {
                SponsorName = SponsorNametxt.Text,
                Contact = Contacttxt.Text
            };

            try
            {
                SponsorDL.AddSponsor(newSponsor);
                LoadSponsors();
                MessageBox.Show("Sponsor added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding sponsor: {ex.Message}");
            }
        }

        //Update Button
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a sponsor to update.");
                return;
            }

            int sponsorId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["SponsorId"].Value);

            var updatedSponsor = new Sponsor
            {
                SponsorId = sponsorId,
                SponsorName = SponsorNametxt.Text,
                Contact = Contacttxt.Text
            };

            try
            {
                SponsorDL.UpdateSponsor(updatedSponsor);
                LoadSponsors();
                MessageBox.Show("Sponsor updated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating sponsor: {ex.Message}");
            }
        }
        //Delete Button
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a sponsor to delete.");
                return;
            }

            int sponsorId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["SponsorId"].Value);

            try
            {
                SponsorDL.DeleteSponsor(sponsorId);
                LoadSponsors();
                MessageBox.Show("Sponsor deleted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting sponsor: {ex.Message}");
            }
        }

    }
}
