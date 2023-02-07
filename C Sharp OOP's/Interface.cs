using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interface_Program
{
    interface demo //Declaration of interface
    {
        void show(); //abstract Method Declaration
    }
    class demo1 : demo //Inheriting interface or implementing it
    {
        public void show() //Defination of abstract method
        {
            Console.WriteLine("Demostration Of Interface");
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
