using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp59
{
    public class Mobile
    {
        public int year;
        public string name;
        public float cpu;

        public Mobile(int year, string name, float cpu)
        {
            this.year = year;
            this.name = name;
            this.cpu = cpu;
        }

        public override string ToString()
        {
            return $"year: {year} name: {name} cpu: {cpu}";
        }
    }

    class MobileCompareByYear : IComparer<Mobile>
    {
        public int Compare(Mobile x, Mobile y)
        {
            return x.year - y.year;
        }
    }
}
