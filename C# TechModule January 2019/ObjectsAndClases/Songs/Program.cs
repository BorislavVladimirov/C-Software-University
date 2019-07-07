using System;
using System.Collections.Generic;

namespace Songs
{

    class Songs
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSongs = int.Parse(Console.ReadLine());

            List<Songs> songs = new List<Songs>();

            for (int i = 0; i < numberOfSongs; i++)
            {
                string[] inputdata = Console.ReadLine().Split('_');

                string type = inputdata[0];
                string name = inputdata[1];
                string time = inputdata[2];

                Songs song = new Songs();

                song.TypeList = type;
                song.Name = name;
                song.Time = time;

                songs.Add(song);
            }

            string comand = Console.ReadLine();

            switch (comand)
            {
                case "all":
                    foreach (Songs song in songs)
                    {
                        Console.WriteLine(song.Name);
                    }
                    break;
                default:
                    foreach (Songs song in songs)
                    {
                        if (song.TypeList == comand)
                        {
                            Console.WriteLine(song.Name);
                        }
                    }
                    break;

            }


        }
    }
}
