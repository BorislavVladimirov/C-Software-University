using AnimalCentre.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalCentre.Models.Procedures
{
    public abstract class Procedure : IProcedure
    {
        private List<IAnimal> procedureHistory;

        public Procedure()
        {
            this.ProcedureHistory = new List<IAnimal>();
        }

        public List<IAnimal> ProcedureHistory { get; set; }

        public virtual void DoService(IAnimal animal, int procedureTime)
        {

        }

        public string History()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.GetType().Name}");

            foreach (var animal in this.ProcedureHistory)
            {
                sb.AppendLine($"    - {animal.Name} - Happiness: {animal.Happiness} - Energy: {animal.Energy}");
            }

            return sb.ToString().Trim();
        }
    }
}
