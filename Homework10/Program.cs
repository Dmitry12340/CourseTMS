namespace Homework10
{
    public class Program
    {
        static void Main(string[] args)
        {
            Calculate calculate = new Calculate();

            calculate.Addition += Calculate_Addition;
            calculate.Subtraction += Calculate_Subtraction;
            calculate.Multiplication += Calculate_Multiplication;
            calculate.Division += Calculate_Division;
            calculate.InvalidOperation += Calculate_InvalidOperation;

            double number1 = 0;
            double number2 = 0;

            while (true)
            {
                Console.WriteLine("Введите первое число");
                bool correctNumber1 = double.TryParse(Console.ReadLine(), out number1);

                Console.WriteLine("Введите второе число");
                bool correctNumber2 = double.TryParse(Console.ReadLine(), out number2);

                if (correctNumber1 && correctNumber2)
                {
                    Console.WriteLine("Введите операцию");
                    string typeOperation = Console.ReadLine();

                    calculate.Calculation(typeOperation, number1, number2);
                }
                else
                {
                    Console.WriteLine("Вы ввели неправильное значение");
                }

                Console.ReadLine();
                Console.Clear();
            }
        }

        private static void Calculate_Division(object obj)
        {
            var calculate = (Calculate)obj;
            calculate.Divide();
            Console.WriteLine($"Division: Result = {calculate.Result}");
        }

        private static void Calculate_Multiplication(object obj)
        {
            var calculate = (Calculate)obj;
            calculate.Multi();
            Console.WriteLine($"Multiplication: Result = {calculate.Result}");
        }

        private static void Calculate_Subtraction(object obj)
        {
            var calculate = (Calculate)obj;
            calculate.Sub();
            Console.WriteLine($"Subtraction: Result = {calculate.Result}");
        }

        private static void Calculate_Addition(object obj)
        {
            var calculate = (Calculate)obj;
            calculate.Add();
            Console.WriteLine($"Addition: Result = {calculate.Result}");
        }

        private static void Calculate_InvalidOperation()
        {
            Console.WriteLine("Invalid Operation");
        }
    }
}
