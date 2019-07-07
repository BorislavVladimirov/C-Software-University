using System;

namespace GenericCountMethodString
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            BoxOfItems<double> box = new BoxOfItems<double>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                double line = double.Parse(Console.ReadLine());

                box.Add(line);
            }

            double element = double.Parse(Console.ReadLine());

            Console.WriteLine(box.Compare(element));
        }
    }
}
