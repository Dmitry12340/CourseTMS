using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework11
{
    public class ComparablePair<T, U> : IComparable<ComparablePair<T, U>>
        where T : IComparable<T>
        where U : IComparable<U>
    {
        public T First { get; }
        public U Second { get; }
        public ComparablePair(T first, U second)
        {
            First = first;
            Second = second;
        }
        public int CompareTo(ComparablePair<T, U>? other)
        {
            if (other == null)
            {
                return 1;
            }

            int firstComparison = First.CompareTo(other.First);
            if(firstComparison != 0)
            {
                return firstComparison;
            }

            return Second.CompareTo(other.Second);
        }
    }
}
