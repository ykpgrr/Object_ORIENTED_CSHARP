using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Yakup Görür 040130052
//Istanbul Technical University Electronic and Communication Engineering
//https://github.com/ykpgrr
//https://tr.linkedin.com/in/ykpgrr
namespace midtermm_3
{
    class Point
    {

        public double Latitude;//{ get; set; }// enlem

        public double Longtitude { get; set; } // boylam
        public String PlaceName;
        public Point()
        {
            Latitude = 0;
            Longtitude = 0;
            PlaceName = null;
        }

        public Point(double lat, double lon, string name = " ")
        {
            Latitude = lat;
            Longtitude = lon;
            PlaceName = name;
        }



        public bool isequal(Point anotherPoint)
        {
            if (this.Latitude == anotherPoint.Latitude && this.Longtitude == anotherPoint.Longtitude)
                return true;
            return false;
        }

        public string Serialize()
        {
            return string.Format("{0} {1} {2}", Convert.ToString(Latitude), Convert.ToString(Longtitude), PlaceName);
        }

        //public bool isatnorthof(Point anotherPoint)
        //{
        //    if (this.Latitude > anotherPoint.Latitude)
        //        return true;
        //    return false;
        //}
    }
}
