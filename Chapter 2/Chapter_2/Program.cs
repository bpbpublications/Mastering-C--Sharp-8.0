using Chapter_2_ClassLib;
using System;

namespace Chapter_2
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Hello World!");
        //    Console.Read();
        //}
        static void Main(string[] args)
        {
            TextManager textManager = new TextManager();
            Console.WriteLine(textManager.GetDisplayMessage());
            Console.Read();
        }
    }
}
