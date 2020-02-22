using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp69
{
    [Flags]
    enum ElevatorState
    {
        GOING_UP,
        GOING_DOWN,
        OPEN_DOORS,
        CLOSE_DOORS,
        IDLE
    }
}
