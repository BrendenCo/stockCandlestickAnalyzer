using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.VisualStyles;
using System.Xml.Schema;
using COP_2513__002;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;


namespace COP_2513__002
{
    public partial class aStockGraphLoader : Form
    {
        
        
        /// <summary>
        /// new list candlesticks
        /// </summary>
        List<CandleStick> candlesticks = new List<CandleStick>();
        public aStockGraphLoader()
        {
            ///This code section loads the data into the graph with up color as blue and down color as red. 
            InitializeComponent();
            initializeRecognizers();


            Graph.Series["OHLC"].XValueMember = "Date";
            Graph.Series["OHLC"].YValuesPerPoint = 4;
            Graph.Series["OHLC"].YValueMembers = "High,Low,Open,Close";

            Graph.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineWidth = 0;
            Graph.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineWidth = 0;

            ///Open High Low Close or High Low Open Close
            Graph.Series["OHLC"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            Graph.Series["OHLC"].CustomProperties = "PriceDownColor=Red,PriceUpColor=Blue";


            ///This code allows the graph to be zoomed in and out on.
            Graph.ChartAreas["ChartArea1"].AxisX.ScaleView.Zoomable = true;
            Graph.ChartAreas["ChartArea1"].AxisY.ScaleView.Zoomable = true;
            Graph.ChartAreas["ChartArea1"].CursorX.AutoScroll = true;
            Graph.ChartAreas["ChartArea1"].CursorY.AutoScroll = true;
            Graph.ChartAreas["ChartArea1"].CursorX.IsUserSelectionEnabled = true;
            Graph.ChartAreas["ChartArea1"].CursorY.IsUserSelectionEnabled = true;



            ///stuff for lower graph aka the volume graph
            Graph.ChartAreas["ChartArea2"].AxisX.MajorGrid.LineWidth = 0;
            Graph.ChartAreas["ChartArea2"].AxisY.MajorGrid.LineWidth = 0;

            Graph.Series["Volume"].XValueMember = "Date";
            Graph.Series["Volume"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            Graph.Series["Volume"].YValuesPerPoint = 1;
            Graph.Series["Volume"].YValueMembers = "Volume";
            Graph.DataBind();



            

        }

        /// <summary>
        /// new list
        /// </summary>
        List<aRecognizer> recognizers = new List<aRecognizer>(32);

        /// <summary>
        /// list of recognizers connected to singlecandlestickreader... adds recognizer each time
        /// </summary>
        /// <returns></returns>
        private List<aRecognizer> initializeRecognizers()
        {
            aRecognizer recognizer = null;

            recognizer = new Recognizer_Bullish();
            recognizers.Add(recognizer); 

            recognizer = new Recognizer_Bearish();
            recognizers.Add(recognizer);

            recognizer = new Recognizer_Neutral();
            recognizers.Add(recognizer);
            
            recognizer = new Recognizer_Doji();
            recognizers.Add(recognizer);

            recognizer = new Recognizer_DragonflyDoji();
            recognizers.Add(recognizer);

            recognizer = new Recognizer_GravestoneDoji();
            recognizers.Add(recognizer);

            recognizer = new Recognizer_LongLeggedDoji();
            recognizers.Add(recognizer);

            recognizer = new Recognizer_Hammer();
            recognizers.Add(recognizer);

            recognizer = new Recognizer_BullishHammer();
            recognizers.Add(recognizer);

            recognizer = new Recognizer_BearishHammer();
            recognizers.Add(recognizer);

            recognizer = new Recognizer_InvertedHammer();
            recognizers.Add(recognizer);

            recognizer = new Recognizer_InvertedBullishHammer();
            recognizers.Add(recognizer);

            recognizer = new Recognizer_InvertedBearishHammer();
            recognizers.Add(recognizer);

            recognizer = new Recognizer_BullishEngulfing();
            recognizers.Add(recognizer);

            recognizer = new Recognizer_BearishEngulfing();
            recognizers.Add(recognizer);

            recognizer = new Recognizer_Marubozu();
            recognizers.Add(recognizer);

            recognizer = new Recognizer_WhiteMarubozu();
            recognizers.Add(recognizer);

            recognizer = new Recognizer_BlackMarubozu();
            recognizers.Add(recognizer);

            aComboBox_Pattern.Items.Clear();
            foreach (aRecognizer r in recognizers)
            {
                aComboBox_Pattern.Items.Add(r.patternName);
            }

            aComboBox_Pattern.Enabled = true;

            return recognizers;
            
        }

        /// <summary>
        /// calls updateChart(), clears annotations, and adds new list recog. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aComboBox_Pattern_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateChart();
            Graph.Annotations.Clear();
         
            aRecognizer recognizer = recognizers[aComboBox_Pattern.SelectedIndex];
            List<int> recog = recognizer.recognize(candlesticks);

            
            
            ///foreach loop that adds new annotation when called upon.
            foreach (int i in recog)
            { 
                RectangleAnnotation ra = new RectangleAnnotation();
                ra.Text = recognizer.patternName;
                ra.AnchorDataPoint = Graph.Series["OHLC"].Points[i];
                Graph.Annotations.Add(ra);
                   
            }




        }


        /// <summary>
        /// sets datasourse to CandleStick and if statement for candlesticks = dataSource.
        /// </summary>
        private void updateChart()
        {
            
            ///
            var dataSource = Graph.DataSource as List<CandleStick>;
            


            if (dataSource != null)
            {
                candlesticks = dataSource;

                double maxY = candlesticks.Max(cs => cs.High);
                double minY = candlesticks.Min(cs => cs.Low);
                double padding = 0.10 * (maxY - minY);

                Graph.ChartAreas["ChartArea1"].AxisY.Maximum = maxY + padding;
                Graph.ChartAreas["ChartArea1"].AxisY.Minimum = minY - padding;

            }
            
            
            
            
            

        }

    }
}
