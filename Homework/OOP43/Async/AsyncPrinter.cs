using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class AsyncPrinter
    {

        private Queue<string> content;
        static object key = new object();


        public AsyncPrinter()
        {
            content = new Queue<string>();
        }

        public void AddContent(string singleContent)
        {
            lock (this)
            {
                Console.WriteLine("content added");
                content.Enqueue(singleContent);
                Console.WriteLine($"Content is: {singleContent}");
                Monitor.Pulse(this);
            }
        }

        public void CheckPrint()
        {
            Console.WriteLine("CheckPrint method called");
            lock (key)
            {
                while (content.Count==0)
                {
                    Console.WriteLine("Waiting");
                    Monitor.Wait(key);
                }
                Console.WriteLine(content.Dequeue());
            }
        }
    }
}
