using System;
using System.IO;

namespace Chapter_12_Example_3
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
                    Console.WriteLine("The directory was created at: "+Directory.GetCreationTime(path).ToShortTimeString());
                    return;
                }                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occured: {0}", ex.ToString());
            }

            Console.Read();
        }
    }
}
