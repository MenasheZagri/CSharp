using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
    class Point
    {
        public double X { get; protected set; }
        public double Y { get; protected set; }

        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        //the following is defined per type and not per specific function

            public static Point operator + (Point p1, Point p2)
        {
            Point result = new Point(p1.X + p2.X, p1.Y + p2.Y);
            return result;
        }

        public override string ToString()
        {
            return $"this x is: {X}\nthis Y is: {Y}";
        }


    }
}
