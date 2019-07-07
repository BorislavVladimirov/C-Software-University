using System;

namespace Coding
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string number = n.ToString();
            int currentNumber = 0;
            int aSCIINum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                currentNumber = n % 10;

                if (currentNumber == 0)
                {
                    Console.Write("ZERO");                    
                }
                aSCIINum = currentNumber + 33;
                char a = Convert.ToChar(aSCIINum);

                for (int j = 0; j < currentNumber; j++)
                {
                    Console.Write(a);
                }
                Console.WriteLine();
                n = (n - currentNumber) / 10;
            }
        }
    }
}
