using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {

            Garage merkaz = new Garage(new List<Car>());
            Car mazda3 = new Car("Mazda", false, true);
            Car toyota = new Car("Toyota", false, true);
            merkaz.AddCar(mazda3);
            foreach (var VARIABLE in merkaz)
            {
                Console.WriteLine(VARIABLE);
            }

        }
    }
}
