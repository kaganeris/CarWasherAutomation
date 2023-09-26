namespace Program.UI
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            panel1 = new Panel();
            btnDashboard = new Button();
            btnEmployees = new Button();
            btnVehicles = new Button();
            btnCustomers = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(btnEmployees);
            panel1.Controls.Add(btnVehicles);
            panel1.Controls.Add(btnCustomers);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(340, 846);
            panel1.TabIndex = 0;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Transparent;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnDashboard.ForeColor = Color.Transparent;
            btnDashboard.Image = (Image)resources.GetObject("btnDashboard.Image");
            btnDashboard.Location = new Point(39, 53);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(244, 50);
            btnDashboard.TabIndex = 2;
            btnDashboard.Text = "        Dashboard";
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // btnEmployees
            // 
            btnEmployees.BackColor = Color.Transparent;
            btnEmployees.FlatAppearance.BorderSize = 0;
            btnEmployees.FlatStyle = FlatStyle.Flat;
            btnEmployees.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnEmployees.ForeColor = Color.Transparent;
            btnEmployees.Image = (Image)resources.GetObject("btnEmployees.Image");
            btnEmployees.Location = new Point(39, 321);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Size = new Size(253, 50);
            btnEmployees.TabIndex = 2;
            btnEmployees.Text = "        Employees";
            btnEmployees.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEmployees.UseVisualStyleBackColor = false;
            // 
            // btnVehicles
            // 
            btnVehicles.BackColor = Color.Transparent;
            btnVehicles.FlatAppearance.BorderSize = 0;
            btnVehicles.FlatStyle = FlatStyle.Flat;
            btnVehicles.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnVehicles.ForeColor = Color.Transparent;
            btnVehicles.Image = (Image)resources.GetObject("btnVehicles.Image");
            btnVehicles.Location = new Point(30, 134);
            btnVehicles.Name = "btnVehicles";
            btnVehicles.Size = new Size(253, 50);
            btnVehicles.TabIndex = 2;
            btnVehicles.Text = "        Vehicles";
            btnVehicles.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVehicles.UseVisualStyleBackColor = false;
            // 
            // btnCustomers
            // 
            btnCustomers.BackColor = Color.Transparent;
            btnCustomers.FlatAppearance.BorderSize = 0;
            btnCustomers.FlatStyle = FlatStyle.Flat;
            btnCustomers.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCustomers.ForeColor = Color.Transparent;
            btnCustomers.Image = (Image)resources.GetObject("btnCustomers.Image");
            btnCustomers.Location = new Point(39, 232);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(253, 50);
            btnCustomers.TabIndex = 2;
            btnCustomers.Text = "        Customers";
            btnCustomers.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCustomers.UseVisualStyleBackColor = false;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1279, 846);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Margin = new Padding(4);
            Name = "MainMenu";
            Text = "MainMenu";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnCustomers;
        private Button btnDashboard;
        private Button btnEmployees;
        private Button btnVehicles;
    }
}