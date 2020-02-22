using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp45
{
    public class PetWolf : Wolf
    {
        public new string _name;
        public new string _favoriteDogFood;
        public new string _nameOfPack;
        public string _babyBark;

        public PetWolf(string name, string favoriteDogFood, string nameOfPack, string babyBark) : base (name,favoriteDogFood,nameOfPack)
        {
            this._name = name;
            this._favoriteDogFood = favoriteDogFood;
            this._nameOfPack = nameOfPack;
            this._babyBark = babyBark;
        }

        public string Bark(string calling)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("(3rd gen override+overload): \t");
            Console.ResetColor();
            Console.WriteLine($"'{_name}' special bark: '{calling}\n");
            return calling;
        }

    }
}
