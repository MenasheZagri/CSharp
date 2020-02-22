using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
using System.Threading;
using System.Xml.Serialization;

namespace ConsoleApp9
{
    class Program
        {
            static void Main(string[] args)
            {

                //1 - Serializing to XML
                //declare file path
                string filePath = @"c:\temp\xmlfile.xml";

                //instanciate object
                Person person1 = new Person("Menashe", "Zagri");
                
                //instanciate XmlSerializer with Class GetType / typeof 
                XmlSerializer personXmlSerializer = new XmlSerializer(typeof(Person));
            
                //stram onto file with autoclose process
            using (Stream file = new FileStream(filePath, FileMode.Create)) 
            {
                personXmlSerializer.Serialize(file, person1);
            }
            
                //2 - Deserializing from XML
                //instanciate target object
            Person person2;

            //stream from file onto object
            using (Stream file = new FileStream(filePath, FileMode.Open))
            {
                //casting object into class
                person2 = personXmlSerializer.Deserialize(file) as Person;
            }

            Console.WriteLine(person2.ToString());
            }
        
                    Person[] pArray =
            {
                new Person("Jane", "Doe"),
                new Person("Israel", "Israeli"),
                new Person("John", "smith"),
                new Person("Games", "Bond"),
                new Person("Princess", "Queen")
            };

        //with array
            XmlSerializer myXmlSerializerArray = new XmlSerializer(typeof(Person[]));
            using (Stream file2 = new FileStream(filePath2, FileMode.Create))
            {
                myXmlSerializerArray.Serialize(file2, pArray);
            }

            Person[] pArray2;
            using (Stream file2 = new FileStream(filePath2, FileMode.Open))
            {
                pArray2 = myXmlSerializerArray.Deserialize(file2) as Person[];
            }

            foreach (Person person in pArray2)
            {
                Console.WriteLine(person.ToString());
            }
        }
}
