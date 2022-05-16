using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSExceptions
{
    public class WorkerShelvesOurOfRange : Exception
    {
        public WorkerShelvesOurOfRange(string message) => Message = message;

        public WorkerShelvesOurOfRange() { }


        public string Message { get; set; }
    }
}
