using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication9
{
    class demo
    {
        public void sum(int a, int b)
        { 
            Console.WriteLine("Addition is "+(a+b));        
        }
        public void sum(int a, int b, int c)
        { 
         Console.WriteLine("Addition is "+(a+b+c));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            demo d1 = new demo();
            d1.sum(10, 10);
            d1.sum(10, 10, 10);
            Console.ReadLine();
        }
    }
}
