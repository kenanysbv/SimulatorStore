using SSManagers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSManagers
{
    public class Store
    {
        public int Money { get; set; } = 0;

        public Warehouse Warehouse { get; set; } = new();

        public WorkerController Controller { get; set; } = new();

        public Statistics Stats { get; set; } = new();
    }
}
