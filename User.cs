using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class User
    {

        protected int Id { get; set; }
        protected string Name { get; set; }
        protected string Password { get; set; }
        protected string Email { get; set; }

        protected string UserName { get; set; }

        public User(int id, string name, string password, string email, string userName)
        {
            Id = id;
            Name = name;
            Password = password;
            Email = email;
            UserName = userName;
        }

        public virtual bool Login()
        {
            var loggedin = true;
            Console.WriteLine($"User {Name} Logged in");
            return loggedin=true;

        }
        public virtual bool Logout()
        {
            Console.WriteLine($"User {Name} Logged out");
            return true;
        }

    }
}
