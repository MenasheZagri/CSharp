
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Car honda = new Car("Civic", 2017, 1800);
            Car suzuki = new Car("Baleno", 2006, 1400);
            Car mitsubishi = new Car("Lancer", 2008, 2000);

            Car[] cars = {honda, suzuki, mitsubishi};
            PrintCars(cars);
            CarCompareByHorsePower compareByHorsePower = new CarCompareByHorsePower();
            Array.Sort(cars, compareByHorsePower);
            PrintCars(cars);
        }

        static void PrintCars(Car[] cars)
        {
            foreach (Car carName in cars)
            {
                Console.WriteLine(carName);
            }
        }
    }
}
