using System;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter_10_Example_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            Task<int> output = Task.Run(()=>SomeMethod());
            Console.WriteLine(output.Result);
            Console.Read();
        }

        private static int SomeMethod()
        {
            Thread.Sleep(2000);
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            return 100;
        }
    }
}
