using PlayersAndMonsters.Core.Contracts;
using PlayersAndMonsters.Core.Factories;
using PlayersAndMonsters.Core.Factories.Contracts;
using PlayersAndMonsters.IO;
using PlayersAndMonsters.IO.Contracts;
using PlayersAndMonsters.Models.Players.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersAndMonsters.Core
{
    public class Engine : IEngine
    {
        private readonly IWriter writer;
        private readonly IReader reader;
        private readonly IManagerController managerController;

        public Engine(IWriter writer, IReader reader, IManagerController managerController)
        {
            this.writer = writer;
            this.reader = reader;
            this.managerController = managerController;
        }

        public void Run()
        {
            var sb = new StringBuilder();
            string command = reader.ReadLine();

            while (command != "Exit")
            {
                string[] temp = command.Split();

                try
                {
                    switch (temp[0])
                    {
                        case "AddPlayer":
                            string playerType = temp[1];
                            string playerUsername = temp[2];

                            sb.AppendLine(managerController.AddPlayer(playerType, playerUsername));
                            break;
                        case "AddCard":
                            string cardType = temp[1];
                            string cardName = temp[2];

                            sb.AppendLine(managerController.AddCard(cardType, cardName));
                            break;
                        case "AddPlayerCard":
                            string username = temp[1];
                            string currentCardName = temp[2];

                            sb.AppendLine(managerController.AddPlayerCard(username, currentCardName));
                            break;
                        case "Fight":
                            string attackUser = temp[1];
                            string enemyUser = temp[2];

                            sb.AppendLine(managerController.Fight(attackUser, enemyUser));
                            break;
                        case "Report":
                            sb.AppendLine(managerController.Report());
                            break;
                    }
                }
                catch (Exception ex)
                {
                    sb.AppendLine(ex.Message);
                }

                command = reader.ReadLine();
            }

            writer.WriteLine(sb.ToString().TrimEnd());
        }
    }
}
