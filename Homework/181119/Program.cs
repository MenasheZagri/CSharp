using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp43
{
    class Program
    {
        static void PrintVehicle(Car car)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("PrintVehicle:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(car._model + "\n");
        }

        static void Main(string[] args)
        {
            Car Toyota = new Car(4, "Toyota Corolla", 5);
            Car BMW = new Car(4, "BMW Series 4", 2);
            Motorcycle Honda = new Motorcycle(2, "Honda CBR600", 2);
            Motorcycle Yamaha = new Motorcycle(2, "Yamaha Yamamoto", 1);

            Toyota.GetMaxSpeed(220);
            Toyota.GetNumberOfPassangers(4);
            BMW.GetMaxSpeed(280);
            BMW.GetNumberOfPassangers(2);
            Honda.GetMaxSpeed(300);
            Honda.GetNumberOfPassangers(2);
            Yamaha.GetMaxSpeed(666);
            Yamaha.GetNumberOfPassangers(2);

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Normal:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(Toyota.ToString());
            Console.WriteLine(Honda.ToString());

            PrintVehicle(Toyota);

            Vehicle[] vehicles = new Vehicle[3];
            vehicles[0] = Honda;
            vehicles[1] = BMW;
            vehicles[2] = Toyota;

            for (int i = 0; i < vehicles.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Array_element " + i +":");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(vehicles[i].ToString());
            }
        }

    }
}
