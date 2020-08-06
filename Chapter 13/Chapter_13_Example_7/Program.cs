using System;
using System.Text.RegularExpressions;

namespace Chapter_13_Example_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = "9";

            if(IsInteger(number))
            {
                Console.WriteLine("The input type is an integer");
            }

            Console.Read();
        }

        public static bool IsInteger(string str)
        {
            Regex pattern = new Regex("[^0-9]");
            return !pattern.IsMatch(str);
        }
    }
}