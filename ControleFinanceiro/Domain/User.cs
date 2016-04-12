using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
   public class User
    {
        public string Email { get; set; }
        public string Users { get; set; }
        public string Password { get; set; }

        public User(string email, string user, string pass)
        {
            this.Email = email;
            this.Users = user;
            this.Password = pass;
        }
    }

   
}
