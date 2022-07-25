using System;
using System.Collections.Generic;

namespace ProductLib
{
    public class ProductCollection
    {
        private List<Product> products = new List<Product>();

        public ProductCollection()
        {

        }
        public ProductCollection(List<Product> products)
        {
            this.products = products;
        }

        public void AddProduct(Product product)                                  //working fine
        {
            products.Add(product);
            Console.WriteLine("Product Added...");
        }

        public void DeleteProduct(string productName)                           //working fine
        {
            bool flag = true;
            for(int i = 0; i < products.Count; i++)
            {
                if (products[i].ProductName == productName)
                {
                    flag = false;
                    products.Remove(products[i]);
                    Console.WriteLine($"{productName} is deleted.");
                    break;
                }
            }
            if (flag) 
            {
                Console.WriteLine($"{productName} not found.");
            } 
        }

        public List<Product> DisplayAll()                                //working fine
        {
            return products;
        }

        public Product Search(string productName)         
        {
            Product res = null;
            for(int i=0; i < products.Count; i++)
            {
                if(products[i].ProductName == productName)
                {
                    res = products[i];
                    break;
                }
            }
            return res;
        }

        public List<Product> QueryPrice(string operatorType, double price)    //working fine
        {
            List<Product> prod = new List<Product>();
            for(int i=0; i<products.Count; i++)
            {
                
                if (operatorType == ">" && products[i].Price > price)
                {
                    prod.Add(products[i]);
                    
                }
                else if(operatorType == "<" && products[i].Price < price)
                {
                    prod.Add(products[i]);
                    
                }
                else if(operatorType == "=" && products[i].Price == price)
                {
                    prod.Add(products[i]);
                    
                }
            }
            return prod;
        }
    }
}
