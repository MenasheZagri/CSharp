using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintShapeArea(new BigCircle());
            Console.WriteLine(new Elipse());

        }

        static void foo(IGoodCode goodCode)
        {

        }

        static void PrintShapeArea(IAreaCalculator ac)
        {
            Console.WriteLine(ac.GetArea());
            Console.WriteLine(ac.GetType());

            if (ac is BigCircle)
            {
                BigCircle c = ac as BigCircle;
                Console.WriteLine(c.Radius);
            }
        }
    }

}
