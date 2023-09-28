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
    public partial class NewVehicle : Form
    {
        public NewVehicle()
        {
            InitializeComponent();
            vehicleRep = new VehicleRepository();
        }
        Customer SelectedCustomer;
        VehicleRepository vehicleRep;
        List<Vehicle> vehicles;
        private void NewVehicle_Load(object sender, EventArgs e)
        {
            vehicleRep = new VehicleRepository();
            cmbBodyTypes.Items.Clear();
            cmbBodyTypes.DataSource = Enum.GetValues(typeof(BodyType));
            vehicles = vehicleRep.GetVehicles();
        }

        private void rbExistingCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (rbExistingCustomer.Checked)
            {
                lvCustomers.Visible = true;
                lblSearch.Text = "Search: ";
            }

        }

        private void rbExterior_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNewCustomer.Checked)
            {
                lvCustomers.Visible = false;
                lblSearch.Text = "Name: ";
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (rbExistingCustomer.Checked)
            {
                int index = 0;
                if (txtSearch.Text == string.Empty) lvCustomers.Items.Clear();
                else
                {
                    vehicleRep = new VehicleRepository();
                    lvCustomers.Items.Clear();
                    foreach (Vehicle vehicle in vehicleRep.SearchVehicles(vehicles, txtSearch.Text))
                    {
                        index++;
                        string[] arr = { index.ToString(), vehicle.Customer.Name, vehicle.Plate,vehicle.BodyType.ToString() };
                        ListViewItem lvi = new ListViewItem(arr);
                        lvCustomers.Items.Add(lvi);
                        lvi.Tag = vehicle;
                    }
                }
            }
        }
        Vehicle SelectedVehicle;
        CustomerRepository customerRep;
        private void lvCustomers_Click(object sender, EventArgs e)
        {
            SelectedVehicle = (Vehicle)lvCustomers.SelectedItems[0].Tag;
            txtSearch.Text = SelectedVehicle.Customer.Name;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Vehicle VehicleToAdd = new Vehicle();
            if (!string.IsNullOrEmpty(txtPlate.Text) && !string.IsNullOrEmpty(txtModel.Text) && !string.IsNullOrEmpty(txtBrand.Text) && cmbBodyTypes.SelectedIndex != -1)
            {
                VehicleToAdd.Plate = txtPlate.Text;
                VehicleToAdd.Model = txtModel.Text;
                VehicleToAdd.Brand = txtBrand.Text;
                VehicleToAdd.BodyType = (BodyType)Enum.Parse(typeof(BodyType), cmbBodyTypes.SelectedItem.ToString());

                if (rbExistingCustomer.Checked && SelectedVehicle != null)
                {
                    VehicleToAdd.CustomerID = SelectedVehicle.CustomerID;
                    vehicleRep.Add(VehicleToAdd);
                    MessageBox.Show("Adding Vehicle is Successful", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBrand.Text = string.Empty;
                    txtModel.Text = string.Empty;
                    txtPlate.Text = string.Empty;
                    txtSearch.Text = string.Empty;
                    vehicleRep = new VehicleRepository();
                    vehicles = vehicleRep.GetVehicles();
                }
                else if (rbNewCustomer.Checked && !string.IsNullOrEmpty(txtSearch.Text))
                {
                    Customer customer = new Customer();
                    customer.Name = txtSearch.Text;
                    customerRep = new CustomerRepository();
                    customerRep.Add(customer);
                    VehicleToAdd.CustomerID = customer.ID;
                    vehicleRep.Add(VehicleToAdd);
                    MessageBox.Show("Adding Vehicle and Customer is Successful", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBrand.Text = string.Empty;
                    txtModel.Text = string.Empty;
                    txtPlate.Text = string.Empty;
                    txtSearch.Text = string.Empty;
                    vehicleRep = new VehicleRepository();
                    vehicles = vehicleRep.GetVehicles();
                }
                else
                {
                    MessageBox.Show("Please Choose a Customer or Create a New Customer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Please Fill In The Blank Areas..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
