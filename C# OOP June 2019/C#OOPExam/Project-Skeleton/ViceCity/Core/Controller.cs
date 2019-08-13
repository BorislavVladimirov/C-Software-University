using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ViceCity.Core.Contracts;
using ViceCity.Models.Guns;
using ViceCity.Models.Guns.Contracts;
using ViceCity.Models.Neghbourhoods;
using ViceCity.Models.Neghbourhoods.Contracts;
using ViceCity.Models.Players;
using ViceCity.Models.Players.Contracts;

namespace ViceCity.Core
{
    public class Controller : IController
    {
        private readonly IPlayer mainPlayer;
        private readonly INeighbourhood neighbourhood;

        private readonly ICollection<IPlayer> civilPlayers;
        private readonly ICollection<IGun> guns;

        public Controller()
        {
            this.mainPlayer = new MainPlayer();
            this.neighbourhood = new GangNeighbourhood();

            this.civilPlayers = new List<IPlayer>();
            this.guns = new List<IGun>();
        }

        public string AddGun(string type, string name)
        {
            if (type == "Pistol")
            {
                IGun gun = new Pistol(name);
                this.guns.Add(gun);

                return $"Successfully added {name} of type: {type}";
            }
            else if (type == "Rifle")
            {
                IGun gun = new Rifle(name);
                this.guns.Add(gun);

                return $"Successfully added {name} of type: {type}";
            }

            return "Invalid gun type!";
        }

        public string AddGunToPlayer(string name)
        {
            if (!this.guns.Any())
            {
                return "There are no guns in the queue!";
            }

            IGun gun = this.guns.First();

            if (name == "Vercetti")
            {
                this.mainPlayer.GunRepository.Add(gun);
                this.guns.Remove(gun);

                return $"Successfully added {gun.Name} to the Main Player: Tommy Vercetti";
            }

            if (!this.civilPlayers.Any(p => p.Name == name))
            {
                return "Civil player with that name doesn't exists!";
            }

            this.civilPlayers.FirstOrDefault(p => p.Name == name).GunRepository.Add(gun);
            this.guns.Remove(gun);

            return $"Successfully added {gun.Name} to the Civil Player: {name}";
        }

        public string AddPlayer(string name)
        {
            IPlayer player = new CivilPlayer(name);

            this.civilPlayers.Add(player);

            return $"Successfully added civil player: {name}!";
        }

        public string Fight()
        {
            StringBuilder sb = new StringBuilder();

            int initialCivilPlayersCOunt = this.civilPlayers.Count;

            this.neighbourhood.Action(this.mainPlayer, this.civilPlayers);

            if (this.mainPlayer.LifePoints == 100
                && this.civilPlayers.Count == initialCivilPlayersCOunt
                && this.civilPlayers.First().LifePoints == 50)
            {
                return sb.AppendLine("Everything is okay!").ToString().TrimEnd();
            }

            sb.AppendLine("A fight happened:");
            sb.AppendLine($"Tommy live points: {this.mainPlayer.LifePoints}!");
            sb.AppendLine($"Tommy has killed: {initialCivilPlayersCOunt - this.civilPlayers.Count} players!");
            sb.AppendLine($"Left Civil Players: {this.civilPlayers.Count}!");

            return sb.ToString().Trim();
        }
    }
}
