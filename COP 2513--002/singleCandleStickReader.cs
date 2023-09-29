using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COP_2513__002
{

    /// <summary>
    /// Classes for each single candlestick pattern type. This one is for Bullish
    /// </summary>
    internal class Recognizer_Bullish : aRecognizer
    {
        public Recognizer_Bullish() : base("Bullish", 1) { }
        protected override bool patternMatchedSubset(List<CandleStick> subsetOfCandlesticks)
        {
            return subsetOfCandlesticks[0].isBullish;
        }

    }
    /// <summary>
    /// Classes for each single candlestick pattern type. This one is for Bearish
    /// </summary>
    internal class Recognizer_Bearish : aRecognizer
    {
        public Recognizer_Bearish() : base("Bearish", 1) { }
        protected override bool patternMatchedSubset(List<CandleStick> subsetOfCandlesticks)
        {
            return subsetOfCandlesticks[0].isBearish;
        }

    }
    /// <summary>
    /// Classes for each single candlestick pattern type. This one is for Neutral
    /// </summary>
    internal class Recognizer_Neutral : aRecognizer
    {
        public Recognizer_Neutral() : base("Neutral", 1) { }
        protected override bool patternMatchedSubset(List<CandleStick> subsetOfCandlesticks)
        {
            return subsetOfCandlesticks[0].isNeutral;
        }
    }

    /// <summary>
    /// Classes for each single candlestick pattern type. This one is for Doji
    /// </summary>
    internal class Recognizer_Doji : aRecognizer
    {
        public Recognizer_Doji() : base("Doji", 1) { }
        protected override bool patternMatchedSubset(List<CandleStick> subsetOfCandlesticks)
        {
            return subsetOfCandlesticks[0].isDoji;
        }
    }
    /// <summary>
    /// Classes for each single candlestick pattern type. This one is for Dragonfly
    /// </summary>
    internal class Recognizer_DragonflyDoji : aRecognizer
    {
        public Recognizer_DragonflyDoji() : base("Dragonfly Doji", 1) { }
        protected override bool patternMatchedSubset(List<CandleStick> subsetOfCandlesticks)
        {
            return subsetOfCandlesticks[0].isDragonflyDoji;
        }
    }
    /// <summary>
    /// Classes for each single candlestick pattern type. This one is for Neutral
    /// </summary>
    internal class Recognizer_NeutralDoji : aRecognizer
    {
        public Recognizer_NeutralDoji() : base("Neutral Doji", 1) { }
        protected override bool patternMatchedSubset(List<CandleStick> subsetOfCandlesticks)
        {
            return subsetOfCandlesticks[0].isNeutralDoji;
        }
    }

    /// <summary>
    /// Classes for each single candlestick pattern type. This one is for Gravestone Doji
    /// </summary>
    internal class Recognizer_GravestoneDoji : aRecognizer
    {
        public Recognizer_GravestoneDoji() : base("Gravestone Doji", 1) { }
        protected override bool patternMatchedSubset(List<CandleStick> subsetOfCandlesticks)
        {
            return subsetOfCandlesticks[0].isGravestoneDoji;
        }
    }
    /// <summary>
    /// Classes for each single candlestick pattern type. This one is for Long-Legged
    /// </summary>
    internal class Recognizer_LongLeggedDoji : aRecognizer
    {
        public Recognizer_LongLeggedDoji() : base("Long-Legged Doji", 1) { }
        protected override bool patternMatchedSubset(List<CandleStick> subsetOfCandlesticks)
        {
            return subsetOfCandlesticks[0].isLongLeggedDoji;
        }
    }
    /// <summary>
    /// Classes for each single candlestick pattern type. This one is for Hammer
    /// </summary>
    internal class Recognizer_Hammer : aRecognizer
    {
        public Recognizer_Hammer() : base("Hammer", 1) { }
        protected override bool patternMatchedSubset(List<CandleStick> subsetOfCandlesticks)
        {
            return subsetOfCandlesticks[0].isHammer;
        }
    }
    /// <summary>
    /// Classes for each single candlestick pattern type. This one is for Bullish Hammer
    /// </summary>
    internal class Recognizer_BullishHammer : aRecognizer
    {
        public Recognizer_BullishHammer() : base("Bullish Hammer", 1) { }
        protected override bool patternMatchedSubset(List<CandleStick> subsetOfCandlesticks)
        {
            return subsetOfCandlesticks[0].isBullishHammer;
        }
    }
    /// <summary>
    /// Classes for each single candlestick pattern type. This one is for Bearish Hammer 
    /// </summary>
    internal class Recognizer_BearishHammer : aRecognizer
    {
        public Recognizer_BearishHammer() : base("Bearish Hammer", 1) { }
        protected override bool patternMatchedSubset(List<CandleStick> subsetOfCandlesticks)
        {
            return subsetOfCandlesticks[0].isBearishHammer;
        }
    }
    /// <summary>
    /// Classes for each single candlestick pattern type. This one is for Inverted Hammer
    /// </summary>
    internal class Recognizer_InvertedHammer : aRecognizer
    {
        public Recognizer_InvertedHammer() : base("Inverted Hammer", 1) { }
        protected override bool patternMatchedSubset(List<CandleStick> subsetOfCandlesticks)
        {
            return subsetOfCandlesticks[0].isInvertedHammer;
        }
    }
    /// <summary>
    /// Classes for each single candlestick pattern type. This one is for Inverted Bullish Hammer
    /// </summary>
    internal class Recognizer_InvertedBullishHammer : aRecognizer
    {
        public Recognizer_InvertedBullishHammer() : base("Inverted Bullish Hammer", 1) { }
        protected override bool patternMatchedSubset(List<CandleStick> subsetOfCandlesticks)
        {
            return subsetOfCandlesticks[0].isInvertedBullishHammer;
        }
    }
    /// <summary>
    /// Classes for each single candlestick pattern type. This one is for Inverted Bearish Hammer
    /// </summary>
    internal class Recognizer_InvertedBearishHammer : aRecognizer
    {
        public Recognizer_InvertedBearishHammer() : base("Inverted Bearish Hammer", 1) { }
        protected override bool patternMatchedSubset(List<CandleStick> subsetOfCandlesticks)
        {
            return subsetOfCandlesticks[0].isInvertedBearishHammer;
        }
    }
    /// <summary>
    /// Classes for each single candlestick pattern type. This one is for Marubozu
    /// </summary>
    internal class Recognizer_Marubozu : aRecognizer
    {
        public Recognizer_Marubozu() : base("Marubozu", 1) { }
        protected override bool patternMatchedSubset(List<CandleStick> subsetOfCandlesticks)
        {
            return subsetOfCandlesticks[0].isMarubozu;
        }
    }
    /// <summary>
    /// Classes for each single candlestick pattern type. This one is for White Marubozu
    /// </summary>
    internal class Recognizer_WhiteMarubozu : aRecognizer
    {
        public Recognizer_WhiteMarubozu() : base("White Marubozu", 1) { }
        protected override bool patternMatchedSubset(List<CandleStick> subsetOfCandlesticks)
        {
            return subsetOfCandlesticks[0].isWhiteMarubozu;
        }
    }
    /// <summary>
    /// Classes for each single candlestick pattern type. This one is for Black Marubozu
    /// </summary>
    internal class Recognizer_BlackMarubozu : aRecognizer
    {
        public Recognizer_BlackMarubozu() : base("Black Marubozu", 1) { }
        protected override bool patternMatchedSubset(List<CandleStick> subsetOfCandlesticks)
        {
            return subsetOfCandlesticks[0].isBlackMarubozu;
        }
    }








}