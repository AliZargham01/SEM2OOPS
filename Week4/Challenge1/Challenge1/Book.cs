using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    public class Book
    {
        public string title;
        public int number;
        public string[] authors = new string[4];
        public string publisher;
        public int price;
        public int ISBN;
        public int year;
        public int copies;
        public static List<Book> books = new List<Book>();
        public Book(string title, string[] authors, string publisher, int price, int ISBN, int year,int copies, int number)
        {
            this.title = title;
            this.authors = (string[])authors.Clone();
            this.publisher = publisher;
            this.price = price;
            this.ISBN = ISBN;
            this.year = year;
            this.copies = copies;
            this.number = number;
        }
       public Book()
        {

        }
        public void AdddBook(Book b)
        {
            books.Add(b);
        }
        public void DisplayBooks()
        {
            Console.Clear();
            foreach(Book book in books)
            {
                Console.WriteLine($"Title : {book.title}");
                for (int x = 0; x < book.number; x++)
                {
                    Console.WriteLine($"Author : {book.authors[x]}");
                }
                Console.WriteLine($"ISBN : {book.ISBN}");
                Console.WriteLine($"Number of Copies : {book.copies}");
                Console.WriteLine($"Publisher : {book.publisher}");
                Console.WriteLine($"Year of Publication : {book.year}");
                Console.WriteLine();
            }
        }
        public Book searchBook(string Title)
        {
            int x = 0;
            for (int i = 0; i < books.Count; i++)
            {
                if (Title == books[i].title)
                {
                    x = i;
                    break;
                }
            }
            return books[x];
        }
        public Book searchBook(int isbn)
        {
            int x = 0;
            for (int i = 0; i < books.Count; i++)
            {
                if (isbn == books[i].ISBN) 
                {
                    x = i;
                    break;
                }
            }
            return books[x];
        }
        public void updateCopies(string title, int copies)
        {
            int x = 0;
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].ISBN == ISBN) 
                {
                    x = i;
                    break;
                }
            }
            books[x].copies = copies;
        }

    }

}
