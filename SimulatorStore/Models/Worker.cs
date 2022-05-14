using SSExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSModels
{
    public class Worker
    {
        public Worker(List<Aisle> corridor, int salary)
        {
            Salary = salary;
            if (corridor.Count > 2)
                throw new WorkerCorridorOurOfRange();
            try
            {
                Corridor = corridor;
            }
            catch (AisleArgumentOutOfRange ex)
            {

            }
        }

        public int Salary { get; set; }

        public List<Aisle> Corridor { get; set; }



        public bool IsFull() => Corridor.Count == 2;
    }
}
