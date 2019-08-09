using MortalEngines.Common;
using MortalEngines.Entities.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MortalEngines.Entities
{
    public class Pilot : IPilot
    {
        private string name;

        public Pilot(string name)
        {
            this.name = name;
            this.Machines = new List<IMachine>();
        }
        public string Name
        {
            get => this.name;

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(OutputMessages.PilotNameNullOrEmpty);
                }

                this.name = value;
            }
        }

        public List<IMachine> Machines { get; private set; }

        public void AddMachine(IMachine machine)
        {
            if (machine == null)
            {
                throw new NullReferenceException(OutputMessages.NullMachineCannotBeAdded);
            }

            this.Machines.Add(machine);
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.name} - {this.Machines.Count} machines");

            foreach (var machine in this.Machines)
            {
                sb.AppendLine(machine.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
