using System;

namespace MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();  
            string output = Console.ReadLine();

            double inputLimit = 0;

            if (input == "mm")
            {
                inputLimit = number / 1000;
            }
            else if (input == "cm")
            {
                inputLimit = number / 100;
            }
            else if (input == "mi")
            {
                inputLimit = number / 0.000621371192;
            }
            else if (input == "in")
            {
                inputLimit = number / 39.3700787;
            }
            else if (input == "km")
            {
                inputLimit = number / 0.001;
            }
            else if (input == "ft")
            {
                inputLimit = number / 3.2808399;
            }
            else if (input == "yd")
            {
                inputLimit = number / 1.0936133;
            }
            else if (input == "m")
            {
                inputLimit = number;
            }
            double result = 0;

            if (output == "m")
            {
                result = inputLimit;
            }
            else if (output == "mm")
            {
                result = inputLimit * 1000;
            }
            else if (output == "cm")
            {
                result = inputLimit * 100;
            }
            else if (output == "mi")
            {
                result = inputLimit * 0.000621371192;
            }
            else if (output == "in")
            {
                result = inputLimit * 39.3700787;
            }
            else if (output == "km")
            {
                result = inputLimit * 0.001;
            }
            else if (output == "ft")
            {
                result = inputLimit * 3.2808399;
            }
            else if (output == "yd")
            {
                result = inputLimit * 1.0936133;
            }
            Console.WriteLine($"{result:f2}");
        }
    }
}
