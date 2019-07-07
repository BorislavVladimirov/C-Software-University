using System;

namespace train2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] trainArr = new int[n];
            int countOfPeople = 0;

            for (int i = 0; i < n; i++)
            {
                int people = int.Parse(Console.ReadLine());
                trainArr[i] = people;
                countOfPeople += people;
            }
            Console.WriteLine(string.Join(" ",trainArr));
            Console.WriteLine(countOfPeople);
        }
    }
}
