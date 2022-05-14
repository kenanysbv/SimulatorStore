using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSModels;
using SSExceptions;
using SSGeneral;

namespace SS
{
    public class Store
    {
        public Store() { }



        public List<Aisle> Aisles { get; set; }



        public void AddAisle(Aisle aisle) => Aisles.Add(aisle);

        public void RemoveAisle(Aisle aisle) => Aisles.Remove(aisle);
    }
}
