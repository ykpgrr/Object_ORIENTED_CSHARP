using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class point
    {
        public double Latitude;//{ get; set; }// enlem

        public double longtitude { get; set; } // boylam
        public point()
        {
            Latitude=15;
            longtitude=0;
        }
        public point(double lat, double lon)
        {
            Latitude = lat;
            longtitude = lon;
        }
        public bool isatnorthof(point anotherPoint)
        {
            if (this.Latitude > anotherPoint.Latitude)
                return true;
            return false;
        }
        public bool isequal(point anotherPoint)
        {
            if (this.Latitude == anotherPoint.Latitude && this.longtitude==anotherPoint.longtitude )
                return true;
            return false;
        }
    }

}
