using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSExceptions
{
    public class WorkerCorridorOurOfRange : Exception
    {
        public WorkerCorridorOurOfRange(string message) => Message = message;

        public WorkerCorridorOurOfRange() { }


        public string Message { get; set; }
    }
}
