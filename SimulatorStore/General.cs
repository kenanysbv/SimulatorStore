using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSModels.Vegetable;

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

        public static List<VegetableType> vegetableTypes = new List<VegetableType>
        {
            new("tomato",0.01,VDecayDefault),
            new("potato",0.01,VDecayDefault),
            new("peas,0",01,VDecayDefault),
            new("pumkin",0.01,VDecayDefault),
            new("cucumber",0.01,VDecayDefault),
            new("pointedgrourd",0.01,VDecayDefault),
            new("Raddish",0.01,VDecayDefault),
            new("Bittergourd",0.01,VDecayDefault),
            new("onion,",0.01,VDecayDefault),
            new("tomato",0.01,VDecayDefault),
            new("garlic",0.01,VDecayDefault),
            new("cabage",0.01,VDecayDefault),
            new("califlower",0.01,VDecayDefault),
            new("chilly",0.01,VDecayDefault),
            new("okra,0",01,VDecayDefault),
            new("pumkin",0.01,VDecayDefault),
            new("brinjal",0.01,VDecayDefault),
            new("ginger",0.01,VDecayDefault),
            new("potato",0.01,VDecayDefault),
            new("peas,0",01,VDecayDefault),
            new("radish",0.01,VDecayDefault),
            new("tomato",0.01,VDecayDefault),
            new("cabage",0.01,VDecayDefault),
            new("califlower",0.01,VDecayDefault)
        };

        public static VegetableType GetRandomVegetableType()
            => vegetableTypes[new Random().Next(0, vegetableTypes.Count)];
    }
}
