using MortalEngines.Common;
using MortalEngines.Entities.Contracts;
using MortalEngines.IO;
using System;
using System.Collections.Generic;
using System.Text;

namespace MortalEngines.Entities
{
    public abstract class BaseMachine : IMachine
    {
        private string name;
        private IPilot pilot;

        protected BaseMachine(string name, double attackPoints, double defensePoints, double healthPoints)
        {
            this.Name = name;
            this.AttackPoints = attackPoints;
            this.DefensePoints = defensePoints;
            this.HealthPoints = healthPoints;

            this.Targets = new List<string>();
        }

        public string Name
        {
            get => this.name;

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(OutputMessages.NameNullOrWhiteSpace);
                }

                this.name = value;
            }
        }

        public IPilot Pilot
        {
            get => this.pilot;

            set
            {
                this.pilot = value ?? throw new ArgumentException(OutputMessages.PilotCannotBeNull);
            }
        }

        public double HealthPoints { get; set; }

        public double AttackPoints { get; protected set; }

        public double DefensePoints { get; protected set; }

        public IList<string> Targets { get; }

        public void Attack(IMachine target)
        {
            if (target == null)
            {
                throw new ArithmeticException(OutputMessages.TargetCannotBeNull);
            }

            target.HealthPoints -= this.AttackPoints - target.DefensePoints;

            if (target.HealthPoints < 0)
            {
                target.HealthPoints = 0;
            }

            this.Targets.Add(target.Name);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"- {this.name}");
            sb.AppendLine($" *Type: {this.GetType().Name}");
            sb.AppendLine($" *Health: {this.HealthPoints:f2}");
            sb.AppendLine($" *Attack: {this.AttackPoints:f2}");
            sb.AppendLine($" *Defense: {this.DefensePoints:f2}");

            if (this.Targets.Count == 0)
            {
                sb.Append(" *Targets: ");
                sb.AppendLine("None");
            }
            else
            {
                sb.Append(" *Targets: ");
                sb.AppendLine(string.Join(", ", this.Targets));
            }

            return sb.ToString().TrimEnd();
        }
    }
}
