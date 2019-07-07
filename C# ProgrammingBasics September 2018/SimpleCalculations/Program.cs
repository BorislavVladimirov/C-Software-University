using System;

namespace SimpleCalculations
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();

            Console.Write("Please enter your age: ");
            int userAge = int.Parse(Console.ReadLine());

            Console.WriteLine("Hello {0} {1}", userName, userAge );

            Console.WriteLine("Hello " + userName + ' ' + userAge);

            Console.WriteLine($"Hello {userName} {userAge}");

            Console.WriteLine(1 + 1);
            Console.WriteLine("1" + 1);
            Console.WriteLine("1" + 1 + 1);
            Console.WriteLine("1" + (1 + 1));

        }
    }
}
