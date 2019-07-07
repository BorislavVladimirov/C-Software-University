using System;
using System.Text.RegularExpressions;

namespace SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string namePattern = @"%([A-Z][a-z]+)%";
            string productNamePattern = @"<(\w+)>";
            string quantityPattern = @"\|(\d+)\|";
            string pricePattern = @"\|(\d+\.?\d+)\$";

            decimal totalIncome = 0;

            //Regex regex = new Regex(namePattern); collection of matches 
            //regex.Matches(input);

            while (input != "end of shift")
            {

                string name = string.Empty;
                string productName = string.Empty;
                int quantity = 0;
                decimal price = 0;
                decimal totalPrice = 0;

                Match nameMatch = Regex.Match(input, namePattern);
                Match productMatch = Regex.Match(input, productNamePattern);
                Match quantityMatch = Regex.Match(input, quantityPattern);
                Match priceMatch = Regex.Match(input, pricePattern);

                bool isMatch = nameMatch.Success &&
                    productMatch.Success && 
                    quantityMatch.Success &&
                    priceMatch.Success;                

                if (!isMatch)
                {
                    input = Console.ReadLine();
                    continue;
                }

                name = nameMatch.Groups[1].ToString();
                productName = productMatch.Groups[1].ToString();
                quantity = int.Parse(quantityMatch.Groups[1].ToString());
                price = decimal.Parse(priceMatch.Groups[1].ToString());

                totalPrice = quantity * price;
                totalIncome += totalPrice;


                Console.WriteLine($"{name}: {productName} - {totalPrice:f2}");

                input = Console.ReadLine();
            }
            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
