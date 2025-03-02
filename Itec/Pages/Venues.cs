using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Itec.Pages
{
    public partial class Venues : Form
    {
        public Venues()
        {
            InitializeComponent();
        }

        private void Venues_Load(object sender, EventArgs e)
        {

        }
        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            Form Dashboard= new Dashboard();
            Dashboard.Show();
            this.Close();
        }

        private void CommiteesBtn_Click(object sender, EventArgs e)
        {
            Form Commitees = new Commitees();
            Commitees.Show();
            this.Close();
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
