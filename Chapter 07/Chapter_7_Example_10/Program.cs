using System;
using System.Collections.Concurrent;

namespace Chapter_7_Example_10
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcurrentStack<int> concurrentStack = new ConcurrentStack<int>();

            for(int i=0; i<10; i++)
                concurrentStack.Push(i);

            if (concurrentStack.IsEmpty)
            {
                Console.WriteLine("The stack is empty!");
            }
            else
            {
                int result;

                while(concurrentStack.TryPop(out result))
                {
                    Console.WriteLine(result);
                }
            }

            Console.Read();
        }
    }
}
