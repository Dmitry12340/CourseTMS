
using static System.Net.Mime.MediaTypeNames;

namespace Homework5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1:Ввести вручную\n" +
                "2:Прочитать текст из файла");

            string text;
            switch (Console.ReadLine())
            {
                case "1":
                    ReadTextFromConsole();
                    break;
                case "2":
                    Task successfulRead = ReadTextFromFile();
                    break;
                default:
                    Console.WriteLine("Нет такой операции");
                    break;
            }
        }

        static void ReadTextFromConsole()
        {
            
        }

        static async Task<bool> ReadTextFromFile()
        {
            Console.WriteLine("Введите путь к файлу который нужно прочитать");
            string path = Console.ReadLine();
            path = path.Replace('\\', '/');
            path = path.Trim('"');

            using (StreamReader reader = new StreamReader(path))
            {
                try
                {
                    string text = await reader.ReadToEndAsync();
                    return true;
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Нет файла по этому пути!");
                    return false;
                }
            }
        }
    }
}
