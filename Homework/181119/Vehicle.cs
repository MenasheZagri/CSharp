using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp43
{
    public abstract class Vehicle
    {
        public int _numberOfWheels;
        public string _model;
        public int _numberOfPassangers;
        public int _maxSpeed;

        public Vehicle(string model, int numberOfWheels) 
        {
            this._model = model;
            this._numberOfWheels = numberOfWheels;
        }

        public abstract void GetNumberOfPassangers(int num);

        public abstract void GetMaxSpeed(int num);

        public override string ToString()
        {
            return $"Vehicle model is: {_model}\nNumber of wheels: {_numberOfWheels}\n" +
                $"It can carry: {_numberOfPassangers} passangers,\nIt's top speed is: {_maxSpeed} Km/h.";
        }

    }
}
