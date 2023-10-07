using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Admin : User
    {
        public Admin(int id, string name, string password, string email, string userName) :base(id, name, password, email, userName)
        { 
        }
        public override bool Login()
        {
            Console.WriteLine($"Admin {Name} Logged in");
            Console.WriteLine($"Admin {Name} Information: \n" +
                $"{UserName} , {Id} , {Email} , and password is secured");
            return true;
        }
        public override bool Logout()
        {
            Console.WriteLine($"Admin {Name} Logged inout");
            return true;
        }
    }
}
