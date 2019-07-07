using System;

namespace OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();

            double result = 0;
            string evenOrOdd = "";

            if (type == "+")
            {
                result = n1 + n2;
                if (result % 2 == 0)
                {
                    evenOrOdd = "even";

                }
                else if (result % 3 == 0)
                {
                    evenOrOdd = "odd";
                }
                Console.WriteLine($"{n1} {type} {n2} = {result} - {evenOrOdd}");
            }
            else if (type == "-")
            {
                result = n1 - n2;
                if (result % 2 == 0)
                {
                    evenOrOdd = "even";

                }
                else if (result % 3 == 0)
                {
                    evenOrOdd = "odd";
                }
                Console.WriteLine($"{n1} {type} {n2} = {result} - {evenOrOdd}");
            }
            else if (type == "*")
            {
                result = n1 * n2;
                if (result % 2 == 0)
                {
                    evenOrOdd = "even";

                }
                else if (result % 3 == 0)
                {
                    evenOrOdd = "odd";
                }
                Console.WriteLine($"{n1} {type} {n2} = {result} - {evenOrOdd}");
            }
            else if (type == "/")
            {
                result = (n1 * 1.0) / (n2 * 1.0);

                if (n2 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                    return;
                }
                Console.WriteLine($"{n1} / {n2} = {result:f2}");
            }
            else if (type == "%")
            {
                result = (n1 * 1.0) % (n2 * 1.0);

                if (n2 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                    return;
                }
                Console.WriteLine($"{n1} % {n2} = {result}");
            }

        }
    }
}
