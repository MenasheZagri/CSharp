using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp45
{
    public class Dog : Animal
    {
        public new string _name;
        public string _favoriteDogFood;

        public Dog()
        { 
        }
        public Dog(string name, string favoriteDogFood) 
        {
            this._name = name;
            this._favoriteDogFood = favoriteDogFood;
        }

        public virtual void Bark()
        {
            Console.WriteLine($"'{_name}' barks: WOOF!\n");
        }

        public override void MakeSound()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("(1st gen virtual override): \t");
            Console.ResetColor();
            Bark();
        }

        private void BasicToString()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("(Custom ToString Function): \t");
            Console.ResetColor();
            Console.Write($"This is a canine, it's name is: '{_name}' and it eats: '{_favoriteDogFood}'.");
        }
        public override string ToString()
        {
            BasicToString();
            return null;
        }

    }
}
