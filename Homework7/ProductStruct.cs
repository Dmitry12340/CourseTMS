using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    public struct ProductStruct
    {
        int id;
        string name;
        decimal price;
        int quantity;

        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public decimal Price
        {
            get { return price; }
            set
            {
                if (value <= 0)
                {
                    price = 1;
                }
                else
                {
                    price = value;
                }
            }
        }
        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (value < 0)
                {
                    quantity = 0;
                }
                else
                {
                    quantity = value;
                }
            }
        }

        public ProductStruct(string name, decimal price)
        {
            Id = 1;
            Name = name;
            Price = price;
            Quantity = 1;
        }
        public ProductStruct(string name, int quantity)
        {
            Id = 1;
            Name = name;
            Price = 1;
            Quantity = quantity;
        }
        public ProductStruct(string name, decimal price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
        public ProductStruct(string name, int id, decimal price, int quantity) : this(name, price, quantity)
        {
            Id = id;
        }
    }
}
