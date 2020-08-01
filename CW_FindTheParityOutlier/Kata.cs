using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CW_FindTheParityOutlier
{
    public class Kata
    {
        public int Find(int[] integers)
        {
            var countP = new List<int>();
            var countI = new List<int>();
            foreach (var item in integers)
            {
                if (item % 2 == 0)
                {
                    countP.Add(item);
                }
                else
                {
                    countI.Add(item);
                }
            }

            if (countP.Count() == 1)
            {
                foreach (var item in countP)
                {
                    return item;
                }
            }
            else
            {
                foreach (var item in countI)
                {
                    return item;
                }
            }
            return -1;
            //-------------------------------------------------------------------------
            //var evenNumbers = integers.Where(integer => integer % 2 == 0);
            //var oddNumbers = integers.Where(integer => integer % 2 == 1);
            //return evenNumbers.Count() == 1 ? evenNumbers.First() : oddNumbers.First();
        }
    }
}
