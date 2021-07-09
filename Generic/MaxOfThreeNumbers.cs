using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class MaxOfThreeNumbers<T> where T : IComparable
    {
        public T[] array;
        public MaxOfThreeNumbers(T[] array)
        {
            this.array = array;
        }
        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return array;
        }
        public T FindingMaxValue(T[] value)
        {
            T[] sorted = this.Sort(value);
            return sorted[sorted.Length - 1];
        }
        public T MaxValue()
        {
            T max = FindingMaxValue(this.array);
            return max;
        }
    }
}
