using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp50
{
    public class MyCanvas
    {
        public const int MaxWidth = 800;
        public const int MaxHeight = 600;
        private static int buttonIndex = 0;
        private static Array[] button = new Array[MaxButtons];
        private static int MaxButtons = 3;

        public static bool CreateNewBottun(int x1, int y1, int x2, int y2)
        {
            return true;
        }

        public static bool MoveButton(int buttonNumber, int x, int y)
        {
            return true;
        }

        public static bool DeleteLastButton()
        {
            return true;
        }

        public static void ClearAllButtons()
        {

        }

        public static int GetCurrentNumberOfButtons (int num)
        {
            return num;
        }

        public static int GetMaxNumberOfButtons (int num)
        {
            return num;
        }

        public static int GetTheMaxWidthOfButton (int num)
        {
            return num;
        }

        public static int GetTheMaxHeightOfButton (int num)
        {
            return num;
        }

        public static bool IsPointInsideAButton(int x, int y)
        {
            return true;
        }

        public static bool CheckIfAnyButtonIsOverlapping()
        {
            return true;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
