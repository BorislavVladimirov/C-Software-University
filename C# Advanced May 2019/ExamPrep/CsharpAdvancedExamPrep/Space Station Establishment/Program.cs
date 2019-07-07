using System;

namespace Space_Station_Establishment
{
    class Program
    {
        private static int sRow;
        private static int sCol;

        private static int oRow;
        private static int oCol;

        private static int secondORow;
        private static int secondOCol;

        private static char[,] matrix;

        private static bool isBlackHoleGiven;

        private static int energy;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            matrix = GenerateMatrix(n);

            while (energy < 50)
            {
                string direction = Console.ReadLine();

                if (direction == "up")
                {
                    if (sRow - 1 < 0)
                    {
                        matrix[sRow, sCol] = '-';

                       // Console.WriteLine("Bad news, the spaceship went to the void.");
                        break;
                    }

                    if (char.IsDigit(matrix[sRow - 1, sCol]))
                    {
                        energy += int.Parse(matrix[sRow - 1, sCol].ToString());

                        matrix[sRow, sCol] = '-';
                        matrix[sRow - 1, sCol] = 'S';
                        matrix[sRow, sCol] = '-';

                        sRow = sRow - 1;
                    }
                    else if (matrix[sRow - 1, sCol] == matrix[oRow, oCol] && isBlackHoleGiven == true) // or sRow -1 == oRow , sCol == Ocol
                    {
                        matrix[secondORow, secondOCol] = 'S';
                        matrix[oRow, oCol] = '-';
                        matrix[sRow, sCol] = '-';
                        matrix[sRow - 1, sCol] = '-';

                        sRow = secondORow;
                        sCol = secondOCol;
                    }
                    else if (matrix[sRow - 1, sCol] == matrix[secondORow, secondOCol] && isBlackHoleGiven == true)
                    {
                        matrix[oRow, oCol] = 'S';
                        matrix[secondORow, secondOCol] = '-';
                        matrix[sRow, sCol] = '-';
                        matrix[sRow - 1, sCol] = '-';

                        sRow = oRow;
                        sCol = oCol;
                    }
                    else
                    {
                        matrix[sRow, sCol] = '-';
                        matrix[sRow - 1, sCol] = 'S';

                        sRow = sRow - 1;
                    }
                }
                else if (direction == "down")
                {
                    if (sRow + 1 > matrix.GetLength(0) - 1)
                    {
                        matrix[sRow, sCol] = '-';

                        //Console.WriteLine("Bad news, the spaceship went to the void.");
                        break;
                    }

                    if (char.IsDigit(matrix[sRow + 1, sCol]))
                    {
                        energy += int.Parse(matrix[sRow + 1, sCol].ToString());

                        matrix[sRow, sCol] = '-';
                        matrix[sRow + 1, sCol] = 'S';
                        matrix[sRow, sCol] = '-';


                        sRow = sRow + 1;
                    }
                    else if (matrix[sRow + 1, sCol] == matrix[oRow, oCol] && isBlackHoleGiven == true) // or sRow -1 == oRow , sCol == Ocol
                    {
                        matrix[secondORow, secondOCol] = 'S';
                        matrix[oRow, oCol] = '-';
                        matrix[sRow + 1, sCol] = '-';
                        matrix[sRow, sCol] = '-';

                        sRow = secondORow;
                        sCol = secondOCol;
                    }
                    else if (matrix[sRow + 1, sCol] == matrix[secondORow, secondOCol] && isBlackHoleGiven == true)
                    {
                        matrix[oRow, oCol] = 'S';
                        matrix[secondORow, secondOCol] = '-';
                        matrix[sRow, sCol] = '-';
                        matrix[sRow + 1, sCol] = '-';

                        sRow = oRow;
                        sCol = oCol;
                    }
                    else
                    {
                        matrix[sRow, sCol] = '-';
                        matrix[sRow + 1, sCol] = 'S';

                        sRow = sRow + 1;
                    }
                }
                else if (direction == "left")
                {
                    if (sCol -1 < 0)
                    {
                        matrix[sRow, sCol] = '-';

                       // Console.WriteLine("Bad news, the spaceship went to the void.");
                        break;
                    }

                    if (char.IsDigit(matrix[sRow, sCol - 1]))
                    {
                        energy += int.Parse(matrix[sRow, sCol - 1].ToString());


                        matrix[sRow, sCol] = '-';
                        matrix[sRow, sCol - 1] = 'S';
                        matrix[sRow, sCol] = '-';


                        sCol = sCol - 1;
                    }
                    else if (matrix[sRow, sCol - 1] == matrix[oRow, oCol] && isBlackHoleGiven == true) // or sRow -1 == oRow , sCol == Ocol
                    {
                        matrix[secondORow, secondOCol] = 'S';
                        matrix[oRow, oCol] = '-';
                        matrix[sRow, sCol - 1] = '-';
                        matrix[sRow, sCol] = '-';


                        sRow = secondORow;
                        sCol = secondOCol;
                    }
                    else if (matrix[sRow , sCol - 1] == matrix[secondORow, secondOCol] && isBlackHoleGiven == true)
                    {
                        matrix[oRow, oCol] = 'S';
                        matrix[secondORow, secondOCol] = '-';
                        matrix[sRow, sCol] = '-';
                        matrix[sRow, sCol - 1] = '-';

                        sRow = oRow;
                        sCol = oCol;
                    }
                    else
                    {
                        matrix[sRow, sCol] = '-';
                        matrix[sRow, sCol - 1] = 'S';

                        sCol = sCol - 1;
                    }
                }
                else if (direction == "right")
                {
                    if (sCol + 1 == matrix.GetLength(1))
                    {
                        matrix[sRow, sCol] = '-';

                        break;
                    }

                    if (char.IsDigit(matrix[sRow, sCol + 1]))
                    {
                        energy += int.Parse(matrix[sRow, sCol + 1].ToString());

                        matrix[sRow, sCol] = '-';
                        matrix[sRow, sCol + 1] = 'S';
                        matrix[sRow, sCol] = '-';


                        sCol = sCol + 1;
                    }
                    else if (matrix[sRow, sCol + 1] == matrix[oRow, oCol] && isBlackHoleGiven == true) // or sRow -1 == oRow , sCol == Ocol
                    {
                        matrix[secondORow, secondOCol] = 'S';
                        matrix[oRow, oCol] = '-';
                        matrix[sRow, sCol + 1] = '-';
                        matrix[sRow, sCol] = '-';

                        sRow = secondORow;
                        sCol = secondOCol;
                    }
                    else if (matrix[sRow, sCol + 1] == matrix[secondORow, secondOCol] && isBlackHoleGiven == true)
                    {
                        matrix[oRow, oCol] = 'S';
                        matrix[secondORow, secondOCol] = '-';
                        matrix[sRow, sCol] = '-';
                        matrix[sRow, sCol + 1] = '-';

                        sRow = oRow;
                        sCol = oCol;
                    }
                    else
                    {
                        matrix[sRow, sCol] = '-';
                        matrix[sRow, sCol + 1] = 'S';

                        sCol = sCol + 1;
                    }
                }
            }

            if (energy >= 50)
            {
                Console.WriteLine("Good news! Stephen succeeded in collecting enough star power!");
            }
            else
            {
                Console.WriteLine("Bad news, the spaceship went to the void.");
            }

            Console.WriteLine($"Star power collected: {energy}");

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]}");
                }
                Console.WriteLine();
            }
        }

        private static char[,] GenerateMatrix(int n)
        {
            char[,] matrix = new char[n, n];

            isBlackHoleGiven = false;

            for (int row = 0; row < n; row++)
            {
                char[] cols = Console.ReadLine().ToCharArray();

                for (int col = 0; col < n; col++)
                {
                    if (cols[col] == 'S')
                    {
                        sRow = row;
                        sCol = col;
                    }


                    if (cols[col] == 'O' && isBlackHoleGiven == false)
                    {
                        isBlackHoleGiven = true;

                        oRow = row;
                        oCol = col;
                    }
                    else if (cols[col] == 'O' && isBlackHoleGiven == true)
                    {
                        secondORow = row;
                        secondOCol = col;
                    }

                    matrix[row, col] = cols[col];
                }
            }

            return matrix;
        }
    }
}
