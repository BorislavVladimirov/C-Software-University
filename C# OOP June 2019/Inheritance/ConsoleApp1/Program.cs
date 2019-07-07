using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            numbers.Sort((int a, int b) =>
            {
                if (a > b)
                {
                    return 1;
                }
                else if (a < b)
                {
                    return -1;
                }

                return 0;
            });
        }


        public static void Calculate(decimal a)
        {
            a += a;
        }
    }
}
