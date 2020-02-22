using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual
{
    class Program
    {
        /*
            Abstract - a function that does not have an implementation
            but the inheritant children must implement.

            Virtual - a function that is implemented but can be overriden
            by the children.
        
            Normal - a function that children cannot change
        */
        static void Main(string[] args)
        {
            TraingleEqual te = new TraingleEqual(4,5);
            Console.WriteLine(te.CalcHekef());

            TraingleAllEqual allEqual = new TraingleAllEqual(7);
            Console.WriteLine(allEqual.CalcHekef());
        }
    }
}
