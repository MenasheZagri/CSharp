using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroes
{
    class SuperMan:Human,ISuperHero,IFly
    {
        public SuperMan(string name, int age, string speed) : base(name, age)
        {
            this.speed = speed;
        }

        public string speed { get; set; }
        public void ActivateSuperPowers()
        {
            fly();
        }
        public void fly()
        {
            Console.WriteLine("Superman flies!");
        }

        public override string ToString()
        {
            return $"Supername real name is: {GetName()}, he is ageless {GetAge()}M years, and his speed is {speed}";
        }
    }
}
