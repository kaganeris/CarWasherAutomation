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

namespace Program.UI
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            AddQueue screen = new AddQueue();
            screen.MdiParent = this;
            screen.Dock = DockStyle.Fill;
            DialogResult result = screen.ShowDialog();

            if(result == DialogResult.OK)
            {
                //Yıkama sırası listesini yenile
            }
        }
    }
}
