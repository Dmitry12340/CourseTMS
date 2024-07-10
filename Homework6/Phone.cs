using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    public class Phone
    {
        public Phone()
        {

        }
        public Phone(string number, string model)
        {
            this.number = number;
            this.model = model;
        }
        public Phone(string number, string model, double weight) : this (number, model)
        {
            this.weight = weight;
        }

        string number;
        string model;
        double weight;

        public string Number { get { return number; } }
        public string Model { get { return model; } }
        public double Weight { get { return weight; } }

        public void ReceiveCall(string name)
        {
            Console.WriteLine($"Звонит {name}");
        }
        public void ReceiveCall(string name, string number)
        {
            Console.WriteLine($"Звонит {name} : {number}");
        }

        public string GetNumber()
        {
            return number;
        }
        public void SendMessage(string[] numbers)
        {
            for(int i  = 0; i < numbers.Length; i++)
            {
                for(int j = 0; j < numbers[i].Length; j++)
                {
                    Console.Write(numbers[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
