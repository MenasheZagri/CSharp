using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual
{
    public class TraingleEqual : TraingleBase
    {
        public TraingleEqual (int a, int c) : base (a,a,c)
        {

        }

        public override int CalcHekef()
        {
            return _a + 2 + _c;
        }

    }
}
