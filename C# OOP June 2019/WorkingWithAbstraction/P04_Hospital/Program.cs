using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_Hospital
{
    public class Program
    {
        public static void Main()
        {
            Dictionary<string, List<string>> doctors = new Dictionary<string, List<string>>();
            Dictionary<string, List<List<string>>> departments = new Dictionary<string, List<List<string>>>();

            string command = Console.ReadLine();

            while (command != "Output")
            {
                string[] tokens = command.Split();

                string departament = tokens[0];
                string firstName = tokens[1];
                string secondName = tokens[2];
                string patient = tokens[3];
                string fullName = firstName + secondName;

                DepartmentsFill(doctors, fullName, departments, departament);               

                bool isSpaceAvailable = departments[departament].SelectMany(x => x).Count() < 60;

                PatientPlacing(doctors, fullName, patient, departments, departament, isSpaceAvailable);

                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "End")
            {
                string[] input = command.Split();

                PrintOutput(input, departments, doctors);

                command = Console.ReadLine();
            }
        }

        private static void DepartmentsFill(Dictionary<string, List<string>> doctors, string fullName, Dictionary<string, List<List<string>>> departments, string departament)
        {
            if (!doctors.ContainsKey(fullName))
            {
                doctors[fullName] = new List<string>();
            }
            if (!departments.ContainsKey(departament))
            {
                departments[departament] = new List<List<string>>();

                for (int rooms = 0; rooms < 20; rooms++)
                {
                    departments[departament].Add(new List<string>());
                }
            }
        }

        private static void PrintOutput(string[] input, Dictionary<string, List<List<string>>> departments,
            Dictionary<string, List<string>> doctors)
        {
            if (input.Length == 1)
            {
                Console.WriteLine(string.Join("\n", departments[input[0]].Where(x => x.Count > 0).SelectMany(x => x)));
            }
            else if (input.Length == 2 && int.TryParse(input[1], out int room))
            {
                Console.WriteLine(string.Join("\n", departments[input[0]][room - 1].OrderBy(x => x)));
            }
            else
            {
                Console.WriteLine(string.Join("\n", doctors[input[0] + input[1]].OrderBy(x => x)));
            }
        }

        private static void PatientPlacing(Dictionary<string, List<string>> doctors, string fullName, string patient,
            Dictionary<string, List<List<string>>> departments, string departament, bool isSpaceAvailable)
        {
            if (isSpaceAvailable)
            {
                int currentRoom = 0;

                doctors[fullName].Add(patient);

                for (int room = 0; room < departments[departament].Count; room++)
                {
                    if (departments[departament][room].Count < 3)
                    {
                        currentRoom = room;
                        break;
                    }
                }

                departments[departament][currentRoom].Add(patient);
            }
        }
    }
}
