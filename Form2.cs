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
using System.IO;


namespace Histogram_Ocen
{
    public partial class GraphWindow : Form
    {
        public GraphWindow()
        {
            InitializeComponent();
        }

        public void bt_generate_Click(object sender, EventArgs e)
        {
            Histogram histogram = new Histogram(MainWindow.fileContent);
            histogram.GenerateHistogram();
            if (histogram.isEmpty == true)
                MessageBox.Show("Plik nie zawiera liczb!");
            else
            {
                //clear series
                chart.Series.Clear();
                //create new series
                Series series = new Series();
                series.ChartType = SeriesChartType.Column;
                series.Name = "Histogram";
                for (int i = 0; i < histogram.Occuarance.Length; i++)
                {
                    if (histogram.Occuarance[i] == 0) continue;
                    series.Points.AddXY(i + histogram.AxisX_min, histogram.Occuarance[i]);
                }

                chart.Series.Add(series);
                bt_change_color.Enabled = true;
                bt_disable_legend.Enabled = true;
                cb_chart_type.Enabled = true;
                cb_chart_type.SelectedIndex = 0;
                bt_generate.Enabled = false;
                bt_save_to_txt.Enabled = true;
            }
        }

        private void bt_change_color_Click(object sender, EventArgs e)
        {
            using(ColorDialog graph_color = new ColorDialog())
            {
                if(graph_color.ShowDialog() == DialogResult.OK)
                {
                    chart.Series["Histogram"].Color = graph_color.Color;
                }
            }
        }
        public void bt_disable_legend_Click(object sender, EventArgs e)
        {
            if (chart.Series["Histogram"].IsVisibleInLegend == false)
            {
                chart.Series["Histogram"].IsVisibleInLegend = true;
            }
            else
            {
                chart.Series["Histogram"].IsVisibleInLegend = false;
            }
        } 

        private void GraphWindow_Load(object sender, EventArgs e)
        {
            cb_chart_type.Items.Add("słupkowy");
            cb_chart_type.Items.Add("kołowy");
            cb_chart_type.Items.Add("punktowy");
        }

        public void cb_chart_type_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cb_chart_type.SelectedIndex == 0)
            {
                chart.Series["Histogram"].ChartType = SeriesChartType.Column;
            }
            if (cb_chart_type.SelectedIndex == 1)
            {
                chart.Series["Histogram"].ChartType = SeriesChartType.Pie;
            }
            if (cb_chart_type.SelectedIndex == 2)
            {
                chart.Series["Histogram"].ChartType = SeriesChartType.Point;
            }
        }

        private void bt_save_to_txt_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog save_txt = new SaveFileDialog())
            {
                save_txt.Filter = "txt files (*.txt)|*.txt";
                save_txt.RestoreDirectory = true;
                save_txt.FilterIndex = 2;
                save_txt.DefaultExt = "txt";
                
                if (save_txt.ShowDialog() == DialogResult.OK)
                {
                    Stream txtStream = save_txt.OpenFile();
                    StreamWriter txt = new StreamWriter(txtStream);
                    List<int> Marks;
                    Histogram histogram = new Histogram(MainWindow.fileContent);
                    Marks = new List<int>();
                    histogram.SearchForNumbers(Marks);
                    var duplicates = Marks.GroupBy(x => x)
                           .Where(g => g.Count() > 1)
                           .Select(y => $"Ocena = {y.Key} | Ilość = {y.Count()}")
                           .ToList();
                    foreach (var i in duplicates)
                    {
                        txt.WriteLine(i);
                    }
                    txt.Close();
                    txtStream.Close();
                }
                MessageBox.Show("Zapisano plik");
            }            
        }

    }
}
