using System;
using System.Collections.Generic;

namespace Chapter_13_Example_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var lstAuthors = new List<Tuple<int, string, string>>
            {
                Tuple.Create(1, "Joydip Kanjilal", "India"),
                Tuple.Create(2, "Anand Naraswamy", "India" ),
                Tuple.Create(3, "Steve Smith", "USA" ),
                Tuple.Create(4, "Davin Campbell", "USA" ),
                Tuple.Create(5, "Michalle Stevens", "USA" ),
            };

            foreach (Tuple<int, string, string> tuple in lstAuthors)
            {
                Console.WriteLine(tuple.Item2);
            }

            Console.Read();
        }
    }
}
