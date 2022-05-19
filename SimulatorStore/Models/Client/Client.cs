using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSGeneral;
using SSModels.Vegetable;

namespace SSModels.Client
{
    public class Client
    {
        public Client()
        {
            Random random = new Random();
            int countOfBunchs = random.Next(0, 10);
            for (int i = 0; i < countOfBunchs; i++)
                BunchOrders.Add(new(new(General.GetRandomVegetableType()), random.Next(0, 11)));
        }



        List<BunchOrder> BunchOrders = new();



        public void Buy(List<Shelf> Shelves)
        {
            //Shelves.ForEach(sh => sh.Bunches.
        }
    }
}
