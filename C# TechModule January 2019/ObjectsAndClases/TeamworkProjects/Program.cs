using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfTeams = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();
            List<Team> disbandedTeams = new List<Team>();

            for (int i = 0; i < countOfTeams; i++)
            {
                string[] creatorAndTeamName = Console.ReadLine().Split("-");

                string creator = creatorAndTeamName[0];
                string teamName = creatorAndTeamName[1];

                Team team = new Team()
                {
                    Creator = creator,
                    Name = teamName,
                    Members = new List<string>()
                };

                if (IsCurrentTeamExisting(teams, teamName))
                {
                    Console.WriteLine($"Team {team.Name} was already created!");
                }
                else if (IsCreatorExisting(teams, creator))
                {
                    Console.WriteLine($"{team.Creator} cannot create another team!");
                }
                else
                {
                    teams.Add(team);
                    Console.WriteLine($"Team {team.Name} has been created by {team.Creator}!");
                }
            }

            string userNameAndTeamToJoin = Console.ReadLine();

            while (userNameAndTeamToJoin != "end of assignment")
            {
                string[] arr = userNameAndTeamToJoin.Split("->");

                string member = arr[0];
                string teamToJoin = arr[1];

                Team currentTeam = teams.FirstOrDefault(t => t.Name == teamToJoin);

                if (currentTeam == null)
                {
                    Console.WriteLine($"Team {teamToJoin} does not exist!");
                }
                else if (CheckIfMemberIsCreator(teams, member))
                {
                    Console.WriteLine($"Member {member} cannot join team {teamToJoin}!");
                }
                else
                {
                    currentTeam.Members.Add(member);
                }

                userNameAndTeamToJoin = Console.ReadLine();
            }

            disbandedTeams.AddRange(teams.Where(t => !t.Members.Any()));

            teams.RemoveAll(x => !x.Members.Any());

            foreach (var team in teams.OrderByDescending(m => m.Members.Count).ThenBy(t => t.Name))
            {
                Console.WriteLine(team.Name);
                Console.WriteLine("- {0}", team.Creator);

                foreach (var member in team.Members.OrderBy(m => m))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");

            foreach (var dibanded in disbandedTeams.OrderByDescending(d => d.Members.Count).ThenBy(t => t.Name))
            {
                Console.WriteLine(dibanded.Name);

                foreach (var member in dibanded.Members.OrderBy(m => m))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

        }

        private static bool CheckIfMemberIsCreator(List<Team> teams, string member)
        {
            foreach (Team team in teams)
            {
                if (team.Creator == member)
                {
                    return true;
                }

                foreach (var m in team.Members)
                {
                    if (m == member)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private static Team FindCurrentTeam(List<Team> teams, string teamToJoin)
        {
            foreach (Team team in teams)
            {
                if (team.Name == teamToJoin)
                {
                    return team;
                }
            }

            return null;
        }

        static bool IsCreatorExisting(List<Team> teams, string creator)
        {
            foreach (var item in teams)
            {
                if (item.Creator == creator)
                {
                    return true;
                }
            }
            return false;
        }

        static bool IsCurrentTeamExisting(List<Team> teams, string teamName)
        {
            foreach (var item in teams)
            {
                if (item.Name == teamName)
                {
                    return true;
                }
            }
            return false;
        }
    }

    class Team
    {
        public string Creator { get; set; }

        public string Name { get; set; }

        public List<string> Members { get; set; }
        
    }
}
