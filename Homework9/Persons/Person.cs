using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9.Persons
{
    internal class Person
    {
        protected int age;
        protected string name;
        public Person(int age, string name)
        {
            this.age = age;
            this.name = name;
        }
        public void Greet()
        {
            Console.WriteLine($"Привет, меня зовут {name}");
        }
        public void SetAge(int age)
        {
            if (age < 0)
            {
                this.age = age;
            }
        }
    }
}
