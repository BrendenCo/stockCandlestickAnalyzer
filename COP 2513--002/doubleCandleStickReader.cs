using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COP_2513__002
{

    /// <summary>
    /// Classes for each double candlestick pattern type. This one is for Bullish Engulfing
    /// </summary>    

    internal class Recognizer_BullishEngulfing : aRecognizer
    {
            public Recognizer_BullishEngulfing() : base("Bullish Engulfing Pattern", 2) { }

            protected override bool patternMatchedSubset(List<CandleStick> subsetOfCandlesticks)
            {
                CandleStick pcs = subsetOfCandlesticks[0];
                CandleStick cs = subsetOfCandlesticks[1];
                return pcs.isBearish && cs.isBullish && pcs.High < cs.topPrice && pcs.Low > cs.bottomPrice;
            }

    }
    /// <summary>
    /// Classes for each single candlestick pattern type. This one is for Bearish Engulfing
    /// </summary>
    internal class Recognizer_BearishEngulfing : aRecognizer
    {
            public Recognizer_BearishEngulfing() : base("Bearish Engulfing Pattern", 2) { }

            protected override bool patternMatchedSubset(List<CandleStick> subsetOfCandlesticks)
            {
                CandleStick pcs = subsetOfCandlesticks[0];
                CandleStick cs = subsetOfCandlesticks[1];
                return pcs.isBullish && cs.isBearish && pcs.High < cs.topPrice && pcs.Low > cs.bottomPrice;
            }
    }

    
}
