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
            grbCustomer = new GroupBox();
            txtSearch = new TextBox();
            lblSearch = new Label();
            rbNewCustomer = new RadioButton();
            rbExistingCustomer = new RadioButton();
            cmbBodyTypes = new ComboBox();
            btnAdd = new Button();
            lblBrand = new Label();
            lblModel = new Label();
            lblBodyType = new Label();
            lvCustomers = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            txtBrand = new TextBox();
            txtModel = new TextBox();
            grbVehicle = new GroupBox();
            txtPlate = new TextBox();
            label1 = new Label();
            grbCustomer.SuspendLayout();
            grbVehicle.SuspendLayout();
            SuspendLayout();
            // 
            // grbCustomer
            // 
            grbCustomer.Controls.Add(txtSearch);
            grbCustomer.Controls.Add(lblSearch);
            grbCustomer.Controls.Add(rbNewCustomer);
            grbCustomer.Controls.Add(rbExistingCustomer);
            grbCustomer.Location = new Point(16, 19);
            grbCustomer.Name = "grbCustomer";
            grbCustomer.Size = new Size(442, 206);
            grbCustomer.TabIndex = 14;
            grbCustomer.TabStop = false;
            grbCustomer.Text = "Select or Add Customer";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(98, 110);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(283, 27);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(19, 113);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(53, 20);
            lblSearch.TabIndex = 2;
            lblSearch.Text = "Search";
            // 
            // rbNewCustomer
            // 
            rbNewCustomer.AutoSize = true;
            rbNewCustomer.Enabled = false;
            rbNewCustomer.Location = new Point(22, 69);
            rbNewCustomer.Name = "rbNewCustomer";
            rbNewCustomer.Size = new Size(194, 24);
            rbNewCustomer.TabIndex = 10;
            rbNewCustomer.TabStop = true;
            rbNewCustomer.Text = "Add With New Customer";
            rbNewCustomer.UseVisualStyleBackColor = true;
            rbNewCustomer.CheckedChanged += rbExterior_CheckedChanged;
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
            rbExistingCustomer.CheckedChanged += rbExistingCustomer_CheckedChanged;
            // 
            // cmbBodyTypes
            // 
            cmbBodyTypes.FormattingEnabled = true;
            cmbBodyTypes.Location = new Point(125, 351);
            cmbBodyTypes.Name = "cmbBodyTypes";
            cmbBodyTypes.Size = new Size(250, 28);
            cmbBodyTypes.TabIndex = 11;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(161, 410);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(121, 35);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add Vehicle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Location = new Point(33, 154);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(55, 20);
            lblBrand.TabIndex = 5;
            lblBrand.Text = "Brand: ";
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(29, 254);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(59, 20);
            lblModel.TabIndex = 6;
            lblModel.Text = "Model: ";
            // 
            // lblBodyType
            // 
            lblBodyType.AutoSize = true;
            lblBodyType.Location = new Point(29, 354);
            lblBodyType.Name = "lblBodyType";
            lblBodyType.Size = new Size(81, 20);
            lblBodyType.TabIndex = 7;
            lblBodyType.Text = "Body Type:";
            // 
            // lvCustomers
            // 
            lvCustomers.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lvCustomers.FullRowSelect = true;
            lvCustomers.Location = new Point(464, 19);
            lvCustomers.Name = "lvCustomers";
            lvCustomers.Size = new Size(463, 684);
            lvCustomers.TabIndex = 13;
            lvCustomers.UseCompatibleStateImageBehavior = false;
            lvCustomers.View = View.Details;
            lvCustomers.Click += lvCustomers_Click;
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
            // txtBrand
            // 
            txtBrand.Location = new Point(114, 153);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(300, 27);
            txtBrand.TabIndex = 12;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(114, 252);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(300, 27);
            txtModel.TabIndex = 13;
            // 
            // grbVehicle
            // 
            grbVehicle.Controls.Add(txtPlate);
            grbVehicle.Controls.Add(label1);
            grbVehicle.Controls.Add(txtModel);
            grbVehicle.Controls.Add(txtBrand);
            grbVehicle.Controls.Add(lblBodyType);
            grbVehicle.Controls.Add(cmbBodyTypes);
            grbVehicle.Controls.Add(lblModel);
            grbVehicle.Controls.Add(lblBrand);
            grbVehicle.Controls.Add(btnAdd);
            grbVehicle.Location = new Point(16, 231);
            grbVehicle.Name = "grbVehicle";
            grbVehicle.Size = new Size(442, 472);
            grbVehicle.TabIndex = 15;
            grbVehicle.TabStop = false;
            grbVehicle.Text = "Vehicle Information";
            // 
            // txtPlate
            // 
            txtPlate.Location = new Point(114, 54);
            txtPlate.Name = "txtPlate";
            txtPlate.Size = new Size(300, 27);
            txtPlate.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 54);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 14;
            label1.Text = "Plate: ";
            // 
            // NewVehicle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 725);
            Controls.Add(grbVehicle);
            Controls.Add(grbCustomer);
            Controls.Add(lvCustomers);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NewVehicle";
            Text = "NewVehicle";
            Load += NewVehicle_Load;
            grbCustomer.ResumeLayout(false);
            grbCustomer.PerformLayout();
            grbVehicle.ResumeLayout(false);
            grbVehicle.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbCustomer;
        private TextBox txtSearch;
        private Label lblSearch;
        private RadioButton rbNewCustomer;
        private Button btnAdd;
        private RadioButton rbExistingCustomer;
        private Label lblBrand;
        private Label lblModel;
        private Label lblBodyType;
        private ListView lvCustomers;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ComboBox cmbBodyTypes;
        private TextBox txtModel;
        private TextBox txtBrand;
        private GroupBox grbVehicle;
        private TextBox txtPlate;
        private Label label1;
    }
}