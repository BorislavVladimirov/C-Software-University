using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    public class CustomStack
    {
        /// <summary>
        /// Default size of internal array
        /// </summary>
        private const int defaultSize = 2;

        /// <summary>
        /// Internal array
        /// </summary>
        private int[] innerArr;

        /// <summary>
        /// Number of elements int he list 
        /// </summary>
        public int Count { get; private set; } = 0;

        /// <summary>
        /// Creates custom integer list with defaut size
        /// </summary>
        public CustomStack()
        {
            innerArr = new int[defaultSize];
        }

        /// <summary>
        /// Creates custom integer list with defaut size
        /// </summary>
        /// <param name="initialSize">Initial size of the list </param>


    }
}
