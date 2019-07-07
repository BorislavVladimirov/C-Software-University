using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomStack
{
    public class MyStack<T> : IEnumerable<T>
    {
        private readonly List<T> myList;

        public MyStack()
        {
            this.myList = new List<T>();
        }

        public void Push(T element)
        {
            myList.Add(element);
        }

        public T Pop()
        {
            if (myList.Count == 0)
            {
                throw new Exception("No elements");
            }

            T element = myList.LastOrDefault();

            myList.RemoveAt(myList.Count - 1);

            return element;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var element in this.myList)
            {
                yield return element;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
            => this.GetEnumerator();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int r = 0; r < 2; r++)
            {
                for (int i = myList.Count() - 1; i >= 0; i--)
                {
                  sb.AppendLine(myList[i].ToString());
                }
            }

            return sb.ToString().Trim();
        }
    }
}
