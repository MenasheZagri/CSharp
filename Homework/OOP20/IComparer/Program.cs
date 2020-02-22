
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Person manny = new Person(040438764, 38,"Menashe",171.0f);
            Person katie = new Person(32164580, 31,"Katelynn", 165.5f);
            Person nir = new Person(13132105, 37, "Nir", 170.5f);
            Person amanda = new Person(69201345,21,"Amanda", 164.2f);
            Person amit = new Person(91231504, 43, "Amit", 172.1f);

            Person[] people = {amit,amanda,katie,manny,nir};
            PrintSortedArray(people,Person.IdComparer);
            PrintSortedArray(people,Person.NameComparer);
            PrintSortedArray(people,Person.AgeComparer);
            PrintSortedArray(people,Person.HeightComparer);
        }

        static void PrintPersonArray(Person [] people)
        {
            foreach (Person person in people)
            {
                Console.WriteLine(person);
            }

        }

        static void PrintSortedArray(Person[] people, IComparer<Person> methodComparer)
        {
            Console.WriteLine($"Sorting by {methodComparer.GetType()}");
            Array.Sort(people, methodComparer);
            PrintPersonArray(people);
        }


    }
}
