
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
            this.bt_generate = new System.Windows.Forms.Button();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bt_change_color = new System.Windows.Forms.Button();
            this.bt_disable_legend = new System.Windows.Forms.Button();
            this.cb_chart_type = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_save_to_txt = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_generate
            // 
            this.bt_generate.Location = new System.Drawing.Point(800, 12);
            this.bt_generate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_generate.Name = "bt_generate";
            this.bt_generate.Size = new System.Drawing.Size(112, 47);
            this.bt_generate.TabIndex = 1;
            this.bt_generate.Text = "Generuj wykres";
            this.bt_generate.UseVisualStyleBackColor = true;
            this.bt_generate.Click += new System.EventHandler(this.bt_generate_Click);
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(13, 12);
            this.chart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(781, 485);
            this.chart.TabIndex = 2;
            this.chart.Text = "chart1";
            // 
            // bt_change_color
            // 
            this.bt_change_color.Enabled = false;
            this.bt_change_color.Location = new System.Drawing.Point(800, 65);
            this.bt_change_color.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_change_color.Name = "bt_change_color";
            this.bt_change_color.Size = new System.Drawing.Size(112, 47);
            this.bt_change_color.TabIndex = 3;
            this.bt_change_color.Text = "Zmień kolor wykresu";
            this.bt_change_color.UseVisualStyleBackColor = true;
            this.bt_change_color.Click += new System.EventHandler(this.bt_change_color_Click);
            // 
            // bt_disable_legend
            // 
            this.bt_disable_legend.Enabled = false;
            this.bt_disable_legend.Location = new System.Drawing.Point(800, 118);
            this.bt_disable_legend.Margin = new System.Windows.Forms.Padding(4);
            this.bt_disable_legend.Name = "bt_disable_legend";
            this.bt_disable_legend.Size = new System.Drawing.Size(112, 47);
            this.bt_disable_legend.TabIndex = 4;
            this.bt_disable_legend.Text = "Wyświetlanie Legendy";
            this.bt_disable_legend.UseVisualStyleBackColor = true;
            this.bt_disable_legend.Click += new System.EventHandler(this.bt_disable_legend_Click);
            // 
            // cb_chart_type
            // 
            this.cb_chart_type.Enabled = false;
            this.cb_chart_type.FormattingEnabled = true;
            this.cb_chart_type.Location = new System.Drawing.Point(747, 532);
            this.cb_chart_type.Margin = new System.Windows.Forms.Padding(4);
            this.cb_chart_type.Name = "cb_chart_type";
            this.cb_chart_type.Size = new System.Drawing.Size(160, 24);
            this.cb_chart_type.TabIndex = 5;
            this.cb_chart_type.SelectedIndexChanged += new System.EventHandler(this.cb_chart_type_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(645, 535);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Typ Wykresu";
            // 
            // bt_save_to_txt
            // 
            this.bt_save_to_txt.Enabled = false;
            this.bt_save_to_txt.Location = new System.Drawing.Point(800, 172);
            this.bt_save_to_txt.Margin = new System.Windows.Forms.Padding(4);
            this.bt_save_to_txt.Name = "bt_save_to_txt";
            this.bt_save_to_txt.Size = new System.Drawing.Size(112, 47);
            this.bt_save_to_txt.TabIndex = 7;
            this.bt_save_to_txt.Text = "Zapisz wyniki do pliku txt";
            this.bt_save_to_txt.UseVisualStyleBackColor = true;
            this.bt_save_to_txt.Click += new System.EventHandler(this.bt_save_to_txt_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(747, 532);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 8;
            // 
            // GraphWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 572);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.bt_save_to_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_chart_type);
            this.Controls.Add(this.bt_disable_legend);
            this.Controls.Add(this.bt_change_color);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.bt_generate);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GraphWindow";
            this.Text = "Histogram";
            this.Load += new System.EventHandler(this.GraphWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bt_generate;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button bt_change_color;
        private System.Windows.Forms.Button bt_disable_legend;
        private System.Windows.Forms.ComboBox cb_chart_type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_save_to_txt;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}