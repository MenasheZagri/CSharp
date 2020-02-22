using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    public class Circle
    {
        // the below might be changed by the instance
        public double _radius;

        // the below will be implemented for any and all instances
        public static double dollar = 5;

        // the below will now allow any change of the value
        public const double pie = 3.14;
        public Circle (double radius)
        {
            _radius = radius;
        }

        public override string ToString()
        {
            return $"Circle {_radius}";
        }

        //allows calling a static data from outside the class
        public static void PrintPie()
        {
            Console.WriteLine(Circle.pie);
        }



    }
}
