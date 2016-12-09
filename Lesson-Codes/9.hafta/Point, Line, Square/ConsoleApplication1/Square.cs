using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Square
    {
        public point Point1;
        public point Point2;
        public Square(point point1, point point2)
        {
            Point1 = point1;
            Point2 = point2;
        }
        public double CalculateEdge()
        {
            // double x=Math.Abs(Point1.Latitude-Point2.Latitude);
            //double y=Math.Abs(Point1.longtitude-Point2.longtitude);
            //return Math.Sqrt(x*x+y*y);

            Line line1 = new Line(Point1, Point2);
            return line1.CalculateLenght();
        }
        public double CalculateLength()
        {
            Line line1 = new Line(Point1, Point2);
            return 4 * line1.CalculateLenght();
        }
        public double CalculateArea()
        {
            Line line1 = new Line(Point1, Point2);
            return Math.Pow(line1.CalculateLenght(), 2);
        }
    }
}
