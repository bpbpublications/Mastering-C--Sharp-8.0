using System;

namespace Chapter_13_Example_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int? x = 10;

            if (x.HasValue)
            {
                Console.WriteLine("The variable contains non-nullable value.");
            }

            else
            {
                Console.WriteLine("The variable contains null value.");
            }

            Console.Read();
        }
    }
}
