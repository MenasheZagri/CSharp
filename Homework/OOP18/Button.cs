using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp56
{
    internal class Button
    {
        private string _buttonName;
        protected Point _topLeft;
        protected Point _bottomRight;
        private int _width;
        private int _height;

        internal Button(string buttonName, Point topLeft, Point bottomRight)
        {
            _topLeft = topLeft;
            _bottomRight = bottomRight;
            _buttonName = buttonName;
        }


        internal int GetWidth(int width)
        {
            return _width;
        }

        internal int GetHeight(int height)
        {
            return _height;
        }

        internal bool SetTopLeft(Point topLeft)
        {
            if (topLeft.GetX() < this._bottomRight.GetX() &&
                topLeft.GetY() > this._bottomRight.GetY())
            {
                this._topLeft = topLeft;
                Console.WriteLine($"Point topLeft created successfully on {topLeft}");
                return true;
            }
            else
            {
                Console.WriteLine($"Something went wrong with creating point: {topLeft}");
                return false;
            }
        }

        internal bool SetBottomRight(Point bottomRight)
        {
            if (bottomRight.GetX() > this._topLeft.GetX() &&
                bottomRight.GetY() < this._topLeft.GetY())
            {
                this._bottomRight = bottomRight;
                Console.WriteLine($"Point bottomRight created successfully on {bottomRight}");
                return true;
            }
            else
            {
                Console.WriteLine($"Something went wrong with creating point: {bottomRight}");
                return false;
            }
        }

        internal Point GetTopLeft(Point xy)
        {
            return xy;
        }

        internal Point GetBottomRight(Point xy)
        {
            return xy;
        }

        public override string ToString()
        {
            return $"top left: {_topLeft} bottom right:{_bottomRight} ";
        }
    }
}
