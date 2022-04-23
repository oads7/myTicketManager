using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myTicketManager.Entities
{
    public interface IUser
    {
        public uint id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string fullname { get; set; }
        public string type { get; set; }

    }

    public class User : IUser
    {
        public uint id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string fullname { get; set; }
        public string type { get; set; }

        public User()
        {
            id = 0;
            username = "";
            password = "";
            fullname = "";
            type = "";
        }

    }

}
