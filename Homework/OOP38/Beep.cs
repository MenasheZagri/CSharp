using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp66
{
    public static class Beep
    {
        public static bool _mute { get; set; }

        public static void BeeperLevelUp()
        {
            if (_mute == false)
            {
                Random random = new Random();
                int freq, duration;
                freq = 900;
                for (int i = 0; i < 15; i++)
                {
                    duration = random.Next(20, 110);
                    Console.Beep(freq, duration);
                    i++;
                    freq = freq + random.Next(100, 600);
                }
            }
        }

        public static void BeeperBadShipExploded()
        {
            if (_mute == false)
            {
                Random random = new Random();
                int freq, duration;
                freq = 2500;
                for (int i = 0; i < 10; i++)
                {
                    duration = random.Next(20, 110);
                    Console.Beep(freq, duration);
                    i++;
                    freq = freq - random.Next(50, 400);
                }
            }
        }

        public static void BeeperMovement()
        {
            if (_mute == false)
            {
                Console.Beep(1000, 50);
                Console.Beep(1100, 150);
            }
        }

        public static void BeeperPointDown()
        {
            if (_mute == false)
            {
                Console.Beep(700, 100);
                Console.Beep(650, 100);
            }
        }

        public static void BeeperGoodShipDestroyed()
        {

            if (_mute == false)
            {
                Console.Beep(1500, 140);
                Console.Beep(1800, 20);
                Console.Beep(900, 140);
                Console.Beep(900, 90);
            }
        }
    }
}
