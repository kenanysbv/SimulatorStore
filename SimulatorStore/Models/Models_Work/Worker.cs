using SSExceptions;
using SSGeneral;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSInterfaces;
using SSModels.Vegetable;
namespace SSModels.Work
{
    public class Worker : ICalculateListCount
    {
        public Worker(List<Shelf> shelves, bool autoAdd = true)
        {
            if (shelves.Count > (int)Capacitys.Worker && !autoAdd)
                throw new WorkerShelvesOurOfRange();
            else if (shelves.Count > (int)Capacitys.Worker && autoAdd)
            {
                Shelves.AddRange(shelves.GetRange(0, FreeSpace()));
            }
            Shelves = shelves;

        }

        public Worker() { }



        public List<Shelf> Shelves { get; set; } = new();



        public void Check()
        {
            // Remeove unsuseful bunvhes
            Shelves.
                ForEach(s => s.Remove(
                 new List<Bunch>(s.Bunches.ToList()
                .Where(b =>
                b.Status == BStatus.Rotten ||
                b.Status == BStatus.Toxic
                ))
                ));

            // Remve empty shelfs
            Shelves.ForEach(delegate (Shelf s)
            {
                if (s.IsEmpty())
                    Shelves.Remove(s);
            });
        }

        public void Preapera()
        {
            Shelves.ForEach(delegate (Shelf s)
            {
                Stack<Bunch> temp = new();

                // For *New Bunches
                s.Bunches.ToList().FindAll(tb => tb.Status == BStatus.New)
                .ForEach(v => temp.Push(v));

                // For *Good Bunches
                s.Bunches.ToList().FindAll(tb => tb.Status == BStatus.Good)
                .ForEach(v => temp.Push(v));

                // For *OldGood Bunches
                s.Bunches.ToList().FindAll(tb => tb.Status == BStatus.OldGood)
                .ForEach(v => temp.Push(v));

                s.Bunches.Clear();
                s.Bunches = temp;
            }
            );
        }

        public int FreeSpace() => (int)Capacitys.Worker - Shelves.Count;

        public bool IsEmpty() => Shelves.Count == 0;

        public bool IsFull() => Shelves.Count == (int)Capacitys.Worker;
    }
}

