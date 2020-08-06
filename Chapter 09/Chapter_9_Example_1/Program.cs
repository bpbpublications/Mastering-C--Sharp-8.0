using System;

namespace Chapter_9_Example_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10, j = 0;

            try
            {
                int z = i / j;
            }

            catch (Exception ex)
            {
                Console.WriteLine
                ("Error occurred: " + ex.Message);
            }

            Console.Read();
        }
    }
}
