using System;
using System.Threading;

namespace Chapter_11_Example_5
{
    class ThreadSafe
    {
        private static readonly object lockObj = new object();
        static int i = 10, j = 1;
        static void Display()
        {
            if (j != 0)
            {
                Monitor.Enter(lockObj);
                Console.WriteLine(i / j);
                j = 0;
                Monitor.Exit(lockObj);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
