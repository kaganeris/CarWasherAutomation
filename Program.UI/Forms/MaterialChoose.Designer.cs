namespace Program.UI.Forms
{
    partial class MaterialChoose
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flpMaterials = new FlowLayoutPanel();
            btnSaveMaterial = new Button();
            SuspendLayout();
            // 
            // flpMaterials
            // 
            flpMaterials.AutoScroll = true;
            flpMaterials.Location = new Point(21, 24);
            flpMaterials.Name = "flpMaterials";
            flpMaterials.Size = new Size(408, 181);
            flpMaterials.TabIndex = 0;
            // 
            // btnSaveMaterial
            // 
            btnSaveMaterial.Location = new Point(298, 211);
            btnSaveMaterial.Name = "btnSaveMaterial";
            btnSaveMaterial.Size = new Size(131, 39);
            btnSaveMaterial.TabIndex = 1;
            btnSaveMaterial.Text = "Save Material";
            btnSaveMaterial.UseVisualStyleBackColor = true;
            btnSaveMaterial.Click += btnSaveMaterial_Click;
            // 
            // MaterialChoose
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 261);
            Controls.Add(btnSaveMaterial);
            Controls.Add(flpMaterials);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "MaterialChoose";
            Text = "MaterialChoose";
            Load += MaterialChoose_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpMaterials;
        private Button btnSaveMaterial;
    }
}