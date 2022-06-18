using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Authors
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<Books> bookAuthors;
        public int Id { get;}
        private static int _id;
        public Authors()
        {
            
        }

        public Authors(string name,string surname):this()
        {
            Name = name;
            Surname = surname;
            bookAuthors = new List<Books>();
            Id = ++_id;
        }
    }
}
