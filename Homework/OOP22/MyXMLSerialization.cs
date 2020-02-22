using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp57
{
    public static class MyXMLSerialization
    {
        public static void WriteXmlFile(Camp camp)
        {
            XmlSerializer myXmlSerializer = new XmlSerializer(typeof(Camp));
            string filePath = @"c:\temp\camp.xml";
            using (Stream file = new FileStream(filePath, FileMode.Create))
            {
                myXmlSerializer.Serialize(file, camp);
            }
        }

        public static Camp ReadXmlFile()
        {
            XmlSerializer myXmlSerializer = new XmlSerializer(typeof(Camp));
            string filePath = @"c:\temp\camp.xml";
            Camp campRead;
            using (Stream file = new FileStream(filePath, FileMode.Open))
            {
                campRead = myXmlSerializer.Deserialize(file) as Camp;
            }
            return campRead;
        }


    }
}
