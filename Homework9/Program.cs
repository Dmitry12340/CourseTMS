using Homework9.Credit;
using Homework9.Cars;

namespace Homework9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ДЗ 1
            Debt mortgage = new Debt(120000.0, 1.01);
            mortgage.PrintBalance();
            mortgage.WaitOneYear();
            mortgage.PrintBalance();
            // Wait 20 years
            int years = 0;
            while (years < 20)
            {
                mortgage.WaitOneYear();
                years = years + 1;
            }
            mortgage.PrintBalance();

            Console.ReadLine();





            //ДЗ3
            Car car = new Car(0);
            car.Drive();

            car.Refuel(10);
            car.Drive();


            Console.WriteLine();


            car = new Truck(0);
            car.Drive();

            car.Refuel(10);
            car.Drive();


            Console.WriteLine();


            car = new SportsCar(0);
            car.Drive();

            car.Refuel(10);
            car.Drive();
        }
    }
}
