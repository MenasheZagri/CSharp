using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(7.555);
            Circle c2 = new Circle(9.855);
            Circle c3 = new Circle(2.1);

            Console.WriteLine(c1._radius);
            Console.WriteLine(Circle.dollar);
            //Circle.pie = 4;
            Circle.PrintPie();

        }
    }
}
