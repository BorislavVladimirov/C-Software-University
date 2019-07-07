using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _1ListyIterator
{
    public class ListyIterator<T> : IEnumerable
    {
        private List<T> elements;
        private int index;

        public ListyIterator()
        {
            this.elements = new List<T>();
            this.index = 0;
        }

        public void Create(T[] elements)
        {
            this.elements.AddRange(elements);
        }

        public bool Move()
        {
            index++;

            if (index <= elements.Count - 1)
            {
                return true;
            }

            index--;

            return false;
        }

        public void Print()
        {
            if (elements.Count == 0)
            {
                throw new ArgumentException("Invalid Operation!");
            }

            Console.WriteLine(this.elements[index]);
        }

        public bool HasNext()
        {
            if (index < elements.Count - 1)
            {
                return true;
            }

            return false;
        }

        //public string PrintAll()
        //{
        //    if (elements.Count == 0)
        //    {
        //        throw new ArgumentException("Invalid Operation!");
        //    }

        //    foreach (var item in this.elements)
        //    {
        //        yield return $"{item}";
        //    }
        //}


        public IEnumerator<T> GetEnumerator()
        {
            foreach (var element in this.elements)
            {
                yield return element;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
            => this.GetEnumerator();
    }
}
