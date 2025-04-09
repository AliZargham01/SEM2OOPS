using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessagingSystem.BL;
namespace MessagingSystem.UI
{
    public class MailUI
    {
        public static Mail getMessageDetail()
        {
            Console.Write("From:");
            string from = Console.ReadLine();
            Console.Write("To:");
            string to = Console.ReadLine();
            Console.Write("Content:");
            string content = Console.ReadLine();
            Mail mail = new Mail(from, to, content);
            return mail;
        }

        public static void showAllMessage(List<Mail> mails)
        {
            foreach (Mail mail in mails)
            {
                Console.WriteLine("{0}:{1}", mail.from, mail.contents);

            }

        }

    }
}
