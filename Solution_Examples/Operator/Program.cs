﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(3, 5);
            Point p2 = new Point(2.5, 7);
            Point p3 = p1 + p2;
            Console.WriteLine(p3);
        }
    }
}
