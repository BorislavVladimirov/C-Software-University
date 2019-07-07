using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOfProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> products = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string product = Console.ReadLine();
                products.Add(product);
            }
            //products.Sort();

            int count = 0;
            foreach (var product in products.OrderBy(p => p))
            {
                Console.WriteLine($"{++count}.{product}");
            }

            //for (int i = 0; i < products.Count; i++)
            //{
            //    Console.WriteLine($"{i + 1}.{products[i]}");
            //}

           
        }
    }
}
