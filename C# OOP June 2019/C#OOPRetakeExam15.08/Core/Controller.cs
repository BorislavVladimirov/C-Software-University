using SpaceStation.Core.Contracts;
using SpaceStation.Models.Astronauts;
using SpaceStation.Models.Astronauts.Contracts;
using SpaceStation.Models.Mission;
using SpaceStation.Models.Planets;
using SpaceStation.Repositories;
using SpaceStation.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceStation.Core
{
    public class Controller : IController
    {
        AstronautRepository astronautRepository;
        PlanetRepository planetRepository;
        private int exploredPlanetsCount = 0;
        private List<IAstronaut> suitableAstronauts;

        public Controller()
        {
            this.astronautRepository = new AstronautRepository();
            this.planetRepository = new PlanetRepository();
            this.suitableAstronauts = new List<IAstronaut>();
        }

        public string AddAstronaut(string type, string astronautName)
        {
            IAstronaut astronaut = null;

            switch (type)
            {
                case "Biologist":
                    astronaut = new Biologist(astronautName);
                    break;
                case "Geodesist":
                    astronaut = new Geodesist(astronautName);
                    break;
                case "Meteorologist":
                    astronaut = new Meteorologist(astronautName);
                    break;
                default:
                    throw new InvalidOperationException(ExceptionMessages.InvalidAstronautType);
            }

            astronautRepository.Add(astronaut);

            return string.Format(OutputMessages.AstronautAdded, astronaut.GetType().Name, astronautName);
        }

        public string AddPlanet(string planetName, params string[] items)
        {
            IPlanet planet = new Planet(planetName);

            foreach (var item in items.ToList())
            {
                planet.Items.Add(item);
            }

            planetRepository.Add(planet);

            return string.Format(OutputMessages.PlanetAdded, planet.Name);
        }

        public string ExplorePlanet(string planetName)
        {
            IPlanet planet = this.planetRepository.FindByName(planetName);

            IMission mission = new Mission();

            if (!this.astronautRepository.Models.Any(a => a.Oxygen > 60))
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidAstronautCount);
            }

            foreach (var astronaut in this.astronautRepository.Models.Where(a => a.Oxygen > 60))
            {
                this.suitableAstronauts.Add(astronaut);
            }

            mission.Explore(planet, suitableAstronauts);
            exploredPlanetsCount += 1;

            return string.Format(OutputMessages.PlanetExplored, planet.Name, this.suitableAstronauts.Where(a => a.Oxygen <= 0).ToList().Count);
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{exploredPlanetsCount} planets were explored!");

            foreach (var astronaut in this.astronautRepository.Models)
            {
                sb.AppendLine("Astronauts info:");
                sb.AppendLine($"Name: {astronaut.Name}");
                sb.AppendLine($"Oxygen: {astronaut.Oxygen}");

                if (!astronaut.Bag.Items.Any())
                {
                    sb.Append("Bag items: ");
                    sb.AppendLine("none");
                }
                else if (astronaut.Bag.Items.Any())
                {
                    sb.AppendLine($"Bag items: " + string.Join(", ", astronaut.Bag.Items));
                }
            }

            return sb.ToString().TrimEnd();
        }

        public string RetireAstronaut(string astronautName)
        {
            if (this.astronautRepository.FindByName(astronautName) == null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.InvalidRetiredAstronaut, astronautName));
            }
            IAstronaut astronaut = this.astronautRepository.FindByName(astronautName);

            this.astronautRepository.Remove(astronaut);

            return string.Format(OutputMessages.AstronautRetired, astronaut.Name);
        }
    }
}
