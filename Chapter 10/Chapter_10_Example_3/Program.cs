using System;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter_10_Example_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The managed thread Id inside Main is: "+Thread.CurrentThread.ManagedThreadId);

            Task<int> output1 = Task.Run(() => SomeMethod());
            Task<int> output2 = Task.Run(() => SomeMethod());
            Task<int> output3 = Task.Run(() => SomeMethod());
            Task<int> output4 = Task.Run(() => SomeMethod());
            Task<int> output5 = Task.Run(() => SomeMethod());
            Task.WaitAll(output1, output2, output3, output4, output5);

            Console.Read();
        }

        private static int SomeMethod()
        {
            Thread.Sleep(2000);
            Console.WriteLine("The managed thread Id inside SomeMethod is: "+Thread.CurrentThread.ManagedThreadId);
            return 100;
        }
    }
}
