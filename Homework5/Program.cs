namespace Homework5
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Введите путь к файлу который нужно прочитать");
            string path = Console.ReadLine();
            path = path.Replace('\\', '/');
            path = path.Trim('"');

            using (StreamReader reader = new StreamReader(path))
            {
                string text = await reader.ReadToEndAsync();
                Console.WriteLine(text);
            }
        }
    }
}
