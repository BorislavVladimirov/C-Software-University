using System;
using System.Collections.Generic;

namespace TupleTask
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<object> items = new List<object>();

            //first tuple
            string[] line = Console.ReadLine().Split(" ");

            string fulleName = $"{line[0]} {line[1]}";
            string address = line[2];
            string town = string.Empty;

            for (int i = 3; i < line.Length; i++)
            {
                town += line[i] + " ";
            }

            CustomTuple<string, string,string> tuple1 = new CustomTuple<string, string,string>(fulleName, address,town.TrimEnd());
            items.Add(tuple1);

            //Secont tuple
            line = Console.ReadLine().Split(" ");
            string name = line[0];
            int litresOFbeer = int.Parse(line[1]);
            bool drunkYES = line[2] == "drunk" ? true : false;

            CustomTuple<string, int, bool> tuple2 = new CustomTuple<string, int, bool>(name, litresOFbeer, drunkYES);
            items.Add(tuple2);

            //tuple 3
            line = Console.ReadLine().Split();
            string personName = line[0];
            double accountBalance = double.Parse(line[1]);
            string bankName = line[2];

            CustomTuple<string, double, string> tuple3 = new CustomTuple<string, double,string>(personName, accountBalance, bankName);
            items.Add(tuple3);


            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
