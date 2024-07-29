using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9.Persons
{
    internal class Teacher : Person
    {
        public Teacher(int age, string name) : base(age, name)
        {

        }
        public void Explain()
        {
            Console.WriteLine("Я объясняю");
        }
    }
}
