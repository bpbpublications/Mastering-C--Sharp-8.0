using System;

namespace Chapter_3_Example_7
{
    //Protected constructor
    public class Base
    {
        protected Base()
        {
            Console.WriteLine("Protected constructor in the Base class called.");
        }
    }

    public class Derived : Base
    {
        public Derived()
        {
            Console.WriteLine("Default constructor in the Derived class called.");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Derived derived = new Derived();
            Console.Read();
        }
    }
}
