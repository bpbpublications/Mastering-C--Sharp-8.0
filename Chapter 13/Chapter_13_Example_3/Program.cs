using System;

namespace Chapter_13_Example_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int Sum(int x, int y)
            {
                return x + y;
            }

            Console.WriteLine(Sum(10, 20));

            Console.Read();
        }
    }
}
