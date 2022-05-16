using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSGeneral
{
    public enum Capacitys
    {
        Bunch = 10,
        Shelf = 15,
        SBox = 15,
        LBox = 30,
        Worker = 5,
    }

    public enum BoxDiscount
    {
        SBox = 2,
        LBox = 5,
    }


    public abstract class General
    {
        public const int Hour = 10;
        public const int VDecayDefault = Hour * 24;

        // Random max  accept -1 value
        public const int InfectedPossibility = 151;
    }
}
