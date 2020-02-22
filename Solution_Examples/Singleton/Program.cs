using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get instance through static function (option 1 - pointers)
            DBConnection connection1 = DBConnection.GetInstanceDbConnection();
            DBConnection connection2 = DBConnection.GetInstanceDbConnection();

            //Get instance through static function (option 2 - GetInstance through connections)
            var connection3 = DBConnection.GetInstanceDbConnection().Connections;
            var connection4 = DBConnection.GetInstanceDbConnection().Connections;

            CheckSingleton(connection1,connection2);
            CheckSingleton(connection3,connection4);

        }

        //Check if singleton using pointers
        static void CheckSingleton(DBConnection connection1, DBConnection connection2)
        {
            Console.Write("Checking pointers: ");
            if (connection1 == connection2)
            {
                Console.WriteLine("Singleton");
            }
            else
            {
                Console.WriteLine($"{connection1} != {connection2} thus not singleton");
            }
        }

        //Check if singleton using static get instance
        private static void CheckSingleton(List<MyConnection> connection1, List<MyConnection> connection2)
        {
            Console.Write("Checking list reference: ");
            if (connection1 == connection2)
            {
                Console.WriteLine("Singleton");
            }
            else
            {
                Console.WriteLine($"{connection1} != {connection2} thus not singleton");
            }
        }
    }
}
