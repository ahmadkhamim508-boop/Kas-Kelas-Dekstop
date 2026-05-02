using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kas_kelas__2_
{
    public partial class UC_Dashboard : UserControl
    {
        public UC_Dashboard()
        {
            InitializeComponent();
        }

        private void UC_Dashboard_Load(object sender, EventArgs e)
        {
            chart1.Series.Clear();

            var series = chart1.Series.Add("Kas");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            series.Points.AddXY("Mon", 1000);
            series.Points.AddXY("Tue", 2000);
            series.Points.AddXY("Wed", 1500);
            series.Points.AddXY("Thu", 2500);
            series.Points.AddXY("Fri", 3000);
            series.Points.AddXY("Sat", 2000);
        }


        private void LoadChart(List<string> labels, List<int> values)
        {
            chart1.Series.Clear();

            var series = chart1.Series.Add("Kas");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            for (int i = 0; i < labels.Count; i++)
            {
                series.Points.AddXY(labels[i], values[i]);
            }

            // styling biar clean
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
        }


        private void ShowWeekly()
        {
            var labels = new List<string> { "MON", "TUE", "WED", "THU", "FRI", "SAT" };
            var values = new List<int> { 1000, 2000, 1500, 2500, 3000, 2000 };

            LoadChart(labels, values);
        }

        private void ShowMonthly()
        {
            var labels = new List<string> { "Week 1", "Week 2", "Week 3", "Week 4" };
            var values = new List<int> { 5000, 7000, 6000, 8000 };

            LoadChart(labels, values);
        }

        private void btnWeekly_Click(object sender, EventArgs e)
        {
            ShowWeekly();   
        }

        private void btnMonths_Click(object sender, EventArgs e)
        {
            ShowMonthly();
        }
    }
}
