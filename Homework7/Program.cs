namespace Homework7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product cheese = new Product("Cheese", 40);
            Product salt = new Product("Salt", 200m);
            Product vine = new Product("Vine", 3000.00m, 200);
            Product bread = new Product("Bread",2, 250.25m, 4);
            Product[] myProducts = new Product[] {cheese, salt, vine, bread};

            Inventory inventory = new Inventory();

            foreach (Product myProduct in myProducts)
            {
                Console.WriteLine($"My product:\nName = {myProduct.Name}\nId = {myProduct.Id}\nPrice = {myProduct.Price}\nQuantity = {myProduct.Quantity}");

                Console.WriteLine($"The price of the whole product = {inventory.GetTotalPrice(myProduct)}\n");
            }
        }
    }
}
