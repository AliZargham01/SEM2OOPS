using MessagingSystem.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagingSystem.UI
{
    public class MUserUI
    {
        public static MUser getUserInfo()
        {
            Console.Write("Enter Name:");
            string userName = Console.ReadLine();
            Console.Write("Enter Password");
            string password = Console.ReadLine();
            MUser user = new MUser(userName, password);
            return user;
        
        }
        public static void showAll(List<MUser> users)
        {
            foreach (MUser user in users)
            {
                Console.WriteLine("{0} \t {1}", user.userName, user.password);
            }

        }
    }
}
