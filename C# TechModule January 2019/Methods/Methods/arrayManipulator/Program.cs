using System;
using System.Linq;

namespace arrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string[] arrManipulation = Console.ReadLine()
                .Split(" ")
                .ToArray();

            while (arrManipulation[0] != "end")
            {
                switch (arrManipulation[0])//checking the input command
                {
                    case "exchange":
                        Exchange(numbers, arrManipulation);
                        break;
                    case "max":
                        Console.WriteLine(MaxEvenOdd(numbers, arrManipulation));
                        break;
                    case "min":
                        Console.WriteLine(MinEvenOdd(numbers, arrManipulation));
                        break;
                    case "first":
                        Console.WriteLine($"[{FirstEvenOdd(numbers, arrManipulation)}]");
                        break;
                    case "last":
                        Console.WriteLine($"[{LastEvenOdd(numbers, arrManipulation)}]");
                        break;
                }
                arrManipulation = Console.ReadLine()
                    .Split()
                    .ToArray();
            }
            PrintFinalArray(numbers);
        }

        private static void PrintFinalArray(int[] numbers)
        {
            Console.WriteLine(string.Join(" ", numbers));
        }

        private static string LastEvenOdd(int[] numbers, string[] arrManipulation)
        {
            string result = string.Empty;

            if (arrManipulation[2] == "even")
            {
                result = LastEven(numbers, arrManipulation);
            }
            else if (arrManipulation[2] == "odd")
            {
                result = LastOdd(numbers, arrManipulation);
            }
            return result;
        }

        private static string LastOdd(int[] numbers, string[] arrManipulation)
        {
            string result = string.Empty;
            int countOfElements = int.Parse(arrManipulation[1]); //finding how many elements of the array will be needed
            int[] arr = new int[countOfElements];

            if (countOfElements > numbers.Length)
            {
                result = "Invalid count";
            }
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = numbers.Length - 1; j > 0; j--)
                {
                    int currentNumer = numbers[j];

                    if (currentNumer % 2 != 0)
                    {
                        arr[i] = currentNumer;
                    }
                }
            }
            result = arr.ToString();

            if (numbers.Length == 0)
            {
                result = "[]";
            }
            return result;
        }

        private static string LastEven(int[] numbers, string[] arrManipulation)
        {
            string result = string.Empty;
            int countOfElements = int.Parse(arrManipulation[1]); //finding how many elements of the array will be needed
            int[] arr = new int[countOfElements];

            if (countOfElements > numbers.Length)
            {
                result = "Invalid count";
            }
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = numbers.Length - 1; j > 0; j--)
                {
                    int currentNumer = numbers[j];

                    if (currentNumer % 2 == 0)
                    {
                        arr[i] = currentNumer;
                    }
                }
            }
            result = arr.ToString();

            if (numbers.Length == 0)
            {
                result = "[]";
            }
            return result;
        }

        private static string FirstEvenOdd(int[] numbers, string[] arrManipulation)
        {
            string result = string.Empty;

            if (arrManipulation[2] == "even")
            {
                result = FirstEven(numbers, arrManipulation);
            }
            else if (arrManipulation[2] == "odd")
            {
                result = FirstOdd(numbers, arrManipulation);
            }
            return result;
        }

        private static string FirstOdd(int[] numbers, string[] arrManipulation)
        {
            string result = string.Empty;
            int countOfElements = int.Parse(arrManipulation[1]); //finding how many elements of the array will be needed
            int[] arr = new int[countOfElements];

            if (countOfElements > numbers.Length)
            {
                result = "Invalid count";
            }
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    int currentNumer = numbers[j];

                    if (currentNumer % 2 != 0)
                    {
                        arr[i] = currentNumer;
                    }
                }
            }
            result = arr.ToString();

            if (numbers.Length == 0)
            {
                result = "[]";
            }
            return result;
        }

        private static string FirstEven(int[] numbers, string[] arrManipulation)
        {
            string result = string.Empty;
            int countOfElements = int.Parse(arrManipulation[1]); //finding how many elements of the array will be needed
            int[] arr = new int[countOfElements];

            if (countOfElements > numbers.Length)
            {
                result = "Invalid count";
            }
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    int currentNumer = numbers[j];

                    if (currentNumer % 2 == 0)
                    {
                        arr[i] = currentNumer;
                    }
                }
            }
            result = arr.ToString();

            if (numbers.Length == 0)
            {
                result = "[]";
            }
            return result;
        }

        private static string MinEvenOdd(int[] numbers, string[] arrManipulation)
        {
            string result = string.Empty;

            if (arrManipulation[1] == "even")
            {
                result = MinEven(numbers);
            }
            else if (arrManipulation[1] == "odd")
            {
                result = MinOdd(numbers);
            }
            return result;
        }

        private static string MinOdd(int[] numbers)
        {
            int minOdd = int.MaxValue;
            string result = string.Empty;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];

                if (currentNumber % 2 != 0 && currentNumber <= minOdd)
                {
                    minOdd = currentNumber;
                    result = i.ToString();
                }
                else
                {
                    result = "No matches";
                }
            }
            return result;
        }

        private static string MinEven(int[] numbers)
        {
            int minEven = int.MaxValue;
            string result = string.Empty;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];

                if (currentNumber % 2 == 0 && currentNumber <= minEven)
                {
                    minEven = currentNumber;
                    result = i.ToString();
                }
                else
                {
                    result = "No matches";
                }
            }
            return result;
        }

        private static string MaxEvenOdd(int[] numbers, string[] arrManipulation)
        {
            string result = string.Empty;

            if (arrManipulation[1] == "even")
            {
                result = MaxEven(numbers);
            }
            else if (arrManipulation[1] == "odd")
            {
                result = MaxOdd(numbers);
            }
            return result;
        }

        private static string MaxOdd(int[] numbers)
        {
            int maxOdd = int.MinValue;
            string result = string.Empty;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];

                if (currentNumber % 2 != 0 && currentNumber >= maxOdd)
                {
                    maxOdd = currentNumber;
                    result = i.ToString();

                }
                else
                {
                    result = "No matches";
                }
            }
            return result;
        }

        private static string MaxEven(int[] numbers)
        {
            int maxEven = int.MinValue;
            string result = string.Empty;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];

                if (currentNumber % 2 == 0 && currentNumber >= maxEven)
                {
                    maxEven = currentNumber;
                    result = i.ToString();

                }
                else
                {
                    result = "No matches";
                }
            }
            return result;
        }

        private static int[] Exchange(int[] numbers, string[] arrManipulation)
        {
            int indexToSplit = int.Parse(arrManipulation[1]);
            int[] convertedArr = new int[numbers.Length];

            if (indexToSplit > (numbers.Length - 1) || indexToSplit < 0)
            {
                Console.WriteLine("Invalid index");
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < convertedArr.Length; j++)
                {
                    convertedArr[j] = numbers[i];
                }
            }
            return convertedArr;
        }
    }
}
