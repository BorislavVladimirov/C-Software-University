using System;

namespace CustomStructures
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var list = new CustomList<int>();

            list.Add(7);
            list.Add(12);
            list.Add(23);
            list.AddRange(new int[] { 1, 2, 3, 546, 76, 3245, 7, 3222 });
            list.RemoveAt(3);
            list.InsertAt(1255, 90);
            list.InsertAt(4, 8);
            list.Swap(0, 8);

            list.ForEach(Console.Write);
                       
        }
    }
}
