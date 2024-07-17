namespace Homework7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CashMachine cashMachine = new CashMachine(2,4,2);
            cashMachine.WithdrawCash(340);



            Console.ReadLine();
            //ДЗ по презентации

            //Классы
            Product cheese = new Product("Cheese", 40);
            Product salt = new Product("Salt", 200m);
            Product vine = new Product("Vine", 3000.00m, 200);
            Product bread = new Product("Bread",2, 250.25m, 4);
            Product[] myProductsClass = new Product[] {cheese, salt, vine, bread};

            Inventory inventoryClass = new Inventory();

            Console.WriteLine("Реализованно через классы");
            foreach (Product myProduct in myProductsClass)
            {
                Console.WriteLine($"My product:\nName = {myProduct.Name}\nId = {myProduct.Id}\nPrice = {myProduct.Price}\nQuantity = {myProduct.Quantity}");

                Console.WriteLine($"The price of the whole product = {inventoryClass.GetTotalPrice(myProduct)}\n");
            }

            Console.ReadLine();
            Console.Clear();

            //Структураы
            ProductStruct table = new ProductStruct("Table", 40);
            ProductStruct copybook = new ProductStruct("Copybook", 200m);
            ProductStruct pen = new ProductStruct("Pen", 3000.00m, 200);
            ProductStruct stool = new ProductStruct("Stool", 2, 250.25m, 4);
            ProductStruct[] myProductsStruct = new ProductStruct[] { table, copybook, pen, stool };

            InventoryStruct inventoryStruct = new InventoryStruct();

            Console.WriteLine("Реализованно через структуры");
            foreach (ProductStruct myProduct in myProductsStruct)
            {
                Console.WriteLine($"My product:\nName = {myProduct.Name}\nId = {myProduct.Id}\nPrice = {myProduct.Price}\nQuantity = {myProduct.Quantity}");

                Console.WriteLine($"The price of the whole product = {inventoryStruct.GetTotalPrice(myProduct)}\n");
            }

            Console.ReadLine();
            Console.Clear();


            //ДЗ по методичке

            //ДЗ 1
            CreditCard creditCard1 = new CreditCard("6468484", 2000000);
            CreditCard creditCard2 = new CreditCard("35435", 1987);
            CreditCard creditCard3 = new CreditCard("45343", 77777);
            creditCard1.DepositMoney(30000);
            creditCard2.DepositMoney(200.80m);
            creditCard3.WithdrawMoney(980.4m);
            creditCard1.ShowBalance();
            creditCard2.ShowBalance();
            creditCard3.ShowBalance();

            Console.Read();
            Console.Clear();

            //ДЗ 2
            Ram ram1 = new Ram("HyperX", 8000);
            HDD hdd1 = new HDD("Kingstone", 6000, "External");

            Computer computer1 = new Computer(50000, "Hp", ram1, hdd1);
            Computer computer2 = new Computer(70000, "Lenovo");

            computer1.ShowParameters();
            computer2.ShowParameters();

            //ДЗ 3

        }
    }
}
