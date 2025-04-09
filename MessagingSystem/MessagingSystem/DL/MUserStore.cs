using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessagingSystem.BL;
namespace MessagingSystem.DL
{
    public class MUserStore
    {
        public List<MUser> store = new List<MUser>();
        public void addUser(MUser user)
        {
            store.Add(user);
        }
        public List<MUser> getAll()
        {
            return store;
        }
    }
}
