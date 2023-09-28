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
    public partial class MaterialChoose : Form
    {
        WashingProcess wp;
        List<MaterialWashingProcess> materialWashingProcessList;
        public MaterialChoose(WashingProcess washingProcess,List<MaterialWashingProcess> mwp)
        {
            InitializeComponent();
            wp = washingProcess;
            materialWashingProcessList = mwp;
        }

        private void MaterialChoose_Load(object sender, EventArgs e)
        {
            MaterialRepository materialRepository = new MaterialRepository();
            foreach (var item in materialRepository.GetAllMaterials())
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Text = item.MaterialName;
                checkBox.AutoSize = true;
                checkBox.Tag = item;
                flpMaterials.Controls.Add(checkBox);
            }
        }

        private void btnSaveMaterial_Click(object sender, EventArgs e)
        {
            int checkedCount = 0;
            foreach (var item in flpMaterials.Controls)
            {
                if (item is CheckBox && ((CheckBox)item).Checked)
                {
                    checkedCount++;
                    Material material = (Material)((CheckBox)item).Tag;
                    MaterialWashingProcess materialWashingProcess = new MaterialWashingProcess();
                    materialWashingProcess.MaterialID = material.ID;
                    materialWashingProcess.WashingProcessID = wp.ID;
                    materialWashingProcessList.Add(materialWashingProcess);
                }
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}
