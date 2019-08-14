using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersAndMonsters.Models.Cards
{
    public class TrapCard : Card
    {
        private const int DamagePoint = 120;
        private const int HealthPoints = 5;

        public TrapCard(string name)
            : base(name, DamagePoint, HealthPoints)
        {
        }
    }
}
