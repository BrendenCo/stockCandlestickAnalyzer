using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace COP_2513__002
{
    internal class CandleStick
    {
        /// making parameters able to be returned and changable.
        public DateTime Date { get; set; }
        public double Open { get; set; }
        public double High { get; set; }
        public double Low { get; set; }
        public double Close { get; set; }
        public long Volume { get; set; }

        public string Ticker { get; set; }
        public string TPeriod { get; set; }
        
        /// candlestick parts
        public double range { get; private set; }
        public double body { get; private set; }

        public double upperTail { get; private set; }

        public double lowerTail { get; private set; }

        public double topPrice { get; private set; }
        public double bottomPrice { get; private set; }

       
        /// <summary>
        /// using computeProperties() and setting values to one another.
        /// </summary>
        /// <param name="date"></param>
        /// <param name="open"></param>
        /// <param name="high"></param>
        /// <param name="low"></param>
        /// <param name="close"></param>
        /// <param name="volume"></param>
        public CandleStick(DateTime date, double open, double high, double low, double close, long volume)
        {

            this.Date = date;
            this.Open = open;
            this.High = high;
            this.Low = low;
            this.Close = close;
            this.Volume = volume;

            
            computeProperties();
        }
        
       

        ///Bullish bearish neutral

        public Boolean isBullish { get; private set; }

        public Boolean isBearish { get; private set; }

        public Boolean isNeutral { get; private set; }


        ///Dojis 
        
        public Boolean isDoji { get; private set; }
        public Boolean isNeutralDoji { get; private set; }
        public Boolean isDragonflyDoji { get; private set; }
        public Boolean isGravestoneDoji { get; private set; }
        public Boolean isLongLeggedDoji { get; private set; }

        /// <summary>
        /// Hammers
        /// </summary>
        public Boolean isHammer { get; private set; }
        public Boolean isBullishHammer { get; private set; }
        public Boolean isBearishHammer { get; private set; }
        public Boolean isInvertedHammer { get; private set; }
        public Boolean isInvertedBullishHammer { get; private set; }
        public Boolean isInvertedBearishHammer { get; private set; }

        ///Marubozu <summary>
        /// Marubozus
        /// </summary>
        public Boolean isMarubozu { get; private set; }
        public Boolean isWhiteMarubozu { get; private set; }

        public Boolean isBlackMarubozu { get; private set; }

        /// <summary>
        /// Below are the candlestick identifiers. They use tolerances and simple math to determine whether to return true or false- identifying whether a pattern is there or not.
        /// </summary>
        /// <param name="bodyTolerance"></param>
        /// <returns></returns>
        public Boolean dojiHere(double bodyTolerance = 0.10)
        {
            return body <= bodyTolerance * range;
        }
        public Boolean neutralDojiHere(double bodyTolerance = 0.05)
        {
            return dojiHere(bodyTolerance) && (dragonflyDojiHere() != true) && (gravestoneDojiHere() != true);
        }
        public Boolean dragonflyDojiHere(double bodyTolerance = 0.10, double upperTailTolerance = 0.15)
        {
            return dojiHere(bodyTolerance) && (upperTail <= range * upperTailTolerance);
        }

        public Boolean gravestoneDojiHere(double bodyTolerance = 0.15, double lowerTailTolerance = 0.15)
        { 
            return dojiHere(bodyTolerance) && (lowerTail <= range * lowerTailTolerance);
        }
        public Boolean longLeggedDojiHere(double bodyTolerance = 0.05)
        { 
            return dojiHere(bodyTolerance);
        }
        public Boolean hammerHere(double minBodyTolerance = 0.15, double maxBodyTolerance = 0.25, double upperTailTolerance = 0.05)
        {
            return (minBodyTolerance * range <= body) && (maxBodyTolerance * range <= body) && (upperTail <= upperTailTolerance);
        }
        public Boolean bullishHammerHere(double minBodyTolerance = 0.15, double maxBodyTolerance = 0.25, double upperTailTolerance = 0.1)
        {
            return hammerHere(minBodyTolerance, maxBodyTolerance, upperTailTolerance) && (Close > Open);
        }
        public Boolean bearishHammerHere(double minBodyTolerance = 0.15, double maxBodyTolerance = 0.25, double upperTailTolerance = 0.10)
        {
            return hammerHere(minBodyTolerance, maxBodyTolerance, upperTailTolerance) && (Close < Open);

        }
        public Boolean invertedHammerHere(double minBodyTolerance = 0.15, double maxBodyTolerance = 0.25, double lowerTailTolerance = 0.05)
        {
            return (minBodyTolerance * range <= body) && (maxBodyTolerance * range <= body) && (lowerTail <= lowerTailTolerance * range);
        }
        public Boolean bullishInvertedHammerHere(double bodyTolerance = 0.03)
        {
            return invertedHammerHere(bodyTolerance) && isBullish == true;
        }
        public Boolean bearishInvertedHammerHere(double bodyTolerance = 0.03)
        {
            return invertedHammerHere(bodyTolerance) && isBearish == true;
        }

        public Boolean marubozuHere(double bodyTolerance = 0.10)
        {
            return body > range * (1 - bodyTolerance);
        }
        public Boolean whiteMarubozuHere(double bodyTolerance = 0.10)
        {
            return marubozuHere(bodyTolerance) && (isBullish == true);
        }

        public Boolean blackMarubozuHere(double bodyTolerance = 0.10)
        {
            return marubozuHere(bodyTolerance) && (isBearish == true);
        }

        /// <summary>
        /// computeProperties() sets commonly used items, range, body, topPrice, etc. Additionally calls computePatterns();
        /// </summary>
        private void computeProperties()
        { 
            range = High - Low;
            body = Math.Max(Open, Close) - Math.Min(Open, Close);
            topPrice = Math.Max(Open, Close);
            bottomPrice = Math.Min(Open, Close);
            upperTail = High - topPrice;
            lowerTail = bottomPrice - Low;

            computePatterns();
            
        }
        /// <summary>
        /// computePatterns() sets local variables to the identifier booleans.
        /// </summary>
        private void computePatterns()
        {
            ///general 
            isBullish = Close > Open;
            isBearish = Close < Open;
            isNeutral = Close == Open;
            ///Dojis
            isDoji = dojiHere();
            isDragonflyDoji = dragonflyDojiHere();
            isNeutralDoji = neutralDojiHere();
            isGravestoneDoji = gravestoneDojiHere();
            isLongLeggedDoji = longLeggedDojiHere();
            
            ///Hammers
            isHammer = hammerHere();
            isBullishHammer = bullishHammerHere();
            isBearishHammer = bearishHammerHere();

            ///Inverted hammer
            ///
            isInvertedHammer = invertedHammerHere();
            isInvertedBullishHammer = bullishInvertedHammerHere();
            isInvertedBearishHammer = bearishInvertedHammerHere();

            ///marubozu
            isMarubozu = marubozuHere();
            isWhiteMarubozu = whiteMarubozuHere();
            isBlackMarubozu = blackMarubozuHere();

        }



    }
}