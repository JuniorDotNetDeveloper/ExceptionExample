using FunWithException.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace FunWithException.Models
{
    internal class RangeArray : IEnumerable
    {
        private int[] intArray;
        private int bottomEdge;
        private int topEdge;
        private int length;

        public RangeArray(int bottom, int top)
        {
            top++;
            if (top < bottom)
            {
                throw new CustomRangeArrayException("bottom index is higher than top");
            }

            length = top - bottom;
            intArray = new int[length];
            bottomEdge = bottom;
            topEdge = --top;
        }

        public int Length { get { return length; } }
        public int LengthForLoop { get { return topEdge + 1; } }
        public int this[int index]
        {
            get
            {
                if (index <= topEdge & index >= bottomEdge)
                    return intArray[index - bottomEdge];
                throw new CustomRangeArrayException("out of range exception");
            }
            set
            {
                if (index <= topEdge & index >= bottomEdge)
                    intArray[index - bottomEdge] = value;
                else throw new CustomRangeArrayException("out of range exception");
            }
        }

        public IEnumerator GetEnumerator()
        {
            return intArray.GetEnumerator();
        }
    }
}
