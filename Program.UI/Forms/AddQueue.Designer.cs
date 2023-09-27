namespace Program.UI.Forms
{
    partial class AddQueue
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
            txtSearch = new TextBox();
            label1 = new Label();
            lvCustomers = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            btnAddQueue = new Button();
            lblBrand = new Label();
            lblModel = new Label();
            lblBodyType = new Label();
            lblPrice = new Label();
            rbInterior = new RadioButton();
            rbExterior = new RadioButton();
            rbFull = new RadioButton();
            groupBox1 = new GroupBox();
            lblPlate = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Location = new Point(135, 36);
            txtSearch.Margin = new Padding(4, 3, 4, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(251, 23);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 39);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(71, 21);
            label1.TabIndex = 2;
            label1.Text = "Search";
            // 
            // lvCustomers
            // 
            lvCustomers.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lvCustomers.FullRowSelect = true;
            lvCustomers.Location = new Point(444, 13);
            lvCustomers.Margin = new Padding(4, 3, 4, 3);
            lvCustomers.Name = "lvCustomers";
            lvCustomers.Size = new Size(482, 687);
            lvCustomers.TabIndex = 3;
            lvCustomers.UseCompatibleStateImageBehavior = false;
            lvCustomers.View = View.Details;
            lvCustomers.Click += lvCustomers_Click;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Index";
            columnHeader1.Width = 80;
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
            // btnAddQueue
            // 
            btnAddQueue.Location = new Point(135, 612);
            btnAddQueue.Margin = new Padding(4, 3, 4, 3);
            btnAddQueue.Name = "btnAddQueue";
            btnAddQueue.Size = new Size(166, 37);
            btnAddQueue.TabIndex = 4;
            btnAddQueue.Text = "Add Queue";
            btnAddQueue.UseVisualStyleBackColor = true;
            btnAddQueue.Click += btnAddQueue_Click;
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Location = new Point(30, 150);
            lblBrand.Margin = new Padding(4, 0, 4, 0);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(70, 21);
            lblBrand.TabIndex = 5;
            lblBrand.Text = "Brand: ";
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(30, 207);
            lblModel.Margin = new Padding(4, 0, 4, 0);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(76, 21);
            lblModel.TabIndex = 6;
            lblModel.Text = "Model: ";
            // 
            // lblBodyType
            // 
            lblBodyType.AutoSize = true;
            lblBodyType.Location = new Point(30, 264);
            lblBodyType.Margin = new Padding(4, 0, 4, 0);
            lblBodyType.Name = "lblBodyType";
            lblBodyType.Size = new Size(108, 21);
            lblBodyType.TabIndex = 7;
            lblBodyType.Text = "Body Type:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(238, 516);
            lblPrice.Margin = new Padding(4, 0, 4, 0);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(63, 21);
            lblPrice.TabIndex = 8;
            lblPrice.Text = "Price: ";
            // 
            // rbInterior
            // 
            rbInterior.AutoSize = true;
            rbInterior.Checked = true;
            rbInterior.Enabled = false;
            rbInterior.Location = new Point(30, 324);
            rbInterior.Margin = new Padding(4, 3, 4, 3);
            rbInterior.Name = "rbInterior";
            rbInterior.Size = new Size(91, 25);
            rbInterior.TabIndex = 9;
            rbInterior.TabStop = true;
            rbInterior.Text = "Interior";
            rbInterior.UseVisualStyleBackColor = true;
            rbInterior.CheckedChanged += rbInterior_CheckedChanged;
            // 
            // rbExterior
            // 
            rbExterior.AutoSize = true;
            rbExterior.Enabled = false;
            rbExterior.Location = new Point(30, 393);
            rbExterior.Margin = new Padding(4, 3, 4, 3);
            rbExterior.Name = "rbExterior";
            rbExterior.Size = new Size(94, 25);
            rbExterior.TabIndex = 10;
            rbExterior.TabStop = true;
            rbExterior.Text = "Exterior";
            rbExterior.UseVisualStyleBackColor = true;
            rbExterior.CheckedChanged += rbExterior_CheckedChanged;
            // 
            // rbFull
            // 
            rbFull.AutoSize = true;
            rbFull.Enabled = false;
            rbFull.Location = new Point(30, 462);
            rbFull.Margin = new Padding(4, 3, 4, 3);
            rbFull.Name = "rbFull";
            rbFull.Size = new Size(57, 25);
            rbFull.TabIndex = 11;
            rbFull.TabStop = true;
            rbFull.Text = "Full";
            rbFull.UseVisualStyleBackColor = true;
            rbFull.CheckedChanged += rbFull_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblPlate);
            groupBox1.Controls.Add(txtSearch);
            groupBox1.Controls.Add(rbFull);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(rbExterior);
            groupBox1.Controls.Add(btnAddQueue);
            groupBox1.Controls.Add(rbInterior);
            groupBox1.Controls.Add(lblBrand);
            groupBox1.Controls.Add(lblPrice);
            groupBox1.Controls.Add(lblModel);
            groupBox1.Controls.Add(lblBodyType);
            groupBox1.Location = new Point(1, 13);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(435, 687);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            // 
            // lblPlate
            // 
            lblPlate.AutoSize = true;
            lblPlate.Location = new Point(30, 104);
            lblPlate.Margin = new Padding(4, 0, 4, 0);
            lblPlate.Name = "lblPlate";
            lblPlate.Size = new Size(65, 21);
            lblPlate.TabIndex = 12;
            lblPlate.Text = "Plate: ";
            // 
            // AddQueue
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 725);
            Controls.Add(groupBox1);
            Controls.Add(lvCustomers);
            Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "AddQueue";
            Text = "AddQueue";
            Load += AddQueue_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtSearch;
        private Label label1;
        private ListView lvCustomers;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button btnAddQueue;
        private Label lblBrand;
        private Label lblModel;
        private Label lblBodyType;
        private Label lblPrice;
        private RadioButton rbInterior;
        private RadioButton rbExterior;
        private RadioButton rbFull;
        private GroupBox groupBox1;
        private Label lblPlate;
    }
}