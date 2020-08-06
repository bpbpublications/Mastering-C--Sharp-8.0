using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Chapter_14_Example_1
{
    class Program
    {

        static void Main(string[] args)
        {
            MainAsync(args);
        }

        static async void MainAsync(string[] args)
        {
            await foreach (var value in GetNumbersAsync())
            {
                Console.WriteLine(value);
            }

            Console.Read();
        }

        private static async IAsyncEnumerable<int> GetNumbersAsync()
        {
            for (int i = 0; i < 10; i++)
            {
                await Task.Delay(10);
                yield return i;
            }
        }
        public void OuterFunction(int x)
        {
            Console.WriteLine("Inside OuterFunction");
            InnerFunction(x);

            static void InnerFunction(int x)
            {
                Console.WriteLine("Insde Inner Function");
            }
        }
    }
}
