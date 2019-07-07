using System;
using System.Diagnostics;
using System.Linq;

namespace palindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            
            string input = Console.ReadLine();

            stopwatch.Start();
            while (input != "END")
            {
                char[] reversed = input.ToCharArray();
                Array.Reverse(reversed);
                string reversedInput = new string(reversed);
                if (input == reversedInput)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(stopwatch.Elapsed);
            stopwatch.Restart();
            input = Console.ReadLine();

            while (input != "END")
            {
                for (int i = 0; i < input.Length / 2; i++)
                {
                    if (input[i] != input[input.Length - 1 - i])
                    {
                        Console.WriteLine("false");
                        break;
                    }
                }
                Console.WriteLine("true");
                input = Console.ReadLine();
            }
            Console.WriteLine(stopwatch.Elapsed);
        }
    }
}
