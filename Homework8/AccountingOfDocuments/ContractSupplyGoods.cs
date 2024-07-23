using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8.AccountingOfDocuments
{
    internal class ContractSupplyGoods : Document
    {
        public string TypeProduct {  get; private set; }
        public int QuantityProduct {  get; private set; }
        public ContractSupplyGoods() : base()
        {
            TypeProduct = "Not found";
            QuantityProduct = 0;
        }
        public ContractSupplyGoods(string TypeProduct, int QuantityProduct, string NumberDocument, DateTime DateDocument) : base(NumberDocument, DateDocument)
        {
            this.TypeProduct = TypeProduct;
            this.QuantityProduct = QuantityProduct;
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"TypeProduct = {TypeProduct}\n" +
                $"QuantityProduct = {QuantityProduct}\n" +
                $"DateDocument = {DateDocument}\n" +
                $"NumberDocument = {NumberDocument}\n");
        }
    }
}
