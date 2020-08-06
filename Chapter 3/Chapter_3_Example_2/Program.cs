using System;

namespace Chapter_3_Example_2
{
    class MyClass
    {
        public int x;
        public int y;

        public MyClass()
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
            Console.WriteLine("x = " + myClass.x);
            Console.WriteLine("y = " + myClass.y);
            Console.Read();
        }
    }

}
