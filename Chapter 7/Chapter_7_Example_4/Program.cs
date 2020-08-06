using System;
using System.Collections;

namespace Chapter_7_Example_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashTable = new Hashtable();
            hashTable.Add("001", "Joydip");
            hashTable.Add("002", "Sabita");
            hashTable.Add("003", "Jini");
            hashTable.Add("004", "Piku");
            hashTable.Add("005", "Sathi");

            Console.WriteLine("The keys are:--");

            foreach (var key in hashTable.Keys)
            {
                Console.WriteLine(key);
            }
                        
            Console.WriteLine(hashTable["002"].ToString());

            Console.Read();
        }
    }
}
