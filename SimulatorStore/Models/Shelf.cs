using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSExceptions;

namespace SSModels
{
    public class Shelf
    {
        public Shelf(List<BunchVegetables> bunchs)
        {
            // Check bunchs number
            if (bunchs.Count > 20)
                throw new BunchVegetablesOutOfRangeException($"{bunchs.Count}");

            try
            {
                Bunchs = bunchs;
            }
            catch (VegetableOutOfException ex)
            {
                for (int i = 0; i < bunchs.Count; i++)
                {
                    // When Vegetable Count Out Of Range
                    if (bunchs[i].Vegetables.Count > 10)
                    {
                        int count = Convert.ToInt32(ex.Message);
                        while (count > 0)
                        {
                            if (count < 10)
                            {
                                Bunchs.Add(new(bunchs[i].VegetableType, count));
                                return;
                            }
                            else
                            {
                                Bunchs.Add(new(bunchs[i].VegetableType));
                                count -= 10;
                            }
                        }
                    }
                    else
                        Bunchs.Add(new(bunchs[i].VegetableType));
                }
            }
        }

        public Shelf(BunchVegetables bunch, int count)
        {
            if (count > 20)
                throw new ArgumentOutOfRangeException();

            for (int i = 0; i < count; i++)
                Bunchs.Add(bunch);

        }

        public Shelf(BunchVegetables bunch)
        {
            for (int i = 0; i < 20; i++)
                Bunchs.Add(bunch);
        }


        public List<BunchVegetables> Bunchs { get; set; }

    }
}
