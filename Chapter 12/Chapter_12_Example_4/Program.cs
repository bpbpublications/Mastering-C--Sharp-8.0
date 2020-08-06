using System;
using System.IO;

namespace Chapter_12_Example_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Directory.GetFiles(@"D:\Workarea");

            foreach (string name in array)
            {
                Console.WriteLine(name);
            }

            Console.Read();
        }
    }
}
