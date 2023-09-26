using Program.Business.Repositories;
using Program.DATA.Entities;
using Program.DATA.Enums;
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
    public partial class AddQueue : Form
    {
        public AddQueue(WashingProcess wp)
        {
            InitializeComponent();
        }
        VehicleRepository vehicleRep;
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            int index = 0;
            if (txtSearch.Text == string.Empty) lvCustomers.Items.Clear();
            else
            {
                foreach (Vehicle vehicle in vehicleRep.SearchVehicles(txtSearch.Text))
                {
                    index++;
                    string[] arr = { index.ToString(), vehicle.Customer.Name };
                    ListViewItem lvi = new ListViewItem(arr);
                    lvCustomers.Items.Add(lvi);
                    lvi.Tag = vehicle;
                }
            }
        }
        Vehicle SelectedVehicle;
        private void lvCustomers_Click(object sender, EventArgs e)
        {
            rbExterior.Enabled = true;
            rbFull.Enabled = true;
            rbInterior.Enabled = true;
            rbInterior.Checked = true;

            SelectedVehicle = (Vehicle)lvCustomers.SelectedItems[0].Tag;
            wp.Vehicle = SelectedVehicle;
            wp.VehicleID = SelectedVehicle.ID;
            lblBodyType.Text = "Body Type: " + SelectedVehicle.BodyType.ToString();
            lblBrand.Text = "Brand: " + SelectedVehicle.Brand;
            lblModel.Text = "Model: " + SelectedVehicle.Model;
            lblPrice.Text = "Price: " + vehicleRep.GetPrice(SelectedVehicle, "Interior").ToString();
        }

        private void rbInterior_CheckedChanged(object sender, EventArgs e)
        {
            if (rbInterior.Checked)
            {
                lblPrice.Text = "Price: " + vehicleRep.GetPrice(SelectedVehicle, "Interior").ToString();
                wp.ProcessType= ProcessType.Interior;
            }
                
        }

        private void rbExterior_CheckedChanged(object sender, EventArgs e)
        {
            if (rbExterior.Checked)
            {
                lblPrice.Text = "Price: " + vehicleRep.GetPrice(SelectedVehicle, "Exterior").ToString();
                wp.ProcessType = ProcessType.Exterior;
            }

        }

        private void rbFull_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFull.Checked)
            {
                lblPrice.Text = "Price: " + vehicleRep.GetPrice(SelectedVehicle, "Full").ToString();
                wp.ProcessType = ProcessType.Full;
            }
        }
        WashingProcessRepository wpRep;
        private void btnAddQueue_Click(object sender, EventArgs e)
        {
            wpRep = new WashingProcessRepository(); 
            
            wp.IsQueue = true;
            wpRep.Add(wp);
            DialogResult = DialogResult.OK;
        }
        WashingProcess wp;
        private void AddQueue_Load(object sender, EventArgs e)
        {
            wp = new WashingProcess();
        }
    }
}
