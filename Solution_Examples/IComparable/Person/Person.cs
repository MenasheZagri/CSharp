using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    class Person :IComparable
    {
        public int Age { get; protected set; }
        public string Name { get; protected set; }
        public float Weight { get; protected set; }
        public int Salary { get; protected set; }

        public Person(int age, string name, float weight, int salary)
        {
            this.Age = age;
            this.Name = name;
            this.Weight = weight;
            this.Salary = salary;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Weight: {Weight}, Salary: {Salary}";
        }

        //take 'this' local object, inject an external object, and compare
        //explain comparison logic within codeblock
        public int CompareTo(object obj)
        {
            // return 0       -- we are the same;
            // return 1       -- [positive] he is first;
            // return -1      -- [negative] he is before me;
            Person other = obj as Person;

            if (this.Weight == other.Weight)
                return 0;
            if (this.Weight > other.Weight)
                return 1;

            return -1;
        }


    }
}
