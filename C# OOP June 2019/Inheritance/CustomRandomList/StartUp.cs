using System;

namespace CustomRandomList
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            RandomList randomList = new RandomList() { "Pesho", "Ivan", "Gosho"};

            Console.WriteLine(randomList.RandomString()); 
        }
    }
}
