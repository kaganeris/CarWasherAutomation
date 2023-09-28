namespace Program.UI.Forms
{
    partial class Dashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            chartWaterCons = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)chartWaterCons).BeginInit();
            SuspendLayout();
            // 
            // chartWaterCons
            // 
            chartArea1.Name = "ChartArea1";
            chartWaterCons.ChartAreas.Add(chartArea1);
            chartWaterCons.Location = new Point(455, 412);
            chartWaterCons.Name = "chartWaterCons";
            chartWaterCons.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series1.Name = "Water Consumption";
            chartWaterCons.Series.Add(series1);
            chartWaterCons.Size = new Size(472, 301);
            chartWaterCons.TabIndex = 0;
            chartWaterCons.Text = "chart3";
            title1.Name = "Water Consumption";
            title1.Text = "Water Consumption";
            chartWaterCons.Titles.Add(title1);
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 725);
            Controls.Add(chartWaterCons);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)chartWaterCons).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.CodeDom.CodeTypeReference chart1;
        private System.CodeDom.CodeTypeReference chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartWaterCons;
    }
}