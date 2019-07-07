using System;

namespace InfiniteLoop
{
    class Program
    {
        static void Main(string[] args)
        {

            int counter = 0;
            while (true)
            {
                
                Console.WriteLine($"Infinite loop: {counter}");
                counter++;

                if (counter == 4456)
                {
                    break;
                }
            }
            Console.WriteLine("Exit");
        }
        
    }
}
