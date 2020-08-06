using System;

namespace Chapter_3_Example_9
{
    public class Base
    {
        public Base()
        {
            Console.WriteLine("Base class constructor");
        }

        ~Base()
        {
            Console.WriteLine("Base class destructor");
        }
    }
    public class Derived : Base
    {
        public Derived()
        {
            Console.WriteLine("Derived class constructor");
        }
        ~Derived()
        {
            Console.WriteLine("Derived class destructor");
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
