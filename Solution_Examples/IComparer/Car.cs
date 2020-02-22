using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Car :IComparable<Car>
    {

        public string Model { get; protected set; }
        public int Year { get; protected set; }
        public int HorsePower { get; protected set; }

        public Car(string model, int year, int horsePower)
        {
            Model = model;
            Year = year;
            HorsePower = horsePower;
        }

        public int CompareTo(Car secondCar)
        {
            //obj = car 2 (secondCar)
            //comparing to "this" - car 1
           // Car secondCar = obj as Car;
           /*
            if (this.Year > secondCar.Year)
            {
                return 1;
            }

            if (this.Year == secondCar.Year)
            {
                return 0;
            }
            return -1;
            */

            return this.Year - secondCar.Year;
        }

        public override string ToString()
        {
            return $"Car Model: {Model,5} \tYear: {Year,5} \tHorse Power: {HorsePower,5}";
        }

    }
}
