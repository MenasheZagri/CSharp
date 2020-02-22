using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp45
{
    class Program
    {
        static void Main(string[] args)
        {
            //1st gen inheritance 
            Dog edna = new Dog("Edna", "Meat");
            Dog pucha = new Dog("Pucha", "Bonzo");
            Horse pony = new Horse("Pie-o-mine", true);
            Console.WriteLine(pucha.ToString());
            pucha.MakeSound();
            Console.WriteLine(edna.ToString());
            edna.MakeSound();
            Console.WriteLine(pony.ToString());
            pony.MakeSound();

            //2nd gen inheritance
            Poodle chichhi = new Poodle("Chichi", "Dogos", 1);
            chichhi.ToString();
            chichhi.Bark("Funny Hawling!");
            Wolf wolfie = new Wolf("Wolfie", "Meat", "TheWilds");
            wolfie.ToString();
            wolfie.MakeSound();
            Console.WriteLine("");

            //3rd gen inheritence
            PetWolf pupper = new PetWolf("Pupper", "Milk", "TheWilds", "Squeek!");
            pupper.ToString();
            pupper.Bark("Squeek!");


            //im unable to call method from within the static function :(
            Dog[] dogs = new Dog[4] { edna, pucha, chichhi, wolfie };
            AnimalSing(dogs);
        }

        static void AnimalSing(Array dogs)
        {
            for (int i = 0; i < dogs.Length; i++)
            {
                Console.WriteLine(dogs.ToString()[i]);
            }            
        }
    }
}
