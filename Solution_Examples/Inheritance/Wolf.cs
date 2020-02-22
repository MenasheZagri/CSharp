using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp45
{
    public class Wolf : Dog
    {
        public new string _name;
        public new string _favoriteDogFood;
        public string _nameOfPack;

        public Wolf()
        { }
        public Wolf (string name, string favoriteDogFood, string nameOfPack) : base (name, favoriteDogFood)
        {
            this._name = name;
            this._favoriteDogFood = favoriteDogFood;
            this._nameOfPack = nameOfPack;
        }

        private void BasicToString()
        {
            base.ToString();
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("(2nd gen ToString override): \t");
            Console.ResetColor();
            Console.WriteLine($"'{_name}' is a Wolf who is part of pack: '{_nameOfPack}'.");

        }
        public override string ToString()
        {
            BasicToString();
            return null;
        }
    }
}
