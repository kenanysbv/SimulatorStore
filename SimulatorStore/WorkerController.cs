using SSModels.Vegetable;
using SSGeneral;
using SSExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSModels.Work;

namespace SS
{
    public class WorkerController
    {
        public WorkerController() { }

        public WorkerController(List<Worker> workers) => Workers = workers;



        public List<Worker> Workers { get; set; } = new();



        public void Check() => Workers.ForEach(w => w.Check());

        public void Preapere() => Workers.ForEach(w => w.Preapera());

        public void ControlWorker()
        {
            Workers.ForEach(delegate (Worker w)
            {
                if (w.IsEmpty())
                    Workers.Remove(w);
            });
        }

        public void GetNewWorker() { }

        public void AddBoxes() { }

    }
}
