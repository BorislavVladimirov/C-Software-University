using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> arr = Console.ReadLine()
                .Split("|")
                .ToList();
            
            List<int> appended = new List<int>();

            for (int i = arr.Count - 1; i >= 0; i--)
            {
                List<int> temp = arr[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

                foreach (int number in temp)
                {
                    appended.Add(number);
                }
            }

            Console.WriteLine(string.Join(" ",appended));
        }
    }
}
