using System;

namespace InchesToSantimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            double inch = double.Parse(Console.ReadLine());
            double centemeters = inch * 2.54;
            Console.WriteLine(centemeters);
        }
    }
}
