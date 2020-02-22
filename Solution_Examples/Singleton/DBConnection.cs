using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class DBConnection
    {
        //Singleton is several rules applied to a class.
        //-----------------------------------------------
        //My specific Sinlgeton design requirements:
        //1. Cannot create more than 1 instance
        //2. Allow public access to the single instance
        //3. If instance does not exist when request  - create it
        //4. Thread-Safe

        public List<MyConnection> Connections
        {
            get; set;
        }

        //Creating static instance (3rd requirement)
        private static DBConnection _instanceDbConnection;
        
        //Creating static key (4rth requirement)
        private static object key = new object();

        //allows program to instance a private / protected class (2nd requirement)
        public static DBConnection GetInstanceDbConnection()
        {
            //thread safe (4rth requirement)
            lock (key)
            {
                //if connection does not instanced, create it (3rd requirement)
                if (_instanceDbConnection == null)
                {
                    _instanceDbConnection = new DBConnection();
                }
            }
            return _instanceDbConnection;
        }

        //Allows singleton to instantiate the ctor (1st requirement)
        protected DBConnection()
        {
            Connections = new List<MyConnection>();
            Connections.Add(new MyConnection());
            Connections.Add(new MyConnection());
            Connections.Add(new MyConnection());
            Connections.Add(new MyConnection());
            Connections.Add(new MyConnection());
        }

    }
}
