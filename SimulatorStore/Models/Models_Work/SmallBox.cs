using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSModels.Vegetable;
using SSGeneral;

namespace SSModels.Work
{
    public class SmallBox : Box
    {
        public SmallBox(Bunch bunch)
        {
            Count = (int)Capacitys.SBox;
            Discount = (int)BoxDiscount.SBox;
            Price = (int)bunch.Price * Count;
            Price -= ((Price / 100) * Discount);

            for (int i = 0; i < Count; i++)
                Bunches.Push(bunch);
        }
    }
}
