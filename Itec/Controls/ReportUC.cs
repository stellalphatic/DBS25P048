using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using iTextSharp.text;
using System.IO;
using System.Drawing.Printing;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using Itec.DB;
using Itec.DL;
public enum ReportType { Financial, Venue, Event }


namespace Itec.Controls
{

    public partial class ReportUC : UserControl
    {
        public ReportUC()
        {
            InitializeComponent();
            InitializeReportTypes();
            LoadEditions();
        }

        private void InitializeReportTypes()
        {
            cmbReport.Items.AddRange(Enum.GetNames(typeof(ReportType)));
            cmbReport.SelectedIndex = 0;
        }
        private void LoadEditions()
        {
            var editions = DatabaseHelper.GetData("SELECT DISTINCT year FROM itec_editions ORDER BY year DESC");
            cmbItecEditions.DataSource = editions;
            cmbItecEditions.DisplayMember = "year";
            cmbItecEditions.ValueMember = "year";
        }

        
        #region Printing Logic
        private void PrintDataGridView(object sender, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(dgvReport.Width, dgvReport.Height);
            dgvReport.DrawToBitmap(bm, new System.Drawing.Rectangle(0, 0, dgvReport.Width, dgvReport.Height));
            e.Graphics.DrawImage(bm, e.MarginBounds);
        }
        #endregion

        private void btnLoad_Click(object sender, EventArgs e)
        {
            var selectedYear = cmbItecEditions.SelectedValue?.ToString();
            var reportType = (ReportType)cmbReport.SelectedIndex;

            // Validate selections
            if (string.IsNullOrEmpty(selectedYear))
            {
                MessageBox.Show("Please select an edition year");
                return;
            }

            dgvReport.DataSource = ReportManager.GetReportData(reportType, selectedYear);
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dgvReport.Rows.Count == 0)
            {
                MessageBox.Show("No data to print!");
                return;
            }

            using (PrintDocument pd = new PrintDocument())
            {
                pd.PrintPage += (s, args) =>
                {
                    Bitmap bm = new Bitmap(dgvReport.Width, dgvReport.Height);
                    dgvReport.DrawToBitmap(bm, new System.Drawing.Rectangle(0, 0, dgvReport.Width, dgvReport.Height));
                    args.Graphics.DrawImage(bm, args.MarginBounds);
                };

                using (PrintDialog printDialog = new PrintDialog { Document = pd })
                {
                    if (printDialog.ShowDialog() == DialogResult.OK)
                    {
                        pd.Print();
                    }
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            var reportType = (ReportType)cmbReport.SelectedIndex;
            var allData = ReportManager.GetFullReportData(reportType);

            using (var sfd = new SaveFileDialog { Filter = "PDF Files|*.pdf" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    PdfReportExporter.ExportReport(reportType, allData, sfd.FileName);
                    MessageBox.Show("Report exported successfully!");
                }
            }
        }
        public static class PdfReportExporter
        {
            public static void ExportReport(ReportType type, DataTable data, string filePath)
            {
                using (var doc = new Document(PageSize.A4.Rotate()))
                {
                    PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
                    doc.Open();

                    AddMainHeader(doc, type.ToString());

                    var groupedData = type switch
                    {
                        ReportType.Financial => data.AsEnumerable().GroupBy(r => r["Year"]),
                        ReportType.Venue => data.AsEnumerable().GroupBy(r => r["Venue"]),
                        ReportType.Event => data.AsEnumerable().GroupBy(r => r["Event"]),
                        _ => throw new ArgumentException("Invalid report type")
                    };

                    foreach (var group in groupedData)
                    {
                        AddReportSection(doc, type, group.Key.ToString(), group.CopyToDataTable());
                    }

                    doc.Close();
                }
            }

            private static void AddMainHeader(Document doc, string reportType)
            {
                var header = new Paragraph($"FULL {reportType.ToUpper()} REPORT",
                    FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16))
                {
                    Alignment = Element.ALIGN_CENTER,
                    SpacingAfter = 20
                };
                doc.Add(header);
            }

            private static void AddReportSection(Document doc, ReportType type, string sectionTitle, DataTable sectionData)
            {
                AddSectionHeader(doc, sectionTitle);

                switch (type)
                {
                    case ReportType.Financial:
                        AddFinancialTable(doc, sectionData);
                        break;
                    case ReportType.Venue:
                        AddVenueTable(doc, sectionData);
                        break;
                    case ReportType.Event:
                        AddEventTable(doc, sectionData);
                        break;
                }

                doc.Add(new Paragraph(" "));
            }

            private static void AddSectionHeader(Document doc, string title)
            {
                var header = new Paragraph(title,
                    FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12))
                {
                    SpacingBefore = 15f,
                    SpacingAfter = 10f
                };
                doc.Add(header);
            }

            #region Table Generators
            private static void AddFinancialTable(Document doc, DataTable data)
            {
                // Main transaction table
                var table = new PdfPTable(6) { WidthPercentage = 100 };
                table.SetWidths(new[] { 2f, 2f, 2f, 3f, 3f, 4f });

                AddTableHeader(table, "TransactionType");
                AddTableHeader(table, "Amount");
                AddTableHeader(table, "Date");
                AddTableHeader(table, "From");
                AddTableHeader(table, "To");
                AddTableHeader(table, "Description");

                foreach (DataRow row in data.Rows)
                {
                    AddTableCell(table, row["TransactionType"].ToString());
                    AddTableCell(table, row["Amount"].ToString());
                    AddTableCell(table, row["TransactionDate"].ToString());
                    AddTableCell(table, row["FromEntity"].ToString());
                    AddTableCell(table, row["ToEntity"].ToString());
                    AddTableCell(table, row["Description"].ToString());
                }

                doc.Add(table);
                AddFinancialTotals(doc, data);
            }

