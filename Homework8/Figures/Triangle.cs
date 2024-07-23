using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8.Figures
{
    public class Triangle : Figure
    {
        private double _side1;
        private double _side2;
        private double _side3;
        public Triangle(double Side1, double Side2, double Side3)
        {
            _side1 = Side1;
            _side2 = Side2;
            _side3 = Side3;
        }
        public override double FindArea()
        {
            double p = FindPerimeter() * 0.5;
            return Math.Sqrt(p * (p - _side1) * (p - _side2) * (p - _side3));
        }

        public override double FindPerimeter()
        {
            return _side1 + _side2 + _side3;
        }
    }
}
