using System;

namespace Coding2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string number = num.ToString();
            int newNum = 0;
            int numToASCII = 0;

            for (int i = 0; i < number.Length; i++)
            {
                newNum = num % 10;
                num /= 10;
                numToASCII = newNum + 33;
                char a = (char)numToASCII;

                for (int j = 0; j < newNum; j++)
                {
                    Console.Write(a);` 
                }
                if (newNum == 0)
                {
                    Console.Write("ZERO");
                    Console.WriteLine();
                    continue;
                }
                Console.WriteLine();
                
                
            }
        }
    }
}
