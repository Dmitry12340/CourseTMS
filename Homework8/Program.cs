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

            Console.ReadKey();

            Triangle triangle = new Triangle(20.5, 20.3, 20.1);
            Console.WriteLine(triangle.FindArea());
            Console.WriteLine(triangle.FindPerimeter());


            Rectangle rectangle = new Rectangle(20, 20);
            Console.WriteLine(rectangle.FindArea());
            Console.WriteLine(rectangle.FindPerimeter());

            Console.WriteLine("Круг");
            Circle circle = new Circle(15);
            Console.WriteLine(circle.FindArea());
        }
    }
}
