using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSInterfaces
{
    public interface ICalculateListCount
    {
        int FreeSpace();
        bool IsFull();
        bool IsEmpty();
    }
}
