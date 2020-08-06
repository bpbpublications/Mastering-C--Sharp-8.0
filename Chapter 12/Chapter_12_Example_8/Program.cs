using System;
using System.IO;

namespace Chapter_12_Example_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Test.txt";

            if (File.Exists(path))
            {
                Console.WriteLine(File.GetCreationTime(path).ToLongTimeString());
                Console.WriteLine(File.GetLastAccessTime(path).ToLongTimeString());
            }

            Console.Read();
        }
    }
}
