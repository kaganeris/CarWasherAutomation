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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            chartWaterCons = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartEndorsment = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartWashByBodyType = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartWashedCars = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)chartWaterCons).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartEndorsment).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartWashByBodyType).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartWashedCars).BeginInit();
            SuspendLayout();
            // 
            // chartWaterCons
            // 
            chartArea1.Name = "ChartArea1";
            chartWaterCons.ChartAreas.Add(chartArea1);
            chartWaterCons.Location = new Point(487, 389);
            chartWaterCons.Name = "chartWaterCons";
            chartWaterCons.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series1.Name = "Water Consumption";
            chartWaterCons.Series.Add(series1);
            chartWaterCons.Size = new Size(440, 301);
            chartWaterCons.TabIndex = 0;
            chartWaterCons.Text = "chart3";
            title1.Name = "Water Consumption";
            title1.Text = "Water Consumption";
            chartWaterCons.Titles.Add(title1);
            // 
            // chartEndorsment
            // 
            chartArea2.Name = "ChartArea1";
            chartEndorsment.ChartAreas.Add(chartArea2);
            chartEndorsment.Location = new Point(487, 30);
            chartEndorsment.Name = "chartEndorsment";
            chartEndorsment.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ChartArea = "ChartArea1";
            series2.IsValueShownAsLabel = true;
            series2.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series2.Name = "Endorsment";
            chartEndorsment.Series.Add(series2);
            chartEndorsment.Size = new Size(440, 301);
            chartEndorsment.TabIndex = 1;
            chartEndorsment.Text = "Endorsment";
            title2.Name = "Endorsment";
            title2.Text = "Endorsment By Day";
            chartEndorsment.Titles.Add(title2);
            // 
            // chartWashByBodyType
            // 
            chartArea3.Name = "ChartArea1";
            chartWashByBodyType.ChartAreas.Add(chartArea3);
            legend1.Name = "Legend1";
            chartWashByBodyType.Legends.Add(legend1);
            chartWashByBodyType.Location = new Point(12, 389);
            chartWashByBodyType.Name = "chartWashByBodyType";
            chartWashByBodyType.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.IsValueShownAsLabel = true;
            series3.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series3.Legend = "Legend1";
            series3.Name = "WashingByBodyType";
            chartWashByBodyType.Series.Add(series3);
            chartWashByBodyType.Size = new Size(422, 301);
            chartWashByBodyType.TabIndex = 2;
            chartWashByBodyType.Text = "chart3";
            title3.Name = "Washing Numbers By Body Type";
            title3.Text = "Washing Numbers By Body Type";
            chartWashByBodyType.Titles.Add(title3);
            // 
            // chartWashedCars
            // 
            chartArea4.Name = "ChartArea1";
            chartWashedCars.ChartAreas.Add(chartArea4);
            chartWashedCars.Location = new Point(23, 30);
            chartWashedCars.Name = "chartWashedCars";
            chartWashedCars.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series4.ChartArea = "ChartArea1";
            series4.IsValueShownAsLabel = true;
            series4.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series4.Name = "WashedCars";
            chartWashedCars.Series.Add(series4);
            chartWashedCars.Size = new Size(425, 301);
            chartWashedCars.TabIndex = 3;
            chartWashedCars.Text = "chart3";
            title4.Name = "WashedCars";
            title4.Text = "Number of Washed Cars";
            chartWashedCars.Titles.Add(title4);
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 725);
            Controls.Add(chartWashedCars);
            Controls.Add(chartWashByBodyType);
            Controls.Add(chartEndorsment);
            Controls.Add(chartWaterCons);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)chartWaterCons).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartEndorsment).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartWashByBodyType).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartWashedCars).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.CodeDom.CodeTypeReference chart1;
        private System.CodeDom.CodeTypeReference chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartWaterCons;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEndorsment;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartWashByBodyType;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartWashedCars;
    }
}