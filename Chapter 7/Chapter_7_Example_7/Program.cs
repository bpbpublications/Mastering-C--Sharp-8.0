using System;
using System.Collections;

namespace Chapter_7_Example_7
{
    class Program
    {
        static void Main(string[] args)
        {
            BitArray bitArray = new BitArray(5, true);

            for (int index = 0; index < bitArray.Length; index++)
                Console.WriteLine(bitArray[index]);

            Console.Read();
        }
    }
}
