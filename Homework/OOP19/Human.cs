using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroes
{
    abstract class Human
    {
        private string _name;
        private int _age;

        public string GetName()
        {
            return _name;
        }

        public void SetName(string Name)
        {
            _name = Name;
        }

        public int GetAge()
        {
            return _age;
        }

        public Human(string name, int age)
        {
            _name = name;
            _age = age;
        }

        protected Human()
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
