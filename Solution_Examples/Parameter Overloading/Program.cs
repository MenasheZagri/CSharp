using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp57
{
    class Program
    {
        static void Main(string[] args)
        {
            Point a = null;
            Point b = new Point(5,11);
            Point c = a + b;
            
            if (a == b)
            {
                Console.WriteLine("ok");
            }

            else
            {
                Console.WriteLine("not ok");
            }
        }
    }
}
