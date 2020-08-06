using System;

namespace Chapter_14
{

    //interface ILogger
    //{
    //    void Initialize()
    //    {
    //        Console.WriteLine("Working with C# 8!");
    //    }
    //}
    class Program
    {
        static void Main(string[] args)
        {
            string? nullableText = null;
            int length = GetTextLength(nullableText);

            Console.WriteLine(length);
            Console.Read();
        }      
        public static int GetTextLength(string? bar)
        {
             if (!string.IsNullOrEmpty(bar))
             {
                  var length = bar!.Length;
                  return length;
             }

            return -1;
        }
    }
}
