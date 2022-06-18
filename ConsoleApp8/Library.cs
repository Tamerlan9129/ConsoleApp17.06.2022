using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Library
    {
        public string  Name { get; set; }

       public List<Books> books;

        public List<Emploee> emploees;
        public List<Authors> authors;

        public Library()
        {
            books = new List<Books>();
            emploees = new List<Emploee>();
            authors = new List<Authors>();
        }
    }
}
