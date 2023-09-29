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

        public AddQueue(MainMenu _anaform)
        {
            anaform = _anaform;
            InitializeComponent();
        }
        MainMenu anaform;
        VehicleRepository vehicleRep;
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            vehicleRep = new VehicleRepository();
            lvCustomers.Items.Clear();
            int index = 0;
            if (txtSearch.Text != string.Empty && vehicleRep.SearchVehicles(VehicleList, txtSearch.Text).Count > 0)
            {
                foreach (Vehicle vehicle in vehicleRep.SearchVehicles(VehicleList, txtSearch.Text))
                {
                    index++;
                    string[] arr = { index.ToString(), vehicle.Customer.Name, vehicle.Plate, vehicle.BodyType.ToString() };
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
            wp.VehicleID = SelectedVehicle.ID;
            lblBodyType.Text = "Body Type: " + SelectedVehicle.BodyType.ToString();
            lblBrand.Text = "Brand: " + SelectedVehicle.Brand;
            lblPlate.Text = "Plate: " + SelectedVehicle.Plate;
            lblModel.Text = "Model: " + SelectedVehicle.Model;
            lblPrice.Text = "Price: " + vehicleRep.GetPrice(SelectedVehicle, "Interior").ToString();
            lblDiscount.Text = "Discount: " +vehicleRep.GetDiscount(SelectedVehicle.Customer).ToString();
            lblSubs.Text = "Subscription: " + SelectedVehicle.Customer.SubscribeType.ToString();
            btnAddQueue.Enabled = false;
        }

        private void rbInterior_CheckedChanged(object sender, EventArgs e)
        {
            if (rbInterior.Checked)
            {
                processType = "Interior";
                lblPrice.Text = "Price: " + vehicleRep.GetPrice(SelectedVehicle, processType).ToString();
                wp.ProcessType = ProcessType.Interior;
            }

        }

        private void rbExterior_CheckedChanged(object sender, EventArgs e)
        {
            if (rbExterior.Checked)
            {
                processType = "Exterior";
                lblPrice.Text = "Price: " + vehicleRep.GetPrice(SelectedVehicle, processType).ToString();
                wp.ProcessType = ProcessType.Exterior;
            }
        }

        private void rbFull_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFull.Checked)
            {
                processType = "Full";
                lblPrice.Text = "Price: " + vehicleRep.GetPrice(SelectedVehicle, processType).ToString();
                wp.ProcessType = ProcessType.Full;
            }
        }
        WashingProcessRepository wpRep;
        private void btnAddQueue_Click(object sender, EventArgs e)
        {
            wpRep = new WashingProcessRepository();

            wp.IsQueue = true;
            wp.WashingPrice = vehicleRep.GetPrice(SelectedVehicle, processType);
            wp.WaterConsumption = vehicleRep.GetWaterConsumption(wp);
            wp.Discount = vehicleRep.GetDiscount(SelectedVehicle.Customer);
            wpRep.Add(wp);
            Vehicles vehicles = new Vehicles(anaform);
            vehicles.MdiParent = anaform;
            vehicles.Dock = DockStyle.Fill;
            anaform.ActiveMdiChild.Close();
            vehicles.Show();
        }
        WashingProcess wp;
        List<Vehicle> VehicleList;
        private void AddQueue_Load(object sender, EventArgs e)
        {
            wp = new WashingProcess();
            wp.EmployeeID = 1;
            vehicleRep = new VehicleRepository();
            customerRep = new CustomerRepository();
            VehicleList = vehicleRep.GetVehicles();
            btnAddQueue.Enabled = false;
        }
        CustomerRepository customerRep;
        string processType = "";
        private void btnCheckSubs_Click(object sender, EventArgs e)
        {
            customerRep = new CustomerRepository();
            customerRep.CheckSubscribeType(SelectedVehicle.Customer, out string returnMessage);
            if(returnMessage!=string.Empty) { }
            lblSubs.Text = "Subscription: " + SelectedVehicle.Customer.SubscribeType.ToString();
            btnAddQueue.Enabled = true;
            lblPrice.Text = "Price: " + vehicleRep.GetPrice(SelectedVehicle, processType).ToString();
            lblDiscount.Text = "Discount: " + vehicleRep.GetDiscount(SelectedVehicle.Customer).ToString();
        }
    }
}
