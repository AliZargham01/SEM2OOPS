using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;
using Challenge2;

namespace Challenge2
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
            string name;
            int id;
            int balance;
            Member member;
            Book book;
            string option = "0";
            while (option != "12")
            {
                Console.Clear();
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Search Book by Title");
                Console.WriteLine("3. Search Book by ISBN");
                Console.WriteLine("4. Update number of copies");
                Console.WriteLine("5. Display All Books");
                Console.WriteLine("6. Add Member");
                Console.WriteLine("7. Dsiplay All Members");
                Console.WriteLine("8. Search Member");
                Console.WriteLine("9. Update Member Name");
                Console.WriteLine("10. Buy Books");
                Console.WriteLine("11. Show Bought Books");
                Console.WriteLine("12. Exit");
                Console.Write("Enter your option : ");
                option = Console.ReadLine();
                if (option == "1")
                {
                    Console.Write("Enter Book Title : ");
                    title = Console.ReadLine();
                    Console.Write("Enter Number of Authors(Less than 4)  : ");
                    number = int.Parse(Console.ReadLine());
                    for (int x = 0; x < number; x++)
                    {
                        Console.Write("Enter authors name : ");
                        authors[x] = Console.ReadLine();
                    }
                    Console.Write("Enter Book ISBN : ");
                    ISBN = int.Parse(Console.ReadLine());
                    Console.Write("Enter Publisher : ");
                    publisher = (Console.ReadLine());
                    Console.Write("Enter Number of copies : ");
                    copies = int.Parse(Console.ReadLine());
                    Console.Write("Enter Year of Publication : ");
                    year = int.Parse(Console.ReadLine());
                    Console.Write("Enter Price : ");
                    price = int.Parse(Console.ReadLine());
                    book = new Book(title, authors, publisher, price, ISBN, year, copies, number);
                    Book.AdddBook(book);
                }
                else if (option == "2")
                {
                    Console.Write("Enter Book's Name : ");
                    title = Console.ReadLine();
                    book = new Book();
                    book = Book.searchBook(title);
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
                else if (option == "3")
                {
                    Console.Write("Enter Book's ISBN : ");
                    ISBN = int.Parse(Console.ReadLine());
                    book = new Book();
                    book = Book.searchBook(ISBN);
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
                else if (option == "4")
                {
                    Console.Write("Enter Title : ");
                    title = Console.ReadLine();
                    book = new Book();
                    Console.Write("Enter updated number of copies : ");
                    copies = int.Parse(Console.ReadLine());
                    Book.updateCopies(title, copies);
                }
                else if (option == "5")
                {
                    Book.DisplayBooks();
                    Console.ReadKey();
                }
                else if(option == "6")
                {
                    Console.Write("Enter Name of Member : ");
                    name = Console.ReadLine();
                    Console.Write("Enter Member ID : ");
                    id = int.Parse(Console.ReadLine());
                    Console.Write("Enter Member Balance : ");
                    balance = int.Parse(Console.ReadLine());
                    member = new Member(name, id, balance);
                    Member.AddMember(member);
                }
                else if(option == "7")
                {
                    Member.DisplayAllMembers();
                    Console.ReadKey();
                }
                else if(option == "8")
                {
                    Console.Write("Enter Name of Member : ");
                    name = Console.ReadLine();
                    Member.SearchMember(name);
                    Console.ReadKey();
                }
                else if(option == "9")
                {
                    string newname;
                    Console.Write("Enter Name of Member : ");
                    name = Console.ReadLine();
                    Console.Write("Enter newname of Member  : ");
                    newname = Console.ReadLine();
                    Member.UpdateMember(name, newname);
                }
                else if(option == "10")
                {
                    Console.Write("Enter MemberID : ");
                    id = int.Parse(Console.ReadLine());
                    foreach(Member m in Member.members)
                    {
                        if(m.id == id)
                        {
                            Book.DisplayBooks();
                            Console.Write("Enter book's ISBN : ");
                            ISBN = int.Parse(Console.ReadLine());
                            foreach(Book b in Book.books)
                            {
                                if(b.ISBN == ISBN)
                                {
                                    m.BuyBooks(ISBN);
                                    break;
                                }
                            }
                            break;
                        }
                    }
                }
                else if(option == "11")
                {
                    Console.WriteLine("Enter Member ID : ");
                    id = int.Parse(Console.ReadLine()) ;
                    foreach(Member m in Member.members)
                    {
                        if(m.id == id)
                        {
                            m.ShowBooksBought(m);
                        }
                    }
                    Console.ReadLine();
                }
            }
        }
    }
}
