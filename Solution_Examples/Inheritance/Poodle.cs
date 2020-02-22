using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp45
{
    public class Poodle : Dog
    {
        public new string _name;
        public new string _favoriteDogFood;
        public int _numberOfPonyTails;

        public Poodle()
        { 
        }

        public Poodle(string name, string favoriteDogFood, int numberOfPonyTails) : base (name, favoriteDogFood)
        {
            this._name = name;
            this._favoriteDogFood = favoriteDogFood;
            this._numberOfPonyTails = numberOfPonyTails;
        }

        public override void Bark()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("(2nd gen virtual override): \t");
            Console.ResetColor();
            Console.WriteLine($"'{_name}' hi pitch bark: PIFF!\n");
        }

        public string Bark(string calling)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("(2nd gen override+overload): \t");
            Console.ResetColor();
            Console.WriteLine($"'{_name}' special bark: '{calling}\n");
            return calling;
        }

        private void BasicToString()
        {
            base.ToString();
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("(2n gen ToString override) \t");
            Console.ResetColor();
            Console.WriteLine($"'{_name}' is a Poodle, and it has {_numberOfPonyTails} ponytails.");

        }
        public override string ToString()
        {
            BasicToString();
            return null;
        }

    }
}
