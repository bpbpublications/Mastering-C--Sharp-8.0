using System;
using System.IO;

namespace Chapter_12_Example_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Workarea";

            try
            {
                if (Directory.Exists(path))
                {
                    Console.WriteLine("A directory in the same name exists in this location.");
                    return;
                }

                Directory.CreateDirectory(path);
                Console.WriteLine("The directory was created successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occured: {0}", ex.ToString());
            }

            Console.Read();
        }
    }
}
