using System;

namespace Chapter_9_Example_4
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
                int i = 10, j = 0; int z = i / j;
                Console.WriteLine("Inside method B");
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
