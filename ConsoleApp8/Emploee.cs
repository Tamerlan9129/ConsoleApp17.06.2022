using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Emploee
    {
        public string  Name { get; set; }
        public string  Surname { get; set; }

        public string Position { get; set; }

        public int Id { get; }

        private static int _id;
        public Emploee()
        {
            
        }
        public Emploee(string name,string surname,string position):this()
        {
            Name = name;
            Surname = surname;
            Position = position;
            Id = ++_id;
        }
    }
}
