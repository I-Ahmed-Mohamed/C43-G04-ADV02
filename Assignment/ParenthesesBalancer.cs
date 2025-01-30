using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class ParenthesesBalancer
    {
        public bool IsBalanced(string expression)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char c in expression)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                else if (c == ')' || c == '}' || c == ']')
                {
                    if (stack.Count == 0 || !IsMatchingPair(stack.Pop(), c))
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;
        }

        private bool IsMatchingPair(char open, char close)
        {
            return (open == '(' && close == ')') ||
                   (open == '{' && close == '}') ||
                   (open == '[' && close == ']');
        }
    }
}
