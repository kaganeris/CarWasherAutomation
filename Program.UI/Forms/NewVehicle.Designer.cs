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
            columnHeader4 = new ColumnHeader();
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
            grbCustomer.Location = new Point(24, 22);
            grbCustomer.Margin = new Padding(4, 3, 4, 3);
            grbCustomer.Name = "grbCustomer";
            grbCustomer.Padding = new Padding(4, 3, 4, 3);
            grbCustomer.Size = new Size(409, 237);
            grbCustomer.TabIndex = 14;
            grbCustomer.TabStop = false;
            grbCustomer.Text = "Select or Add Customer";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(147, 126);
            txtSearch.Margin = new Padding(4, 3, 4, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(193, 32);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(28, 130);
            lblSearch.Margin = new Padding(4, 0, 4, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(78, 23);
            lblSearch.TabIndex = 2;
            lblSearch.Text = "Search";
            // 
            // rbNewCustomer
            // 
            rbNewCustomer.AutoSize = true;
            rbNewCustomer.Location = new Point(33, 79);
            rbNewCustomer.Margin = new Padding(4, 3, 4, 3);
            rbNewCustomer.Name = "rbNewCustomer";
            rbNewCustomer.Size = new Size(271, 27);
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
            rbExistingCustomer.Location = new Point(33, 45);
            rbExistingCustomer.Margin = new Padding(4, 3, 4, 3);
            rbExistingCustomer.Name = "rbExistingCustomer";
            rbExistingCustomer.Size = new Size(307, 27);
            rbExistingCustomer.TabIndex = 9;
            rbExistingCustomer.TabStop = true;
            rbExistingCustomer.Text = "Add To An Existing Customer";
            rbExistingCustomer.UseVisualStyleBackColor = true;
            rbExistingCustomer.CheckedChanged += rbExistingCustomer_CheckedChanged;
            // 
            // cmbBodyTypes
            // 
            cmbBodyTypes.FormattingEnabled = true;
            cmbBodyTypes.Location = new Point(143, 269);
            cmbBodyTypes.Margin = new Padding(4, 3, 4, 3);
            cmbBodyTypes.Name = "cmbBodyTypes";
            cmbBodyTypes.Size = new Size(217, 31);
            cmbBodyTypes.TabIndex = 11;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(105, 342);
            btnAdd.Margin = new Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(182, 40);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add Vehicle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Location = new Point(19, 132);
            lblBrand.Margin = new Padding(4, 0, 4, 0);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(78, 23);
            lblBrand.TabIndex = 5;
            lblBrand.Text = "Brand: ";
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(19, 202);
            lblModel.Margin = new Padding(4, 0, 4, 0);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(83, 23);
            lblModel.TabIndex = 6;
            lblModel.Text = "Model: ";
            // 
            // lblBodyType
            // 
            lblBodyType.AutoSize = true;
            lblBodyType.Location = new Point(19, 272);
            lblBodyType.Margin = new Padding(4, 0, 4, 0);
            lblBodyType.Name = "lblBodyType";
            lblBodyType.Size = new Size(116, 23);
            lblBodyType.TabIndex = 7;
            lblBodyType.Text = "Body Type:";
            // 
            // lvCustomers
            // 
            lvCustomers.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lvCustomers.FullRowSelect = true;
            lvCustomers.Location = new Point(450, 22);
            lvCustomers.Margin = new Padding(4, 3, 4, 3);
            lvCustomers.Name = "lvCustomers";
            lvCustomers.Size = new Size(460, 691);
            lvCustomers.TabIndex = 13;
            lvCustomers.UseCompatibleStateImageBehavior = false;
            lvCustomers.View = View.Details;
            lvCustomers.Click += lvCustomers_Click;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Index";
            columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Name";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Vehicle Plate";
            columnHeader3.Width = 150;
            // 
            // txtBrand
            // 
            txtBrand.Location = new Point(130, 129);
            txtBrand.Margin = new Padding(4, 3, 4, 3);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(258, 32);
            txtBrand.TabIndex = 12;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(130, 193);
            txtModel.Margin = new Padding(4, 3, 4, 3);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(258, 32);
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
            grbVehicle.Location = new Point(24, 266);
            grbVehicle.Margin = new Padding(4, 3, 4, 3);
            grbVehicle.Name = "grbVehicle";
            grbVehicle.Padding = new Padding(4, 3, 4, 3);
            grbVehicle.Size = new Size(409, 447);
            grbVehicle.TabIndex = 15;
            grbVehicle.TabStop = false;
            grbVehicle.Text = "Vehicle Information";
            // 
            // txtPlate
            // 
            txtPlate.Location = new Point(130, 59);
            txtPlate.Margin = new Padding(4, 3, 4, 3);
            txtPlate.Name = "txtPlate";
            txtPlate.Size = new Size(258, 32);
            txtPlate.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 62);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(72, 23);
            label1.TabIndex = 14;
            label1.Text = "Plate: ";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Body Type";
            columnHeader4.Width = 120;
            // 
            // NewVehicle
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 725);
            Controls.Add(grbVehicle);
            Controls.Add(grbCustomer);
            Controls.Add(lvCustomers);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
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
        private ColumnHeader columnHeader4;
    }
}