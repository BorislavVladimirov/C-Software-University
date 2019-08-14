namespace PlayersAndMonsters.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Contracts;
    using PlayersAndMonsters.Common;
    using PlayersAndMonsters.Core.Factories.Contracts;
    using PlayersAndMonsters.Models.BattleFields.Contracts;
    using PlayersAndMonsters.Models.Cards.Contracts;
    using PlayersAndMonsters.Models.Players;
    using PlayersAndMonsters.Models.Players.Contracts;
    using PlayersAndMonsters.Repositories;
    using PlayersAndMonsters.Repositories.Contracts;

    public class ManagerController : IManagerController
    {
        private readonly IPlayerRepository playerRepository;
        private readonly ICardFactory cardFactory;
        private readonly IPlayerFactory playerFactory;
        private readonly ICardRepository cardRepository;
        private readonly IBattleField battleField;

        public ManagerController(
            IPlayerRepository playerRepository,
            ICardFactory cardFactory,
            IPlayerFactory playerFactory,
            ICardRepository cardRepository,
            IBattleField battleField)
        {
            this.playerRepository = playerRepository;
            this.cardFactory = cardFactory;
            this.playerFactory = playerFactory;
            this.cardRepository = cardRepository;
            this.battleField = battleField;
        }

        public string AddPlayer(string type, string username)
        {
            IPlayer player = playerFactory.CreatePlayer(type, username);

            this.playerRepository.Add(player);

            return string.Format(ConstantMessages.SuccessfullyAddedPlayer, type, player.Username);
        }

        public string AddCard(string type, string name)
        {
            ICard card = this.cardFactory.CreateCard(type, name);

            this.cardRepository.Add(card);

            return string.Format(ConstantMessages.SuccessfullyAddedCard, type, card.Name);
        }

        public string AddPlayerCard(string username, string cardName)
        {
            IPlayer player = this.playerRepository.Find(username);
            ICard card = this.cardRepository.Find(cardName);

            player.CardRepository.Add(card);

            return string.Format(ConstantMessages.SuccessfullyAddedPlayerWithCards, card.Name, player.Username);
        }

        public string Fight(string attackUser, string enemyUser)
        {
            IPlayer attacker = playerRepository.Players.FirstOrDefault(p => p.Username == attackUser);
            IPlayer enemy = playerRepository.Players.FirstOrDefault(p => p.Username == enemyUser);

            this.battleField.Fight(attacker, enemy);

            return string.Format(ConstantMessages.FightInfo, attacker.Health, enemy.Health);
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var user in playerRepository.Players)
            {
                sb.AppendLine(string.Format(ConstantMessages.PlayerReportInfo, user.Username, user.Health, user.CardRepository.Cards.Count));

                foreach (var card in user.CardRepository.Cards)
                {
                    sb.AppendLine(string.Format(ConstantMessages.CardReportInfo, card.Name, card.DamagePoints));
                }

                sb.AppendLine(ConstantMessages.DefaultReportSeparator);
            }

            return sb.ToString().TrimEnd();
        }
    }
}
