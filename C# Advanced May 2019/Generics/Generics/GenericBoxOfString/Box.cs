using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBoxOfString
{
    public class Box<T>
    {
        private T value;
        private T type;

        public Box(T input)
        {
            this.Value = input;
        }

        public T Value { get; set; }

        public override string ToString()
        {
            return $"{Value.GetType().FullName}: {this.Value}";
        }
    }
}
