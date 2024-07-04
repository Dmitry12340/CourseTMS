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

                Console.WriteLine("Хотите выполнить какие-нибудь действия с матрицой?");
            }
            else
            {
                Console.WriteLine("Вы ввели что-то не то");
            }
        }
    }
}
