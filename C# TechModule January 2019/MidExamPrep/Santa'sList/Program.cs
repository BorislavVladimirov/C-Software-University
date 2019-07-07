using System;
using System.Collections.Generic;
using System.Linq;

namespace Santa_sList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> kids = Console.ReadLine().Split("&").ToList();

            string command = Console.ReadLine();

            while (command != "Finished!")
            {
                string[] input = command.Split();
                string name = input[1];

                switch (input[0])
                {
                    case "Bad":
                        if (!kids.Contains(name))
                        {
                            kids.Insert(0, name);
                        }
                        break;
                    case "Good":
                        if (kids.Contains(name))
                        {
                            kids.Remove(name);
                        }
                        break;
                    case "Rename":
                        if (kids.Contains(name))
                        {
                            int indexOfName = kids.IndexOf(name);
                            kids[indexOfName] = input[2];                      
                        }
                        break;
                    case "Rearrange":
                        if (kids.Contains(name))
                        {
                            kids.Remove(name);
                            kids.Add(name);
                        }
                        break;
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ",kids));
            
        }
    }
}

