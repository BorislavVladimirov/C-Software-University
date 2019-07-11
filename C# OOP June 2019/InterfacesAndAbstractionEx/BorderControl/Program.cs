using System;
using System.Collections.Generic;

namespace BorderControl
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<IIdentifiable> result = new List<IIdentifiable>();

            while (input != "End")
            {
                string[] tempArr = input.Split();

                switch (tempArr.Length)
                {
                    case 2:
                        string model = tempArr[0];
                        string robotId = tempArr[1];

                        Robot robot = new Robot(model, robotId);
                        result.Add(robot);
                        break;
                    case 3:
                        string name = tempArr[0];
                        string age = tempArr[1];
                        string id = tempArr[2];

                        Citizen citizen = new Citizen(name, age, id);
                        result.Add(citizen);
                        break;
                }
                
                input = Console.ReadLine();
            }

            string idToCheck = Console.ReadLine();

            foreach (var item in result)
            {
                if (item.Id.EndsWith(idToCheck))
                {
                    Console.WriteLine(item.Id);
                }
            }
        }
    }
}
