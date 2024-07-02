namespace Homework3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            int number1 = 0;
            int number2 = 0;

            while (true)
            {
                Console.WriteLine("Введите первое число");
                bool correctNumber1 = int.TryParse(Console.ReadLine(), out number1);

                Console.WriteLine("Введите второе число");
                bool correctNumber2 = int.TryParse(Console.ReadLine(), out number2);


                if (correctNumber1 && correctNumber2)
                {
                    Console.WriteLine("Введите операцию");
                    string typeOperation = Console.ReadLine();

                    switch (typeOperation)
                    {
                        case "+":
                            result = number1 + number2;
                            break;
                        case "-":
                            result = number1 - number2;
                            break;
                        case "*":
                            result = number1 * number2;
                            break;
                        case "/":
                            result = number1 / number2;
                            break;
                        case "%":
                            result = number1 % number2;
                            break;
                        default:
                            Console.WriteLine("Вы ввели неправильную операция");
                            break;
                    }

                    Console.Clear();
                    Console.WriteLine("Результат = " + result);
                }
                else
                {
                    Console.WriteLine("Вы ввели неправильное значение");
                }
            }
        }
    }
}
