using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ViceCity.Models.Guns.Contracts;
using ViceCity.Models.Neghbourhoods.Contracts;
using ViceCity.Models.Players.Contracts;

namespace ViceCity.Models.Neghbourhoods
{
    public class GangNeighbourhood : INeighbourhood
    {
        public void Action(IPlayer mainPlayer, ICollection<IPlayer> civilPlayers)
        {
            while (mainPlayer.GunRepository.Models.Any() && civilPlayers.Any())
            {
                IGun gun = mainPlayer.GunRepository.Models.FirstOrDefault();

                IPlayer player = civilPlayers.FirstOrDefault();

                while (player.IsAlive && gun.CanFire)
                {
                    player.TakeLifePoints(gun.Fire());
                }

                if (!player.IsAlive)
                {
                    civilPlayers.Remove(player);
                }
                if (!gun.CanFire)
                {
                    mainPlayer.GunRepository.Remove(gun);
                }
            }

            foreach (var player in civilPlayers)
            {
                while (mainPlayer.IsAlive && player.GunRepository.Models.Any())
                {
                    IGun gun = player.GunRepository.Models.FirstOrDefault();

                    while (mainPlayer.IsAlive && gun.CanFire)
                    {
                        mainPlayer.TakeLifePoints(gun.Fire());
                    }

                    if (!mainPlayer.IsAlive)
                    {
                        return;
                    }
                    if (!gun.CanFire)
                    {
                        player.GunRepository.Remove(gun);
                    }
                }

            }
        }
    }
}
