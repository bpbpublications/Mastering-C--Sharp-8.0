using System;
using System.IO;

namespace Chapter_12_Example_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Test.txt";
            FileInfo fileInfo = new FileInfo(path);
            StreamWriter streamWriter = fileInfo.AppendText();
            streamWriter.WriteLine("Text has been appended...");
            Console.WriteLine("Text has been appended to a text file.");
            streamWriter.Close();
            Console.Read();
        }
    }
}
