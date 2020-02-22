using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp66
{
    class GameViewer
    {
        public void GoodSpaceShipHPChangedEventHandler(object sender, PointsEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine($"\t\tThe ship has been hit by {sender}");
            Console.WriteLine($"\t\tThe ship points are now {e.points} \n");
            Console.ResetColor();
            Beep.BeeperPointDown();
            Delay();
        }

        public void GoodSpaceShipLocationChangedEventHandler(object sender, LocationEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine($"\t\tThe ship has been moved by {sender}");
            Console.WriteLine($"\t\tThe ship is now at {e.x} and {e.y} \n");
            Console.ResetColor();
            Beep.BeeperMovement();
            Delay();
        }

        public void GoodSpaceShipDestroyedEventHandler (object sender, LocationEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Good spaceship destroyed - Game Over!");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine($"\t\tThe ship has been destroyed by {sender}");
            Console.WriteLine($"\t\tThe ship position reset to {e.x} and {e.y} \n");
            Console.ResetColor();
            Beep.BeeperGoodShipDestroyed();
            ConsoleReset();
        }

        public void BadShipsExplodedEventHandler(object sender, BadShipsExplodedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine($"\t\tEnemy Destroyed by {sender}");
            Console.Write($"\t\tRemaining bad ships: ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(e.badShipExplode + "\n");
            Console.ResetColor();
            Beep.BeeperBadShipExploded();
            Delay();
            
        }

        public void LevelUpReachedEventHandler(object sender, LevelEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("#######\t\t WELL DONE LEVEL UP! \t\t#######");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine($"\t\tLevel up by {sender}");
            Console.WriteLine($"\t\tYou are now in Level: {e.level} \n");
            Console.ResetColor();
            Beep.BeeperLevelUp();
            ConsoleReset();
        }

        public void Delay()
        {
            Thread.Sleep(2000);
        }

    public static void ConsoleReset()
    {
        Thread.Sleep(2000);
            Console.ResetColor();
            Console.Clear();
        }
    }
}
