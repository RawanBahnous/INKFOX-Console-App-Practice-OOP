using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Vendor : User
    {
        private string Firstname { get; set; }
        private string Lasttname { get; set; }
        private string Phone { get; set; }
        private string CityAddress { get; set; }

        public Vendor(int id, string name, string Firstname, string Lasttname, string CityAddress, string Phone, string password, string email, string userName) : base(id, name, password, email, userName)
        {
            this.Firstname = Firstname;
            this.CityAddress = CityAddress;
            this.Lasttname = Lasttname;
            this.Phone = Phone;
        }

        public override bool Login()
        {
            Console.WriteLine($"Vendor ({Name}) {Firstname} {Lasttname} Logged in");
            Console.WriteLine($"Vendor {Name} Information: \n" +
                $"{UserName} , {Id} , {Email} ,Phone {Phone} , {CityAddress} and password is secured");
            return true;
        }
        public override bool Logout()
        {
            return base.Logout();
        }
    }
}
