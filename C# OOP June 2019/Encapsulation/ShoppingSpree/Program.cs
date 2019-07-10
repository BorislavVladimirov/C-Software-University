using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();

            string[] input = Console.ReadLine().Split(";");

            for (int i = 0; i < input.Length; i++)
            {
                string[] tempPersont = input[i].Split("=");

                string name = tempPersont[0];
                decimal money = decimal.Parse(tempPersont[1]);

                try
                {
                    Person person = new Person(name, money);
                    people.Add(person);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
            }

            input = Console.ReadLine().Split(";");

            for (int i = 0; i < input.Length; i++)
            {
                string[] tempProduct = input[i].Split("=");

                string nameOfProduct = tempProduct[0];
                decimal price = decimal.Parse(tempProduct[1]);

                try
                {
                    Product product = new Product(nameOfProduct, price);
                    products.Add(product);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
            }


            input = Console.ReadLine().Split(" ");

            while (input[0] != "END")
            {
                string personName = input[0];
                string productName = input[1];

                Person person = people.FirstOrDefault(x => x.Name == personName);
                Product productToBuy = products.FirstOrDefault(x => x.Name == productName);

                if (person.Money >= productToBuy.Cost)
                {
                    person.BuyProduct(productToBuy);
                    person.Money -= productToBuy.Cost;

                    Console.WriteLine($"{person.Name} bought {productToBuy.Name}");
                }
                else
                {
                    Console.WriteLine($"{person.Name} can't afford {productToBuy.Name}");
                }

                input = Console.ReadLine().Split();
            }

            foreach (var person in people)
            {
                if (person.Products().Count > 0)
                {
                    Console.WriteLine($"{person.Name} - {string.Join(", ", person.Products().Select(x => x.Name))}");
                }
                else
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
            }
        }
    }
}
