using System;
using System.Collections.Generic;
using System.Linq;

namespace QuestsJournal
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> journal = Console.ReadLine().Split(", ").ToList();

            string command = Console.ReadLine();

            while (command != "Retire!")
            {
                List<string> operation = command.Split(" - ").ToList();

                string typeOfCommand = operation[0];
                string quest = operation[1];

                switch (typeOfCommand)
                {
                    case "Start":
                        if (!journal.Exists(j => j == quest))
                        {
                            journal.Add(quest);
                        }
                        break;

                    case "Complete":
                        if (journal.Exists(j => j == quest))
                        {
                            journal.Remove(quest);
                        }
                        break;

                    case "Side Quest":

                        string[] sideQuest = quest.Split(":");
                        string sQuest = sideQuest[1];

                        if (journal.Exists(e => e == sideQuest[0]))
                        {
                            int indexOfQuest = journal.IndexOf(sideQuest[0]);

                            if (!journal.Contains(sideQuest[1]))
                            {
                                journal.Insert(indexOfQuest + 1, sQuest);
                            }
                        }
                        break;

                    case "Renew":

                        if (journal.Contains(quest))
                        {
                            journal.Add(quest);
                            int indexOfQuest = journal.IndexOf(quest);
                            journal.RemoveAt(indexOfQuest);
                        }
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", journal));
        }
    }
}
