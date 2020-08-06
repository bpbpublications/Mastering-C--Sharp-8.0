using System;
using System.IO;

namespace Chapter_12_Example_9
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Test.txt";
            FileInfo fileInfo = new FileInfo(path);
            StreamWriter streamWriter = fileInfo.CreateText();
            streamWriter.WriteLine("This is a new text file.");
            Console.WriteLine("A new text file has been created.");
            streamWriter.Close();
            Console.Read();
        }
    }
}
