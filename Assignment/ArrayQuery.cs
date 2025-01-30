using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class ArrayQuery
    {
        private int[] numbers;

        public ArrayQuery(int[] numbers)
        {
            this.numbers = numbers;
        }

        public int CountGreaterThan(int x)
        {
            return numbers.Count(num => num > x);
        }
    }
}
