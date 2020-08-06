using System;
using System.Collections;

namespace Chapter_7_Example_6
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList sortedList = new SortedList();
            sortedList.Add("001", "Joydip");
            sortedList.Add("002", "Sabita");
            sortedList.Add("005", "Sathi");
            sortedList.Add("003", "Jini");
            sortedList.Add("004", "Piku");            

            Console.WriteLine("The keys stored in the SortedList are:--");

            foreach (var key in sortedList.Keys)
            {
                Console.WriteLine(key);
            }

            Console.Read();
        }
    }
}
