namespace Homework5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1:Ввести текст вручную\n" +
                "2:Прочитать текст из файла");

            switch (Console.ReadLine())
            {
                case "1":
                    ReadTextFromConsole();
                    break;
                case "2":
                    Console.WriteLine("Модуль еще не готов");
                    break;
                default:
                    Console.WriteLine("Нет такой операции");
                    break;
            }
        }

        static void ReadTextFromConsole()
        {
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();




            bool run = true;
            while (run)
            {
                Console.WriteLine($"Ваша строка {str}\n");
                Console.WriteLine("Что будем делать со строкой?");
                Console.WriteLine("1:Найти слова, содержащие максимальное количество цифр\n" +
                    "2:Найти самое длинное слово и определить, сколько раз оно встретилось в тексте\n" +
                    "3:Заменить цифры от 0 до 9 на слова «ноль», «один», ..., «девять»\n" +
                    "4:Вывести на экран сначала вопросительные, а затем восклицательные предложения\n" +
                    "5:Вывести на экран только предложения, не содержащие запятых\n" +
                    "6:Найти слова, начинающиеся и заканчивающиеся на одну и ту же букву\n" +
                    "0:Выход");

                switch (Console.ReadLine())
                {
                    case "0":
                        run = false; 
                        break;
                    case "1":
                        FindQuantityNumbers(str);
                        break;
                }
            }
        }

        //static async Task<> ReadTextFromFile()
        //{
        //    Console.WriteLine("Введите путь к файлу который нужно прочитать");
        //    string path = Console.ReadLine();
        //    path = path.Replace('\\', '/');
        //    path = path.Trim('"');

        //    using (StreamReader reader = new StreamReader(path))
        //    {
        //        string text = await reader.ReadToEndAsync();
        //    }
        //}

        static void FindQuantityNumbers(string str)
        {
            string[] internalStr = str.Split(' ');

            int result = 0;
            int index = 0;
            for (int i = 0; i < internalStr.Length; i++)
            {
                int countNumbers = 0;
                for (int j = 0; j < internalStr[i].Length; j++)
                {
                    if (char.IsNumber(internalStr[i][j]))
                    {
                        countNumbers++;
                    }
                    if (countNumbers > result)
                    {
                        result = countNumbers;
                        index = i;
                    }
                }
            }

            Console.Clear();
            Console.WriteLine($"Наибольшее колличество чисел в слове {internalStr[index]}\n");
        }
    }
}
