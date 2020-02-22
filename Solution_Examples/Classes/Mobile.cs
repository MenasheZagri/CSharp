using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Mobile
    {
        //DATA
        public string _model;
        public float _size;
        public string _color;


        /// <summary>
        /// This function calls
        /// </summary>
        /// <param name="x">this accept number</param>
        //FUNCTIONALITY
        public float Ring(int x)
        {
            Console.WriteLine($"{this._model} is Ringing...");
            return 0;
        }

        public void Call()
        {
            Console.WriteLine("Calling...");

        }

        public void TurnOn()
        {
            Console.WriteLine("Turning on...");
        }
        public Mobile ()
        {

        }

        public Mobile (string _model, float _size, string _color)
        {
            this._model = _model;
            this._size = _size;
            this._color = _color;
        }

    }
}
