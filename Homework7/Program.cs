namespace Homework7
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
