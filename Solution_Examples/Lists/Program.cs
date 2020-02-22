using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp59
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Mobile> phones = new List<Mobile>()
            {
                new Mobile(2020, "iPhone", 15.5f),
                new Mobile (2019, "Android", 23.9f),
                new Mobile(2021, "Google", 30.0f),
                new Mobile(2018, "Nokia", 0.9f)
             };

            //phones.ForEach(mobiles => Console.WriteLine(mobiles));

            MyMobileStack stack = new MyMobileStack();
            stack.Init(phones);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peep());
            
        }
    }


}
