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
using Itec.Pages;

namespace Itec
{
    public partial class Dashboard : Form
    {

        public Dashboard()
        {
            InitializeComponent();
        }


        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            Form dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void CommiteesBtn_Click(object sender, EventArgs e)
        {
            Form commitees = new Commitees();
            commitees.Show();
            this.Hide();
        }

        private void VenuesBtn_Click(object sender, EventArgs e)
        {
            NavigationHelper.NavigateTo(this, new Venues());
        }

        private void ReportBtn_Click(object sender, EventArgs e)
        {
            NavigationHelper.NavigateTo(this, new Report());
        }

        private void FinancesBtn_Click(object sender, EventArgs e)
        {
            NavigationHelper.NavigateTo(this, new Finances());
        }

        private void ParticipantsBtn_Click(object sender, EventArgs e)
        {
            NavigationHelper.NavigateTo(this, new Participants());
        }

        private void EventsBtn_Click(object sender, EventArgs e)
        {
            NavigationHelper.NavigateTo(this, new EventsManage());
        }

        private void EditionsBtn_Click(object sender, EventArgs e)
        {
            NavigationHelper.NavigateTo(this, new Editions());
        }

        private void DutiesBtn_Click(object sender, EventArgs e)
        {
            NavigationHelper.NavigateTo(this, new Duties());
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
