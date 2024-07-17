namespace Homework7
{
    public class Ram
    {
        public string name;
        public decimal capacity;
        public Ram()
        {
            name = "Unknown name";
            capacity = 0;
        }
        public Ram(string name, decimal capacity)
        {
            this.name = name;
            this.capacity = capacity;
        }

        public void ShowParameters()
        {
            Console.WriteLine($"Ram:\n" +
                $"Name:{name}\n" +
                $"Capacity:{capacity}\n");
        }
    }
}