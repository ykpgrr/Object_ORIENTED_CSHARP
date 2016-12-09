using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Line
    {
        public point Point1 { get; set; }
        public point Point2 { get; set; }
        public Line(point point1, point point2)
        {
            Point1 = point1;
            Point2 = point2;
        }
        public double CalculateLenght()
        {
            double x = Math.Abs(Point1.Latitude - Point2.Latitude);
            double y = Math.Abs(Point1.longtitude - Point2.longtitude);
            return Math.Sqrt(x * x + y * y);
        }
        public bool IsLine()
        {
            if (Point1.isequal(Point2))
                return false;
            return true;

        }
    }
}
