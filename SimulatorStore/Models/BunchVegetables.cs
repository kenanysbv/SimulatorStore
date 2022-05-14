using SSModels;
using SSExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSModels
{
    public class BunchVegetables
    {
        public BunchVegetables(Vegetable vegetable, int count)
        {
            if (count > 10)
                throw new ArgumentOutOfRangeException();

            for (int i = 0; i < count; i++)
                Vegetables.Push(new(vegetable));

        }

        public BunchVegetables(Vegetable vegetable)
        {
            // Fill Vegetables with same vegeable
            // Because a BunchVegetables conatains 10 same vegetable
            for (int i = 0; i < 10; i++)
                Vegetables.Push(vegetable);

            VegetableType = vegetable;
            Price = vegetable.Price * 10;
        }

        public BunchVegetables(Stack<Vegetable> vegetables)
        {
            // Check vegetables number
            if (vegetables.Count > 10)
                throw new VegetableOutOfException($"{vegetables.Count}");

            VegetableType = vegetables.Peek();
            Vegetables = vegetables;
        }




        public Stack<Vegetable> Vegetables { get; set; } = new(); 

        public Vegetable VegetableType { get; set; }

        public double Price { get; set; }
    }
}
