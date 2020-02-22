using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp56
{
    class Program
    {
        static void Main(string[] args)
        {
            Button button1 = new Button ("Go",new Point(3,4), new Point(2,6));
            Point button2 = new Point((9), 15);
            MyCanvas.CreateNewButton(1, 5, 3, 9);
            MyCanvas.CreateNewButton(1, 5, 3, 9);
            MyCanvas.CreateNewButton(1, 5, 3, 9);
            MyCanvas.CreateNewButton(1, 5, 3, 9);
            MyCanvas.ClearAllButtons();
            MyCanvas.CreateNewButton(1, 5, 3, 9);
            MyCanvas.CreateNewButton(1, 5, 3, 9);
            Console.WriteLine($"Current number of buttons: {MyCanvas.GetCurrentNumberOfButtons()}");
            MyCanvas.ClearAllButtons();
            Console.WriteLine($"Current number of buttons: {MyCanvas.GetCurrentNumberOfButtons()}");
            MyCanvas.CreateNewButton(1, 5, 3, 9);
            MyCanvas.CreateNewButton(1, 5, 3, 9);
            MyCanvas.CreateNewButton(1, 5, 3, 9);
            Console.WriteLine($"Current number of buttons: {MyCanvas.GetCurrentNumberOfButtons()}");
            MyCanvas.DeleteLastButton();
            Console.WriteLine($"Current number of buttons: {MyCanvas.GetCurrentNumberOfButtons()}");
        }
    }
}
