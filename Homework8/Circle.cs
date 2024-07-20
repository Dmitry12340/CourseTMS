using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    public class Circle : Figure
    {
        private double _radius;
        public Circle(double Radius)
        {
            _radius = Radius;
        }
        public override double FindArea()
        {
            return Math.PI * (_radius * _radius);
        }

        public override double FindPerimeter()
        {
            throw new NotImplementedException();
        }
    }
}
