using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter_10_Example_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<int> output1 = Task.Run(() => SomeMethod());
            Task<int> output2 = Task.Run(() => SomeMethod());
            Task<int> output3 = Task.Run(() => SomeMethod());
            Task<int> output4 = Task.Run(() => SomeMethod());
            Task<int> output5 = Task.Run(() => SomeMethod());

            var taskList = new List<Task>();
            taskList.Add(output1);
            taskList.Add(output2);
            taskList.Add(output3);
            taskList.Add(output4);
            taskList.Add(output5);

            var result = Task.WhenAll(taskList).ContinueWith(t => {

                Console.WriteLine("All tasks have been completed");

            });

            Console.Read();
        }

        private static int SomeMethod()
        {
            Thread.Sleep(1000);
            return Thread.CurrentThread.ManagedThreadId;
        }
    }
}
