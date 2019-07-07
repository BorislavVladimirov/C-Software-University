using System;

namespace aa
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int smallestNumber = int.MaxValue;
            int largestNumber = int.MinValue;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                int number = int.Parse(input);

                if (smallestNumber > number)
                {
                    smallestNumber = number;
                }
                
                if (largestNumber < number)
                {
                    largestNumber = number;
                }                
               
            }
            Console.WriteLine($"Max number: {largestNumber}");
            Console.WriteLine($"Min number: {smallestNumber}");
            

        }
    }
}
