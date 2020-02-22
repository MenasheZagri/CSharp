using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual
{
    public class TraingleEqualSidesWith90Angle: TraingleEqual
    {
        
        public TraingleEqualSidesWith90Angle(int a, int c) : base (a,c)
        {

        }
        public override int CalcHekef()
        {
            return _a * _c;
        }

    }
}
