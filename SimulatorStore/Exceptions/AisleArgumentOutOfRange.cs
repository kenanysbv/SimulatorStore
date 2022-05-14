using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSExceptions
{
    public class AisleArgumentOutOfRange : Exception
    {
        public AisleArgumentOutOfRange(string message) => Message = message;

        public AisleArgumentOutOfRange() { }


        public string Message { get; set; }
    }
}
