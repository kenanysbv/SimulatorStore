using SSModels.Vegetable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSManagers
{
    /*
~~~Report Data
     Client
        All count
        Count of satisfied
        Count of angry
        Count of dont find vegeables
     Finance
        Spending
        Income
        Profit
     Vegetables
        Sold veg with count
        Dont fintes vegs
     */

    public class Statistics
    {
        public class ClientStatistics
        {
            static public int AllCount { get; set; } = 0;
            static public int CountOfSatisfied { get; set; } = 0;
            static public int CountOfDontFindVeg { get; set; } = 0;
            static public int CountOfAngry { get; set; } = 0;
        }

        public class FinanceStatistics
        {
            static public double Income { get; set; }
            static public double Spending { get; set; }
            static public double Profit { get; set; }
        }

        public class VegetableStatistics
        {
            static public Dictionary<VegetableType, int> SoldVeg { get; set; } = null;
        }



        public ClientStatistics? Client { get; set; } = new();
        public FinanceStatistics? Finance { get; set; } = new();
        public VegetableStatistics? Vegetable { get; set; } = new();
    }
}
