using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Histogram_Ocen
{
    public partial class GraphWindow : Form
    {
        public GraphWindow()
        {
            InitializeComponent();
        }

        private void bt_generate_Click(object sender, EventArgs e)
        {
            Histogram histogram = new Histogram(MainWindow.fileContent);
            histogram.GenerateHistogram();
            //clear series
            chart.Series.Clear();
            //create new series
            Series series = new Series();
            series.ChartType = SeriesChartType.Column;
            series.Name = "Histogram";
            for(int i=0; i<histogram.Reviews.Count(); i++)
                series.Points.AddXY(histogram.Reviews[i].ReviewStar, histogram.Reviews[i].Occurance);
            chart.Series.Add(series);
            
        }
    }
}
