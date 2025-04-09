using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagingSystem.BL
{
    public class MUser
    {
        public string userName;
        public string password;
        public MUser(string userName, string password)
        {
            this.userName = userName;
            this.password = password;
        }
    }
}
