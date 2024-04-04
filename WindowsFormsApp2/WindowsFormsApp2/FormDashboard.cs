namespace WindowsFormsApp2
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;
    using System.Windows.Forms.DataVisualization.Charting;
    using Database;
    using Entities;

    public partial class FormDashboard : Form
    {
        private readonly DataAccess dataAccess = new DataAccess();

        public FormDashboard()
        {
            InitializeComponent();
            chart1.Series.Clear();
        }

        // Car Price Statistics
        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();

            List<string> priceCategories = new List<string>
                { "0-2000", "2000-5000", "5000-10000", "10000-20000", "20000+" };

            Dictionary<string, double> carCounts = new Dictionary<string, double>();
            foreach (string category in priceCategories)
            {
                carCounts.Add(category, 0);
            }

            List<double> carPrices = dataAccess.GetCarPrices();

            foreach (int price in carPrices)
            {
                if (price <= 2000)
                    carCounts["0-2000"]++;
                else if (price <= 5000)
                    carCounts["2000-5000"]++;
                else if (price <= 10000)
                    carCounts["5000-10000"]++;
                else if (price <= 20000)
                    carCounts["10000-20000"]++;
                else
                    carCounts["20000+"]++;
            }

            Series series = new Series("Car Prices");
            series.ChartType = SeriesChartType.Column;

            foreach (KeyValuePair<string, double> entry in carCounts)
            {
                series.Points.AddXY(entry.Key, entry.Value);
            }

            chart1.Series.Add(series);

            chart1.Invalidate();
        }

        // Car Make Statistics
        private void button2_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();

            List<Car> allCars = dataAccess.GetAllCars();

            Dictionary<string, int> carMakeCounts = new Dictionary<string, int>();
            foreach (Car car in allCars)
            {
                if (carMakeCounts.ContainsKey(car.Make))
                {
                    carMakeCounts[car.Make]++;
                }
                else
                {
                    carMakeCounts.Add(car.Make, 1);
                }
            }

            Series series = new Series("Car Make");
            series.ChartType = SeriesChartType.Pie;

            foreach (KeyValuePair<string, int> entry in carMakeCounts)
            {
                series.Points.AddXY(entry.Key, entry.Value);
                /*
                if we want to print "BMW - 15.5%", "Audi - 12.7%", instead of just "BMW", "Audi", ...:
                    double percentage = ((double)entry.Value / allCars.Count) * 100;
                    series.Points.AddXY(entry.Key + " - " + percentage.ToString("0.##") + "%", percentage);
                */
            }

            chart1.Series.Add(series);

            chart1.Invalidate();
        }

        // Car Year Statistics
        private void button3_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();

            List<Car> allCars = dataAccess.GetAllCars();

            Dictionary<string, int> carYearCounts = new Dictionary<string, int>
            {
                { "Before 2000", 0 },
                { "2000-2010", 0 },
                { "2011-2020", 0 },
                { "After 2020", 0 }
            };

            foreach (Car car in allCars)
            {
                if (car.Year < 2000)
                {
                    carYearCounts["Before 2000"]++;
                }
                else if (car.Year >= 2000 && car.Year <= 2010)
                {
                    carYearCounts["2000-2010"]++;
                }
                else if (car.Year >= 2011 && car.Year <= 2020)
                {
                    carYearCounts["2011-2020"]++;
                }
                else
                {
                    carYearCounts["After 2020"]++;
                }
            }

            Series series = new Series("Car Year");
            series.ChartType = SeriesChartType.Column;


            foreach (KeyValuePair<string, int> entry in carYearCounts)
            {
                series.Points.AddXY(entry.Key, entry.Value);
            }

            chart1.Series.Add(series);

            chart1.ChartAreas[0].BackColor = Color.Transparent;
            chart1.ChartAreas[0].BorderColor = Color.White;

            chart1.Series["Car Year"].LabelForeColor = Color.Black;
            chart1.Series["Car Year"].Font = new Font("Arial", 10f, FontStyle.Bold);

            chart1.Invalidate();
        }
    }
}