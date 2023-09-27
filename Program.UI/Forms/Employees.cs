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
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
        }
        EmployeeRepository employeeRepository;
        private void Employees_Load(object sender, EventArgs e)
        {
            employeeRepository = new EmployeeRepository();
            GetAllEmployees();
            ButtonControl(true);
        }
        public void GetAllEmployees()
        {
            foreach (var item in employeeRepository.GetAllEmployees())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.ID.ToString();
                lvi.SubItems.Add(item.FirstName);
                lvi.SubItems.Add(item.LastName);
                lvi.SubItems.Add(item.Title);
                lvi.SubItems.Add(item.Address);
                lvi.SubItems.Add(item.CreatedDate.ToString());
                lvi.SubItems.Add(item.ModifiedDate.ToString());
                lvi.SubItems.Add(item.DeletedDate.ToString());
                lvi.Tag = item;
                lstEmployees.Items.Add(lvi);
            }
        }
        public void ButtonControl(bool status)
        {
            btnAdd.Enabled = status;
            btnDelete.Enabled = !status;
            btnUpdate.Enabled = !status;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "" || txtLastName.Text == "" || txtTitle.Text == "" || txtAddress.Text == "")
            {
                MessageBox.Show("Employee informations can not be empty!");
                return;
            }
            else
            {
                Employee newEmployee = new Employee();
                txtFirstName.Text = newEmployee.FirstName;
                txtLastName.Text = newEmployee.LastName;
                txtTitle.Text = newEmployee.Title;
                txtAddress.Text = newEmployee.Address;
                employeeRepository.Add(newEmployee);
                MessageBox.Show("Employee successfully added!");
                GetAllEmployees();
            }
        }
        Employee selectedEmployee;
        private void lstEmployees_Click(object sender, EventArgs e)
        {
            if (lstEmployees.SelectedItems.Count == 1)
            {
                ButtonControl(false);
                selectedEmployee = (Employee)lstEmployees.SelectedItems[0].Tag;
                txtFirstName.Text = selectedEmployee.FirstName;
                txtLastName.Text = selectedEmployee.LastName;
                txtTitle.Text = selectedEmployee.Title;
                txtAddress.Text = selectedEmployee.Address;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            employeeRepository.Delete(selectedEmployee);
            MessageBox.Show("Employee succesfully deleted!");
            ClearTextbox();
            ButtonControl(true);
            GetAllEmployees();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            selectedEmployee.FirstName = txtFirstName.Text;
            selectedEmployee.LastName = txtLastName.Text;
            selectedEmployee.Title = txtTitle.Text;
            selectedEmployee.Address = txtAddress.Text;
            employeeRepository.Update(selectedEmployee);
            MessageBox.Show("Employee succesfully updated!");
            ClearTextbox();
            ButtonControl(true);
            GetAllEmployees();
        }
        public void ClearTextbox()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtTitle.Text = "";
            txtAddress.Text = "";
        }
    }
}
