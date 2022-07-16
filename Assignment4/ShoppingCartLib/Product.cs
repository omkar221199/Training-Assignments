using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartLib
{
    public class Product
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public Product()
        {

        }
        public Product(string productName, decimal price, int quantity)
        {
            ProductName = productName;
            Price = price;
            Quantity = quantity;
        }

        public decimal GetProductCost()
        {
            return Price * Quantity;
        }

        public override string ToString()
        {
            return String.Format($"Product Name is: {ProductName}\nPrice is: {Price}\nQuantity is: {Quantity}");
        }
    }
}
