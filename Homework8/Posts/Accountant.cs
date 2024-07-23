using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8.Posts
{
    internal class Accountant : IPrintPost
    {
        public void Print()
        {
            Console.WriteLine($"Печать: Бухгалтер");
        }
    }
}
