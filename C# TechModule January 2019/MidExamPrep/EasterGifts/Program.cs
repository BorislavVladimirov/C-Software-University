using System;
using System.Collections.Generic;
using System.Linq;

namespace EasterGifts
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> gifts = Console.ReadLine().Split().ToList();

            string input = Console.ReadLine();

            while (input != "No Money")
            {
                string[] tempArr = input.Split();

                string command = tempArr[0];
                string gift = tempArr[1];

                switch (command)
                {
                    case "OutOfStock":
                        for (int i = 0; i < gifts.Count - 1; i++)
                        {
                            if (gift.Contains(gift))
                            {
                                int tempIndex = gifts.IndexOf(gift);

                                if (tempIndex >= 0 && tempIndex <= gifts.Count - 1)
                                {
                                    gifts[tempIndex] = "None";
                                }
                            }
                        }                        
                        break;
                    case "Required":
                        int index = int.Parse(tempArr[2]);

                        if (index >= 0 && index <= gifts.Count - 1)
                        {
                            gifts[index] = gift;
                        }

                        break;
                    case "JustInCase":
                        gifts[gifts.Count - 1] = gift;
                        break;
                }


                input = Console.ReadLine();
            }

            foreach (var gift in gifts.Where(g => g != "None"))
            {
                Console.Write(string.Join(" ", gift + " "));
            }
        }
    }
}
