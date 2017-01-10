using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Yakup Görür 040130052
//Istanbul Technical University Electronic and Communication Engineering
//https://github.com/ykpgrr
//https://tr.linkedin.com/in/ykpgrr
namespace midtermm_3
{
    class Person
    {

        public int ID { get; set; }
        public List<Point> Location { get; set; }



        public Person(int id, double latitude, double longtitude)
        {
            ID = id;
            var new_point = new Point(latitude, longtitude);
            Location = new List<Point>();
            Location.Add(new_point);
        }
        public Person(int id)
        {
            ID = id;
        }

        public Person()
        {
            // TODO: Complete member initialization
        }
        public bool Equals(Person other)
        {
            if (other == null) return false;
            return (this.ID.Equals(other.ID));
        }
        public override int GetHashCode()
        {
            return ID;
        }

        //public override string ToString()
        //{
        //    //return "ID: " + ID + "   latitude: " + Location.Latitude + "longtitude:" + Location.Longtitude;
        //}
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Person objAsPerson = obj as Person;
            if (objAsPerson == null) return false;
            else return Equals(objAsPerson);
        }
        public string Serialize()
        {
            string a = "";
            foreach (var p in Location)
            {
                a = a + string.Format("{0} {1} {2}", ID, p.Latitude, p.Longtitude);
            }
            return a;
        }

        internal void AddLocation(double p1, double p2)
        {
            var a = new Point(p1, p2);
            Location.Add(a);
        }
    }
}
