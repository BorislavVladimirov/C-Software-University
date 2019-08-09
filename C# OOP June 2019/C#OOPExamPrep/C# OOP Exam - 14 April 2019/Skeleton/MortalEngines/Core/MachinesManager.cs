namespace MortalEngines.Core
{
    using Contracts;
    using MortalEngines.Common;
    using MortalEngines.Entities;
    using MortalEngines.Entities.Contracts;
    using MortalEngines.IO;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MachinesManager : IMachinesManager
    {
        private readonly List<IPilot> pilots;
        private readonly List<IMachine> machines;

        public MachinesManager()
        {
            this.pilots = new List<IPilot>();
            this.machines = new List<IMachine>();
        }
        public string HirePilot(string name)
        {
            if (this.pilots.Any(p => p.Name == name))
            {
                return string.Format(OutputMessages.PilotExists, name);
            }

            IPilot pilot = new Pilot(name);

            this.pilots.Add(pilot);
            return string.Format(OutputMessages.PilotHired, name);
        }

        public string ManufactureTank(string name, double attackPoints, double defensePoints)
        {
            if (this.machines.Any(m => m.Name == name))
            {
                return string.Format(OutputMessages.MachineExists, name);
            }

            ITank tank = new Tank(name, attackPoints, defensePoints);

            machines.Add(tank);
            return string.Format(OutputMessages.TankManufactured, name, tank.AttackPoints, tank.DefensePoints);
        }

        public string ManufactureFighter(string name, double attackPoints, double defensePoints)
        {
            if (this.machines.Any(m => m.Name == name))
            {
                return string.Format(OutputMessages.MachineExists, name);
            }

            IFighter fighter = new Fighter(name, attackPoints, defensePoints);

            machines.Add(fighter);
            return string.Format(OutputMessages.FighterManufactured, name, fighter.AttackPoints, fighter.DefensePoints, fighter.AggressiveMode ? "ON" : "OFF");
        }

        public string EngageMachine(string selectedPilotName, string selectedMachineName)
        {
            if (!pilots.Any(p => p.Name == selectedPilotName))
            {
                return string.Format(OutputMessages.PilotNotFound, selectedPilotName);
            }
            if (!machines.Any(m => m.Name == selectedMachineName))
            {
                return string.Format(OutputMessages.MachineNotFound, selectedMachineName);
            }

            IPilot pilot = pilots.FirstOrDefault(p => p.Name == selectedPilotName);
            IMachine machine = machines.FirstOrDefault(m => m.Name == selectedMachineName);

            if (machine.Pilot != null)
            {
                return string.Format(OutputMessages.MachineHasPilotAlready, selectedMachineName);
            }

            return string.Format(OutputMessages.MachineEngaged, selectedPilotName, selectedMachineName);
        }

        public string AttackMachines(string attackingMachineName, string defendingMachineName)
        {
            if (!machines.Any(m => m.Name == attackingMachineName))
            {
                return string.Format(OutputMessages.MachineNotFound, attackingMachineName);
            }
            if (!machines.Any(m => m.Name == defendingMachineName))
            {
                return string.Format(OutputMessages.MachineNotFound, defendingMachineName);
            }

            IMachine attackingMachine = machines.FirstOrDefault(m => m.Name == attackingMachineName);
            IMachine defendingMachine = machines.FirstOrDefault(m => m.Name == defendingMachineName);

            if (attackingMachine.HealthPoints == 0)
            {
                return string.Format(OutputMessages.DeadMachineCannotAttack, attackingMachineName);
            }
            if (defendingMachine.HealthPoints == 0)
            {
                return string.Format(OutputMessages.DeadMachineCannotAttack, defendingMachineName);
            }

            attackingMachine.Attack(defendingMachine);
            return string.Format(OutputMessages.AttackSuccessful, defendingMachineName, attackingMachineName, defendingMachine.HealthPoints);
        }

        public string PilotReport(string pilotReporting)
        {
            if (pilots.Any(p => p.Name == pilotReporting))
            {
                IPilot pilot = this.pilots.FirstOrDefault(p => p.Name == pilotReporting);
                return pilot.Report();
            }

            return string.Format(OutputMessages.PilotNotFound, pilotReporting);
        }

        public string MachineReport(string machineName)
        {
            if (this.machines.Any(m => m.Name == machineName))
            {
                IMachine machine = machines.FirstOrDefault(m => m.Name == machineName);
                return machine.ToString();
            }

            return string.Format(OutputMessages.MachineNotFound, machineName);
        }

        public string ToggleFighterAggressiveMode(string fighterName)
        {
            if (machines.Any(t => t.Name == fighterName))
            {
                IMachine machine = machines.FirstOrDefault(t => t.Name == fighterName);

                if (machine is IFighter fighter)
                {
                    fighter.ToggleAggressiveMode();

                }
                //IFighter figher1 = (IFighter)machine;
                return string.Format(OutputMessages.FighterOperationSuccessful, fighterName);
            }

            return string.Format(OutputMessages.MachineNotFound, fighterName);
        }

        public string ToggleTankDefenseMode(string tankName)
        {
            if (machines.Any(t => t.Name == tankName))
            {
                IMachine machine = machines.FirstOrDefault(t => t.Name == tankName);

                if (machine is ITank tank)
                {
                    tank.ToggleDefenseMode();

                }
                //ITank tank1 = (ITank)machine;
                return string.Format(OutputMessages.TankOperationSuccessful, tankName);
            }

            return string.Format(OutputMessages.MachineNotFound, tankName);
        }
    }
}