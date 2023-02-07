using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Method_Overriding
{
    class demo

    {
        public void show() 

        {
            Console.WriteLine("Base Class...");        
        }
    }

    class demo1 : demo
    {

        
        public void show() 
        {
            base.show();
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
