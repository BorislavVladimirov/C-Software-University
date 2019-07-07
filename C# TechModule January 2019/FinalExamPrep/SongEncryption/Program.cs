using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace SongEncryption
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            string pattern = @"^[A-Z][a-z\' ]+:[A-Z ]*$";

            StringBuilder sb = new StringBuilder();

            Regex regex = new Regex(pattern);

            while (input != "end")
            {
                sb.Clear();

                if (regex.IsMatch(input))
                {
                    string[] tempArr = input.Split(":");
                    int key = tempArr[0].Length;

                    for (int i = 0; i < input.Length; i++)
                    {
                        char currentChar = input[i];


                        if (currentChar == ':')
                        {
                            sb.Append("@");
                        }
                        else if (currentChar == ' ' || currentChar == '\'')
                        {
                            sb.Append(currentChar);
                        }
                        else
                        {
                            for (int j = key - 1; j >= 0; j--)
                            {
                                currentChar++;

                                if (currentChar > 'z')
                                {
                                    currentChar = 'a';
                                }
                                else if (currentChar > 'Z' && currentChar < 'a')
                                {
                                    currentChar = 'A';
                                }
                            }

                            sb.Append(currentChar);

                        }
                    }
                    Console.WriteLine($"Successful encryption: {sb}");
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                input = Console.ReadLine();
            }
        }
    }
}
