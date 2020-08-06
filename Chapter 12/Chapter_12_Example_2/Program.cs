using System;
using System.IO;

namespace Chapter_12_Example_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Workarea";

            try
            {
                if (!Directory.Exists(path))
                {
                    Console.WriteLine("Directory not found.");
                    return;
                }

                Directory.Delete(path, true);
                Console.WriteLine("The directory and its subdirectories and files was deleted successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occured: {0}", ex.ToString());
            }

            Console.Read();
        }
    }
}