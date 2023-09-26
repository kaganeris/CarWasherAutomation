namespace Program.UI.Forms
{
    partial class NewVehicle
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
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            txtSearch = new TextBox();
            label1 = new Label();
            rbExterior = new RadioButton();
            btnAdd = new Button();
            rbExistingCustomer = new RadioButton();
            lblBrand = new Label();
            lblModel = new Label();
            lblBodyType = new Label();
            lvCustomers = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(txtSearch);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(rbExterior);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(rbExistingCustomer);
            groupBox1.Controls.Add(lblBrand);
            groupBox1.Controls.Add(lblModel);
            groupBox1.Controls.Add(lblBodyType);
            groupBox1.Location = new Point(16, 19);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(400, 462);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Vehicle";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(109, 283);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(250, 28);
            comboBox1.TabIndex = 11;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(98, 110);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(283, 27);
            txtSearch.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 113);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 2;
            label1.Text = "Search";
            // 
            // rbExterior
            // 
            rbExterior.AutoSize = true;
            rbExterior.Enabled = false;
            rbExterior.Location = new Point(22, 69);
            rbExterior.Name = "rbExterior";
            rbExterior.Size = new Size(194, 24);
            rbExterior.TabIndex = 10;
            rbExterior.TabStop = true;
            rbExterior.Text = "Add With New Customer";
            rbExterior.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(238, 372);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(121, 35);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add Vehicle";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // rbExistingCustomer
            // 
            rbExistingCustomer.AutoSize = true;
            rbExistingCustomer.Checked = true;
            rbExistingCustomer.Enabled = false;
            rbExistingCustomer.Location = new Point(22, 39);
            rbExistingCustomer.Name = "rbExistingCustomer";
            rbExistingCustomer.Size = new Size(222, 24);
            rbExistingCustomer.TabIndex = 9;
            rbExistingCustomer.TabStop = true;
            rbExistingCustomer.Text = "Add To An Existing Customer";
            rbExistingCustomer.UseVisualStyleBackColor = true;
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Location = new Point(22, 177);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(55, 20);
            lblBrand.TabIndex = 5;
            lblBrand.Text = "Brand: ";
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(22, 231);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(59, 20);
            lblModel.TabIndex = 6;
            lblModel.Text = "Model: ";
            // 
            // lblBodyType
            // 
            lblBodyType.AutoSize = true;
            lblBodyType.Location = new Point(22, 286);
            lblBodyType.Name = "lblBodyType";
            lblBodyType.Size = new Size(81, 20);
            lblBodyType.TabIndex = 7;
            lblBodyType.Text = "Body Type:";
            // 
            // lvCustomers
            // 
            lvCustomers.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lvCustomers.FullRowSelect = true;
            lvCustomers.Location = new Point(422, 19);
            lvCustomers.Name = "lvCustomers";
            lvCustomers.Size = new Size(463, 462);
            lvCustomers.TabIndex = 13;
            lvCustomers.UseCompatibleStateImageBehavior = false;
            lvCustomers.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Index";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Name";
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Vehicle Plate";
            columnHeader3.Width = 200;
            // 
            // NewVehicle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 510);
            Controls.Add(groupBox1);
            Controls.Add(lvCustomers);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NewVehicle";
            Text = "NewVehicle";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtSearch;
        private Label label1;
        private RadioButton rbExterior;
        private Button btnAdd;
        private RadioButton rbExistingCustomer;
        private Label lblBrand;
        private Label lblModel;
        private Label lblBodyType;
        private ListView lvCustomers;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ComboBox comboBox1;
    }
}