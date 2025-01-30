using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
     class PalindromeChecker
    {
        public bool IsPalindrome(int[] arr)
        {
            return arr.SequenceEqual(arr.Reverse());
        }
    }
}
