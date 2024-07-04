namespace Homework4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sizeMatrix;
            Console.WriteLine("Создаем матрицу");
            Console.WriteLine("Введите колличество массивов в матрице");
            bool correctSizeArray = int.TryParse(Console.ReadLine(), out sizeMatrix);

            if (correctSizeArray)
            {
                int[][] myArray = new int[sizeMatrix][];
                for (int i = 0; i < sizeMatrix; i++)
                {
                    Console.WriteLine($"Введите размер {i + 1} массива");
                    int input;
                    bool correctInput = int.TryParse(Console.ReadLine(), out input);
                    if (correctInput)
                    {
                        myArray[i] = new int[input];
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели что-то не то");
                    }
                }


                Console.WriteLine("Заполним массивы значениями");

                for (int i = 0; i < myArray.Length; i++)
                {
                    for (int j = 0; j < myArray[i].Length; j++)
                    {
                        Console.WriteLine($"Введите значение {j + 1} элемента, {i + 1} массива");
                        int input;
                        bool correctInput = int.TryParse(Console.ReadLine(), out input);
                        if (correctInput)
                        {
                            myArray[i][j] = input;
                        }
                        else
                        {
                            Console.WriteLine("Вы ввели что-то не то");
                        }
                    }
                }

                Console.Clear();
                Console.WriteLine("Вот ваша матрица");

                foreach (int[] array in myArray)
                {
                    foreach (int input in array)
                    {
                        Console.Write($"{input} ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Вы ввели что-то не то");
            }
        }

        static void Examples()
        {
            //Список
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i]);
            }

            Console.WriteLine();

            list.Remove(1);
            foreach (int i in list)
            {
                Console.Write(i);
            }

            Console.WriteLine();

            //Словарь
            Dictionary<int, string> month = new Dictionary<int, string>();
            month.Add(1, "Январь");
            month.Add(2, "Февраль");
            month.Add(3, "Март");

            foreach (var i in month)
            {
                Console.WriteLine(i.Key);
                Console.WriteLine(i.Value);
            }

            Console.WriteLine();

            //Стек
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine(stack.Pop());

            foreach (var i in stack)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            //Очередь
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Console.WriteLine(queue.Dequeue());
            foreach (var i in queue)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            var filePermission = FileAccess.Write | FileAccess.Read;
            var canRead = (filePermission & FileAccess.Read) == FileAccess.Read;
        }

        //Перечисление
        enum DayOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        //Битовые флаги
        [Flags]
        enum FileAccess
        {
            Read = 1,    //0001
            Write = 2,   //0010
            Execute = 4, //0100
            Delete = 8,  //1000
        }
    }
}
