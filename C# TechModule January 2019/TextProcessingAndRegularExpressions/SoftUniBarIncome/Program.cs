using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"%(?<customer>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<count>\d+)\|[^|$%.]*(?<price>[0-9]+\.?[0-9]+)\$";

            string input = string.Empty;

            double totalIncome = 0;

            while ((input = Console.ReadLine()) != "end of shift")
            {
                Regex order = new Regex(pattern);

                if (order.IsMatch(input))
                {
                    string name = order.Match(input).Groups("customer").Value;
                    string product = order.Match(input).Groups("product").Value;
                    int count = int.Parse(order.Match(input).Groups("price").Value);
                    double price = double.Parse(order.Match(input).Groups("price").Value);

                    double totalPrice = count * price;

                }
            }
        }
    }
}
