using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    public class Computer
    {
        decimal price;
        string model;
        Ram ram;
        HDD hdd;
        public Computer(decimal price, string model)
        {
            this.price = price;
            this.model = model;
            ram = new Ram();
            hdd = new HDD();
        }

        public Computer(decimal price, string model, Ram ram, HDD hdd) : this(price, model)
        {
            this.ram = ram;
            this.hdd = hdd;
        }

        public void ShowParameters()
        {
            Console.WriteLine($"Computer:\n" +
                $"Model:{model}\n" +
                $"Price:{price}\n" +
                $"Ram name:{ram.name}\n" +
                $"Ram capacity:{ram.capacity}\n" +
                $"HDD name:{hdd.name}\n" +
                $"HDD capacity:{hdd.capacity}\n" +
                $"HDD type:{hdd.type}\n");
        }
    }
}
