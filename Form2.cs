using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            var objChart = graph.ChartAreas[0];
            //x axis set
            objChart.AxisX.Interval = 1;
            objChart.AxisX.Minimum = histogram.AxisX_min;
            objChart.AxisX.Maximum = histogram.AxisX_max;
            //y axis set
            objChart.AxisY.Interval = 1;
            objChart.AxisY.Minimum = histogram.AxisY_min;
            objChart.AxisY.Maximum = histogram.AxisY_max;
            //clear series
            graph.Series.Clear();

        }
    }
}
