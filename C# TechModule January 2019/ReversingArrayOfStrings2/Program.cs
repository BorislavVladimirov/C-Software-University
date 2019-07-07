using System;
using System.Linq;

namespace ReversingArrayOfStrings2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] texts = Console.ReadLine().Split();
            string[] reversed = new string[texts.Length];
            for (int i = 0; i < texts.Length / 2 ; i++)
            {
                string firstText = texts[i];
                int indexOfReversedCell = texts.Length - i - 1;

                texts[i] = texts[indexOfReversedCell];
                texts[indexOfReversedCell] = firstText;                
            }
            for (int i = texts.Length - 1; i >= 0; i--)
            {
                reversed[i] = texts[i];
            }
            Console.Write(string.Join(" ", reversed));


        }
    }
}
