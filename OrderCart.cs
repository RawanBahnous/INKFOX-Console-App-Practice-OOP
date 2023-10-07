using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class OrderCart
    {
        public int OrderId { get; set;}
        public List<Manga> Mangas { get; set;}
        public Customer Customer { get; set;}
        public int TotalPrice { get; set;}

        public bool Speacial { get; set;} = false;

        public OrderCart(int orderId, List<Manga> mangas, Customer customer, int totalPrice,bool speacial)
        {
            OrderId = orderId;
            Mangas = mangas;
            Customer = customer;
            TotalPrice = totalPrice;
            Speacial = speacial;
        }

        public void MakeOrder()
        {
            Console.WriteLine($"Order ID: {OrderId}");
            Console.WriteLine("Ordered Mangas:");
            foreach (var manga in Mangas)
            {
                Console.WriteLine($"{manga.Type.TypeName} , {manga.Name} , {manga.Price}");
                TotalPrice += manga.Price;
            }
            Console.WriteLine($"Total Price : {TotalPrice} , Is Special Order? {Speacial}");
            Console.WriteLine($"Customer Data : {Customer.Firstname} ,{Customer.Lasttname},{Customer.CityAddress} , Is Special Order? {Speacial}");

        }
    }
}
