using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_9_Example_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10, j = 0;
            try
            {
                int z = i / j;
            }

            catch (Exception ex)
            {
                Console.WriteLine
                ("Error occured: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Inside Main()");
            }

            Console.Read();
        }
    }
}
