using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class OddNumberRemover
    {
        public int[] RemoveOddNumbers(int[] arr)
        {
            return arr.Where(x => x % 2 == 0).ToArray();
        }
    }
}
