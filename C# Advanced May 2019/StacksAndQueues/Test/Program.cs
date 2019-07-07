using System;
using System.Collections.Generic;
using System.Linq;

namespace AutoRepairAndService
{
    class StartUp
    {
        public static void Main(string[] args)
        {
            Stack<char> text = new Stack<char>();
            Stack<char> previous = new Stack<char>();

            Stack<int> history = new Stack<int>();

            int n = int.Parse(Console.ReadLine());
            int previusCountCase1 = 0;
            int previusCountCase2 = 0;

            for (int i = 0; i < n; i++)
            {
                string commandArray = Console.ReadLine();

                int command = int.Parse(commandArray.Split()[0]);

                switch (command)
                {
                    case 1:
                        char[] arr = commandArray.Split()[1].ToCharArray();

                        for (int y = 0; y < arr.Length; y++)
                        {
                            text.Push(arr[y]);
                        }
                        history.Push(1);
                        previusCountCase1 = arr.Length;
                        break;
                    case 2:
                        int count = int.Parse(commandArray.Split()[1]);

                        var temp = new char[count];

                        for (int y = 0; y < count; y++)
                        {
                            temp[y] = text.Pop();
                        }

                        for (int y = temp.Length - 1; y >= 0; y--)
                        {
                            previous.Push(temp[y]);
                        }


                        history.Push(2);
                        previusCountCase2 = count;
                        break;
                    case 3:
                        int index = int.Parse(commandArray.Split()[1]);

                        Console.WriteLine(text.ElementAt(text.Count - index));
                        break;
                    case 4:
                        switch (history.Pop())
                        {
                            case 1:
                                for (int y = 0; y < previusCountCase1; y++)
                                {
                                    text.Pop();
                                }
                                break;
                            case 2:
                                for (int y = 0; y < previusCountCase2; y++)
                                {
                                    text.Push(previous.Pop());
                                }
                                break;
                        }
                        break;
                }
            }
        }
    }
}