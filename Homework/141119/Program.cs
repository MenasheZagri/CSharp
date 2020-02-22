using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace ConsoleApp42
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Computer Apple = new Computer()
            {
                _model = "AppleX",
                _price = 2500,
                _numberOfProcessors = 1,
                _screenSize = 15.5f,
                _isTurnedOn = true
            };

            Computer Micron = new Computer()
            {
                _model = "Micron 9TX",
                _price = 3500,
                _numberOfProcessors = 4,
                _screenSize = 0.0f,
                _isTurnedOn = false
            };

            Computer PC = new Computer()
            {
                _model = "KSP",
                _price = 1500,
                _numberOfProcessors = 2,
                _screenSize = 14.1f,
                _isTurnedOn = false
            };
            PC.turnOn("");
            Micron.tellMeThePrice();
            Apple.tellMeTheScreenSize();
            Apple.turnOff("");
        }
    }
} 
