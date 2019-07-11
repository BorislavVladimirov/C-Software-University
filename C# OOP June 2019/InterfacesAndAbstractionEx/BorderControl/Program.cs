using System;
using System.Collections.Generic;
using System.Linq;
using BorderControl.Interfaces;
using BorderControl.Models;

namespace BorderControl
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<IBuyer> result = new List<IBuyer>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                switch (input.Length)
                {
                    case 4:
                        string name = input[0];
                        string age = input[1];
                        string id = input[2];
                        string birthdate = input[3];

                        Citizen citizen = new Citizen(name, age, id, birthdate);
                        result.Add(citizen);
                        break;
                    case 3:
                        string rebelName = input[0];
                        string rebelAge = input[1];
                        string rebelGroup = input[2];

                        Rebel rebel = new Rebel(rebelName, rebelAge, rebelGroup);
                        result.Add(rebel);
                        break;
                }
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                string name = command;

                if (result.Any(x => x.Name == name))
                {
                    IBuyer item = result.FirstOrDefault(x => x.Name == name);
                    item.BuyFood();
                }

                command = Console.ReadLine();
            }

            int sum = 0;

            foreach (var item in result)
            {
                sum += item.Food;
            }

            Console.WriteLine(sum);
        }
    }
}
