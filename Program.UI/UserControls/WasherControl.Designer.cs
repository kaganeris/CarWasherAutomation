namespace Program.UI.UserControls
{
    partial class WasherControl
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WasherControl));
            cmbEmployees = new ComboBox();
            label1 = new Label();
            lblBodyType = new Label();
            label4 = new Label();
            lblCustomer = new Label();
            lblPlate = new Label();
            label2 = new Label();
            label3 = new Label();
            pbBodyType = new PictureBox();
            btnWashingDone = new Button();
            btnRemove = new Button();
            lblTime = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label5 = new Label();
            label6 = new Label();
            btnMaterialChoose = new Button();
            ((System.ComponentModel.ISupportInitialize)pbBodyType).BeginInit();
            SuspendLayout();
            // 
            // cmbEmployees
            // 
            cmbEmployees.FormattingEnabled = true;
            cmbEmployees.Location = new Point(99, 137);
            cmbEmployees.Name = "cmbEmployees";
            cmbEmployees.Size = new Size(121, 29);
            cmbEmployees.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 145);
            label1.Name = "label1";
            label1.Size = new Size(90, 21);
            label1.TabIndex = 1;
            label1.Text = "Employee:";
            // 
            // lblBodyType
            // 
            lblBodyType.AutoSize = true;
            lblBodyType.Location = new Point(91, 55);
            lblBodyType.Name = "lblBodyType";
            lblBodyType.Size = new Size(48, 21);
            lblBodyType.TabIndex = 13;
            lblBodyType.Text = "Body";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 55);
            label4.Name = "label4";
            label4.Size = new Size(93, 21);
            label4.TabIndex = 12;
            label4.Text = "Body Type:";
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Location = new Point(90, 88);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(86, 21);
            lblCustomer.TabIndex = 11;
            lblCustomer.Text = "Customer";
            // 
            // lblPlate
            // 
            lblPlate.AutoSize = true;
            lblPlate.Location = new Point(117, 23);
            lblPlate.Name = "lblPlate";
            lblPlate.Size = new Size(50, 21);
            lblPlate.TabIndex = 10;
            lblPlate.Text = "Plate";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 88);
            label2.Name = "label2";
            label2.Size = new Size(90, 21);
            label2.TabIndex = 9;
            label2.Text = "Customer:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 23);
            label3.Name = "label3";
            label3.Size = new Size(114, 21);
            label3.TabIndex = 8;
            label3.Text = "License Plate:";
            // 
            // pbBodyType
            // 
            pbBodyType.Location = new Point(216, 42);
            pbBodyType.Name = "pbBodyType";
            pbBodyType.Size = new Size(109, 67);
            pbBodyType.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBodyType.TabIndex = 14;
            pbBodyType.TabStop = false;
            // 
            // btnWashingDone
            // 
            btnWashingDone.FlatAppearance.BorderSize = 0;
            btnWashingDone.FlatStyle = FlatStyle.Flat;
            btnWashingDone.Image = (Image)resources.GetObject("btnWashingDone.Image");
            btnWashingDone.Location = new Point(279, 126);
            btnWashingDone.Name = "btnWashingDone";
            btnWashingDone.Size = new Size(46, 40);
            btnWashingDone.TabIndex = 15;
            btnWashingDone.UseVisualStyleBackColor = true;
            btnWashingDone.Click += btnWashingDone_Click;
            // 
            // btnRemove
            // 
            btnRemove.FlatAppearance.BorderSize = 0;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Image = (Image)resources.GetObject("btnRemove.Image");
            btnRemove.Location = new Point(304, 0);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(21, 20);
            btnRemove.TabIndex = 16;
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new Point(236, 2);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(46, 21);
            lblTime.TabIndex = 17;
            lblTime.Text = "Time";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(116, 2);
            label5.Name = "label5";
            label5.Size = new Size(110, 21);
            label5.TabIndex = 18;
            label5.Text = "Passing Time:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 114);
            label6.Name = "label6";
            label6.Size = new Size(79, 21);
            label6.TabIndex = 19;
            label6.Text = "Material:";
            // 
            // btnMaterialChoose
            // 
            btnMaterialChoose.FlatAppearance.BorderSize = 0;
            btnMaterialChoose.FlatStyle = FlatStyle.Flat;
            btnMaterialChoose.Image = (Image)resources.GetObject("btnMaterialChoose.Image");
            btnMaterialChoose.Location = new Point(91, 112);
            btnMaterialChoose.Name = "btnMaterialChoose";
            btnMaterialChoose.Size = new Size(36, 23);
            btnMaterialChoose.TabIndex = 20;
            btnMaterialChoose.UseVisualStyleBackColor = true;
            btnMaterialChoose.Click += btnMaterialChoose_Click;
            // 
            // WasherControl
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnMaterialChoose);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(lblTime);
            Controls.Add(btnRemove);
            Controls.Add(btnWashingDone);
            Controls.Add(pbBodyType);
            Controls.Add(lblBodyType);
            Controls.Add(label4);
            Controls.Add(lblCustomer);
            Controls.Add(lblPlate);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(cmbEmployees);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "WasherControl";
            Size = new Size(328, 169);
            Load += WasherControl_Load;
            ((System.ComponentModel.ISupportInitialize)pbBodyType).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbEmployees;
        private Label label1;
        private Label lblBodyType;
        private Label label4;
        private Label lblCustomer;
        private Label lblPlate;
        private Label label2;
        private Label label3;
        private PictureBox pbBodyType;
        private Button btnWashingDone;
        private Button btnRemove;
        private Label lblTime;
        public System.Windows.Forms.Timer timer1;
        private Label label5;
        private Label label6;
        private Button btnMaterialChoose;
    }
}
