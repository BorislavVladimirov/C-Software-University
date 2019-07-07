using System;
using System.Collections.Generic;
using System.Text;

namespace TupleTask
{
    public class CustomTuple<T,R, V>
    {
        public CustomTuple(T value1, R value2, V value3)
        {
            this.Value1 = value1;
            this.Value2 = value2;
            this.Value3 = value3;
        }

        public T Value1 { get; set; }

        public R Value2 { get; set; }

        public V Value3 { get; set; }

        public override string ToString()
        {
            return $"{this.Value1} -> {this.Value2} -> {this.Value3}";
        }
    }
}
