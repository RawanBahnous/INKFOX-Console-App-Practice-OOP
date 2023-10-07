using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Customer : User
    {
        internal string Firstname { get; set; }
        internal string Lasttname { get; set; }
        internal string Phone { get; set; }
        internal string CityAddress { get; set; }

        public Customer(int id, string name, string Firstname, string Lasttname, string CityAddress,string Phone, string password, string email, string userName) : base(id, name, password, email, userName)
        {
            this.Firstname = Firstname;
            this.CityAddress = CityAddress;
            this.Lasttname = Lasttname;
            this.Phone = Phone;
        }

        public override bool Login()
        {
            Console.WriteLine($"Customer ({Name}) {Firstname} {Lasttname} Logged in");
            Console.WriteLine($"Customer {Name} Information: \n" +
                $"{UserName} , {Id} , {Email} ,Phone {Phone} , {CityAddress} and password is secured");
            return true;
        }
        public override bool Logout()
        {
            return base.Logout();
        }
    }
}
