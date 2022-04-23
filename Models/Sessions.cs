using myTicketManager.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myTicketManager
{
    public static class Sessions
    {
        private static ICollection<User> list = new Collection<User>();

        public static void Register(User user)
        {
            

            list.Add(user);
        }

        public static User Current()
        {
            return list.Last();
        }

    }
}
