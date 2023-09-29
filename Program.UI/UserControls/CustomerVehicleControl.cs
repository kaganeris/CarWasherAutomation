using Program.DATA.Entities;
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
    public partial class CustomerVehicleControl : UserControl
    {
        Vehicles _vehicles;
        WashingProcess wp;
        MainMenu mainMenu;
        public CustomerVehicleControl(Vehicles vehicles,WashingProcess washingProcess,MainMenu _mainMenu)
        {
            InitializeComponent();
            wp = washingProcess;
            _vehicles = vehicles;
            mainMenu = _mainMenu;
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

        private void btnAddToWasher_Click(object sender, EventArgs e)
        {
            if (_vehicles.flpWasher1.Controls.Count == 0)
                _vehicles.flpWasher1.Controls.Add(WasherAdd());
            else if(_vehicles.flpWasher2.Controls.Count == 0)
                _vehicles.flpWasher2.Controls.Add(WasherAdd());
            else if(_vehicles.flpWasher3.Controls.Count == 0)
                _vehicles.flpWasher3.Controls.Add(WasherAdd());
            else
                MessageBox.Show("Washer's are full!!");
        }
        public WasherControl WasherAdd()
        {
            WasherControl washerControl = new WasherControl(_vehicles,wp,this,mainMenu);
            washerControl.Plate = this.Plate;
            washerControl.Customer = this.Customer;
            washerControl.BodyType = this.BodyType;
            washerControl.BodyTypeImage = this.BodyTypeImage;
            washerControl.Tag = this.Tag;
            washerControl.timer1.Start();
            _vehicles.flpQueue.Controls.Remove(this);
            return washerControl;
        }
    }
}
