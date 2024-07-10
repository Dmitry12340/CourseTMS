namespace Homework6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Первое задание
            Phone phone1 = new Phone();
            Phone phone2 = new Phone();
            Phone phone3 = new Phone();

            Console.WriteLine($"Phone1 = {phone1.Number}, {phone1.Model}, {phone1.Weight}\n" +
                $"Phone2 = {phone2.Number}, {phone2.Model}, {phone2.Weight}\n" +
                $"Phone3 = {phone3.Number}, {phone3.Model}, {phone3.Weight}");

            Console.WriteLine();

            string number = "+79891621435";
            phone1.ReceiveCall(number);
            Console.WriteLine(phone1.GetNumber());
            phone2.ReceiveCall(number);
            Console.WriteLine(phone2.GetNumber());
            phone3.ReceiveCall(number);
            Console.WriteLine(phone3.GetNumber());

            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Введите номера телефонов через пробел");
            string answer = Console.ReadLine();
            string[] numbers = answer.Split(' ');


            Phone phone4 = new Phone();
            phone4.SendMessage(numbers);


            Console.ReadLine();
            Console.Clear();

            //Второе задание
            while (true)
            {
                Console.WriteLine("Введите тип лечения пациента");
                bool correctInput = false;

                correctInput = int.TryParse(Console.ReadLine(), out int typePlan);
                if (!correctInput)
                {
                    typePlan = 0;
                }

                TreatmentPlan plan = new TreatmentPlan(typePlan);

                Patient patient = new Patient(plan);
                patient.ToHeal();
            }
        }
    }
}
