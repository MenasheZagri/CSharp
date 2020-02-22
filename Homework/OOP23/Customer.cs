using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp60
{
    public class Customer : IComparable<Customer>, IEnumerable<Customer>
    {

        public string Name { get; set; }
        public string Address { get; set; }
        public int Id { get; set; }
        public int BirthYear { get; set; }
        public int Protection { get; set; }
        public int TotalPurchases { get; set; }

        public Customer(string name, string address, int id, int birthYear, int protection, int totalPurchases)
        {
            Name = name;
            Address = address;
            Id = id;
            BirthYear = birthYear;
            Protection = protection;
            TotalPurchases = totalPurchases;
        }

        public int CompareTo(Customer other)
        {
            return this.BirthYear - other.BirthYear;
        }

        public override string ToString()
        {
            return $"Name {Name,1} \tAddress: {Address,1} \t ID: {Id,1} \tBirthYear: {BirthYear,1} " +
                   $"\tProtection: {Protection,1} \tTotalPurchases: {TotalPurchases} ";
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<Customer> GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    public class CustomerCompareByProtection : IComparer<Customer>
    {
        public int Compare(Customer a, Customer b)
        {
            return a.Protection - b.Protection;
        }
    }

    public class CustomerCompareByTotalPurchases : IComparer<Customer>
    {
        public int Compare(Customer a, Customer b)
        {
            return a.TotalPurchases - b.TotalPurchases;
        }
    }

}
