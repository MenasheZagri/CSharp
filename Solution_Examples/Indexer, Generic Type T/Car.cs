using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class Car
    {
        public string Name { get; private set; }
        public string Color { get; private set; }
        public string Treatment { get; private set; }
        public int Price { get; private set; }

        public Car(string name, string color, string treatment, int price)
        {
            Name = name;
            Color = color;
            Treatment = treatment;
            Price = price;
        }

        //String Indexer
        public string this[string fieldName]
        {
            get
            {
                if (fieldName == "Name")
                    return this.Name;
                if (fieldName == "Color")
                    return this.Color;
                if (fieldName == "Treatment")
                    return this.Treatment;
                if (fieldName == "Price")
                    return this.Price.ToString();
                return "Unknown";
            }

            set
            {
                if (fieldName == "Name")
                    this.Name = value;
                if (fieldName == "Color")
                    this.Color = value;
                if (fieldName == "Treatment")
                    this.Treatment = value;
                if (fieldName == "Price")
                    this.Price = Convert.ToInt32(Price);
            }
        }

        public override string ToString()
        {
            return $"Car Name: {Name}, Price: {Price}, Color: {Color}, Treatment {Treatment}";
        }
    }
}
