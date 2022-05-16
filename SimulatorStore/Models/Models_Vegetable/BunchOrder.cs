using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSModels.Vegetable
{
    public class BunchOrder
    {
        public BunchOrder(Bunch bunch, int count)
        {
            Bunch = bunch;
            Count = count;
        }

        public Bunch Bunch { get; set; }

        public int Count { get; set; }
    }
}
