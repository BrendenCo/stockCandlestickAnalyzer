namespace COP_2513__002
{
    partial class aStockGraphLoader
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.aComboBox_Pattern = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Graph)).BeginInit();
            this.SuspendLayout();
            // 
            // Graph
            // 
            this.Graph.BackColor = System.Drawing.Color.Pink;
            chartArea1.BackColor = System.Drawing.Color.MistyRose;
            chartArea1.Name = "ChartArea1";
            chartArea2.AlignWithChartArea = "ChartArea1";
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            chartArea2.Name = "ChartArea2";
            this.Graph.ChartAreas.Add(chartArea1);
            this.Graph.ChartAreas.Add(chartArea2);
            this.Graph.Dock = System.Windows.Forms.DockStyle.Top;
            legend1.BackColor = System.Drawing.Color.Moccasin;
            legend1.BorderColor = System.Drawing.Color.Black;
            legend1.Name = "Legend1";
            this.Graph.Legends.Add(legend1);
            this.Graph.Location = new System.Drawing.Point(0, 0);
            this.Graph.Name = "Graph";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
            series1.Legend = "Legend1";
            series1.Name = "OHLC";
            series1.YValuesPerPoint = 4;
            series2.ChartArea = "ChartArea2";
            series2.Color = System.Drawing.Color.Green;
            series2.Legend = "Legend1";
            series2.Name = "Volume";
            series2.ShadowColor = System.Drawing.Color.Gray;
            this.Graph.Series.Add(series1);
            this.Graph.Series.Add(series2);
            this.Graph.Size = new System.Drawing.Size(1548, 787);
            this.Graph.TabIndex = 0;
            this.Graph.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 802);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Patterns";
            // 
            // aComboBox_Pattern
            // 
            this.aComboBox_Pattern.FormattingEnabled = true;
            this.aComboBox_Pattern.Location = new System.Drawing.Point(12, 825);
            this.aComboBox_Pattern.Name = "aComboBox_Pattern";
            this.aComboBox_Pattern.Size = new System.Drawing.Size(205, 28);
            this.aComboBox_Pattern.TabIndex = 2;
            this.aComboBox_Pattern.Text = "Choose";
            this.aComboBox_Pattern.SelectedIndexChanged += new System.EventHandler(this.aComboBox_Pattern_SelectedIndexChanged);
            // 
            // aStockGraphLoader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1548, 865);
            this.Controls.Add(this.aComboBox_Pattern);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Graph);
            this.Name = "aStockGraphLoader";
            this.Text = "aStockGraphLoader";
            ((System.ComponentModel.ISupportInitialize)(this.Graph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataVisualization.Charting.Chart chartStock;
        public System.Windows.Forms.DataVisualization.Charting.Chart Graph;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox aComboBox_Pattern;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}