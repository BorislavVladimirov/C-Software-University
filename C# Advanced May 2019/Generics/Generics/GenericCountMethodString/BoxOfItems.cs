using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCountMethodString
{
    public class BoxOfItems<T>
        where  T : IComparable<T>
    {
        List<T> list;

        public BoxOfItems()
        {
            this.list = new List<T>();
        }

        public void Add(T item)
        {
            this.list.Add(item);
        }

        public int Compare(T element)
        {
            int count = 0;

            foreach (var item in this.list)
            {
                if (item.CompareTo(element) > 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
