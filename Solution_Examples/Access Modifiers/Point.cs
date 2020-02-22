using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp50
{
    internal class Point
    {
        private int _x;
        private int _y;

        internal Point (int x, int y)
        {
            this._x = x;
            this._y = y;
        }

        internal int GetX(int x)
        {
            return x;
        }

        internal int GetY(int y)
        {
            return y;
        }

        internal void SetX (int x)
        {

        }

        internal void SetY(int y)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
