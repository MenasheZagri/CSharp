using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Xml;

namespace ConsoleApp63
{
    class Program
    {
        static void Main(string[] args)
        {

            SimpleCalculator simple = new SimpleCalculator();
            AtomicCalculator atomic = new AtomicCalculator();
            atomic.Calculate = simple.Calculate;
            atomic.GetNumberFromUser = simple.NumberGetter;
            atomic.GetUserChoice = simple.GetUserChoice;
            atomic.MenuPrinter = simple.PrintMenu;
            atomic.ResultPrinter = simple.PrintResultNicely;
            atomic.RunAgain = simple.RunAnother;
            atomic.Run();
        } 
    } 
}
