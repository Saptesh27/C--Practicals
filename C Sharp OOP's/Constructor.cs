using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Constructor
{
    class demo
    {
        public int c;
        public demo() //Default Constructor
        {
            Console.WriteLine("Default Constructor Called");
        }

        public demo(int a, int b) //Parameterize Constructor
        {
            c = a+b;
            Console.WriteLine("Parameterize Constructor Addition is " + c);
        }

        public demo(demo d2) //Copy Constructor
        {
            int a = d2.c; //Copied Value from d2 object
            Console.WriteLine(a);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            demo d1 = new demo();
            demo d2 = new demo(10, 10);
            demo d3 = new demo(d2);
            Console.ReadLine();
        }
    }
}
