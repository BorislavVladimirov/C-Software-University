using System;
using System.Text;

namespace Temp
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int sum = firstNumber + secondNumber + thirdNumber;

            string n1 = firstNumber.ToString() + secondNumber.ToString() + thirdNumber.ToString();
            string n2 = firstNumber.ToString() + thirdNumber.ToString() + secondNumber.ToString();
            string n3 = secondNumber.ToString() + firstNumber.ToString() + thirdNumber.ToString();
            string n4 = secondNumber.ToString() + thirdNumber.ToString() + firstNumber.ToString();
            string n5 = thirdNumber.ToString() + secondNumber.ToString() + firstNumber.ToString();
            string n6 = thirdNumber.ToString() + firstNumber.ToString() + secondNumber.ToString();

            string[] numbers = { n1, n2, n3, n4, n5, n6 };

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = int.Parse(numbers[i]);

                if (sum != 0 && currentNumber % sum == 0)
                {
                    Console.WriteLine("Digitivision successful!");
                    return;
                }
            }

            Console.WriteLine("No digitivision possible.");
        }
    }
}
