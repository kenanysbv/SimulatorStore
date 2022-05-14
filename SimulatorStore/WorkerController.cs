using SSModels;
using SSGeneral;
using SSExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SS
{
    public class WorkerController
    {
        public WorkerController() { }

        public WorkerController(List<Worker> workers) => Workers = workers;



        public List<Worker> Workers { get; set; }



        public void Check() => Workers.ForEach(w => w.Check());

        public void Preapere() => Workers.ForEach(w => w.Preapera());

        public void CheckForNewWorkers() { }
    }
}
