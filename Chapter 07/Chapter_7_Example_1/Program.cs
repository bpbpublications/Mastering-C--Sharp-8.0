using System;
using System.Collections;

namespace Chapter_7_Example_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 100;
            double d = 20.5;
            string s = "Joydip Kanjilal";
            ArrayList arrayList = new ArrayList();
            arrayList.Add(s);
            arrayList.Add(i);
            arrayList.Add(d);

            for (int index = 0; index < arrayList.Count; index++)
                Console.WriteLine(arrayList[index]);

            Console.Read();
        }
    }
}
