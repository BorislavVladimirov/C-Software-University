using System;
using Telephony.Models;

namespace Telephony
{
    public class StartUp
    {
        public static void Main(string[] args)
        {            
            string phoneNumber = Console.ReadLine();
            string adress = Console.ReadLine();

            Smartphone smartphone = new Smartphone();

            foreach (var phone in phoneNumber.Split())
            {
                try
                {
                    Console.WriteLine(smartphone.Call(phone));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            foreach (var url in adress.Split())
            {
                try
                {
                    Console.WriteLine(smartphone.Browse(url));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
