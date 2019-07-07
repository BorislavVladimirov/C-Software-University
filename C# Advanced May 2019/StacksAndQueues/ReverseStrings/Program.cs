using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<string> reversed = new Stack<string>();

            foreach (var ch in input)
            {
                reversed.Push(ch.ToString());
            }

            string[] test = reversed.ToArray();

            while (reversed.Count > 0)
            {
                Console.Write(reversed.Pop());
            }
            Console.WriteLine();
        }
    }
}
