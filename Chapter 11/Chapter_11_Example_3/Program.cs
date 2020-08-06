using System;
using System.Threading;

namespace Chapter_11_Example_3
{
    public class MyThreadClass
    {
        public void MyThreadMethodA()
        {
            Console.WriteLine("Inside MyThreadMethodA..");
            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine(x);
            }
        }
        public void MyThreadMethodB()
        {
            Console.WriteLine("Inside MyThreadMethodB..");
            for (int x = 5; x > 0; x--)
            {
                Console.WriteLine(x);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyThreadClass obj = new MyThreadClass();
            Thread thread1 = new Thread(new ThreadStart(obj.MyThreadMethodA));
            Thread thread2 = new Thread(new ThreadStart(obj.MyThreadMethodB));
            thread2.Priority = ThreadPriority.Highest;
            thread1.Priority = ThreadPriority.Lowest;
            thread1.Start();
            thread2.Start();            
            Console.Read();
        }
    }
}
