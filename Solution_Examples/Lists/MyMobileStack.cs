using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp59
{
    class MyMobileStack
    {
        private List<Mobile> _mobiles = new List<Mobile>();
        public MyMobileStack()
        {
        }

        public int Size
        {
            get; 
        }


        public Mobile Pop()
        {
            Mobile item = _mobiles[0];
            _mobiles.RemoveAt(0);
            return item;
        }

        public void Push(Mobile mobile)
        {
            _mobiles.Insert(0, mobile);
        }

        public void Clear()
        {
            _mobiles.Clear();
        }

        public void Init(List<Mobile> newList)
        {
            _mobiles = newList;
        }

        public void Sort()
        {
            _mobiles.Sort();
        }

        public Mobile Peep()
        {
            Mobile item = _mobiles[0];
            return item;
        }
    }
}
