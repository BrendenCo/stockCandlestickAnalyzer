using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COP_2513__002
{
    internal abstract class aRecognizer
    {

        /// learning "Abstract Classes"
        /// abstract recognizer
        /// like : recognizer()
        /// {
        ///     make highlightcandlestickpatterns ? 
        /// }
        /// 
        /// basically making a new index list where 0 1 2 3  and doji at 1 and 3 but not the rest.
        /// recognizer provides: vvv
        /// string pattern name:
        /// int pattern size: (number of candlesticks in A pattern
        /// Abstract List <int> recognize(list<candlestickdata>)candlesticks);
        ///
        /// string PatternName {get; set;}
        ///
        /// int PatternSize {get; set;}
        /// 
        /// Recognizer(string pn = "?", int ps = 1)
        /// patternName = pn
        /// patternSize = ps
        
        /// public class Recognizer_Doji : Recognizer
        /// {
        ///      public Recognizer_Doji() : base("Doji",1) {}
        ///      {
        ///          
        ///          string x = PatternName;
        ///          
        ///      }
        /// }
        ///  

        
        public string patternName { get; set; }

        public int patternSize { get; set; }

        
        /// <summary>
        /// Abstract bool patternMatchedSubset uses list CandleStick
        /// </summary>
        /// <param name="subsetOfCandlesticks"></param>
        /// <returns></returns>
        protected abstract bool patternMatchedSubset(List<CandleStick> subsetOfCandlesticks);

        /// <summary>
        /// new list int and creates offset. Uses for loop that runs List CandleStick and if patternMatchedSubset we add offset.
        /// </summary>
        /// <param name="candlesticks"></param>
        /// <returns></returns>
        public List<int> recognize(List<CandleStick> candlesticks)
        {
            List<int> result = new List<int>(candlesticks.Count / 8);

            int offset = patternSize - 1;
            
            for (int i = offset; i < candlesticks.Count; ++i)
            {
                List<CandleStick> subset = candlesticks.GetRange(i - offset, patternSize);
                
                if (patternMatchedSubset(subset))
                {
                    result.Add(i);
                }
            }
            return result;
        
        }
        /// <summary>
        /// class aRecognizer
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pSize"></param>
        public aRecognizer(string pName, int pSize) => (patternName, patternSize) = (pName, pSize);

     
    }
}
