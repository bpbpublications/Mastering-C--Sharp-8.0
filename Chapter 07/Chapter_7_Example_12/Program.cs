using System;
using System.Collections.Generic;

namespace Chapter_7_Example_12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<int, string> dictionary = new Dictionary<int, string>();
            //dictionary.Add(1, "A");
            //dictionary.Add(2, "B");
            //dictionary.Add(3, "C");

            IDictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(new KeyValuePair<int, string>(1, "A"));
            dictionary.Add(new KeyValuePair<int, string>(2, "B"));
            dictionary.Add(new KeyValuePair<int, string>(3, "C"));

            foreach (KeyValuePair<int, string> item in dictionary)
            {
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
            }

            Console.Read();
        }
    }
}
