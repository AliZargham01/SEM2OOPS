using System;
using System.Collections.Generic;
using MessagingSystem.BL;
using MessagingSystem.UI;
using MessagingSystem.DL;

namespace MessagingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MailStore mailStore = new MailStore();
            MUserStore userStore = new MUserStore();

            int option = -1;
            while ((option = menu()) != 5)
            {
                if (option == 1)
                {
                    //Code to Signup User
                     MUser user = MUserUI.getUserInfo();
                     userStore.addUser(user);
                     waitKey();
                }
                if (option == 2)
                {
                    //Code that shows all Users
                    List<MUser> users = userStore.getAll();
                    MUserUI.showAll(users);

                    waitKey();
                }

                if (option == 3)
                {
                    //Code to send Message
                    Mail mail = MailUI.getMessageDetail();
                    mailStore.addMail(mail);
                    waitKey();
                }
                if (option == 4)
                {
                    //Read Message
                    Console.WriteLine("Your User Name");
                    string userName = Console.ReadLine();
                    List<Mail> userMessages = mailStore.getAllMail(userName);
                    MailUI.showAllMessage(userMessages);
                    waitKey();

                }
            }
        }

        static void waitKey()
        {
            Console.WriteLine("Press any Key to Continue...");
            Console.ReadKey();
        }
        static int menu()
        {
            Console.Clear();
            Console.WriteLine("1. Signup");
            Console.WriteLine("2. Show All");
            Console.WriteLine("3. Send Message");
            Console.WriteLine("4. Read Message");
            Console.WriteLine("5. Exit");
            Console.Write("Enter Option: ");
            int option = int.Parse(Console.ReadLine());
            return option;
        }
    }
}
