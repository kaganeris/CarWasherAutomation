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
        #region Design Codes
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (e.Clicks == 1 && e.Y <= this.Height && e.Y >= 0)
                {
                    ReleaseCapture();
                    SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            }
        }
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]

        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]

        private static extern bool ReleaseCapture();

        #endregion
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


        private void btnWasherStatus_Click(object sender, EventArgs e)
        {
            WasherStatusLoad();
        }

        private void btnAddQueue_Click(object sender, EventArgs e)
        {
            this.ActiveMdiChild.Close();
            AddQueue addQueue = new AddQueue(this);
            addQueue.MdiParent = this;
            addQueue.Dock = DockStyle.Fill;
            addQueue.Show();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            this.ActiveMdiChild.Close();
            NewVehicle newVehicle = new NewVehicle();
            newVehicle.MdiParent = this;
            newVehicle.Dock = DockStyle.Fill;
            newVehicle.Show();
        }
        public void WasherStatusLoad()
        {
            Vehicles vehicles = new Vehicles();
            vehicles.MdiParent = this;
            vehicles.Dock = DockStyle.Fill;
            vehicles.Show();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            this.ActiveMdiChild.Close();
            Employees employees = new Employees();
            employees.MdiParent = this;
            employees.Dock = DockStyle.Fill;
            employees.Show();
        }

        private void btnMaterialStock_Click(object sender, EventArgs e)
        {
            this.ActiveMdiChild.Close();
            Stock stock = new Stock();
            stock.MdiParent = this;
            stock.Dock = DockStyle.Fill;
            stock.Show();
        }
    }
}
