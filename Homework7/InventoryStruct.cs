using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    public struct InventoryStruct
    {
        public decimal GetTotalPrice(ProductStruct product)
        {
            return product.Price * product.Quantity;
        }
    }
}
