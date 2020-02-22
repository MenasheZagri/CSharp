using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class ThreadExecutor
    {

        Queue<Thread> _threadsQueue = new Queue<Thread>();
        public void Add(Thread thread)
        {
            lock (this)
            {
                Console.WriteLine("New Thread in queue " + thread.ThreadState);
                if (thread != null)
                {
                    _threadsQueue.Enqueue(thread);
                }
            }
        }

        public void Execute()
        {
            lock (this)
            {
                if (_threadsQueue != null)
                    while (_threadsQueue.Count > 0)
                    {
                        Thread currentThread = _threadsQueue.Dequeue();
                        currentThread.Start();
                    }
            }

        }
    }
}
