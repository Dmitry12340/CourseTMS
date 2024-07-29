using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9.Cars
{
    internal class SportsCar : Car
    {
        public SportsCar(int fuel) : base(fuel)
        {
        }
        public override void Drive()
        {
            if (fuel > 0)
            {
                Console.WriteLine("SportsCar движется");
            }
            else
            {
                Console.WriteLine("SportsCar не заправлен");
            }
        }
    }
}
