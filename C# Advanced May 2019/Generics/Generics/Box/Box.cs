using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoxOfT
{
    public class Box<T>
    {
        private List<T> boxItems;

        public Box()
        {
            boxItems = new List<T>();
        }

        public int Count
        {
            get
            {
                return this.boxItems.Count; ;
            }
        }

        public void Add(T element)
        {
            this.boxItems.Add(element);
        }

        public T Remove()
        {
            var element = boxItems.Last();

            this.boxItems.RemoveAt(Count - 1);
            return element;
        }
    }
}
