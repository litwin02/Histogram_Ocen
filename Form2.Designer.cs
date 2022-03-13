
namespace Histogram_Ocen
{
    partial class GraphWindow
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bt_generate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.graph)).BeginInit();
            this.SuspendLayout();
            // 
            // graph
            // 
            chartArea1.Name = "ChartArea1";
            this.graph.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.graph.Legends.Add(legend1);
            this.graph.Location = new System.Drawing.Point(32, 21);
            this.graph.Name = "graph";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.graph.Series.Add(series1);
            this.graph.Size = new System.Drawing.Size(751, 497);
            this.graph.TabIndex = 0;
            this.graph.Text = "chart1";
            // 
            // bt_generate
            // 
            this.bt_generate.Location = new System.Drawing.Point(800, 21);
            this.bt_generate.Name = "bt_generate";
            this.bt_generate.Size = new System.Drawing.Size(112, 47);
            this.bt_generate.TabIndex = 1;
            this.bt_generate.Text = "Generuj wykres";
            this.bt_generate.UseVisualStyleBackColor = true;
            this.bt_generate.Click += new System.EventHandler(this.bt_generate_Click);
            // 
            // GraphWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 572);
            this.Controls.Add(this.bt_generate);
            this.Controls.Add(this.graph);
            this.Name = "GraphWindow";
            this.Text = "Histogram";
            ((System.ComponentModel.ISupportInitialize)(this.graph)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart graph;
        private System.Windows.Forms.Button bt_generate;
    }
}