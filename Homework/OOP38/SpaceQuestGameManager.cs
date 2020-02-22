using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp66
{
    class SpaceQuestGameManager
    {
        private int _goodSpaceShipHitPoints = 0;
        private int _shipXLocation = 0;
        private int _shipYLocation = 0;
        private int _numberOfBadShips = 0;
        private int _currentLevel = 1;
        

        public SpaceQuestGameManager(int goodSpaceShipHitPoints, int shipXLocation, int shipYLocation, int numberOfBadShips)
        {
            _goodSpaceShipHitPoints = goodSpaceShipHitPoints;
            _shipXLocation = shipXLocation;
            _shipYLocation = shipYLocation;
            _numberOfBadShips = numberOfBadShips;
        }

        public event EventHandler<PointsEventArgs> GoodSpaceShipHPChanged;
        public event EventHandler<LocationEventArgs> GoodSpaceShipLocationChanged;
        public event EventHandler<LocationEventArgs> GoodSpaceShipDestroyed;
        public event EventHandler<BadShipsExplodedEventArgs> BadShipsExploded;
        public event EventHandler<LevelEventArgs> LevelUpReached;

        private int a, b,goodDamage,goodHp,badDestroyed;
        public Action MoveSpaceShip(int newX, int newY)
        {
            a = newX;
            b = newY;
            return MoveSpaceShipVoid;
        }

        private void MoveSpaceShipVoid()
        {
            _shipXLocation = a;
            _shipYLocation = b;
            Console.WriteLine($"Moving ship from {_shipXLocation} , {_shipYLocation}");
            OnGoodSpaceShipLocationChanged();
            return;
        }

        public Action GoodSpaceShipGotDamaged(int damage)
        {
            goodDamage = damage;
            return GoodSpaceShipGotDamagedVoid;
        }

        private void GoodSpaceShipGotDamagedVoid()
        {
            _goodSpaceShipHitPoints = _goodSpaceShipHitPoints - goodDamage;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Good Spaceship got hit! Remaining points: {_goodSpaceShipHitPoints}");
            Console.ResetColor();
            if (_goodSpaceShipHitPoints < 0)
            {
                _currentLevel = 1;
                OnGoodSpaceShipDestroyed();
            }
            else
            {
                OnGoodSpaceShipHPChanged();
            }
            return;
        }

        public Action GoodSpaceShipGotExtraHP(int extra)
        {
            goodHp = extra;
            return GoodSpaceShipGotExtraHPVoid;
        }

        private void GoodSpaceShipGotExtraHPVoid()
        {
            _goodSpaceShipHitPoints = _goodSpaceShipHitPoints + goodHp;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Good Spaceship hit enemy, increasing points by {goodHp}, current points: {_goodSpaceShipHitPoints}");
            Console.ResetColor();
            if (_goodSpaceShipHitPoints >= 5)
            {
                OnLevelUpReached();
            }
            OnBadShipsExploded();
            return;
        }

        public Action EnemyShipsDestroyed(int numberOfBadShipsDestroyed)
        {
            badDestroyed = numberOfBadShipsDestroyed;
            return EnemyShipDestroyedVoid;
        }

        private void EnemyShipDestroyedVoid()
        {
            if (_numberOfBadShips > 0)
            {
                _numberOfBadShips = _numberOfBadShips - badDestroyed;
                return;
            }
            if (_numberOfBadShips <= 0)
            {
                Console.WriteLine("There are no enemy ships left!");
                OnLevelUpReached();
            }
            return;
        }


        private void OnGoodSpaceShipHPChanged()
        {
            if (GoodSpaceShipHPChanged != null)
            {
                GoodSpaceShipHPChanged.Invoke(this, new PointsEventArgs {points = _goodSpaceShipHitPoints});
            }
        }

        private void OnGoodSpaceShipLocationChanged()
        {
            if (GoodSpaceShipLocationChanged != null)
            {
                GoodSpaceShipLocationChanged.Invoke(this, new LocationEventArgs { x = _shipXLocation, y = _shipYLocation });
            }
        }

        private void OnGoodSpaceShipDestroyed()
        {
            GoodSpaceShipDestroyed.Invoke(this, new LocationEventArgs{ x = 0 , y = 0});
        }

        private void OnBadShipsExploded()
        {
            _numberOfBadShips--;

            if (BadShipsExploded != null)
            {
                BadShipsExploded.Invoke(this, new BadShipsExplodedEventArgs{badShipExplode = _numberOfBadShips});
            }
        }

        private void OnLevelUpReached()
        {
            _currentLevel++;
            LevelUpReached.Invoke(this, new LevelEventArgs{level = _currentLevel});
        }
    }
}
