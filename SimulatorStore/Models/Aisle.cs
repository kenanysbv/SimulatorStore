using SSExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSModels
{
    public class Aisle
    {
        public Aisle(List<Shelf> shelves)
        {
            if (shelves.Count > 2)
                throw new AisleArgumentOutOfRange($"{shelves.Count}");
            try
            {
                Shelves = shelves;
            }
            catch (BunchVegetablesOutOfRangeException ex)
            {
                for (int i = 0; i < shelves.Count; i++)
                {
                    if (shelves[i].Bunchs.Count > 20)
                    {
                        int count = Convert.ToInt32(ex.Message);
                        while (count > 0)
                        {
                            if (count < 20)
                            {
                                Shelves.Add(new(shelves[i].Bunchs[0], count));
                                return;
                            }
                            else
                            {
                                Shelves.Add(new(shelves[i].Bunchs.First()));
                                count -= 20;
                            }
                        }
                    }
                    else
                        Shelves.Add(new(shelves[i].Bunchs.First()));
                }
            }


        }




        public List<Shelf> Shelves { get; set; }
    }
}
