using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessagingSystem.BL;

namespace MessagingSystem.DL
{
   public class MailStore
    {
        public List<Mail> store = new List<Mail>();

        public void addMail(Mail mail)
        {
            store.Add(mail);
        }
        public List<Mail> getAllMail(string userName)
        {
           return store.FindAll(mail => mail.to == userName);
            //LINQ ; Lambda Operator
            
        }
    }
}
