using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSExceptions
{
    public class BunchVegetablesOutOfRangeException : Exception
    {
        public BunchVegetablesOutOfRangeException(string message) => Message = message;

        public BunchVegetablesOutOfRangeException() { }


        public string Message { get; set; }
    }
}
