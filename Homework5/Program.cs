using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

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
                    case "2":
                        FindLongestWord(str);
                        break;
                    case "3":
                        ReplaceNumbersWithWords(str);
                        break;
                    case "4":
                        ShowInterrogativeExclamationSentences(str);
                        break;
                    case "5":
                        ShowSentencesNoComma(str);
                        break;
                    case "6":
                        ShowStartEqualEnd(str);
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

        static void FindLongestWord(string str)
        {
            string[] internalStr = str.Split(' ');
            int index = 0;

            //Ищем самое длинное слово
            for (int i = 0; i < internalStr.Length; i++)
            {
                if (internalStr[i].Length > internalStr[index].Length)
                {
                    index = i;
                }
            }

            int count = 0;
            //Ишем сколько раз повторяется самое длинное слово
            for (int i = 0; i < internalStr.Length; i++)
            {
                if (internalStr[i] == internalStr[index])
                {
                    count++;
                }
            }

            Console.Clear();
            Console.WriteLine($"Самое длинное слово {internalStr[index]}\n" +
                $"Оно повторяется {count} раз\n");
        }

        static void ReplaceNumbersWithWords(string str)
        {
            StringBuilder stringBuilder = new StringBuilder(str);
            stringBuilder.Replace("0", "Ноль");
            stringBuilder.Replace("1", "Один");
            stringBuilder.Replace("2", "Два");
            stringBuilder.Replace("3", "Три");
            stringBuilder.Replace("4", "Четыре");
            stringBuilder.Replace("5", "Пять");
            stringBuilder.Replace("6", "Шесть");
            stringBuilder.Replace("7", "Семь");
            stringBuilder.Replace("8", "Восемь");
            stringBuilder.Replace("9", "Девять");

            Console.Clear();
            str = stringBuilder.ToString();
            Console.WriteLine($"Результат: {str}\n");
        }

        static void ShowInterrogativeExclamationSentences(string str)
        {
            Console.Clear();
            //char[] separator = {'.', '!', '?'};
            string[] internalStr = Regex.Split(str, @"(?<=[\.!\?])\s+");

            Console.Write("Вопросительные предложения: ");
            for (int i = 0; i < internalStr.Length; i++)
            {
                if (internalStr[i].Contains('?'))
                {
                    Console.Write(internalStr[i] + " ");
                }
            }
            Console.WriteLine("\n");

            Console.Write("Восклицательные предложения: ");
            for (int i = 0; i < internalStr.Length; i++)
            {
                if (internalStr[i].Contains('!'))
                {
                    Console.Write(internalStr[i] + " ");
                }
            }
            Console.WriteLine("\n");
        }

        static void ShowSentencesNoComma(string str)
        {
            Console.Clear();
            string[] internalStr = Regex.Split(str, @"(?<=[\.!\?])\s+");

            Console.Write("Предложения без запятой: ");
            for (int i = 0; i < internalStr.Length; i++)
            {
                if (!internalStr[i].Contains(','))
                {
                    Console.Write(internalStr[i] + " ");
                }
            }
            Console.WriteLine("\n");
        }

        static void ShowStartEqualEnd(string str)
        {
            Console.Clear();
            string[] internalStr = str.Split(' ');

            Console.WriteLine("Слова начинающиеся и заканчивающиеся на одну и ту же букву:");
            for (int i = 0; i < internalStr.Length; i++)
            {
                if (char.ToLower(internalStr[i][0]) == char.ToLower(internalStr[i][internalStr[i].Length - 1]))
                {
                    Console.Write(internalStr[i] + " ");
                }
            }
            Console.WriteLine("\n");
        }
    }
}
