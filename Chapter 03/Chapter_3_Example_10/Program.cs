using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_3_Example_10
{
    class A
    {
        public A()
        {
            System.Console.WriteLine("A's constructor is called");
        }
        ~A()
        {
            System.Console.WriteLine("A's destructor is called");
        }
    }
    class B : A
    {
        public B()
        {
            System.Console.WriteLine("B's constructor is called");
        }
        ~B()
        {
            System.Console.WriteLine("B's destructor is called");
        }
    }
    class C : B
    {
        public C()
        {
            System.Console.WriteLine("C's constructor is called");
        }
        ~C()
        {
            System.Console.WriteLine("C's destructor is called");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            C obj = new C();
            Console.Read();
        }
    }
}
