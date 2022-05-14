using SSGeneral;

namespace SSModels
{
    public enum VStatus { New, Good, Rotten, Toxic }

    public class Vegetable
    {
        public Vegetable(Vegetable vegetable)
        {
            Name = vegetable.Name;
            Price = vegetable.Price;
            DecayTime = vegetable.DecayTime;
            Status = vegetable.Status;
        }

        public Vegetable(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public Vegetable(string name, double price, int decayTime)
        {
            Name = name;
            Price = price;
            DecayTime = decayTime;
        }



        public string Name { get; set; }

        public double Price { get; set; }

        public int DecayTime { get; set; } = General.VDecayDefault;

        public VStatus Status { get; set; } = VStatus.New;



        public void Decay()
        {
            // For random Toxic status
            if (new Random().Next(0, 101) == 16)
            {
                Status = VStatus.Toxic;
                return;
            }

            // Change Status
            switch (Status)
            {
                case VStatus.New:
                    Status = VStatus.Good;
                    break;
                case VStatus.Good:
                    Status = VStatus.Rotten;
                    break;
                case VStatus.Rotten:
                    Status = VStatus.Toxic;
                    break;
            }

        }

    }
}
