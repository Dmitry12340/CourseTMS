namespace Homework11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 задание
            Pair<string, int> pair = new Pair<string, int>("Hello", 12);
            Console.WriteLine($"S = {pair.value1}, T = {pair.value2}");
            Console.ReadLine();

            //2 задание
            ComparablePair<int, string> pair1 = new ComparablePair<int, string>(18, "Дмитрий");
            ComparablePair<int, string> pair2 = new ComparablePair<int, string>(6, "Евгений");
            ComparablePair<int, string> pair3 = new ComparablePair<int, string>(10, "Александр");

            ComparablePair<int, string>[] pairs = new ComparablePair<int, string>[] {pair1, pair2, pair3};

            Array.Sort(pairs);//Теперь нам доступна сортировка

            foreach (var p in pairs)
            {
                Console.WriteLine($"{p.First} - {p.Second}");
            }
            Console.WriteLine();

            //Если текущий объект меньше передоваемого то возвращается -1
            //Если текущий объект больше передоваемого то возвращается 1
            //Если объекты равны то возвращается 0
            Console.WriteLine($"Результат сравнения pair1 и pair2 = {pair1.CompareTo(pair2)}");
            Console.WriteLine($"Результат сравнения pair1 и pair3 = {pair1.CompareTo(pair3)}");
            Console.WriteLine($"Результат сравнения pair2 и pair3 = {pair2.CompareTo(pair3)}");
        }
    }
}
