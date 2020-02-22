using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp57
{
    class Program
    {
        static void Main(string[] args)
        {
            Camp camp1 = new Camp(100,200,4,5,10);
            Camp camp2 = new Camp(123,456,30,6,12);
            Camp camp3 = camp1 + camp2;
            Camp camp4 = new Camp(333,666,125,30,80);
            Camp camp5 = new Camp(842,025,50,10,17);
            CompareCampSize(camp1, camp2);
            CompareCampId(camp1, camp2);
            Console.WriteLine($"Camp1 ID: {camp1.GetHashCode()}");
            Console.WriteLine($"Camp2 ID: {camp2.GetHashCode()}");
            Console.WriteLine($"Camp3 ID: {camp3.GetHashCode()}");
            Console.WriteLine(camp1.ToString());
            Console.WriteLine(camp2.ToString());
            Console.WriteLine(camp3.ToString());
            MyXMLSerialization.WriteXmlFile(camp4);
            Camp campA = MyXMLSerialization.ReadXmlFile();
            Camp campB = MyXMLSerialization.ReadXmlFile();
            Console.WriteLine(campA.GetHashCode() == campB.GetHashCode());
        }

        static void CompareCampSize(Camp camp1, Camp camp2)
        {
            if (camp1 > camp2) 
            {
                Console.WriteLine($"Camp 1 is bigger than camp 2 by {camp1.NumberOfPeople - camp2.NumberOfPeople} people");
            }
            else 
            {
                Console.WriteLine($"Camp 1 is smaller than camp 2 by {camp2.NumberOfPeople - camp1.NumberOfPeople} people");
            }
        }

        static void CompareCampId(Camp camp1, Camp camp2)
        {
            if (camp1 == camp2)
            {
                Console.WriteLine("Camps have the same id");
            }

            if (camp1 != camp2)
            {
                Console.WriteLine("Camps does not have the same id");
            }
        }
    }
}
