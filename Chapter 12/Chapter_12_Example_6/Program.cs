using System;
using System.IO;

namespace Chapter_12_Example_6
{
    class Program
    {
        static void Main(string[] args)
        {
            DriveInfo driveInfo = new DriveInfo(@"D:\");
            Console.WriteLine("Total free space: "+driveInfo.TotalFreeSpace);
            Console.WriteLine("Volume label: " + driveInfo.VolumeLabel);

            DirectoryInfo directoryInfo = driveInfo.RootDirectory;
            Console.WriteLine(directoryInfo.Attributes.ToString());

            Console.Read();
        }
    }
}
