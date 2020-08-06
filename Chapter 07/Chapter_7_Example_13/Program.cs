using System;
using System.Collections.Generic;

namespace Chapter_7_Example_13
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> hashSet = new HashSet<int>();

            for (int i = 0; i < 10; i++)
            {
                hashSet.Add(i);
            }

            foreach (int i in hashSet)
            {
                Console.WriteLine(i);
            }

            Console.Read();
        }
    }
}
