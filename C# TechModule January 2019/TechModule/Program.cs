using System;
using System.Linq;

namespace TechModule
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[20];

            //записване на стойност на дадена клетка
            numbers[13] = 100;
            numbers[19] = 2312;
            numbers[0] = 5;

            // взимане на стойност от клетка
            int firstNumber = numbers[13];
            int secondNumber = numbers[19];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i;
            }
            //директно пълнене на масива със стойности
            int[] number = { 1, 2, 3, 4, 5 };

            //четене на стринг и разделянето му
            // 2 8 30 25 40 72 -2 44 56
            int[] numBers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            // 2,8,30!,25,40!,72,-2,44,56
            //когато имаме сивмоли във входните данни и четем интове
            int[] nums = Console.ReadLine()
                .Split(new char[] { '!', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            //double масив към int масив 
            double[] realNumbers = { 1.2, 3.4, 5.6 };
            int nummm = (int)realNumbers[1];

            //foreach loop
            int[] num1 = { 1, 2, 3, 4, 5 };
            foreach (var item in num1)
            {
                Console.WriteLine(item);
            }

            //принтиране на масив
            int[] arr = { 10, 20, 30, 40, 50 };

            for (int i = 0; i < arr.Length; i++)

                Console.WriteLine(arr[i]);


            //принтиране на масив с join
            int[] array = { 1, 2, 3 };

            Console.WriteLine(string.Join(", ", arr)); // 1, 2, 3

            string[] strings = { "one", "two" };

            Console.WriteLine(string.Join(" - ", strings)); //Enviroment.NewLine - за нов ред в принтирането.



            int[] something = { 1, 2, 3, 4, };


            int[] other = something;

            other[1] = 4;

            int[] hapy = other;

            hapy[0] = 7;

            Console.WriteLine(string.Join(" ", something));
            Console.WriteLine(string.Join(" ", other));
            Console.WriteLine(string.Join(" ", hapy));

            
        }
    }
}
