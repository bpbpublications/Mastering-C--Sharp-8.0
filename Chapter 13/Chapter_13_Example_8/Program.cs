using System;
using System.Text.RegularExpressions;

namespace Chapter_13_Example_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //string text = "A";
            string text = "5";

            if (IsAlpha(text))
                Console.WriteLine("The input is text");
            else
                Console.WriteLine("The input is not text");

            Console.Read();
        }

        public static bool IsAlpha(string str)
        {
            Regex pattern = new Regex("[^a-zA-Z]");
            return !pattern.IsMatch(str);
        }
    }
}
