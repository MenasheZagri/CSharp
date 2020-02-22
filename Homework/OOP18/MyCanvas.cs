using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp56
{
    public class MyCanvas
    {
        public const int MaxWidth = 800;
        public const int MaxHeight = 600;
        private static int buttonIndex = 0;
        private static Button[] buttons = new Button[MaxButtons];
        private static int MaxButtons = 3;

        public static bool CreateNewButton(int x1, int x2, int y1, int y2)
        {
            if (buttonIndex < MaxButtons)
            {
                Point topLeft = new Point(x1, y1);
                Point bottomRight =new Point(x2, y2);
                buttonIndex++;
                Console.WriteLine($"Button was creates successfully in button index:{buttonIndex}.");
                return true;
            }

            else
            {
                Console.WriteLine("Button array is full");
                return false;
            }
        }

        public static bool MoveButton(int buttonIndex, int x, int y)
        {
            foreach (var button in buttons)
            {
                
            }
            return true;
        }

        public static bool DeleteLastButton()
        {
            buttons = buttons.Where(i => i != buttons[buttonIndex]).ToArray();
            return true;
        }

        public static void ClearAllButtons()
        {
            buttonIndex = 0;
            for (int i = 0; i < buttonIndex; i++)
            {
                buttons[i] = null;
                i++;
            }
            Console.WriteLine($"Button array is cleared (button index: {buttonIndex})");
        }

        public static int GetCurrentNumberOfButtons()
        {
            int currentNumberOfButtons = 0;
            for (int j = 0; j < buttonIndex; j++)
            {
                currentNumberOfButtons++;
            }
            return currentNumberOfButtons;
        }

        public static int GetMaxNumberOfButtons(int num)
        {
            return num;
        }

        public static int GetMaxWidthOfAButton(int num)
        {
            return num;
        }

        public static int GetMaxHeightOfAButton(int num)
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
            return $"button array: {buttons}";
        }
    }
}
