using System;
using System.Threading;

namespace Chapter_11_Example_2
{
    public class MyThreadClass
    {
        public void MyThreadMethodA()
        {
            Console.WriteLine("Inside MyThreadMethodA..");

            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine(x);
                Thread.Sleep(100);
            }
        }
        public void MyThreadMethodB()
        {
            Console.WriteLine("Inside MyThreadMethodB..");

            for (int x = 10; x > 0; x--)
            {
                Console.WriteLine(x);
                Thread.Sleep(100);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyThreadClass obj = new MyThreadClass();
            Thread threadObjA = new Thread(new ThreadStart(obj.MyThreadMethodA));
            Thread threadObjB = new Thread(new ThreadStart(obj.MyThreadMethodB));
            threadObjA.Start();
            threadObjA.Join();
            threadObjB.Start();
            Console.Read();
        }
    }
}
