using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroes
{
    class Flash : Human, ISuperHero,IFlash
    {

        public Flash(string name, int age, int voltage) : base(name, age)
        {
            Voltage = voltage;
        }

        public int Voltage { get; private set; }

        public void ActivateSuperPowers()
        {
            FireLightnings();
        }
        public void FireLightnings()
        {
            Console.WriteLine("Firing Light ZZZ!");
        }

        public override string ToString()
        {
            return $"Flash name is: {GetName()}, his age is: {GetAge()}, and his voltage is:{Voltage}";
        }
    }
}
