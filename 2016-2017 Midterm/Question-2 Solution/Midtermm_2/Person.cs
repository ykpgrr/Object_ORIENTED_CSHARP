using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midtermm_2
{
    class Person
    {
        
        public string Not { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Telno { get; set; }
        public int Ticket_Price { get; set; }
        public int Quota { get; set; }

        public Person(string name, string surname, string telno)
        {
            Name = name;
            Surname = surname;
            Telno = telno;
        }


        internal string Serialize()
        {
            return string.Format("{0} {1} {2}", Name, Surname, Telno);
        }
    }
}
