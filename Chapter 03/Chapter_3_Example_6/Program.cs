using System;

namespace Chapter_3_Example_6
{
    class MyClass
    {
        static MyClass()
        {
            Console.WriteLine("Static Constructor executed.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass1 = new MyClass();
            MyClass myClass2 = new MyClass();
            Console.Read();
        }
    }
}
