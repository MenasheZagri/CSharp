using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight marcus = new Knight("Marcus", "York", "Sir");
            Knight mourice = new Knight("Mourice", "Hammerhead", "Sir Jr.");
            Knight jared = new Knight("Jared", "Newton", "Knight" );
            Magician tom = new Magician("Tom Riddle", "Shefield", "Avada Kadabra");
            Magician harry = new Magician("Harry Potter", "London", "Expeliarmus");
            Magician merlin = new Magician("Merlin", "Manchester", "Allermius");

            RoundTable<Knight> knights = new RoundTable<Knight>();
            RoundTable<Magician> mages = new RoundTable<Magician>();
            knights.Add(marcus);
            knights.Add(mourice);

            mages.Add(tom);
            mages.Add(harry);
            mages.Add(merlin);
            mages.InsertAt(0,new Magician("Charlie", "Bottomtown", "BLAST!"));

            harry["Name"] = "Mike";
            Console.WriteLine(knights[0]);
            
            foreach (Knight knight in knights)
            {
                Console.WriteLine(knight);
            }

            foreach (Magician mage in mages)
            {
                Console.WriteLine(mage);
            }

            mages.RemoveAt(2);
            mages.RemoveAt(1);

            Console.WriteLine("");
            foreach (Magician mage in mages)
            {
                Console.WriteLine(mage);
            }
        }
    }
}
