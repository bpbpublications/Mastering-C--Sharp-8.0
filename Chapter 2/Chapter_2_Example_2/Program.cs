using System;

namespace Chapter_2_Example_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if ((number % 2) == 0)
            {
                Console.WriteLine("{0} is an even number", number);
            }
            else
            {
                Console.WriteLine("{0} is an odd number", number);
            }

            Console.Read();
        }
    }
}
