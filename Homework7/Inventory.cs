using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    public class Inventory
    {
        public decimal GetTotalPrice(Product product)
        {
            return product.Price * product.Quantity;
        }
    }
}
