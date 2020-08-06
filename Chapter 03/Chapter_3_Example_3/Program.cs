using System;

namespace Chapter_3_Example_3
{
    class MyClass
    {
        public static int x;
        public static int y;

        static MyClass()
        {
            x = 0;
            y = 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            Console.WriteLine("x = " + MyClass.x);
            Console.WriteLine("y = " + MyClass.y);
            Console.Read();
        }
    }

}
