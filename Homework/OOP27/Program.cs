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
            Car ford = new Car("Ford", false, false);

            try
            {
                merkaz.AddCar(mazda3);
                merkaz.AddCar(ford);
                merkaz.AddCar(toyota);
                merkaz.FixCar(mazda3);
                merkaz.RemoveCar(mazda3);
                merkaz.FixCar(ford);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
