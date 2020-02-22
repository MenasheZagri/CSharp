using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    //Marker interface (contract of abilities)
    interface IOldCode
    {
    }

    interface IGoodCode
    {
    }

    interface IAreaCalculator
    {
        double GetArea(); // public abstract
        int MyProperty { get; set; }
    }

    abstract class Shape
    {
        public abstract void do1();
    }

    abstract class Circle : Shape, IOldCode, IGoodCode, IAreaCalculator
    {
        public abstract double GetArea();
        public abstract int MyProperty2 { get; set; }
        public int MyProperty { get; set; }
    }

    class BigCircle : Circle
    {
        public override int MyProperty2 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void do1()
        {
            Console.WriteLine();
        }
        public override double GetArea()
        {
            return 10;
        }

        public double Radius { get; set; }
    }

    class Elipse : IAreaCalculator
    {
        public double GetArea()
        {
            throw new NotImplementedException();
        }

        public int MyProperty { get; set; }
    }
}
