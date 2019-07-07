using System;
using System.Linq;

namespace ladyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizeOfField = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] indexesOfLadybugs = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            string input = Console.ReadLine();

            while (input != "end")
            {

                string[] commands = input
                    .Split(" ")
                    .ToArray();

                for (int i = 0; i < sizeOfField.Length; i++)
                {
                    
                }


                

                input = Console.ReadLine();
            }
        }
    }
}
