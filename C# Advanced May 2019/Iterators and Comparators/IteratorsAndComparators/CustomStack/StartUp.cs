using System;
using System.Linq;

namespace CustomStack
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");

            MyStack<int> myStack = new MyStack<int>();

            while (input[0] != "END")
            {
                try
                {
                    switch (input[0])
                    {
                        case "Pop":
                            myStack.Pop();
                            break;
                        case "Push":
                            int[] elements = string.Join(" ",input.Skip(1)).Split(", ").Select(int.Parse).ToArray();

                            elements.ToList().ForEach(x => myStack.Push(x));
                            break;

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                input = Console.ReadLine().Split(" ");
            }

            Console.WriteLine(myStack);

        }
    }
}
