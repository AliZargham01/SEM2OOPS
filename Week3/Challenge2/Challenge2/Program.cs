using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int price;
            int quantity;
            int thresholed;
            string category;
            string option = "0";
            Product product;
            while(option!="6")
            {
                Console.Clear();
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. View All Products");
                Console.WriteLine("3. Product With Highest Price");
                Console.WriteLine("4. View Sales Tax of Product");
                Console.WriteLine("5. Products to be Ordered");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your option : ");
                option = Console.ReadLine();
                if(option == "1")
                {
                    Console.Write("Enter Product Name : ");
                    name = Console.ReadLine();
                    Console.Write("Enter Product Price : ");
                    price = int.Parse(Console.ReadLine());
                    Console.Write("Enter Product Quantity : ");
                    quantity = int.Parse(Console.ReadLine());
                    Console.Write("Enter Product Category : ");
                    category = Console.ReadLine();
                    Console.Write("Enter Product Threshold : ");
                    thresholed = int.Parse(Console.ReadLine());
                    product = new Product(name, price, category, quantity, thresholed);
                    product.AddProduct(product);
                }
                else if(option == "2")
                {
                    product = new Product();
                    product.ShowAll();
                    Console.Read();
                }
                else if(option == "3")
                {
                    product = new Product();
                    Console.WriteLine($"Product With highest Price : {product.HighestPrice()}");
                    Console.Read();
                }
                else if(option == "4")
                {
                    product = new Product();
                    product.CalculateSalesTax();
                    Console.Read();
                }
                else if(option == "5")
                {
                    Console.Write("Enter Product Threshold : ");
                    thresholed = int.Parse(Console.ReadLine());
                    product = new Product();
                    product.ProductsToBeOrdered(thresholed);
                    Console.Read();
                }
            }
        }
    }
}
