using System;
using System.Collections.Generic;
using System.Linq;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {

            var products = new Dictionary<string, Dictionary<double,double>>();

            string input = Console.ReadLine();

            while (input != "buy")
            {
                string[] arr = input.Split();
                
                string name = arr[0];
                double price = double.Parse(arr[1]);
                double quantity = double.Parse(arr[2]);

                if (!products.ContainsKey(name))
                {
                    products.Add(name, new Dictionary<double, double>());

                    products[name].Add(price, quantity);
                }
                else
                {
                    double tempQuantity = products[name].Values.FirstOrDefault();

                    products[name] = new Dictionary<double, double>();

                    products[name].Add(price, tempQuantity + quantity);
                }

                input = Console.ReadLine();
            }


            foreach (var p in products)
            {
                foreach (var kvp in p.Value)
                {
                    Console.WriteLine($"{p.Key} -> {(kvp.Key * kvp.Value):f2}");
                }
            }

        }
    }
}
