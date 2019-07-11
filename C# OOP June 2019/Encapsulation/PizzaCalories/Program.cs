using System;
using System.Linq;

namespace PizzaCalories
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                string[] pizzaArr = Console.ReadLine()
                    .Split(" ").ToArray();

                var pizza = new Pizza(pizzaArr[1]);

                string[] doughtArr = Console.ReadLine()

                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var dough = new Dough(doughtArr[1], doughtArr[2], double.Parse(doughtArr[3]));
                pizza.Dough = dough;

                string toppings = Console.ReadLine();

                while (toppings != "END")
                {
                    string[] toppingsArr = toppings
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();

                    var topping = new Topping(toppingsArr[1], double.Parse(toppingsArr[2]));

                    pizza.AddTopping(topping);

                    toppings = Console.ReadLine();
                }

                Console.WriteLine(pizza.ToString());
            }
            catch (ArgumentException ae)
            {

                Console.WriteLine(ae.Message);
            }
        }
    }
}
