using System;

namespace Chapter_3_Example_11
{
    struct MyStruct
    {
        int _x;
        public MyStruct(int x)
        {
            _x = x;
            Console.WriteLine("Constructor executed.");
            Console.WriteLine("The value is: " + _x);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            MyStruct myStruct = new MyStruct(10);
            Console.Read();
        }

    }
}
