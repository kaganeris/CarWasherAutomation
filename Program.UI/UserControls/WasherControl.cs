using Program.Business.Repositories;
using Program.DATA.Entities;
using Program.DATA.Enums;
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

namespace Program.UI.UserControls
{
    public partial class WasherControl : UserControl
    {
        WashingProcess wp;
        Vehicles _vehicles;
        CustomerVehicleControl cvc;
        public WasherControl(Vehicles vehicles, WashingProcess washingProcess,CustomerVehicleControl customerVehicleControl)
        {
            InitializeComponent();
            wp = washingProcess;
            _vehicles = vehicles;
            cvc = customerVehicleControl;
        }
        public Image BodyTypeImage
        {
            get { return pbBodyType.Image; }
            set { pbBodyType.Image = value; }
        }
        public string Plate
        {
            get { return lblPlate.Text; }
            set { lblPlate.Text = value; }
        }
        public string Customer
        {
            get { return lblCustomer.Text; }
            set { lblCustomer.Text = value; }
        }
        public string BodyType
        {
            get { return lblBodyType.Text; }
            set { lblBodyType.Text = value; }
        }
        public ComboBox Employees
        {
            get { return cmbEmployees; }
            set { cmbEmployees = value; }
        }

        private void WasherControl_Load(object sender, EventArgs e)
        {
            EmployeeRepository employeeRepository = new EmployeeRepository();
            foreach (var item in employeeRepository.GetAllEmployees())
            {
                cmbEmployees.Items.Add(item);
            }
        }

        private void btnWashingDone_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Is the washing completed?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                WashingProcessRepository washingProcessRepository = new WashingProcessRepository();
                wp.Employee = (Employee)cmbEmployees.SelectedItem;
                wp.IsQueue = false;
                washingProcessRepository.Update(wp);
                foreach (var item in _vehicles.Controls)
                {
                    if (item is GroupBox)
                    {
                        foreach (var control in ((GroupBox)item).Controls)
                        {
                            if (control is FlowLayoutPanel)
                                ((FlowLayoutPanel)control).Controls.Remove(this);
                        }
                    }
                }
            }
            else
                return;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            foreach (var item in _vehicles.Controls)
            {
                if (item is GroupBox)
                {
                    foreach (var control in ((GroupBox)item).Controls)
                    {
                        if (control is FlowLayoutPanel)
                        {
                            ((FlowLayoutPanel)control).Controls.Remove(this);
                            _vehicles.flpQueue.Controls.Add(cvc);
                        }
                            
                    }
                }
            }
        }
    }
}
