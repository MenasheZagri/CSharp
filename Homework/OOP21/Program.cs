using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Mazda", "6 Series", 2019, "Blue", 9242, 4);
            
            
            Car[] cars =
            {
                new Car("BMW", "4 Series", 2017, "White", 5500, 2),
                new Car("Volvo", "S60", 2016, "Silver", 2468, 5),
                new Car("Audi", "A4", 2018, "Black", 1224, 4)
            };
            
            PrintCarArray(cars);
            Console.WriteLine(cars[0].GetCodan());
            Console.WriteLine(cars[2].GetNumberOfSeats());

            car1.ChangeNumberOfSeats(6);
            Console.WriteLine(car1.GetNumberOfSeats());

            Car.SerializeACar("car1", car1);
            Car.SerializeCarArray("cars", cars);
            
            Console.WriteLine(Car.DeSerializeACar("car2"));
            PrintCarArray(Car.DeserializeCarArray("cars2"));
            
            Console.WriteLine(car1.CarCompare("car1"));
            Console.WriteLine(car1.CarCompare("car2"));
        }

        static void PrintCarArray (Car[] arrayName)
        {
            foreach (Car carElement in arrayName)
            {
                Console.WriteLine(carElement.ToString());
            }
        }
    }
}
