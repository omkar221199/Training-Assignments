using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLib
{
    public class Product
    {
        private string productName;
        private double price;
        private int quantity;
        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public double Total
        {
            get { return  Price*Quantity; }  
        }
        public Product(string productName, double price, int quantity)
        {
            ProductName = productName;
            Price = price;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return $"Product: {ProductName}, Price: {Price}, Quantity: {Quantity}";
        }
    }
}
