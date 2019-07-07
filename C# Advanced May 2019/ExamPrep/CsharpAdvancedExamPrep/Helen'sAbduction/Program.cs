using System;
using System.Linq;

namespace Helen_sAbduction
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int parisEnergy = int.Parse(Console.ReadLine());
            int size = int.Parse(Console.ReadLine());

            string[,] matrix = new string[size, size];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] elements = Console.ReadLine().ToCharArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = elements[col].ToString();
                }
            }

            int rowIndexOfParis = 0;
            int colIndexOfParis = 0;

            int rowIndexOfHelen = 0;
            int colIndexOfHelen = 0;

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    string currentItem = matrix[row, col].ToString();

                    if (currentItem == "P")
                    {
                        rowIndexOfParis = row;
                        colIndexOfParis = col;
                    }

                    if (currentItem == "H")
                    {
                        rowIndexOfHelen = row;
                        colIndexOfHelen = col;
                    }
                }
            }

            while (true)
            {
                string[] command = Console.ReadLine().Split();

                string direction = command[0];

                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);

                matrix[row, col] = "S";

                if (direction == "up")
                {
                    rowIndexOfParis -= 1;

                    Move(matrix, rowIndexOfParis, colIndexOfParis, ref parisEnergy, direction);

                    if (IsInside(matrix, rowIndexOfParis, colIndexOfParis) == false)
                    {
                        continue;
                    }

                    if (IsParisDead(ref parisEnergy))
                    {
                        //matrix[rowIndexOfParis, colIndexOfParis] = "X";
                        break;

                    }

                    if (IsHelenAbducted(matrix, rowIndexOfParis, colIndexOfParis, direction))
                    {
                        matrix[rowIndexOfParis, colIndexOfParis] = "-";
                        break;

                    }
                }
                else if (direction == "down")
                {
                    rowIndexOfParis += 1;

                    Move(matrix, rowIndexOfParis, colIndexOfParis, ref parisEnergy, direction);

                    if (IsInside(matrix, rowIndexOfParis, colIndexOfParis) == false)
                    {
                        continue;
                    }

                    if (IsParisDead(ref parisEnergy))
                    {
                        matrix[rowIndexOfParis, colIndexOfParis] = "X";
                        break;

                    }
                    if (IsHelenAbducted(matrix, rowIndexOfParis, colIndexOfParis, direction))
                    {
                        matrix[rowIndexOfParis, colIndexOfParis] = "-";
                        break;

                    }
                }
                else if (direction == "left")
                {
                    colIndexOfParis -= 1;

                    Move(matrix, rowIndexOfParis, colIndexOfParis, ref parisEnergy, direction);

                    if (IsInside(matrix, rowIndexOfParis, colIndexOfParis) == false)
                    {
                        continue;
                    }

                    if (IsParisDead(ref parisEnergy))
                    {
                        matrix[rowIndexOfParis, colIndexOfParis] = "X";
                        break;

                    }
                    if (IsHelenAbducted(matrix, rowIndexOfParis, colIndexOfParis, direction))
                    {
                        matrix[rowIndexOfParis, colIndexOfParis] = "-";
                        break;

                    }
                }
                else if (direction == "right")
                {
                    colIndexOfParis += 1;

                    Move(matrix, rowIndexOfParis, colIndexOfParis, ref parisEnergy, direction);

                    if (IsInside(matrix, rowIndexOfParis, colIndexOfParis) == false)
                    {
                        continue;
                    }

                    if (IsParisDead(ref parisEnergy))
                    {
                        matrix[rowIndexOfParis, colIndexOfParis] = "X";
                        break;

                    }
                    if (IsHelenAbducted(matrix, rowIndexOfParis, colIndexOfParis, direction))
                    {
                        matrix[rowIndexOfParis, colIndexOfParis] = "-";
                        break;

                    }
                }
            }

            Print(matrix);
        }

        private static void Print(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }
        }

        private static void Move(string[,] matrix, int rowIndexOfParis, int colIndexOfParis, ref int parisEnergy, string direction)
        {
            if (IsInside(matrix, rowIndexOfParis, colIndexOfParis))
            {
                parisEnergy -= 1;

                if (matrix[rowIndexOfParis, colIndexOfParis] == "S")
                {
                    parisEnergy -= 2;

                    if (IsParisDead(ref parisEnergy))
                    {
                        switch (direction)
                        {
                            case "up":
                                matrix[rowIndexOfParis + 1, colIndexOfParis] = "-";
                                break;
                            case "down":
                                matrix[rowIndexOfParis - 1, colIndexOfParis] = "-";
                                break;
                            case "left":
                                matrix[rowIndexOfParis, colIndexOfParis + 1] = "-";
                                break;
                            case "right":
                                matrix[rowIndexOfParis, colIndexOfParis - 1] = "-";
                                break;
                        }

                        Console.WriteLine($"Paris died at {rowIndexOfParis};{colIndexOfParis}.");
                    }

                    matrix[rowIndexOfParis, colIndexOfParis] = "P";

                    switch (direction)
                    {
                        case "up":
                            matrix[rowIndexOfParis + 1, colIndexOfParis] = "-";
                            break;
                        case "down":
                            matrix[rowIndexOfParis - 1, colIndexOfParis] = "-";
                            break;
                        case "left":
                            matrix[rowIndexOfParis, colIndexOfParis + 1] = "-";
                            break;
                        case "right":
                            matrix[rowIndexOfParis, colIndexOfParis - 1] = "-";
                            break;
                    }
                }
                else if (IsHelenAbducted(matrix, rowIndexOfParis, colIndexOfParis, direction))
                {
                    Console.WriteLine($"Paris has successfully abducted Helen! Energy left: {parisEnergy}");
                }
                else if (IsParisDead(ref parisEnergy))
                {

                    matrix[rowIndexOfParis - 1, colIndexOfParis] = "X";
                    matrix[rowIndexOfParis , colIndexOfParis] = "-";


                }
                else
                {
                    switch (direction)
                    {
                        case "up":
                            matrix[rowIndexOfParis + 1, colIndexOfParis] = "-";
                            break;
                        case "down":
                            matrix[rowIndexOfParis - 1, colIndexOfParis] = "-";
                            break;
                        case "left":
                            matrix[rowIndexOfParis, colIndexOfParis + 1] = "-";
                            break;
                        case "right":
                            matrix[rowIndexOfParis, colIndexOfParis - 1] = "-";
                            break;
                    }

                    matrix[rowIndexOfParis, colIndexOfParis] = "P";

                }
            }
            else
            {
                parisEnergy -= 1;
            }
        }

        private static bool IsHelenAbducted(string[,] matrix, int rowIndexOfParis, int colIndexOfParis, string direction)
        {
            if (matrix[rowIndexOfParis, colIndexOfParis] == "H")
            {
                switch (direction)
                {
                    case "up":
                        matrix[rowIndexOfParis + 1, colIndexOfParis] = "-";
                        break;
                    case "down":
                        matrix[rowIndexOfParis - 1, colIndexOfParis] = "-";
                        break;
                    case "left":
                        matrix[rowIndexOfParis, colIndexOfParis + 1] = "-";
                        break;
                    case "right":
                        matrix[rowIndexOfParis, colIndexOfParis - 1] = "-";
                        break;
                }
                return true;
            }

            return false;
        }

        private static bool IsParisDead(ref int parisEnergy)
        {
            if (parisEnergy <= 0)
            {
                return true;
            }

            return false;
        }

        private static bool IsInside(string[,] matrix, int rowIndexOfParis, int colIndexOfParis)
        {
            if (rowIndexOfParis >= 0
                && rowIndexOfParis < matrix.GetLength(0)
                && colIndexOfParis >= 0
                && colIndexOfParis < matrix.GetLength(1))
            {
                return true;
            }

            return false;
        }
    }
}

