using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp10
{
    public class Car
    {
        #region datafields and ctors
        public string _model { get; set; }
        public string _brand { get; set; }
        public int _year { get; set; }
        public string _color { get; set; }
        private int _codan;
        protected int _numberOfSeats = 4;
        public string _fileName = String.Empty;

        public Car()
        {
        }
        public Car(string fileName)
        {
            _fileName = fileName;

        }
        public Car(string brand, string model, int year, string color, int codan, int numberOfSeats)
        {
            _model = model;
            _brand = brand;
            _year = year;
            _color = color;
            _codan = codan;
            _numberOfSeats = numberOfSeats;
        }
        #endregion


        //although you asked for an int, a string return would be more user friendly
        public string GetCodan() 
        {
            return $"The codan for {_brand} is: {_codan}";
        }

        public string GetNumberOfSeats()
        {
            return $"{_brand} {_model} {_year} has {_numberOfSeats} seats";
        }


        //plesae take note that in tue UML you asked for protected access!
        public void ChangeNumberOfSeats(int newNumberOfSeats)
        {
            _numberOfSeats = newNumberOfSeats;
        }

        public static void SerializeACar(string fileName, Car car)
        {
            string filePath = @"c:\temp\"+fileName+".xml";
            XmlSerializer carXmlSerializer = new XmlSerializer(typeof(Car));
            using (Stream fileWrite = new FileStream(filePath, FileMode.Create))
            {
                carXmlSerializer.Serialize(fileWrite,car);
            }
            Console.WriteLine("File write complete (Single Mode)");
        }

        public static void SerializeCarArray(string fileName, Car[] cars)
        {
            string filePath = @"c:\temp\"+fileName+".xml";
            XmlSerializer carXmlSerializer = new XmlSerializer(typeof(Car []));
            using (Stream fileWrite = new FileStream(filePath, FileMode.Create))
            {
                carXmlSerializer.Serialize(fileWrite, cars);
            }
            Console.WriteLine("File write complete (Array Mode)");
        }


        public static Car DeSerializeACar(string fileName)
        {
            string filePath = @"c:\temp\" + fileName + ".xml";
            Car car1FromFile;
            XmlSerializer carXmlSerializer = new XmlSerializer(typeof(Car));
            using (Stream fileRead = new FileStream(filePath, FileMode.Open))
            {
                car1FromFile = carXmlSerializer.Deserialize(fileRead) as Car;
            }

            Console.WriteLine("File read complete (Single Mode)");
            return car1FromFile;
        }

        public static Car[] DeserializeCarArray(string fileName)
        {
            string filePath = @"c:\temp\"+fileName+".xml";
            Car [] carsArray;
            XmlSerializer carXmlSerializer = new XmlSerializer(typeof(Car[]));
            using (Stream fileRead = new FileStream(filePath, FileMode.Open))
            {
                carsArray = carXmlSerializer.Deserialize(fileRead) as Car[];
            }

            Console.WriteLine("File read complete");
            return carsArray;
        }

        public bool CarCompare(string fileName)
        {
            Car carFromFile = Car.DeSerializeACar(fileName);
            
            if (
                carFromFile._brand ==this._brand &&
                carFromFile._model ==this._model &&
                carFromFile._color ==this._color &&
                carFromFile._year ==this._year
                )
            { return true;}

            else
            { return false;}
        }

        public override string ToString()
        {
            return $"Brand: {_brand,10} \t Model: {_model,10} \t Year: {_year,10}";
        }
    }
}
