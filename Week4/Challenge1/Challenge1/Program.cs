using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            string title;
            string[] authors = new string[4];
            string publisher;
            int price;
            int ISBN;
            int year;
            int copies;
            Book book;
            string option = "0";
            while(option != "6")
            {
                Console.Clear();
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Search Book by Title");
                Console.WriteLine("3. Search Book by ISBN");
                Console.WriteLine("4. Update number of copies");
                Console.WriteLine("5. Dsiplay All Books");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your option : ");
                option = Console.ReadLine();
                if(option == "1")
                {
                    Console.Write("Enter Book Title : ");
                    title = Console.ReadLine();
                    Console.Write("Enter Number of Authors(Less than 4)  : ");
                    number = int.Parse(Console.ReadLine());
                    for(int x=0;x <number;x++)
                    {
                        Console.Write("Enter authors name : ");
                        authors[x] = Console.ReadLine();
                    }
                    Console.Write("Enter Book ISBN : ");
                    ISBN = int.Parse(Console.ReadLine());
                    Console.Write("Enter Publisher : ");
                    publisher = (Console.ReadLine());
                    Console.Write("Enter Number of copies : ");
                    copies =int.Parse(Console.ReadLine());
                    Console.Write("Enter Year of Publication : ");
                    year = int.Parse(Console.ReadLine());
                    Console.Write("Enter Price : ");
                    price = int.Parse(Console.ReadLine());
                    book =new Book(title, authors,publisher,price,ISBN,year,copies,number);
                    book.AdddBook(book);
                }
                else if(option == "2")
                {
                    Console.Write("Enter Book's Name : ");
                    title = Console.ReadLine();
                    book = new Book();
                    book = book.searchBook(title);
                    Console.WriteLine($"Title : {book.title}");
                    for(int x=0; x<book.number;x++)
                    {
                        Console.WriteLine($"Author : {book.authors[x]}");
                    }
                    Console.WriteLine($"ISBN : {book.ISBN}");
                    Console.WriteLine($"Number of Copies : {book.copies}");
                    Console.WriteLine($"Publisher : {book.publisher}");
                    Console.WriteLine($"Year of Publication : {book.year}");
                    Console.ReadKey();
                }
                else if (option == "3")
                {
                    Console.Write("Enter Book's ISBN : ");
                    ISBN = int.Parse(Console.ReadLine());
                    book = new Book();
                    book = book.searchBook(ISBN);
                    Console.WriteLine($"Title : {book.title}");
                    for (int x = 0; x < book.number; x++)
                    {
                        Console.WriteLine($"Author : {book.authors[x]}");
                    }
                    Console.WriteLine($"ISBN : {book.ISBN}");
                    Console.WriteLine($"Number of Copies : {book.copies}");
                    Console.WriteLine($"Publisher : {book.publisher}");
                    Console.WriteLine($"Year of Publication : {book.year}");
                    Console.ReadKey();
                }
                else if(option == "4")
                {
                    Console.Write("Enter Title : ");
                    title = Console.ReadLine();
                    book = new Book();
                    Console.Write("Enter updated number of copies : ");
                    copies = int.Parse(Console.ReadLine());
                    book.updateCopies(title, copies);
                }
                else if(option == "5")
                {
                    book = new Book();
                    book.DisplayBooks();
                    Console.ReadKey();
                }
            }
    }
    }
}
