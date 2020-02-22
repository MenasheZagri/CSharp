using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual
{
    public class TraingleAllEqual : TraingleBase
    {
        public TraingleAllEqual(int a): base (a,a,a)
        {

        }
        public override int CalcHekef()
        {
          return  _a *3;
        }

    }
}
