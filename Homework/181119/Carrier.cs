using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp43
{
    public class Carrier
    {
        Vehicle[] vehicle = new Vehicle[2];
        
        public override string ToString()
        {
            return $"{vehicle}";
        }
    }
}
