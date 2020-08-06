using System;

namespace Chapter_2_Example_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //for(int i=1; i<=10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine(i++);
            //}

            int i = 1;
            do
            {
              Console.WriteLine(i++);
            } while (i <= 10);

            Console.Read();
        }
    }
}
