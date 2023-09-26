using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program.UI.Forms
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            DashboardShow();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.ActiveMdiChild.Close();
            DashboardShow();
        }
        public void DashboardShow()
        {
            Dashboard dashboard = new Dashboard();
            dashboard.MdiParent = this;
            dashboard.Dock = DockStyle.Fill;
            dashboard.Show();
        }

        private void btnVehicles_Click(object sender, EventArgs e)
        {
            Vehicles vehicles = new Vehicles();
            vehicles.MdiParent = this;
            vehicles.Dock = DockStyle.Fill;
            vehicles.Show();
        }
    }
}
