using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Magician
    {
        public string Name { get; private set; }
        public string Birthtown { get; private set; }
        public string FavoriteSpell { get; private set; }

        public Magician(string name, string birthtown, string favoriteSpell)
        {
            Name = name;
            Birthtown = birthtown;
            FavoriteSpell = favoriteSpell;
        }

        public string this[string fieldName]
        {
            get
            {
                if (fieldName == "Name")
                    return this.Name;
                if (fieldName == "Birthrown")
                    return this.Birthtown;
                if (fieldName == "FavoriteSpell")
                    return this.FavoriteSpell;
                return "Unknown";
            }

            set
            {
                if (fieldName == "Name")
                    this.Name = value;
                if (fieldName == "Birthtown")
                    this.Birthtown = value;
                if (fieldName == "FavoriteSpell")
                    this.FavoriteSpell = value;
            }
        }

        public override string ToString()
        {
            return $"Name: {Name} Birth town: {Birthtown} Favorite Spell: {FavoriteSpell}";
        }
    }
}
