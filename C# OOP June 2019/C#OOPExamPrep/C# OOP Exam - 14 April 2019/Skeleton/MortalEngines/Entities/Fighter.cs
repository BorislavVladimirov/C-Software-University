using MortalEngines.Common;
using MortalEngines.Entities.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MortalEngines.Entities
{
    public class Fighter : BaseMachine, IFighter
    {
        private const double InitalHealthPoints = 200;
        public Fighter(string name, double attackPoints, double defensePoints)
            : base(name, attackPoints, defensePoints, InitalHealthPoints)
        {
            this.AggressiveMode = true;

            this.AttackPoints += 50;
            this.DefensePoints -= 25;
        }

        public bool AggressiveMode { get; private set; }

        public void ToggleAggressiveMode()
        {
            if (this.AggressiveMode == true)
            {
                this.AggressiveMode = false;
                this.AttackPoints -= 50;
                this.DefensePoints += 25;
            }
            else
            {
                this.AggressiveMode = true;
                this.AttackPoints += 50;
                this.DefensePoints -= 25;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());

            if (this.AggressiveMode)
            {
                sb.AppendLine($" *Aggressive: {"ON"}");
            }
            else
            {
                sb.AppendLine($" *Aggressive: {"OFF"}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
