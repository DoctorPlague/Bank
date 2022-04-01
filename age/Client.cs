using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Client
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string MiddleName{ get;set; }
        public Client(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
        public Client(string name, string surname, string middleName)
            : this(name, surname)
        {
            MiddleName = middleName;
        }
    }
}
