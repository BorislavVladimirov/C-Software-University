using System;
using System.Linq;
using System.Text;

namespace ArrivingInKathmandu
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "Last note")
            {
                StringBuilder name = new StringBuilder();
                StringBuilder result = new StringBuilder();

                bool istrue = false;

                if (input.Contains("="))
                {
                    string[] tempArr = input.Split("=");

                    string leftSide = tempArr[0];
                    string TemprightSide = tempArr[1];

                    if (leftSide.Length == 0 || TemprightSide.Length == 0)
                    {
                        Console.WriteLine("Nothing found!");
                        input = Console.ReadLine();
                        continue;
                    }
                    if (leftSide.Contains("!") || leftSide.Contains("@") || leftSide.Contains("#") || leftSide.Contains("$")
                        || leftSide.Contains("?") && (!leftSide.Contains("=")))
                    {
                        for (int i = 0; i < leftSide.Length; i++)
                        {
                            char currentChar = char.Parse(leftSide[i].ToString());

                            if (!char.IsLetterOrDigit(currentChar) && currentChar != '!' &&
                                currentChar != '@' && currentChar != '#' && currentChar != '$' && currentChar != '?')
                            {
                                Console.WriteLine("Nothing found!");
                                input = Console.ReadLine();
                                istrue = true;
                                break;

                            }
                            if (char.IsLetterOrDigit(currentChar))
                            {
                                name.Append(currentChar);
                            }
                        }
                        if (istrue)
                        {
                            continue;
                        }
                        string rightSide = tempArr[1];

                        if (rightSide.Contains("<<"))
                        {
                            string[] temp = rightSide.Split("<<");

                            string tempLenght = temp[0].ToString();

                            if (tempLenght.Contains("."))
                            {
                                Console.WriteLine("Nothing found!");
                                input = Console.ReadLine();
                                continue;
                            }

                            for (int i = 0; i < tempLenght.Length; i++)
                            {
                                if (char.IsDigit(tempLenght[i]))
                                {
                                    result.Append(tempLenght[i]);
                                }
                            }

                            int length = int.Parse(result.ToString());

                            string geohashCode = temp[1].ToString();
                            int geohashCodeSum = geohashCode.Length;

                            if (geohashCodeSum != length)
                            {
                                Console.WriteLine("Nothing found!");
                                input = Console.ReadLine();
                                continue;
                            }
                            else
                            {
                                Console.WriteLine($"Coordinates found! {name} -> {geohashCode}");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nothing found!");
                        input = Console.ReadLine();
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Nothing found!");
                    input = Console.ReadLine();
                    continue;
                }

                input = Console.ReadLine();
            }
        }
    }
}
