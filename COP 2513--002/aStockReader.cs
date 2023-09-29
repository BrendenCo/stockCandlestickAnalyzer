using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace COP_2513__002
{
    internal class aStockReader
    {


        /// <summary>
        /// constant
        /// </summary>
        const string dataFolder = @"Stock Data";
        
        /// <summary>
        /// aStockReader method
        /// </summary>
        public aStockReader() 
        {
            listOfCandlesticks = new List<CandleStick>(256);
        }

        ///set listOfCandlesticks to null
        public List<CandleStick> listOfCandlesticks = null;

        ///readListOfCandlesticks method
        public List<CandleStick> readListOfCandlesticks(string csvFilename, DateTime startDate, DateTime endDate)
        {
            char[] separators = new char[] { '-', '/', ',', '"'};
            ///Gets all lines as string array by ReadAllLines
            String[] lines = System.IO.File.ReadAllLines(csvFilename);

            ///Skips header
            String header = lines[0];
            if (header == "Date,Open,High,Low,Close,Adj Close,Volume")
            {

                listOfCandlesticks = new List<CandleStick>(lines.Length - 1);

                ///for loop
                for (int l = 1; l < lines.Length; ++l)
                {
                    ///get lth line
                    String line = lines[l].Trim();


                    ///split string function
                    string[] subStrings = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                    ///Date string year, month, day
                    int year = int.Parse(subStrings[0]);
                    int month = int.Parse(subStrings[1]);
                    int day = int.Parse(subStrings[2]);

                    ///Date object for the first 3 substrings
                    DateTime date = new DateTime(year, month, day);

                    if (date.CompareTo(startDate) > 0 && date.CompareTo(endDate) <= 0)
                    {

                        ///now just get other parts of the line. Open, High,Low, CLose, and volume
                        Double open = Double.Parse(subStrings[3]);
                        Double high = Double.Parse(subStrings[4]);
                        Double low = Double.Parse(subStrings[5]);
                        Double close = Double.Parse(subStrings[6]);
                        ///Double adj = Double.Parse(subStrings[7]);
                        long volume = long.Parse(subStrings[8]);
                        


                        ///Rounding 2 decimals
                        open = Math.Round(open, 2);
                        high = Math.Round(high, 2);
                        low = Math.Round(low, 2);
                        close = Math.Round(close, 2);

                        

                        ///New candlestick with open high low close volume date parameters
                        CandleStick candleStick = new CandleStick(date, open, high, low, close, volume);
                        ///Adding candleStick to the listOfCandlesticks
                        listOfCandlesticks.Add(candleStick);
                    }
                }
            }
            ///return listOfCandlesticks
            return listOfCandlesticks;
        }
        internal List<CandleStick> readStock(string ticker, DateTime startDate, DateTime endDate)
        {
            ///string tperiod
            ///create the filename for the ticker by concatinating the dataFolder name
            String csvFilename = dataFolder + @"\" + ticker ;
            
            ///go read the candlesticsk and return them as the listOfCandlesticks member
            ///string tperiod
            listOfCandlesticks = readListOfCandlesticks(csvFilename, startDate, endDate);

            return listOfCandlesticks;
        }

    }   
}
