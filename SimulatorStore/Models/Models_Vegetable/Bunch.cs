using SSModels.Vegetable;
using SSExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSGeneral;

namespace SSModels.Vegetable
{
    public enum BStatus { New, Good, OldGood, Rotten, Toxic, Infected }

    public class Bunch
    {
        public Bunch(VegetableType vegetableType)
        {
            // For Random Infected Status
            if (new Random().Next(0, General.InfectedPossibility) == 16)
                Status = BStatus.Infected;

            Type = vegetableType;
            Price = vegetableType.Price * (int)Capacitys.Bunch;
            DecayTime = vegetableType.DecayTime;
        }



        public VegetableType Type { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public int DecayTime { get; set; } = General.VDecayDefault;

        public BStatus Status { get; set; } = BStatus.New;



        public void Decay()
        {
            // Infected status can't change
            if (Status == BStatus.Infected)
                return;

            // For random Toxic status
            if (new Random().Next(0, 101) == 16)
            {
                Status = BStatus.Toxic;
                return;
            }

            // Change Status
            switch (Status)
            {
                case BStatus.New:
                    Status = BStatus.Good;
                    break;
                case BStatus.Good:
                    Status = BStatus.OldGood;
                    break;
                case BStatus.OldGood:
                    Status = BStatus.Rotten;
                    break;
                case BStatus.Rotten:
                    Status = BStatus.Toxic;
                    break;
                default:
                    break;
            }

        }
    }
}
