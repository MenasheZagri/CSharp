﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class PersonCompareByAge : IComparer<Person>
    {
        public int Compare(Person x,Person y)
        {
            return x.Age - y.Age;
        }
    }
}
