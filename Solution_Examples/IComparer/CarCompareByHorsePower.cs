using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class CarCompareByHorsePower: IComparer<Car>

    {
        public int Compare(Car x, Car y)
        {
            return -1 * (x.HorsePower - y.HorsePower);
        }
    }
}
