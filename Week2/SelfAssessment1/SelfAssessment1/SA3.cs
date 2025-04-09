using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfAssessment1
{
    public class SA3
    {
       public void sa3()
       {
            atm Atm = new atm();
            Atm.balance = 100;
            string option = "0";
            while(option!="5")
            {
                Console.Clear();
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. WithDraw");
                Console.WriteLine("3. Check Balance");
                Console.WriteLine("4. Access histroy");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Enter your option : ");
                option = Console.ReadLine();
                if(option == "1")
                {
                    Console.Write("Enter money to deposit : ");
                    Atm.money = int.Parse(Console.ReadLine());
                    Atm.deposit();
                }
                else if(option == "2")
                {
                    Console.Write("Enter money to withdraw : ");
                    Atm.money = int.Parse(Console.ReadLine());
                    if (Atm.balance >= Atm.money)
                    {
                        Atm.withdraw();
                    }
                    else
                    {
                        Console.Write("Not Enough Money!");
                    }
                }
                else if(option == "3")
                {
                    Console.WriteLine($"Balance : {Atm.balance}");
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }
       }
        public class atm
        {
            public int balance;
            public int money;
            public List <string> history = new List<string>();
            public atm()
            {

            }
            public int withdraw()
            {
                balance = balance - money;
                return balance;
            }
            public int deposit()
            {
                balance = balance + money;
                return balance;
            }
            public void showtransaction()
            {
                for(int i=0;i <  history.Count;i++)
                {

                }
            }
        }

    }
}
