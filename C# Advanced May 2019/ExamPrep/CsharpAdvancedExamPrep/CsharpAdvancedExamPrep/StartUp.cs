using System;

namespace CsharpAdvancedExamPrep
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int rowsCount = int.Parse(Console.ReadLine());

            string[][] jaggedArray = new string[rowsCount][];

            for (int i = 0; i < jaggedArray.GetLength(0); i++)
            {
                string[] col = Console.ReadLine().Split();

                jaggedArray[i] = col;
            }

            string input = Console.ReadLine();

            int lettuceHarvedCount = 0;
            int potatoesHarvedCount = 0;
            int carrotsHarvedCount = 0;
            int harmedVegetables = 0;

            while (input != "End of Harvest")
            {
                string[] command = input.Split();

                string typeOfCommand = command[0];
                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);

                if (typeOfCommand == "Harvest")
                {
                    if (IsInside(row, col, jaggedArray))
                    {
                        if (jaggedArray[row][col] != " ")
                        {
                            switch (jaggedArray[row][col])
                            {
                                case "L":
                                    lettuceHarvedCount++;
                                    break;
                                case "P":
                                    potatoesHarvedCount++;
                                    break;
                                case "C":
                                    carrotsHarvedCount++;
                                    break;
                            }

                            jaggedArray[row][col] = " ";
                        }
                    }
                }
                else if (typeOfCommand == "Mole")
                {
                    string direction = command[3];

                    if (IsInside(row, col, jaggedArray))
                    {
                        if (direction == "up")
                        {
                            while (row >= 0)
                            {
                                if (jaggedArray[row][col] != " ")
                                {
                                    jaggedArray[row][col] = " ";
                                    harmedVegetables++;
                                }

                                row -= 2;
                            }
                        }
                        else if (direction == "down")
                        {
                            while (row <= jaggedArray.Length - 1)
                            {
                                if (jaggedArray[row][col] != " ")
                                {
                                    jaggedArray[row][col] = " ";
                                    harmedVegetables++;
                                }

                                row += 2;
                            }
                        }
                        else if (direction == "left")
                        {
                            while (col >= 0)
                            {
                                if (jaggedArray[row][col] != " ")
                                {
                                    jaggedArray[row][col] = " ";
                                    harmedVegetables++;
                                }

                                col -= 2;
                            }
                        }
                        else if (direction == "right")
                        {
                            while (col <= jaggedArray[row].Length - 1)
                            {
                                if (jaggedArray[row][col] != " ")
                                {
                                    jaggedArray[row][col] = " ";
                                    harmedVegetables++;
                                }

                                col += 2;
                            }
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Print(jaggedArray, lettuceHarvedCount, potatoesHarvedCount, carrotsHarvedCount, harmedVegetables);

        }

        private static void Print(string[][] jaggedArray, int lettuceHarvedCount, int potatoesHarvedCount, int carrotsHarvedCount, int harmedVegetables)
        {
            for (int row = 0; row < jaggedArray.Length; row++)
            {
                Console.Write(string.Join(" ", jaggedArray[row]));

                Console.WriteLine();
            }

            Console.WriteLine($"Carrots: {carrotsHarvedCount}");
            Console.WriteLine($"Potatoes: {potatoesHarvedCount}");
            Console.WriteLine($"Lettuce: {lettuceHarvedCount}");
            Console.WriteLine($"Harmed vegetables: {harmedVegetables}");
        }

        public static bool IsInside(int row, int col, string[][] jaggedArray)
        {
            if (row >= 0
                && row < jaggedArray.Length
                && col >= 0 
                && col < jaggedArray[row].Length)
            {
                return true;
            }

            return false;
        }
    }
}
