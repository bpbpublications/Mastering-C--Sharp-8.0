using System;

namespace Chapter_3_Example_5
{
    class MyStaticClass
    {
        public static string MyText { get; set; }
        static MyStaticClass()
        {
            Console.WriteLine("Static Constructor executed.");
        }
        public static int MyInteger
        {
            get; set;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyStaticClass.MyText = "Hello World!";
            MyStaticClass.MyInteger = 10;
            Console.Read();
        }
    }
}
