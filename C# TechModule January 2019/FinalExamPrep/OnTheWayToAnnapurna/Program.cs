using System;
using System.Collections.Generic;
using System.Linq;

namespace OnTheWayToAnnapurna
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var result = new Dictionary<string,List<string>>();

            while (input != "END")
            {
                string[] tempArr = input.Split("->",StringSplitOptions.RemoveEmptyEntries);

                string command = tempArr[0];
                string storeName = tempArr[1];

                switch (command)
                {
                    case "Add":
                        string[] items = tempArr[2].Split(",");

                        for (int i = 0; i < items.Length; i++)
                        {
                            string currentItem = items[i];

                            if (!result.ContainsKey(storeName))
                            {
                                result.Add(storeName, new List<string>());
                                result[storeName].Add(currentItem);
                            }
                            else
                            {
                                result[storeName].Add(currentItem);
                            }
                        }
                        break;
                    case "Remove":
                        if (result.ContainsKey(storeName))
                        {
                            result.Remove(storeName);
                        }
                        break;
                }

                input = Console.ReadLine();               
            }
            Console.WriteLine("Stores list:");

            foreach (var store in result.OrderByDescending(x => x.Value.Count).ThenByDescending(x => x.Key))
            {
                Console.WriteLine($"{store.Key}");

                foreach (var item in store.Value)
                {
                    Console.WriteLine($"<<{item}>>");
                }
            }
        }
    }
}
