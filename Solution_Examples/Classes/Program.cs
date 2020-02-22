using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating new instance of a class 
            Mobile samsung = new Mobile();

            //using a constructor to insert data into the instance
            samsung._color = "Black";
            samsung._model = "Samsung 9";
            samsung._size = 6.7f;
            samsung.Ring(1);

            //a 2nd way to use a constructor
            Mobile iPhone = new Mobile()
            {
                _color = "white",
                _model = "Samsung",
                _size = 5.9f
            };
            iPhone._color = "Black";
            iPhone._model = "iPhone 6";
            iPhone.Ring(0);

            //a 3rd way to use a constructor
            Mobile nokia = new Mobile("Nokia3369", 6.7f, "green");
            nokia.Ring(0);
        }
    }
}
