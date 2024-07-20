using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    internal class Worker : IPrintPost
    {
        public void Print()
        {
            Console.WriteLine($"Печать: Рабочий");
        }
    }
}
