using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSExceptions;
using SSGeneral;
using SSInterfaces;

namespace SSModels.Vegetable
{
    public class Shelf : ICalculateListCount
    {
        public Shelf(Stack<Bunch> bunchs, bool autoAdd = true)
        {
            // Check bunchs number
            if (bunchs.Count > (int)Capacitys.Shelf && !autoAdd)
                throw new BunchsOutOfRangeException($"{bunchs.Count}");
            else if (bunchs.Count > (int)Capacitys.Shelf && autoAdd)
            {
                for (int i = 0; i < FreeSpace(); i++)
                    Bunches.Push(bunchs.Pop());
            }
            else
                Bunches = bunchs;
        }

        public Shelf() { }


        public Stack<Bunch> Bunches { get; set; } = new();




        public bool Add(Bunch bunch)
        {
            if (!IsFull())
                Bunches.Push(bunch);
            else
                return false;
            return true;
        }

        public bool Add(Stack<Bunch> bunches, bool autoAdd = true)
        {
            if (bunches.Count <= FreeSpace())
                for (int i = 0; i < bunches.Count; i++)
                    Bunches.Push(bunches.Pop());
            else if (autoAdd)
                for (int i = 0; i < FreeSpace(); i++)
                    Bunches.Push(bunches.Pop());
            else
                return false;
            return true;
        }

        public bool Remove()
        {
            if (IsEmpty())
                return false;
            Bunches.Pop();
            return true;
        }

        /// <summary>
        /// Delete list from Bunches
        /// </summary>
        /// <param name="bunch">bunch you want to delete</param>
        /// <returns>
        /// 0 => Succes
        /// 1 => Bunches is empty
        /// 2 => bunch is empty
        /// </returns>
        public int Remove(Bunch bunch)
        {
            if (IsEmpty())
                return 1;
            Bunches = new(Bunches.ToList().Where(x => x != bunch));
            return 0;
        }

        /// <summary>
        /// Delete list from Bunches
        /// </summary>
        /// <param name="bunch">List of bunches you want to delete</param>
        /// <returns>
        /// 0 => Succes
        /// 1 => Bunches is empty
        /// 2 => bunch is empty
        /// </returns>
        public int Remove(List<Bunch> bunch)
        {
            if (IsEmpty())
                return 1;
            else if (bunch.Count == 0)
                return 2;
            Bunches = new(Bunches.ToList().Where(x => !bunch.Contains(x)));
            return 0;
        }

        public bool IsFull() => Bunches.Count == (int)Capacitys.Shelf;

        public int FreeSpace() => (int)Capacitys.Shelf - Bunches.Count;

        public bool IsEmpty() => Bunches.Count == 0;
    }
}
