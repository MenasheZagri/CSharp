using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Person
    {
        public int Id { get; set; }
        public int Age { get; protected set; }
        public float Height { get; protected set; }
        public string Name { get; protected set; }


        private static readonly IComparer<Person> _compareById;
        private static readonly IComparer<Person> _compareByAge;
        private static readonly IComparer<Person> _compareByName;
        private static readonly IComparer<Person> _compareByHeight;

        public Person(int id, int age, string name, float height)
        {
            Id = id;
            Age = age;
            Height = height;
            Name = name;
        }

        static Person()
        {
            _compareById = new PersonCompareById();
            _compareByHeight = new PersonCompareByHeight();
            _compareByAge = new PersonCompareByAge();
            _compareByName = new PersonCompareByName();
        }

        public static IComparer<Person> IdComparer
        {
            get { return _compareById; }
        }

        public static IComparer<Person> AgeComparer
        {
            get { return _compareByAge; }
        }

        public static IComparer<Person> NameComparer
        {
            get { return _compareByName; }
        }

        public static IComparer<Person> HeightComparer
        {
            get { return _compareByHeight; }
        }

        public int CompareTo(Person secondPerson)
        {
           return this.Id - secondPerson.Id;
        }

        public override string ToString()
        {
            return $"ID: {Id,10} \t Name: {Name,10} \t Age: {Age} \t Height: {Height}";
        }
    }

}
