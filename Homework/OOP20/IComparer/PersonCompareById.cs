using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class PersonCompareById: IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            if (x.Id > y.Id)
            return 1;

            if (x.Id == y.Id)
                return 0;
            else
            {
                return -1;
            }
        }
    }
}
