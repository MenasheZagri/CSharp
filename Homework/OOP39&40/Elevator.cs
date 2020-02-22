using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp69
{
    class Elevator
    {
        Random random = new Random();
        private ElevatorState _elevatorState;
        private int _currentFloor;
        private int _gotoFloor;

        public Elevator(ElevatorState elevatorState, int currentFloor)
        {
            _elevatorState = elevatorState;
            _currentFloor = currentFloor;
        }

        public bool GoToFloor(int newFloor)
        {

            if (_elevatorState == ElevatorState.IDLE && _currentFloor == newFloor)
            {
                _elevatorState = ElevatorState.OPEN_DOORS;
                PrintStatus();
            }

            if (_elevatorState == ElevatorState.IDLE && _currentFloor != newFloor)
            {
                _gotoFloor = newFloor;
                if (_currentFloor < newFloor)
                {
                    _elevatorState = ElevatorState.GOING_UP;
                    PrintStatus();
                    FloorReached();
                    return true;
                }

                if (_currentFloor > newFloor)
                {
                    _elevatorState = ElevatorState.GOING_DOWN;
                    PrintStatus();
                    FloorReached();
                    return true;
                }
            }
            return false;
        } 

        public bool FloorReached()
        {
            _elevatorState = ElevatorState.OPEN_DOORS;
            _currentFloor = _gotoFloor;
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Floor {_currentFloor} reached");
            Console.ResetColor();
            PrintStatus();
            Console.Write($"Idling the system\t ");
            CloseDoors();
            Delay();
            Console.WriteLine(ToString());
            Console.WriteLine();
            _elevatorState = ElevatorState.IDLE;
            return true;
        }

        public bool CloseDoors()
        {
            if (_elevatorState == ElevatorState.OPEN_DOORS)
            {
                _elevatorState = ElevatorState.CLOSE_DOORS | ElevatorState.IDLE;
            }
            return true;
        }

        public void PrintStatus()
        {
            if (_currentFloor != _gotoFloor)
            {
                Console.WriteLine($"Status: {_elevatorState} \t Current Floor: {_currentFloor} \t Next Floor {_gotoFloor}");
            }

            if (_currentFloor == _gotoFloor)
            {
                Console.WriteLine($"Status: {_elevatorState} \t Current Floor: {_currentFloor}");
            }

            if (_elevatorState == ElevatorState.GOING_DOWN || _elevatorState == ElevatorState.GOING_UP)
            {
                if (_currentFloor < _gotoFloor)
                {
                    for (int i = _currentFloor; i <= _gotoFloor; i++)
                    {
                        Console.Write(_elevatorState + " Floor: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(string.Format("{0}", i));
                        Console.ResetColor();
                        Console.Write("\r".PadLeft(Console.WindowWidth - Console.CursorLeft - 1));
                        Delay();
                    }
                    Console.Write("\r".PadLeft(Console.WindowWidth - Console.CursorLeft - 1));
                }

                if (_currentFloor > _gotoFloor)
                {
                    for (int i = _currentFloor; i >= _gotoFloor; i--)
                    {
                        Console.Write(_elevatorState + " Floor: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(string.Format("{0}", i));
                        Console.ResetColor();
                        Console.Write("\r".PadLeft(Console.WindowWidth - Console.CursorLeft - 3));
                        Delay();
                    }
                    Console.Write("\r".PadLeft(Console.WindowWidth - Console.CursorLeft - 1));
                }
            }
        }

        private void Delay()
        {
            Thread.Sleep(800);
        }

        public override string ToString()
        {
            if (_currentFloor != _gotoFloor)
            {
                return $"Elevator is at {_currentFloor}, going to floor {_gotoFloor}, status is {_elevatorState}";
            }
            else
            {
                return $"Elevator is at {_currentFloor}, status is {_elevatorState}";
            }
        }
    }
}
