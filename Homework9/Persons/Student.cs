using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9.Persons
{
    internal class Student : Person
    {
        public Student(int age, string name) : base(age, name)
        {

        }
        public void Study()
        {
            Console.WriteLine("Я учусь");
        }
        public void ShowAge()
        {
            Console.WriteLine($"Мой возраст: {age} лет");
        }
    }
}
