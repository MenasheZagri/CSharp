using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp63
{
    class AtomicCalculator
    {
        public int x { get; private set; }
        public int y { get; private set; }
        public int z { get; private set; }
        public double result;


        public Func<int> GetNumberFromUser { get; set; }
        public Action MenuPrinter { get; set; }

        public Func<int> GetUserChoice { get; set; }
        public Func<int,int,int,double> Calculate { get; set; }
        public Action<double> ResultPrinter { get; set; }
        public Func<bool> RunAgain { get; set; }

        public void Run()
        {
            this.x = GetNumberFromUser();
            this.y = GetNumberFromUser();
            MenuPrinter();
            this.z = GetUserChoice();
            result = Calculate(this.x, this.y, this.z);
            ResultPrinter(result);

            if (RunAgain()==true)
            { Run();}
            
        }
    }
}
