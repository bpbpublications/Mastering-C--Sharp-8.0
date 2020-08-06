using System;
using System.Threading;

namespace Chapter_11_Example_4
{
    class ThreadUnsafe
    {
        static int i = 10, j = 1;

        static void Display()
        {
            if (j != 0)
                Console.WriteLine(i / j);
            j = 0;
        }
    }

    class ThreadSafe
    {
        private static readonly object lockObj = new object();
        static int i = 10, j = 1;
        static void Display()
        {
            if (j != 0)
            {
                lock(lockObj)
                {
                    Console.WriteLine(i / j);
                    j = 0;
                }
            }         
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ThreadPool.SetMinThreads(25, 25);
        }
    }
}
