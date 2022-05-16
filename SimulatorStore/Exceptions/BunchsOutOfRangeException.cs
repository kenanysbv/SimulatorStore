using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSExceptions
{
    public class BunchsOutOfRangeException : Exception
    {
        public BunchsOutOfRangeException(string message) => Message = message;

        public BunchsOutOfRangeException() { }


        public string Message { get; set; }
    }
}
