using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Books
    {
        public string Name { get; set; }

        public string Genre { get; set; }

        public string Language { get; set; }
        public int Id { get; }

        private static int _id;
        public List<Authors> authors;

        public Books()
        {
            
        }
        public Books(string name, string genre, string language) : this()
        {
            Name = name;
            Genre = genre;
            Language = language;
            Id = ++_id;
            authors = new List<Authors>();
        }
    }
}
