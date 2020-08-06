using System;

namespace Chapter_2_Example_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];

            for (int index = 0; index < 10; index++)
                numbers[index] = index + 1;

            for (int index = 0; index < 10; index++)
                Console.WriteLine(numbers[index]);

            Console.Read();
        }
    }
}
