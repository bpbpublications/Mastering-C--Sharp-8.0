using System;

namespace Chapter_13_Example_5
{
    class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
                int i = 1;
                int* ptr = &i;
                Console.WriteLine("The value of the variable i is : " + i);
                Console.WriteLine ("The memory address of the variable i is : " + (int)ptr);
            }

            Console.Read();
        }
    }
}
