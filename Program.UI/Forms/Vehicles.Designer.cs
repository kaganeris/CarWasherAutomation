namespace Program.UI.Forms
{
    partial class Vehicles
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
            grpWasher3 = new GroupBox();
            flpWasher3 = new FlowLayoutPanel();
            grpWasher2 = new GroupBox();
            flpWasher2 = new FlowLayoutPanel();
            grpQueue = new GroupBox();
            flpQueue = new FlowLayoutPanel();
            grpWasher1 = new GroupBox();
            flpWasher1 = new FlowLayoutPanel();
            grpWasher3.SuspendLayout();
            grpWasher2.SuspendLayout();
            grpQueue.SuspendLayout();
            grpWasher1.SuspendLayout();
            SuspendLayout();
            // 
            // grpWasher3
            // 
            grpWasher3.Controls.Add(flpWasher3);
            grpWasher3.Location = new Point(68, 477);
            grpWasher3.Margin = new Padding(4);
            grpWasher3.Name = "grpWasher3";
            grpWasher3.Padding = new Padding(4);
            grpWasher3.Size = new Size(310, 178);
            grpWasher3.TabIndex = 19;
            grpWasher3.TabStop = false;
            grpWasher3.Text = "Washer 3";
            // 
            // flpWasher3
            // 
            flpWasher3.Location = new Point(7, 36);
            flpWasher3.Margin = new Padding(4);
            flpWasher3.Name = "flpWasher3";
            flpWasher3.Size = new Size(295, 134);
            flpWasher3.TabIndex = 2;
            // 
            // grpWasher2
            // 
            grpWasher2.Controls.Add(flpWasher2);
            grpWasher2.Location = new Point(68, 279);
            grpWasher2.Margin = new Padding(4);
            grpWasher2.Name = "grpWasher2";
            grpWasher2.Padding = new Padding(4);
            grpWasher2.Size = new Size(310, 178);
            grpWasher2.TabIndex = 18;
            grpWasher2.TabStop = false;
            grpWasher2.Text = "Washer 2";
            // 
            // flpWasher2
            // 
            flpWasher2.Location = new Point(7, 36);
            flpWasher2.Margin = new Padding(4);
            flpWasher2.Name = "flpWasher2";
            flpWasher2.Size = new Size(295, 134);
            flpWasher2.TabIndex = 2;
            // 
            // grpQueue
            // 
            grpQueue.Controls.Add(flpQueue);
            grpQueue.Location = new Point(561, 53);
            grpQueue.Margin = new Padding(4);
            grpQueue.Name = "grpQueue";
            grpQueue.Padding = new Padding(4);
            grpQueue.Size = new Size(310, 619);
            grpQueue.TabIndex = 17;
            grpQueue.TabStop = false;
            grpQueue.Text = "Queue";
            // 
            // flpQueue
            // 
            flpQueue.Location = new Point(11, 28);
            flpQueue.Margin = new Padding(4);
            flpQueue.Name = "flpQueue";
            flpQueue.Size = new Size(291, 583);
            flpQueue.TabIndex = 5;
            // 
            // grpWasher1
            // 
            grpWasher1.Controls.Add(flpWasher1);
            grpWasher1.Location = new Point(68, 81);
            grpWasher1.Margin = new Padding(4);
            grpWasher1.Name = "grpWasher1";
            grpWasher1.Padding = new Padding(4);
            grpWasher1.Size = new Size(310, 178);
            grpWasher1.TabIndex = 16;
            grpWasher1.TabStop = false;
            grpWasher1.Text = "Washer 1";
            // 
            // flpWasher1
            // 
            flpWasher1.Location = new Point(7, 36);
            flpWasher1.Margin = new Padding(4);
            flpWasher1.Name = "flpWasher1";
            flpWasher1.Size = new Size(295, 134);
            flpWasher1.TabIndex = 2;
            // 
            // Vehicles
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 725);
            Controls.Add(grpWasher3);
            Controls.Add(grpWasher2);
            Controls.Add(grpQueue);
            Controls.Add(grpWasher1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Vehicles";
            Text = "Vehicles";
            Load += Vehicles_Load;
            grpWasher3.ResumeLayout(false);
            grpWasher2.ResumeLayout(false);
            grpQueue.ResumeLayout(false);
            grpWasher1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpWasher3;
        private GroupBox grpWasher2;
        private GroupBox grpQueue;
        private GroupBox grpWasher1;
        public FlowLayoutPanel flpWasher3;
        public FlowLayoutPanel flpWasher2;
        public FlowLayoutPanel flpWasher1;
        public FlowLayoutPanel flpQueue;
    }
}