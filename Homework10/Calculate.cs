using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10
{
    public class Calculate
    {
        private double number1;
        private double number2;
        private double result;
        public double Result { get { return result; } }

        public event Action<object> Addition;
        public event Action<object> Subtraction;
        public event Action<object> Multiplication;
        public event Action<object> Division;
        public event Action InvalidOperation;
        public Calculate()
        {
            number1 = 0;
            number2 = 0;
        }

        public void Calculation(string operation, double number1, double number2)
        {
            this.number1 = number1;
            this.number2 = number2;

            switch (operation)
            {
                case "+":
                    if (Addition != null)
                    {
                        Addition(this);
                    }
                    break;
                case "-":
                    if (Subtraction != null)
                    {
                        Subtraction(this);
                    }
                    break;
                case "*":
                    if (Multiplication != null)
                    {
                        Multiplication(this);
                    }
                    break;
                case "/":
                    if (Division != null)
                    {
                        Division(this);
                    }
                    break;
                default:
                    if (Addition != null)
                    {
                        InvalidOperation();
                    }
                    break;
            }
        }
        public void Add()
        {
            result = number1 + number2;
        }
        public void Sub()
        {
            result = number1 - number2;
        }
        public void Multi()
        {
            result = number1 * number2;
        }
        public void Divide()
        {
            result = number1 / number2;
        }
    }
}
