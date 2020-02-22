using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp57
{
    public class Camp
    {
        private readonly int id;
        private static int lastCampId = 0;
        public int Latitude { get; set; }
        public int Longtitude { get; set; }
        public int NumberOfPeople { get; set; }
        public int NumberOfTents { get; set; }
        public int NumberOfFlashLights { get; set; }

        public Camp(int latitude, int longtitude, int numberOfPeople, int numberOfTents, int numberOfFlashLights)
        {
            this.id = ++lastCampId;
            Latitude = latitude;
            Longtitude = longtitude;
            NumberOfPeople = numberOfPeople;
            NumberOfTents = numberOfTents;
            NumberOfFlashLights = numberOfFlashLights;
        }
        public Camp()
        {
            
        }

        public static bool operator ==(Camp c1, Camp c2)
        {

            if (ReferenceEquals(c1, null) && ReferenceEquals(c2, null))
            {
                return true;
            }

            if (ReferenceEquals(c1, null) || ReferenceEquals(c2, null))
            {
                return false;
            }

            if (c1.id == c2.id)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Camp c1, Camp c2)
        {
            return !(c1 == c2);
        }

        public static bool operator >=(Camp c1, Camp c2)
        {
            return !(c1 == c2);
        }
        public static bool operator <=(Camp c1, Camp c2)
        {
            return !(c1 == c2);
        }

        public static bool operator >(Camp c1, Camp c2)
        {
            if (c1.NumberOfPeople > c2.NumberOfPeople)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator <(Camp c1, Camp c2)
        {
            return !(c1 > c2);
        }

        public static Camp operator +(Camp c1, Camp c2)
        {
            return new Camp
                (
                (c1.Latitude + c2.Latitude)/2, 
                (c1.Longtitude+c2.Longtitude)/2, 
                c1.NumberOfPeople+c2.NumberOfPeople,
                c1.NumberOfTents + c2.NumberOfTents,
                c1.NumberOfFlashLights + c2.NumberOfFlashLights
                );
        }

        public override bool Equals(object obj)
        {
            Camp other = obj as Camp;
            return this == other;
        }

        public override int GetHashCode()
        {
            return this.id;
        }

        public override string ToString()
        {
            return $"Camp ID: {id}, long {Longtitude}, lat {Latitude}, people {NumberOfPeople}, tents {NumberOfTents}, flash {NumberOfFlashLights}";
        }
    }
}
