using System;
using System.Collections.Generic;
using System.Linq;

namespace Something
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split();

            List<string> arr1 = Console.ReadLine().Split().ToList();

            Console.WriteLine(string.Join(", ",
                Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .OrderByDescending(x => x)
                .Where( y => y % 2 == 0)
                .ToList()
                ));
            Console.WriteLine();
            //int[] numbers = Console.ReadLine()
            //    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            //    .Select(int.Parse)
            //    .ToArray();

            ////принтирайте всички четни числа;
            ////*сортирайте ги по големина четните числа.Принтирай на един ред, разделени с "," сортирани по големина.
            //List<int> evenNumbers = new List<int>();

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        evenNumbers.Add(numbers[i]);                
            //    }
            //}

            //Console.Write(string.Join(", ", evenNumbers));
            //Console.WriteLine();

            
        }
    }
}
