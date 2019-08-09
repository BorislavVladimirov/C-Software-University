using System;

namespace SquareRoot
{
    public class Program
    {
        public static void Main()
        {
            int number = 0;

            try
            {
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    if (number < 0)
                    {
                        throw new ArgumentException("Invalid number");
                    }

                    Console.WriteLine(Math.Sqrt(number));
                }
                else
                {
                    throw new ArgumentException("Invalid number");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Good bye");
            }

        }
    }
}
