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

                bool run = true;
                while (run)
                {
                    Console.WriteLine();
                    Console.WriteLine("Вот ваша матрица");

                    foreach (int[] array in myArray)
                    {
                        foreach (int input in array)
                        {
                            Console.Write($"{input} ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();


                    Console.WriteLine("Хотите выполнить какие-нибудь действия с матрицой?");


                    Console.WriteLine("1:Найти количество положительных чисел\n" +
                    "2:Найти количество отрицательных чисел\n" +
                    "3:Отсортировать елементы в матрице\n" +
                    "4:Инверсия матрицы\n" +
                    "0:Выход");

                    string action = Console.ReadLine();
                    switch (action)
                    {
                        case "1":
                            FindPositiveNumbers(myArray);
                            break;
                        case "2":
                            FindNegativeNumbers(myArray);
                            break;
                        case "3":
                            Sorting(myArray);
                            break;
                        case "4":
                            Inversion(myArray);
                            break;
                        case "0":
                            run = false;
                            break;
                        default:
                            Console.WriteLine("Нет такой операции");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Вы ввели что-то не то");
            }
        }

        static void FindPositiveNumbers(int[][] Array)
        {
            Console.WriteLine("Введите номер массива в котором нужно найти колличество положительных чисел");
            bool correctAnswer = int.TryParse(Console.ReadLine(), out int answer);

            int result = 0;

            if (correctAnswer)
            {
                if (answer <= Array.Length)
                {
                    for (int i = 0; i < Array[answer - 1].Length; i++)
                    {
                        if (Array[answer - 1][i] > 0)
                        {
                            result++;
                        }
                    }
                    Console.WriteLine("Колличество положительных чисел = " + result);
                }
                else
                {
                    Console.WriteLine("Нет такого массива");
                }
            }
            else
            {
                Console.WriteLine("Вы ввели что-то не то");
            }
        }

        static void FindNegativeNumbers(int[][] Array)
        {
            Console.WriteLine("Введите номер массива в котором нужно найти колличество отрицательных чисел");
            bool correctAnswer = int.TryParse(Console.ReadLine(), out int answer);

            int result = 0;

            if (correctAnswer)
            {
                if (answer <= Array.Length)
                {
                    for (int i = 0; i < Array[answer - 1].Length; i++)
                    {
                        if (Array[answer - 1][i] < 0)
                        {
                            result++;
                        }
                    }
                    Console.WriteLine("Колличество отрицательных чисел = " + result);
                }
                else
                {
                    Console.WriteLine("Нет такого массива");
                }
            }
            else
            {
                Console.WriteLine("Вы ввели что-то не то");
            }
        }

        static void Sorting(int[][] Array)
        {
            Console.WriteLine("Введите номер массива который нужно отсортировать");
            bool correctAnswer = int.TryParse(Console.ReadLine(), out int answer);

            if (correctAnswer)
            {
                if (answer <= Array.Length)
                {
                    for (int i = 0; i < Array[answer - 1].Length; i++)
                    {
                        for (int j = 0; j < Array[answer - 1].Length - 1; j++)
                        {
                            int iter = 0;
                            if (Array[answer - 1][j] > Array[answer - 1][j + 1])
                            {
                                iter = Array[answer - 1][j];
                                Array[answer - 1][j] = Array[answer - 1][j + 1];
                                Array[answer - 1][j + 1] = iter;
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Нет такого массива");
                }
            }
            else
            {
                Console.WriteLine("Вы ввели что-то не то");
            }
        }

        static void Inversion(int[][] Array)
        {
            Console.WriteLine("Введите номер массива в котором инверсию");
            bool correctAnswer = int.TryParse(Console.ReadLine(), out int answer);

            if (correctAnswer)
            {
                if (answer <= Array.Length)
                {
                    for (int i = 0; i < Array[answer - 1].Length; i++)
                    {
                        int iter = 0;
                        if (i < Array[answer - 1].Length / 2)
                        {
                            iter = Array[answer - 1][i];
                            Array[answer - 1][i] = Array[answer - 1][Array[answer - 1].Length - 1 - i];
                            Array[answer - 1][Array[answer - 1].Length - 1 - i] = iter;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Нет такого массива");
                }
            }
            else
            {
                Console.WriteLine("Вы ввели что-то не то");
            }
        }
    }
}
