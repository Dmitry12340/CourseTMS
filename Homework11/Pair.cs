using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework11
{
    internal class Pair<S,T>
    {
        public S value1;
        public T value2;
        public Pair(S value1, T value2)
        {
            this.value1 = value1;
            this.value2 = value2;
        }
    }
}
