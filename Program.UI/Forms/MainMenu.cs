using Program.UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program.UI
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

<<<<<<< HEAD
        private void btnCustomers_Click(object sender, EventArgs e)
        {
            AddQueue screen = new AddQueue();
            screen.MdiParent = this;
            screen.Dock = DockStyle.Fill;
            DialogResult result = screen.ShowDialog();

            if(result == DialogResult.OK)
            {
                //Yıkama sırası listesini yenile
            }
=======
        private void MainMenu_Load(object sender, EventArgs e)
        {
            DashboardShow();
        }

        private void DashboardShow()
        {
            Dashboard dashboard = new Dashboard();
            dashboard.MdiParent = this;
            dashboard.Dock = DockStyle.Fill;
            dashboard.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.ActiveMdiChild.Close();
            DashboardShow();
        }

        private void btnVehicles_Click(object sender, EventArgs e)
        {
            Vehicles vehicles = new Vehicles();
            vehicles.MdiParent = this;
            vehicles.Dock = DockStyle.Fill;
            vehicles.Show();
>>>>>>> 25ee217c098466a4cf32a25c2a6c7e310e6db05d
        }
    }
}
