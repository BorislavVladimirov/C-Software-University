using PlayersAndMonsters.Core.Factories.Contracts;
using PlayersAndMonsters.Models.Players;
using PlayersAndMonsters.Models.Players.Contracts;
using PlayersAndMonsters.Repositories;
using PlayersAndMonsters.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersAndMonsters.Core.Factories
{
    public class PlayerFactory : IPlayerFactory
    {
        public IPlayer CreatePlayer(string type, string username)
        {
            ICardRepository cardRepository = new CardRepository();

            IPlayer player;

            switch (type)
            {
                case "Advanced":
                    player = new Advanced(cardRepository,username);
                    break;
                case "Beginner":
                    player = new Beginner(cardRepository, username);
                    break;
                default:
                    player = null;
                    break;
            }

            return player;
        }
    }
}
