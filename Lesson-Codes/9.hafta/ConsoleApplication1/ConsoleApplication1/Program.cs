using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
             point point1= new point(11.0,20);
             point point2 = new point(13,43);

            Console.WriteLine("isatnortof: "+ point1.isatnorthof(point2));
           
            Line line1 = new Line(point1, point1);
            Line line2 = new Line(point1, point2);

            Console.WriteLine("is line1:{0} and lenght: {1}", line1.IsLine(), line1.CalculateLenght());
            Console.WriteLine("is line2:{0} and lenght: {1}", line2.IsLine(), line2.CalculateLenght());
            Console.WriteLine();

            Square square = new Square(point1, point2);
            Console.WriteLine("Square's length :{0} and Area: {1}", square.CalculateLength(), square.CalculateArea());
            Console.WriteLine();
            finish();
        }

        private static void finish()
        {
            Console.ReadKey();
        }
      
    }
}
