using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp66
{

    public abstract class Program
    {
        public static Random random = new Random();
     //   private static Delegate _delegate;

        static void Main(string[] args)
        {
            int damageValue = 1;
            int goodShipHP = 4;
            int locationX = 110;
            int locationY = 220;
            int enemies = 5;
            bool audioMute = true;
            
            SpaceQuestGameManager spaceQuest = new SpaceQuestGameManager(goodShipHP, locationX, locationY, enemies);
            GameViewer gameViewer = new GameViewer();

            spaceQuest.GoodSpaceShipLocationChanged += gameViewer.GoodSpaceShipLocationChangedEventHandler;
            spaceQuest.GoodSpaceShipHPChanged += gameViewer.GoodSpaceShipHPChangedEventHandler;
            spaceQuest.GoodSpaceShipDestroyed += gameViewer.GoodSpaceShipDestroyedEventHandler;
            spaceQuest.BadShipsExploded += gameViewer.BadShipsExplodedEventHandler;
            spaceQuest.LevelUpReached += gameViewer.LevelUpReachedEventHandler;

            List<Action> methods = new List<Action>();
            methods.Insert(0, spaceQuest.MoveSpaceShip(random.Next(100),random.Next(200)));
            methods.Insert(1, spaceQuest.GoodSpaceShipGotExtraHP(damageValue)) ;
            methods.Insert(2,spaceQuest.GoodSpaceShipGotDamaged(damageValue));
            methods.Insert(3, spaceQuest.EnemyShipsDestroyed(damageValue));


            for (int i = 0; i < 1000; i++)
            {
                Beep._mute = audioMute;
                methods[random.Next(1, 4)].Invoke();
            } 

        }
    }
    
}
