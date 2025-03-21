using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using Itec.Controls;
using Itec.Pages;

namespace Itec
{
    public partial class Dashboard : Form
    {
        Controls.DashboardUC dashboardUC;
        Controls.EditionsUC editionsUC;
        Controls.CommitteeMembersUC committee;
        Controls.FinancesUC financesUC;
        Controls.DutiesUC dutiesUC;
        Controls.ReportUC reportUC;
        Controls.VenuesUC venuesUC;
        Controls.EventsManageUC eventsManageUC;
        Controls.ParticipantsUC participantsUC;
        Reports.MainForm mainReport;
        public Dashboard()
        {
            InitializeComponent();
            dashboardUC = new DashboardUC();
            editionsUC = new EditionsUC();
            committee = new CommitteeMembersUC();
            financesUC = new FinancesUC();
            dutiesUC = new DutiesUC();
            reportUC = new ReportUC();
            venuesUC = new VenuesUC();
            eventsManageUC = new EventsManageUC();
            participantsUC = new ParticipantsUC();
            mainReport= new Reports.MainForm();
        }


        private void Dashboard_Load(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(dashboardUC);
            dashboardUC.Dock = DockStyle.Fill;
        }

        //Navigation buttons
        private void DashboardBtn_Click(object sender, EventArgs e)
        {
          
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(dashboardUC);
            dashboardUC.Dock = DockStyle.Fill;
        }

        private void EventsBtn_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(eventsManageUC);
            eventsManageUC.Dock = DockStyle.Fill;

        }

        private void ParticipantsBtn_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(participantsUC);
            participantsUC.Dock = DockStyle.Fill;
        }

        private void VenuesBtn_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(venuesUC);
            venuesUC.Dock = DockStyle.Fill;
        }

        private void CommiteesBtn_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(committee);
            committee.Dock = DockStyle.Fill;
        }

        private void FinancesBtn_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(financesUC);
            financesUC.Dock = DockStyle.Fill;
        }

        private void DutiesBtn_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(dutiesUC);
            dutiesUC.Dock = DockStyle.Fill;
        }

        private void EditionsBtn_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(editionsUC);
            editionsUC.Dock = DockStyle.Fill;
        }

        private void ReportBtn_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(mainReport);
            mainReport.Dock = DockStyle.Fill;

        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            NavigationHelper.NavigateTo(this, new LoginPage());
        }
        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
