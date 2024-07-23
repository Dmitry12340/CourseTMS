using Homework8.AccountingOfDocuments;

namespace Homework8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Дз по презентации
            Dog dog = new Dog();
            dog.SetName("Шарик");
            Console.WriteLine(dog.GetName());
            dog.Eat();

            Console.ReadKey();
            Console.Clear();

            //Дз по методичке

            //Дз 1
            Console.WriteLine("Треугольник");
            Triangle triangle = new Triangle(20.5, 20.3, 20.1);
            Console.WriteLine($"Площадь:{triangle.FindArea()}");
            Console.WriteLine($"Периметр:{triangle.FindPerimeter()}");
            Console.WriteLine();


            Console.WriteLine("Прямоугольник");
            Rectangle rectangle = new Rectangle(20, 20);
            Console.WriteLine($"Площадь:{rectangle.FindArea()}");
            Console.WriteLine($"Периметр:{rectangle.FindPerimeter()}");
            Console.WriteLine();


            Console.WriteLine("Круг");
            Circle circle = new Circle(30);
            Console.WriteLine($"Площадь:{circle.FindArea()}");
            Console.WriteLine($"Периметр:{circle.FindPerimeter()}\n");

            double sumPerimeter = 0;
            Figure[] figures = {triangle, rectangle, circle};
            for(int i = 0; i < figures.Length; i++)
            {
                sumPerimeter += figures[i].FindPerimeter();
            }
            Console.WriteLine($"Сумма всех периметров = {sumPerimeter}");

            Console.ReadKey();
            Console.Clear();

            //Дз 2
            Director director = new Director();
            Worker worker = new Worker();
            Accountant accountant = new Accountant();
            director.Print();
            worker.Print();
            accountant.Print();

            Console.ReadKey();
            Console.Clear();

            //Дз 3

            FinancialInvoice financialInvoice = new FinancialInvoice();
            FinancialInvoice financialInvoice2 = new FinancialInvoice(3000, "GFJD000", "450", DateTime.Now);
            СontractEmployee сontractEmployee = new СontractEmployee();
            СontractEmployee сontractEmployee2 = new СontractEmployee("Dmitry", DateTime.Now, new DateTime(2027, 12, 31), "KHBKHFB", DateTime.Now);
            ContractSupplyGoods contractSupplyGoods = new ContractSupplyGoods();
            ContractSupplyGoods contractSupplyGoods2 = new ContractSupplyGoods("Физическое лицо", 200, "HGFKHDG", DateTime.Now);



            Register register = new Register();
            register.SaveDocument(financialInvoice);
            register.SaveDocument(financialInvoice2);
            register.SaveDocument(сontractEmployee);
            register.SaveDocument(сontractEmployee2);
            register.SaveDocument(contractSupplyGoods);
            register.SaveDocument(contractSupplyGoods2);
            register.SaveDocument(financialInvoice);
            register.SaveDocument(financialInvoice2);
            register.SaveDocument(сontractEmployee);
            register.SaveDocument(сontractEmployee2);
            register.SaveDocument(contractSupplyGoods);
        }
    }
}
