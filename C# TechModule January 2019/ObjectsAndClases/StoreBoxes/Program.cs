using System;
using System.Collections.Generic;

namespace StoreBoxes
{
    class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
    class Box
    {
        public Box()
        {
            Item = new Item();
        }
        public int SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public decimal PriceForABox { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            string inputData = Console.ReadLine();

            List<Box> boxes = new List<Box>();
            List<Item> items = new List<Item>();

            while (inputData != "end")
            {
                string[] input = inputData.Split();

                int serialNumber = int.Parse(input[0]);
                string item = input[1];
                int itemQuality = int.Parse(input[2]);
                decimal itemPrice = decimal.Parse(input[3]);

                Box box = new Box()
                {
                    
                };


                inputData = Console.ReadLine();
            }
            foreach (Box box in boxes)
            {
                Console.WriteLine($"{box.SerialNumber} -- {box.Item} – $: {box.ItemQuantity}-- ${box.PriceForABox}");
            }
        }
    }
}
