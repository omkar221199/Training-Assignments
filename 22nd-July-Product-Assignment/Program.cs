using System;
using System.Collections.Generic;
using ProductLib;

namespace ProductApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductCollection productCollection = new ProductCollection();
            List<Product> products;
            int choice;

            do
            {
                Console.WriteLine("\n1.Add Product\n2.Delete Product\n" +
                    "3.Display all Products\n4.Search a Product\n5.Search a product on basis of Price\n6.Enter 6 to exit\n");
                Console.WriteLine("Enter choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Product Name: ");
                        string addProduct = Console.ReadLine();
                        Console.WriteLine("Enter price: ");
                        double price = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter quantity: ");
                        int quantity = Convert.ToInt32(Console.ReadLine());
                        productCollection.AddProduct(new Product(addProduct, price, quantity));
                        break;
                    case 2:
                        Console.WriteLine("Enter Product Name: ");
                        string deleteProduct = Console.ReadLine();
                        productCollection.DeleteProduct(deleteProduct);
                        break;
                    case 3:
                        products = productCollection.DisplayAll();
                        for(int i =0; i<products.Count; i++)
                        {
                            Console.WriteLine(products[i]);
                        }
                        break;
                    case 4:
                        Console.WriteLine("Enter Product Name: ");
                        string searchProduct = Console.ReadLine();
                        Product result = productCollection.Search(searchProduct);

                        if (result != null)
                        {
                            Console.WriteLine(result);
                        }
                        else
                        {
                            Console.WriteLine($"{searchProduct} not found.");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Enter sign: Greater than (>) or Lesser than (<) or Equal to (=)");
                        string operatorType = Console.ReadLine();
                        Console.WriteLine("Enter price: ");
                        double queryPrice = Convert.ToDouble(Console.ReadLine());
                        products = productCollection.QueryPrice(operatorType, queryPrice);
                        for (int i = 0; i < products.Count; i++)
                        {
                            Console.WriteLine(products[i]);
                        }
                        break;
                }
            } while (choice < 6);
        }
    }
}

