namespace Homework5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Введите путь к файлу который нужно прочитать");
            //string path = Console.ReadLine();
            //path = path.Replace('\\', '/');
            //for (int i = 0; i < path.Length; i++)
            //{
            //    if (path[i] == '"')
            //    {
            //        Console.WriteLine("Зашел");
            //        path.Remove(i, 1);
            //    }
            //}
            //Console.WriteLine(path);
            //Console.WriteLine("hbjhvb");

            //path = "C:/Users/kubte/OneDrive/Рабочий стол/Telegram.txt";
            //using (StreamReader reader = new StreamReader(path))
            //{
            //    string text = await reader.ReadToEndAsync();
            //    Console.WriteLine(text);
            //}

            string str = "\"gigiggkghk\"";
            for(int i = 0; i < args.Length; i++)
            {
                if (str[i] == '\"')
                {
                    str.Remove(i, 1);
                }
            }
            Console.WriteLine(str);
            str = str.Remove(0, 1);
            Console.WriteLine(str);
        }
    }
}
