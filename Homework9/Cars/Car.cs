using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9.Cars
{
    internal class Car
    {
        protected int fuel;
        public Car(int fuel)
        {
            this.fuel = fuel;
        }
        public virtual void Drive()
        {
            if(fuel > 0)
            {
                Console.WriteLine("Автомобиль движется");
            }
            else
            {
                Console.WriteLine("Автомобиль не заправлен");
            }
        }
        public virtual bool Refuel(int fuel)
        {
            if (fuel > 0)
            {
                this.fuel += fuel;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
