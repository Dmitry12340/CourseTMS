using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework13
{
    internal class SomeClass
    {
        private int _id;
        private string _name;
        private int _age;

        public int Id { get { return _id; } }
        public string Name { get { return _name; } }
        public int Age { get { return _age; } }
        public SomeClass(int id, string name, int age)
        {
            _id = id;
            _name = name;
            _age = age;
        }
    }
}
