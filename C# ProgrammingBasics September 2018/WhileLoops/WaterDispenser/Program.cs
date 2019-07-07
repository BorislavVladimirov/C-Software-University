using System;

namespace WaterDispenser
{
    class Program
    {
        static void Main(string[] args)
        {
            double volume = double.Parse(Console.ReadLine());
            int waterIntTheGlass = 0;
            int count = 0;

            while (waterIntTheGlass <= volume)
            {
                string type = Console.ReadLine();


                if (type == "Easy")
                {
                    waterIntTheGlass = waterIntTheGlass + 50;
                    count++;
                }
                else if (type == "Medium")
                {
                    waterIntTheGlass = waterIntTheGlass + 100;
                    count++;
                }
                else if (type == "Hard")
                {
                    waterIntTheGlass = waterIntTheGlass + 200;
                    count++;
                }
                if (waterIntTheGlass == volume)
                {
                    Console.WriteLine($"The dispenser has been tapped {count} times.");
                    break;
                }
               
            }
            if (waterIntTheGlass > volume)
            {
                double waterSpilled = waterIntTheGlass - volume;
                Console.WriteLine($"{waterSpilled}ml has been spilled.");
            }
            
        }
    }
}
