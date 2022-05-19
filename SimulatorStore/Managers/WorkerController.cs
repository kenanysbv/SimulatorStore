using SSModels.Vegetable;
using SSGeneral;
using SSExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSModels.Work;

namespace SSManagers
{
    public class WorkerController
    {
        public WorkerController() { }

        public WorkerController(List<Worker> workers) => Workers = workers;



        public List<Worker> Workers { get; set; } = new();



        public void Check() => Workers.ForEach(w => w.Check());

        public void Preapere() => Workers.ForEach(w => w.Preapera());

        public void ClearWorker()
        {
            Workers.ForEach(delegate (Worker w)
            {
                if (w.IsEmpty())
                    Workers.Remove(w);
            });
        }

        public void GetNewWorker(ref List<Shelf> Shelves)
        {
            int countOfFree = Shelves.FindAll(s => s.MWorker == null).Count;
            if (countOfFree > 0)
                while (Shelves.FindAll(s => s.MWorker == null).Count > 0)
                    Workers.Add(new(ref Shelves));
        }
    }
}
