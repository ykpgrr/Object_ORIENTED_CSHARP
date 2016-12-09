using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public CardTypes CardType { get; set; }
        public string School { get; set; }

        public User(string firstname, string lastName, CardTypes cardType, string school = "") //string school = "" opsiyonelllik jkatıyo bu paramtreye
        {
            FirstName = firstname;
            LastName = lastName;
            CardType = cardType;
            School = school;
        }
        public string Serialize()
        {
            return string.Format("{0} {1} {2} {3}", FirstName, LastName, CardType, School);
        }
    }
}
