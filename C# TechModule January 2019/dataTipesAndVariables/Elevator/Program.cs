using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capasityOfElevator = int.Parse(Console.ReadLine());

            double courseCount = Math.Ceiling((double)numberOfPeople / (double)capasityOfElevator);
            Console.WriteLine(courseCount);
        }
    }
}
