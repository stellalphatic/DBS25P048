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
    public partial class FinancesUC : UserControl
    {
        public FinancesUC()
        {
            InitializeComponent();
            LoadFinances();
            PopulateComboboxes();
        }

        private void LoadFinances()
        {
            var finances = FinanceDL.GetAllFinances();
            dataGridView1.Rows.Clear();

            foreach (var finance in finances)
            {
                dataGridView1.Rows.Add(
                    finance.TransactionId,
                    finance.ItecId,
                    finance.EventId,
                    finance.TypeId,
                    finance.Amount,
                    finance.FromEntityType,
                    finance.FromEntityId,
                    finance.ToEntityType,
                    finance.ToEntityId,
                    finance.Description,
                    finance.DateRecorded.ToString("yyyy-MM-dd HH:mm:ss")
                );
            }
        }

        private void PopulateComboboxes()
        {
            //ITEC Editions
            string itecQuery = "SELECT itec_id, year FROM itec_editions";
            DataTable itecData = DatabaseHelper.GetData(itecQuery);
            cmbItec.DataSource = itecData;
            cmbItec.DisplayMember = "year";
            cmbItec.ValueMember = "itec_id";

            //Events
            string eventQuery = "SELECT event_id, event_name FROM itec_events";
            DataTable eventData = DatabaseHelper.GetData(eventQuery);
            cmbEvent.DataSource = eventData;
            cmbEvent.DisplayMember = "event_name";
            cmbEvent.ValueMember = "event_id";

            //Finance Types 
            string typeQuery = "SELECT lookup_id, value FROM lookup WHERE category = 'FinanceTypes'";
            DataTable typeData = DatabaseHelper.GetData(typeQuery);
            cmbType.DataSource = typeData;
            cmbType.DisplayMember = "value";
            cmbType.ValueMember = "lookup_id";
        }

        //insert
        private void AddBtn_Click(object sender, EventArgs e)
        {
            var newFinance = new Finance
            {
                ItecId = cmbItec.SelectedValue != null ? Convert.ToInt32(cmbItec.SelectedValue) : (int?)null,
                EventId = cmbEvent.SelectedValue != null ? Convert.ToInt32(cmbEvent.SelectedValue) : (int?)null,
                TypeId = cmbType.SelectedValue != null ? Convert.ToInt32(cmbType.SelectedValue) : (int?)null,
                Amount = Convert.ToDecimal(Amounttxt.Text),
                FromEntityType = cmbFromEntityType.SelectedItem.ToString(),
                FromEntityId = Convert.ToInt32(FromEntityIdtxt.Text),
                ToEntityType = cmbToEntityType.SelectedItem.ToString(),
                ToEntityId = Convert.ToInt32(ToEntityIdtxt.Text),
                Description = Descriptiontxt.Text,
                DateRecorded = DateTime.Now
            };

            try
            {
                FinanceDL.AddFinance(newFinance);
                LoadFinances(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding financial transaction: {ex.Message}");
            }
        }
        //Update
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;

            int transactionId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["TransactionId"].Value);

            var updatedFinance = new Finance
            {
                TransactionId = transactionId,
                ItecId = cmbItec.SelectedValue != null ? Convert.ToInt32(cmbItec.SelectedValue) : (int?)null,
                EventId = cmbEvent.SelectedValue != null ? Convert.ToInt32(cmbEvent.SelectedValue) : (int?)null,
                TypeId = cmbType.SelectedValue != null ? Convert.ToInt32(cmbType.SelectedValue) : (int?)null,
                Amount = Convert.ToDecimal(Amounttxt.Text),
                FromEntityType = cmbFromEntityType.SelectedItem.ToString(),
                FromEntityId = Convert.ToInt32(FromEntityIdtxt.Text),
                ToEntityType = cmbToEntityType.SelectedItem.ToString(),
                ToEntityId = Convert.ToInt32(ToEntityIdtxt.Text),
                Description = Descriptiontxt.Text,
                DateRecorded = DateTime.Now
            };

            try
            {
                FinanceDL.UpdateFinance(updatedFinance);
                LoadFinances();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating financial transaction: {ex.Message}");
            }
        }
        //Delete
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;

            int transactionId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["TransactionId"].Value);

            try
            {
                FinanceDL.DeleteFinance(transactionId);
                LoadFinances(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting financial transaction: {ex.Message}");
            }
        }
    }
}
