using System;
using System.Linq;
namespace readingArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string values = Console.ReadLine();
            string[] valuesAsString = values.Split();
            int[] numbers = new int[valuesAsString.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Console.Write(string.Join("", numbers));
        }
    }
}
