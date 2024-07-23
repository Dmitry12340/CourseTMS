using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8.Figures
{
    public class Rectangle : Figure
    {
        private double _width;
        private double _height;
        public Rectangle(double Width, double Height)
        {
            _width = Width;
            _height = Height;
        }
        public override double FindArea()
        {
            return _width * _height;
        }

        public override double FindPerimeter()
        {
            return (_width + _height) * 2;
        }
    }
}
