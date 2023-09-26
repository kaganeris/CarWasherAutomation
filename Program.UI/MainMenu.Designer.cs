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
            groupBox1 = new GroupBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            groupBox2 = new GroupBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            groupBox3 = new GroupBox();
            flowLayoutPanel3 = new FlowLayoutPanel();
            groupBox4 = new GroupBox();
            flowLayoutPanel4 = new FlowLayoutPanel();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(flowLayoutPanel1);
            groupBox1.Location = new Point(261, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(228, 170);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Washer 1";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(6, 22);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(218, 137);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(flowLayoutPanel2);
            groupBox2.Location = new Point(261, 188);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(230, 170);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Washer 2";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Location = new Point(6, 22);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(218, 137);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(flowLayoutPanel3);
            groupBox3.Location = new Point(261, 364);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(230, 170);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Washer 3";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Location = new Point(6, 22);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(218, 137);
            flowLayoutPanel3.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(flowLayoutPanel4);
            groupBox4.Location = new Point(521, 14);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(230, 520);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Queue";
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Location = new Point(6, 22);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(218, 492);
            flowLayoutPanel4.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(33, 36);
            button1.Name = "button1";
            button1.Size = new Size(134, 41);
            button1.TabIndex = 4;
            button1.Text = "Customer Add Queue";
            button1.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 544);
            Controls.Add(button1);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "MainMenu";
            Text = "MainMenu";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel3;
        private GroupBox groupBox4;
        private FlowLayoutPanel flowLayoutPanel4;
        private Button button1;
    }
}