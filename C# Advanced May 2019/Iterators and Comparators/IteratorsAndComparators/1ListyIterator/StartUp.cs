using System;
using System.Linq;

namespace _1ListyIterator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            ListyIterator<string> listyIterator = new ListyIterator<string>();

            string[] createCommand = Console.ReadLine().Split(" ");

            listyIterator.Create(createCommand.Skip(1).ToArray());

            string command = Console.ReadLine();

            while (command != "END")
            {
                try
                {
                    switch (command)
                    {
                        case "Move":
                            Console.WriteLine(listyIterator.Move());
                            break;
                        case "Print":
                            listyIterator.Print();
                            break;
                        case "HasNext":
                            Console.WriteLine(listyIterator.HasNext());
                            break;
                        case "PrintAll":
                            foreach (var item in listyIterator)
                            {
                                Console.Write(item + " ");
                            }
                            Console.WriteLine();
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message); 
                }

                command = Console.ReadLine();
            }
        }
    }
}
