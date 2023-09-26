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
            lblPlate = new Label();
            lblCustomer = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(42, 4);
            pictureBox1.Margin = new Padding(4, 4, 4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(145, 70);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 78);
            label1.Name = "label1";
            label1.Size = new Size(102, 21);
            label1.TabIndex = 1;
            label1.Text = "License Plate:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 104);
            label2.Name = "label2";
            label2.Size = new Size(81, 21);
            label2.TabIndex = 2;
            label2.Text = "Customer:";
            // 
            // lblPlate
            // 
            lblPlate.AutoSize = true;
            lblPlate.Location = new Point(120, 78);
            lblPlate.Name = "lblPlate";
            lblPlate.Size = new Size(44, 21);
            lblPlate.TabIndex = 3;
            lblPlate.Text = "Plate";
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Location = new Point(109, 104);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(78, 21);
            lblCustomer.TabIndex = 4;
            lblCustomer.Text = "Customer";
            // 
            // button1
            // 
            button1.Location = new Point(217, 14);
            button1.Name = "button1";
            button1.Size = new Size(75, 60);
            button1.TabIndex = 5;
            button1.Text = "Add to Washer";
            button1.UseVisualStyleBackColor = true;
            // 
            // CustomerVehicleControl
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(lblCustomer);
            Controls.Add(lblPlate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "CustomerVehicleControl";
            Size = new Size(295, 134);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label lblPlate;
        private Label lblCustomer;
        private Button button1;
    }
}
