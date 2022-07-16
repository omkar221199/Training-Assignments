using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingCartLib;

namespace AmazonApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter product name: ");
            string productName = Console.ReadLine();

            Console.WriteLine("Enter price: ");
            decimal price = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter quantity: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            Product product = new Product(productName, price, quantity);
            Console.WriteLine(product);
            Console.WriteLine("Overall cost is: " + product.GetProductCost());

            Console.ReadLine();

        }
    }
}
