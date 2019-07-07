using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Froggy
{
    public class Lake<T> : IEnumerable<T>
    {
        private T[] stones;

        public Lake(T[] numbers)
        {
            this.stones = numbers;
        }

        public void Jump()
        {
            List<T> temp = new List<T>();

            for (int i = 0; i < stones.Length; i++)
            {
                if (i % 2 == 0)
                {
                    temp.Add(stones[i]);
                }
            }

            for (int i = stones.Length - 1; i >= 0; i--)
            {
                if (i % 2 != 0)
                {
                    temp.Add(stones[i]);
                }
            }

            Console.WriteLine(string.Join(", ", temp));
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
