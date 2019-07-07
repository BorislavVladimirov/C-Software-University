using System;

namespace train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int totalPeopleCount = 0;
            int[] train = new int[n];
            
            for (int i = 0; i < n; i++)
            {
                int peoplePerWagon = int.Parse(Console.ReadLine());
                totalPeopleCount += peoplePerWagon;


                train[i] = peoplePerWagon;
            }
            Console.WriteLine(string.Join(" ", train));
            Console.WriteLine(totalPeopleCount);
        }
    }
}
