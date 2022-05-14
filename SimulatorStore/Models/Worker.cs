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
        public Worker(List<Aisle> corridors, int salary)
        {
            Salary = salary;
            if (corridors.Count > 2)
                throw new WorkerCorridorOurOfRange();
            try
            {
                Corridor = corridors;
            }
            catch (AisleArgumentOutOfRange ex)
            {
                for (int i = 0; i < corridors.Count; i++)
                {
                    if (corridors[i].Shelves.Count > 2)
                    {
                        // When Vegetable Count Out Of Range
                        //Corridor.Add(new(corridors[i].Shelves));
                    }
                    else
                        Corridor.Add(new(corridors[i].Shelves));
                }
            }
        }

        public int Salary { get; set; }

        public List<Aisle> Corridor { get; set; }


        public void Check()
        {
            Corridor.ForEach(a => a.Shelves.ForEach(s =>
            s.Bunchs.ForEach(b =>
            b.Vegetables = new
            (
                b.Vegetables
                .Where(a => a.Status == VStatus.Rotten || a.Status == VStatus.Toxic)
            )
             )));
        }

        public void Preapera()
        {
            Corridor.ForEach(a => a.Shelves.ForEach(s =>
            s.Bunchs.ForEach(delegate (BunchVegetables b)
            {
                BunchVegetables temp = new(b.Vegetables);
                b.Vegetables.Clear();

                // Get *New Vegetable
                temp.Vegetables.Where(tb => tb.Status == VStatus.New)
                    .ToList()
                    .ForEach(v => b.Vegetables.Push(v));

                // Get *Good Vegetable
                temp.Vegetables.Where(tb => tb.Status == VStatus.Good)
                    .ToList()
                    .ForEach(v => b.Vegetables.Push(v));

            })
            ));
        }

        public bool IsFull() => Corridor.Count == 2;
    }
}
