#define Version_8
using System;

namespace Chapter_13_Example_6
{
    class Program
    {
        static void Main(string[] args)
        {
            #if (Version_8)
                        Console.WriteLine("Write code here that uses C# 8.0");
            #else
                        Console.WriteLine("Write code here the uses C# 7.0");
            #endif
        }
    }
}