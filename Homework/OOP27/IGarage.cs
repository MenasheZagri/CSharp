using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    interface IGarage
    {
        void AddCar(Car car);
        void RemoveCar(Car car);
        void FixCar(Car car);

    }
}
