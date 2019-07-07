using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniCoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> schedule = Console.ReadLine().Split(", ").ToList();

            string command = Console.ReadLine();

            string exercise = string.Empty;
            string lessonTitle = string.Empty;

            while (command != "course start")
            {
                string[] input = command.Split(":");

                string operation = input[0];

                switch (operation)
                {
                    case "Add":
                        if (!schedule.Contains(input[1]))
                        {
                            schedule.Add(input[1]);
                        }
                        break;

                    case "Insert":
                        if (!schedule.Contains(input[1]))
                        {
                            if (int.Parse(input[2]) >= 0 && int.Parse(input[2]) <= schedule.Count)
                            {
                                schedule.Insert(int.Parse(input[2]), input[1]);
                            }
                        }
                        break;

                    case "Remove":
                        if (schedule.Contains(input[1]))
                        {
                            lessonTitle = input[1];

                            if (IsLessonHavingExercise(schedule, lessonTitle, exercise))
                            {
                                schedule.Remove(lessonTitle + "-Exercise");
                            }
                            schedule.Remove(input[1]);
                        }
                        break;

                    case "Swap":
                        if (schedule.Contains(input[1]) && schedule.Contains(input[2]))
                        {
                            string firstLesson = input[1];
                            int firstIndex = schedule.IndexOf(firstLesson);

                            string secondLesson = input[2];
                            int secondIndex = schedule.IndexOf(secondLesson);

                            schedule[firstIndex] = secondLesson;
                            schedule[secondIndex] = firstLesson;
                            
                            if (schedule.Contains($"{firstLesson}-Exercise"))
                            {
                                schedule.Remove($"{firstLesson}-Exercise");
                                schedule.Insert(schedule.IndexOf(firstLesson) + 1, $"{firstLesson}-Exercise");
                            }
                            if (schedule.Contains($"{secondLesson}-Exercise"))
                            {
                                schedule.Remove($"{secondLesson}-Exercise");
                                schedule.Insert(schedule.IndexOf(secondLesson) + 1, $"{secondLesson}-Exercise");
                            }
                        }
                        break;
                    case "Exercise":
                        lessonTitle = input[1];

                        if (schedule.Contains(lessonTitle))
                        {
                            if (!IsLessonHavingExercise(schedule, lessonTitle, exercise))
                            {
                                int indexOfLesson = schedule.IndexOf(lessonTitle);
                                schedule.Insert(indexOfLesson + 1, lessonTitle + "-Exercise");
                            }
                        }
                        else if (!schedule.Contains(lessonTitle))
                        {
                            schedule.Add(lessonTitle);
                            schedule.Add(lessonTitle + "-Exercise");
                        }
                        break;
                }

                command = Console.ReadLine();
            }
            foreach (var lesson in schedule)
            {
                Console.WriteLine($"{schedule.IndexOf(lesson) + 1}.{lesson}");
            }

        }

        private static bool IsLessonHavingExercise(List<string> schedule, string lessonTitle, string exercise)
        {

            exercise = lessonTitle + "-Exercise";

            if (schedule.Contains(exercise))
            {
                return true;
            }
            return false;

        }
    }
}
