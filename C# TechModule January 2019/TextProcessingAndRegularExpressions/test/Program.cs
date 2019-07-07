using System;
using System.Text.RegularExpressions;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int strength = 0;

            for (int i = 0; i < input.Length - 1; i++)
            {

                if (input[i] == '>')
                {
                    strength += int.Parse(input[i + 1].ToString());
                    string key = String.Empty;


                    if (strength + i >= input.Length)
                    {

                        key = input.Substring(i + 1, input.Length - i - 1); // >3>3asr
                    }
                    else
                    {
                        key = input.Substring(i + 1, strength);
                    }

                    if (!key.Contains('>'))
                    {
                        input = input.Remove(i + 1, key.Length);
                        strength = 0;

                    }
                    else
                    {
                        string newKey = key.Substring(0, key.IndexOf('>'));
                        input = input.Remove(i + 1, newKey.Length);

                        strength = strength - newKey.Length;

                    }
                }

            }

            Console.WriteLine(input);
        }
    }
}
