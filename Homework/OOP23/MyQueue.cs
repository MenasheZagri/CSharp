using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp60
{
    class MyQueue
    {
        private List<Customer> customers;
        public MyQueue(List<Customer> customers)
        {
            this.customers = customers;
        }
        public void Enqueue(Customer customer) 
        {
            this.customers.Add(customer);
        }

        public Customer Dequeue()
        {
            Customer element0 = customers[0];
            customers.RemoveAt(0);
            return element0;
        }

        public void Init(List<Customer> newCustomers)
        {
            this.customers = newCustomers;
        }

        public void clear()
        {
            this.customers.Clear();
        }

        public Customer WhoIsNext()
        {
            return customers[0];
        }

        public int Count
        {
            get { return customers.Count; }
        }

        public void AniRakSheela(int position, Customer customer)
        {
            customers.Insert(position, customer);
        }

        public List<Customer> DequeueCustomer(int num)
        {
            if ((num > customers.Count) || (num <= 0))
            {
                Console.WriteLine("number invalid!");
            }

            List<Customer> newList = new List<Customer>();
            while (newList.Count < num)
            {
                newList.Add(customers[0]);
                customers.RemoveAt(0);
            }

            return newList;
        }
        public void SortByProtection()
        {
            customers.Sort(new CustomerCompareByProtection());
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Sorted by Protection");
            Console.ResetColor();
        }

        public void SortByTotalPurchases()
        {
            customers.Sort(new CustomerCompareByTotalPurchases());
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Sorted by Total Purchases");
            Console.ResetColor();
        }

        public void SortByYear()
        {
            customers.Sort();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Sorted by Year of Birth");
            Console.ResetColor();
        }
    }
}
