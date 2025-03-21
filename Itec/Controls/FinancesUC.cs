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
            LoadTransactions();
            InitializeComboboxes();

        }
        private void LoadTransactions()
        {
            try
            {
                var transactions = FinancialDL.GetAllTransactions();
                dataGridView1.Rows.Clear();

                foreach (var t in transactions)
                {
                    dataGridView1.Rows.Add(
                        t.TransactionId,
                        t.ITECYear,
                        t.EventName,
                        t.FinanceType,
                        t.Amount.ToString("C"),
                        $"{t.FromEntityType}: {t.FromEntityName}",
                        $"{t.ToEntityType}: {t.ToEntityName}",
                        t.Description,
                        t.DateRecorded.ToString("yyyy-MM-dd")
                    );
                }
                dataGridView1.Columns["TransactionId"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading transactions: {ex.Message}");
            }
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];

                //Populate all fields
                cmbItec.SelectedValue = GetITECIdFromYear(row.Cells["ITECYear"].Value.ToString());
                cmbType.SelectedValue = GetTypeIdFromName(row.Cells["FinanceType"].Value.ToString());
                Amounttxt.Text = row.Cells["Amount"].Value.ToString().Replace("$", "").Trim();

                //Handle From Entity
                var fromParts = row.Cells["FromEntity"].Value.ToString().Split(':');
                cmbFromEntityType.SelectedItem = fromParts[0].Trim();
                LoadEntityCombobox(cmbFromEntity, fromParts[0].Trim());
                cmbFromEntity.SelectedValue = GetEntityId(fromParts[0].Trim(), fromParts[1].Trim());

                //Handle To Entity
                var toParts = row.Cells["ToEntity"].Value.ToString().Split(':');
                cmbToEntityType.SelectedItem = toParts[0].Trim();
                LoadEntityCombobox(cmbToEntity, toParts[0].Trim());
                cmbToEntity.SelectedValue = GetEntityId(toParts[0].Trim(), toParts[1].Trim());

                Descriptiontxt.Text = row.Cells["Description"].Value.ToString();
                dtpDate.Value = DateTime.Parse(row.Cells["DateRecorded"].Value.ToString());
            }
        }
        private int GetITECIdFromYear(string year)
        {
            DataTable dt = DatabaseHelper.GetData(
                $"SELECT itec_id FROM itec_editions WHERE year = '{year}'");
            return dt.Rows.Count > 0 ? Convert.ToInt32(dt.Rows[0][0]) : -1;
        }
        private int GetEntityId(string entityType, string entityName)
        {
            string query = entityType switch
            {
                "Sponsor" => $"SELECT sponsor_id FROM sponsors WHERE sponsor_name = '{entityName}'",
                "User" => $"SELECT user_id FROM users WHERE username = '{entityName}'",
                "Committee" => $"SELECT committee_id FROM committees WHERE committee_name = '{entityName}'",
                "Vendor" => $"SELECT vendor_id FROM vendors WHERE vendor_name = '{entityName}'",
                _ => ""
            };

            DataTable dt = DatabaseHelper.GetData(query);
            return dt.Rows.Count > 0 ? Convert.ToInt32(dt.Rows[0][0]) : -1;
        }
        private int GetTypeIdFromName(string typeName)
        {
            DataTable dt = DatabaseHelper.GetData(
                $"SELECT lookup_id FROM lookup WHERE value = '{typeName}'");
            return dt.Rows.Count > 0 ? Convert.ToInt32(dt.Rows[0][0]) : -1;
        }

        private void InitializeComboboxes()
        {
            //Entity Type comboboxes
            cmbFromEntityType.Items.AddRange(new[] { "Sponsor", "User", "Committee", "Vendor" });
            cmbToEntityType.Items.AddRange(new[] { "Sponsor", "User", "Committee", "Vendor" });

            //Financial Types
            cmbType.DataSource = DatabaseHelper.GetData(
                "SELECT lookup_id, value FROM lookup WHERE category = 'FinanceTypes'");
            cmbType.DisplayMember = "value";
            cmbType.ValueMember = "lookup_id";

            //ITEC Editions
            cmbItec.DataSource = DatabaseHelper.GetData("SELECT itec_id, year FROM itec_editions");
            cmbItec.DisplayMember = "year";
            cmbItec.ValueMember = "itec_id";

            //Events
            cmbEvent.DataSource = DatabaseHelper.GetData("SELECT event_id, event_name FROM itec_events");
            cmbEvent.DisplayMember = "event_name";
            cmbEvent.ValueMember = "event_id";
        }

        private void cmbFromEntityType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadEntityCombobox(cmbFromEntity, cmbFromEntityType.Text);
        }

        private void cmbToEntityType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadEntityCombobox(cmbToEntity, cmbToEntityType.Text);
        }

        // Dynamic Entity Loading using Switch Expression (Refactored) 
        private void LoadEntityCombobox(ComboBox cb, string entityType)
        {
            if (string.IsNullOrEmpty(entityType))
            {
                cb.DataSource = null;
                return;
            }

            string query = entityType switch
            {
                "Sponsor" => "SELECT sponsor_id AS ID, sponsor_name AS Name FROM sponsors",
                "User" => "SELECT user_id AS ID, username AS Name FROM users",
                "Committee" => "SELECT committee_id AS ID, committee_name AS Name FROM committees",
                "Vendor" => "SELECT vendor_id AS ID, vendor_name AS Name FROM vendors",
                _ => ""
            };

            if (!string.IsNullOrEmpty(query))
            {
                var dt = DatabaseHelper.GetData(query);
                cb.DisplayMember = "Name";  
                cb.ValueMember = "ID";      
                cb.DataSource = dt;

                // Add empty item if no records
                if (dt.Rows.Count == 0)
                    cb.Items.Add("No records found");
            }
        }



        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Descriptiontxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void GenerateReportBtn_Click(object sender, EventArgs e)
        {
            if (cmbItec.SelectedValue == null)
            {
                MessageBox.Show("Please select an ITEC edition");
                return;
            }

            int itecId = Convert.ToInt32(cmbItec.SelectedValue);
            DataTable report = FinancialDL.GetBudgetReport(itecId);

            if (report.Rows.Count > 0)
            {
                decimal income = report.Rows[0]["TotalIncome"] == DBNull.Value ? 0 : Convert.ToDecimal(report.Rows[0]["TotalIncome"]);
                decimal expenses = report.Rows[0]["TotalExpenses"] == DBNull.Value ? 0 : Convert.ToDecimal(report.Rows[0]["TotalExpenses"]);
                decimal balance = income - expenses;

                Incomelbl.Text = income.ToString("C");
                Expenseslbl.Text = expenses.ToString("C");
                Balancelbl.Text = balance.ToString("C");
                Balancelbl.ForeColor = balance >= 0 ? Color.Green : Color.Red;
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            var transaction = new Finance
            {
                ITECId = Convert.ToInt32(cmbItec.SelectedValue),
                EventId = cmbEvent.SelectedValue != null ? Convert.ToInt32(cmbEvent.SelectedValue) : (int?)null,
                TypeId = Convert.ToInt32(cmbType.SelectedValue),
                Amount = Amounttxt.Value,
                FromEntityType = cmbFromEntityType.Text,
                FromEntityId = Convert.ToInt32(cmbFromEntity.SelectedValue),
                ToEntityType = cmbToEntityType.Text,
                ToEntityId = Convert.ToInt32(cmbToEntity.SelectedValue),
                Description = Descriptiontxt.Text,
                DateRecorded = dtpDate.Value
            };

            try
            {
                FinancialDL.AddTransaction(transaction);
                LoadTransactions();
                MessageBox.Show("Transaction added successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;

            int transactionId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["TransactionId"].Value);

            try
            {
                FinancialDL.DeleteTransaction(transactionId);
                LoadTransactions();
                MessageBox.Show("Transaction deleted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting: {ex.Message}");
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a transaction to update");
                return;
            }


            var transaction = new Finance
            {
                TransactionId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["TransactionId"].Value),
                ITECId = Convert.ToInt32(cmbItec.SelectedValue),
                EventId = cmbEvent.SelectedValue != null ? Convert.ToInt32(cmbEvent.SelectedValue) : (int?)null,
                TypeId = Convert.ToInt32(cmbType.SelectedValue),
                Amount = decimal.Parse(Amounttxt.Text),
                FromEntityType = cmbFromEntityType.Text,
                FromEntityId = Convert.ToInt32(cmbFromEntity.SelectedValue),
                ToEntityType = cmbToEntityType.Text,
                ToEntityId = Convert.ToInt32(cmbToEntity.SelectedValue),
                Description = Descriptiontxt.Text,
                DateRecorded = dtpDate.Value
            };

            try
            {
                FinancialDL.UpdateTransaction(transaction);
                LoadTransactions();
                MessageBox.Show("Transaction updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating transaction: {ex.Message}");
            }
        }

        private void SponsorsBtn_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            SponsorshipUC spon = new SponsorshipUC();
            MainPanel.Controls.Add(spon);
            spon.Dock = DockStyle.Fill;
        }

        private void FinancesBtn_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            FinancesUC spon = new FinancesUC();
            MainPanel.Controls.Add(spon);
            spon.Dock = DockStyle.Fill;
        }
    }
}
