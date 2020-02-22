using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace SuperHeroes
{
    class SpiderMan:Human, ISuperHero,IClimb
    {

        public SpiderMan(string name, int age, int webLeft) : base(name, age)
        {
            WebLeft = webLeft;
        }

        public int WebLeft { get; set; }


        public void ActivateSuperPowers()
        {
            Climb();
        }
        public void Climb()
        {
            Console.WriteLine("Spiderman, spiderman!");
        }

        public override string ToString()
        {
            return $"Spiderman name is: {GetName()}, his age is: {GetAge()}, he has {WebLeft} webs left";
        }
    }
}
