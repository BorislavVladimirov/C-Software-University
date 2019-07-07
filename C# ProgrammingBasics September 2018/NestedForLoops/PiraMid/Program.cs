using System;

namespace PiraMid
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int count = 1;

            for (int row = 0; row <= num; row++)
            {
                for (int col = 0; col <= row; col++)
                {
                    Console.Write($"{count++} ");
                    if (count > num)
                    {
                        return;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
