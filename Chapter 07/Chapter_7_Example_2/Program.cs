using System;
using System.Collections;

namespace Chapter_7_Example_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push("Joydip");
            stack.Push("Sabita");
            stack.Push("Jini");
            stack.Push("Piku");

            while (stack.Count > 0)
                Console.WriteLine(stack.Pop());
            Console.ReadLine();
        }
    }
}
