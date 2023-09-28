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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        WashingProcessRepository wpRep;
        private void Dashboard_Load(object sender, EventArgs e)
        {
            wpRep = new WashingProcessRepository();
            for (int i = 0; i < 15; i++)
            {
                chartWaterCons.Series["Water Consumption"].Points.AddXY(DateTime.Now.AddDays(-i).Date, wpRep.WaterConsOfDay(DateTime.Now.AddDays(-i)));
                chartEndorsment.Series["Endorsment"].Points.AddXY(DateTime.Now.AddDays(-i).Date, wpRep.EndorsmentOfDay(DateTime.Now.AddDays(-i)));
                chartWashedCars.Series["WashedCars"].Points.AddXY(DateTime.Now.AddDays(-i).Date, wpRep.WashedCarsOfDay(DateTime.Now.AddDays(-i)));
            }
            piechart();
        }

        private void piechart()
        {
            foreach(BodyType bodyType in Enum.GetValues(typeof(BodyType)))
            {
                if(wpRep.WashingByBodyType(bodyType)>0)
                chartWashByBodyType.Series["WashingByBodyType"].Points.AddXY(bodyType.ToString(),wpRep.WashingByBodyType(bodyType));
            }
        }
    }
}
