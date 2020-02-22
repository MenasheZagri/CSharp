using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            Flash flash = new Flash("Speedy", 16, 220);
            SpiderMan spiderman = new SpiderMan("Toby", 28, 1000);
            SuperMan superman = new SuperMan("Clark Kent", 200, "Faster Than a Bullet");

            Console.WriteLine(flash.ToString());
            ActivateSuperhero(flash);
            Console.WriteLine(spiderman.ToString());
            ActivateSuperhero(spiderman);
            Console.WriteLine(superman.ToString());
            ActivateSuperhero(superman);

            IdentifyHero(spiderman);
            IdentifyHero(superman);
            IdentifyHero(flash);
            Console.WriteLine();

            GetMoreHeroData(flash);
            GetMoreHeroData(superman);
            GetMoreHeroData(spiderman);
            Console.WriteLine();

            CreateHero(flash);
            CreateHero(spiderman);
            CreateHero(superman);
        }

        static void ActivateSuperhero(ISuperHero seHero)
        {
            Console.WriteLine($"{seHero.GetType()} Powers activated\n");
        }

        static void IdentifyHero(ISuperHero seHero)
        {
            if (seHero.GetType() == typeof(Flash))
            {
                Console.WriteLine($"Flash detected");
            }

            if (seHero.GetType() == typeof(SuperMan))
            {
                Console.WriteLine("Superman detected");
            }
            else if (seHero.GetType()==typeof(SpiderMan))
            {
                Console.WriteLine($"Spiderman detected");
            }
        }

        static void GetMoreHeroData(ISuperHero seHero)
        {
            if (seHero is Flash)
            {
                Flash flash1 = (Flash) seHero;
                Console.WriteLine($"Flash voltage: {flash1.Voltage} V");
            }

            if (seHero is SpiderMan)
            {
                SpiderMan spider1 = (SpiderMan)seHero;
                Console.WriteLine($"Spiderman has: {spider1.WebLeft} web left ");
            }

            else if (seHero is SuperMan)
            {
                SuperMan super1 = (SuperMan)seHero;
                Console.WriteLine($"Superman speed is: {super1.speed} ");
            }
        }

        static void CreateHero(ISuperHero seHero)
        {
            
            if (seHero.GetType() == typeof(Flash))
            {
                Flash flash1 = new Flash("New Flash", 18, 480);
                Console.WriteLine("*** New object **");
                Console.WriteLine(flash1.ToString());
            }

            if (seHero.GetType() == typeof(SuperMan))
            {
                SuperMan super1 = new SuperMan("New Clark", 58, "120");
                Console.WriteLine("*** New object **");
                Console.WriteLine(super1.ToString());
            }
            else if (seHero.GetType() == typeof(SpiderMan))
            {
                SpiderMan spider1 = new SpiderMan("New Spider", 44, 100);
                Console.WriteLine("*** New object **");
                Console.WriteLine(spider1.ToString());
            }
        }
    }
}
