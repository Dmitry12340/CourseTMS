using System.Runtime.Serialization;

namespace Lesson9
{
    [Serializable]
    public class Product 
    { 
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public void DisplayInfo()
        {
            Console.WriteLine($"Product: {Name}, Price: {Price}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(Product);
            var method = type.GetMethod("DisplayInfo");
            method.Invoke(new Product() { Id = 1, Name = "Salt", Price = 340}, null);

            var attributes = Attribute.IsDefined(type, typeof(SerializableAttribute));
            Console.WriteLine(attributes);
        }
    }
}
