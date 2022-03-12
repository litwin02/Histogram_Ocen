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
            foreach (int num in histogram.Marks)
            {
                MessageBox.Show($"{num}");
            }

        }
    }
}
