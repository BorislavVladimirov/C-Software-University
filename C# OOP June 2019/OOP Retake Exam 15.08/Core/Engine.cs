using SpaceStation.Core.Contracts;
using SpaceStation.IO;
using SpaceStation.IO.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceStation.Core
{
    public class Engine : IEngine
    {
        private IWriter writer;
        private IReader reader;
        private IController controller;

        public Engine()
        {
            this.writer = new Writer();
            this.reader = new Reader();
            this.controller = new Controller();
        }
        public void Run()
        {
            while (true)
            {
                var input = reader.ReadLine().Split();

                if (input[0] == "Exit")
                {
                    Environment.Exit(0);
                }
                try
                {
                    if (input[0] == "AddAstronaut")
                    {
                        string type = input[1];
                        string name = input[2];
                        writer.WriteLine(controller.AddAstronaut(type, name));
                    }
                    else if (input[0] == "AddPlanet")
                    {
                        string planetName = input[1];
                        string[] items = new string[input.Length - 2];

                        for (int i = 2; i < input.Length; i++)
                        {
                            items[i - 2] = input[i];
                        }

                        writer.WriteLine(controller.AddPlanet(planetName, items));
                    }
                    else if (input[0] == "RetireAstronaut")
                    {
                        string nameToRetire = input[1];
                        writer.WriteLine(controller.RetireAstronaut(nameToRetire));
                    }
                    else if (input[0] == "ExplorePlanet")
                    {
                        string planetName = input[1];
                        writer.WriteLine(controller.ExplorePlanet(planetName));
                    }
                    else if (input[0] == "Report")
                    {
                        writer.WriteLine(controller.Report());
                    }
                }
                catch (Exception ex)
                {
                    writer.WriteLine(ex.Message);
                }
            }
        }
    }
}
