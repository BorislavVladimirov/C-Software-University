using MortalEngines.Core.Contracts;
using MortalEngines.IO.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MortalEngines.Core
{
    public class Engine : IEngine
    {
        private IWriter writer;
        private IReader reader;
        private IMachinesManager machinesManager;

        public Engine(IWriter writer, IReader reader, IMachinesManager machinesManager)
        {
            this.writer = writer;
            this.reader = reader;
            this.machinesManager = machinesManager;
        }

        public void Run()
        {
            var sb = new StringBuilder();
            string input = reader.ReadCommands();

            while (input != "Quit")
            {
                string[] tempArray = input.Split().ToArray();

                string typeOfCommnd = tempArray[0];
                string name = tempArray[1];

                try
                {
                    switch (typeOfCommnd)
                    {
                        case "HirePilot":
                            sb.AppendLine(machinesManager.HirePilot(name));
                            break;
                        case "PilotReport":
                            sb.AppendLine(machinesManager.PilotReport(name));
                            break;
                        case "ManufactureTank":
                            sb.AppendLine(machinesManager.ManufactureTank(name, double.Parse(tempArray[2]), double.Parse(tempArray[3])));
                            break;
                        case "ManufactureFighter":
                            sb.AppendLine(machinesManager.ManufactureFighter(name, double.Parse(tempArray[2]), double.Parse(tempArray[3])));
                            break;
                        case "MachineReport":
                            sb.AppendLine(machinesManager.MachineReport(name));
                            break;
                        case "AggressiveMode":
                            sb.AppendLine(machinesManager.ToggleFighterAggressiveMode(name));
                            break;
                        case "DefenseMode":
                            sb.AppendLine(machinesManager.ToggleTankDefenseMode(name));
                            break;
                        case "Engage":
                            sb.AppendLine(machinesManager.EngageMachine(name, tempArray[2]));
                            break;
                        case "Attack":
                            sb.AppendLine(machinesManager.AttackMachines(name, tempArray[2]));
                            break;
                    }
                }
                catch (Exception ex)
                {
                    sb.AppendLine(ex.Message);
                }

                input = reader.ReadCommands();
            }

            writer.Write(sb.ToString().Trim());
        }
    }
}
