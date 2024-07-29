using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9.Cars
{
    internal class Truck : Car
    {
        public Truck(int fuel) : base(fuel)
        {
        }
        public override void Drive()
        {
            if (fuel > 0)
            {
                Console.WriteLine("Truck движется");
            }
            else
            {
                Console.WriteLine("Truck не заправлен");
            }
        }
    }
}
