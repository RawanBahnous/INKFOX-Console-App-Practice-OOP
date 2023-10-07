using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello in INKFOX website\n\n");

            Admin admin1 = new Admin(1,"rawan","1233","ron@mail.com","RonOnaBoat");


            //bool Loggedin = admin1.Login();
            //bool logout = admin1.Logout();

            //if (Loggedin)
            //{
            //    admin1.Logout();
            //}
            //else
            //{
            //    Console.WriteLine("he did not logged in");
            //}
            //int counter = 1;

            User[] users = new User[6];

            users[0] = new Admin(2, "John", "password1", "john@example.com", "JohnDoe");
            users[1] = new Admin(3, "Alice", "password2", "alice@example.com", "AliceSmith");
            users[2] = admin1;

            users[3] = new Customer(1, "John", "John", "Jou", "Cairo", "0123456", "password1", "john@example.com", "JohnDoe");
            users[4] = new Customer(2, "Nada", "Nada", "Mohammed", "Cairo", "0123456", "password1", "john@example.com", "JohnDoe");
            Customer mayar = new Customer(2, "mayar", "mayar", "hassan", "Cairo", "0123456", "password1", "john@example.com", "JohnDoe");
            users[5] = mayar;
            foreach (var user in users)
            {
                //Console.WriteLine(counter++);
                Console.WriteLine($"{user.Login()} \n");
            }

            // add manga list 

            List<TypeManga> Types = new List<TypeManga>();
            TypeManga type1 = new TypeManga(1, "Shonen", new List<Manga>());
            TypeManga type2 = new TypeManga(2, "Seinen", new List<Manga>());
            Types.Add(type1);
            Types.Add(type2);


            List<Manga> mangas= new List<Manga>();
            Manga Naruto = new Manga(1, "Naruto", "A ninja's journey", 20, "naruto.jpg", type1);
            Manga OnePiece = new Manga(2, "One Piece", "Adventure on the high seas", 25, "naruto.jpg", type1);
            Manga manga3 = new Manga(3, "Berserk", "Dark fantasy", 30, "berserk.jpg", type2);
            Manga manga4 = new Manga(4, "Attack on Titan", "Humanity's fight for survival", 28, "aot.jpg", type2);
            mangas.Add(Naruto);
            mangas.Add(OnePiece);
            mangas.Add(manga3);
            mangas.Add(manga4);


            foreach (var manga in mangas) {
                manga.AddMange();
            }

            //print the order or make order

            Console.WriteLine("Order Information:");
            Console.WriteLine("------------------");

            OrderCart newOrder = new OrderCart(1, new List<Manga>() { Naruto , manga4}, mayar, 1500, false);

            newOrder.MakeOrder();

            //check payment 
            Console.WriteLine("\n\nPayment Information:");
            Console.WriteLine("------------------");

            Payment payment = new Payment(1, newOrder, false);
            payment.ProcessPayment();
            payment.PrintBill();
        }
    }
}