            private static void AddVenueTable(Document doc, DataTable data)
            {
                var table = new PdfPTable(6) { WidthPercentage = 100 };  // Added Year column
                table.SetWidths(new[] { 2f, 3f, 2f, 2f, 2f, 3f });

                AddTableHeader(table, "Year");
                AddTableHeader(table, "Venue");
                AddTableHeader(table, "Capacity");
                AddTableHeader(table, "Date");
                AddTableHeader(table, "Time");
                AddTableHeader(table, "Event");

                foreach (DataRow row in data.Rows)
                {
                    AddTableCell(table, row["Year"].ToString());
                    AddTableCell(table, row["Venue"].ToString());         // Changed from venue_name
                    AddTableCell(table, row["Capacity"].ToString());      // Changed from capacity
                    AddTableCell(table, row["AssignmentDate"].ToString());// Changed from assigned_date
                    AddTableCell(table, row["AssignmentTime"].ToString());// Changed from assigned_time
                    AddTableCell(table, row["AssignedEvent"].ToString()); // Changed from event_name
                }

                doc.Add(table);
            }

            private static void AddEventTable(Document doc, DataTable data)
            {
                var table = new PdfPTable(6) { WidthPercentage = 100 };  // Changed to 6 columns
                table.SetWidths(new[] { 3f, 2f, 2f, 3f, 2f, 2f });  //Adjusted widths

                AddTableHeader(table, "Event");
                AddTableHeader(table, "Category");
                AddTableHeader(table, "Date");
                AddTableHeader(table, "Committee");
                AddTableHeader(table, "Venue");
                AddTableHeader(table, "Participants");

                foreach (DataRow row in data.Rows)
                {
                    AddTableCell(table, row["Event"].ToString());
                    AddTableCell(table, row["Category"].ToString());
                    AddTableCell(table, row["EventDate"].ToString());
                    AddTableCell(table, row["ResponsibleCommittee"].ToString());  // Changed from committee_id
                    AddTableCell(table, row["Venue"].ToString());
                    AddTableCell(table, row["ParticipantsRegistered"].ToString());
                }

                doc.Add(table);
            }
            #endregion

            #region Helper Methods
            private static void AddTableHeader(PdfPTable table, string text)
            {
                table.AddCell(new Phrase(text, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10)));
            }

            private static void AddTableCell(PdfPTable table, string text)
            {
                table.AddCell(new Phrase(text, FontFactory.GetFont(FontFactory.HELVETICA, 10)));
            }

            private static void AddFinancialTotals(Document doc, DataTable data)
            {
                try
                {
                    // Group by TransactionType and FinancialCategory
                    var incomeGroups = data.AsEnumerable()
                        .Where(r => r.Field<string>("FinancialCategory") == "Income")
                        .GroupBy(r => r.Field<string>("TransactionType"))
                        .Select(g => new { Type = g.Key, Total = g.Sum(r => r.Field<decimal>("Amount")) });

                    var expenseGroups = data.AsEnumerable()
                        .Where(r => r.Field<string>("FinancialCategory") == "Expense")
                        .GroupBy(r => r.Field<string>("TransactionType"))
                        .Select(g => new { Type = g.Key, Total = g.Sum(r => r.Field<decimal>("Amount")) });

                    // Add Income Breakdown
                    doc.Add(new Paragraph("Income Breakdown:"));
                    foreach (var group in incomeGroups)
                    {
                        doc.Add(new Paragraph($"{group.Type}: {group.Total.ToString("N2")}"));
                    }

                    // Add Expense Breakdown
                    doc.Add(new Paragraph("\nExpense Breakdown:"));
                    foreach (var group in expenseGroups)
                    {
                        doc.Add(new Paragraph($"{group.Type}: {group.Total.ToString("N2")}"));
                    }

                    //Calculate Totals
                    decimal totalIncome = incomeGroups.Sum(g => g.Total);
                    decimal totalExpenses = expenseGroups.Sum(g => g.Total);

                    //Totals Table
                    var totalsTable = new PdfPTable(2)
                    {
                        WidthPercentage = 50,
                        SpacingBefore = 15f,
                        HorizontalAlignment = Element.ALIGN_RIGHT
                    };

                    AddTotalRow(totalsTable, "Total Income:", totalIncome);
                    AddTotalRow(totalsTable, "Total Expenses:", totalExpenses);
                    AddTotalRow(totalsTable, "Net Balance:", totalIncome - totalExpenses);

                    doc.Add(totalsTable);
                }
                catch (Exception ex)
                {
                    doc.Add(new Paragraph($"Error generating totals: {ex.Message}"));
                }
            }

            private static void AddTotalRow(PdfPTable table, string label, decimal value)
            {
                table.AddCell(new Phrase(label, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10)));
                table.AddCell(new Phrase(value.ToString("N2"), FontFactory.GetFont(FontFactory.HELVETICA, 10)));
            }
            #endregion
        }
    }
        
}
    



