using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            AsyncPrinter printer = new AsyncPrinter();
            List<Thread> threads = new List<Thread>();
            int loopValue = 10;

            for (int i = 0; i <loopValue ; i++)
            {
                Thread thread = new Thread(() => printer.CheckPrint());
                thread.Start();
                for (int j = 0; j <= 100; j++)
                {
                  //  Console.Write("Counting: ");
                    Console.Write(string.Format("{0}", j));
                    Console.Write("\r".PadLeft(Console.WindowWidth - Console.CursorLeft - 1));
                    Thread.Sleep(6);
                }
                Console.WriteLine("");
            }

            
            for (int i = 0; i < loopValue+100; i++)
            {
                Thread printThread = new Thread(() => printer.AddContent(Convert.ToString(DateTime.Now)));
                printThread.Start();
                for (int j = 0; j <= 150; j++)
                {
                   // Console.Write("Counting: ");
                    Console.Write(string.Format("{0}", j));
                    Console.Write("\r".PadLeft(Console.WindowWidth - Console.CursorLeft - 1));
                    Thread.Sleep(6);
                }
                Console.WriteLine("");
            }
        }
    }
}
