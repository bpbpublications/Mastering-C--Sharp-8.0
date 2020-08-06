using System;
using System.Collections;

namespace Chapter_7_Example_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue("Joydip");
            queue.Enqueue("Sabita");
            queue.Enqueue("Jini");
            queue.Enqueue("Piku");
            queue.Enqueue("Sathi");

            while (queue.Count > 0)
                Console.WriteLine(queue.Dequeue());
            Console.ReadLine();
        }
    }
}
