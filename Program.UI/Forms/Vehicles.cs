using Program.Business.Repositories;
using Program.UI.UserControls;
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
    public partial class Vehicles : Form
    {
        public Vehicles()
        {
            InitializeComponent();
        }
        WashingProcessRepository washingProcessRepository;
        private void Vehicles_Load(object sender, EventArgs e)
        {
            washingProcessRepository = new WashingProcessRepository();
            QueueLoad();
        }
        public void QueueLoad()
        {
            flpQueue.Controls.Clear();
            foreach (var item in washingProcessRepository.GetAllQueueVehicles())
            {
                CustomerVehicleControl customerVehicleControl = new CustomerVehicleControl(this, item);
                customerVehicleControl.Plate = item.Vehicle.Plate;
                customerVehicleControl.Customer = item.Vehicle.Customer.Name;
                customerVehicleControl.BodyType = item.Vehicle.BodyType.ToString();
                customerVehicleControl.Tag = item;
                switch (item.Vehicle.BodyType)
                {
                    case DATA.Enums.BodyType.Sedan:
                        customerVehicleControl.BodyTypeImage = Image.FromFile(Application.StartupPath + "\\BodyTypeImage\\Sedan.png");
                        break;
                    case DATA.Enums.BodyType.Hatchback:
                        customerVehicleControl.BodyTypeImage = Image.FromFile(Application.StartupPath + "\\BodyTypeImage\\Hatchback.png");
                        break;
                    case DATA.Enums.BodyType.SUV:
                        customerVehicleControl.BodyTypeImage = Image.FromFile(Application.StartupPath + "\\BodyTypeImage\\SUV.png");
                        break;
                    case DATA.Enums.BodyType.StationVagon:
                        customerVehicleControl.BodyTypeImage = Image.FromFile(Application.StartupPath + "\\BodyTypeImage\\StationWagon.png");
                        break;
                    case DATA.Enums.BodyType.Pickup:
                        customerVehicleControl.BodyTypeImage = Image.FromFile(Application.StartupPath + "\\BodyTypeImage\\Pickup.png");
                        break;
                    case DATA.Enums.BodyType.Minivan:
                        customerVehicleControl.BodyTypeImage = Image.FromFile(Application.StartupPath + "\\BodyTypeImage\\Minivan.png");
                        break;
                    case DATA.Enums.BodyType.Panelvan:
                        customerVehicleControl.BodyTypeImage = Image.FromFile(Application.StartupPath + "\\BodyTypeImage\\Panelvan.png");
                        break;
                    case DATA.Enums.BodyType.Coupe:
                        customerVehicleControl.BodyTypeImage = Image.FromFile(Application.StartupPath + "\\BodyTypeImage\\Coupe.png");
                        break;
                    default:
                        break;
                }
                flpQueue.Controls.Add(customerVehicleControl);
            }
        }
    }
}
