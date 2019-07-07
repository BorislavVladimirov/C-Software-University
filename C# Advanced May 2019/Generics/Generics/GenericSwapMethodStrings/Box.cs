using System;
using System.Collections.Generic;
using System.Text;

namespace GenericSwapMethodStrings
{
    public class Box<T>
    {
        List<T> texts;
        public Box()
        {
            texts = new List<T>();
        }

        public void Add(T item)
        {
            this.texts.Add(item);
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            T temp = texts[firstIndex];

            this.texts[firstIndex] = this.texts[secondIndex];
            this.texts[secondIndex] = temp;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in texts)
            {
                sb.AppendLine($"{item.GetType().FullName}: {item}");
            }

            return sb.ToString();
        }
    }
}
