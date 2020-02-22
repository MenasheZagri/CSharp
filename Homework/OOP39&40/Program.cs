using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp69
{
    class Program
    {
        public static void Main(string[] args)
        {
            Elevator elevator = new Elevator(ElevatorState.IDLE, 0);
            elevator.GoToFloor(5);
            elevator.GoToFloor(-4);

 
        }
    }


}
