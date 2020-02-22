using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Knight 
    {
        public string Name { get; private set; }
        public string Birthtown { get; private set; }
        public string Title { get; private set; }

        public Knight(string name, string birthtown, string title)
        {
            Name = name;
            Birthtown = birthtown;
            Title = title;
        }

        public string this[string fieldName]
        {
            get
            {
                if (fieldName == "Name")
                    return this.Name;
                if (fieldName == "Birthrown")
                    return this.Birthtown;
                if (fieldName == "Title")
                    return this.Title;
                return "Unknown";
            }

            set
            {
                if (fieldName == "Name")
                    this.Name = value;
                if (fieldName=="Birthtown")
                this.Birthtown = value;
                if (fieldName == "Title")
                    this.Title = value;
                }
        }

        public override string ToString()
        {
            return $"Title: {Title} Name: {Name} Birth town: {Birthtown} ";
        }

    }
}

