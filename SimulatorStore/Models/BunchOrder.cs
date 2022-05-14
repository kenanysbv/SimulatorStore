using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSModels
{
    public class BunchOrder
    {
        public BunchOrder(BunchVegetables bunch, int count)
        {
            Bunch = bunch;
            Count = count;
        }

        public BunchVegetables Bunch { get; set; }

        public int Count { get; set; }
    }
}
