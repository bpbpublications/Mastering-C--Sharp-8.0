using System;

namespace Chapter_3_Example_8
{
    public class Base
    {
        public Base()
        {
            Console.WriteLine("Base class constructor");
        }
    }

    public class Derived : Base
    {
        public Derived()
        {
            Console.WriteLine("Derived class constructor");
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
