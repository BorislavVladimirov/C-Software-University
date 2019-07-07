using System;
using System.Collections.Generic;

namespace CustomStack
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var stack = new StackOfStrings();

            stack.AddRange(new List<string> {"Pesho", "Gosho", "Ivan" });

            Console.WriteLine(stack.IsEmpty());

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
