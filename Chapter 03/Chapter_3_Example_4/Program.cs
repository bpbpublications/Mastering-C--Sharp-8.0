using System;

namespace Chapter_3_Example_4
{
    class MyClass
    {
        static MyClass()
        {
            Console.WriteLine("Static constructor");
        }
        public MyClass()
        {
            Console.WriteLine("Default constructor");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            Console.Read();
        }
    }
}
