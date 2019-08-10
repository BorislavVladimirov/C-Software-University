using MXGP.Core.Contracts;
using MXGP.IO;
using MXGP.IO.Contracts;
using MXGP.Models.Motorcycles.Contracts;
using MXGP.Models.Races.Contracts;
using MXGP.Models.Riders.Contracts;
using MXGP.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MXGP.Core
{
    public class Engine : IEngine
    {
        private IReader consoleReader;
        private IWriter consoleWriter;
        private IChampionshipController championshipController;

        public Engine(IReader consoleReader, IWriter consoleWriter, IChampionshipController championshipController)
        {
            this.consoleReader = consoleReader;
            this.consoleWriter = consoleWriter;
            this.championshipController = championshipController;
        }

        public void Run()
        {
            StringBuilder sb = new StringBuilder();

            string input = consoleReader.ReadLine();

            while (input != "End")
            {
                string[] arr = input.Split();
                string typeOfCommand = arr[0];

                try
                {
                    switch (typeOfCommand)
                    {
                        case "CreateRider":
                            string name = arr[1];
                            sb.AppendLine(this.championshipController.CreateRider(name));
                            break;
                        case "CreateMotorcycle":
                            string motorcycleType = arr[1];
                            string model = arr[2];
                            string horsepower = arr[3];
                            sb.AppendLine(championshipController.CreateMotorcycle(motorcycleType, model, int.Parse(horsepower)));
                            break;
                        case "AddMotorcycleToRider":
                            string riderName = arr[1];
                            string motorcycleName = arr[2];
                            sb.AppendLine(championshipController.AddMotorcycleToRider(riderName, motorcycleName));
                            break;
                        case "AddRiderToRace":
                            string raceName = arr[1];
                            string currentRiderName = arr[2];
                            sb.AppendLine(championshipController.AddRiderToRace(raceName, currentRiderName));
                            break;
                        case "CreateRace":
                            string currentName = arr[1];
                            string laps = arr[2];
                            sb.AppendLine(championshipController.CreateRace(currentName, int.Parse(laps)));
                            break;
                        case "StartRace":
                            string currentRaceName = arr[1];
                            sb.AppendLine(championshipController.StartRace(currentRaceName));
                            break;
                    }
                }
                catch (Exception ex)
                {
                    sb.AppendLine(ex.Message);
                }

                input = consoleReader.ReadLine();
            }

            consoleWriter.WriteLine(sb.ToString().TrimEnd());
        }
    }
}
