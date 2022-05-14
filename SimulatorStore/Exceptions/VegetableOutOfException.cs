using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSExceptions
{
    public class VegetableOutOfException : Exception
    {
        public VegetableOutOfException(string message) => Message = message;

        public VegetableOutOfException() { }



        public string Message { get; set; }

    }
}
