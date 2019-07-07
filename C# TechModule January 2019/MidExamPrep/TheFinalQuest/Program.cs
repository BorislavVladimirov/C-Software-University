using System;
using System.Collections.Generic;
using System.Linq;

namespace TheFinalQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();

            string tempInput = Console.ReadLine();

            while (tempInput != "Stop")
            {
                string[] tempArr = tempInput.Split();
                string command = tempArr[0];

                switch (command)
                {
                    case "Delete":
                        int index = int.Parse(tempArr[1]);

                        if (index + 1 <= input.Capacity - 1 && index + 1 >= 0)
                        {
                            input.RemoveAt(index + 1);
                        }
                        break;
                    case "Swap":
                        string firstWord = tempArr[1];
                        string secondWord = tempArr[2];

                        if (input.Contains(firstWord) && input.Contains(secondWord))
                        {
                            input[input.IndexOf(firstWord)] = secondWord;
                            input[input.IndexOf(secondWord)] = firstWord;
                        }
                        break;
                    case "Put":
                        string word = tempArr[1];
                        int Tempindex = int.Parse(tempArr[2]);

                        if (Tempindex - 1 >= 0 && Tempindex <= input.Count - 1)
                        {
                            input.Insert(Tempindex - 1, word);
                        }
                        break;
                    case "Sort":
                        input.OrderByDescending(x => x);
                        break;
                    case "Replace":
                        string first = tempArr[1];
                        string second = tempArr[2];

                        if (input.Contains(second))
                        {
                            int indexOfSecond = input.IndexOf(second);
                            input[indexOfSecond] = first;
                        }
                        break;
                }

                tempInput = Console.ReadLine();
            }

            foreach (var item in input)
            {
                Console.Write(string.Join(" ",item + " "));
            }
        }
    }
}
