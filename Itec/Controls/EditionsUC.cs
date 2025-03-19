using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Itec.DL;
using Itec.BL;

namespace Itec.Controls
{
    public partial class EditionsUC : UserControl
    {
        public EditionsUC()
        {
            InitializeComponent();
            LoadEditions();
        }
        //Setting values to dataGridview
        private void LoadEditions()
        {
            var editions = EditionDL.GetAllEditions();
            dataGridView1.Rows.Clear();

            foreach (var edition in editions)
            {
                dataGridView1.Rows.Add(
                    edition.Year,
                    edition.Theme,
                    edition.Description,
                    edition.EventCount,
                    edition.ParticipantCount
                );
            }
        }
        //Insert Button 
        private void AddBtn_Click(object sender, EventArgs e)
        {
            var newEdition = new Edition
            {
                Year = Convert.ToInt32(Yeartxt.Text),
                Theme = Themetxt.Text,
                Description = Descriptiontxt.Text
            };

            try
            {
                EditionDL.AddEdition(newEdition);
                LoadEditions();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding edition: {ex.Message}");
            }
        }


        //Update Button
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;

            //Getting Selected Gridview Edition year
            int selectedYear = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Year"].Value);

            var editions = EditionDL.GetAllEditions();
            var selectedEdition = editions.FirstOrDefault(ed => ed.Year == selectedYear);

            if (selectedEdition == null)
            {
                MessageBox.Show("Selected edition not found.");
                return;
            }

            var updatedEdition = new Edition
            {
                ItecId = selectedEdition.ItecId,
                Year = Convert.ToInt32(Yeartxt.Text),
                Theme = Themetxt.Text,
                Description = Descriptiontxt.Text
            };

            try
            {
                EditionDL.UpdateEdition(updatedEdition);
                LoadEditions();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating edition: {ex.Message}");
            }
        }
        //Delete Button
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;

            //Getting selected Edition value
            int selectedYear = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Year"].Value);

            var editions = EditionDL.GetAllEditions();
            var selectedEdition = editions.FirstOrDefault(ed => ed.Year == selectedYear);

            if (selectedEdition == null)
            {
                MessageBox.Show("Selected edition not found.");
                return;
            }

            try
            {
                EditionDL.DeleteEdition(selectedEdition.ItecId);
                LoadEditions();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting edition: {ex.Message}");
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                int year = Convert.ToInt32(selectedRow.Cells["Year"].Value);
                Yeartxt.Value = new DateTime(year, 1, 1);
                Themetxt.Text = selectedRow.Cells["Theme"].Value.ToString();
                Descriptiontxt.Text = selectedRow.Cells["Description"].Value?.ToString();
            }
        }

      
    }
}
