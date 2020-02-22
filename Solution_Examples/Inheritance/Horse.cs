using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp45
{
    public class Horse : Animal
    {
        public string _horse;
        public bool _racingHorse;
        public Horse()
        {

        }

        public Horse(string name, bool racingHorse)
        {
            this._name = name;
            this._racingHorse = racingHorse;
        }


        public virtual void Neigh()
        {
            Console.WriteLine("Horse neighs: NEIGH!\n");
        }
        public override void MakeSound()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("(1st gen virtual override): \t");
            Console.ResetColor();
            Neigh();
        }

        private void BasicToString()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("(Custom ToString Function): \t");
            Console.ResetColor();
            Console.Write($"This is a Horse, it's name is: '{_name}' ");
            if (_racingHorse==true)
            {
                Console.Write($"and '{ _name}' is a racing horse.");
            }
            else
            {
                Console.Write($"and '{_name}' is not a racing horse");
            }
        }
        public override string ToString()
        {
            BasicToString();
            return null;
        }
    }
}
