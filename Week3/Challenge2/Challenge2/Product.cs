using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2
{
    public class Product
    {
        static List<Product> products = new List<Product>();
        public string name;
        public int price;
        public string category;
        public int quantity;
        public int threshold;
        public Product()
        {

        }
        public Product(string name, int price, string category, int quantity, int threshold)
        {
            this.name = name;
            this.price = price;
            this.category = category;
            this.quantity = quantity;
            this.threshold = threshold;
        }

        public void AddProduct(Product p)
        {
            products.Add(p);
        }
        public void ShowAll()
        {
            foreach (Product p in products)
            {
                Console.WriteLine($"Name : {p.name}");
                Console.WriteLine($"Price : {p.price}");
                Console.WriteLine($"Category : {p.category}");
                Console.WriteLine($"Quantity : {p.quantity}");
                Console.WriteLine($"Threshold : {p.threshold}");
                Console.WriteLine();
            }
        }
        public string HighestPrice()
        {
            int max = 0, x = 0;
            for(int i = 0; i<products.Count;i++)
            {
                if(max > products[i].price)
                {
                    max = products[i].price;
                    x = i;
                }
            }
            return products[x].name;
        }
        public void CalculateSalesTax()
        {
            float tax = 0;
            foreach(Product p in products)
            {
                if(p.category == "fruit")
                {
                    tax = (p.price * 5)/100;
                    Console.WriteLine($"Product Name : {p.name}");
                    Console.WriteLine($"Product Tax : {tax}");
                    Console.WriteLine();
                }
                else if (p.category == "groceries")
                {
                    tax = (p.price * 10) / 100;
                    Console.WriteLine($"Product Name : {p.name}");
                    Console.WriteLine($"Product Tax : {tax}");
                    Console.WriteLine();
                }
                else
                {
                    tax = (p.price * 15) / 100;
                    Console.WriteLine($"Product Name : {p.name}");
                    Console.WriteLine($"Product Tax : {tax}");
                    Console.WriteLine();
                }
            }
        }
        public void ProductsToBeOrdered(int threshold)
        {
            foreach(Product p in products)
            {
                if(p.threshold < threshold)
                {
                    Console.WriteLine(p.name);
                }
            }
        }
    }
}
