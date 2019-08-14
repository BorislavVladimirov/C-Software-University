using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PlayersAndMonsters.Models.BattleFields.Contracts;
using PlayersAndMonsters.Models.Players.Contracts;

namespace PlayersAndMonsters.Models.BattleFields
{
    public class BattleField : IBattleField
    {
        private const int BonusHealthPOints = 40;
        private const int BonuCardPoints = 30;

        public void Fight(IPlayer attackPlayer, IPlayer enemyPlayer)
        {
            if (attackPlayer.IsDead || enemyPlayer.IsDead)
            {
                throw new ArgumentException("Player is dead!");
            }

            if (attackPlayer.GetType().Name == "Beginner")
            {
                attackPlayer.Health += BonusHealthPOints;

                foreach (var card in attackPlayer.CardRepository.Cards)
                {
                    card.DamagePoints += BonuCardPoints;
                }
            }

            if (enemyPlayer.GetType().Name == "Beginner")
            {
                enemyPlayer.Health += BonusHealthPOints;

                foreach (var card in enemyPlayer.CardRepository.Cards)
                {
                    card.DamagePoints += BonuCardPoints;
                }
            }

            foreach (var card in attackPlayer.CardRepository.Cards)
            {
                attackPlayer.Health += card.HealthPoints;
            }

            foreach (var card in enemyPlayer.CardRepository.Cards)
            {
                enemyPlayer.Health += card.HealthPoints;
            }


            while (!attackPlayer.IsDead && !enemyPlayer.IsDead)
            {
                foreach (var card  in attackPlayer.CardRepository.Cards)
                {
                    enemyPlayer.TakeDamage(card.DamagePoints);
                }

                if (enemyPlayer.IsDead)
                {
                    return;
                }

                foreach (var card in enemyPlayer.CardRepository.Cards)
                {
                    attackPlayer.TakeDamage(card.DamagePoints);
                }

                if (attackPlayer.IsDead)
                    {
                        return;
                    }
            }
        }
    }
}
