using Program.Business.Repositories;
using Program.DATA.Entities;
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
        public AddQueue()
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
            rbInterior.Checked=true;

            SelectedVehicle = (Vehicle)lvCustomers.SelectedItems[0].Tag;
            lblBodyType.Text = "Body Type: " + SelectedVehicle.BodyType.ToString();
            lblBrand.Text = "Brand: " + SelectedVehicle.Brand;
            lblModel.Text = "Model: " + SelectedVehicle.Model;
            lblPrice.Text = "Price: " + vehicleRep.GetPrice(SelectedVehicle, "Interior");
        }

    }
}
