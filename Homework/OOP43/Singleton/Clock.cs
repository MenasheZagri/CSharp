using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Clock
    {
        private static Clock _clockInstance;
        private static object key = new object();

        public static Clock GetClockInstance()
        {
            lock (key)
            {
                if (_clockInstance == null)
                {
                    _clockInstance = new Clock();
                }

                return _clockInstance;
            }
        }
        public void GetTime()
        {
            Console.WriteLine("Time in Israel: " + DateTime.Now);
        }
    }
}
