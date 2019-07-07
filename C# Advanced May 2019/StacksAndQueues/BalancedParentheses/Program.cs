using System;
using System.Collections.Generic;
using System.Linq;

namespace BalancedParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            Stack<char> parentheses = new Stack<char>();
            bool isValid = true;
            char[] openParaneteses = new char[] {'(', '{', '[' };

            if (!openParaneteses.Contains(input[0]))
            {
                isValid = false;
            }

            foreach (var item in input)
            {
                if (openParaneteses.Contains(item))
                {
                    parentheses.Push(item);
                    continue;
                }

                if (parentheses.Count == 0)
                {
                    isValid = false;
                    break;
                }

                if (parentheses.Peek() == '(' && item == ')')
                {
                    parentheses.Pop();
                }
                else if (parentheses.Peek() == '[' && item == ']')
                {
                    parentheses.Pop();
                }
                else if (parentheses.Peek() == '{' && item == '}')
                {
                    parentheses.Pop();
                }
                else
                {
                    isValid = false;
                    break;
                }
            }
            if (isValid)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            
        }
    }
}
