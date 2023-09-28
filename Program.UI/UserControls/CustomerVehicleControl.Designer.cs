namespace Program.UI.UserControls
{
    partial class CustomerVehicleControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pbBodyType = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            lblPlate = new Label();
            lblCustomer = new Label();
            btnAddToWasher = new Button();
            lblBodyType = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbBodyType).BeginInit();
            SuspendLayout();
            // 
            // pbBodyType
            // 
            pbBodyType.Location = new Point(81, 4);
            pbBodyType.Margin = new Padding(4);
            pbBodyType.Name = "pbBodyType";
            pbBodyType.Size = new Size(145, 70);
            pbBodyType.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBodyType.TabIndex = 0;
            pbBodyType.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 78);
            label1.Name = "label1";
            label1.Size = new Size(102, 21);
            label1.TabIndex = 1;
            label1.Text = "License Plate:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 143);
            label2.Name = "label2";
            label2.Size = new Size(81, 21);
            label2.TabIndex = 2;
            label2.Text = "Customer:";
            // 
            // lblPlate
            // 
            lblPlate.AutoSize = true;
            lblPlate.Location = new Point(106, 78);
            lblPlate.Name = "lblPlate";
            lblPlate.Size = new Size(44, 21);
            lblPlate.TabIndex = 3;
            lblPlate.Text = "Plate";
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Location = new Point(95, 143);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(78, 21);
            lblCustomer.TabIndex = 4;
            lblCustomer.Text = "Customer";
            // 
            // btnAddToWasher
            // 
            btnAddToWasher.Location = new Point(196, 91);
            btnAddToWasher.Name = "btnAddToWasher";
            btnAddToWasher.Size = new Size(75, 60);
            btnAddToWasher.TabIndex = 5;
            btnAddToWasher.Text = "Add to Washer";
            btnAddToWasher.UseVisualStyleBackColor = true;
            btnAddToWasher.Click += btnAddToWasher_Click;
            // 
            // lblBodyType
            // 
            lblBodyType.AutoSize = true;
            lblBodyType.Location = new Point(96, 111);
            lblBodyType.Name = "lblBodyType";
            lblBodyType.Size = new Size(45, 21);
            lblBodyType.TabIndex = 7;
            lblBodyType.Text = "Body";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 111);
            label4.Name = "label4";
            label4.Size = new Size(84, 21);
            label4.TabIndex = 6;
            label4.Text = "Body Type:";
            // 
            // CustomerVehicleControl
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblBodyType);
            Controls.Add(label4);
            Controls.Add(btnAddToWasher);
            Controls.Add(lblCustomer);
            Controls.Add(lblPlate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pbBodyType);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "CustomerVehicleControl";
            Size = new Size(286, 173);
            ((System.ComponentModel.ISupportInitialize)pbBodyType).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbBodyType;
        private Label label1;
        private Label label2;
        private Label lblPlate;
        private Label lblCustomer;
        private Button btnAddToWasher;
        private Label lblBodyType;
        private Label label4;
    }
}
