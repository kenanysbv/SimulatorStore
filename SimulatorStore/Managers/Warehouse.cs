using SSModels.Vegetable;
using SSModels.Work;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSManagers
{
    public class Warehouse
    {
        public Warehouse(List<Shelf> shelves) => Shelves = shelves;

        public Warehouse() { }



        public List<Shelf> Shelves { get; set; } = new();



        public void AddBoxes(Box box)
        {
            Shelves.ForEach(s => s.Add(ref box));
            if (box.Bunches.Count > 0)
                while (box.Bunches.Count > 0)
                    Shelves.Add(new(ref box));
        }

        public void AddBoxes(ref List<Box> boxes)
        {
            boxes.ForEach(delegate (Box box)
           {
               Shelves.ForEach(s => s.Add(ref box));
               if (box.Bunches.Count > 0)
                   while (box.Bunches.Count > 0)
                       Shelves.Add(new(ref box));
           });
        }
    }
}
