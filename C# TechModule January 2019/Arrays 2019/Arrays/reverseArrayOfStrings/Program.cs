using System;
using System.Linq;

namespace reverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine()
                .Split(' ')
                .ToArray();

            for (int i = 0; i < array.Length / 2; i++)
            {
                string oldElement = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = oldElement;
            }
            Console.Write(string.Join(" ", array));
        }
    }
}
