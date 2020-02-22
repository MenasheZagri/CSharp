using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual
{
    public class TraingleBase
    {
        public string _name;
        public int _a, _b, _c;


        public TraingleBase(int a, int b, int c)

        { 
            _a = a;
            _b = b;
            _c = c;

        }

        public virtual int CalcHekef()
        {
            return _a + _b + _c;
        }

        public override string ToString()
        {
            return $"Traingle a: {_a} b: {_b} c: {_c}";            
        }
    }
}
