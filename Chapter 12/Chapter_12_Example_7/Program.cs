using System;
using System.IO;

namespace Chapter_12_Example_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Test.txt";

            if (!File.Exists(path))
            File.Create(path);

            Console.WriteLine("New file created.");
            Console.Read();
        }
    }
}
