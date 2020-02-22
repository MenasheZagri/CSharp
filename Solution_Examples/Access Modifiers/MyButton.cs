using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp50
{
    internal class MyButton
    {
        protected Point _topLeft;
        protected Point _bottomRight;
        private int _width;
        private int _height;

        internal MyButton(Point topLeft, Point bottomRight)
        {
            this._topLeft = topLeft;
            this._bottomRight = bottomRight;
        }
        
        internal int GetWidth(int width)
        {
            return width;
        }

        internal int GetHeight(int height)
        {
            return height;
        }

        internal bool SetTopLeft(Point xy) 
        {
            return true;
        }

        internal bool SetBottomRight(Point xy)
        {
            return true;
        }

        internal void GetTopLeft (Point xy)
        {

        }

        internal void GetBottomRight (Point xy)
        {

        }

        public override string ToString()
        {
            return $"width: {_width} height: {_height} topleft: {_topLeft} bottomright {_bottomRight}";
        }

    }
}
