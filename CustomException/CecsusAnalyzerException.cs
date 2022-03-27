using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CensusAnalyzer_Day29.CustomException
{
   public class CecsusAnalyzerException:Exception
    {
        public string exceptionMessage;
        private string v;

        public CecsusAnalyzerException(string Message):base(Message)
        {
            exceptionMessage = Message;
        }

        public CecsusAnalyzerException(string Message, string v) : this(Message)
        {
            this.v = v;
        }
    }
}
