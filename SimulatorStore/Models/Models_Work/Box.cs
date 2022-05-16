using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSModels.Vegetable;

namespace SSModels.Work
{
    public abstract class Box
    {
        public Stack<Bunch> Bunches { get; set; } = new();

        public int Count { get; set; }

        public int Discount { get; set; }

        public int Price { get; set; }
    }
}
