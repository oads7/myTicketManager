using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using myTicketManager.Entities;
using System.Net;

namespace myTicketManager.Controllers
{
    public static class LoginValidate
    {

        public static async Task<bool> StartSessionAsync(string username, string password)
        {
            bool returnValue = false;

            // Pass password string through function hash
            string passwordHash = string.Empty;
            {
                SHA256 sha256 = SHA256.Create();
                byte[] bytePassword = Encoding.ASCII.GetBytes(password);
                byte[] bytePasswordHash = sha256.ComputeHash(bytePassword);

                passwordHash = Convert.ToHexString(bytePasswordHash);
            }
            Log.Write(passwordHash);
            
            User user = await Database.GetUser(username);
            if (user.password == passwordHash)
            {
                Sessions.Register(user);
                returnValue = true;
            }

            return returnValue;
        }

        public static bool FinishSession(string username)
        {
            return false;
        }


    }
}
