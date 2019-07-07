using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConcertClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Band> bands = new List<Band>();

            while (input != "start of concert")
            {
                string[] tempArr = input.Split("; ");
                string command = tempArr[0];
                string bandName = tempArr[1];

                Band band = bands.FirstOrDefault(x => x.Name == bandName);

                if (band == null)
                {
                    band = new Band
                    {
                        Name = bandName,
                        Members = new List<string>()
                    };

                    bands.Add(band);
                }

                switch (command)
                {
                    case "Add":
                        string[] members = tempArr[2].Split(", ");

                        foreach (var member in members)
                        {
                            if (!band.Members.Contains(member))
                            {
                                band.Members.Add(member);
                            }
                        }
                        break;
                    case "Play":
                        int time = int.Parse(tempArr[2]);

                        band.TimePlayed += time;
                        break;
                }

                input = Console.ReadLine();
            }
            
            Console.WriteLine($"Total time: {bands.Sum(x => x.TimePlayed)}");

            foreach (var band in bands
                .OrderByDescending(x => x.TimePlayed)
                .ThenBy(x => x.Name))
            {
                Console.WriteLine($"{band.Name} -> {band.TimePlayed}");
            }

            string finalInput = Console.ReadLine();

            Band bandToPrint = bands.FirstOrDefault(x => x.Name == finalInput);

            Console.WriteLine(finalInput);

            foreach (var member in bandToPrint.Members)
            {
                Console.WriteLine($"=> {member}");
            }
        }
    }

    class Band
    {
        public string Name { get; set; }

        public int TimePlayed { get; set; }

        public List<string> Members { get; set; }
    }
}
