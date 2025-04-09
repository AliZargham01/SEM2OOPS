using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3
{
    public class Member
    {
        public string name;
        public int id;
        public static List<Member> members = new List<Member>();
        public List<Book> books = new List<Book>();
        public int numberOfBooks;
        public double balance;
        public double spent = 0;
        public Member()
        {

        }
        public Member(string name, int id, double balance)
        {
            this.name = name;
            this.id = id;
            if(id!=0)
            {
                this.balance = balance - 10;
                this.spent = 0;
            }
            else
            {
                this.balance = balance;
                this.spent = 0;
            }
        }

        public static void AddMember(Member m)
        {
            members.Add(m);
        }
        public static void DisplayAllMembers()
        {
            foreach (var m in members)
            {
                Console.WriteLine($"Name : {m.name}");
                Console.WriteLine($"ID : {m.id}");
                Console.WriteLine($"Balance : {m.balance}");
                Console.WriteLine($"Amount Spent : {m.spent}");
                Console.WriteLine($"Number of Books : {m.numberOfBooks}");
                Console.WriteLine();
            }
        }
        public void ShowBooksBought(Member m)
        {
            Console.WriteLine($"Member Name : {m.name}");
            for (int i = 0; i < books.Count; i++)
            {
                Console.WriteLine($"Book Name : {books[i].title}");
            }
        }
        public static void SearchMember(string name)
        {
            foreach (var m in members)
            {
                if (m.name == name)
                {
                    Console.WriteLine($"Name : {m.name}");
                    Console.WriteLine($"ID : {m.id}");
                    Console.WriteLine($"Balance : {m.balance}");
                    Console.WriteLine($"Amount Spent : {m.spent}");
                    Console.WriteLine($"Number of Books : {m.numberOfBooks}");
                    Console.WriteLine();
                    break;
                }
            }
        }
        public static void UpdateMember(string name, string newname)
        {
            foreach (var m in members)
            {
                if (m.name == name)
                {
                    m.name = newname;
                    break;
                }
            }
        }
        public void BuyBooks(int isbn)
        {
            numberOfBooks++;
            if(numberOfBooks == 11)
            {
                int sum = 0;
                for(int i = 0; i < 10;i++)
                {
                    sum += books[i].price;
                }
                sum = sum/ 10;
                balance = balance + sum;

            }
            Book b = new Book();
            b = Book.searchBook(isbn);
            books.Add(b);
            b.copies--;
            if (id != 0)
            {
                balance = balance - (b.price - (b.price*0.05));
                spent += (b.price - (b.price * 0.05));
            }
            else
            {
                balance -= b.price;
                spent += b.price;
            }
        }
    }
}