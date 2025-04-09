using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            string country;
            string brandname;
            string category;
            int price;
            int id;
            string option = "0";
            Product product;
            while(option!="4")
            {
                Console.Clear();
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Show All Product");
                Console.WriteLine("3. Total Price");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your option : ");
                option = Console.ReadLine();
                if(option == "1")
                {
                    Console.Write("Enter product name : ");
                    name = Console.ReadLine();
                    Console.Write("Enter product id : ");
                    id = int.Parse(Console.ReadLine());
                    Console.Write("Enter product price : ");
                    price = int.Parse(Console.ReadLine());
                    Console.Write("Enter product category : ");
                    category = Console.ReadLine();
                    Console.Write("Enter product Country : ");
                    country = Console.ReadLine();
                    Console.Write("Enter product BrandName : ");
                    brandname = Console.ReadLine();
                    product = new Product(id,name,category,price,country,brandname);
                    product.AddProduct(product);
                }
                else if(option == "2")
                {
                    product = new Product();
                    product.showAllProducts();
                    Console.WriteLine("Error input");
                    Console.Write("Press an key to continue : ");
                    Console.ReadKey();
                }
                else if(option == "3")
                {
                    product = new Product();
                    Console.Write($"Total :  {product.StoreTotal()}");
                    Console.WriteLine("Error input");
                    Console.Write("Press an key to continue : ");
                    Console.ReadKey();
                }
                
            }
        }
    }
}
