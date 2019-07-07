using System;
using System.Collections.Generic;
using System.Linq;

namespace LastStop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] input = command.Split();


                string operation = input[0];
                int num = 0;

                if (command != "Reverse")
                {
                    num = int.Parse(input[1]);
                }
                
                switch (operation)
                {
                    case "Change":
                        if (nums.Contains(num))
                        {
                            nums[nums.IndexOf(num)] = int.Parse(input[2]);
                        }
                        break;
                    case "Hide":
                        if (nums.Contains(num))
                        {
                            nums.Remove(num);
                        }
                        break;
                    case "Switch":

                        int secondNum = int.Parse(input[2]);

                        if (nums.Contains(num) && nums.Contains(secondNum))
                        {
                            int firstIndex = nums.IndexOf(num);
                            int firstValue = num;

                            int secondIndex = nums.IndexOf(secondNum);
                            int secondValue = secondNum;

                            nums[firstIndex] = secondValue;
                            nums[secondIndex] = firstValue;
                        }
                        break;
                    case "Insert":
                        int number = int.Parse(input[2]);
                        int place = int.Parse(input[1]) + 1;

                        if (place >= 0 && place < nums.Count)
                        {
                            nums.Insert(place, number);
                        }
                        break;
                    case "Reverse":
                        nums.Reverse();
                        break;

                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",nums));
        }
    }
}
