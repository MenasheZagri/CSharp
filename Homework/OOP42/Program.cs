using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;

namespace ConsoleApp3
{
    class Program
    {
        static Stopwatch sw = new Stopwatch();
        static void Main(string[] args)
        {
            ThreadExecutor executor = new ThreadExecutor();

            
            for (int i = 0; i < 5; i++)
            {
                executor.Add(new Thread(PrintCount));
                executor.Execute();
                executor.Add(new Thread(PrintHello));
                executor.Execute();
            }
            
            executor.Add(new Thread(PrintCount));
            executor.Execute();


        }

        static void PrintHello()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Beep(440,50);
                Console.WriteLine("Hellow World!");
                Thread.Sleep(250);
            }
        }

        static void PrintCount()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Beep(659, 50);
                Console.Write(i +", ");
                Thread.Sleep(500);
            }
            Console.WriteLine();
        }
    }
}
