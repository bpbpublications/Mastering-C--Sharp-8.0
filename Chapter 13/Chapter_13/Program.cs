using System;

namespace Chapter_13
{
    class Program
    {
        static void PrintData(string str, int i)
        {
            Console.WriteLine("{0} {1}", str, i);
        }
        static void Main(string[] args)
        {
            Tuple<string, int> tuple = new Tuple<string, int>("This is a string data.", 100);
            PrintData(tuple.Item1, tuple.Item2);

            //Tuple.Create(1, 2, 3, 4, 5, 6, 7, Tuple.Create(100,200,300));
        }
    }
}
