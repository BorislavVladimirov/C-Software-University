using System;

namespace BiggestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int biggestNum = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number > biggestNum)
                {
                    biggestNum = number;
                }                
            }
            Console.WriteLine(biggestNum);
        }
            
           
    }
}
