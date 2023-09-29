using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace COP_2513__002
{
    public partial class FormStockLoader : Form
    {

        ///defining stockReader to null
        aStockReader stockReader= null;
        List<CandleStick> listOfCandlesticks = null;
        FileInfo[] Files = null;
        

        public static FormStockLoader instance;
        
        public FormStockLoader()
        {
            InitializeComponent();
            

            stockReader = new aStockReader();
            instance = this;
            ///used for obtaining stocks inputed by TA
            string fileName = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
            string filePath = fileName + "/Stock Data/";
            DirectoryInfo directory = new DirectoryInfo(filePath);
            Files = directory.GetFiles("*.csv");

            


        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /// TODO: This line of code loads data into the 'aDatabaseDataSet.aCandleStick' table. You can move, or remove it, as needed.
            this.aCandleStickTableAdapter.Fill(this.aDatabaseDataSet.aCandleStick);
            Text = "I was loaded";
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }


        private void buttonLoadTicker(object sender, EventArgs e)
        {
            ///if else statements for changing day/week/month
            string dayWeekMonthFileSlot = String.Empty;
            if (radioButtonDaily.Checked)
            {
                dayWeekMonthFileSlot = "Day";
            }
            else if (radioButtonWeekly.Checked)
            {
                dayWeekMonthFileSlot = "Week";
            }
            
            else if (radioButtonMonthly.Checked)
            {
                dayWeekMonthFileSlot = "Month";
            }
            else
            {
                dayWeekMonthFileSlot = "Day";
            }



            Text = "We pressed the button";
            ///when form is loaded, this code has the Daily radio button activate
            radioButtonDaily.Visible = true;

            ///period box code connecting the buttons to their functions
            string period = String.Empty;
            if (radioButtonDaily.Checked) { period = "Day"; }
            else if (radioButtonWeekly.Checked) { period = "Week"; }
            else if (radioButtonMonthly.Checked) { period = "Month"; }
            else { period = "Day"; };


            listOfCandlesticks = stockReader.readStock(aComboBox_Ticker.Text, dateTimePickerStartDate.Value, dateTimePickerEndDate.Value);


            aStockGraphLoader loader = new aStockGraphLoader();
            loader.Graph.DataSource = listOfCandlesticks;
            
            if (radioButtonChart.Checked)
            {
                loader.Show();
            }
            else
            {
                loader.Hide();  
            }


            
        }

        private void labelLoadTicker_Enter(object sender, EventArgs e)
        {
            
        }

        private void radioButtonDaily_CheckedChanged(object sender, EventArgs e)
        {
            ///updated to look at files in stock folder for day, and add them to the combo box.
            string period = String.Empty;
            period = "Day";
            aComboBox_Ticker.Items.Clear();
            foreach (FileInfo file in Files)
            {
                if ((file.Name).Contains(period))
                {
                    aComboBox_Ticker.Items.Add(file.Name);
                }
            }
            
        }
        private void radioButtonWeekly_CheckedChanged(object sender, EventArgs e)
        {

            ///updated to look at files in stock folder for week, and add them to the combo box.

            string period = String.Empty;
            period = "Week";
            aComboBox_Ticker.Items.Clear();
            foreach (FileInfo file in Files)
            {
                if ((file.Name).Contains(period))
                {
                    aComboBox_Ticker.Items.Add(file.Name);
                }
            }
            
        }
        private void radioButtonMonthly_CheckedChanged(object sender, EventArgs e)
        {
            ///updated to look at files in stock folder for month, and add them to the combo box.

            string period = String.Empty;
            period = "Month";
            aComboBox_Ticker.Items.Clear();
            foreach (FileInfo file in Files)
            {
                if ((file.Name).Contains(period))
                {
                    aComboBox_Ticker.Items.Add(file.Name);
                }
            }

        }

        private void aComboBox_Ticker_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
