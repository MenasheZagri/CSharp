using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp43
{
    public class Car : Vehicle
    {
        public new int _numberOfWheels;
        public new string _model;
        public int _numberOfDoors;
        public Car (int numberOfWheels, string model, int numberOfDoors) : base (model,  numberOfWheels)
        {
            this._model = model;
            this._numberOfDoors = numberOfDoors;
            this._numberOfWheels = numberOfWheels;
        }

        public override void GetNumberOfPassangers(int num)
        {
            _numberOfPassangers = num;
        }

        public override void GetMaxSpeed(int num)
        {
            _maxSpeed = num;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nNumber of doors: {_numberOfDoors}\n";
        }
    }
}
