using System;
using System.Threading;

namespace Chapter_11_Example_1
{
    class Program
    {
        static void Main()
        {
            Thread t = new Thread(new ThreadStart(SomeThreadMethod));
            t.Start();

            Console.WriteLine("The thread’s state is: " + t.ThreadState.ToString());
            //t.IsBackground = true;
            Console.Read();
        }
        static void SomeThreadMethod()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
