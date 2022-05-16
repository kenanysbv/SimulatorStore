using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSModels.Vegetable
{
    public class VegetableType
    {
        public VegetableType(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public VegetableType(string name, double price, int decayTime)
        {
            Name = name;
            Price = price;
            DecayTime = decayTime;
        }



        public string Name { get; set; }

        public double Price { get; set; }

        public int DecayTime { get; set; }
    }
}
