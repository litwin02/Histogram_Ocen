using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Histogram_Ocen
{
    public partial class MainWindow : Form
    {
        public static string fileContent { get; set; }
        public static string filePath { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }

        public void bt_open_file_Click(object sender, EventArgs e)
        {           
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;

                    using (Stream fileStream = openFileDialog.OpenFile())
                    {
                        using (StreamReader reader = new StreamReader(fileStream))
                        {
                            fileContent = reader.ReadToEnd();
                        }
                    }
                    MessageBox.Show("Otwarto poprawnie plik");
                    bt_show_graph.Enabled = true;
                }
            }
        }

        private void bt_show_graph_Click(object sender, EventArgs e)
        {
            GraphWindow graphWindow = new GraphWindow();
            graphWindow.Show();
        }
    }
}
