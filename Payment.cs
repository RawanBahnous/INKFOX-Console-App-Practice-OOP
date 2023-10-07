using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Payment
    {
        internal int Id { get; set; }

        internal OrderCart Cart { get; set; }

        internal bool Status { get; set; } 
        public Payment(int id,OrderCart order , bool status) 
        {
            Id = id;
            Cart= order;
            Status = status;
        }

        public bool ProcessPayment() {
            Status = true;
            return Status;
        }

        public void PrintBill() {

            Console.WriteLine($"Payment / Bill Information: \n\n" +
                $"{Id} , Customer Name{Cart.Customer.Firstname} {Cart.Customer.Lasttname} \n" +
                $"{Cart.Customer.CityAddress} ,Phone Number {Cart.Customer.Phone}\n");

            foreach (var manga in Cart.Mangas)
            {
                Console.WriteLine("Manga List Information:\n");
                Console.WriteLine($"{manga.Id},Name: {manga.Name} ,Type {manga.Type.TypeName}");
            }
            Console.WriteLine("Your oredr Will coming Soon");

        }

    }
}
