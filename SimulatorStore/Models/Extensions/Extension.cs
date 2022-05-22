using SSModels.Vegetable;
using SSModels.Work;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulatorStore.Models.Extensions
{
    public static class Extension
    {
        public static Bunch RemoveAndReturn(this List<Bunch> list, int index)
        {
            var temp = list[index];
            list.Remove(list[index]);
            return temp;
        }
        public static Box RemoveAndReturn(this List<Box> list, int index)
        {
            var temp = list[index];
            list.Remove(list[index]);
            return temp;
        }
    }
}
