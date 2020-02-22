using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
             Car honda = new Car("Honda", "Red", "Airbag Sensor Replacement", 85000);
             Car mazda = new Car("Mazda", "Black", "Oil Change", 100000);
             Car ford = new Car("Ford", "White", "Collateral Damage", 135000);
             Car toyota = new Car("Toyota", "Blue", "Chassis Damage", 90000);
             Car audi = new Car("Audi", "Black", "Replace Engine", 190000);
             Bike suzuki = new Bike("Suzuki","Red","Tire Change",15000,"OilBased");

             //Since garage class is generic, declare it's object type (from class) during instance
             Garage<Car> garage = new Garage<Car>();
             Garage<Bike> garage2 = new Garage<Bike>();

             Console.WriteLine(honda["Treatment"]);
             honda["Color"] = "Green";
             Console.WriteLine(honda["Color"]);

            garage.AddLight(honda);
            garage.AddLight(mazda);
            garage.AddHeavy(ford);
            garage.AddHeavy(toyota);
            garage.AddHeavy(audi);
            garage2.AddLight(suzuki);

            Console.WriteLine(garage[1]);
            Console.WriteLine(garage2[0]);

            //Calling INumerator to print all cars in the list
            foreach (Car car in garage)
            {
                Console.WriteLine(car);
            }

            foreach (Bike bike in garage2)
            {
                Console.WriteLine(bike);
            }
        }
    }
}
