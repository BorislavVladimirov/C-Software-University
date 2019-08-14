﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersAndMonsters.Models.Cards
{
    public class MagicCard : Card
    {
        private const int DamagePoint = 5;
        private const int HealthPoints = 80;

        public MagicCard(string name) 
            : base(name, DamagePoint, HealthPoints)
        {
        }
    }
}
