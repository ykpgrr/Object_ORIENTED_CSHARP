using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Yakup Görür 
//Istanbul Technical University Electronic and Communication Engineering
//https://github.com/ykpgrr
//https://tr.linkedin.com/in/ykpgrr

namespace midterm_calismam
{
    class Plane
    {
        public string Flight_Number { get; set; }
        public string Departure_Point { get; set; }
        public string Arrival_Point { get; set; }
        public string Flight_Date { get; set; }
        public int Ticket_Price { get; set; }
        public int Quota { get; set; }

        public Plane(string flight_Number, string departure_Point, string arrival_Point, string flight_Date, string ticket_Price, string quota) //string school = "" opsiyonelllik jkatıyo bu paramtreye
        {
            Flight_Number = flight_Number;
            Departure_Point = departure_Point;
            Arrival_Point = arrival_Point;
            Flight_Date = flight_Date;
            Ticket_Price = Convert.ToInt32(ticket_Price);
            Quota = Convert.ToInt32(quota);
        }


        internal string Serialize()
        {
            return string.Format("{0} {1} {2} {3} {4} {5}", Flight_Number, Departure_Point, Arrival_Point, Flight_Date, Ticket_Price, Quota);
        }
    }
}
