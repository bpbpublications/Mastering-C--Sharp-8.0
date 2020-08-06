using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_9_Example_5
{
    class Program
    {

        static void Method_A()
        {
            try
            {
                Console.WriteLine("Inside method A");
                Method_B();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void Method_B()
        {
            try
            {
                Console.WriteLine("Inside method B");
                int i = 10, j = 0; int z = i / j;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        static void Main(string[] args)
        {
            Method_A();
            Console.Read();
        }
    }
}
