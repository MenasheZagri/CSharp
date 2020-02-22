using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApp42
{
    [DebuggerDisplay("{_model} {_price}")]
    class Computer
    {
        #region Data
        public string _model;
        public int _price;
        public int _numberOfProcessors;
        public float _screenSize;
        public bool _isTurnedOn;
        #endregion

        #region Constructors
        public Computer()
        { }


        public Computer(string model, int price, int numberOfProcessors, float screenSize, bool isTurnedOn)
        {
            this._model = model;
            this._price = price;
            this._numberOfProcessors = numberOfProcessors;
            this._screenSize = screenSize;
            this._isTurnedOn = isTurnedOn;
        }
        #endregion

        #region Functions

        public void tellMeThePrice()
        {
            Console.WriteLine($"The {_model} costs {_price}$");
        }

        public void tellMeTheScreenSize()
        {
            Console.WriteLine($"{_model} screen size is {_screenSize}");
        }

        public string turnOn(string model)
        {
            _isTurnedOn = true;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"{this._model} is turned ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("on...");
            Console.ForegroundColor = ConsoleColor.White;
            return model;
        }

        public string turnOff(string model)
        {
            _isTurnedOn = false;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"{this._model} is turned ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("off...");
            Console.ForegroundColor = ConsoleColor.White;
            return model;
        }

        public void addProcessor()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Current number of processors = {_numberOfProcessors}, adding 1 more");
            _numberOfProcessors++;
            Console.Write($"{_model} now has ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"{_numberOfProcessors} processors");
        }
        #endregion
        public override string ToString()
        {
            return "To String Test";
        }

    }
}
