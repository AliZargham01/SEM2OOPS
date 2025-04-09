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
        public int id;
        public string name;
        public string category;
        public int price;
        public string country;
        public string brandname;
        public Product()
        {

        }

        public Product(int id, string name, string category, int price, string country, string brandname)
        {
            this.id = id;
            this.name = name;
            this.category = category;
            this.price = price;
            this.country = country;
            this.brandname = brandname;
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void showAllProducts()
        {
            for (int i=0;i<products.Count;i++)
            {
                Console.WriteLine($"Name : {products[i].name}");
                Console.WriteLine($"ID : {products[i].id}");
                Console.WriteLine($"Category : {products[i].category}");
                Console.WriteLine($"BrandName : {products[i].brandname}");
                Console.WriteLine($"Price : {products[i].price}");
                Console.WriteLine($"Country : {products[i].country}");
            }
        }
        public int StoreTotal()
        {
            int total = 0;
            for (int i = 0; i < products.Count; i++)
            {
                total += products[i].price;
            }
            return total;
        }
    }
    
}
