using System;
using System.Collections;

namespace Chapter_7_Example_5
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

            Console.WriteLine("The keys stored in the Hashtable are:--");

            foreach (var key in hashTable.Keys)
            {
                Console.WriteLine(key);
            }

            IDictionaryEnumerator enumerator = hashTable.GetEnumerator();

            Console.WriteLine("The values stored in the Hashtable are:--");

            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Value.ToString());
            }

            Console.Read();
        }
    }
}
