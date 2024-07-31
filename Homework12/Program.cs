namespace Homework12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите Login");
                string Login = Console.ReadLine();

                Console.WriteLine("Введите Password");
                string Password = Console.ReadLine();

                Console.WriteLine("Введите ConfirmPassword");
                string ConfirmPassword = Console.ReadLine();

                bool result = false;

                try
                {
                    result = User.Registration(Login, Password, ConfirmPassword);
                }
                catch (WrongLoginException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine(e.StackTrace);
                }
                catch (WrongPasswordException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine(e.StackTrace);
                }

                Console.WriteLine();
                Console.WriteLine($"Результат операции = {result}");

                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
