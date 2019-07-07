using System;

namespace SumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int primeSum = 0;
            int nonPrimeSum = 0;
            bool isPrime = true;


            while (true)
            {
                string input = Console.ReadLine();
                if (input == "stop")
                {
                    break;
                }
                int num = int.Parse(input);

                isPrime = true;

                if (num < 0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }
                if (num == 1)
                {
                    isPrime = false;
                }
                else
                {
                    for (int i = num; i >= 2; i--)
                    {
                        if (num % i == 0 && i != num)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                }

                if (isPrime)
                {
                    primeSum += num;
                }
                else
                {
                    nonPrimeSum += num;
                }
            }
            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
            
        }
    }
}
