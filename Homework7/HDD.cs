namespace Homework7
{
    public class HDD
    {
        public string name;
        public decimal capacity;
        public string type;
        public HDD()
        {
            name = "Unknown name";
            capacity = 0;
            type = "Unknown type";
        }
        public HDD(string name, decimal capacity, string type)
        {
            this.name = name;
            this.capacity = capacity;
            this.type = type;
        }

        public void ShowParameters()
        {
            Console.WriteLine($"HDD:\n" +
                $"Name:{name}\n" +
                $"Capacity:{capacity}\n" +
                $"Type:{type}\n");
        }
    }
}