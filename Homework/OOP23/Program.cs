using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp60
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Customer> customers = new List<Customer>()
            {
                new Customer("First", "4th Rays", 0123, 1982, 1, 3),
                new Customer("Someone", "196 Ruby Rd.", 6540, 1980, 3, 1),
                new Customer("Anyone", "10 Cherry Rd.", 9874, 1992, 0, 15),
                new Customer("Else", "12 Rock av.", 0404, 1969, 6, 5),
                new Customer("Last", "12 Martin rd.", 6013, 1973, 2, 7)
            };
            MyQueue queue = new MyQueue(customers);


            queue.Enqueue(new Customer("Newbie", "Somewhere", 1133, 1900, 5, 1));
            queue.AniRakSheela(3,(new Customer("Rude", "Israeli", 6495, 1965, 4,7)));
            Print(customers);

            /*
            queue.SortByProtection();
            Print(customers);

            queue.SortByTotalPurchases();
            Print(customers);

            queue.SortByYear();
            Print(customers);
            
            Console.WriteLine("Number of customers in list: " + queue.Count);
            */

            queue.DequeueCustomer(3);
            Print(customers);
        }

        static void Print(List<Customer> customers)
        {
            foreach (var VARIABLE in customers)
            {
                Console.WriteLine(VARIABLE);
            }

            for (int i = 0; i < 116; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }
    }
}
