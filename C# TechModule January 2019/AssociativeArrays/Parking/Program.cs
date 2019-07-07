using System;
using System.Collections.Generic;

namespace Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, string> cars = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                string typeOfCommand = input[0];

                string username = input[1];

                switch (typeOfCommand)
                {
                    case "register":

                        string licensePlate = input[2];

                        if (!cars.ContainsKey(username))
                        {
                            cars.Add(username, licensePlate);

                            Console.WriteLine($"{username} registered {licensePlate} successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {licensePlate}");
                        }
                        break;

                    case "unregister":
                        if (!cars.ContainsKey(username))
                        {
                            Console.WriteLine($"ERROR: user {username} not found");
                        }
                        else
                        {
                            cars.Remove(username);

                            Console.WriteLine($"{username} unregistered successfully");

                        }
                        break;
                }
            }
            foreach (var kvp in cars)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}
