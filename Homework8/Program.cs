namespace Homework8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.SetName("Шарик");
            Console.WriteLine(dog.GetName());
            dog.Eat();
        }
    }
}
