using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    class Program
    {
        static void Main(string[] args)
        {
            Person moshe = new Person(45, "moshe", 110, 55000);
            Person dana = new Person(30, "dana", 45, 15000);
            Person zoei = new Person(26, "zoei", 30, 12000);

            Person[] group = { moshe, dana, zoei };

            Console.WriteLine("before sort:");
            PrintArray(group);

            Array.Sort(group);

            Console.WriteLine("after sort:");
            PrintArray(group);


            int[] arr = { 7, 4, -1, 10 };
            string[] arr2 = { "aa", "bb", "cd", "ef", "dd" };

            Array.Sort(arr2);
            foreach (var item in arr2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Array.Sort(arr);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();


        }

        static void PrintArray(Array arr)
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
