using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9.Persons
{
    internal class StudentProfessorTest
    {
        static void Main()
        {
            Person person = new Person(name: "Человек", age: 40);
            person.Greet();

            Console.WriteLine();

            Student student = new Student(18, "Настя");
            student.Greet();
            student.ShowAge();

            Console.WriteLine();

            Teacher teacher = new Teacher(35, "Пётр");
            teacher.Greet();
            teacher.Explain();
        }
    }
}
