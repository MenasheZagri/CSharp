using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp43
{
    public class Motorcycle : Vehicle
    {
        public new int _numberOfWheels;
        public new string _model;
        public int _numberOfHandBreaks;


        public Motorcycle(int numberOfWheels, string model, int numberOfHandBreaks) : base (model,numberOfWheels )
        {
            this._numberOfWheels = numberOfWheels;
            this._model = model;
            this._numberOfHandBreaks = numberOfHandBreaks;
        }

        public override void GetMaxSpeed(int num)
        {
            _maxSpeed = num;
        }

        public override void GetNumberOfPassangers(int num)
        {
            _numberOfPassangers = num;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nnumber of handbrakes {_numberOfHandBreaks}\n";
        }
    }
}
