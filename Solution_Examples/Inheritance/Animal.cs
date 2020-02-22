using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp45
{
    public abstract class Animal
    {
        public string _name;
        public Animal()
        {
        }

        public Animal(string name)
        {
            this._name = name;
        }

        public abstract void MakeSound();

        public override string ToString()
        {
            return $"This animal is: {_name}";
        }

    }
}
