using System;

namespace Chapter_4_Example_2
{
    class Program
    {
        class Base
        {
            public virtual void SomeMethod(int someParameter)
            {
                Console.WriteLine("SomeMethod of the Base class called. The value of the parameter passed is: " + someParameter);
            }
        }

        class Derived : Base
        {
            public override void SomeMethod(int anotherParameter)
            {
                Console.WriteLine("SomeMethod of the Derived class called. The value of the parameter passed is: " + anotherParameter);
            }
        }

        static void Main(string[] args)
        {
            Base b = new Derived();
            b.SomeMethod(10);
            Console.Read();
        }
    }
}
