using System;
using System.Collections.Concurrent;

namespace Chapter_7_Example_11
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcurrentQueue<int> concurrentQueue = new ConcurrentQueue<int>();
            for (int i = 0; i < 10; i++)
                concurrentQueue.Enqueue(i);

            int number;
            while (concurrentQueue.TryDequeue(out number))
            {
                Console.WriteLine(number);
            }

            Console.Read();
        }
    }
}
