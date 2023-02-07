using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Method_Overriding
{
    class demo

    {
        public virtual void show() //virtual keyword in parent class

        {
            Console.WriteLine("Base Class...");        
        }
    }

    class demo1 : demo
    {
        public override void show() //override keyword in child class
        {
            Console.WriteLine("Derived  class...");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            demo1 d1 = new demo1();
            d1.show();
            Console.ReadLine();
        }
    }
}
