using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Manga
    {
        internal int Id { get; set; }
        internal string Name { get; set; }
        internal string Description { get; set; }
        internal int Price { get; set; }
        internal string MangaImg { get; set; }
        public TypeManga Type { get; set; }

        public Manga(int id, string name, string description, int price, string mangaImg, TypeManga type)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            MangaImg = mangaImg;
            Type = type;
        }

        public void AddMange()
        {
            Console.WriteLine($"Your Manga Added as Follows \n" +
                $"Manga Number {Id} , Mnaga Name: {Name}\n" +
                $"Description:{Description} ,Price: {Price}\n" +
                $"Manga Type: {Type.TypeName} \n \n");
        }

    }
}
