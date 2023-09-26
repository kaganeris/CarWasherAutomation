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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            lblLicensePlate = new Label();
            lblCustomer = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(36, 24);
            pictureBox1.Margin = new Padding(4, 4, 4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(196, 57);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;

            label1.Location = new Point(12, 96);
            label1.Location = new Point(12, 85);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(114, 21);
            label1.TabIndex = 1;
            label1.Text = "License Plate:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 132);
            label2.Location = new Point(12, 114);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(90, 21);
            label2.TabIndex = 2;
            label2.Text = "Customer:";
            // 
            // lblLicensePlate
            // 
            lblLicensePlate.AutoSize = true;
            lblLicensePlate.Location = new Point(134, 96);
            lblLicensePlate.Location = new Point(134, 85);
            lblLicensePlate.Margin = new Padding(4, 0, 4, 0);
            lblLicensePlate.Name = "lblLicensePlate";
            lblLicensePlate.Size = new Size(50, 21);
            lblLicensePlate.TabIndex = 3;
            lblLicensePlate.Text = "Plate";
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Location = new Point(134, 137);
            lblCustomer.Location = new Point(134, 114);
            lblCustomer.Margin = new Padding(4, 0, 4, 0);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(86, 21);
            lblCustomer.TabIndex = 4;
            lblCustomer.Text = "Customer";
            // 
            // button1
            // 
            button1.Location = new Point(228, 96);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(101, 57);
            button1.Location = new Point(221, 85);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(70, 39);
            button1.TabIndex = 5;
            button1.Text = "Add to Washer";
            button1.UseVisualStyleBackColor = true;
            // 
            // CustomerVehicleControl
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(lblCustomer);
            Controls.Add(lblLicensePlate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "CustomerVehicleControl";
            Size = new Size(341, 182);
            Size = new Size(295, 134);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label lblLicensePlate;
        private Label lblCustomer;
        private Button button1;
    }
}
