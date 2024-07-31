namespace Homework12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        static bool Registration(string Login, string Password, string ConfirmPassword)
        {
            if (Login.Length > 20 || Login.Length < 3 || Login.Contains(' '))
            {
                throw new WrongLoginException();
            }
        }
    }
}
