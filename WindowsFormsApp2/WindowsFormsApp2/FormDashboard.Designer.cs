
namespace WindowsFormsApp2
{
    partial class FormDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.CarPriceStatistics = new System.Windows.Forms.Button();
            this.CarMakeStatistics = new System.Windows.Forms.Button();
            this.CarYearStatistics = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(42, 21);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(560, 286);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // CarPriceStatistics
            // 
            this.CarPriceStatistics.Location = new System.Drawing.Point(42, 349);
            this.CarPriceStatistics.Name = "CarPriceStatistics";
            this.CarPriceStatistics.Size = new System.Drawing.Size(152, 38);
            this.CarPriceStatistics.TabIndex = 1;
            this.CarPriceStatistics.Text = "Car Price Statistics";
            this.CarPriceStatistics.UseVisualStyleBackColor = true;
            this.CarPriceStatistics.Click += new System.EventHandler(this.button1_Click);
            // 
            // CarMakeStatistics
            // 
            this.CarMakeStatistics.Location = new System.Drawing.Point(365, 349);
            this.CarMakeStatistics.Name = "CarMakeStatistics";
            this.CarMakeStatistics.Size = new System.Drawing.Size(152, 38);
            this.CarMakeStatistics.TabIndex = 2;
            this.CarMakeStatistics.Text = "Car Make Statistics";
            this.CarMakeStatistics.UseVisualStyleBackColor = true;
            this.CarMakeStatistics.Click += new System.EventHandler(this.button2_Click);
            // 
            // CarYearStatistics
            // 
            this.CarYearStatistics.Location = new System.Drawing.Point(203, 349);
            this.CarYearStatistics.Name = "CarYearStatistics";
            this.CarYearStatistics.Size = new System.Drawing.Size(156, 38);
            this.CarYearStatistics.TabIndex = 3;
            this.CarYearStatistics.Text = "Car Year Statistics";
            this.CarYearStatistics.UseVisualStyleBackColor = true;
            this.CarYearStatistics.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 492);
            this.Controls.Add(this.CarYearStatistics);
            this.Controls.Add(this.CarMakeStatistics);
            this.Controls.Add(this.CarPriceStatistics);
            this.Controls.Add(this.chart1);
            this.Name = "FormDashboard";
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button CarPriceStatistics;
        private System.Windows.Forms.Button CarMakeStatistics;
        private System.Windows.Forms.Button CarYearStatistics;
    }
}