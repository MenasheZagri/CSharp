using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp56
{
    internal class Point
    {
        private int _x;
        private int _y;

        internal Point(int x, int y)
        {
            _x = x;
            _y = y;
        }

        internal int GetX()
        {
            return _x;
        }

        internal int GetY()
        {
            return _y;
        }

        internal void SetX(int x)
        {
            if (x < 0 || x > MyCanvas.MaxWidth)
            {
                Console.WriteLine($"the value {x} is invalid");
            }
            else
            {
                _x = x;
                Console.WriteLine($"the value {x} has been set");
            }
        }

        internal void SetY(int y)
        {
            if (y < 0 || y > MyCanvas.MaxHeight)
            {
                Console.WriteLine($"the value {y} is invalid");
            }
            else
            {
                _y = y;
                Console.WriteLine($"the value {y} has been set");
            }
        }

        public override string ToString()
        {
            return $"x is {_x} and y is {_y}";
        }
    }
}
