using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8.AccountingOfDocuments
{
    internal class ContractSupplyGoods : Document
    {
        private string _typeProduct;
        private int _quantityProduct;
        public ContractSupplyGoods() : base()
        {
            _typeProduct = "Not found";
            _quantityProduct = 0;
        }
        public ContractSupplyGoods(string TypeProduct, int QuantityProduct, string NumberDocument, DateTime DateDocument) : base(NumberDocument, DateDocument)
        {
            _typeProduct = TypeProduct;
            _quantityProduct = QuantityProduct;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"_typeProduct = {_typeProduct}\n_quantityProduct = {_quantityProduct}\n_dateDocument = {_dateDocument}\n_numberDocument = {_numberDocument}");
        }
    }
}
