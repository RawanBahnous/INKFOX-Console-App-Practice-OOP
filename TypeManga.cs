using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class TypeManga
    {
        public int ID { get; set; }
        public string TypeName { get; set; }
        public List<Manga> Manga { get; set; }
        public TypeManga(int id, string typeName, List<Manga> manga)
        {
            ID = id;
            TypeName = typeName;
            Manga = manga;
        }

    }
}
